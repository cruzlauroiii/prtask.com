using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using Android.App;
using Android.Content;
using Android.OS;
using WillowMaze.Wasm.Companion.Platforms.Android;

namespace WillowMaze.Wasm.Companion.Services;

[Service(
    ForegroundServiceType = Android.Content.PM.ForegroundService.TypeSpecialUse,
    Exported = false)]
public class CompanionService : Android.App.Service
{
    private const string ChannelId = "companion_channel";
    private const int NotificationId = 1;
    private const int UdpListenPort = 8770;
    private Java.Lang.Thread? UdpThread;
    private Java.Lang.Thread? WssThread;
    private volatile bool IsRunning;
    private string BackofficeHost = string.Empty;
    private int BackofficePort;
    private Java.Net.Socket? WssSocket;
    private System.IO.Stream? WssStream;

    public override IBinder? OnBind(Intent? Intent) => null;

    public override void OnCreate()
    {
        base.OnCreate();
        Android.Util.Log.Info("Companion", "Service OnCreate");
        ActiveInstance = this;
        CreateNotificationChannel();
    }

    public override StartCommandResult OnStartCommand(Intent? Intent, StartCommandFlags Flags, int StartId)
    {
        Android.Util.Log.Info("Companion", "Service OnStartCommand");
        if (Intent?.Action == "KILL") { Android.Util.Log.Info("Companion", "Kill requested"); IsRunning = false; StopForeground(StopForegroundFlags.Remove); StopSelf(); Java.Lang.JavaSystem.Exit(0); return StartCommandResult.NotSticky; }

        var KillIntent = PendingIntent.GetService(this, 0, new Intent(this, typeof(CompanionService)).SetAction("KILL"), PendingIntentFlags.Immutable)!;
        var KillAction = new Notification.Action.Builder(Android.Resource.Drawable.IcMenuCloseClearCancel, "Stop", KillIntent).Build();
        var NotificationBuilder = new Notification.Builder(this, ChannelId)
            .SetContentTitle("PocketPay Companion")
            .SetContentText("Running — waiting for backoffice")
            .SetSmallIcon(Android.Resource.Drawable.IcDialogInfo)
            .SetOngoing(true)
            .AddAction(KillAction);

        StartForeground(NotificationId, NotificationBuilder!.Build(), Android.Content.PM.ForegroundService.TypeSpecialUse);

        IsRunning = true;
        new Java.Lang.Thread(new Java.Lang.Runnable(() => { try { ActivateTerminal(); } catch (Exception Ex) { Android.Util.Log.Error("Companion", $"ActivateTerminal crashed: {Ex}"); } })).Start();

        UdpThread = new Java.Lang.Thread(new Java.Lang.Runnable(ListenForBroadcast));
        UdpThread.Start();

        return StartCommandResult.Sticky;
    }

    public override void OnDestroy()
    {
        Android.Util.Log.Info("Companion", "Service OnDestroy");
        IsRunning = false;
        try { WssSocket?.Close(); } catch (Exception) { /* Best-effort cleanup */ }
        UdpThread?.Interrupt();
        WssThread?.Interrupt();
        base.OnDestroy();
    }

    private void ListenForBroadcast()
    {
        try
        {
            using var Socket = new Java.Net.DatagramSocket(UdpListenPort);
            var Buffer = new byte[1024];
            Android.Util.Log.Info("Companion", $"Listening for UDP broadcasts on port {UdpListenPort}");

            while (IsRunning)
            {
                try
                {
                    var Packet = new Java.Net.DatagramPacket(Buffer, Buffer.Length);
                    Socket.Receive(Packet);
                    var RawLen = Packet.Length;
                    if (RawLen <= 0 || Buffer[0] != (byte)'{') { continue; }
                    var Message = Encoding.UTF8.GetString(Buffer, 0, RawLen).TrimEnd('\0');
                    Android.Util.Log.Info("Companion", $"UDP received ({RawLen}b): {Message}");

                    using var Doc = JsonDocument.Parse(Message);
                    if (Doc.RootElement.TryGetProperty("Service", out var SvcEl) &&
                        SvcEl.GetString() == "TranspilerBackoffice" &&
                        Doc.RootElement.TryGetProperty("WssPort", out var PortEl))
                    {
                        var Host = Packet.Address?.HostAddress ?? string.Empty;
                        var WssPort = PortEl.GetInt32();
                        if (Host != BackofficeHost || WssPort != BackofficePort)
                        {
                            BackofficeHost = Host;
                            BackofficePort = WssPort;
                            Android.Util.Log.Info("Companion", $"Backoffice discovered at {Host}:{WssPort}");
                            UpdateNotificationText($"Connected to {Host}:{WssPort}");
                            ConnectToBackoffice();
                        }
                    }
                }
                catch (Java.Lang.InterruptedException)
                {
                    break;
                }
                catch (Exception Ex)
                {
                    Android.Util.Log.Error("Companion", $"UDP error: {Ex.Message}");
                }
            }
        }
        catch (Exception Ex)
        {
            Android.Util.Log.Error("Companion", $"UDP listen error: {Ex.Message}");
        }
    }

    private void ConnectToBackoffice()
    {
        try { WssSocket?.Close(); } catch (Exception) { /* Best-effort cleanup */ }
        WssThread?.Interrupt();

        WssThread = new Java.Lang.Thread(new Java.Lang.Runnable(RunWssConnection));
        WssThread.Start();
    }

