using System.Collections.Concurrent;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using WillowMaze.Server;

var port = 19751;
var dataDir = Path.Combine(AppContext.BaseDirectory, "data");
Directory.CreateDirectory(dataDir);

var builder = WebApplication.CreateSlimBuilder(args);
builder.WebHost.ConfigureKestrel(k =>
{
    k.Listen(IPAddress.Any, port);
});
builder.Logging.SetMinimumLevel(LogLevel.Warning);
var app = builder.Build();
app.UseWebSockets(new WebSocketOptions { KeepAliveInterval = TimeSpan.FromSeconds(30) });

var txnStore = new Store<Transaction>(Path.Combine(dataDir, "transactions.jsonl"));
var vaultStore = new Store<VaultedCard>(Path.Combine(dataDir, "vault.jsonl"));
var custStore = new Store<Customer>(Path.Combine(dataDir, "customers.jsonl"));
var subStore = new Store<Subscription>(Path.Combine(dataDir, "subscriptions.jsonl"));
var auditStore = new Store<AuditEntry>(Path.Combine(dataDir, "audit.jsonl"));

var devices = new ConcurrentDictionary<string, DeviceConn>();
var dashboards = new ConcurrentDictionary<string, WebSocket>();
var serverLog = new ConcurrentQueue<string>();
var latestDeviceStatus = new ConcurrentDictionary<string, string>();
var pendingDeviceCommands = new ConcurrentQueue<string>();
var lastDevicePoll = DateTimeOffset.MinValue;
var startedAt = DateTimeOffset.UtcNow;
var J = new JsonSerializerOptions { PropertyNamingPolicy = null, WriteIndented = false };
var gwName = Environment.GetEnvironmentVariable("WILLOW_GATEWAY") ?? "sandbox";
IGateway gw = gwName.ToLowerInvariant() switch
{
    "pocketpay" => new PocketPayGateway(),
    _ => new SandboxGateway()
};

app.MapGet("/", ctx => Html(ctx, Pages.PaymentHtml()));
app.MapGet("/nfc", ctx => Html(ctx, Pages.NfcHtml()));
app.MapGet("/favicon.ico", () => Results.NoContent());

app.MapPost("/api/device/poll", async (HttpContext ctx) =>
{
    var body = await new StreamReader(ctx.Request.Body).ReadToEndAsync();
    lastDevicePoll = DateTimeOffset.UtcNow;
    Log($"POLL from {ctx.Connection.RemoteIpAddress} body={body.Length}b");

    try
    {
        var node = JsonNode.Parse(body);
        var messages = node?["Messages"]?.AsArray();
        if (messages is not null)
        {
            foreach (var msg in messages)
            {
                if (msg is null) continue;
                var msgStr = msg.ToJsonString();
                HandleDevice("http-poll", msgStr);
            }
        }
    }
    catch { }

    var cmds = new List<string>();
    while (pendingDeviceCommands.TryDequeue(out var cmd)) cmds.Add(cmd);

    return Results.Json(new { Commands = cmds.Select(c => { try { return JsonNode.Parse(c); } catch { return null; } }).Where(c => c is not null).ToArray() }, J);
});

app.MapGet("/api/data", () => Results.Json(new
{
    Port = port, LanIp = GetLanIp(), UptimeSeconds = (int)(DateTimeOffset.UtcNow - startedAt).TotalSeconds,
    Devices = devices.Select(c => new { c.Value.Id, c.Value.ConnectedAt, c.Value.RemoteIp, c.Value.MessageCount, IsOpen = c.Value.Socket.State == WebSocketState.Open })
        .Concat(lastDevicePoll > DateTimeOffset.MinValue ? [new { Id = "http-poll", ConnectedAt = lastDevicePoll, RemoteIp = "poll", MessageCount = 0, IsOpen = (DateTimeOffset.UtcNow - lastDevicePoll).TotalSeconds < 15 }] : []).ToArray(),
    Transactions = txnStore.All.OrderByDescending(t => t.CreatedUtc).Take(200).ToArray(),
    Vault = vaultStore.All.OrderByDescending(v => v.CreatedUtc).ToArray(),
    Customers = custStore.All.OrderByDescending(c => c.CreatedUtc).ToArray(),
    Subscriptions = subStore.All.OrderByDescending(s => s.CreatedUtc).ToArray(),
    Audit = auditStore.All.OrderByDescending(a => a.CreatedUtc).Take(200).ToArray(),
    DeviceStatus = latestDeviceStatus.ToDictionary(x => x.Key, x => x.Value),
    RecentLogs = serverLog.Reverse().Take(200).ToArray()
}, J));

