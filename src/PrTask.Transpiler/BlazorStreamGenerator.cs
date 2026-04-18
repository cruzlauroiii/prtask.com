using System.Text;

namespace PrTask.Transpiler;

public sealed class BlazorStreamGenerator
{
    private readonly string OutputDir;
    private readonly string Namespace;
    private readonly string AppTitle;
    private readonly string ExePath;

    public BlazorStreamGenerator(string OutputDir, string Namespace, string AppTitle, string ExePath)
    {
        this.OutputDir = OutputDir;
        this.Namespace = Namespace;
        this.AppTitle = AppTitle;
        this.ExePath = ExePath;
    }

    public void Generate()
    {
        Directory.CreateDirectory(OutputDir);
        Directory.CreateDirectory(Path.Combine(OutputDir, "wwwroot"));
        Directory.CreateDirectory(Path.Combine(OutputDir, "wwwroot", "css"));

        WriteCsproj();
        WriteProgram();
        WriteWindowCapture();
        WriteIndexHtml();
        WriteCss();
    }

    private void WriteCsproj()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("<Project Sdk=\"Microsoft.NET.Sdk.Web\">");
        Sb.AppendLine("  <PropertyGroup>");
        Sb.AppendLine("    <TargetFramework>net11.0</TargetFramework>");
        Sb.AppendLine("    <ImplicitUsings>enable</ImplicitUsings>");
        Sb.AppendLine("    <Nullable>enable</Nullable>");
        Sb.AppendLine("    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>");
        Sb.AppendLine("    <NoWarn>$(NoWarn);SA1132;SA1503;SA1633;CS1069;CS1591;PT003;PT004;PT005;PT006;PT007;CA1050;CA1416;CA1806;CA1838;CA5394;IDE0011;IDE0028;IDE0350;MA0047;S101;S3903;SYSLIB0014</NoWarn>");
        Sb.AppendLine("  </PropertyGroup>");
        Sb.AppendLine("  <ItemGroup>");
        Sb.AppendLine("    <PackageReference Include=\"System.Drawing.Common\" Version=\"9.*\" />");
        Sb.AppendLine("  </ItemGroup>");
        Sb.AppendLine("</Project>");