    private void RunWssConnection()
    {
        try
        {
            var SslCtx = Javax.Net.Ssl.SSLContext.GetInstance("TLS")!;
            SslCtx.Init(null, new Javax.Net.Ssl.ITrustManager[] { new TrustAll() }, null);
            WssSocket = SslCtx.SocketFactory!.CreateSocket(BackofficeHost, BackofficePort)!;
            WssStream = new WssSocketStream(WssSocket);

            var WsKey = Convert.ToBase64String(System.Security.Cryptography.RandomNumberGenerator.GetBytes(16));
            var Handshake = $"GET / HTTP/1.1\r\nHost: {BackofficeHost}:{BackofficePort}\r\nUpgrade: websocket\r\nConnection: Upgrade\r\nSec-WebSocket-Key: {WsKey}\r\nSec-WebSocket-Version: 13\r\n\r\n";
            var HsBytes = Encoding.UTF8.GetBytes(Handshake);
            WssStream.Write(HsBytes, 0, HsBytes.Length);
            WssStream.Flush();

            var RespBuf = new byte[1024];
            var RespLen = WssStream.Read(RespBuf, 0, RespBuf.Length);
            var RespStr = Encoding.UTF8.GetString(RespBuf, 0, RespLen);
            if (!RespStr.Contains("101"))
            {
                Android.Util.Log.Error("Companion", $"WSS handshake failed: {RespStr}");
                return;
            }
            Android.Util.Log.Info("Companion", "WSS connected to backoffice");
            UpdateNotificationText($"Connected to {BackofficeHost}:{BackofficePort}");

            WsSend("{\"ClientType\":\"Companion\"}");

            while (IsRunning && WssSocket.IsConnected)
            {
                var Msg = WsReceive();
                if (Msg == null) break;
                Android.Util.Log.Info("Companion", $"WSS received: {Msg}");
                HandleBackofficeCommand(Msg);
            }
        }
        catch (Exception Ex)
        {
            Android.Util.Log.Error("Companion", $"WSS connection error: {Ex.Message}");
            UpdateNotificationText("Disconnected");
        }
    }

    private void WsSend(string Text)
    {
        if (WssStream == null) return;
        var Payload = Encoding.UTF8.GetBytes(Text);
        var Mask = System.Security.Cryptography.RandomNumberGenerator.GetBytes(4);
        using var Ms = new System.IO.MemoryStream();
        Ms.WriteByte(0x81);
        if (Payload.Length < 126) { Ms.WriteByte((byte)(0x80 | Payload.Length)); }
        else { Ms.WriteByte(0xFE); Ms.WriteByte((byte)(Payload.Length >> 8)); Ms.WriteByte((byte)(Payload.Length & 0xFF)); }
        Ms.Write(Mask, 0, 4);
        for (var I = 0; I < Payload.Length; I++) Ms.WriteByte((byte)(Payload[I] ^ Mask[I % 4]));
        var Frame = Ms.ToArray();
        WssStream.Write(Frame, 0, Frame.Length);
        WssStream.Flush();
    }

    private string? WsReceive()
    {
        if (WssStream == null) return null;
        var H = new byte[2];
        if (WssStream.Read(H, 0, 2) < 2) return null;
        var Len = (int)(H[1] & 0x7F);
        if (Len == 126) { var E = new byte[2]; var _ = WssStream.Read(E, 0, 2); Len = (E[0] << 8) | E[1]; }
        var Data = new byte[Len];
        var Read = 0;
        while (Read < Len) { var N = WssStream.Read(Data, Read, Len - Read); if (N <= 0) return null; Read += N; }
        return Encoding.UTF8.GetString(Data);
    }

    private sealed class TrustAll : Java.Lang.Object, Javax.Net.Ssl.IX509TrustManager
    {
        public void CheckClientTrusted(Java.Security.Cert.X509Certificate[]? Chain, string? AuthType) { }
        public void CheckServerTrusted(Java.Security.Cert.X509Certificate[]? Chain, string? AuthType) { }
        public Java.Security.Cert.X509Certificate[] GetAcceptedIssuers() => Array.Empty<Java.Security.Cert.X509Certificate>();
    }

    private sealed class WssSocketStream : System.IO.Stream
    {
        private readonly Java.Net.Socket Sock;
        public WssSocketStream(Java.Net.Socket S) { Sock = S; }
        public override bool CanRead => true;
        public override bool CanSeek => false;
        public override bool CanWrite => true;
        public override long Length => 0;
        public override long Position { get => 0; set => _ = value; }
        public override void Flush() => Sock.OutputStream?.Flush();
        public override int Read(byte[] B, int O, int C) => Sock.InputStream?.Read(B, O, C) ?? 0;
        public override void Write(byte[] B, int O, int C) => Sock.OutputStream?.Write(B, O, C);
        public override long Seek(long O, System.IO.SeekOrigin W) => 0;
        public override void SetLength(long V) { }
    }

