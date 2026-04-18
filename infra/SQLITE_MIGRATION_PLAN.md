# GatekeeperDO SQLite Migration Plan

## Status: RECOMMENDED — Migrate

## 1. Current Architecture

### In-Memory JSON + R2 Persistence
- **State model**: `this.db` holds all 7 collections as in-memory JS arrays
- **Persistence**: Every mutation serializes the entire `this.db` object to R2 (`db/prtask.json`)
- **Mutation log**: Separate R2 key (`db/mutation-log.json`) stores up to 10,000 entries
- **Snapshot timestamp**: R2 key (`db/snapshot-timestamp.json`) for catchup sync
- **Cold start**: `loadFromR2()` fetches all 3 R2 objects, parses JSON, hydrates memory

### Current Pain Points
1. **Full-state R2 writes on every mutation** — O(N) serialization + network round-trip to R2 on every insert/update/delete
2. **Cold start latency** — 3x R2 GET + JSON parse before first request can be served
3. **No query indexing** — All filters are O(N) linear scans over JS arrays
4. **No transactional safety** — If the DO crashes between mutation and `persistToR2()`, data is lost
5. **Mutation log is a JSON blob** — Must serialize/deserialize entire log on every mutation

### 7 Collections
| Collection | Purpose | Typical Size |
|---|---|---|
| `users` | User profiles | Small (<1000) |
| `tasks` | Task listings | Medium |
| `pull_requests` | PR submissions | Medium |
| `payments` | Payment records | Small |
| `achievements` | User achievements | Small |
| `leaderboard` | XP rankings | Small |
| `audit_log` | Audit entries | Large (unbounded) |

## 2. Proposed Architecture: DO SQLite + R2 for Blobs

### wrangler.toml
Already configured correctly:
```toml
[[migrations]]
tag = "v1"
new_sqlite_classes = ["GatekeeperDO"]
```

### Storage Split
| Data | Storage | Reason |
|---|---|---|
| 7 collections (CRUD) | DO SQLite (`ctx.storage.sql`) | Zero-latency, transactional, indexed |
| Full snapshot export | R2 (`db/prtask.json`) | External API access, daily rebuild |
| Audit archive | R2 + Analytics Engine | Long-term retention, compliance |
| Avatars, diffs | R2 (unchanged) | Binary blobs |

### Key Benefits
- **Zero-latency reads**: SQLite is co-located in-thread — microsecond queries vs R2 round-trips
- **Indexed queries**: SQL indexes on `id`, `status`, `task_id` etc. — O(log N) vs O(N)
- **Transactional writes**: `transactionSync()` guarantees atomicity — no partial writes
- **Incremental writes**: Only the changed row is written, not the entire DB
- **Point-in-time recovery**: Restore to any point in the past 30 days via PITR API
- **No cold start hydration**: SQLite is persisted by the runtime — no `loadFromR2()` needed
- **10 GB per DO**: Far exceeds current data size

## 3. SQLite Schema Design

