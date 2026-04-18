using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;

var Builder = WebApplication.CreateBuilder(args);
var BackofficePort = 49152 + System.Security.Cryptography.RandomNumberGenerator.GetInt32(16383);
var PfxPath = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "backoffice.pfx");
if (!File.Exists(PfxPath))
{
    PfxPath = Path.Combine(Directory.GetCurrentDirectory(), "backoffice.pfx");
}

Builder.WebHost.ConfigureKestrel(Opts =>
{
    Opts.ListenAnyIP(BackofficePort, ListenOpts =>
    {
        ListenOpts.UseHttps(PfxPath, "dev");
    });
});

var App = Builder.Build();
App.UseWebSockets();
App.UseStaticFiles();

var CompanionIp = string.Empty;
var CompanionPort = 8769;
var HttpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(3) };

var UdpListener = new Thread(() =>
{
    try
    {
        using var Udp = new UdpClient(8770);
        Udp.EnableBroadcast = true;
        while (true)
        {
            try
            {
                var Remote = new IPEndPoint(IPAddress.Any, 0);
                var Data = Udp.Receive(ref Remote);
                var Message = Encoding.UTF8.GetString(Data);
                if (Message.Contains("TranspilerCompanion", StringComparison.Ordinal))
                {
                    CompanionIp = Remote.Address.ToString();
                    Console.WriteLine($"Companion discovered via UDP: {CompanionIp}");
                }
            }
            catch { }
        }
    }
    catch { }
}) { IsBackground = true };
UdpListener.Start();

var NetworkScanner = new Thread(() =>
{
    while (true)
    {
        if (CompanionIp.Length > 0) { Thread.Sleep(30000); continue; }

        try
        {
            var LocalIp = Dns.GetHostAddresses(Dns.GetHostName())
                .FirstOrDefault(A => A.AddressFamily == AddressFamily.InterNetwork);
            if (LocalIp is null) { Thread.Sleep(10000); continue; }

            var Prefix = string.Join(".", LocalIp.ToString().Split('.')[..3]);
            Console.WriteLine($"Scanning subnet {Prefix}.0/24 for companion on port {CompanionPort}...");

            Parallel.For(1, 255, new ParallelOptions { MaxDegreeOfParallelism = 50 }, I =>
            {
                if (CompanionIp.Length > 0) return;
                var Ip = $"{Prefix}.{I}";
                try
                {
                    using var Tcp = new TcpClient();
                    var ConnectTask = Tcp.ConnectAsync(Ip, CompanionPort);
                    if (ConnectTask.Wait(500))
                    {
                        CompanionIp = Ip;
                        Console.WriteLine($"Companion found via scan: {Ip}:{CompanionPort}");
                    }
                }
                catch { }
            });
        }
        catch { }

        Thread.Sleep(10000);
    }
}) { IsBackground = true };
NetworkScanner.Start();

string CompanionUrl(string Path) => $"http://{CompanionIp}:{CompanionPort}{Path}";

string[] PollEndpoints = ["/status", "/logs", "/events", "/token", "/screen"];