// === Transaction CRUD ===
app.MapPost("/api/txn/{id}/{action}", async (string id, string action, HttpContext ctx) =>
{
    var txn = txnStore.Get(id);
    if (txn is null) return Results.NotFound("Not found");
    var body = await new StreamReader(ctx.Request.Body).ReadToEndAsync();
    JsonNode? jb = null; try { if (!string.IsNullOrEmpty(body)) jb = JsonNode.Parse(body); } catch { }
    var amt = jb?["Amount"]?.GetValue<decimal>() ?? txn.Amount ?? 0;
    var cur = jb?["Currency"]?.GetValue<string>() ?? txn.Currency ?? "PHP";
    txn.Amount = amt > 0 ? amt : txn.Amount; txn.Currency = cur;
    var vc = !string.IsNullOrEmpty(txn.VaultId) ? vaultStore.Get(txn.VaultId) : null;
    var old = txn.Status;
    GatewayResponse? gr;
    switch (action)
    {
        case "authorize":
            if (vc is null) { vc = await AutoVault(txn); txn.VaultId = vc.Id; }
            gr = await gw.AuthorizeAsync(new() { Token = vc.GatewayToken, VaultId = vc.Id, Card = CardFromVault(vc), Amount = amt, Currency = cur, MerchantReference = txn.Id });
            txn.Status = gr.Approved ? "Authorized" : "Declined"; txn.AuthorizationCode = gr.AuthorizationCode;
            break;
        case "capture":
            gr = await gw.CaptureAsync(new() { AuthorizationCode = txn.AuthorizationCode, ReferenceNumber = txn.ReferenceNumber, Token = txn.GatewayToken, Card = vc is not null ? CardFromVault(vc) : new(), Amount = amt, Currency = cur, TipAmount = jb?["TipAmount"]?.GetValue<decimal>() });
            if (gr.Approved) txn.Status = "Captured";
            break;
        case "void":
            gr = await gw.VoidAsync(new() { AuthorizationCode = txn.AuthorizationCode, ReferenceNumber = txn.ReferenceNumber, Token = txn.GatewayToken, Card = vc is not null ? CardFromVault(vc) : new(), Amount = amt, Reason = jb?["Reason"]?.GetValue<string>() });
            if (gr.Approved) txn.Status = "Voided";
            break;
        case "refund":
            gr = await gw.RefundAsync(new() { ReferenceNumber = txn.ReferenceNumber, Token = txn.GatewayToken, Card = vc is not null ? CardFromVault(vc) : new(), Amount = amt, Currency = cur, PartialAmount = jb?["PartialAmount"]?.GetValue<decimal>(), Reason = jb?["Reason"]?.GetValue<string>() });
            if (gr.Approved) txn.Status = "Refunded";
            break;
        case "settle":
            gr = await gw.SettleAsync(new() { ReferenceNumber = txn.ReferenceNumber, Token = txn.GatewayToken, Amount = amt, BatchId = jb?["BatchId"]?.GetValue<string>() });
            if (gr.Approved) txn.Status = "Settled";
            break;
        case "reverse":
            gr = await gw.VoidAsync(new() { AuthorizationCode = txn.AuthorizationCode, ReferenceNumber = txn.ReferenceNumber, Token = txn.GatewayToken, Card = vc is not null ? CardFromVault(vc) : new(), Amount = amt, Reason = "Reversal" });
            if (gr.Approved) txn.Status = "Reversed";
            break;
        case "incremental":
            var addAmt = jb?["AdditionalAmount"]?.GetValue<decimal>() ?? 0;
            gr = await gw.IncrementalAuthAsync(new() { AuthorizationCode = txn.AuthorizationCode, ReferenceNumber = txn.ReferenceNumber, Token = txn.GatewayToken, AdditionalAmount = addAmt, Currency = cur });
            if (gr.Approved) { txn.Amount = (txn.Amount ?? 0) + addAmt; txn.Status = "Authorized"; }
            break;
        case "decline":
            gr = new GatewayResponse { Approved = false, ResponseCode = "05", ResponseMessage = "Manual decline", ReferenceNumber = "MANUAL", ProcessedUtc = DateTimeOffset.UtcNow };
            txn.Status = "Declined";
            break;
        default: return Results.BadRequest("Unknown action");
    }
    txn.ReferenceNumber = gr.ReferenceNumber ?? txn.ReferenceNumber;
    txn.GatewayResponseCode = gr.ResponseCode; txn.GatewayResponseMessage = gr.ResponseMessage;
    txn.GatewayToken = gr.Token ?? txn.GatewayToken; txn.UpdatedUtc = DateTimeOffset.UtcNow;
    txn.History.Add($"{DateTimeOffset.UtcNow:O} {old}->{txn.Status} [{gr.ResponseCode}] {gr.ResponseMessage} auth={gr.AuthorizationCode} ref={gr.ReferenceNumber}");
    txnStore.Upsert(txn); Audit("Txn", id, action, old, $"{txn.Status} [{gr.ResponseCode}] {gr.AuthorizationCode}");
    Log($"TXN [{id}] {old}->{txn.Status} [{gr.ResponseCode}] auth={gr.AuthorizationCode}");
    await Broadcast(new { EventType = "TransactionUpdate", Transaction = txn });
    await RelayToDevices(JsonSerializer.Serialize(new { Command = "TransactionResult", TransactionId = id, Status = txn.Status, AidHex = txn.AidHex, AuthorizationCode = txn.AuthorizationCode, GatewayResponse = gr.ResponseMessage }, J));
    return Results.Json(txn, J);
});