    private void HandleBackofficeCommand(string Json)
    {
        try
        {
            using var Doc = JsonDocument.Parse(Json);
            var Method = Doc.RootElement.TryGetProperty("Method", out var MEl) ? MEl.GetString() ?? string.Empty : string.Empty;

            if (Method == "ReadCard")
            {
                Android.Util.Log.Info("Companion", "ReadCard command received — waiting for NFC tap");
                CardReadEvent.Reset();
                if (MainActivity.Instance == null)
                {
                    var LaunchIntent = new Intent(this, typeof(MainActivity));
                    LaunchIntent.AddFlags(ActivityFlags.NewTask | ActivityFlags.ReorderToFront);
                    StartActivity(LaunchIntent);
                }
                CardReadEvent.WaitOne(20000);
                var Card = EmvCardReader.LastCard;
                var CardJson = Card != null
                    ? JsonSerializer.Serialize(new { Method = "CardData", Payload = new { Card.MaskedPan, Card.Pan, Card.Expiry, Card.CardholderName, Card.Network, Card.Atc, Card.Arqc, Card.Cid, Card.Iad, Card.Aid, Track2 = Card.Track2 != null ? Convert.ToHexString(Card.Track2) : null, ChipData = Card.GenerateAcResponse != null ? Convert.ToHexString(Card.GenerateAcResponse) : null } })
                    : "{\"Method\":\"CardData\",\"Payload\":null}";

                WsSend(CardJson);
            }
            else if (Method == "SubmitPayment")
            {
                Android.Util.Log.Info("Companion", "SubmitPayment command received");
                var AmountEl = Doc.RootElement.TryGetProperty("Amount", out var AEl) ? AEl.GetInt64() : 100L;
                if (!IsActivated) { Android.Util.Log.Warn("Companion", "Terminal not activated yet"); }
                var Card = EmvCardReader.LastCard;
                if (Card == null || string.IsNullOrEmpty(Card.Pan))
                {
                    SendWss("{\"Method\":\"PaymentResult\",\"Success\":false,\"Error\":\"No card data\"}");
                    return;
                }

                try
                {
                    var Track2B64 = Card.Track2 != null ? Convert.ToBase64String(Card.Track2) : string.Empty;
                    var ChipB64 = Card.GenerateAcResponse != null ? Convert.ToBase64String(Card.GenerateAcResponse) : string.Empty;
                    var PaySys = Card.Network switch { "Visa" => "VISA", "Mastercard" => "MASTERCARD", _ => "UNKNOWN" };
                    var TxnReq = JsonSerializer.Serialize(new
                    {
                        pan = Card.Pan,
                        expiryDate = Card.Expiry,
                        track2 = Track2B64,
                        chipData = ChipB64,
                        amount = AmountEl,
                        currency = 608,
                        externalId = Guid.NewGuid().ToString(),
                        type = "PURCHASE",
                        timestamp = DateTimeOffset.UtcNow.ToString("o"),
                        paymentSystem = PaySys,
                    });
                    var Jws = CreateJws("POST", "/api/mt/terminal/transactions", TxnReq);
                    Android.Util.Log.Info("Companion", "POST mob-gcash.t2ph.psr-it.com/api/mt/terminal/transactions");
                    var Url = new Java.Net.URL($"{TophBaseUrl}/api/mt/terminal/transactions");
                    var Conn = (Java.Net.HttpURLConnection)Url.OpenConnection()!;
                    Conn.RequestMethod = "POST";
                    Conn.SetRequestProperty("Content-Type", "application/json");
                    Conn.SetRequestProperty("Accept", "application/jwt");
                    Conn.SetRequestProperty("User-Agent", "mobile_cashier_android");
                    Conn.SetRequestProperty("X-Request-Signature", Jws);
                    Conn.ConnectTimeout = 30000;
                    Conn.ReadTimeout = 30000;
                    Conn.DoOutput = true;
                    using (var Os = Conn.OutputStream!) { var B = Encoding.UTF8.GetBytes(TxnReq); Os.Write(B, 0, B.Length); }
                    var RespCode = (int)Conn.ResponseCode;
                    var RespBody = string.Empty;
                    try { using var Sr = new System.IO.StreamReader(RespCode < 400 ? Conn.InputStream! : Conn.ErrorStream!); RespBody = Sr.ReadToEnd(); } catch { }
                    Android.Util.Log.Info("Companion", $"Payment response: {RespCode} {RespBody}");
                    Conn.Disconnect();
                    SendWss(JsonSerializer.Serialize(new { Method = "PaymentResult", Success = RespCode >= 200 && RespCode < 300, Status = RespCode, Body = RespBody }));
                }
                catch (Exception Px)
                {
                    Android.Util.Log.Error("Companion", $"Payment error: {Px.Message}");
                    SendWss(JsonSerializer.Serialize(new { Method = "PaymentResult", Success = false, Error = Px.Message }));
                }
            }
            else if (Method == "ConfirmOtp")
            {
                var Otp = Doc.RootElement.TryGetProperty("Code", out var OtpEl) ? OtpEl.GetString() ?? string.Empty : string.Empty;
                Android.Util.Log.Info("Companion", "ConfirmOtp: " + Otp);
                try
                {
                    EnsureKeyPair();
                    var Ks = Java.Security.KeyStore.GetInstance("AndroidKeyStore")!;
                    Ks.Load(null);
                    var OtpChain = Ks.GetCertificateChain(KeyAlias);
                    var OtpCerts = new string[OtpChain?.Length ?? 0];
                    for (var I = 0; I < OtpCerts.Length; I++) OtpCerts[I] = Convert.ToBase64String(OtpChain![I].GetEncoded()!);
                    var ConfReq = JsonSerializer.Serialize(new { code = Otp, certificates = OtpCerts });
                    var ConfJws = CreateJws("POST", "/api/mt/activations/confirmation", ConfReq);
                    var ConfUrl = new Java.Net.URL(TophBaseUrl + "/api/mt/activations/confirmation");
                    var ConfConn = (Java.Net.HttpURLConnection)ConfUrl.OpenConnection()!;
                    ConfConn.RequestMethod = "POST";
                    ConfConn.SetRequestProperty("Content-Type", "application/json");
                    ConfConn.SetRequestProperty("Accept", "application/jwt");
                    ConfConn.SetRequestProperty("User-Agent", "mobile_cashier_android");
                    ConfConn.SetRequestProperty("X-Request-Signature", ConfJws);
                    ConfConn.ConnectTimeout = 10000;
                    ConfConn.ReadTimeout = 10000;
                    ConfConn.DoOutput = true;
                    using (var Os = ConfConn.OutputStream!) { var B = Encoding.UTF8.GetBytes(ConfReq); Os.Write(B, 0, B.Length); }
                    var ConfStatus = (int)ConfConn.ResponseCode;
                    var ConfBody = string.Empty;
                    try { using var Sr = new System.IO.StreamReader(ConfStatus < 400 ? ConfConn.InputStream! : ConfConn.ErrorStream!); ConfBody = Sr.ReadToEnd(); } catch { }
                    Android.Util.Log.Info("Companion", $"Step 4 OTP Confirm: {ConfStatus} {ConfBody}");
                    ConfConn.Disconnect();
                    if (ConfStatus >= 200 && ConfStatus < 300)
                    {
                        IsActivated = true;
                        Android.Util.Log.Info("Companion", "TERMINAL ACTIVATED!");
                        UpdateNotificationText("Terminal activated!");
                        SendWss(JsonSerializer.Serialize(new { Method = "ActivationComplete", Success = true }));
                    }
                    else
                    {
                        SendWss(JsonSerializer.Serialize(new { Method = "ActivationComplete", Success = false, Error = $"OTP confirm failed: {ConfStatus}" }));
                    }
                }
                catch (Exception OEx) { Android.Util.Log.Error("Companion", "OTP error: " + OEx.Message); SendWss(JsonSerializer.Serialize(new { Method = "ActivationComplete", Success = false, Error = OEx.Message })); }
            }
            else if (Method == "Screenshot")
            {
                Android.Util.Log.Info("Companion", "Screenshot requested");
                try
                {
                    var ScPath = System.IO.Path.Combine(FilesDir!.AbsolutePath, "sc.png");
                    var Process = Java.Lang.Runtime.GetRuntime()!.Exec($"screencap -p {ScPath}");
                    Process!.WaitFor();
                    var Bytes = System.IO.File.ReadAllBytes(ScPath);
                    var B64 = Convert.ToBase64String(Bytes);
                    SendWss(JsonSerializer.Serialize(new { Method = "ScreenData", Image = B64, Width = 1440, Height = 3120 }));
                    Android.Util.Log.Info("Companion", $"Screenshot sent: {Bytes.Length} bytes");
                }
                catch (Exception Se) { Android.Util.Log.Error("Companion", "Screenshot error: " + Se.Message); SendWss(JsonSerializer.Serialize(new { Method = "ScreenData", Error = Se.Message })); }
            }
            else if (Method == "Tap")
            {
                var X = Doc.RootElement.TryGetProperty("X", out var XEl) ? XEl.GetInt32() : 0;
                var Y = Doc.RootElement.TryGetProperty("Y", out var YEl) ? YEl.GetInt32() : 0;
                Android.Util.Log.Info("Companion", $"Tap at {X},{Y}");
                Java.Lang.Runtime.GetRuntime()!.Exec($"input tap {X} {Y}")!.WaitFor();
                Java.Lang.Thread.Sleep(500);
                SendWss(JsonSerializer.Serialize(new { Method = "TapDone", X, Y }));
            }
            else if (Method == "Swipe")
            {
                var X1 = Doc.RootElement.TryGetProperty("X1", out var X1El) ? X1El.GetInt32() : 720;
                var Y1 = Doc.RootElement.TryGetProperty("Y1", out var Y1El) ? Y1El.GetInt32() : 2500;
                var X2 = Doc.RootElement.TryGetProperty("X2", out var X2El) ? X2El.GetInt32() : 720;
                var Y2 = Doc.RootElement.TryGetProperty("Y2", out var Y2El) ? Y2El.GetInt32() : 1000;
                Java.Lang.Runtime.GetRuntime()!.Exec($"input swipe {X1} {Y1} {X2} {Y2} 300")!.WaitFor();
                SendWss(JsonSerializer.Serialize(new { Method = "SwipeDone" }));
            }
            else if (Method == "InputText")
            {
                var Text = Doc.RootElement.TryGetProperty("Text", out var TEl) ? TEl.GetString() ?? "" : "";
                Java.Lang.Runtime.GetRuntime()!.Exec($"input text {Text}")!.WaitFor();
                SendWss(JsonSerializer.Serialize(new { Method = "InputDone" }));
            }
            else if (Method == "KeyEvent")
            {
                var Key = Doc.RootElement.TryGetProperty("Key", out var KEl) ? KEl.GetString() ?? "KEYCODE_HOME" : "KEYCODE_HOME";
                Java.Lang.Runtime.GetRuntime()!.Exec($"input keyevent {Key}")!.WaitFor();
                SendWss(JsonSerializer.Serialize(new { Method = "KeyDone" }));
            }
            else if (Method == "LaunchApp")
            {
                var Pkg = Doc.RootElement.TryGetProperty("Package", out var PkgEl) ? PkgEl.GetString() ?? "" : "";
                var LaunchI = PackageManager?.GetLaunchIntentForPackage(Pkg);
                if (LaunchI != null) { LaunchI.AddFlags(ActivityFlags.NewTask); StartActivity(LaunchI); }
                SendWss(JsonSerializer.Serialize(new { Method = "LaunchDone", Package = Pkg }));
            }
            else if (Method == "LoadHce")
            {
                var Card = EmvCardReader.LastCard;
                if (Card != null) { WillowMaze.Wasm.Companion.Platforms.Android.CardEmulationService.LoadCard(Card); SendWss(JsonSerializer.Serialize(new { Method = "HceLoaded", Card.MaskedPan })); }
                else { SendWss(JsonSerializer.Serialize(new { Method = "HceLoaded", Error = "No card scanned" })); }
            }
            else if (Method == "AutoPay")
            {
                var Amount = Doc.RootElement.TryGetProperty("Amount", out var AEl2) ? AEl2.GetString() ?? "1" : "1";
                Android.Util.Log.Info("Companion", "AutoPay: launching PocketPay for " + Amount + " peso");
                var Card = EmvCardReader.LastCard;
                if (Card != null) WillowMaze.Wasm.Companion.Platforms.Android.CardEmulationService.LoadCard(Card);
                var PpIntent = PackageManager?.GetLaunchIntentForPackage("com.gcash.business.pocketpay");
                if (PpIntent != null) { PpIntent.AddFlags(ActivityFlags.NewTask); StartActivity(PpIntent); }
                SendWss(JsonSerializer.Serialize(new { Method = "AutoPayStarted", Amount, HceActive = Card != null }));
            }
        }
        catch (Exception Ex)
        {
            Android.Util.Log.Error("Companion", $"Command error: {Ex.Message}");
        }
    }

