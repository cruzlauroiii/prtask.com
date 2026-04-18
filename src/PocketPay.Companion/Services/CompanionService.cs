using Android.App;
using Android.Content;
using Android.OS;

namespace PocketPay.Companion.Services;

[Service(
    ForegroundServiceType = Android.Content.PM.ForegroundService.TypeSpecialUse,
    Exported = false)]
public class CompanionService : Android.App.Service
{
    private const string ChannelId = "companion_channel";
    private const int NotificationId = 1;
    private const string ActionKill = "com.prtask.companion.KILL";
    private const string ActionRestart = "com.prtask.companion.RESTART";
    private LogcatReader? LogcatReaderInstance;
    private NetworkDiscovery? NetworkDiscoveryInstance;
    private Java.Lang.Thread? ServerThread;
    private System.Net.HttpListener? HttpListenerInstance;
    private volatile bool IsRunning;
    public static long StartTimeMs { get; private set; }
    public static string CurrentStatus { get; private set; } = "Starting";

    public override IBinder? OnBind(Intent? Intent) => null;

    public override void OnCreate()
    {
        base.OnCreate();
        Android.Util.Log.Info("Companion", "Service OnCreate");
        CreateNotificationChannel();
    }

    public override StartCommandResult OnStartCommand(Intent? Intent, StartCommandFlags Flags, int StartId)
    {
        Android.Util.Log.Info("Companion", "Service OnStartCommand");
        StartTimeMs = System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        if (Intent?.Action == ActionKill)
        {
            Android.Util.Log.Info("Companion", "Kill requested");
            StopMonitoring();
            UpdateNotificationText("Killed — tap app icon to restart");
            return StartCommandResult.Sticky;
        }

        if (Intent?.Action == ActionRestart)
        {
            Android.Util.Log.Info("Companion", "Restart requested");
            StopMonitoring();
            StartMonitoring();
            return StartCommandResult.Sticky;
        }

        if (ServerThread is not null && ServerThread.IsAlive)
        {
            return StartCommandResult.Sticky;
        }

        var KillIntent = PendingIntent.GetService(this, 1,
            new Intent(this, typeof(CompanionService)).SetAction(ActionKill),
            PendingIntentFlags.Immutable)!;
        var RestartIntent = PendingIntent.GetService(this, 2,
            new Intent(this, typeof(CompanionService)).SetAction(ActionRestart),
            PendingIntentFlags.Immutable)!;

        var KillAction = new Notification.Action.Builder(
            Android.Resource.Drawable.IcMenuCloseClearCancel, "Kill", KillIntent).Build();
        var RestartAction = new Notification.Action.Builder(
            Android.Resource.Drawable.IcMenuRotate, "Restart", RestartIntent).Build();

        var NotificationBuilder = new Notification.Builder(this, ChannelId)
            .SetContentTitle("Transpiler Companion")
            .SetContentText("Running — capturing traffic data")
            .SetSmallIcon(Android.Resource.Drawable.IcDialogInfo)
            .SetOngoing(true)
            .AddAction(KillAction)
            .AddAction(RestartAction);

        StartForeground(NotificationId, NotificationBuilder!.Build(), Android.Content.PM.ForegroundService.TypeSpecialUse);

        IsRunning = true;

        LogcatReaderInstance = new LogcatReader();
        NetworkDiscoveryInstance = new NetworkDiscovery();

        ServerThread = new Java.Lang.Thread(new Java.Lang.Runnable(() =>
        {
            Android.Util.Log.Info("Companion", "Server thread started");
            StartHttpServer();
        }));
        ServerThread.Start();

        LogcatReaderInstance.Start();
        NetworkDiscoveryInstance.Start();

        CurrentStatus = "Running";
        UpdateNotificationText("Running");

        Android.Util.Log.Info("Companion", "All subsystems started");
        return StartCommandResult.Sticky;
    }

