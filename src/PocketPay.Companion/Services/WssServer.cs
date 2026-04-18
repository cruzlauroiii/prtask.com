using System.Collections.Concurrent;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;

namespace PocketPay.Companion.Services;

public sealed class WssServer : IDisposable
{
    private const int WssPort = 8771;
    private TcpListener? Listener;
    private volatile bool IsRunning;
    private Java.Lang.Thread? AcceptThread;
    private Java.Lang.Thread? BroadcastThread;
    private X509Certificate2? Certificate;
    private readonly ConcurrentDictionary<string, WebSocket> Clients = new();
    private readonly Func<string, string?> CommandHandler;

    public WssServer(Func<string, string?> CommandHandler)
    {
        this.CommandHandler = CommandHandler;
    }

    public void Start()
    {
        Certificate = GenerateSelfSignedCert();
        IsRunning = true;

        AcceptThread = new Java.Lang.Thread(new Java.Lang.Runnable(() =>
        {
            Android.Util.Log.Info("Companion", $"WSS server starting on port {WssPort.ToString(System.Globalization.CultureInfo.InvariantCulture)}");
            RunAcceptLoop();
        }));
        AcceptThread.Start();

        BroadcastThread = new Java.Lang.Thread(new Java.Lang.Runnable(() =>
        {
            Android.Util.Log.Info("Companion", "WSS broadcast thread started");
            RunBroadcastLoop();
        }));
        BroadcastThread.Start();
    }

    public void Stop()
    {
        IsRunning = false;
        Listener?.Stop();
        AcceptThread?.Interrupt();
        BroadcastThread?.Interrupt();

        foreach (var Kv in Clients)
        {
            try { Kv.Value.Dispose(); } catch { }
        }

        Clients.Clear();
    }

    public void Dispose()
    {
        Stop();
        Certificate?.Dispose();
        AcceptThread?.Dispose();
        BroadcastThread?.Dispose();
    }

    private void RunAcceptLoop()
    {
        try
        {
            Listener = new TcpListener(IPAddress.Any, WssPort);
            Listener.Start();
            Android.Util.Log.Info("Companion", $"WSS listener started on port {WssPort}");

            while (IsRunning)
            {
                try
                {
                    var TcpClient = Listener.AcceptTcpClient();
                    var ClientId = Guid.NewGuid().ToString("N")[..8];
                    Android.Util.Log.Info("Companion", $"WSS client connecting: {ClientId}");

                    var ClientThread = new Java.Lang.Thread(new Java.Lang.Runnable(() =>
                        HandleClient(TcpClient, ClientId)));
                    ClientThread.Start();
                }
                catch (SocketException) when (!IsRunning) { break; }
                catch (Exception Ex)
                {
                    Android.Util.Log.Error("Companion", $"WSS accept error: {Ex.Message}");
                }
            }
        }
        catch (Exception Ex)
        {
            Android.Util.Log.Error("Companion", $"WSS server error: {Ex.Message}");
        }
    }

    private void HandleClient(TcpClient TcpClient, string ClientId)
    {
        WebSocket? Ws = null;
        try
        {
            var NetworkStream = TcpClient.GetStream();
            var SslStream = new SslStream(NetworkStream, false);
            SslStream.AuthenticateAsServer(Certificate!, false, System.Security.Authentication.SslProtocols.None, false);

            Android.Util.Log.Info("Companion", $"WSS TLS handshake complete: {ClientId}");

            var HttpRequest = ReadHttpUpgradeRequest(SslStream);
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

            Clients[ClientId] = Ws;
            Android.Util.Log.Info("Companion", $"WSS client connected: {ClientId}");

            var Buffer = new byte[4096];
            while (IsRunning && Ws.State == WebSocketState.Open)
            {
                var Segment = new ArraySegment<byte>(Buffer);
                var Result = Ws.ReceiveAsync(Segment, CancellationToken.None).GetAwaiter().GetResult();

                if (Result.MessageType == WebSocketMessageType.Close)
                {
                    break;
                }

                var Message = Encoding.UTF8.GetString(Buffer, 0, Result.Count);
                Android.Util.Log.Info("Companion", $"WSS received from {ClientId}: {Message}");

                try
                {
                    var Command = JsonSerializer.Deserialize<JsonElement>(Message);
                    var Action = Command.TryGetProperty("Action", out var ActionProp) ? ActionProp.GetString() : null;

                    if (!string.IsNullOrEmpty(Action))
                    {
                        var Response = CommandHandler(Action);
                        if (Response != null)
                        {
                            var Ack = JsonSerializer.Serialize(new { Type = "Ack", Action, Response });
                            var AckBytes = Encoding.UTF8.GetBytes(Ack);
                            Ws.SendAsync(new ArraySegment<byte>(AckBytes), WebSocketMessageType.Text, true, CancellationToken.None).GetAwaiter().GetResult();
                        }
                    }
                }
                catch (Exception Ex)
                {
                    Android.Util.Log.Error("Companion", $"WSS command error: {Ex.Message}");
                }
            }
        }
        catch (Exception Ex)
        {
            Android.Util.Log.Error("Companion", $"WSS client {ClientId} error: {Ex.Message}");
        }
        finally
        {
            Clients.TryRemove(ClientId, out _);
            try { Ws?.Dispose(); } catch { }
            try { TcpClient.Close(); } catch { }
            Android.Util.Log.Info("Companion", $"WSS client disconnected: {ClientId}");
        }
    }

