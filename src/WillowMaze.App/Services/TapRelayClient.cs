using System.Collections.Concurrent;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace WillowMaze.App.Services;

internal static class TapRelayClient
{
    private static readonly object Sync = new();
    private static string? _serverBaseUrl;
    private static bool _running;
    private static readonly DateTimeOffset _startTime = DateTimeOffset.UtcNow;
    private static readonly ConcurrentQueue<string> OutboundQueue = new();
    private static HttpClient? _http;
    private static HttpClient Http => _http ??= new HttpClient(new SocketsHttpHandler { PooledConnectionLifetime = TimeSpan.Zero, MaxConnectionsPerServer = 1 }) { Timeout = TimeSpan.FromSeconds(30), DefaultRequestHeaders = { ConnectionClose = true } };
    private static readonly JsonSerializerOptions J = new() { WriteIndented = false, PropertyNamingPolicy = null };

    public static event EventHandler? StateChanged;
    public static event EventHandler<TransactionResultEventArgs>? TransactionResultReceived;
    public static string? LastTransactionId { get; private set; }
    public static string? LastTransactionStatus { get; private set; }

    public static string ServerUrl
    {
        get { lock (Sync) { return _serverBaseUrl ?? "(not configured)"; } }
    }

    public static bool IsConnected { get; private set; }

    public static void Configure(string wssUrl)
    {
        lock (Sync)
        {
            var uri = new Uri(wssUrl.Replace("wss://", "http://").Replace("ws://", "http://").Replace("/ws", ""));
            var baseUrl = $"http://{uri.Host}:{uri.Port}";
            if (_serverBaseUrl == baseUrl && _running) return;
            _serverBaseUrl = baseUrl;
        }

        if (!_running)
        {
            _running = true;
            OutboundQueue.Enqueue("{\"EventType\":\"Hello\"}");
            var timer = new System.Timers.Timer(3000);
            timer.Elapsed += (_, _) => { timer.Stop(); PollOnceAsync().ContinueWith(_ => timer.Start()); };
            timer.AutoReset = false;
            timer.Start();
        }
    }

    private static System.Threading.Timer? _pollTimer;

    public static void StartPolling(IDispatcher dispatcher)
    {
        _pollTimer = new System.Threading.Timer(_ => dispatcher.Dispatch(() => _ = PollOnceAsync()), null, TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(3));
    }

    private static async Task PollOnceAsync()
    {
        string? baseUrl;
        lock (Sync) { baseUrl = _serverBaseUrl; }
        if (baseUrl is null) return;

        try
        {
            var messages = new List<string>();
            while (OutboundQueue.TryDequeue(out var msg)) messages.Add(msg);
            if (messages.Count == 0 && IsConnected)
                messages.Add(JsonSerializer.Serialize(new { EventType = "Heartbeat", Uptime = (DateTimeOffset.UtcNow - _startTime).TotalSeconds }, J));

            var body = JsonSerializer.Serialize(new { Messages = messages }, J);
            var content = new ByteArrayContent(Encoding.UTF8.GetBytes(body));
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await Http.PostAsync($"{baseUrl}/api/device/poll", content);

            if (response.IsSuccessStatusCode)
            {
                if (!IsConnected) { IsConnected = true; StatusReporter.Start(); StateChanged?.Invoke(null, EventArgs.Empty); }
                var responseBody = await response.Content.ReadAsStringAsync();
                HandleServerResponse(responseBody);
            }
            else
            {
                if (IsConnected) { IsConnected = false; StateChanged?.Invoke(null, EventArgs.Empty); }
            }
        }
        catch
        {
            if (IsConnected) { IsConnected = false; StateChanged?.Invoke(null, EventArgs.Empty); }
        }
    }

    public static void SendTap(string eventType, string? aidHex, string? responsePreview, object? extra = null)
    {
        var payload = JsonSerializer.Serialize(new
        {
            EventType = eventType, AidHex = aidHex, ResponsePreview = responsePreview,
            DeviceTimestampUtc = DateTimeOffset.UtcNow.ToString("O"), Extra = extra
        }, J);
        OutboundQueue.Enqueue(payload);
        while (OutboundQueue.Count > 50) OutboundQueue.TryDequeue(out _);
    }

    public static void SendStatus(object statusPayload)
    {
        var payload = JsonSerializer.Serialize(new
        {
            EventType = "Status", DeviceTimestampUtc = DateTimeOffset.UtcNow.ToString("O"), Data = statusPayload
        }, J);
        OutboundQueue.Enqueue(payload);
        while (OutboundQueue.Count > 50) OutboundQueue.TryDequeue(out _);
    }