    public override void OnDestroy()
    {
        Android.Util.Log.Info("Companion", "Service OnDestroy");
        StopAllSubsystems();
        base.OnDestroy();
    }

    private void StopAllSubsystems()
    {
        IsRunning = false;
        CurrentStatus = "Stopped";
        LogcatReaderInstance?.Stop();
        NetworkDiscoveryInstance?.Stop();
        try { HttpListenerInstance?.Stop(); } catch { }
        try { HttpListenerInstance?.Close(); } catch { }
        HttpListenerInstance = null;
        ServerThread?.Interrupt();
        LogcatReaderInstance = null;
        NetworkDiscoveryInstance = null;
        ServerThread = null;
    }

    private void StopMonitoring()
    {
        CurrentStatus = "Stopped";
        LogcatReaderInstance?.Stop();
        NetworkDiscoveryInstance?.Stop();
        LogcatReaderInstance = null;
        NetworkDiscoveryInstance = null;
        UpdateNotificationText("Stopped");
    }

    private void StartMonitoring()
    {
        LogcatReaderInstance = new LogcatReader();
        NetworkDiscoveryInstance = new NetworkDiscovery();
        LogcatReaderInstance.Start();
        NetworkDiscoveryInstance.Start();
        CurrentStatus = "Running";
        UpdateNotificationText("Running");
    }

    private string? HandleWssCommand(string Action)
    {
        return Action switch
        {
            "Start" => DoStart(),
            "Stop" => DoStop(),
            "Restart" => DoRestart(),
            "Kill" => DoKill(),
            "ForceKill" => DoForceKill(),
            "Clear" => DoClear(),
            _ => null,
        };
    }

    private string DoStart()
    {
        StartMonitoring();
        return "{\"Started\":true}";
    }

    private string DoStop()
    {
        StopMonitoring();
        return "{\"Stopped\":true}";
    }

    private string DoRestart()
    {
        RestartAllSubsystems();
        return "{\"Restarting\":true}";
    }

    private string DoKill()
    {
        StopMonitoring();
        CurrentStatus = "Killed";
        UpdateNotificationText("Killed — use Start to resume");
        return "{\"Killed\":true}";
    }

    private string DoForceKill()
    {
        StopForeground(StopForegroundFlags.Remove);
        StopSelf();
        Java.Lang.JavaSystem.Exit(0);
        return "{\"ForceKilling\":true}";
    }

    private static string DoClear()
    {
        LogcatReader.ClearLogs();
        AccessibilityBridge.ClearEvents();
        return "{\"Cleared\":true}";
    }

    private void RestartAllSubsystems()
    {
        StopMonitoring();
        UpdateNotificationText("Restarting...");
        StartTimeMs = System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        StartMonitoring();
    }

    private void UpdateNotificationText(string Text)
    {
        var NotificationBuilder = new Notification.Builder(this, ChannelId)
            .SetContentTitle("Transpiler Companion")
            .SetContentText(Text)
            .SetSmallIcon(Android.Resource.Drawable.IcDialogInfo)
            .SetOngoing(true);

        var Manager = GetSystemService(NotificationService) as NotificationManager;
        Manager?.Notify(NotificationId, NotificationBuilder.Build());
    }

    private void CreateNotificationChannel()
    {
        var Channel = new NotificationChannel(
            ChannelId,
            "Companion Service",
            NotificationImportance.Low);
        var Manager = GetSystemService(NotificationService) as NotificationManager;
        Manager?.CreateNotificationChannel(Channel);
    }