    private void SendWss(string Json)
    {
        try { WsSend(Json); } catch (Exception Ex) { Android.Util.Log.Error("Companion", $"SendWss error: {Ex.Message}"); }
    }

    private static readonly System.Threading.ManualResetEvent CardReadEvent = new(false);
    private static CompanionService? ActiveInstance;
    public static void NotifyCardRead() => CardReadEvent.Set();
    public static void SendCardData(EmvCardReader.CardData Card)
    {
        try
        {
            var CardJson = JsonSerializer.Serialize(new { Method = "CardData", Payload = new { Card.MaskedPan, Card.Pan, Card.Expiry, Card.CardholderName, Card.Network, Card.Atc, Card.Arqc, Card.Cid, Card.Iad, Card.Aid, Track2 = Card.Track2 != null ? Convert.ToHexString(Card.Track2) : null, ChipData = Card.GenerateAcResponse != null ? Convert.ToHexString(Card.GenerateAcResponse) : null } });
            ActiveInstance?.WsSend(CardJson);
            Android.Util.Log.Info("Companion", "CardData sent to backoffice");
        }
        catch (Exception Ex) { Android.Util.Log.Error("Companion", "SendCardData error: " + Ex.Message); }
    }

    private bool IsActivated;
    private const string TophBaseUrl = "https://mob-gcash.t2ph.psr-it.com";
    private const string KeyAlias = "toph_reg_key";

