#!/usr/bin/env node
/**
 * WSS CRUD round-trip test for prtask D1 via Durable Objects.
 *
 * Usage:
 *   node test-wss-crud.mjs [endpoint]
 *
 * Default endpoint: wss://prtask.com/ws
 * For local dev:    node test-wss-crud.mjs ws://localhost:8787/ws
 *
 * Tests CREATE, READ, UPDATE, DELETE on the tasks table, verifying each
 * step via the prtask-db WebSocket protocol.
 */

const endpoint = process.argv[2] || "wss://prtask.com/ws";
let ws;
let msgId = 0;
const pending = new Map();

function nextId() {
  return `test-${++msgId}`;
}

function send(msg) {
  return new Promise((resolve, reject) => {
    const id = nextId();
    msg.id = id;
    pending.set(id, { resolve, reject });
    ws.send(JSON.stringify(msg));
    setTimeout(() => {
      if (pending.has(id)) {
        pending.delete(id);
        reject(new Error(`Timeout waiting for ack on ${id}`));
      }
    }, 10000);
  });
}

function assert(condition, message) {
  if (!condition) throw new Error("ASSERT FAILED: " + message);
}

async function run() {
  const WebSocket = (await import("ws")).default;

  console.log(`Connecting to ${endpoint} ...`);
  ws = new WebSocket(endpoint, ["prtask-db"]);

  await new Promise((resolve, reject) => {
    ws.on("open", resolve);
    ws.on("error", reject);
  });

  console.log(`Connected. Protocol: ${ws.protocol}`);

  ws.on("message", (raw) => {
    const msg = JSON.parse(raw.toString());
    if (msg.id && pending.has(msg.id)) {
      const { resolve, reject } = pending.get(msg.id);
      pending.delete(msg.id);
      if (msg.type === "error") {
        reject(new Error(msg.message));
      } else {
        resolve(msg);
      }
    }
  });

  const testId = crypto.randomUUID();
  const testClientId = "test-client-" + Date.now();

  // ------------------------------------------------------------------
  // 0. SETUP — Insert a test user (FK target for tasks.client_id)
  // ------------------------------------------------------------------
  console.log("\n[0/4] SETUP — creating test user ...");
  const setupResult = await send({
    type: "mutation",
    data: {
      sql: "INSERT OR IGNORE INTO users (id, display_name, email) VALUES (?, ?, ?)",
      params: [testClientId, "Test User", "test@example.com"]
    }
  });
  assert(setupResult.type === "ack", "SETUP should return ack");
  console.log("  SETUP OK");

  // ------------------------------------------------------------------
  // 1. CREATE — Insert a test task
  // ------------------------------------------------------------------
  console.log("[1/4] CREATE ...");
  const createResult = await send({
    type: "mutation",
    channel: "tasks",
    collection: "tasks",
    data: {
      sql: "INSERT INTO tasks (id, client_id, title, description, status, complexity, bounty_amount_cents, created_at) VALUES (?, ?, ?, ?, 'Open', 'Medium', 10000, datetime('now'))",
      params: [testId, testClientId, "WSS CRUD Test Task", "Automated test task"],
      fields: { id: testId }
    }
  });
  assert(createResult.type === "ack", "CREATE should return ack");
  assert(createResult.data.success, "CREATE should succeed");
  console.log("  CREATE OK");

  // ------------------------------------------------------------------
  // 2. READ — Query the task back
  // ------------------------------------------------------------------
  console.log("[2/4] READ ...");
  const readResult = await send({
    type: "query",
    collection: "tasks",
    data: {
      sql: "SELECT * FROM tasks WHERE id = ?",
      params: [testId]
    }
  });
  assert(readResult.type === "ack", "READ should return ack");
  assert(Array.isArray(readResult.data), "READ data should be array");
  assert(readResult.data.length === 1, "READ should return exactly 1 row");
  assert(readResult.data[0].title === "WSS CRUD Test Task", "READ title should match");
  console.log("  READ OK — title:", readResult.data[0].title);

  // ------------------------------------------------------------------
  // 3. UPDATE — Change the title
  // ------------------------------------------------------------------
  console.log("[3/4] UPDATE ...");
  const updateResult = await send({
    type: "mutation",
    channel: "tasks",
    collection: "tasks",
    data: {
      sql: "UPDATE tasks SET title = ? WHERE id = ?",
      params: ["WSS CRUD Test Task (Updated)", testId],
      fields: { id: testId }
    }
  });
  assert(updateResult.type === "ack", "UPDATE should return ack");
  assert(updateResult.data.success, "UPDATE should succeed");

  // Verify update
  const readAfterUpdate = await send({
    type: "query",
    data: {
      sql: "SELECT title FROM tasks WHERE id = ?",
      params: [testId]
    }
  });
  assert(readAfterUpdate.data[0].title === "WSS CRUD Test Task (Updated)", "Updated title should match");
  console.log("  UPDATE OK — new title:", readAfterUpdate.data[0].title);

  // ------------------------------------------------------------------
  // 4. DELETE — Remove the test task
  // ------------------------------------------------------------------
  console.log("[4/4] DELETE ...");
  const deleteResult = await send({
    type: "mutation",
    channel: "tasks",
    collection: "tasks",
    data: {
      sql: "DELETE FROM tasks WHERE id = ?",
      params: [testId],
      fields: { id: testId }
    }
  });
  assert(deleteResult.type === "ack", "DELETE should return ack");
  assert(deleteResult.data.success, "DELETE should succeed");

  // Verify deletion
  const readAfterDelete = await send({
    type: "query",
    data: {
      sql: "SELECT * FROM tasks WHERE id = ?",
      params: [testId]
    }
  });
  assert(readAfterDelete.data.length === 0, "Deleted task should not be found");
  console.log("  DELETE OK — row gone");

  // ------------------------------------------------------------------
  // CLEANUP — Remove test user
  // ------------------------------------------------------------------
  await send({
    type: "mutation",
    data: {
      sql: "DELETE FROM users WHERE id = ?",
      params: [testClientId]
    }
  });
  console.log("  CLEANUP OK — test user removed");

  // ------------------------------------------------------------------
  // Done
  // ------------------------------------------------------------------
  console.log("\nAll 4 CRUD operations passed via WSS.\n");
  ws.close();
  process.exit(0);
}

run().catch((err) => {
  console.error("\nTEST FAILED:", err.message);
  if (ws) ws.close();
  process.exit(1);
});