    private void StartHttpServer()
    {
        if (HttpListenerInstance is { IsListening: true })
        {
            return;
        }

        try
        {
            HttpListenerInstance = new System.Net.HttpListener();
            HttpListenerInstance.Prefixes.Add("http://+:8769/");
            HttpListenerInstance.Start();
            Android.Util.Log.Info("Companion", "HTTP listener started on port 8769");

            while (IsRunning)
            {
                try
                {
                    var Context = HttpListenerInstance.GetContext();
                    var Request = Context.Request;

                    if (Request.IsWebSocketRequest)
                    {
                        HandleWebSocket(Context);
                    }
                    else
                    {
                        HandleHttpRequest(Context);
                    }
                }
                catch (System.Net.HttpListenerException)
                {
                    break;
                }
                catch (System.ObjectDisposedException)
                {
                    break;
                }
                catch (Java.Lang.InterruptedException)
                {
                    break;
                }
                catch (System.Exception Ex)
                {
                    Android.Util.Log.Error("Companion", $"Listener error: {Ex.Message}");
                }
            }
        }
        catch (System.Exception Ex)
        {
            Android.Util.Log.Error("Companion", $"Server start error: {Ex.Message}");
        }
    }

    private void HandleHttpRequest(System.Net.HttpListenerContext Context)
    {
        var Request = Context.Request;
        var Response = Context.Response;

        if (Request.HttpMethod == "OPTIONS")
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, OPTIONS");
            Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type");
            Response.Headers.Add("Access-Control-Allow-Private-Network", "true");
            Response.StatusCode = 204;
            Response.Close();
            return;
        }

        var Path = Request.Url?.AbsolutePath?.TrimEnd('/') ?? string.Empty;

        string Json;

        if (Path.StartsWith("/monitor/", System.StringComparison.Ordinal) && Path.Length > 9)
        {
            var Package = Path[9..];
            AccessibilityBridge.MonitoredPackage = Package;
            Json = System.Text.Json.JsonSerializer.Serialize(new { Monitored = Package });
        }
        else if (Path == "/restart")
        {
            Json = "{\"Restarting\":true}";
            SendJsonResponse(Response, Json);
            RestartAllSubsystems();
            return;
        }
        else if (Path == "/stop")
        {
            StopMonitoring();
            Json = "{\"Stopped\":true}";
        }
        else if (Path == "/start")
        {
            StartMonitoring();
            Json = "{\"Started\":true}";
        }
        else if (Path == "/kill")
        {
            StopMonitoring();
            UpdateNotificationText("Killed — use Start to resume");
            Json = "{\"Killed\":true}";
        }
        else if (Path == "/forcekill")
        {
            Json = "{\"ForceKilling\":true}";
            SendJsonResponse(Response, Json);
            StopForeground(StopForegroundFlags.Remove);
            StopSelf();
            Java.Lang.JavaSystem.Exit(0);
            return;
        }
        else if (Path == "/update" && Request.HttpMethod == "POST")
        {
            Json = HandleApkUpload(Request);
        }
        else
        {
            Json = Path switch
            {
                "/logs" => System.Text.Json.JsonSerializer.Serialize(LogcatReader.Logs),
                "/token" => System.Text.Json.JsonSerializer.Serialize(new
                {
                    Jwt = LogcatReader.Token ?? string.Empty,
                    DeviceToken = LogcatReader.DeviceToken ?? string.Empty,
                }),
                "/state" => AccessibilityBridge.State ?? "{}",
                "/events" => BuildEventsJson(),
                "/screen" => AccessibilityBridge.ScreenText ?? "[]",
                "/clear" => DoClear(),
                "/command" => "{\"Ack\":true}",
                "/devopt/on" => SetGlobalSetting("development_settings_enabled", 1),
                "/devopt/off" => SetGlobalSetting("development_settings_enabled", 0),
                "/adb/on" => SetGlobalSetting("adb_enabled", 1),
                "/adb/off" => SetGlobalSetting("adb_enabled", 0),
                "/wifidebug/on" => SetGlobalSetting("adb_wifi_enabled", 1),
                "/wifidebug/off" => SetGlobalSetting("adb_wifi_enabled", 0),
                "/adbinfo" => GetAdbInfo(),
                "/nfc" => GetLastCardRead(),
                "/headers" => System.Text.Json.JsonSerializer.Serialize(TrafficInterceptor.Headers),
                "/headers/clear" => ClearHeaders(),
                _ => BuildStatusJson(Path),
            };
        }