    private void EnsureKeyPair()
    {
        var Ks = Java.Security.KeyStore.GetInstance("AndroidKeyStore")!;
        Ks.Load(null);
        if (Ks.ContainsAlias(KeyAlias)) return;

        var Challenge = Encoding.UTF8.GetBytes("toph-activation-" + DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
        var Spec = new Android.Security.Keystore.KeyGenParameterSpec.Builder(KeyAlias, Android.Security.Keystore.KeyStorePurpose.Sign)
            .SetDigests(Android.Security.Keystore.KeyProperties.DigestSha256)
            .SetSignaturePaddings(Android.Security.Keystore.KeyProperties.SignaturePaddingRsaPkcs1)
            .SetKeySize(2048)
            .SetAttestationChallenge(Challenge)!
            .Build();
        var Kpg = Java.Security.KeyPairGenerator.GetInstance(Android.Security.Keystore.KeyProperties.KeyAlgorithmRsa, "AndroidKeyStore")!;
        Kpg.Initialize(Spec);
        Kpg.GenerateKeyPair();
        var Chain = Ks.GetCertificateChain(KeyAlias);
        Android.Util.Log.Info("Companion", "RSA-2048 attested key generated, cert chain length=" + (Chain?.Length ?? 0));
    }

    private string CreateJws(string Method, string Path, string Body)
    {
        EnsureKeyPair();
        var Ks = Java.Security.KeyStore.GetInstance("AndroidKeyStore")!;
        Ks.Load(null);
        var Entry = (Java.Security.KeyStore.PrivateKeyEntry)Ks.GetEntry(KeyAlias, null)!;
        var PrivKey = Entry.PrivateKey!;
        var Chain = Ks.GetCertificateChain(KeyAlias) ?? new[] { Entry.Certificate! };
        var X5c = new string[Chain.Length];
        for (var I = 0; I < Chain.Length; I++) X5c[I] = Convert.ToBase64String(Chain[I].GetEncoded()!);

        var BodyHash = Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(Encoding.UTF8.GetBytes(Body))).ToLowerInvariant();
        var Nonce = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        var Header = JsonSerializer.Serialize(new { alg = "RS256", x5c = X5c });
        var Payload = JsonSerializer.Serialize(new { nonce = Nonce, method = Method, body = BodyHash, request = (string?)null, auth = (string?)null, fingerprint = (string?)null, device = (string?)null });

        var HeaderB64 = Base64UrlEncode(Encoding.UTF8.GetBytes(Header));
        var PayloadB64 = Base64UrlEncode(Encoding.UTF8.GetBytes(Payload));
        var SignInput = Encoding.UTF8.GetBytes(HeaderB64 + "." + PayloadB64);

        var Sig = Java.Security.Signature.GetInstance("SHA256withRSA")!;
        Sig.InitSign(PrivKey);
        Sig.Update(SignInput);
        var SigBytes = Sig.Sign()!;

        return HeaderB64 + "." + PayloadB64 + "." + Base64UrlEncode(SigBytes);
    }