app.MapPost("/api/txn/{id}/vault", async (string id) =>
{
    var txn = txnStore.Get(id); if (txn is null) return Results.NotFound("Not found");
    var card = await AutoVault(txn);
    txn.VaultId = card.Id; txnStore.Upsert(txn);
    Audit("Vault", card.Id, "created", null, $"Active token={card.GatewayToken}");
    Log($"VAULT [{card.Id}] from TXN {txn.Id}");
    await Broadcast(new { EventType = "Refresh" });
    return Results.Json(card, J);
});

app.MapDelete("/api/txn/{id}", (string id) => { Audit("Txn", id, "delete", null, null); txnStore.Remove(id); txnStore.Compact(); return Results.Ok(); });

// === Vault CRUD ===
app.MapGet("/api/vault/{id}", (string id) => { var c = vaultStore.Get(id); return c is null ? Results.NotFound("") : Results.Json(c, J); });

app.MapPost("/api/vault/{id}/{action}", async (string id, string action, HttpContext ctx) =>
{
    var c = vaultStore.Get(id); if (c is null) return Results.NotFound("Not found");
    var body = await new StreamReader(ctx.Request.Body).ReadToEndAsync();
    JsonNode? jb = null; try { if (!string.IsNullOrEmpty(body)) jb = JsonNode.Parse(body); } catch { }
    var old = c.Status;
    GatewayResponse? gr = null;
    switch (action)
    {
        case "verify":
            gr = await gw.VerifyCardAsync(new() { Token = c.GatewayToken, VaultId = c.Id, Card = CardFromVault(c) });
            c.Status = gr.Approved ? "Verified" : old;
            break;
        case "authorize":
            var authAmt = jb?["Amount"]?.GetValue<decimal>() ?? 0;
            var authCur = jb?["Currency"]?.GetValue<string>() ?? "PHP";
            gr = await gw.AuthorizeAsync(new() { Token = c.GatewayToken, VaultId = c.Id, Card = CardFromVault(c), Amount = authAmt, Currency = authCur });
            c.Status = gr.Approved ? "Authorized" : old;
            if (gr.Approved) c.GatewayToken = gr.Token ?? c.GatewayToken;
            break;
        case "charge":
            var chgAmt = jb?["Amount"]?.GetValue<decimal>() ?? 0;
            var chgCur = jb?["Currency"]?.GetValue<string>() ?? "PHP";
            var chgDesc = jb?["Description"]?.GetValue<string>();
            gr = await gw.ChargeVaultAsync(new() { Token = c.GatewayToken, VaultId = c.Id, Card = CardFromVault(c), Amount = chgAmt, Currency = chgCur, Description = chgDesc, CustomerId = c.CustomerId });
            if (gr.Approved)
            {
                var chgTxn = new Transaction { Id = Guid.NewGuid().ToString("N")[..12], DeviceId = "vault", EventType = "VaultCharge", AidHex = c.AidHex, VaultId = c.Id, CustomerId = c.CustomerId, Amount = chgAmt, Currency = chgCur, Status = "Authorized", AuthorizationCode = gr.AuthorizationCode, ReferenceNumber = gr.ReferenceNumber, GatewayResponseCode = gr.ResponseCode, GatewayResponseMessage = gr.ResponseMessage, GatewayToken = c.GatewayToken, ResponsePreview = $"Vault charge {chgAmt} {chgCur}", CreatedUtc = DateTimeOffset.UtcNow };
                chgTxn.History.Add($"{DateTimeOffset.UtcNow:O} Created Authorized [{gr.ResponseCode}] auth={gr.AuthorizationCode}");
                txnStore.Upsert(chgTxn); Audit("Txn", chgTxn.Id, "vault_charge", null, $"Authorized [{gr.ResponseCode}]");
            }
            break;
        case "suspend": c.Status = "Suspended"; break;
        case "activate": c.Status = "Active"; break;
        case "expire": c.Status = "Expired"; break;
        case "flag": c.Status = "Flagged"; break;
        case "delete": c.Status = "Deleted"; break;
        case "update":
            c.CardholderName = jb?["CardholderName"]?.GetValue<string>() ?? c.CardholderName;
            c.Expiry = jb?["Expiry"]?.GetValue<string>() ?? c.Expiry;
            c.CardBrand = jb?["CardBrand"]?.GetValue<string>() ?? c.CardBrand;
            break;
        default: return Results.BadRequest("Unknown action");
    }
    c.UpdatedUtc = DateTimeOffset.UtcNow;
    var gwInfo = gr is not null ? $" [{gr.ResponseCode}] {gr.ResponseMessage} auth={gr.AuthorizationCode}" : "";
    c.History.Add($"{DateTimeOffset.UtcNow:O} {old}->{c.Status} {action}{gwInfo}");
    vaultStore.Upsert(c); Audit("Vault", id, action, old, $"{c.Status}{gwInfo}");
    await Broadcast(new { EventType = "Refresh" });
    return Results.Json(c, J);
});