```sql
-- Users
CREATE TABLE IF NOT EXISTS users (
  id TEXT PRIMARY KEY,
  username TEXT,
  email TEXT,
  avatar_url TEXT,
  provider TEXT,
  role TEXT DEFAULT 'Developer',
  created_at TEXT NOT NULL,
  updated_at TEXT NOT NULL
);

-- Tasks
CREATE TABLE IF NOT EXISTS tasks (
  id TEXT PRIMARY KEY,
  client_id TEXT,
  title TEXT NOT NULL,
  description TEXT DEFAULT '',
  repo_url TEXT DEFAULT '',
  complexity TEXT DEFAULT 'Medium',
  bounty_amount_cents INTEGER DEFAULT 10000,
  status TEXT DEFAULT 'Open',
  created_at TEXT NOT NULL,
  updated_at TEXT NOT NULL
);
CREATE INDEX IF NOT EXISTS idx_tasks_status ON tasks(status);
CREATE INDEX IF NOT EXISTS idx_tasks_client_id ON tasks(client_id);

-- Pull Requests
CREATE TABLE IF NOT EXISTS pull_requests (
  id TEXT PRIMARY KEY,
  task_id TEXT NOT NULL,
  author_id TEXT,
  title TEXT,
  description TEXT DEFAULT '',
  status TEXT DEFAULT 'Open',
  diff_key TEXT DEFAULT '',
  created_at TEXT NOT NULL,
  updated_at TEXT NOT NULL
);
CREATE INDEX IF NOT EXISTS idx_prs_task_id ON pull_requests(task_id);
CREATE INDEX IF NOT EXISTS idx_prs_status ON pull_requests(status);

-- Payments
CREATE TABLE IF NOT EXISTS payments (
  id TEXT PRIMARY KEY,
  task_id TEXT,
  pr_id TEXT,
  payer_id TEXT,
  payee_id TEXT,
  amount_cents INTEGER,
  currency TEXT DEFAULT 'PHP',
  status TEXT DEFAULT 'Pending',
  provider TEXT,
  reference_id TEXT,
  created_at TEXT NOT NULL,
  updated_at TEXT NOT NULL
);

-- Achievements
CREATE TABLE IF NOT EXISTS achievements (
  id TEXT PRIMARY KEY,
  user_id TEXT,
  achievement_type TEXT,
  title TEXT,
  description TEXT DEFAULT '',
  xp_awarded INTEGER DEFAULT 0,
  created_at TEXT NOT NULL,
  updated_at TEXT NOT NULL
);
CREATE INDEX IF NOT EXISTS idx_achievements_user_id ON achievements(user_id);

-- Leaderboard
CREATE TABLE IF NOT EXISTS leaderboard (
  id TEXT PRIMARY KEY,
  user_id TEXT UNIQUE,
  username TEXT,
  total_xp INTEGER DEFAULT 0,
  tasks_completed INTEGER DEFAULT 0,
  prs_merged INTEGER DEFAULT 0,
  created_at TEXT NOT NULL,
  updated_at TEXT NOT NULL
);
CREATE INDEX IF NOT EXISTS idx_leaderboard_xp ON leaderboard(total_xp DESC);

-- Audit Log
CREATE TABLE IF NOT EXISTS audit_log (
  id TEXT PRIMARY KEY,
  user_id TEXT,
  username TEXT,
  collection TEXT NOT NULL,
  operation TEXT NOT NULL,
  record_id TEXT,
  timestamp TEXT NOT NULL
);
CREATE INDEX IF NOT EXISTS idx_audit_collection ON audit_log(collection);
CREATE INDEX IF NOT EXISTS idx_audit_timestamp ON audit_log(timestamp DESC);

-- Mutation Log (for WebSocket catchup sync)
CREATE TABLE IF NOT EXISTS mutation_log (
  seq INTEGER PRIMARY KEY AUTOINCREMENT,
  timestamp TEXT NOT NULL,
  collection TEXT NOT NULL,
  operation TEXT NOT NULL,
  data TEXT NOT NULL
);
CREATE INDEX IF NOT EXISTS idx_mutation_log_timestamp ON mutation_log(timestamp);
```

## 4. Migration Steps

### Step 1: Schema Initialization
Add `initSchema()` method to GatekeeperDO constructor that runs `CREATE TABLE IF NOT EXISTS` statements. SQLite tables are created lazily on first access.

### Step 2: Refactor GatekeeperDO Methods

| Current Method | Replace With |
|---|---|
| `loadFromR2()` | `initSchema()` — no data loading needed |
| `ensureLoaded()` | `ensureSchema()` — just ensure tables exist |
| `persistToR2()` | Remove — SQLite auto-persists |
| `persistMutationLog()` | Remove — SQLite auto-persists |
| `this.db[collection]` array ops | `this.sql.exec()` SQL queries |
| `Array.filter()` for queries | `SELECT ... WHERE` with SQL indexes |
| `Array.push()` for inserts | `INSERT INTO` |
| `Array.findIndex()` + splice for delete | `DELETE FROM ... WHERE id = ?` |

### Step 3: Keep R2 for Snapshot Export
The `/api/snapshot` endpoint should build a JSON snapshot from SQLite and optionally cache to R2 for the daily rebuild pipeline.

### Step 4: Data Migration (One-Time)
On first load after deployment, check if R2 data exists but SQLite tables are empty. If so, import R2 data into SQLite tables, then mark migration complete.

### Step 5: wrangler.toml Changes
No changes needed — `new_sqlite_classes = ["GatekeeperDO"]` is already configured.

## 5. Performance Comparison

| Operation | Current (R2 JSON) | Proposed (DO SQLite) |
|---|---|---|
| Cold start | ~200-500ms (3x R2 GET + JSON parse) | ~0ms (SQLite auto-loaded by runtime) |
| Read query | O(N) array scan | O(log N) indexed SQL query |
| Single insert | Full JSON serialize + R2 PUT (~50-200ms) | Single row INSERT (~microseconds) |
| Single update | Full JSON serialize + R2 PUT (~50-200ms) | Single row UPDATE (~microseconds) |
| Single delete | Full JSON serialize + R2 PUT (~50-200ms) | Single row DELETE (~microseconds) |
| Mutation log append | Full JSON serialize + R2 PUT | Single row INSERT (~microseconds) |
| Concurrent safety | None (race conditions possible) | SQLite serialization (ACID) |
| Data recovery | Manual R2 restore | PITR — any point in 30 days |