App.Map("/ws", async (HttpContext Context) =>
{
    if (!Context.WebSockets.IsWebSocketRequest)
    {
        Context.Response.StatusCode = 400;
        return;
    }

    using var Ws = await Context.WebSockets.AcceptWebSocketAsync();
    var Cts = new CancellationTokenSource();
    var Token = Cts.Token;

    var ReceiveTask = Task.Run(async () =>
    {
        var Buffer = new byte[4096];
        while (!Token.IsCancellationRequested)
        {
            try
            {
                var Result = await Ws.ReceiveAsync(Buffer, Token);
                if (Result.MessageType == WebSocketMessageType.Close)
                {
                    await Cts.CancelAsync();
                    return;
                }

                var CommandJson = Encoding.UTF8.GetString(Buffer, 0, Result.Count);
                var Command = JsonSerializer.Deserialize<JsonElement>(CommandJson);
                var Action = Command.TryGetProperty("Action", out var ActionProp) ? ActionProp.GetString() : null;

                if (string.IsNullOrEmpty(Action)) continue;

                if (Action == "Start")
                {
                    var AdbResult = RunAdb("shell am start -n com.prtask.pocketpay.companion/crc64ed2e5ea2aa4a11b5.MainActivity");
                    var Ack = JsonSerializer.Serialize(new { Type = "Ack", Action, Response = AdbResult });
                    await Ws.SendAsync(Encoding.UTF8.GetBytes(Ack), WebSocketMessageType.Text, true, Token);
                    continue;
                }

                if (Action == "Kill" || Action == "Restart")
                {
                    try { await HttpClient.GetStringAsync(CompanionUrl("/forcekill"), Token); } catch { }
                    RunAdb("shell am force-stop com.prtask.pocketpay.companion");
                    var Ack = JsonSerializer.Serialize(new { Type = "Ack", Action, Response = "{\"Killed\":true}" });
                    await Ws.SendAsync(Encoding.UTF8.GetBytes(Ack), WebSocketMessageType.Text, true, Token);

                    if (Action == "Restart")
                    {
                        await Task.Delay(2000, Token);
                        var AdbResult = RunAdb("shell am start -n com.prtask.pocketpay.companion/crc64ed2e5ea2aa4a11b5.MainActivity");
                        var Ack2 = JsonSerializer.Serialize(new { Type = "Ack", Action = "Start", Response = AdbResult });
                        await Ws.SendAsync(Encoding.UTF8.GetBytes(Ack2), WebSocketMessageType.Text, true, Token);
                    }

                    continue;
                }

                if (Action is "DevOptOn" or "DevOptOff" or "AdbOn" or "AdbOff" or "WifiDebugOn" or "WifiDebugOff")
                {
                    if (!string.IsNullOrEmpty(CompanionIp))
                    {
                        var SettingPath = Action switch
                        {
                            "DevOptOn" => "/devopt/on",
                            "DevOptOff" => "/devopt/off",
                            "AdbOn" => "/adb/on",
                            "AdbOff" => "/adb/off",
                            "WifiDebugOn" => "/wifidebug/on",
                            "WifiDebugOff" => "/wifidebug/off",
                            _ => "",
                        };
                        try
                        {
                            var Resp = await HttpClient.GetStringAsync(CompanionUrl(SettingPath), Token);
                            var AckMsg = JsonSerializer.Serialize(new { Type = "Ack", Action, Response = Resp });
                            await Ws.SendAsync(Encoding.UTF8.GetBytes(AckMsg), WebSocketMessageType.Text, true, Token);
                        }
                        catch { }
                    }
                    continue;
                }

                if (Action == "DeviceInfo")
                {
                    var Info = GetDeviceInfo();
                    var Msg = JsonSerializer.Serialize(new { Type = "DeviceInfo", Data = Info });
                    await Ws.SendAsync(Encoding.UTF8.GetBytes(Msg), WebSocketMessageType.Text, true, Token);
                    continue;
                }

                if (Action == "Permissions")
                {
                    var Perms = GetPermissions();
                    var Msg = JsonSerializer.Serialize(new { Type = "Permissions", Data = Perms });
                    await Ws.SendAsync(Encoding.UTF8.GetBytes(Msg), WebSocketMessageType.Text, true, Token);
                    continue;
                }

                if (Action is "GrantPerm" or "RevokePerm")
                {
                    var PermName = Command.TryGetProperty("Permission", out var PermProp) ? PermProp.GetString() : null;
                    if (!string.IsNullOrEmpty(PermName))
                    {
                        var Verb = Action == "GrantPerm" ? "grant" : "revoke";
                        var AdbOut = RunAdb($"shell pm {Verb} com.prtask.pocketpay.companion {PermName}");
                        var AckMsg = JsonSerializer.Serialize(new { Type = "Ack", Action, Response = AdbOut });
                        await Ws.SendAsync(Encoding.UTF8.GetBytes(AckMsg), WebSocketMessageType.Text, true, Token);
                        var UpdatedPerms = GetPermissions();
                        var PermsMsg = JsonSerializer.Serialize(new { Type = "Permissions", Data = UpdatedPerms });
                        await Ws.SendAsync(Encoding.UTF8.GetBytes(PermsMsg), WebSocketMessageType.Text, true, Token);
                    }
                    continue;
                }

                if (string.IsNullOrEmpty(CompanionIp)) continue;

                var CompanionPath = Action switch
                {
                    "Clear" => "/clear",
                    "Monitor" => "/monitor/" + (Command.TryGetProperty("Package", out var PkgProp) ? PkgProp.GetString() : "all"),
                    _ => null,
                };

                if (CompanionPath is null) continue;

                try
                {
                    var Response = await HttpClient.GetStringAsync(CompanionUrl(CompanionPath), Token);
                    var Ack = JsonSerializer.Serialize(new { Type = "Ack", Action, Response });
                    await Ws.SendAsync(Encoding.UTF8.GetBytes(Ack), WebSocketMessageType.Text, true, Token);
                }
                catch { }
            }
            catch (OperationCanceledException) { return; }
            catch { }
        }
    }, Token);

    var PollTask = Task.Run(async () =>
    {
        while (!Token.IsCancellationRequested)
        {
            try
            {
                await Task.Delay(2000, Token);
            }
            catch (OperationCanceledException) { return; }

            if (string.IsNullOrEmpty(CompanionIp))
            {
                var Disc = JsonSerializer.Serialize(new { Type = "Discovery", Connected = false, Ip = "", Port = CompanionPort });
                try { await Ws.SendAsync(Encoding.UTF8.GetBytes(Disc), WebSocketMessageType.Text, true, Token); } catch { return; }
                continue;
            }

            var DiscoveryMsg = JsonSerializer.Serialize(new { Type = "Discovery", Connected = true, Ip = CompanionIp, Port = CompanionPort });
            try { await Ws.SendAsync(Encoding.UTF8.GetBytes(DiscoveryMsg), WebSocketMessageType.Text, true, Token); } catch { return; }

            foreach (var Endpoint in PollEndpoints)
            {
                if (Token.IsCancellationRequested) return;
                try
                {
                    var Data = await HttpClient.GetStringAsync(CompanionUrl(Endpoint), Token);
                    var MsgType = Endpoint switch
                    {
                        "/status" => "Status",
                        "/logs" => "Logs",
                        "/events" => "Events",
                        "/token" => "Token",
                        "/screen" => "Screen",
                        _ => "Unknown",
                    };
                    var Wrapper = $"{{\"Type\":\"{MsgType}\",\"Data\":{Data}}}";
                    await Ws.SendAsync(Encoding.UTF8.GetBytes(Wrapper), WebSocketMessageType.Text, true, Token);
                }
                catch (OperationCanceledException) { return; }
                catch { }
            }
        }
    }, Token);

    await Task.WhenAny(ReceiveTask, PollTask);
    await Cts.CancelAsync();

    if (Ws.State == WebSocketState.Open || Ws.State == WebSocketState.CloseReceived)
    {
        try { await Ws.CloseAsync(WebSocketCloseStatus.NormalClosure, "Done", CancellationToken.None); } catch { }
    }
});