    private void RunBroadcastLoop()
    {
        while (IsRunning)
        {
            try
            {
                Java.Lang.Thread.Sleep(2000);
            }
            catch (Java.Lang.InterruptedException) { return; }

            if (Clients.IsEmpty) continue;

            try
            {
                var UptimeMs = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - CompanionService.StartTimeMs;
                var Status = JsonSerializer.Serialize(new
                {
                    Type = "Status",
                    Data = new
                    {
                        Status = CompanionService.CurrentStatus,
                        Uptime = UptimeMs,
                        LogCount = LogcatReader.Logs.Count,
                        EventCount = AccessibilityBridge.Events.Count,
                        MonitoredPackage = AccessibilityBridge.MonitoredPackage ?? "all",
                    },
                });

                var Logs = $"{{\"Type\":\"Logs\",\"Data\":{JsonSerializer.Serialize(LogcatReader.Logs)}}}";

                var Events = BuildEventsPayload();

                var Token = JsonSerializer.Serialize(new
                {
                    Type = "Token",
                    Data = new
                    {
                        Jwt = LogcatReader.Token ?? string.Empty,
                        DeviceToken = LogcatReader.DeviceToken ?? string.Empty,
                    },
                });

                var Screen = $"{{\"Type\":\"Screen\",\"Data\":{AccessibilityBridge.ScreenText ?? "[]"}}}";

                BroadcastMessage(Status);
                BroadcastMessage(Logs);
                BroadcastMessage(Events);
                BroadcastMessage(Token);
                BroadcastMessage(Screen);
            }
            catch (Exception Ex)
            {
                Android.Util.Log.Error("Companion", $"WSS broadcast error: {Ex.Message}");
            }
        }
    }

    private void BroadcastMessage(string Message)
    {
        var Bytes = Encoding.UTF8.GetBytes(Message);
        var Segment = new ArraySegment<byte>(Bytes);

        foreach (var Kv in Clients)
        {
            try
            {
                if (Kv.Value.State == WebSocketState.Open)
                {
                    Kv.Value.SendAsync(Segment, WebSocketMessageType.Text, true, CancellationToken.None).GetAwaiter().GetResult();
                }
            }
            catch
            {
                Clients.TryRemove(Kv.Key, out var Dead);
                try { Dead?.Dispose(); } catch { }
            }
        }
    }

    private static string BuildEventsPayload()
    {
        var RawEvents = AccessibilityBridge.Events;
        var Sb = new StringBuilder("{\"Type\":\"Events\",\"Data\":[");
        for (var I = 0; I < RawEvents.Count; I++)
        {
            if (I > 0) Sb.Append(',');
            Sb.Append(RawEvents[I]);
        }

        Sb.Append("]}");
        return Sb.ToString();
    }

    private static string? ReadHttpUpgradeRequest(SslStream Stream)
    {
        var Buffer = new byte[4096];
        var TotalRead = 0;

        while (TotalRead < Buffer.Length)
        {
            var BytesRead = Stream.Read(Buffer, TotalRead, Buffer.Length - TotalRead);
            if (BytesRead == 0) return null;
            TotalRead += BytesRead;

            var Request = Encoding.UTF8.GetString(Buffer, 0, TotalRead);
            if (Request.Contains("\r\n\r\n", StringComparison.Ordinal))
            {
                return Request;
            }
        }

        return null;
    }

    private static string? ExtractWebSocketKey(string HttpRequest)
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

    private static void SendWebSocketUpgradeResponse(SslStream Stream, string WebSocketKey)
    {
#pragma warning disable CA5350
        var AcceptKey = Convert.ToBase64String(
            SHA1.HashData(Encoding.UTF8.GetBytes(WebSocketKey + "258EAFA5-E914-47DA-95CA-5AB5DC698230")));
#pragma warning restore CA5350

        var Response = "HTTP/1.1 101 Switching Protocols\r\n" +
                       "Upgrade: websocket\r\n" +
                       "Connection: Upgrade\r\n" +
                       $"Sec-WebSocket-Accept: {AcceptKey}\r\n" +
                       "Access-Control-Allow-Origin: *\r\n" +
                       "\r\n";

        var ResponseBytes = Encoding.UTF8.GetBytes(Response);
        Stream.Write(ResponseBytes);
        Stream.Flush();
    }

    private static X509Certificate2 GenerateSelfSignedCert()
    {
        using var Rsa = RSA.Create(2048);
        var Request = new CertificateRequest(
            "CN=TranspilerCompanion",
            Rsa,
            HashAlgorithmName.SHA256,
            RSASignaturePadding.Pkcs1);

        var SanBuilder = new SubjectAlternativeNameBuilder();
        SanBuilder.AddDnsName("*");
        SanBuilder.AddIpAddress(IPAddress.Any);
        SanBuilder.AddIpAddress(IPAddress.Loopback);
        Request.CertificateExtensions.Add(SanBuilder.Build());

        Request.CertificateExtensions.Add(
            new X509BasicConstraintsExtension(false, false, 0, false));
        Request.CertificateExtensions.Add(
            new X509KeyUsageExtension(X509KeyUsageFlags.DigitalSignature | X509KeyUsageFlags.KeyEncipherment, false));

        var Cert = Request.CreateSelfSigned(DateTimeOffset.UtcNow.AddMinutes(-5), DateTimeOffset.UtcNow.AddYears(10));
        Android.Util.Log.Info("Companion", "Self-signed WSS certificate generated");
        return Cert;
    }
}