app.MapPost("/api/vault/{vid}/link/{cid}", async (string vid, string cid) =>
{
    var c = vaultStore.Get(vid); if (c is null || custStore.Get(cid) is null) return Results.NotFound("");
    var old = c.CustomerId; c.CustomerId = cid; c.UpdatedUtc = DateTimeOffset.UtcNow;
    c.History.Add($"{DateTimeOffset.UtcNow:O} linked to {cid}");
    vaultStore.Upsert(c); Audit("Vault", vid, "link", old, cid);
    await Broadcast(new { EventType = "Refresh" });
    return Results.Ok();
});

app.MapDelete("/api/vault/{id}", (string id) => { Audit("Vault", id, "delete", null, null); vaultStore.Remove(id); vaultStore.Compact(); return Results.Ok(); });

// === Customer CRUD ===
app.MapPost("/api/customer", async (HttpContext ctx) =>
{
    var node = JsonNode.Parse(await new StreamReader(ctx.Request.Body).ReadToEndAsync());
    var c = new Customer { Id = $"cust_{Guid.NewGuid().ToString("N")[..8]}", Name = node?["Name"]?.GetValue<string>() ?? "", Email = node?["Email"]?.GetValue<string>() ?? "", Phone = node?["Phone"]?.GetValue<string>() ?? "", CreatedUtc = DateTimeOffset.UtcNow };
    custStore.Upsert(c); Audit("Customer", c.Id, "created", null, c.Name); Log($"CUST [{c.Id}] {c.Name}");
    await Broadcast(new { EventType = "Refresh" });
    return Results.Json(c, J);
});
app.MapPut("/api/customer/{id}", async (string id, HttpContext ctx) =>
{
    var c = custStore.Get(id); if (c is null) return Results.NotFound("");
    var node = JsonNode.Parse(await new StreamReader(ctx.Request.Body).ReadToEndAsync());
    var old = c.Name; c.Name = node?["Name"]?.GetValue<string>() ?? c.Name; c.Email = node?["Email"]?.GetValue<string>() ?? c.Email; c.Phone = node?["Phone"]?.GetValue<string>() ?? c.Phone; c.UpdatedUtc = DateTimeOffset.UtcNow;
    c.History.Add($"{DateTimeOffset.UtcNow:O} updated");
    custStore.Upsert(c); Audit("Customer", id, "update", old, c.Name);
    await Broadcast(new { EventType = "Refresh" });
    return Results.Json(c, J);
});
app.MapDelete("/api/customer/{id}", (string id) => { Audit("Customer", id, "delete", null, null); custStore.Remove(id); custStore.Compact(); return Results.Ok(); });