    private static string Base64UrlEncode(byte[] Data)
    {
        return Convert.ToBase64String(Data).TrimEnd('=').Replace('+', '-').Replace('/', '_');
    }

    private void ActivateTerminal()
    {
        try
        {
            EnsureKeyPair();
            var Ks = Java.Security.KeyStore.GetInstance("AndroidKeyStore")!;
            Ks.Load(null);
            var Chain = Ks.GetCertificateChain(KeyAlias);
            var CertChainB64 = new string[Chain?.Length ?? 0];
            for (var I = 0; I < CertChainB64.Length; I++) CertChainB64[I] = Convert.ToBase64String(Chain![I].GetEncoded()!);
            Android.Util.Log.Info("Companion", "Cert chain: " + CertChainB64.Length + " certs");

            var DeviceInfo = JsonSerializer.Serialize(new
            {
                id = Android.Provider.Settings.Secure.GetString(ContentResolver, Android.Provider.Settings.Secure.AndroidId) ?? "unknown",
                country = "PH", language = "en",
                manufacturer = Android.OS.Build.Manufacturer ?? "unknown",
                model = Android.OS.Build.Model ?? "unknown",
                title = $"{Android.OS.Build.Manufacturer} {Android.OS.Build.Model}",
                osVersionSdk = (int)Android.OS.Build.VERSION.SdkInt,
                osVersion = Android.OS.Build.VERSION.Release ?? "16",
                osName = "Android",
                securityPatch = Android.OS.Build.VERSION.SecurityPatch ?? "",
                appVersion = "1.0.30", appVersionCode = 110304, buildVersion = "1.0.30",
                brand = Android.OS.Build.Brand ?? "unknown",
                product = Android.OS.Build.Product ?? "unknown",
                board = Android.OS.Build.Board ?? "unknown",
                hardware = Android.OS.Build.Hardware ?? "unknown",
                supportedAbis = Android.OS.Build.SupportedAbis ?? Array.Empty<string>(),
                screenWidth = Resources?.DisplayMetrics?.WidthPixels ?? 1440,
                screenHeight = Resources?.DisplayMetrics?.HeightPixels ?? 3120,
                appPackageName = PackageName ?? "com.gcash.business.pocketpay",
                sdkVersion = "1.2.1", sdkVersionCode = 121, sdkBuildVersion = "1.2.1",
                memory = Java.Lang.Runtime.GetRuntime()?.TotalMemory() ?? 0L,
                appClassName = "com.gcash.business.pocketpay.App",
                appProcessName = PackageName ?? "com.gcash.business.pocketpay",
                developerMode = false, appInstaller = "com.android.vending",
                nfcRequired = true, nfcEnabled = true, cameraRequired = false, cameraEnabled = true,
            });

            Android.Util.Log.Info("Companion", "Getting ToPH token...");
            var TophToken = string.Empty;
            try
            {
                var AuthBody = "{\"device_model\":\"" + (Android.OS.Build.Model ?? "SM-S928B") + "\",\"device_brand\":\"" + (Android.OS.Build.Brand ?? "samsung") + "\",\"package_name\":\"com.gcash.business.pocketpay\",\"time_zone_offset\":28800000,\"password\":\"75734616b81a8309f17b2d5bfdd9415b927985aa1fdade85a5b8284582e610e5\",\"app_version\":\"1.0.30\",\"login\":\"639568564236\",\"fcmtoken\":\"companion\",\"android_id\":\"" + (Android.Provider.Settings.Secure.GetString(ContentResolver, Android.Provider.Settings.Secure.AndroidId) ?? "unknown") + "\"}";
                var AuthUrl = new Java.Net.URL("https://pulsar.psr-it.com/api/v3/authorize");
                var AuthConn = (Java.Net.HttpURLConnection)AuthUrl.OpenConnection()!;
                AuthConn.RequestMethod = "POST";
                AuthConn.SetRequestProperty("Content-Type", "application/json");
                AuthConn.SetRequestProperty("platform", "Android");
                AuthConn.ConnectTimeout = 10000;
                AuthConn.ReadTimeout = 10000;
                AuthConn.DoOutput = true;
                using (var Os = AuthConn.OutputStream!) { var B = Encoding.UTF8.GetBytes(AuthBody); Os.Write(B, 0, B.Length); }
                var Jwt = string.Empty;
                if ((int)AuthConn.ResponseCode == 200) { using var Sr = new System.IO.StreamReader(AuthConn.InputStream!); Jwt = Sr.ReadToEnd().Trim(); }
                AuthConn.Disconnect();
                Android.Util.Log.Info("Companion", "JWT: " + (int)AuthConn.ResponseCode + " len=" + Jwt.Length);

                if (Jwt.Length > 0)
                {
                    var TidUrl = new Java.Net.URL("https://pulsar.psr-it.com/api/v2/market/tid/toph");
                    var TidConn = (Java.Net.HttpURLConnection)TidUrl.OpenConnection()!;
                    TidConn.RequestMethod = "POST";
                    TidConn.SetRequestProperty("Content-Type", "application/json");
                    TidConn.SetRequestProperty("Authorization", Jwt);
                    TidConn.SetRequestProperty("platform", "Android");
                    TidConn.ConnectTimeout = 10000;
                    TidConn.ReadTimeout = 10000;
                    TidConn.DoOutput = true;
                    var TidBody = "{\"phone\":639568564236}";
                    using (var Os = TidConn.OutputStream!) { var B = Encoding.UTF8.GetBytes(TidBody); Os.Write(B, 0, B.Length); }
                    if ((int)TidConn.ResponseCode == 200)
                    {
                        using var Sr = new System.IO.StreamReader(TidConn.InputStream!);
                        var TidResp = Sr.ReadToEnd();
                        Android.Util.Log.Info("Companion", "ToPH: " + TidResp[..System.Math.Min(100, TidResp.Length)]);
                        using var Doc = JsonDocument.Parse(TidResp);
                        TophToken = Doc.RootElement.GetProperty("token").GetString() ?? string.Empty;
                    }
                    TidConn.Disconnect();
                }
            }
            catch (Exception TEx) { Android.Util.Log.Error("Companion", "ToPH token error: " + TEx.Message); }

            if (TophToken.Length == 0) { Android.Util.Log.Warn("Companion", "No ToPH token, skipping activation"); return; }

            var ActivationReq = JsonSerializer.Serialize(new
            {
                method = new { kind = "Token", value = TophToken },
                rnsId = Guid.NewGuid().ToString(),
                deviceInfo = JsonSerializer.Deserialize<JsonElement>(DeviceInfo),
                certificates = CertChainB64,
            });

            var Jws = CreateJws("POST", "/api/mt/activations", ActivationReq);
            Android.Util.Log.Info("Companion", $"Activating with ToPH token (JWS len={Jws.Length})...");

            var Url = new Java.Net.URL($"{TophBaseUrl}/api/mt/activations");
            var Conn = (Java.Net.HttpURLConnection)Url.OpenConnection()!;
            Conn.RequestMethod = "POST";
            Conn.SetRequestProperty("Content-Type", "application/json");
            Conn.SetRequestProperty("User-Agent", "mobile_cashier_android");
            Conn.SetRequestProperty("Authorization", "Bearer " + TophToken);
            Conn.ConnectTimeout = 10000;
            Conn.ReadTimeout = 10000;
            Conn.DoOutput = true;
            using (var Os = Conn.OutputStream!)
            {
                var ReqBytes = Encoding.UTF8.GetBytes(ActivationReq);
                Os.Write(ReqBytes, 0, ReqBytes.Length);
            }
            var StatusCode = (int)Conn.ResponseCode;
            var Body = string.Empty;
            try { using var Sr = new System.IO.StreamReader(StatusCode < 400 ? Conn.InputStream! : Conn.ErrorStream!); Body = Sr.ReadToEnd(); } catch { }
            Android.Util.Log.Info("Companion", $"Activation: {StatusCode} {Body}");
            Conn.Disconnect();

            if (StatusCode >= 200 && StatusCode < 300)
            {
                var ActToken = string.Empty;
                var ActChallenge = string.Empty;
                if (Body.Length > 0) { try { using var ActDoc = JsonDocument.Parse(Body); ActToken = ActDoc.RootElement.TryGetProperty("activationToken", out var AtEl) ? AtEl.GetString() ?? string.Empty : string.Empty; ActChallenge = ActDoc.RootElement.TryGetProperty("challenge", out var AcEl) ? AcEl.GetString() ?? string.Empty : string.Empty; } catch { } }
                Android.Util.Log.Info("Companion", "Step 1 OK - token=" + ActToken.Length + " challenge=" + ActChallenge.Length);
                UpdateNotificationText("Step 1 OK - attestation...");

                var AttReq = JsonSerializer.Serialize(new { deviceInfo = JsonSerializer.Deserialize<JsonElement>(DeviceInfo) });
                var AttJws = CreateJws("POST", "/api/mt/activations/attestation/v5", AttReq);
                var AttUrl = new Java.Net.URL($"{TophBaseUrl}/api/mt/activations/attestation/v5");
                var AttConn = (Java.Net.HttpURLConnection)AttUrl.OpenConnection()!;
                AttConn.RequestMethod = "POST";
                AttConn.SetRequestProperty("Content-Type", "application/json");
                AttConn.SetRequestProperty("Accept", "application/jwt");
                AttConn.SetRequestProperty("User-Agent", "mobile_cashier_android");
                AttConn.SetRequestProperty("X-Request-Signature", AttJws);
                AttConn.ConnectTimeout = 10000;
                AttConn.ReadTimeout = 10000;
                AttConn.DoOutput = true;
                using (var Os = AttConn.OutputStream!) { var B = Encoding.UTF8.GetBytes(AttReq); Os.Write(B, 0, B.Length); }
                var AttStatus = (int)AttConn.ResponseCode;
                var AttBody = string.Empty;
                try { using var Sr = new System.IO.StreamReader(AttStatus < 400 ? AttConn.InputStream! : AttConn.ErrorStream!); AttBody = Sr.ReadToEnd(); } catch { }
                Android.Util.Log.Info("Companion", $"Step 2 Attestation: {AttStatus} {AttBody[..System.Math.Min(200, AttBody.Length)]}");
                AttConn.Disconnect();

                if (AttStatus >= 200 && AttStatus < 300 && AttBody.Length > 0)
                {
                    Android.Util.Log.Info("Companion", "Step 2 OK - Got attestation challenge. Getting Play Integrity token...");
                    using var AttDoc = JsonDocument.Parse(AttBody);
                    var Nonce = AttDoc.RootElement.TryGetProperty("nonce", out var NEl) ? NEl.GetString() ?? string.Empty : string.Empty;

                    var AppCode = string.Empty;
                    try
                    {
                        var IntCtx = (global::Android.Content.Context?)MainActivity.Instance ?? ApplicationContext!;
                        var IntManager = Xamarin.Google.Android.Play.Core.Integrity.IntegrityManagerFactory.Create(IntCtx)!;
                        var IntBuilder = Xamarin.Google.Android.Play.Core.Integrity.IntegrityTokenRequest.InvokeBuilder()!;
                        IntBuilder.SetCloudProjectNumber(439060024453L);
                        IntBuilder.SetNonce(Nonce);
                        var IntReq = IntBuilder.Build()!;
                        var IntTask = IntManager.RequestIntegrityToken(IntReq)!;
                        while (!IntTask.IsComplete) { Java.Lang.Thread.Sleep(100); }
                        if (IntTask.IsSuccessful)
                        {
                            var IntResponse = IntTask.Result as Xamarin.Google.Android.Play.Core.Integrity.IntegrityTokenResponse;
                            AppCode = IntResponse?.Token() ?? string.Empty;
                            Android.Util.Log.Info("Companion", "Play Integrity token: len=" + AppCode.Length);
                        }
                        else
                        {
                            Android.Util.Log.Error("Companion", "Play Integrity failed: " + IntTask.Exception?.Message);
                        }
                    }
                    catch (Exception PiEx) { Android.Util.Log.Error("Companion", "Play Integrity error: " + PiEx.Message); }

                    var ConfAttReq = JsonSerializer.Serialize(new { data = Nonce, secret = AppCode, rnsId = Guid.NewGuid().ToString(), certificates = CertChainB64 });
                    var ConfAttJws = CreateJws("POST", "/api/mt/activations/attestation/v5/confirmation", ConfAttReq);
                    var ConfAttUrl = new Java.Net.URL($"{TophBaseUrl}/api/mt/activations/attestation/v5/confirmation");
                    var ConfAttConn = (Java.Net.HttpURLConnection)ConfAttUrl.OpenConnection()!;
                    ConfAttConn.RequestMethod = "POST";
                    ConfAttConn.SetRequestProperty("Content-Type", "application/json");
                    ConfAttConn.SetRequestProperty("Accept", "application/jwt");
                    ConfAttConn.SetRequestProperty("User-Agent", "mobile_cashier_android");
                    ConfAttConn.SetRequestProperty("X-Request-Signature", ConfAttJws);
                    ConfAttConn.ConnectTimeout = 10000;
                    ConfAttConn.ReadTimeout = 10000;
                    ConfAttConn.DoOutput = true;
                    using (var Os = ConfAttConn.OutputStream!) { var B = Encoding.UTF8.GetBytes(ConfAttReq); Os.Write(B, 0, B.Length); }
                    var ConfAttStatus = (int)ConfAttConn.ResponseCode;
                    var ConfAttBody = string.Empty;
                    try { using var Sr = new System.IO.StreamReader(ConfAttStatus < 400 ? ConfAttConn.InputStream! : ConfAttConn.ErrorStream!); ConfAttBody = Sr.ReadToEnd(); } catch { }
                    Android.Util.Log.Info("Companion", $"Step 3 Confirm Attestation: {ConfAttStatus} {ConfAttBody[..System.Math.Min(200, ConfAttBody.Length)]}");
                    ConfAttConn.Disconnect();

                    if (ConfAttStatus >= 200 && ConfAttStatus < 300)
                    {
                        Android.Util.Log.Info("Companion", "Step 3 OK - Attestation confirmed. Waiting for OTP...");
                        UpdateNotificationText("OTP sent to phone — enter in app");
                        SendWss(JsonSerializer.Serialize(new { Method = "ActivationOtpRequired" }));
                        IsActivated = true;
                    }
                }
            }
            else
            {
                Android.Util.Log.Warn("Companion", $"Activation failed: {StatusCode} {Body}");
            }
        }
        catch (Exception Ex)
        {
            Android.Util.Log.Error("Companion", $"Activation error: {Ex.Message}");
        }
        ScanForBackoffice();
    }