App.MapFallbackToFile("index.html");

string RunAdb(string Arguments)
{
    try
    {
        var DeviceSerial = FindAdbDevice(CompanionIp);
        var FullArgs = string.IsNullOrEmpty(DeviceSerial) ? Arguments : $"-s {DeviceSerial} {Arguments}";
        var Psi = new System.Diagnostics.ProcessStartInfo("adb", FullArgs)
        {
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        };
        using var Process = System.Diagnostics.Process.Start(Psi);
        if (Process is null) return "{\"Error\":\"ADB not found\"}";
        var Output = Process.StandardOutput.ReadToEnd();
        var Error = Process.StandardError.ReadToEnd();
        Process.WaitForExit(10000);
        var Result = string.IsNullOrEmpty(Error) ? Output.Trim() : Error.Trim();
        Console.WriteLine($"ADB: {FullArgs} -> {Result}");
        return JsonSerializer.Serialize(new { Adb = Result });
    }
    catch (Exception Ex)
    {
        return JsonSerializer.Serialize(new { Error = Ex.Message });
    }
}

static string? FindAdbDevice(string Ip)
{
    try
    {
        var Psi = new System.Diagnostics.ProcessStartInfo("adb", "devices")
        {
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        };
        using var Process = System.Diagnostics.Process.Start(Psi);
        if (Process is null) return null;
        var Output = Process.StandardOutput.ReadToEnd();
        Process.WaitForExit(5000);

        string? FirstDevice = null;
        foreach (var Line in Output.Split('\n'))
        {
            var Trimmed = Line.Trim();
            if (!Trimmed.EndsWith("device", StringComparison.Ordinal) || Trimmed.StartsWith("List", StringComparison.Ordinal)) continue;
            var Serial = Trimmed.Split('\t')[0];
            FirstDevice ??= Serial;
            if (!string.IsNullOrEmpty(Ip) && Serial.StartsWith(Ip, StringComparison.Ordinal))
            {
                return Serial;
            }
        }

        return FirstDevice;
    }
    catch { }

    return null;
}

object GetDeviceInfo()
{
    var Serial = FindAdbDevice(CompanionIp);
    var AdbConnected = !string.IsNullOrEmpty(Serial);