        File.WriteAllText(Path.Combine(OutputDir, Namespace + ".csproj"), Sb.ToString());
    }

    private void WriteProgram()
    {
        var EscapedExe = ExePath.Replace("\\", "\\\\");
        var Sb = new StringBuilder();
        Sb.AppendLine("WindowCapture.RegisterCleanup();");
        Sb.AppendLine("WindowCapture.RegisterCleanup();");
        Sb.AppendLine("var Builder = WebApplication.CreateBuilder(args);");
        Sb.AppendLine("var App = Builder.Build();");
        Sb.AppendLine("App.UseDefaultFiles();");
        Sb.AppendLine("App.UseStaticFiles();");
        Sb.AppendLine("App.UseWebSockets();");
        Sb.AppendLine("App.Map(\"/ws\", async (HttpContext Ctx) =>");
        Sb.AppendLine("{");
        Sb.AppendLine("    if (!Ctx.WebSockets.IsWebSocketRequest) { Ctx.Response.StatusCode = 400; return; }");
        Sb.AppendLine("    var Ws = await Ctx.WebSockets.AcceptWebSocketAsync();");
        Sb.Append("    await WindowCapture.StreamAsync(Ws, @\"").Append(EscapedExe).AppendLine("\");");
        Sb.AppendLine("});");
        Sb.AppendLine("App.Run();");
        Sb.AppendLine("WindowCapture.KillAll();");
        Sb.AppendLine("WindowCapture.KillAll();");

        File.WriteAllText(Path.Combine(OutputDir, "Program.cs"), Sb.ToString());
    }

    private void WriteWindowCapture()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("using System.Diagnostics;");
        Sb.AppendLine("using System.Drawing;");
        Sb.AppendLine("using System.Drawing.Imaging;");
        Sb.AppendLine("using System.Net.WebSockets;");
        Sb.AppendLine("using System.Runtime.InteropServices;");
        Sb.AppendLine();
        Sb.AppendLine("public static partial class WindowCapture");
        Sb.AppendLine("{");
        Sb.AppendLine("    [LibraryImport(\"user32.dll\")]");
        Sb.AppendLine("    private static partial nint GetDC(nint Hwnd);");
        Sb.AppendLine();
        Sb.AppendLine("    [LibraryImport(\"user32.dll\")]");
        Sb.AppendLine("    private static partial int ReleaseDC(nint Hwnd, nint Hdc);");
        Sb.AppendLine();
        Sb.AppendLine("    [LibraryImport(\"user32.dll\")]");
        Sb.AppendLine("    [return: MarshalAs(UnmanagedType.Bool)]");
        Sb.AppendLine("    private static partial bool GetWindowRect(nint Hwnd, out RECT Rect);");
        Sb.AppendLine();
        Sb.AppendLine("    [LibraryImport(\"user32.dll\")]");
        Sb.AppendLine("    [return: MarshalAs(UnmanagedType.Bool)]");
        Sb.AppendLine("    private static partial bool GetClientRect(nint Hwnd, out RECT Rect);");
        Sb.AppendLine();
        Sb.AppendLine("    [LibraryImport(\"user32.dll\")]");
        Sb.AppendLine("    [return: MarshalAs(UnmanagedType.Bool)]");
        Sb.AppendLine("    private static partial bool PrintWindow(nint Hwnd, nint HdcBlt, uint Flags);");
        Sb.AppendLine();
        Sb.AppendLine("    [LibraryImport(\"user32.dll\")]");
        Sb.AppendLine("    [return: MarshalAs(UnmanagedType.Bool)]");
        Sb.AppendLine("    private static partial bool ShowWindow(nint Hwnd, int Cmd);");
        Sb.AppendLine();
        Sb.AppendLine("    [LibraryImport(\"user32.dll\")]");
        Sb.AppendLine("    [return: MarshalAs(UnmanagedType.Bool)]");
        Sb.AppendLine("    private static partial bool MoveWindow(nint Hwnd, int X, int Y, int W, int H, [MarshalAs(UnmanagedType.Bool)] bool Repaint);");
        Sb.AppendLine();
        Sb.AppendLine("    [LibraryImport(\"user32.dll\")]");
        Sb.AppendLine("    private static partial nint SendMessageW(nint Hwnd, uint Msg, nint WParam, nint LParam);");
        Sb.AppendLine();
        Sb.AppendLine("    [LibraryImport(\"user32.dll\")]");
        Sb.AppendLine("    [return: MarshalAs(UnmanagedType.Bool)]");
        Sb.AppendLine("    private static partial bool PostMessageW(nint Hwnd, uint Msg, nint WParam, nint LParam);");
        Sb.AppendLine();
        Sb.AppendLine("    [LibraryImport(\"gdi32.dll\")]");
        Sb.AppendLine("    private static partial nint CreateCompatibleDC(nint Hdc);");
        Sb.AppendLine();
        Sb.AppendLine("    [LibraryImport(\"gdi32.dll\")]");
        Sb.AppendLine("    private static partial nint CreateCompatibleBitmap(nint Hdc, int Width, int Height);");
        Sb.AppendLine();
        Sb.AppendLine("    [LibraryImport(\"gdi32.dll\")]");
        Sb.AppendLine("    private static partial nint SelectObject(nint Hdc, nint Obj);");
        Sb.AppendLine();
        Sb.AppendLine("    [LibraryImport(\"gdi32.dll\")]");
        Sb.AppendLine("    [return: MarshalAs(UnmanagedType.Bool)]");
        Sb.AppendLine("    private static partial bool DeleteObject(nint Obj);");
        Sb.AppendLine();
        Sb.AppendLine("    [LibraryImport(\"gdi32.dll\")]");
        Sb.AppendLine("    [return: MarshalAs(UnmanagedType.Bool)]");
        Sb.AppendLine("    private static partial bool DeleteDC(nint Hdc);");
        Sb.AppendLine();
        Sb.AppendLine("    [StructLayout(LayoutKind.Sequential)]");
        Sb.AppendLine("    private struct RECT { public int Left, Top, Right, Bottom; }");
        Sb.AppendLine();
        Sb.AppendLine("    private static readonly List<Process> Processes = new();");
        Sb.AppendLine();
        Sb.AppendLine("    public static void RegisterCleanup()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        AppDomain.CurrentDomain.ProcessExit += (_, _) => KillAll();");
        Sb.AppendLine("        Console.CancelKeyPress += (_, _) => KillAll();");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    public static void KillAll()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        foreach (var P in Processes)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            try { if (!P.HasExited) P.Kill(true); } catch { }");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private static readonly List<Process> Processes = new();");
        Sb.AppendLine();
        Sb.AppendLine("    public static void RegisterCleanup()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        AppDomain.CurrentDomain.ProcessExit += (_, _) => KillAll();");
        Sb.AppendLine("        Console.CancelKeyPress += (_, _) => KillAll();");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    public static void KillAll()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        foreach (var P in Processes)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            try { if (!P.HasExited) P.Kill(true); } catch { }");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private static nint MakeLParam(int X, int Y) => (nint)((Y << 16) | (X & 0xFFFF));");
        Sb.AppendLine();
        Sb.AppendLine("    public static async Task StreamAsync(WebSocket Ws, string ExePath)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        var Psi = new ProcessStartInfo");
        Sb.AppendLine("        {");
        Sb.AppendLine("            FileName = ExePath,");
        Sb.AppendLine("            UseShellExecute = true,");
        Sb.AppendLine("            WorkingDirectory = Path.GetDirectoryName(ExePath) ?? string.Empty,");
        Sb.AppendLine("        };");
        Sb.AppendLine("        var Proc = Process.Start(Psi)!;");
        Sb.AppendLine("        Processes.Add(Proc);");
        Sb.AppendLine("        Processes.Add(Proc);");
        Sb.AppendLine("        await Task.Delay(5000);");
        Sb.AppendLine("        Proc.Refresh();");
        Sb.AppendLine("        var Hwnd = Proc.MainWindowHandle;");
        Sb.AppendLine("        if (Hwnd == nint.Zero)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            await Task.Delay(5000);");
        Sb.AppendLine("            Proc.Refresh();");
        Sb.AppendLine("            Hwnd = Proc.MainWindowHandle;");
        Sb.AppendLine("        }");
        Sb.AppendLine();
        Sb.AppendLine("        MoveWindow(Hwnd, -32000, -32000, 1920, 1080, true);");
        Sb.AppendLine();
        Sb.AppendLine("        var Encoder = ImageCodecInfo.GetImageEncoders().First(E => E.MimeType == \"image/jpeg\");");
        Sb.AppendLine("        var EncoderParams = new EncoderParameters(1);");
        Sb.AppendLine("        EncoderParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 60L);");
        Sb.AppendLine();
        Sb.AppendLine("        var Buffer = new byte[1024];");
        Sb.AppendLine("        var InputTask = Task.Run(async () =>");
        Sb.AppendLine("        {");
        Sb.AppendLine("            while (Ws.State == WebSocketState.Open)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                var Result = await Ws.ReceiveAsync(Buffer, CancellationToken.None);");
        Sb.AppendLine("                if (Result.MessageType == WebSocketMessageType.Close) break;");
        Sb.AppendLine("                if (Result.Count >= 9 && Hwnd != nint.Zero)");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    var Type = Buffer[0];");
        Sb.AppendLine("                    var X = BitConverter.ToInt32(Buffer, 1);");
        Sb.AppendLine("                    var Y = BitConverter.ToInt32(Buffer, 5);");
        Sb.AppendLine("                    var Lp = MakeLParam(X, Y);");
        Sb.AppendLine("                    if (Type == 1)");
        Sb.AppendLine("                    {");
        Sb.AppendLine("                        PostMessageW(Hwnd, 0x0200, 0, Lp);");
        Sb.AppendLine("                        PostMessageW(Hwnd, 0x0201, 1, Lp);");
        Sb.AppendLine("                    }");
        Sb.AppendLine("                    else if (Type == 2)");
        Sb.AppendLine("                    {");
        Sb.AppendLine("                        PostMessageW(Hwnd, 0x0202, 0, Lp);");
        Sb.AppendLine("                    }");
        Sb.AppendLine("                    else if (Type == 3)");
        Sb.AppendLine("                    {");
        Sb.AppendLine("                        PostMessageW(Hwnd, 0x0200, 0, Lp);");
        Sb.AppendLine("                    }");
        Sb.AppendLine("                }");
        Sb.AppendLine("            }");
        Sb.AppendLine("        });");
        Sb.AppendLine();
        Sb.AppendLine("        while (Ws.State == WebSocketState.Open && !Proc.HasExited)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            try");
        Sb.AppendLine("            {");
        Sb.AppendLine("                if (Hwnd == nint.Zero) { Proc.Refresh(); Hwnd = Proc.MainWindowHandle; await Task.Delay(1000); continue; }");
        Sb.AppendLine("                GetClientRect(Hwnd, out var Rect);");
        Sb.AppendLine("                var W = Rect.Right - Rect.Left;");
        Sb.AppendLine("                var H = Rect.Bottom - Rect.Top;");
        Sb.AppendLine("                if (W <= 0 || H <= 0) { await Task.Delay(100); continue; }");
        Sb.AppendLine("                var SrcDc = GetDC(Hwnd);");
        Sb.AppendLine("                var MemDc = CreateCompatibleDC(SrcDc);");
        Sb.AppendLine("                var HBmp = CreateCompatibleBitmap(SrcDc, W, H);");
        Sb.AppendLine("                var Old = SelectObject(MemDc, HBmp);");
        Sb.AppendLine("                PrintWindow(Hwnd, MemDc, 2);");
        Sb.AppendLine("                SelectObject(MemDc, Old);");
        Sb.AppendLine("                using var Bmp = Image.FromHbitmap(HBmp);");
        Sb.AppendLine("                DeleteObject(HBmp);");
        Sb.AppendLine("                DeleteDC(MemDc);");
        Sb.AppendLine("                ReleaseDC(Hwnd, SrcDc);");
        Sb.AppendLine("                using var Ms = new MemoryStream();");
        Sb.AppendLine("                Bmp.Save(Ms, Encoder, EncoderParams);");
        Sb.AppendLine("                await Ws.SendAsync(Ms.ToArray(), WebSocketMessageType.Binary, true, CancellationToken.None);");
        Sb.AppendLine("            }");
        Sb.AppendLine("            catch { }");
        Sb.AppendLine("            await Task.Delay(33);");
        Sb.AppendLine("        }");
        Sb.AppendLine();
        Sb.AppendLine("        if (!Proc.HasExited) Proc.Kill();");
        Sb.AppendLine("        if (Ws.State == WebSocketState.Open)");
        Sb.AppendLine("            await Ws.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None);");
        Sb.AppendLine("    }");
        Sb.AppendLine("}");

        File.WriteAllText(Path.Combine(OutputDir, "WindowCapture.cs"), Sb.ToString());
    }

    private void WriteIndexHtml()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("<!DOCTYPE html>");
        Sb.AppendLine("<html lang=\"en\">");
        Sb.AppendLine("<head>");
        Sb.AppendLine("    <meta charset=\"utf-8\" />");
        Sb.AppendLine("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />");
        Sb.Append("    <title>").Append(AppTitle).AppendLine("</title>");
        Sb.AppendLine("    <link rel=\"stylesheet\" href=\"css/app.css\" />");
        Sb.AppendLine("</head>");
        Sb.AppendLine("<body>");
        Sb.Append("    <canvas id=\"screen\" tabindex=\"1\"></canvas>");
        Sb.AppendLine();
        Sb.AppendLine("    <script>");
        Sb.AppendLine("    (function() {");
        Sb.AppendLine("        var C = document.getElementById('screen');");
        Sb.AppendLine("        var Ctx = C.getContext('2d');");
        Sb.AppendLine("        var Ws = new WebSocket((location.protocol === 'https:' ? 'wss://' : 'ws://') + location.host + '/ws');");
        Sb.AppendLine("        Ws.binaryType = 'arraybuffer';");
        Sb.AppendLine("        Ws.onmessage = function(E) {");
        Sb.AppendLine("            var Blob = new Blob([new Uint8Array(E.data)], {type:'image/jpeg'});");
        Sb.AppendLine("            var Url = URL.createObjectURL(Blob);");
        Sb.AppendLine("            var Img = new Image();");
        Sb.AppendLine("            Img.onload = function() {");
        Sb.AppendLine("                if (C.width !== Img.width || C.height !== Img.height) {");
        Sb.AppendLine("                    C.width = Img.width; C.height = Img.height;");
        Sb.AppendLine("                }");
        Sb.AppendLine("                Ctx.drawImage(Img, 0, 0);");
        Sb.AppendLine("                URL.revokeObjectURL(Url);");
        Sb.AppendLine("            };");
        Sb.AppendLine("            Img.src = Url;");
        Sb.AppendLine("        };");
        Sb.AppendLine("        function Send(Type, E) {");
        Sb.AppendLine("            if (Ws.readyState !== 1) return;");
        Sb.AppendLine("            var R = C.getBoundingClientRect();");
        Sb.AppendLine("            var X = Math.round((E.clientX - R.left) * (C.width / R.width));");
        Sb.AppendLine("            var Y = Math.round((E.clientY - R.top) * (C.height / R.height));");
        Sb.AppendLine("            var B = new ArrayBuffer(9); var V = new DataView(B);");
        Sb.AppendLine("            V.setUint8(0, Type); V.setInt32(1, X, true); V.setInt32(5, Y, true);");
        Sb.AppendLine("            Ws.send(B);");
        Sb.AppendLine("        }");
        Sb.AppendLine("        C.addEventListener('mousedown', function(E) { Send(1, E); });");
        Sb.AppendLine("        C.addEventListener('mouseup', function(E) { Send(2, E); });");
        Sb.AppendLine("        C.addEventListener('mousemove', function(E) { if (E.buttons) Send(3, E); });");
        Sb.AppendLine("        window.addEventListener('beforeunload', function() { Ws.close(); });");
        Sb.AppendLine("    })();");
        Sb.AppendLine("    </script>");
        Sb.AppendLine("</body>");
        Sb.AppendLine("</html>");

        File.WriteAllText(Path.Combine(OutputDir, "wwwroot", "index.html"), Sb.ToString());
    }

    private void WriteCss()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("html, body { margin: 0; padding: 0; background: #000; overflow: hidden; width: 100vw; height: 100vh; }");
        Sb.AppendLine("#screen { display: block; width: 100vw; height: 100vh; object-fit: contain; cursor: default; }");

        File.WriteAllText(Path.Combine(OutputDir, "wwwroot", "css", "app.css"), Sb.ToString());
    }
}