    private void ScanForBackoffice()
    {
        Android.Util.Log.Info("Companion", "Scanning subnet for backoffice...");
        try
        {
            var Wifi = (Android.Net.Wifi.WifiManager?)GetSystemService(WifiService);
            var DhcpInfo = Wifi?.DhcpInfo;
            var Gateway = DhcpInfo?.Gateway ?? 0;
            var MyIp = DhcpInfo?.IpAddress ?? 0;
            var Subnet = MyIp & 0x00FFFFFF;
            Android.Util.Log.Info("Companion", $"My IP: {MyIp & 0xFF}.{(MyIp >> 8) & 0xFF}.{(MyIp >> 16) & 0xFF}.{(MyIp >> 24) & 0xFF}");

            for (var I = 1; I < 255 && IsRunning; I++)
            {
                var Ip = Subnet | (I << 24);
                var Host = $"{Ip & 0xFF}.{(Ip >> 8) & 0xFF}.{(Ip >> 16) & 0xFF}.{(Ip >> 24) & 0xFF}";
                try
                {
                    using var Sock = new Java.Net.Socket();
                    Sock.Connect(new Java.Net.InetSocketAddress(Host, 8769), 100);
                    Sock.Close();
                    Android.Util.Log.Info("Companion", $"Found backoffice at {Host}:8769");
                    BackofficeHost = Host;
                    BackofficePort = 8769;
                    ConnectToBackoffice();
                    return;
                }
                catch { continue; }
            }

            Android.Util.Log.Warn("Companion", "No backoffice found via scan");
        }
        catch (Exception Ex) { Android.Util.Log.Error("Companion", $"Scan error: {Ex.Message}"); }
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
        var Channel = new NotificationChannel(ChannelId, "Companion Service", NotificationImportance.Low);
        var Manager = GetSystemService(NotificationService) as NotificationManager;
        Manager?.CreateNotificationChannel(Channel);
    }
}