### Estimated Latency Improvement
- **Writes**: 100-1000x faster (microseconds vs R2 round-trip)
- **Reads**: 10-100x faster for filtered queries (index scan vs linear scan)
- **Cold start**: Eliminated entirely (no `loadFromR2()`)

## 6. Risk Assessment

### Critical Constraint (Addressed)
- **KV-to-SQLite migration is not supported** — You cannot change an existing KV-backed DO class to SQLite via a later `new_sqlite_classes` migration. Options would be: (a) deploy a new class (e.g., GatekeeperDOv2), or (b) use `new_sqlite_classes` from the very first migration.
- **Our case: NOT affected** — GatekeeperDO's `v1` migration already uses `new_sqlite_classes`, meaning it was SQLite-backed from the start. No class rename or v2 migration is needed.

### Critical Constraint (Addressed)
- **KV-to-SQLite migration is not supported** — You cannot change an existing KV-backed DO class to SQLite via a later `new_sqlite_classes` migration. Options would be: (a) deploy a new class (e.g., GatekeeperDOv2), or (b) use `new_sqlite_classes` from the very first migration.
- **Our case: NOT affected** — GatekeeperDO's `v1` migration already uses `new_sqlite_classes`, meaning it was SQLite-backed from the start. No class rename or v2 migration is needed.

### Critical Constraint (Addressed)
- **KV-to-SQLite migration is not supported** — You cannot change an existing KV-backed DO class to SQLite via a later `new_sqlite_classes` migration. Options would be: (a) deploy a new class (e.g., GatekeeperDOv2), or (b) use `new_sqlite_classes` from the very first migration.
- **Our case: NOT affected** — GatekeeperDO's `v1` migration already uses `new_sqlite_classes`, meaning it was SQLite-backed from the start. No class rename or v2 migration is needed.

### Critical Constraint (Addressed)
- **KV-to-SQLite migration is not supported** — You cannot change an existing KV-backed DO class to SQLite via a later `new_sqlite_classes` migration. Options would be: (a) deploy a new class (e.g., GatekeeperDOv2), or (b) use `new_sqlite_classes` from the very first migration.
- **Our case: NOT affected** — GatekeeperDO's `v1` migration already uses `new_sqlite_classes`, meaning it was SQLite-backed from the start. No class rename or v2 migration is needed.

### Low Risk
- **Schema is additive** — `CREATE TABLE IF NOT EXISTS` is safe to re-run
- **wrangler.toml already configured** — No migration tag changes needed
- **SQLite is GA** — Production-ready since April 2025, 10GB per DO
- **PITR provides safety net** — 30-day point-in-time recovery

### Medium Risk
- **One-time data migration** — Must import existing R2 JSON data into SQLite tables. Mitigation: Keep R2 data as backup, run migration in a transaction, verify row counts.
- **Billing starts January 2026** — SQLite storage now incurs charges. Mitigation: Current data size is small; well within free tier (25B rows read, 50M rows written/month included).

### Low Risk (Addressed by Design)
- **Snapshot export** — R2 snapshot still generated for daily rebuild and external API. No change to downstream consumers.
- **WebSocket diff broadcasting** — Unchanged. Mutation → SQLite write → broadcast diff to subscribers.

### Rollback Plan
1. PITR can restore SQLite to any prior state within 30 days
2. R2 snapshot remains as a secondary backup
3. If critical issues found, revert worker.js to R2-based code (R2 data still exists)

## 7. Recommendation

**Migrate.** The GatekeeperDO already has `new_sqlite_classes` configured in wrangler.toml, meaning the SQLite backend is already active. The current code is ignoring this capability by persisting everything to R2. Migrating to `ctx.storage.sql` will:

1. Eliminate cold-start latency (no `loadFromR2()`)
2. Reduce write latency by 100-1000x (no full-state R2 serialization)
3. Add ACID transactional safety (no data loss on crash)
4. Enable indexed queries (O(log N) vs O(N))
5. Provide 30-day point-in-time recovery for free
6. Simplify code (remove `persistToR2`, `persistMutationLog`, `loadFromR2`)

The data size is small and well within SQLite's 10GB limit. The billing impact is negligible given the included free tier. R2 remains for snapshot export, avatars, and diffs — no breaking changes to the external API surface.
