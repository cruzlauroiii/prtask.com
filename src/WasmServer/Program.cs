using System.Net.Security;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.FileProviders;

var Root = new PhysicalFileProvider(@"C:\work\prtask.com\src\PocketPay.Wasm\bin\Release\net11.0\publish\wwwroot");
var Builder = WebApplication.CreateBuilder(args);
Builder.WebHost.UseUrls("https://localhost:5000");
var App = Builder.Build();
App.UseWebSockets();
App.Use(async (Ctx, Next) =>
{
    if (Ctx.Request.Path == "/ws" && Ctx.WebSockets.IsWebSocketRequest)
    {
        Console.WriteLine("[PROXY] Browser connecting");
        var BrowserWs = await Ctx.WebSockets.AcceptWebSocketAsync();

        var Tcp = new TcpClient();
        await Tcp.ConnectAsync("127.0.0.1", 8769);
        var Ssl = new SslStream(Tcp.GetStream(), false, (_, _, _, _) => true);
        await Ssl.AuthenticateAsClientAsync("localhost");

        var WsKey = Convert.ToBase64String(RandomNumberGenerator.GetBytes(16));
        var Handshake = $"GET / HTTP/1.1\r\nHost: localhost:8769\r\nUpgrade: websocket\r\nConnection: Upgrade\r\nSec-WebSocket-Key: {WsKey}\r\nSec-WebSocket-Version: 13\r\n\r\n";
        await Ssl.WriteAsync(Encoding.UTF8.GetBytes(Handshake));
        await Ssl.FlushAsync();

        var RespBuf = new byte[1024];
        var RespLen = await Ssl.ReadAsync(RespBuf);
        var RespStr = Encoding.UTF8.GetString(RespBuf, 0, RespLen);
        if (!RespStr.Contains("101"))
        {
            Console.WriteLine($"[PROXY] Handshake failed: {RespStr}");
            return;
        }
        Console.WriteLine("[PROXY] Connected to Backoffice via raw WSS");

        using var Cts = new CancellationTokenSource();

        _ = Task.Run(async () =>
        {
            var Buf = new byte[16384];
            try
            {
                while (!Cts.Token.IsCancellationRequested)
                {
                    var B0 = await ReadByte(Ssl);
                    var B1 = await ReadByte(Ssl);
                    var Len = B1 & 0x7F;
                    if (Len == 126)
                    {
                        var Lb = new byte[2];
                        await Ssl.ReadExactlyAsync(Lb, Cts.Token);
                        Len = (Lb[0] << 8) | Lb[1];
                    }
                    var Data = new byte[Len];
                    var Read = 0;
                    while (Read < Len)
                    {
                        var N = await Ssl.ReadAsync(Data.AsMemory(Read, Len - Read), Cts.Token);
                        if (N <= 0)
                        {
                            break;
                        }

                        Read += N;
                    }
                    Console.WriteLine($"[PROXY] Backend->Browser: {Len} bytes");
                    await BrowserWs.SendAsync(Data, WebSocketMessageType.Text, true, Cts.Token);
                }
            }
            catch (Exception Ex) { Console.WriteLine($"[PROXY] Backend->Browser done: {Ex.Message}"); }
        });

        var Buf2 = new byte[16384];
        try
        {
            while (!Cts.Token.IsCancellationRequested)
            {
                var R = await BrowserWs.ReceiveAsync(Buf2, Cts.Token);
                if (R.MessageType == WebSocketMessageType.Close)
                {
                    break;
                }

                Console.WriteLine($"[PROXY] Browser->Backend: {R.Count} bytes");
                var Payload = new byte[R.Count];
                Array.Copy(Buf2, Payload, R.Count);
                var Mask = RandomNumberGenerator.GetBytes(4);
                using var Ms = new MemoryStream();
                Ms.WriteByte(0x81);
                if (Payload.Length < 126)
                {
                    Ms.WriteByte((byte)(0x80 | Payload.Length));
                }
                else
                {
                    Ms.WriteByte(0xFE);
                    Ms.WriteByte((byte)(Payload.Length >> 8));
                    Ms.WriteByte((byte)(Payload.Length & 0xFF));
                }
                Ms.Write(Mask);
                for (var I = 0; I < Payload.Length; I++)
                {
                    Ms.WriteByte((byte)(Payload[I] ^ Mask[I % 4]));
                }

                var Frame = Ms.ToArray();
                await Ssl.WriteAsync(Frame);
                await Ssl.FlushAsync();
            }
        }
        catch (Exception Ex) { Console.WriteLine($"[PROXY] Browser->Backend done: {Ex.Message}"); }

        await Cts.CancelAsync();
        Tcp.Close();
        Console.WriteLine("[PROXY] Connection closed");
        return;
    }
    await Next();
});
App.UseDefaultFiles(new DefaultFilesOptions { FileProvider = Root });
App.UseStaticFiles(new StaticFileOptions { FileProvider = Root, ServeUnknownFileTypes = true });
App.MapGet("/companion.apk", async (HttpContext Ctx) =>
{
    var ApkPath = Directory.GetFiles(@"C:\work\prtask.com\src\PocketPay.Wasm\WillowMaze.Wasm.Companion\bin\Release\net11.0-android36.0", "*-Signed.apk").FirstOrDefault();
    if (ApkPath != null)
    {
        Ctx.Response.ContentType = "application/vnd.android.package-archive";
        await Ctx.Response.SendFileAsync(ApkPath);
    }
    else
    {
        Ctx.Response.StatusCode = 404;
    }
});
App.MapPost("/wss-proxy/{**Path}", async (HttpContext Ctx, string Path) =>
{
    Ctx.Response.ContentType = "application/json";
    await Ctx.Response.WriteAsync("{\"Success\":false,\"Error\":\"Not connected to backoffice\"}");
});
App.MapFallback(async Ctx =>
{
    if (Ctx.Request.Path.StartsWithSegments("/wss-proxy"))
    {
        Ctx.Response.ContentType = "application/json";
        await Ctx.Response.WriteAsync("{\"Success\":false,\"Error\":\"Not connected\"}");
        return;
    }
    Ctx.Response.ContentType = "text/html";
    await Ctx.Response.SendFileAsync(@"C:\work\prtask.com\src\PocketPay.Wasm\bin\Release\net11.0\publish\wwwroot\index.html");
});
Console.WriteLine("WASM on https://localhost:5000 (WSS proxy at /ws)");
App.Run();

static async Task<byte> ReadByte(SslStream S)
{
    var B = new byte[1];
    var N = await S.ReadAsync(B);
    return N > 0 ? B[0] : throw new EndOfStreamException();
}