    private static async Task PollLoopAsync()
    {
        while (true)
        {
            try
            {
                string? baseUrl;
                lock (Sync) { baseUrl = _serverBaseUrl; }
                if (baseUrl is null) { await Task.Delay(2000); continue; }

                var messages = new List<string>();
                while (OutboundQueue.TryDequeue(out var msg)) messages.Add(msg);
                if (messages.Count == 0 && IsConnected)
                {
                    messages.Add(JsonSerializer.Serialize(new { EventType = "Heartbeat", Uptime = (DateTimeOffset.UtcNow - _startTime).TotalSeconds }, J));
                }

                var body = JsonSerializer.Serialize(new { Messages = messages }, J);
                var content = new ByteArrayContent(Encoding.UTF8.GetBytes(body));
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var response = await Http.PostAsync($"{baseUrl}/api/device/poll", content);

                if (response.IsSuccessStatusCode)
                {
                    if (!IsConnected) { IsConnected = true; StatusReporter.Start(); StateChanged?.Invoke(null, EventArgs.Empty); }
                    var responseBody = await response.Content.ReadAsStringAsync();
                    HandleServerResponse(responseBody);
                }
                else
                {
                    if (IsConnected) { IsConnected = false; StateChanged?.Invoke(null, EventArgs.Empty); }
                }
            }
            catch (Exception ex)
            {
                if (IsConnected) { IsConnected = false; StateChanged?.Invoke(null, EventArgs.Empty); }
                OutboundQueue.Enqueue(JsonSerializer.Serialize(new { EventType = "PollError", Error = ex.GetType().Name + ": " + ex.Message }, J));
            }

            await Task.Delay(3000);
        }
    }

    private static void HandleServerResponse(string responseBody)
    {
        try
        {
            var node = JsonNode.Parse(responseBody);
            var commands = node?["Commands"]?.AsArray();
            if (commands is null) return;

            foreach (var cmd in commands)
            {
                var command = cmd?["Command"]?.GetValue<string>();
                if (string.IsNullOrEmpty(command)) continue;
                MainThread.BeginInvokeOnMainThread(() => DispatchCommand(command, cmd));
            }
        }
        catch { }
    }

    private static void DispatchCommand(string command, JsonNode? node)
    {
        try
        {
            var svc = IPlatformApplication.Current?.Services.GetService<INfcWorkbenchService>();
            if (svc is null) return;

            _ = command switch
            {
                "StartReader" => svc.StartReaderAsync(),
                "StopReader" => svc.StopReaderAsync(),
                "Refresh" => svc.RefreshAsync(),
                "OpenNfcSettings" => svc.OpenNfcSettingsAsync(),
                "SetPreferredService" => svc.SetPreferredServiceAsync(true),
                "ReleasePreferredService" => svc.SetPreferredServiceAsync(false),
                "EnableObserveMode" => svc.SetObserveModeEnabledAsync(true),
                "DisableObserveMode" => svc.SetObserveModeEnabledAsync(false),
                "EnableHceF" => svc.SetHceFEnabledAsync(true),
                "DisableHceF" => svc.SetHceFEnabledAsync(false),
                "EnableForegroundDispatch" => svc.ToggleForegroundDispatchAsync(true),
                "DisableForegroundDispatch" => svc.ToggleForegroundDispatchAsync(false),
                "FormatTag" => svc.FormatTagAsync(),
                "ClearWrite" => svc.ClearWriteAsync(),
                "ClearHceAids" => svc.ClearHceAidsAsync(),
                "RegisterHceAids" => svc.RegisterHceAidsAsync(node?["Value"]?.GetValue<string>() ?? ""),
                "RegisterSystemAids" => svc.RegisterSystemAidsAsync(node?["Category"]?.GetValue<string>() ?? "other", node?["Value"]?.GetValue<string>() ?? ""),
                "RemoveSystemAids" => svc.RemoveSystemAidsAsync(node?["Category"]?.GetValue<string>() ?? "other"),
                "UpdateHceResponse" => svc.UpdateHceResponseAsync(node?["Value"]?.GetValue<string>() ?? ""),
                "UpdateHceFResponse" => svc.UpdateHceFResponseAsync(node?["Value"]?.GetValue<string>() ?? ""),
                "SendRaw" => svc.SendRawAsync(node?["Technology"]?.GetValue<string>() ?? "IsoDep", node?["Value"]?.GetValue<string>() ?? ""),
                "SetDefaultObserveMode" => svc.SetDefaultObserveModeAsync(node?["Value"]?.GetValue<bool>() ?? false),
                "ResetDiscoveryTechnology" => svc.ResetDiscoveryTechnologyAsync(),
                "TransactionResult" => HandleTransactionResult(node),
                _ => Task.CompletedTask
            };
        }
        catch { }
    }

    private static Task HandleTransactionResult(JsonNode? node)
    {
        var txnId = node?["TransactionId"]?.GetValue<string>();
        var status = node?["Status"]?.GetValue<string>();
        LastTransactionId = txnId;
        LastTransactionStatus = status;
        TransactionResultReceived?.Invoke(null, new TransactionResultEventArgs(txnId, status));
        return Task.CompletedTask;
    }
}

internal sealed class TransactionResultEventArgs(string? transactionId, string? status) : EventArgs
{
    public string? TransactionId { get; } = transactionId;
    public string? Status { get; } = status;
}