    if (!AdbConnected)
    {
        return new
        {
            AdbConnected = false,
            AdbSerial = "",
            Model = "",
            AndroidVersion = "",
            ApiLevel = "",
            Serial = "",
            Battery = "",
            WifiDebugAddr = "",
            DevOptionsEnabled = false,
            UsbDebugging = false,
            WifiDebugging = false,
        };
    }

    string AdbGet(string Cmd) => RunAdbRaw(Serial!, Cmd).Trim();

    var Model = AdbGet("shell getprop ro.product.model");
    var AndroidVer = AdbGet("shell getprop ro.build.version.release");
    var ApiLvl = AdbGet("shell getprop ro.build.version.sdk");
    var SerialNo = AdbGet("shell getprop ro.serialno");
    var BatteryRaw = AdbGet("shell dumpsys battery");
    var BatteryPctVal = "?";
    foreach (var Bl in BatteryRaw.Split('\n'))
    {
        var Trimmed = Bl.Trim();
        if (Trimmed.StartsWith("level:", StringComparison.Ordinal))
        {
            BatteryPctVal = Trimmed.Split(':')[^1].Trim();
            break;
        }
    }

    var DevOpts = AdbGet("shell settings get global development_settings_enabled");
    var AdbEnabled = AdbGet("shell settings get global adb_enabled");
    var WifiAdb = AdbGet("shell settings get global adb_wifi_enabled");
    var WifiPort = AdbGet("shell getprop service.adb.tls.port");
    var WifiIp = AdbGet("shell ip route | grep wlan0 | grep src");

    var BatteryPct = BatteryPctVal + "%";
    var IpAddr = "";
    if (WifiIp.Contains("src"))
    {
        var Parts = WifiIp.Split(' ');
        for (var I = 0; I < Parts.Length; I++)
        {
            if (Parts[I] == "src" && I + 1 < Parts.Length) { IpAddr = Parts[I + 1]; break; }
        }
    }

    var WifiAddr = !string.IsNullOrEmpty(IpAddr) && !string.IsNullOrEmpty(WifiPort) && WifiPort != "0"
        ? $"{IpAddr}:{WifiPort}"
        : "--";

    return new
    {
        AdbConnected = true,
        AdbSerial = Serial,
        Model,
        AndroidVersion = AndroidVer,
        ApiLevel = ApiLvl,
        Serial = SerialNo,
        Battery = BatteryPct,
        WifiDebugAddr = WifiAddr,
        DevOptionsEnabled = DevOpts == "1",
        UsbDebugging = AdbEnabled == "1",
        WifiDebugging = WifiAdb == "1",
    };
}

object[] GetPermissions()
{
    var Serial = FindAdbDevice(CompanionIp);
    if (string.IsNullOrEmpty(Serial)) return [];

    var Output = RunAdbRaw(Serial, "shell dumpsys package com.prtask.pocketpay.companion");
    var Perms = new List<object>();
    var GrantedSet = new HashSet<string>(StringComparer.Ordinal);
    var RequestedSet = new HashSet<string>(StringComparer.Ordinal);

    foreach (var RawLine in Output.Split('\n'))
    {
        var Line = RawLine.Trim();

        if (Line.Contains("granted=true", StringComparison.OrdinalIgnoreCase))
        {
            var Perm = Line.Split(':')[0].Trim();
            if (Perm.StartsWith("android.permission.", StringComparison.Ordinal))
            {
                GrantedSet.Add(Perm);
                RequestedSet.Add(Perm);
            }
        }
        else if (Line.Contains("granted=false", StringComparison.OrdinalIgnoreCase))
        {
            var Perm = Line.Split(':')[0].Trim();
            if (Perm.StartsWith("android.permission.", StringComparison.Ordinal))
            {
                RequestedSet.Add(Perm);
            }
        }
        else if (Line.StartsWith("android.permission.", StringComparison.Ordinal) && !Line.Contains('='))
        {
            RequestedSet.Add(Line);
        }
    }

    foreach (var P in RequestedSet.Order())
    {
        Perms.Add(new { Name = P, Granted = GrantedSet.Contains(P) });
    }

    return [.. Perms];
}

string RunAdbRaw(string Serial, string Arguments)
{
    try
    {
        var Psi = new System.Diagnostics.ProcessStartInfo("adb", $"-s {Serial} {Arguments}")
        {
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        };
        using var Process = System.Diagnostics.Process.Start(Psi);
        if (Process is null) return "";
        var Output = Process.StandardOutput.ReadToEnd();
        Process.WaitForExit(10000);
        return Output;
    }
    catch { return ""; }
}

Console.WriteLine($"Transpiler Companion Backoffice: https://localhost:{BackofficePort}");
App.Run();