        SendJsonResponse(Response, Json);
    }

    private static void SendJsonResponse(System.Net.HttpListenerResponse Response, string Json)
    {
        Response.ContentType = "application/json";
        Response.Headers.Add("Access-Control-Allow-Origin", "*");
        Response.Headers.Add("Access-Control-Allow-Private-Network", "true");
        var Buffer = System.Text.Encoding.UTF8.GetBytes(Json);
        Response.ContentLength64 = Buffer.Length;
        Response.OutputStream.Write(Buffer, 0, Buffer.Length);
        Response.Close();
    }

    private string HandleApkUpload(System.Net.HttpListenerRequest Request)
    {
        try
        {
            var DownloadsPath = global::Android.OS.Environment.GetExternalStoragePublicDirectory(
                global::Android.OS.Environment.DirectoryDownloads)!.AbsolutePath;
            var ApkPath = System.IO.Path.Combine(DownloadsPath, "companion_update.apk");

            using var FileStream = System.IO.File.Create(ApkPath);
            Request.InputStream.CopyTo(FileStream);

            var ApkFile = new Java.IO.File(ApkPath);
            var ApkUri = global::Android.Net.Uri.FromFile(ApkFile);

            var InstallIntent = new Intent(Intent.ActionView)
                .SetDataAndType(ApkUri, "application/vnd.android.package-archive")
                .AddFlags(ActivityFlags.NewTask | ActivityFlags.GrantReadUriPermission);
            StartActivity(InstallIntent);

            return "{\"Updated\":true}";
        }
        catch (System.Exception Ex)
        {
            return System.Text.Json.JsonSerializer.Serialize(new { Error = Ex.Message });
        }
    }

    private static string GetAdbInfo()
    {
        try
        {
            var Runtime = Java.Lang.Runtime.GetRuntime();
            var Process = Runtime!.Exec(["getprop", "service.adb.tls.port"]);
            var Reader = new Java.IO.BufferedReader(new Java.IO.InputStreamReader(Process!.InputStream));
            var TlsPort = Reader.ReadLine()?.Trim() ?? "";
            Process.WaitFor();
            Process.Destroy();

            var WifiEnabled = Android.Provider.Settings.Global.GetInt(
                Android.App.Application.Context.ContentResolver, "adb_wifi_enabled", 0);
            var AdbEnabled = Android.Provider.Settings.Global.GetInt(
                Android.App.Application.Context.ContentResolver, "adb_enabled", 0);
            var DevOpts = Android.Provider.Settings.Global.GetInt(
                Android.App.Application.Context.ContentResolver, "development_settings_enabled", 0);

            var Ip = "";
            try
            {
                var Interfaces = Java.Net.NetworkInterface.NetworkInterfaces;
                while (Interfaces != null && Interfaces.HasMoreElements)
                {
                    if (Interfaces.NextElement() is not Java.Net.NetworkInterface Iface) continue;
                    if (Iface.Name != "wlan0") continue;
                    var Addrs = Iface.InetAddresses;
                    if (Addrs is null) continue;
                    while (Addrs.HasMoreElements)
                    {
                        if (Addrs.NextElement() is not Java.Net.InetAddress Addr) continue;
                        if (Addr is Java.Net.Inet4Address)
                        {
                            Ip = Addr.HostAddress ?? "";
                            break;
                        }
                    }
                }
            }
            catch { }

            return System.Text.Json.JsonSerializer.Serialize(new
            {
                Ip,
                TlsPort,
                WifiEnabled = WifiEnabled == 1,
                AdbEnabled = AdbEnabled == 1,
                DevOptions = DevOpts == 1,
                ConnectAddr = !string.IsNullOrEmpty(Ip) && !string.IsNullOrEmpty(TlsPort) && TlsPort != "0"
                    ? $"{Ip}:{TlsPort}" : "",
            });
        }
        catch (System.Exception Ex)
        {
            return System.Text.Json.JsonSerializer.Serialize(new { Error = Ex.Message });
        }
    }

    private static string ClearHeaders()
    {
        TrafficInterceptor.ClearHeaders();
        return "{\"Cleared\":true}";
    }

    private static string GetLastCardRead()
    {
        var Card = EmvCardReader.LastCard;
        if (Card == null) return "{\"Card\":null}";
        return System.Text.Json.JsonSerializer.Serialize(new
        {
            Card.MaskedPan,
            Card.Expiry,
            Card.CardholderName,
            Card.Network,
            Card.Atc,
        });
    }

    private string SetGlobalSetting(string Key, int Value)
    {
        try
        {
            Android.Provider.Settings.Global.PutInt(ContentResolver, Key, Value);
            Android.Util.Log.Info("Companion", $"Set {Key}={Value}");
            return System.Text.Json.JsonSerializer.Serialize(new { Setting = Key, Value });
        }
        catch (System.Exception Ex)
        {
            Android.Util.Log.Error("Companion", $"SetGlobalSetting error: {Ex.Message}");
            return System.Text.Json.JsonSerializer.Serialize(new { Error = Ex.Message });
        }
    }

    private string BuildStatusJson(string Path)
    {
        if (Path is not ("" or "/" or "/status"))
        {
            return "{\"Error\":\"NotFound\"}";
        }

        var UptimeMs = System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - StartTimeMs;
        return System.Text.Json.JsonSerializer.Serialize(new
        {
            Status = CurrentStatus,
            Uptime = UptimeMs,
            LogCount = LogcatReader.Logs.Count,
            LogcatTotalLines = LogcatReader.TotalLines,
            EventCount = AccessibilityBridge.Events.Count,
            MonitoredPackage = AccessibilityBridge.MonitoredPackage ?? "all",
        });
    }

    private static string BuildEventsJson()
    {
        var RawEvents = AccessibilityBridge.Events;
        var Sb = new System.Text.StringBuilder("[");
        for (var I = 0; I < RawEvents.Count; I++)
        {
            if (I > 0)
            {
                Sb.Append(',');
            }

            Sb.Append(RawEvents[I]);
        }

        Sb.Append(']');
        return Sb.ToString();
    }

    private static void HandleWebSocket(System.Net.HttpListenerContext HttpContext)
    {
        try
        {
            var WsContext = HttpContext.AcceptWebSocketAsync(null).GetAwaiter().GetResult();
            var Socket = WsContext.WebSocket;
            var Buffer = new byte[4096];

            Android.Util.Log.Info("Companion", "WebSocket client connected");

            while (Socket.State == System.Net.WebSockets.WebSocketState.Open)
            {
                var Result = Socket.ReceiveAsync(
                    new System.ArraySegment<byte>(Buffer),
                    System.Threading.CancellationToken.None).GetAwaiter().GetResult();

                if (Result.MessageType == System.Net.WebSockets.WebSocketMessageType.Close)
                {
                    break;
                }

                var Message = System.Text.Encoding.UTF8.GetString(Buffer, 0, Result.Count);
                Android.Util.Log.Info("Companion", $"WS received: {Message}");

                var Reply = System.Text.Encoding.UTF8.GetBytes("{\"Ack\":true}");
                Socket.SendAsync(
                    new System.ArraySegment<byte>(Reply),
                    System.Net.WebSockets.WebSocketMessageType.Text,
                    true,
                    System.Threading.CancellationToken.None).GetAwaiter().GetResult();
            }
        }
        catch (System.Exception Ex)
        {
            Android.Util.Log.Error("Companion", $"WebSocket error: {Ex.Message}");
        }
    }
}