// === Subscription CRUD ===
app.MapPost("/api/sub", async (HttpContext ctx) =>
{
    var node = JsonNode.Parse(await new StreamReader(ctx.Request.Body).ReadToEndAsync());
    var interval = node?["Interval"]?.GetValue<string>() ?? "Monthly";
    var sub = new Subscription
    {
        Id = $"sub_{Guid.NewGuid().ToString("N")[..8]}", CustomerId = node?["CustomerId"]?.GetValue<string>() ?? "",
        VaultId = node?["VaultId"]?.GetValue<string>() ?? "", Amount = node?["Amount"]?.GetValue<decimal>() ?? 0,
        Currency = node?["Currency"]?.GetValue<string>() ?? "PHP", Interval = interval,
        Description = node?["Description"]?.GetValue<string>() ?? "", Status = "Active",
        NextChargeUtc = DateTimeOffset.UtcNow.AddDays(interval == "Weekly" ? 7 : interval == "Daily" ? 1 : 30),
        CreatedUtc = DateTimeOffset.UtcNow
    };
    subStore.Upsert(sub); Audit("Sub", sub.Id, "created", null, $"{sub.Amount} {sub.Currency} {sub.Interval}");
    Log($"SUB [{sub.Id}] {sub.Amount} {sub.Currency} {sub.Interval}");
    await Broadcast(new { EventType = "Refresh" });
    return Results.Json(sub, J);
});
app.MapPost("/api/sub/{id}/{action}", async (string id, string action) =>
{
    var s = subStore.Get(id); if (s is null) return Results.NotFound("");
    var old = s.Status;
    s.Status = action switch { "pause" => "Paused", "resume" => "Active", "cancel" => "Cancelled", _ => s.Status };
    s.UpdatedUtc = DateTimeOffset.UtcNow; s.History.Add($"{DateTimeOffset.UtcNow:O} {old}->{s.Status}");
    subStore.Upsert(s); Audit("Sub", id, action, old, s.Status);
    await Broadcast(new { EventType = "Refresh" });
    return Results.Json(s, J);
});
app.MapPost("/api/sub/{id}/charge", async (string id) =>
{
    var sub = subStore.Get(id); if (sub is null) return Results.NotFound("");
    var vc = vaultStore.Get(sub.VaultId);
    var gr = await gw.ChargeVaultAsync(new() { Token = vc?.GatewayToken, VaultId = sub.VaultId, Card = vc is not null ? CardFromVault(vc) : new(), Amount = sub.Amount, Currency = sub.Currency, Description = sub.Description, CustomerId = sub.CustomerId, SubscriptionId = sub.Id, IsRecurring = true });
    var txn = new Transaction
    {
        Id = Guid.NewGuid().ToString("N")[..12], DeviceId = "recurring", EventType = "RecurringCharge",
        AidHex = vc?.AidHex, VaultId = sub.VaultId, CustomerId = sub.CustomerId, SubscriptionId = sub.Id,
        Amount = sub.Amount, Currency = sub.Currency, Status = gr.Approved ? "Authorized" : "Declined",
        AuthorizationCode = gr.AuthorizationCode, ReferenceNumber = gr.ReferenceNumber,
        GatewayResponseCode = gr.ResponseCode, GatewayResponseMessage = gr.ResponseMessage,
        GatewayToken = vc?.GatewayToken, ResponsePreview = $"Recurring {sub.Amount} {sub.Currency}",
        CreatedUtc = DateTimeOffset.UtcNow
    };
    txn.History.Add($"{DateTimeOffset.UtcNow:O} RecurringCharge [{gr.ResponseCode}] {gr.ResponseMessage} auth={gr.AuthorizationCode}");
    txnStore.Upsert(txn); Audit("Txn", txn.Id, "recurring_charge", null, $"{txn.Status} [{gr.ResponseCode}]");
    sub.LastChargedUtc = DateTimeOffset.UtcNow; sub.ChargeCount++;
    sub.NextChargeUtc = DateTimeOffset.UtcNow.AddDays(sub.Interval == "Weekly" ? 7 : sub.Interval == "Daily" ? 1 : 30);
    sub.History.Add($"{DateTimeOffset.UtcNow:O} charged {sub.Amount} {sub.Currency} txn={txn.Id} [{gr.ResponseCode}]");
    subStore.Upsert(sub);
    Log($"RECURRING [{txn.Id}] {sub.Amount} {sub.Currency} [{gr.ResponseCode}]");
    await Broadcast(new { EventType = "Refresh" });
    return Results.Json(txn, J);
});
app.MapDelete("/api/sub/{id}", (string id) => { Audit("Sub", id, "delete", null, null); subStore.Remove(id); subStore.Compact(); return Results.Ok(); });

// --- WebSocket: device ---
app.Map("/ws", async context =>
{
    if (!context.WebSockets.IsWebSocketRequest) { context.Response.StatusCode = 400; return; }
    using var ws = await context.WebSockets.AcceptWebSocketAsync();
    var id = Guid.NewGuid().ToString("N")[..8];
    var info = new DeviceConn(id, ws, context.Connection.RemoteIpAddress?.ToString() ?? "?");
    devices[id] = info; Log($"Device+ {id} from {info.RemoteIp}");
    try
    {
        var buf = new byte[8192];
        while (ws.State == WebSocketState.Open)
        {
            var r = await ws.ReceiveAsync(buf, CancellationToken.None);
            if (r.MessageType == WebSocketMessageType.Close) { await ws.CloseAsync(WebSocketCloseStatus.NormalClosure, null, CancellationToken.None); break; }
            info.MessageCount++;
            HandleDevice(id, Encoding.UTF8.GetString(buf, 0, r.Count));
        }
    }
    catch (WebSocketException wex) { Log($"Device {id} WS err: {wex.WebSocketErrorCode} {wex.Message}"); }
    catch (Exception ex) { Log($"Device {id} err: {ex.GetType().Name}: {ex.Message}"); }
    finally { Log($"Device- {id} state={ws.State} close={ws.CloseStatus}:{ws.CloseStatusDescription}"); devices.TryRemove(id, out _); latestDeviceStatus.TryRemove(id, out _); }
});

// --- WebSocket: dashboard ---
app.Map("/ws/dashboard", async context =>
{
    if (!context.WebSockets.IsWebSocketRequest) { context.Response.StatusCode = 400; return; }
    using var ws = await context.WebSockets.AcceptWebSocketAsync();
    var id = Guid.NewGuid().ToString("N")[..8];
    dashboards[id] = ws;
    try
    {
        var buf = new byte[4096];
        while (ws.State == WebSocketState.Open)
        {
            var r = await ws.ReceiveAsync(buf, CancellationToken.None);
            if (r.MessageType == WebSocketMessageType.Close) { await ws.CloseAsync(WebSocketCloseStatus.NormalClosure, null, CancellationToken.None); break; }
            await RelayToDevices(Encoding.UTF8.GetString(buf, 0, r.Count));
        }
    }
    catch (WebSocketException) { }
    finally { dashboards.TryRemove(id, out _); }
});

app.Map("/ws/pocketpay", async context =>
{
    if (!context.WebSockets.IsWebSocketRequest) { context.Response.StatusCode = 400; return; }
    using var ws = await context.WebSockets.AcceptWebSocketAsync();
    var proxy = new PocketPay.Wasm.Server.NativeProxy();
    var handler = new PocketPay.Wasm.Server.WssHandler(ws, proxy);
    Log($"PocketPay WSS client connected");
    await handler.RunAsync(context.RequestAborted);
    Log($"PocketPay WSS client disconnected");
});

Log($"WillowMaze.Server wss://0.0.0.0:{port}/ws | https://localhost:{port}/ | PocketPay ws://0.0.0.0:{port}/ws/pocketpay");
_ = Task.Run(async () => { var lip = GetLanIp(); var b = Encoding.UTF8.GetBytes($"WILLOW:{lip}:{port}"); using var u = new System.Net.Sockets.UdpClient(); u.EnableBroadcast = true; var ep = new IPEndPoint(IPAddress.Broadcast, 19750); while (true) { try { await u.SendAsync(b, ep); } catch { } await Task.Delay(2000); } });
app.Run();

// --- Helpers ---
void HandleDevice(string deviceId, string msg)
{
    try
    {
        var node = JsonNode.Parse(msg);
        var et = node?["EventType"]?.GetValue<string>();
        if (et == "Status") { latestDeviceStatus[deviceId] = msg; _ = BroadcastRaw(msg); return; }
        if (et is "SelectAid" or "GetData" or "Tap" or "Transaction")
        {
            var txn = new Transaction
            {
                Id = Guid.NewGuid().ToString("N")[..12], DeviceId = deviceId, EventType = et!,
                AidHex = node?["AidHex"]?.GetValue<string>(), ResponsePreview = node?["ResponsePreview"]?.GetValue<string>(),
                DeviceTimestamp = node?["DeviceTimestampUtc"]?.GetValue<string>(), RawJson = node?.ToJsonString(),
                Status = "Pending", CardBrand = Brand(node?["AidHex"]?.GetValue<string>()), CreatedUtc = DateTimeOffset.UtcNow
            };
            txnStore.Upsert(txn);
            Log($"TXN+ [{txn.Id}] {et} from {deviceId}");
            _ = Broadcast(new { EventType = "NewTransaction", Transaction = txn });
        }
    }
    catch { }
}

async Task Broadcast(object payload) => await BroadcastRaw(JsonSerializer.Serialize(payload, J));
async Task BroadcastRaw(string msg)
{
    var bytes = Encoding.UTF8.GetBytes(msg); var seg = new ArraySegment<byte>(bytes);
    foreach (var (id, ws) in dashboards) { if (ws.State == WebSocketState.Open) { try { await ws.SendAsync(seg, WebSocketMessageType.Text, true, CancellationToken.None); } catch { dashboards.TryRemove(id, out _); } } }
}
async Task RelayToDevices(string msg)
{
    pendingDeviceCommands.Enqueue(msg);
    while (pendingDeviceCommands.Count > 100) pendingDeviceCommands.TryDequeue(out _);
    var bytes = Encoding.UTF8.GetBytes(msg); var seg = new ArraySegment<byte>(bytes);
    foreach (var (_, d) in devices) { if (d.Socket.State == WebSocketState.Open) { try { await d.Socket.SendAsync(seg, WebSocketMessageType.Text, true, CancellationToken.None); } catch { } } }
}

CardData CardFromVault(VaultedCard v) => new() { MaskedPan = v.TokenMask, Last4 = v.Last4, Expiry = v.Expiry, CardholderName = v.CardholderName, AidHex = v.AidHex, CardBrand = v.CardBrand, Fingerprint = v.Fingerprint, EmvData = v.EmvData };

async Task<VaultedCard> AutoVault(Transaction txn)
{
    var extra = txn.RawJson is not null ? JsonNode.Parse(txn.RawJson)?["Extra"] : null;
    var cd = new CardData
    {
        MaskedPan = extra?["EmvPan"]?.GetValue<string>() ?? Mask(txn.ResponsePreview),
        Last4 = extra?["EmvLast4"]?.GetValue<string>() ?? txn.Id[^4..],
        Expiry = extra?["EmvExpiry"]?.GetValue<string>(),
        CardholderName = extra?["EmvCardholderName"]?.GetValue<string>(),
        AidHex = extra?["EmvAidHex"]?.GetValue<string>() ?? txn.AidHex,
        CardBrand = extra?["EmvCardBrand"]?.GetValue<string>() ?? Brand(txn.AidHex),
        Fingerprint = Fp(txn),
        EmvData = extra?.ToJsonString()
    };
    string? token = null;
    if (gw.SupportsTokenization)
    {
        var tr = await gw.TokenizeAsync(new() { Card = cd });
        token = tr.Token;
    }
    var card = new VaultedCard
    {
        Id = $"vault_{Guid.NewGuid().ToString("N")[..8]}", TransactionId = txn.Id,
        AidHex = cd.AidHex, TokenMask = cd.MaskedPan, Fingerprint = cd.Fingerprint,
        CardBrand = cd.CardBrand, Last4 = cd.Last4, Expiry = cd.Expiry,
        CardholderName = cd.CardholderName, GatewayToken = token,
        EmvData = cd.EmvData, Status = "Active", CreatedUtc = DateTimeOffset.UtcNow
    };
    card.History.Add($"{DateTimeOffset.UtcNow:O} vaulted{(token is not null ? $" token={token}" : " (no token - raw card)")}");
    vaultStore.Upsert(card);
    return card;
}

Task Html(HttpContext ctx, string html) { ctx.Response.ContentType = "text/html; charset=utf-8"; return ctx.Response.WriteAsync(html); }
void Audit(string entityType, string entityId, string action, string? oldVal, string? newVal)
{
    auditStore.Upsert(new AuditEntry { Id = Guid.NewGuid().ToString("N")[..12], EntityType = entityType, EntityId = entityId, Action = action, OldValue = oldVal, NewValue = newVal, CreatedUtc = DateTimeOffset.UtcNow });
}
void Log(string m) { var l = $"[{DateTimeOffset.Now:HH:mm:ss}] {m}"; Console.WriteLine(l); serverLog.Enqueue(l); while (serverLog.Count > 500) serverLog.TryDequeue(out _); }
string GetLanIp() { try { using var s = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Dgram, 0); s.Connect("8.8.8.8", 80); return ((IPEndPoint)s.LocalEndPoint!).Address.ToString(); } catch { return "0.0.0.0"; } }
string Mask(string? s) => string.IsNullOrEmpty(s) ? "****" : s.Length > 8 ? $"{s[..4]}...{s[^4..]}" : "****";
string Fp(Transaction t) => Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(Encoding.UTF8.GetBytes($"{t.AidHex}{t.ResponsePreview}{t.DeviceId}")))[..16];
string Brand(string? aid) => aid?.ToUpperInvariant() switch { var a when a?.StartsWith("A000000003") == true => "Visa", var a when a?.StartsWith("A000000004") == true => "Mastercard", var a when a?.StartsWith("A000000025") == true => "Amex", var a when a?.StartsWith("A000000065") == true => "JCB", _ => "Custom" };

record DeviceConn(string Id, WebSocket Socket, string RemoteIp) { public DateTimeOffset ConnectedAt { get; } = DateTimeOffset.UtcNow; public int MessageCount { get; set; } }
