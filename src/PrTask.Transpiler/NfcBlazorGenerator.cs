using System.Text;
using PrTask.Domain.Constants;

namespace PrTask.Transpiler;

public sealed class NfcBlazorGenerator
{
    private readonly string OutputDir;
    private readonly string Namespace;
    private readonly string AppTitle;
    private readonly List<ExtractedAssembly> AppAssemblies;
    private readonly IlToSharpDecompiler Decompiler;

    public NfcBlazorGenerator(string OutputDir, string Namespace, string AppTitle, List<ExtractedAssembly> AppAssemblies)
    {
        this.OutputDir = OutputDir;
        this.Namespace = Namespace;
        this.AppTitle = AppTitle;
        this.AppAssemblies = AppAssemblies;
        this.Decompiler = new IlToSharpDecompiler();

        foreach (var Asm in AppAssemblies)
        {
            Decompiler.LoadAssembly(Asm.FilePath);
        }
    }

    public void Generate()
    {
        Directory.CreateDirectory(OutputDir);
        Directory.CreateDirectory(Path.Combine(OutputDir, ApkConstants.WwwrootDirectory));
        Directory.CreateDirectory(Path.Combine(OutputDir, ApkConstants.WwwrootDirectory, ApkConstants.CssDirectory));
        Directory.CreateDirectory(Path.Combine(OutputDir, ApkConstants.PagesDirectory));
        Directory.CreateDirectory(Path.Combine(OutputDir, ApkConstants.LayoutDirectory));
        Directory.CreateDirectory(Path.Combine(OutputDir, ApkConstants.ServicesDirectory));
        Directory.CreateDirectory(Path.Combine(OutputDir, ApkConstants.ModelsDirectory));

        WriteCsproj();
        WriteProgram();
        WriteImports();
        WriteAppRazor();
        WriteMainLayout();
        WriteNotFoundPage();
        WriteIndexHtml();
        WriteCss();
        WriteDecompiledCoreTypes();
        WriteINfcWorkbenchService();
        WriteWssNfcWorkbenchService();
        WriteWssMessage();
        WriteHomePage();
        WriteWssInterop();
        WriteDecompiledSources();

        Console.WriteLine(string.Format(System.Globalization.CultureInfo.InvariantCulture,
            "  App assemblies loaded: {0}", AppAssemblies.Count));

        Console.WriteLine(ApkConstants.ProjectGeneratedFormat.Replace("{0}", OutputDir));
    }

    private void WriteCsproj()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("<Project Sdk=\"Microsoft.NET.Sdk.BlazorWebAssembly\">");
        Sb.AppendLine("  <PropertyGroup>");
        Sb.AppendLine("    <TargetFramework>net11.0</TargetFramework>");
        Sb.AppendLine("    <ImplicitUsings>enable</ImplicitUsings>");
        Sb.AppendLine("    <Nullable>enable</Nullable>");
        Sb.Append("    <RootNamespace>").Append(Namespace).AppendLine("</RootNamespace>");
        Sb.Append("    <NoWarn>").Append(ApkConstants.NoWarnList).AppendLine("</NoWarn>");
        Sb.AppendLine("    <EnableTrimAnalyzer>false</EnableTrimAnalyzer>");
        Sb.AppendLine("    <TrimMode>partial</TrimMode>");
        Sb.AppendLine("    <StaticWebAssetsFingerprintContent>true</StaticWebAssetsFingerprintContent>");
        Sb.AppendLine("    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>");
        Sb.AppendLine("  </PropertyGroup>");
        Sb.AppendLine("  <ItemGroup>");
        Sb.AppendLine("    <PackageReference Include=\"Microsoft.AspNetCore.Components.WebAssembly\" Version=\"11.0.0-preview.2.26159.112\" />");
        Sb.AppendLine("    <PackageReference Include=\"Microsoft.AspNetCore.Components.WebAssembly.DevServer\" Version=\"11.0.0-preview.2.26159.112\" PrivateAssets=\"all\" />");
        Sb.AppendLine("  </ItemGroup>");
        Sb.AppendLine("  <ItemGroup>");
        Sb.AppendLine("    <Compile Remove=\"**/*.binary.cs\" />");
        Sb.AppendLine("    <Compile Remove=\"Decompiled/**/*.cs\" />");
        Sb.AppendLine("    <None Include=\"**/*.binary.cs\" />");
        Sb.AppendLine("    <None Include=\"Decompiled/**/*.cs\" />");
        Sb.AppendLine("  </ItemGroup>");
        Sb.AppendLine("</Project>");

        File.WriteAllText(Path.Combine(OutputDir, Namespace + ".csproj"), Sb.ToString());
    }

    private void WriteProgram()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("using Microsoft.AspNetCore.Components.WebAssembly.Hosting;");
        Sb.Append("using ").Append(Namespace).AppendLine(".Services;");
        Sb.AppendLine();
        Sb.AppendLine("var Builder = WebAssemblyHostBuilder.CreateDefault(args);");
        Sb.Append("Builder.RootComponents.Add<").Append(Namespace).AppendLine(".App>(\"#app\");");
        Sb.AppendLine("Builder.Services.AddScoped(Sp => new HttpClient { BaseAddress = new Uri(Builder.HostEnvironment.BaseAddress) });");
        Sb.AppendLine("Builder.Services.AddSingleton<INfcWorkbenchService, WssNfcWorkbenchService>();");
        Sb.AppendLine("await Builder.Build().RunAsync();");

        File.WriteAllText(Path.Combine(OutputDir, "Program.cs"), Sb.ToString());
    }

    private void WriteImports()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("@using Microsoft.AspNetCore.Components.Web");
        Sb.AppendLine("@using Microsoft.AspNetCore.Components.Routing");
        Sb.AppendLine("@using Microsoft.JSInterop");
        Sb.Append("@using ").AppendLine(Namespace);
        Sb.Append("@using ").Append(Namespace).AppendLine(".Pages");
        Sb.Append("@using ").Append(Namespace).AppendLine(".Layout");
        Sb.Append("@using ").Append(Namespace).AppendLine(".Services");
        Sb.Append("@using ").Append(Namespace).AppendLine(".Models");

        File.WriteAllText(Path.Combine(OutputDir, "_Imports.razor"), Sb.ToString());
    }

    private void WriteAppRazor()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("<Router AppAssembly=\"typeof(Program).Assembly\">");
        Sb.AppendLine("    <Found Context=\"routeData\">");
        Sb.AppendLine("        <RouteView RouteData=\"routeData\" DefaultLayout=\"typeof(Layout.MainLayout)\" />");
        Sb.AppendLine("    </Found>");
        Sb.AppendLine("    <NotFound>");
        Sb.AppendLine("        <LayoutView Layout=\"typeof(Layout.MainLayout)\">");
        Sb.AppendLine("            <p>Not found</p>");
        Sb.AppendLine("        </LayoutView>");
        Sb.AppendLine("    </NotFound>");
        Sb.AppendLine("</Router>");

        File.WriteAllText(Path.Combine(OutputDir, "App.razor"), Sb.ToString());
    }

    private void WriteMainLayout()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("@inherits LayoutComponentBase");
        Sb.AppendLine();
        Sb.AppendLine("<div class=\"layout-frame\">");
        Sb.AppendLine("    @Body");
        Sb.AppendLine("</div>");

        File.WriteAllText(Path.Combine(OutputDir, "Layout", "MainLayout.razor"), Sb.ToString());
    }

    private void WriteNotFoundPage()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("@page \"/notfound\"");
        Sb.AppendLine();
        Sb.Append("<h1>").Append(AppTitle).AppendLine("</h1>");
        Sb.AppendLine("<p>Page not found.</p>");

        File.WriteAllText(Path.Combine(OutputDir, "Pages", "NotFound.razor"), Sb.ToString());
    }

    private void WriteIndexHtml()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("<!DOCTYPE html>");
        Sb.AppendLine("<html lang=\"en\">");
        Sb.AppendLine("<head>");
        Sb.AppendLine("    <meta charset=\"utf-8\" />");
        Sb.AppendLine("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no, viewport-fit=cover\" />");
        Sb.Append("    <title>").Append(AppTitle).AppendLine("</title>");
        Sb.AppendLine("    <base href=\"/\" />");
        Sb.AppendLine("    <link rel=\"icon\" href=\"data:,\" />");
        Sb.AppendLine("    <link rel=\"stylesheet\" href=\"css/app.css\" />");
        Sb.Append("    <link rel=\"stylesheet\" href=\"").Append(Namespace).AppendLine(".styles.css\" />");
        Sb.AppendLine("</head>");
        Sb.AppendLine("<body>");
        Sb.Append("    <div id=\"app\">Loading ").Append(AppTitle).AppendLine("...</div>");
        Sb.AppendLine();
        Sb.AppendLine("    <div id=\"blazor-error-ui\">");
        Sb.AppendLine("        An unhandled error has occurred.");
        Sb.AppendLine("        <a href=\"\" class=\"reload\">Reload</a>");
        Sb.AppendLine("    </div>");
        Sb.AppendLine("    <script src=\"_framework/blazor.webassembly.js\" autostart=\"false\"></script>");
        Sb.AppendLine("    <script>");
        Sb.AppendLine("        window.WillowWss = {");
        Sb.AppendLine("            socket: null,");
        Sb.AppendLine("            pendingCallbacks: {},");
        Sb.AppendLine("            callId: 0,");
        Sb.AppendLine("            dotNetRef: null,");
        Sb.AppendLine("            connect: function(url, dotNetRef) {");
        Sb.AppendLine("                this.dotNetRef = dotNetRef;");
        Sb.AppendLine("                try {");
        Sb.AppendLine("                    this.socket = new WebSocket(url);");
        Sb.AppendLine("                    this.socket.onopen = () => dotNetRef.invokeMethodAsync('OnWssOpen');");
        Sb.AppendLine("                    this.socket.onclose = (e) => dotNetRef.invokeMethodAsync('OnWssClose', e.code, e.reason || '');");
        Sb.AppendLine("                    this.socket.onerror = () => dotNetRef.invokeMethodAsync('OnWssError', 'WebSocket error');");
        Sb.AppendLine("                    this.socket.onmessage = (e) => dotNetRef.invokeMethodAsync('OnWssMessage', e.data);");
        Sb.AppendLine("                    return true;");
        Sb.AppendLine("                } catch (err) {");
        Sb.AppendLine("                    return false;");
        Sb.AppendLine("                }");
        Sb.AppendLine("            },");
        Sb.AppendLine("            send: function(json) {");
        Sb.AppendLine("                if (this.socket && this.socket.readyState === 1) {");
        Sb.AppendLine("                    this.socket.send(json);");
        Sb.AppendLine("                    return true;");
        Sb.AppendLine("                }");
        Sb.AppendLine("                return false;");
        Sb.AppendLine("            },");
        Sb.AppendLine("            disconnect: function() {");
        Sb.AppendLine("                if (this.socket) { this.socket.close(); this.socket = null; }");
        Sb.AppendLine("            },");
        Sb.AppendLine("            isConnected: function() {");
        Sb.AppendLine("                return this.socket !== null && this.socket.readyState === 1;");
        Sb.AppendLine("            },");
        Sb.AppendLine("            hasWebNfc: function() {");
        Sb.AppendLine("                return 'NDEFReader' in window;");
        Sb.AppendLine("            },");
        Sb.AppendLine("            startWebNfcScan: async function(dotNetRef) {");
        Sb.AppendLine("                if (!('NDEFReader' in window)) return false;");
        Sb.AppendLine("                try {");
        Sb.AppendLine("                    const reader = new NDEFReader();");
        Sb.AppendLine("                    await reader.scan();");
        Sb.AppendLine("                    reader.onreading = (event) => {");
        Sb.AppendLine("                        const records = [];");
        Sb.AppendLine("                        for (const r of event.message.records) {");
        Sb.AppendLine("                            const decoder = new TextDecoder();");
        Sb.AppendLine("                            records.push({");
        Sb.AppendLine("                                recordType: r.recordType,");
        Sb.AppendLine("                                mediaType: r.mediaType || '',");
        Sb.AppendLine("                                data: r.data ? btoa(String.fromCharCode(...new Uint8Array(r.data.buffer))) : ''");
        Sb.AppendLine("                            });");
        Sb.AppendLine("                        }");
        Sb.AppendLine("                        dotNetRef.invokeMethodAsync('OnWebNfcTag', event.serialNumber || '', JSON.stringify(records));");
        Sb.AppendLine("                    };");
        Sb.AppendLine("                    reader.onreadingerror = () => dotNetRef.invokeMethodAsync('OnWebNfcError', 'Read error');");
        Sb.AppendLine("                    return true;");
        Sb.AppendLine("                } catch(e) { return false; }");
        Sb.AppendLine("            },");
        Sb.AppendLine("            writeWebNfc: async function(text, isUri) {");
        Sb.AppendLine("                if (!('NDEFReader' in window)) return 'Web NFC not available';");
        Sb.AppendLine("                try {");
        Sb.AppendLine("                    const writer = new NDEFReader();");
        Sb.AppendLine("                    const records = isUri");
        Sb.AppendLine("                        ? [{ recordType: 'url', data: text }]");
        Sb.AppendLine("                        : [{ recordType: 'text', data: text }];");
        Sb.AppendLine("                    await writer.write({ records });");
        Sb.AppendLine("                    return '';");
        Sb.AppendLine("                } catch(e) { return e.message || 'Write failed'; }");
        Sb.AppendLine("            },");
        Sb.AppendLine("            generateRandomPort: function() {");
        Sb.AppendLine("                return 49152 + Math.floor(Math.random() * 16383);");
        Sb.AppendLine("            }");
        Sb.AppendLine("        };");
        Sb.AppendLine("        Blazor.start();");
        Sb.AppendLine("    </script>");
        Sb.AppendLine("</body>");
        Sb.AppendLine("</html>");

        File.WriteAllText(Path.Combine(OutputDir, "wwwroot", "index.html"), Sb.ToString());
    }

    private void WriteCss()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine(":root { --ink-0: #0f1722; --ink-1: #172334; --ink-2: #223247; --mint: #8cffd7; --rose: #ff8fb0; --gold: #ffd36e; --text: #edf6ff; --muted: #a6bbcf; --red: #ff6b6b; --green: #51cf66; }");
        Sb.AppendLine("html, body { margin: 0; padding: 0; background: var(--ink-0); color: var(--text); font-family: system-ui, -apple-system, sans-serif; }");
        Sb.AppendLine(".layout-frame { max-width: 72rem; margin: 0 auto; padding: 1.5rem; min-height: 100vh; }");
        Sb.AppendLine("h1, h2, h3 { color: var(--mint); }");
        Sb.AppendLine(".panel-card { background: var(--ink-1); border: 1px solid var(--ink-2); border-radius: 12px; padding: 1.25rem; margin-bottom: 1rem; }");
        Sb.AppendLine(".hero-card { background: linear-gradient(160deg, rgba(140,255,215,0.08), rgba(255,143,176,0.06)); border: 1px solid var(--ink-2); border-radius: 16px; padding: 1.5rem; margin-bottom: 1.5rem; }");
        Sb.AppendLine(".badge-row { display: flex; flex-wrap: wrap; gap: 0.5rem; }");
        Sb.AppendLine(".badge { background: var(--ink-2); color: var(--muted); padding: 0.25rem 0.75rem; border-radius: 999px; font-size: 0.8rem; }");
        Sb.AppendLine(".badge.good { background: rgba(140,255,215,0.15); color: var(--mint); }");
        Sb.AppendLine(".badge.bad { background: rgba(255,107,107,0.15); color: var(--rose); }");
        Sb.AppendLine(".badge.neutral { background: var(--ink-2); color: var(--muted); }");
        Sb.AppendLine(".action { display: inline-flex; align-items: center; gap: 0.4rem; padding: 0.5rem 1.25rem; border: none; border-radius: 8px; cursor: pointer; font-weight: 600; font-size: 0.9rem; background: var(--ink-2); color: var(--text); transition: filter 0.15s; }");
        Sb.AppendLine(".action.primary { background: linear-gradient(135deg, var(--mint), #5ce0b0); color: var(--ink-0); }");
        Sb.AppendLine(".action:hover { filter: brightness(1.15); }");
        Sb.AppendLine(".action:disabled { opacity: 0.4; cursor: not-allowed; filter: none; }");
        Sb.AppendLine(".status-grid { display: grid; grid-template-columns: repeat(auto-fit, minmax(16rem, 1fr)); gap: 0.75rem; }");
        Sb.AppendLine(".detail-grid { display: grid; grid-template-columns: repeat(auto-fit, minmax(18rem, 1fr)); gap: 0.75rem; margin-bottom: 1rem; }");
        Sb.AppendLine(".detail-wide { grid-column: 1 / -1; }");
        Sb.AppendLine(".form-grid { display: grid; grid-template-columns: 1fr 1fr; gap: 0.75rem; }");
        Sb.AppendLine("@media (max-width: 640px) { .form-grid { grid-template-columns: 1fr; } }");
        Sb.AppendLine("input, select, textarea { background: var(--ink-0); color: var(--text); border: 1px solid var(--ink-2); border-radius: 6px; padding: 0.5rem 0.75rem; font-size: 0.9rem; width: 100%; box-sizing: border-box; }");
        Sb.AppendLine("pre, code { font-family: Consolas, 'Courier New', monospace; background: var(--ink-0); padding: 0.75rem; border-radius: 6px; overflow-x: auto; font-size: 0.85rem; color: var(--muted); }");
        Sb.AppendLine("code.mono { font-size: 0.85rem; padding: 0.2rem 0.4rem; }");
        Sb.AppendLine("code.mono.mini { font-size: 0.75rem; word-break: break-all; }");
        Sb.AppendLine(".chip-row { display: flex; flex-wrap: wrap; gap: 0.4rem; margin-top: 0.5rem; }");
        Sb.AppendLine(".chip { background: var(--ink-2); color: var(--muted); padding: 0.2rem 0.6rem; border-radius: 6px; font-size: 0.78rem; }");
        Sb.AppendLine(".hero-actions { display: flex; flex-wrap: wrap; gap: 0.5rem; margin-top: 0.75rem; }");
        Sb.AppendLine(".hero-actions.compact { margin-top: 0.5rem; }");
        Sb.AppendLine(".inline-gap { margin-top: 0.5rem; }");
        Sb.AppendLine(".status-text { color: var(--muted); font-size: 0.9rem; margin: 0.4rem 0; }");
        Sb.AppendLine(".write-note { color: var(--gold); }");
        Sb.AppendLine(".empty-state { color: var(--muted); font-style: italic; }");
        Sb.AppendLine(".detail-list { list-style: none; padding: 0; margin: 0.5rem 0; }");
        Sb.AppendLine(".detail-list li { padding: 0.2rem 0; font-size: 0.85rem; color: var(--muted); }");
        Sb.AppendLine(".snapshot-title { font-weight: 600; color: var(--text); }");
        Sb.AppendLine(".snapshot-time { font-size: 0.8rem; color: var(--muted); }");
        Sb.AppendLine(".headline-grid { display: grid; grid-template-columns: repeat(auto-fit, minmax(12rem, 1fr)); gap: 0.4rem; margin-top: 0.5rem; }");
        Sb.AppendLine(".headline-chip { background: var(--ink-0); border: 1px solid var(--ink-2); border-radius: 6px; padding: 0.3rem 0.6rem; font-size: 0.8rem; color: var(--muted); }");
        Sb.AppendLine(".record-grid { display: grid; grid-template-columns: repeat(auto-fit, minmax(14rem, 1fr)); gap: 0.5rem; }");
        Sb.AppendLine(".record-card { background: var(--ink-0); border: 1px solid var(--ink-2); border-radius: 8px; padding: 0.75rem; }");
        Sb.AppendLine(".record-kind { font-size: 0.8rem; color: var(--mint); margin: 0 0 0.25rem; }");
        Sb.AppendLine(".record-summary { font-size: 0.85rem; color: var(--text); margin: 0 0 0.25rem; }");
        Sb.AppendLine(".eyebrow { color: var(--muted); font-size: 0.8rem; margin: 0 0 0.25rem; letter-spacing: 0.05em; text-transform: uppercase; }");
        Sb.AppendLine(".lede { color: var(--muted); font-size: 0.9rem; line-height: 1.5; }");
        Sb.AppendLine(".scan-shell { animation: fadeIn 0.3s ease-out; }");
        Sb.AppendLine("@keyframes fadeIn { from { opacity: 0; transform: translateY(8px); } to { opacity: 1; transform: none; } }");
        Sb.AppendLine("label { display: flex; flex-direction: column; gap: 0.25rem; font-size: 0.85rem; color: var(--muted); }");
        Sb.AppendLine("label.wide { grid-column: 1 / -1; }");
        Sb.AppendLine("label.toggle { flex-direction: row; align-items: center; gap: 0.5rem; }");
        Sb.AppendLine(".jsonl-viewer { max-height: 24rem; overflow-y: auto; white-space: pre-wrap; word-break: break-all; font-size: 0.78rem; }");
        Sb.AppendLine(".wss-bar { background: var(--ink-1); border: 1px solid var(--ink-2); border-radius: 8px; padding: 0.6rem 1rem; margin-bottom: 1rem; display: flex; align-items: center; gap: 0.75rem; flex-wrap: wrap; }");
        Sb.AppendLine(".wss-dot { width: 10px; height: 10px; border-radius: 50%; }");
        Sb.AppendLine(".wss-dot.on { background: var(--green); box-shadow: 0 0 6px var(--green); }");
        Sb.AppendLine(".wss-dot.off { background: var(--red); }");
        Sb.AppendLine("#blazor-error-ui { background: #5a1a1a; color: #fca; padding: 0.5rem 1rem; position: fixed; bottom: 0; width: 100%; z-index: 9999; display: none; }");
        Sb.AppendLine("#blazor-error-ui .reload { color: var(--mint); }");

        File.WriteAllText(Path.Combine(OutputDir, "wwwroot", "css", "app.css"), Sb.ToString());
    }

    private void WriteModels()
    {
        File.WriteAllText(Path.Combine(OutputDir, "Models", "NfcTagSnapshot.cs"), $@"namespace {Namespace}.Models;

public sealed record NfcTagSnapshot(
    string Summary,
    string IdentifierHex,
    IReadOnlyList<string> Technologies,
    IReadOnlyList<string> HeadlineFacts,
    IReadOnlyList<NdefRecordSnapshot> Records,
    IReadOnlyList<string> Details,
    string WriteOutcome,
    DateTimeOffset CapturedAtUtc);
");

        File.WriteAllText(Path.Combine(OutputDir, "Models", "NdefRecordSnapshot.cs"), $@"namespace {Namespace}.Models;

public sealed record NdefRecordSnapshot(
    string Icon,
    string Kind,
    string Summary,
    string PayloadHex);
");

        File.WriteAllText(Path.Combine(OutputDir, "Models", "NdefWriteDraft.cs"), $@"namespace {Namespace}.Models;

public enum NdefPayloadKind
{{
    Text,
    Uri,
    Mime
}}

public sealed record NdefWriteDraft(
    NdefPayloadKind Kind,
    string Content,
    string MimeType,
    bool MakeReadOnly,
    DateTimeOffset ArmedAtUtc)
{{
    public string Summary =>
        Kind switch
        {{
            NdefPayloadKind.Text => $""text | {{TrimForPreview(Content)}}"",
            NdefPayloadKind.Uri => $""uri | {{TrimForPreview(Content)}}"",
            NdefPayloadKind.Mime => $""{{NormalizedMimeType}} | {{TrimForPreview(Content)}}"",
            _ => TrimForPreview(Content)
        }};

    public string NormalizedMimeType => string.IsNullOrWhiteSpace(MimeType) ? ""text/plain"" : MimeType.Trim();

    private static string TrimForPreview(string Value)
    {{
        if (string.IsNullOrWhiteSpace(Value)) return ""(empty)"";
        var Trimmed = Value.Trim();
        return Trimmed.Length <= 64 ? Trimmed : $""{{Trimmed[..61]}}..."";
    }}
}}
");
    }

    private void WriteNfcJson()
    {
        File.WriteAllText(Path.Combine(OutputDir, "Services", "NfcJson.cs"), $@"using System.Text.Json;
using System.Text.Json.Nodes;

namespace {Namespace}.Services;

public static class NfcJson
{{
    private static readonly JsonSerializerOptions Options = new(JsonSerializerDefaults.Web)
    {{
        WriteIndented = false
    }};

    public static string Line(string Stream, string EventType, object? Payload = null)
    {{
        JsonObject Root;
        if (Payload is null)
        {{
            Root = [];
        }}
        else
        {{
            var Node = JsonSerializer.SerializeToNode(Payload, Options);
            Root = Node as JsonObject ?? new JsonObject {{ [""value""] = Node }};
        }}

        Root[""stream""] = Stream;
        Root[""eventType""] = EventType;
        Root[""timestampUtc""] = DateTimeOffset.UtcNow.ToString(""O"");
        return Root.ToJsonString(Options);
    }}

    public static string Serialize(object Payload) => JsonSerializer.Serialize(Payload, Options);

    public static void Append(List<string> Target, int MaxEntries, string Stream, string EventType, object? Payload = null)
    {{
        Target.Insert(0, Line(Stream, EventType, Payload));
        if (Target.Count > MaxEntries)
        {{
            Target.RemoveRange(MaxEntries, Target.Count - MaxEntries);
        }}
    }}

    public static string Join(IReadOnlyList<string> Lines) => string.Join(Environment.NewLine, Lines);
}}
");
    }

    private void WriteHceAppletRuntime()
    {
        File.WriteAllText(Path.Combine(OutputDir, "Services", "HceAppletRuntime.cs"), $@"using System.Text;

namespace {Namespace}.Services;

public static class HceAppletRuntime
{{
    private const int MaxEntries = 80;
    private const string DefaultResponseText = ""{{\""service\"":\""hce_apdu\"",\""message\"":\""willow_maze_ready\""}}"";
    private static readonly object Sync = new();
    private static readonly List<string> Entries = [];
    private static readonly HashSet<string> DynamicAidHexValues = new(StringComparer.OrdinalIgnoreCase);
    private static string ResponseTextValue = DefaultResponseText;
    private static string? SelectedAidHex;

    public const string AidHex = ""F0770A11B1C2D3"";
    public static event EventHandler? Changed;

    public static string ResponseText
    {{
        get {{ lock (Sync) {{ return ResponseTextValue; }} }}
    }}

    public static IReadOnlyList<string> EventEntries
    {{
        get {{ lock (Sync) {{ return Entries.ToArray(); }} }}
    }}

    public static string Jsonl
    {{
        get {{ lock (Sync) {{ return NfcJson.Join(Entries); }} }}
    }}

    public static IReadOnlyList<string> EffectiveAids
    {{
        get {{ lock (Sync) {{ return [AidHex, .. DynamicAidHexValues.OrderBy(static V => V, StringComparer.OrdinalIgnoreCase)]; }} }}
    }}

    public static void UpdateResponseText(string Value)
    {{
        var Next = string.IsNullOrWhiteSpace(Value) ? DefaultResponseText : Value.Trim();
        lock (Sync)
        {{
            ResponseTextValue = Next;
            AppendEntry(""config"", ""response_updated"", new {{ selectedAidHex = SelectedAidHex, preview = Trim(Next) }});
        }}
        RaiseChanged();
    }}

    public static void SetDynamicAids(IEnumerable<string> Aids)
    {{
        lock (Sync)
        {{
            DynamicAidHexValues.Clear();
            foreach (var Aid in Aids.Select(static V => NormalizeAid(V)).Where(static V => !string.IsNullOrWhiteSpace(V)))
            {{
                DynamicAidHexValues.Add(Aid);
            }}
            AppendEntry(""config"", ""dynamic_aids_updated"", new {{ aids = EffectiveAids }});
        }}
        RaiseChanged();
    }}

    public static byte[]? ProcessCommandApdu(byte[]? CommandApdu, Action<byte[]>? SendResponse = null)
    {{
        if (CommandApdu is null || CommandApdu.Length < 4)
            return StatusWord(0x67, 0x00, ""apdu_error"", new {{ reason = ""malformed_apdu"" }});

        var CommandHex = Convert.ToHexString(CommandApdu);
        Log(""command_apdu"", new {{ commandHex = CommandHex }});

        if (TryMatchSelectAid(CommandApdu, out var MatchedAidHex))
        {{
            lock (Sync) {{ SelectedAidHex = MatchedAidHex; }}
            return EncodePayloadResponse(ResponseText, ""select_ok"", new {{ aidHex = MatchedAidHex }});
        }}

        if (IsGetData(CommandApdu))
        {{
            if (!HasSelectedAid())
                return StatusWord(0x69, 0x85, ""get_data_rejected"", new {{ reason = ""conditions_not_satisfied"" }});
            return EncodePayloadResponse(ResponseText, ""get_data_ok"", new {{ aidHex = SelectedAidHex }});
        }}

        if (IsPutData(CommandApdu))
        {{
            var Payload = ExtractLcPayload(CommandApdu);
            var Text = Payload.Length == 0 ? DefaultResponseText : Encoding.UTF8.GetString(Payload);
            UpdateResponseText(Text);
            return StatusWord(0x90, 0x00, ""put_data_ok"", new {{ payloadPreview = Trim(Text) }});
        }}

        if (IsEcho(CommandApdu))
        {{
            var Payload = ExtractLcPayload(CommandApdu);
            return AppendStatus(Payload, 0x90, 0x00, ""echo_ok"", new {{ responseHex = Convert.ToHexString(Payload) }});
        }}

        if (IsAsyncResponse(CommandApdu))
        {{
            var Payload = ExtractLcPayload(CommandApdu);
            var Text = Payload.Length == 0 ? ResponseText : Encoding.UTF8.GetString(Payload);
            SendResponse?.Invoke(AppendStatus(Encoding.UTF8.GetBytes(Text), 0x90, 0x00, ""async_response_sent"", new {{ payloadPreview = Trim(Text) }}));
            Log(""async_response_queued"", new {{ payloadPreview = Trim(Text) }});
            return null;
        }}

        return StatusWord(0x6D, 0x00, ""unsupported_apdu"", new {{ commandHex = CommandHex }});
    }}

    public static void LogDeactivated(string Reason) => Log(""deactivated"", new {{ reason = Reason }});

    private static bool HasSelectedAid() {{ lock (Sync) {{ return !string.IsNullOrWhiteSpace(SelectedAidHex); }} }}

    private static byte[] EncodePayloadResponse(string Text, string EventType, object Payload)
    {{
        var Bytes = Encoding.UTF8.GetBytes(Text);
        return AppendStatus(Bytes, 0x90, 0x00, EventType, Payload);
    }}

    private static bool IsGetData(byte[] Apdu) => Apdu.Length >= 4 && Apdu[0] == 0x80 && Apdu[1] == 0xCA && Apdu[2] == 0x00 && Apdu[3] == 0x00;
    private static bool IsPutData(byte[] Apdu) => Apdu.Length >= 5 && Apdu[0] == 0x80 && Apdu[1] == 0xDA && Apdu[2] == 0x00 && Apdu[3] == 0x00;
    private static bool IsEcho(byte[] Apdu) => Apdu.Length >= 5 && Apdu[0] == 0x80 && Apdu[1] == 0xEE && Apdu[2] == 0x00 && Apdu[3] == 0x00;
    private static bool IsAsyncResponse(byte[] Apdu) => Apdu.Length >= 5 && Apdu[0] == 0x80 && Apdu[1] == 0xE2 && Apdu[2] == 0x00 && Apdu[3] == 0x00;

    private static byte[] ExtractLcPayload(byte[] Apdu)
    {{
        if (Apdu.Length < 5) return [];
        var Length = Apdu[4];
        if (Apdu.Length < 5 + Length) return [];
        return Apdu.Skip(5).Take(Length).ToArray();
    }}

    private static bool TryMatchSelectAid(byte[] Apdu, out string MatchedAidHex)
    {{
        MatchedAidHex = string.Empty;
        if (Apdu.Length < 5 || Apdu[0] != 0x00 || Apdu[1] != 0xA4 || Apdu[2] != 0x04 || Apdu[3] != 0x00) return false;
        var AidLength = Apdu[4];
        if (Apdu.Length != 5 + AidLength) return false;
        MatchedAidHex = Convert.ToHexString(Apdu, 5, AidLength);
        lock (Sync) {{ return string.Equals(MatchedAidHex, AidHex, StringComparison.OrdinalIgnoreCase) || DynamicAidHexValues.Contains(MatchedAidHex); }}
    }}

    private static string NormalizeAid(string Value) => new string(Value.Where(Uri.IsHexDigit).ToArray()).ToUpperInvariant();

    private static byte[] AppendStatus(byte[] Payload, byte Sw1, byte Sw2, string EventType, object PayloadObject)
    {{
        var Combined = new byte[Payload.Length + 2];
        Payload.CopyTo(Combined, 0);
        Combined[^2] = Sw1;
        Combined[^1] = Sw2;
        Log(EventType, new {{ statusWord = $""{{Sw1:X2}}{{Sw2:X2}}"", responseHex = Convert.ToHexString(Combined), payload = PayloadObject }});
        return Combined;
    }}

    private static byte[] StatusWord(byte Sw1, byte Sw2, string EventType, object Payload)
    {{
        var Response = new[] {{ Sw1, Sw2 }};
        Log(EventType, new {{ statusWord = $""{{Sw1:X2}}{{Sw2:X2}}"", responseHex = Convert.ToHexString(Response), payload = Payload }});
        return Response;
    }}

    private static void Log(string EventType, object Payload) {{ lock (Sync) {{ AppendEntry(""event"", EventType, Payload); }} RaiseChanged(); }}
    private static void AppendEntry(string Stream, string EventType, object Payload) => NfcJson.Append(Entries, MaxEntries, $""hce.{{Stream}}"", EventType, Payload);
    private static string Trim(string Value) => Value.Length <= 120 ? Value : $""{{Value[..117]}}..."";
    private static void RaiseChanged() => Changed?.Invoke(null, EventArgs.Empty);
}}
");
    }

    private void WriteHceFAppletRuntime()
    {
        File.WriteAllText(Path.Combine(OutputDir, "Services", "HceFAppletRuntime.cs"), $@"using System.Text;

namespace {Namespace}.Services;

public static class HceFAppletRuntime
{{
    private const int MaxEntries = 80;
    private const string DefaultResponseText = ""{{\""service\"":\""hce_nfcf\"",\""message\"":\""willow_maze_ready\""}}"";
    private static readonly object Sync = new();
    private static readonly List<string> Entries = [];
    private static string ResponseTextValue = DefaultResponseText;

    public const string SystemCodeHex = ""4000"";
    public const string Nfcid2Hex = ""02FE000000000000"";
    public const string T3tPmmHex = ""FFFFFFFFFFFFFFFF"";

    public static event EventHandler? Changed;

    public static string ResponseText {{ get {{ lock (Sync) {{ return ResponseTextValue; }} }} }}
    public static IReadOnlyList<string> EventEntries {{ get {{ lock (Sync) {{ return Entries.ToArray(); }} }} }}
    public static string Jsonl {{ get {{ lock (Sync) {{ return NfcJson.Join(Entries); }} }} }}

    public static void UpdateResponseText(string Value)
    {{
        var Next = string.IsNullOrWhiteSpace(Value) ? DefaultResponseText : Value.Trim();
        lock (Sync)
        {{
            ResponseTextValue = Next;
            AppendEntry(""config"", ""response_updated"", new {{ preview = Trim(Next) }});
        }}
        RaiseChanged();
    }}

    public static void LogStatus(string Value) {{ lock (Sync) {{ AppendEntry(""status"", ""state"", new {{ message = Value }}); }} RaiseChanged(); }}

    public static byte[]? ProcessPacket(byte[]? CommandPacket, Action<byte[]>? SendResponse = null)
    {{
        if (CommandPacket is null || CommandPacket.Length < 2)
            return BuildFrame(0xFF, ""packet_error"", new {{ reason = ""malformed_packet"" }});

        var CommandHex = Convert.ToHexString(CommandPacket);
        Log(""command_packet"", new {{ commandHex = CommandHex }});

        var CommandCode = CommandPacket[1];
        if (CommandCode == 0xE2)
        {{
            var Payload = ExtractPayload(CommandPacket);
            var Text = Payload.Length == 0 ? ResponseText : Encoding.UTF8.GetString(Payload);
            SendResponse?.Invoke(BuildFrame(0xE3, ""async_response_sent"", new {{ payloadPreview = Trim(Text) }}, Text));
            Log(""async_response_queued"", new {{ payloadPreview = Trim(Text) }});
            return null;
        }}

        if (CommandCode == 0xDA)
        {{
            var Payload = ExtractPayload(CommandPacket);
            var Text = Payload.Length == 0 ? DefaultResponseText : Encoding.UTF8.GetString(Payload);
            UpdateResponseText(Text);
            return BuildFrame(0xDB, ""write_response_ok"", new {{ payloadPreview = Trim(Text) }}, string.Empty);
        }}

        if (CommandCode == 0xCA)
            return BuildFrame(0xCB, ""read_response_ok"", new {{ payloadPreview = Trim(ResponseText) }}, ResponseText);

        if (CommandCode == 0xEE)
        {{
            var Payload = ExtractPayload(CommandPacket);
            var Text = Payload.Length == 0 ? string.Empty : Encoding.UTF8.GetString(Payload);
            return BuildFrame(0xEF, ""echo_ok"", new {{ payloadPreview = Trim(Text) }}, Text);
        }}

        var ResponseCode = unchecked((byte)(CommandCode + 1));
        return BuildFrame(ResponseCode, ""packet_reply"", new {{ commandCode = $""0x{{CommandCode:X2}}"", payloadPreview = Trim(ResponseText) }}, ResponseText);
    }}

    public static void LogDeactivated(string Reason) => Log(""deactivated"", new {{ reason = Reason }});

    private static byte[] ExtractPayload(byte[] Packet) => Packet.Length <= 10 ? [] : Packet.Skip(10).ToArray();

    private static byte[] BuildFrame(byte ResponseCode, string EventType, object Payload, string? ResponseOverride = null)
    {{
        var Nfcid2Bytes = Convert.FromHexString(Nfcid2Hex);
        var ResponseBytes = Encoding.UTF8.GetBytes(ResponseOverride ?? ResponseText);
        var PayloadLength = Math.Min(ResponseBytes.Length, 244 - Nfcid2Bytes.Length);
        var Frame = new byte[2 + Nfcid2Bytes.Length + PayloadLength];
        Frame[1] = ResponseCode;
        Buffer.BlockCopy(Nfcid2Bytes, 0, Frame, 2, Nfcid2Bytes.Length);
        Buffer.BlockCopy(ResponseBytes, 0, Frame, 2 + Nfcid2Bytes.Length, PayloadLength);
        Frame[0] = (byte)Frame.Length;
        Log(EventType, new {{ responseCode = $""0x{{ResponseCode:X2}}"", responseHex = Convert.ToHexString(Frame), payload = Payload }});
        return Frame;
    }}

    private static void Log(string EventType, object Payload) {{ lock (Sync) {{ AppendEntry(""event"", EventType, Payload); }} RaiseChanged(); }}
    private static void AppendEntry(string Stream, string EventType, object Payload) => NfcJson.Append(Entries, MaxEntries, $""hcef.{{Stream}}"", EventType, Payload);
    private static string Trim(string Value) => Value.Length <= 120 ? Value : $""{{Value[..117]}}..."";
    private static void RaiseChanged() => Changed?.Invoke(null, EventArgs.Empty);
}}
");
    }

    private void WriteINfcWorkbenchService()
    {
        File.WriteAllText(Path.Combine(OutputDir, "Services", "INfcWorkbenchService.cs"), $@"using {Namespace}.Models;

namespace {Namespace}.Services;

public interface INfcWorkbenchService
{{
    bool IsSupported {{ get; }}
    bool IsEnabled {{ get; }}
    bool IsListening {{ get; }}
    bool IsForegroundDispatchEnabled {{ get; }}
    bool SupportsHce {{ get; }}
    bool SupportsNfcFCardEmulation {{ get; }}
    bool IsHceFEnabled {{ get; }}
    bool SupportsObserveMode {{ get; }}
    bool IsObserveModeEnabled {{ get; }}
    bool ShouldDefaultToObserveMode {{ get; }}
    bool SupportsTagIntentPreference {{ get; }}
    bool? IsTagIntentAllowed {{ get; }}
    bool SupportsReaderOption {{ get; }}
    bool IsReaderOptionEnabled {{ get; }}
    bool SupportsSecureNfc {{ get; }}
    bool IsSecureNfcEnabled {{ get; }}
    bool SupportsAidPrefixRegistration {{ get; }}
    bool AllowsOtherCategoryForegroundPreference {{ get; }}
    bool IsPreferredService {{ get; }}
    bool HasCustomDiscoveryTechnology {{ get; }}
    bool IsWssConnected {{ get; }}
    bool HasWebNfc {{ get; }}
    int DefaultNfcSubscriptionId {{ get; }}
    string StatusText {{ get; }}
    string LastWriteStatus {{ get; }}
    string LastRawStatus {{ get; }}
    string DiscoveryStatusText {{ get; }}
    string PreferredPaymentDescription {{ get; }}
    string PreferredPaymentRoute {{ get; }}
    string LastIntentAction {{ get; }}
    string HceAidHex {{ get; }}
    string HceStatusText {{ get; }}
    string HceResponseText {{ get; }}
    string HceFSystemCodeHex {{ get; }}
    string HceFNfcid2Hex {{ get; }}
    string HceFT3tPmmHex {{ get; }}
    string HceFStatusText {{ get; }}
    string HceFResponseText {{ get; }}
    string ObserveModeStatusText {{ get; }}
    string AdapterSnapshotJson {{ get; }}
    string LatestTagJsonl {{ get; }}
    string SessionJsonl {{ get; }}
    string HceJsonl {{ get; }}
    string HceFJsonl {{ get; }}
    string RawJsonl {{ get; }}
    string WssUrl {{ get; }}
    NdefWriteDraft? PendingWrite {{ get; }}
    NfcTagSnapshot? LatestTag {{ get; }}
    IReadOnlyList<string> CapabilityNotes {{ get; }}
    IReadOnlyList<string> AntennaFacts {{ get; }}
    IReadOnlyList<string> RawEvents {{ get; }}
    IReadOnlyList<string> HceEvents {{ get; }}
    IReadOnlyList<string> HceFEvents {{ get; }}
    IReadOnlyList<string> RegisteredHceAids {{ get; }}
    IReadOnlyList<string> PollingFilters {{ get; }}
    IReadOnlyList<string> PollingPatternFilters {{ get; }}
    event EventHandler? Changed;
    Task InitializeAsync();
    Task ArmWriteAsync(NdefWriteDraft Draft);
    Task ClearWriteAsync();
    Task OpenNfcSettingsAsync();
    Task OpenTagRoutingAsync();
    Task RefreshAsync();
    Task SendRawAsync(string TechnologyName, string CommandHex);
    Task IgnoreCurrentTagAsync(int DebounceMs);
    Task SetObserveModeEnabledAsync(bool Enabled);
    Task SetDefaultObserveModeAsync(bool Enabled);
    Task SetPreferredServiceAsync(bool Prefer);
    Task SetHceFEnabledAsync(bool Enabled);
    Task SetDiscoveryTechnologyAsync(int PollFlags, int ListenFlags);
    Task ResetDiscoveryTechnologyAsync();
    Task RegisterHceAidsAsync(string RawAidText);
    Task ClearHceAidsAsync();
    Task AddPollingFilterAsync(string FilterHex, bool AutoTransact);
    Task RemovePollingFilterAsync(string FilterHex);
    Task AddPollingPatternFilterAsync(string Pattern, bool AutoTransact);
    Task RemovePollingPatternFilterAsync(string Pattern);
    Task StartReaderAsync();
    Task StopReaderAsync();
    Task UpdateHceResponseAsync(string ResponseText);
    Task UpdateHceFResponseAsync(string ResponseText);
    Task ConnectWssAsync(string Url);
    Task DisconnectWssAsync();
}}
");
    }

    private void WriteWssMessage()
    {
        File.WriteAllText(Path.Combine(OutputDir, "Models", "WssMessage.cs"), $@"using System.Text.Json.Serialization;

namespace {Namespace}.Models;

public sealed class WssMessage
{{
    [JsonPropertyName(""type"")]
    public string Type {{ get; set; }} = string.Empty;

    [JsonPropertyName(""method"")]
    public string Method {{ get; set; }} = string.Empty;

    [JsonPropertyName(""id"")]
    public string Id {{ get; set; }} = string.Empty;

    [JsonPropertyName(""payload"")]
    public System.Text.Json.JsonElement? Payload {{ get; set; }}

    [JsonPropertyName(""error"")]
    public string? Error {{ get; set; }}

    [JsonPropertyName(""data"")]
    public System.Text.Json.JsonElement? Data {{ get; set; }}
}}
");
    }

    private void WriteWssInterop()
    {
        File.WriteAllText(Path.Combine(OutputDir, "Services", "WssInterop.cs"), $@"using Microsoft.JSInterop;

namespace {Namespace}.Services;

public sealed class WssInterop : IAsyncDisposable
{{
    private readonly IJSRuntime Js;
    private DotNetObjectReference<WssNfcWorkbenchService>? DotNetRef;

    public WssInterop(IJSRuntime Js) => this.Js = Js;

    public async Task<bool> ConnectAsync(string Url, WssNfcWorkbenchService Service)
    {{
        DotNetRef = DotNetObjectReference.Create(Service);
        return await Js.InvokeAsync<bool>(""WillowWss.connect"", Url, DotNetRef);
    }}

    public async Task<bool> SendAsync(string Json) => await Js.InvokeAsync<bool>(""WillowWss.send"", Json);
    public async Task DisconnectAsync() => await Js.InvokeVoidAsync(""WillowWss.disconnect"");
    public async Task<bool> IsConnectedAsync() => await Js.InvokeAsync<bool>(""WillowWss.isConnected"");
    public async Task<bool> HasWebNfcAsync() => await Js.InvokeAsync<bool>(""WillowWss.hasWebNfc"");
    public async Task<int> GenerateRandomPortAsync() => await Js.InvokeAsync<int>(""WillowWss.generateRandomPort"");

    public async Task<bool> StartWebNfcScanAsync(WssNfcWorkbenchService Service)
    {{
        DotNetRef ??= DotNetObjectReference.Create(Service);
        return await Js.InvokeAsync<bool>(""WillowWss.startWebNfcScan"", DotNetRef);
    }}

    public async Task<string> WriteWebNfcAsync(string Text, bool IsUri) => await Js.InvokeAsync<string>(""WillowWss.writeWebNfc"", Text, IsUri);

    public async ValueTask DisposeAsync()
    {{
        DotNetRef?.Dispose();
        try {{ await Js.InvokeVoidAsync(""WillowWss.disconnect""); }} catch {{ }}
    }}
}}
");
    }

    private void WriteWssNfcWorkbenchService()
    {
        File.WriteAllText(Path.Combine(OutputDir, "Services", "WssNfcWorkbenchService.cs"), $@"using System.Text.Json;
using Microsoft.JSInterop;
using {Namespace}.Models;

namespace {Namespace}.Services;

public sealed class WssNfcWorkbenchService : INfcWorkbenchService, IAsyncDisposable
{{
    private readonly IJSRuntime Js;
    private WssInterop? Interop;
    private readonly List<string> CapabilityNotesInternal = [];
    private readonly List<string> AntennaFactsInternal = [];
    private readonly List<string> RawEventsInternal = [];
    private readonly List<string> SessionJsonlEntries = [];
    private readonly List<string> RawJsonlEntries = [];
    private readonly List<string> PollingFilterEntries = [];
    private readonly List<string> PollingPatternFilterEntries = [];

    public WssNfcWorkbenchService(IJSRuntime Js) => this.Js = Js;

    public bool IsSupported {{ get; private set; }}
    public bool IsEnabled {{ get; private set; }}
    public bool IsListening {{ get; private set; }}
    public bool IsForegroundDispatchEnabled {{ get; private set; }}
    public bool SupportsHce {{ get; private set; }}
    public bool SupportsNfcFCardEmulation {{ get; private set; }}
    public bool IsHceFEnabled {{ get; private set; }}
    public bool SupportsObserveMode {{ get; private set; }}
    public bool IsObserveModeEnabled {{ get; private set; }}
    public bool ShouldDefaultToObserveMode {{ get; private set; }}
    public bool SupportsTagIntentPreference {{ get; private set; }}
    public bool? IsTagIntentAllowed {{ get; private set; }}
    public bool SupportsReaderOption {{ get; private set; }}
    public bool IsReaderOptionEnabled {{ get; private set; }}
    public bool SupportsSecureNfc {{ get; private set; }}
    public bool IsSecureNfcEnabled {{ get; private set; }}
    public bool SupportsAidPrefixRegistration {{ get; private set; }}
    public bool AllowsOtherCategoryForegroundPreference {{ get; private set; }}
    public bool IsPreferredService {{ get; private set; }}
    public bool HasCustomDiscoveryTechnology {{ get; private set; }}
    public bool IsWssConnected {{ get; private set; }}
    public bool HasWebNfc {{ get; private set; }}
    public int DefaultNfcSubscriptionId {{ get; private set; }} = -1;
    public string StatusText {{ get; private set; }} = ""Connect to a Willow server or use Web NFC to begin."";
    public string LastWriteStatus {{ get; private set; }} = ""No write armed yet."";
    public string LastRawStatus {{ get; private set; }} = ""Tap a tag, keep it in field, then send a raw hex frame."";
    public string DiscoveryStatusText {{ get; private set; }} = ""Default discovery settings."";
    public string PreferredPaymentDescription {{ get; private set; }} = ""(none)"";
    public string PreferredPaymentRoute {{ get; private set; }} = ""(none)"";
    public string LastIntentAction {{ get; private set; }} = ""(none)"";
    public string HceAidHex => FormatHex(HceAppletRuntime.AidHex);
    public string HceStatusText {{ get; private set; }} = ""Demo applet is idle."";
    public string HceResponseText {{ get; private set; }} = HceAppletRuntime.ResponseText;
    public string HceFSystemCodeHex => FormatHex(HceFAppletRuntime.SystemCodeHex);
    public string HceFNfcid2Hex => FormatHex(HceFAppletRuntime.Nfcid2Hex);
    public string HceFT3tPmmHex => FormatHex(HceFAppletRuntime.T3tPmmHex);
    public string HceFStatusText {{ get; private set; }} = ""Demo NFC-F applet is idle."";
    public string HceFResponseText {{ get; private set; }} = HceFAppletRuntime.ResponseText;
    public string ObserveModeStatusText {{ get; private set; }} = ""Observe mode is idle."";
    public NdefWriteDraft? PendingWrite {{ get; private set; }}
    public NfcTagSnapshot? LatestTag {{ get; private set; }}
    public IReadOnlyList<string> CapabilityNotes => CapabilityNotesInternal;
    public IReadOnlyList<string> AntennaFacts => AntennaFactsInternal;
    public IReadOnlyList<string> RawEvents => RawEventsInternal;
    public IReadOnlyList<string> HceEvents {{ get; private set; }} = [];
    public IReadOnlyList<string> HceFEvents {{ get; private set; }} = [];
    public IReadOnlyList<string> RegisteredHceAids => HceAppletRuntime.EffectiveAids;
    public IReadOnlyList<string> PollingFilters => PollingFilterEntries;
    public IReadOnlyList<string> PollingPatternFilters => PollingPatternFilterEntries;
    public string WssUrl {{ get; private set; }} = string.Empty;

    public string AdapterSnapshotJson => NfcJson.Serialize(new
    {{
        IsSupported, IsEnabled, IsListening, SupportsHce, SupportsNfcFCardEmulation,
        IsHceFEnabled, SupportsObserveMode, IsObserveModeEnabled, SupportsSecureNfc,
        IsSecureNfcEnabled, IsPreferredService, HasCustomDiscoveryTechnology, IsWssConnected, HasWebNfc,
        HceAidHex, HceFSystemCodeHex, HceFNfcid2Hex, HceFT3tPmmHex, CapabilityNotes, AntennaFacts
    }});

    public string LatestTagJsonl => LatestTag is not null
        ? NfcJson.Line(""tag"", ""snapshot"", new
        {{
            LatestTag.Summary, LatestTag.IdentifierHex, LatestTag.Technologies,
            Records = LatestTag.Records.Select(static R => new {{ R.Icon, R.Kind, R.Summary, R.PayloadHex }}),
            LatestTag.Details, LatestTag.WriteOutcome, LatestTag.CapturedAtUtc
        }})
        : string.Empty;

    public string SessionJsonl => NfcJson.Join(SessionJsonlEntries);
    public string HceJsonl => HceAppletRuntime.Jsonl;
    public string HceFJsonl => HceFAppletRuntime.Jsonl;
    public string RawJsonl => NfcJson.Join(RawJsonlEntries);

    public event EventHandler? Changed;

    public async Task InitializeAsync()
    {{
        Interop = new WssInterop(Js);
        HasWebNfc = await Interop.HasWebNfcAsync();
        HceAppletRuntime.Changed += HandleHceChanged;
        HceFAppletRuntime.Changed += HandleHceChanged;
        SyncHceState();

        if (HasWebNfc)
        {{
            IsSupported = true;
            IsEnabled = true;
            StatusText = ""Web NFC is available. Start reader to scan tags."";
            CapabilityNotesInternal.Add(""Web NFC API detected in this browser."");
        }}
        else
        {{
            StatusText = ""No Web NFC. Connect to a Willow server (WSS) for full NFC access."";
            CapabilityNotesInternal.Add(""Web NFC not available. Use WSS proxy to an Android device."");
        }}

        CapabilityNotesInternal.Add(""HCE APDU applet runs in-process (browser WASM)."");
        CapabilityNotesInternal.Add(""HCE NFC-F applet runs in-process (browser WASM)."");
        RaiseChanged();
    }}

    public async Task ConnectWssAsync(string Url)
    {{
        Interop ??= new WssInterop(Js);
        WssUrl = Url;
        var Connected = await Interop.ConnectAsync(Url, this);
        if (!Connected)
        {{
            StatusText = $""Failed to connect to {{Url}}"";
            RaiseChanged();
        }}
    }}

    public async Task DisconnectWssAsync()
    {{
        if (Interop is not null) await Interop.DisconnectAsync();
        IsWssConnected = false;
        StatusText = ""WSS disconnected."";
        LogSession(""wss"", ""disconnected"", null);
        RaiseChanged();
    }}

    [JSInvokable] public Task OnWssOpen()
    {{
        IsWssConnected = true;
        IsSupported = true;
        IsEnabled = true;
        StatusText = $""Connected to Willow server at {{WssUrl}}"";
        CapabilityNotesInternal.Insert(0, $""WSS connected to {{WssUrl}}"");
        LogSession(""wss"", ""connected"", new {{ url = WssUrl }});
        RaiseChanged();
        return Task.CompletedTask;
    }}

    [JSInvokable] public Task OnWssClose(int Code, string Reason)
    {{
        IsWssConnected = false;
        StatusText = $""WSS closed ({{Code}}: {{Reason}})"";
        LogSession(""wss"", ""closed"", new {{ code = Code, reason = Reason }});
        RaiseChanged();
        return Task.CompletedTask;
    }}

    [JSInvokable] public Task OnWssError(string Error)
    {{
        StatusText = $""WSS error: {{Error}}"";
        LogSession(""wss"", ""error"", new {{ error = Error }});
        RaiseChanged();
        return Task.CompletedTask;
    }}

    [JSInvokable] public Task OnWssMessage(string Json)
    {{
        try
        {{
            var Msg = JsonSerializer.Deserialize<WssMessage>(Json);
            if (Msg is null) return Task.CompletedTask;

            if (Msg.Type == ""tag_discovered"" && Msg.Data.HasValue)
            {{
                var Tag = JsonSerializer.Deserialize<NfcTagSnapshot>(Msg.Data.Value.GetRawText());
                if (Tag is not null)
                {{
                    LatestTag = Tag;
                    StatusText = $""{{Tag.Summary}} via WSS"";
                    AppendEvent(RawEventsInternal, $""Tag captured via WSS: {{Tag.Summary}}"");
                    LogSession(""tag"", ""discovered_wss"", new {{ Tag.Summary, Tag.IdentifierHex }});
                }}
            }}
            else if (Msg.Type == ""state_update"" && Msg.Data.HasValue)
            {{
                ApplyStateUpdate(Msg.Data.Value);
            }}
            else if (Msg.Type == ""raw_response"" && Msg.Data.HasValue)
            {{
                var ResponseHex = Msg.Data.Value.GetProperty(""responseHex"").GetString() ?? """";
                var Tech = Msg.Data.Value.GetProperty(""technology"").GetString() ?? """";
                LastRawStatus = $""{{Tech}} via WSS: {{FormatHex(ResponseHex)}}"";
                AppendEvent(RawEventsInternal, LastRawStatus);
            }}
            else if (Msg.Type == ""error"")
            {{
                StatusText = $""WSS error: {{Msg.Error}}"";
            }}

            RaiseChanged();
        }}
        catch {{ }}
        return Task.CompletedTask;
    }}

    [JSInvokable] public Task OnWebNfcTag(string SerialNumber, string RecordsJson)
    {{
        var Records = new List<NdefRecordSnapshot>();
        try
        {{
            using var Doc = JsonDocument.Parse(RecordsJson);
            foreach (var Elem in Doc.RootElement.EnumerateArray())
            {{
                var RecordType = Elem.GetProperty(""recordType"").GetString() ?? ""unknown"";
                var Data = Elem.GetProperty(""data"").GetString() ?? """";
                Records.Add(new NdefRecordSnapshot(
                    RecordType == ""url"" ? ""link"" : ""text"",
                    RecordType,
                    Data.Length > 0 ? System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(Data)) : ""(empty)"",
                    Data, string.Empty, string.Empty, string.Empty, string.Empty, 0, []));
            }}
        }}
        catch {{ }}

        LatestTag = new NfcTagSnapshot(
            ""NFC tag discovered (Web NFC)"",
            SerialNumber,
            string.Empty,
            string.Empty,
            [""WebNFC""],
            [$""ID: {{SerialNumber}}"", $""Records: {{Records.Count}}""],
            Records,
            [""Scanned via Web NFC API""],
            [],
            [],
            PendingWrite is null ? ""Inspect only."" : ""Web NFC write pending."",
            DateTimeOffset.UtcNow);

        StatusText = $""Tag scanned: {{SerialNumber}}"";
        LogSession(""tag"", ""discovered_webnfc"", new {{ serialNumber = SerialNumber, recordCount = Records.Count }});
        RaiseChanged();
        return Task.CompletedTask;
    }}

    [JSInvokable] public Task OnWebNfcError(string Error)
    {{
        StatusText = $""Web NFC error: {{Error}}"";
        RaiseChanged();
        return Task.CompletedTask;
    }}

    public async Task StartReaderAsync()
    {{
        if (HasWebNfc && Interop is not null)
        {{
            var Started = await Interop.StartWebNfcScanAsync(this);
            IsListening = Started;
            StatusText = Started ? ""Reader mode is live (Web NFC). Tap a tag."" : ""Failed to start Web NFC reader."";
        }}
        else if (IsWssConnected)
        {{
            await SendWssAsync(""start_reader"");
            IsListening = true;
            StatusText = ""Reader mode started via WSS."";
        }}
        else
        {{
            StatusText = ""No NFC source available. Connect WSS or use a Web NFC-capable browser."";
        }}
        RaiseChanged();
    }}

    public async Task StopReaderAsync()
    {{
        if (IsWssConnected) await SendWssAsync(""stop_reader"");
        IsListening = false;
        StatusText = ""Reader mode paused."";
        RaiseChanged();
    }}

    public Task RefreshAsync()
    {{
        SyncHceState();
        if (IsWssConnected) return SendWssAsync(""refresh"");
        RaiseChanged();
        return Task.CompletedTask;
    }}

    public async Task ArmWriteAsync(NdefWriteDraft Draft)
    {{
        PendingWrite = Draft with {{ Content = Draft.Content.Trim() }};
        LastWriteStatus = $""Armed next write: {{PendingWrite.Summary}}"";

        if (HasWebNfc && Interop is not null && PendingWrite is not null)
        {{
            var Error = await Interop.WriteWebNfcAsync(PendingWrite.Content, PendingWrite.Kind == NdefPayloadKind.Uri);
            if (string.IsNullOrEmpty(Error))
            {{
                LastWriteStatus = $""Wrote via Web NFC: {{PendingWrite.Summary}}"";
                PendingWrite = null;
            }}
            else
            {{
                LastWriteStatus = $""Web NFC write failed: {{Error}}"";
            }}
        }}
        else if (IsWssConnected)
        {{
            await SendWssAsync(""arm_write"", new {{ kind = Draft.Kind.ToString(), content = Draft.Content, mimeType = Draft.MimeType, makeReadOnly = Draft.MakeReadOnly }});
        }}

        RaiseChanged();
    }}

    public async Task ClearWriteAsync()
    {{
        PendingWrite = null;
        LastWriteStatus = ""Pending write cleared."";
        if (IsWssConnected) await SendWssAsync(""clear_write"");
        RaiseChanged();
    }}

    public async Task SendRawAsync(string TechnologyName, string CommandHex)
    {{
        if (IsWssConnected)
        {{
            await SendWssAsync(""send_raw"", new {{ technology = TechnologyName, commandHex = CommandHex }});
            LastRawStatus = $""Sent {{TechnologyName}} command via WSS..."";
        }}
        else
        {{
            LastRawStatus = ""Raw I/O requires WSS connection to Android device."";
        }}
        AppendEvent(RawEventsInternal, LastRawStatus);
        RaiseChanged();
    }}

    public Task OpenNfcSettingsAsync() => IsWssConnected ? SendWssAsync(""open_nfc_settings"") : Task.CompletedTask;
    public Task OpenTagRoutingAsync() => IsWssConnected ? SendWssAsync(""open_tag_routing"") : Task.CompletedTask;
    public Task IgnoreCurrentTagAsync(int DebounceMs) => IsWssConnected ? SendWssAsync(""ignore_tag"", new {{ debounceMs = DebounceMs }}) : Task.CompletedTask;
    public Task SetObserveModeEnabledAsync(bool Enabled) => IsWssConnected ? SendWssAsync(""set_observe_mode"", new {{ enabled = Enabled }}) : Task.CompletedTask;
    public Task SetDefaultObserveModeAsync(bool Enabled) => IsWssConnected ? SendWssAsync(""set_default_observe"", new {{ enabled = Enabled }}) : Task.CompletedTask;
    public Task SetPreferredServiceAsync(bool Prefer) => IsWssConnected ? SendWssAsync(""set_preferred_service"", new {{ prefer = Prefer }}) : Task.CompletedTask;
    public Task SetHceFEnabledAsync(bool Enabled) => IsWssConnected ? SendWssAsync(""set_hcef_enabled"", new {{ enabled = Enabled }}) : Task.CompletedTask;
    public Task SetDiscoveryTechnologyAsync(int PollFlags, int ListenFlags) => IsWssConnected ? SendWssAsync(""set_discovery"", new {{ pollFlags = PollFlags, listenFlags = ListenFlags }}) : Task.CompletedTask;
    public Task ResetDiscoveryTechnologyAsync() => IsWssConnected ? SendWssAsync(""reset_discovery"") : Task.CompletedTask;

    public Task RegisterHceAidsAsync(string RawAidText)
    {{
        var Aids = RawAidText.Split([',', ';', ' ', '\n', '\r'], StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
            .Select(static V => new string(V.Where(Uri.IsHexDigit).ToArray()).ToUpperInvariant())
            .Where(static V => V.Length >= 10).ToArray();
        if (Aids.Length == 0) {{ HceStatusText = ""No valid AID hex values found.""; RaiseChanged(); return Task.CompletedTask; }}
        HceAppletRuntime.SetDynamicAids(Aids);
        HceStatusText = $""Registered {{Aids.Length}} dynamic AID(s)."";
        SyncHceState();
        RaiseChanged();
        return Task.CompletedTask;
    }}

    public Task ClearHceAidsAsync()
    {{
        HceAppletRuntime.SetDynamicAids([]);
        HceStatusText = ""Dynamic AIDs cleared."";
        SyncHceState();
        RaiseChanged();
        return Task.CompletedTask;
    }}

    public Task AddPollingFilterAsync(string FilterHex, bool AutoTransact)
    {{
        var Cleaned = new string(FilterHex.Where(Uri.IsHexDigit).ToArray()).ToUpperInvariant();
        if (!string.IsNullOrWhiteSpace(Cleaned) && !PollingFilterEntries.Contains(Cleaned)) PollingFilterEntries.Add(Cleaned);
        if (IsWssConnected) return SendWssAsync(""add_polling_filter"", new {{ filterHex = Cleaned, autoTransact = AutoTransact }});
        RaiseChanged();
        return Task.CompletedTask;
    }}

    public Task RemovePollingFilterAsync(string FilterHex)
    {{
        var Cleaned = new string(FilterHex.Where(Uri.IsHexDigit).ToArray()).ToUpperInvariant();
        PollingFilterEntries.RemoveAll(V => string.Equals(V, Cleaned, StringComparison.OrdinalIgnoreCase));
        if (IsWssConnected) return SendWssAsync(""remove_polling_filter"", new {{ filterHex = Cleaned }});
        RaiseChanged();
        return Task.CompletedTask;
    }}

    public Task AddPollingPatternFilterAsync(string Pattern, bool AutoTransact)
    {{
        var Trimmed = Pattern.Trim();
        if (!string.IsNullOrWhiteSpace(Trimmed) && !PollingPatternFilterEntries.Contains(Trimmed)) PollingPatternFilterEntries.Add(Trimmed);
        if (IsWssConnected) return SendWssAsync(""add_polling_pattern"", new {{ pattern = Trimmed, autoTransact = AutoTransact }});
        RaiseChanged();
        return Task.CompletedTask;
    }}

    public Task RemovePollingPatternFilterAsync(string Pattern)
    {{
        PollingPatternFilterEntries.RemoveAll(V => string.Equals(V, Pattern.Trim(), StringComparison.Ordinal));
        if (IsWssConnected) return SendWssAsync(""remove_polling_pattern"", new {{ pattern = Pattern.Trim() }});
        RaiseChanged();
        return Task.CompletedTask;
    }}

    public Task UpdateHceResponseAsync(string Text)
    {{
        HceAppletRuntime.UpdateResponseText(Text);
        SyncHceState();
        RaiseChanged();
        return Task.CompletedTask;
    }}

    public Task UpdateHceFResponseAsync(string Text)
    {{
        HceFAppletRuntime.UpdateResponseText(Text);
        SyncHceState();
        RaiseChanged();
        return Task.CompletedTask;
    }}

    private async Task SendWssAsync(string Method, object? Payload = null)
    {{
        if (Interop is null) return;
        var Msg = new {{ type = ""command"", method = Method, id = Guid.NewGuid().ToString(""N""), payload = Payload }};
        var Json = JsonSerializer.Serialize(Msg);
        await Interop.SendAsync(Json);
        LogSession(""wss"", Method, Payload);
    }}

    private void ApplyStateUpdate(JsonElement Data)
    {{
        if (Data.TryGetProperty(""isSupported"", out var V1)) IsSupported = V1.GetBoolean();
        if (Data.TryGetProperty(""isEnabled"", out var V2)) IsEnabled = V2.GetBoolean();
        if (Data.TryGetProperty(""isListening"", out var V3)) IsListening = V3.GetBoolean();
        if (Data.TryGetProperty(""supportsHce"", out var V4)) SupportsHce = V4.GetBoolean();
        if (Data.TryGetProperty(""supportsNfcFCardEmulation"", out var V5)) SupportsNfcFCardEmulation = V5.GetBoolean();
        if (Data.TryGetProperty(""isHceFEnabled"", out var V6)) IsHceFEnabled = V6.GetBoolean();
        if (Data.TryGetProperty(""supportsObserveMode"", out var V7)) SupportsObserveMode = V7.GetBoolean();
        if (Data.TryGetProperty(""isObserveModeEnabled"", out var V8)) IsObserveModeEnabled = V8.GetBoolean();
        if (Data.TryGetProperty(""supportsSecureNfc"", out var V9)) SupportsSecureNfc = V9.GetBoolean();
        if (Data.TryGetProperty(""isSecureNfcEnabled"", out var V10)) IsSecureNfcEnabled = V10.GetBoolean();
        if (Data.TryGetProperty(""isPreferredService"", out var V11)) IsPreferredService = V11.GetBoolean();
        if (Data.TryGetProperty(""supportsReaderOption"", out var V12)) SupportsReaderOption = V12.GetBoolean();
        if (Data.TryGetProperty(""isReaderOptionEnabled"", out var V13)) IsReaderOptionEnabled = V13.GetBoolean();
        if (Data.TryGetProperty(""supportsTagIntentPreference"", out var V14)) SupportsTagIntentPreference = V14.GetBoolean();
        if (Data.TryGetProperty(""supportsAidPrefixRegistration"", out var V15)) SupportsAidPrefixRegistration = V15.GetBoolean();
        if (Data.TryGetProperty(""statusText"", out var V16)) StatusText = V16.GetString() ?? StatusText;
    }}

    private void SyncHceState()
    {{
        HceResponseText = HceAppletRuntime.ResponseText;
        HceEvents = HceAppletRuntime.EventEntries;
        HceFResponseText = HceFAppletRuntime.ResponseText;
        HceFEvents = HceFAppletRuntime.EventEntries;
    }}

    private void HandleHceChanged(object? Sender, EventArgs E)
    {{
        SyncHceState();
        RaiseChanged();
    }}

    private void LogSession(string Stream, string EventType, object? Payload)
    {{
        NfcJson.Append(SessionJsonlEntries, 500, $""session.{{Stream}}"", EventType, Payload);
    }}

    private static void AppendEvent(List<string> Target, string Value)
    {{
        Target.Insert(0, $""{{DateTimeOffset.Now:HH:mm:ss}} {{Value}}"");
        if (Target.Count > 14) Target.RemoveRange(14, Target.Count - 14);
    }}

    private static string FormatHex(string Hex) => string.Join(' ', Enumerable.Range(0, Hex.Length / 2).Select(I => Hex.Substring(I * 2, 2)));

    private void RaiseChanged() => Changed?.Invoke(this, EventArgs.Empty);

    public async ValueTask DisposeAsync()
    {{
        HceAppletRuntime.Changed -= HandleHceChanged;
        HceFAppletRuntime.Changed -= HandleHceChanged;
        if (Interop is not null) await Interop.DisposeAsync();
    }}
}}
");
    }

    private void WriteHomePage()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("@page \"/\"");
        Sb.AppendLine("@implements IDisposable");
        Sb.AppendLine("@inject INfcWorkbenchService Pulse");
        Sb.AppendLine();
        Sb.Append("<PageTitle>").Append(AppTitle).AppendLine("</PageTitle>");
        Sb.AppendLine();

        Sb.AppendLine("<div class=\"scan-shell\">");

        Sb.AppendLine("    <div class=\"wss-bar\">");
        Sb.AppendLine("        <span class=\"wss-dot @(Pulse.IsWssConnected ? \"on\" : \"off\")\"></span>");
        Sb.AppendLine("        <span>@(Pulse.IsWssConnected ? $\"WSS connected: {Pulse.WssUrl}\" : \"WSS disconnected\")</span>");
        Sb.AppendLine("        <span>@(Pulse.HasWebNfc ? \"Web NFC available\" : \"No Web NFC\")</span>");
        Sb.AppendLine("        <input @bind=\"_wssUrl\" placeholder=\"wss://0.0.0.0:PORT\" style=\"width:16rem\" />");
        Sb.AppendLine("        <button class=\"action primary\" @onclick=\"ConnectWssAsync\" disabled=\"@Pulse.IsWssConnected\">Connect</button>");
        Sb.AppendLine("        <button class=\"action\" @onclick=\"DisconnectWssAsync\" disabled=\"@(!Pulse.IsWssConnected)\">Disconnect</button>");
        Sb.AppendLine("    </div>");

        Sb.AppendLine("    <section class=\"hero-card\">");
        Sb.AppendLine("        <p class=\"eyebrow\">Willow Maze</p>");
        Sb.AppendLine("        <h1>NFC Workbench</h1>");
        Sb.AppendLine("        <p class=\"lede\">");
        Sb.AppendLine("            Full NFC workbench in the browser via WebAssembly.");
        Sb.AppendLine("            Reader mode scans tags via Web NFC or WSS proxy to an Android device.");
        Sb.AppendLine("            HCE APDU and NFC-F applets run in-process in WASM.");
        Sb.AppendLine("            Raw tech I/O, NDEF write, observe mode, polling filters, and discovery");
        Sb.AppendLine("            technology control operate through the WSS bridge.");
        Sb.AppendLine("        </p>");
        Sb.AppendLine("        <div class=\"hero-actions\">");
        Sb.AppendLine("            <button class=\"action primary\" @onclick=\"StartAsync\" disabled=\"@Pulse.IsListening\">Start reader</button>");
        Sb.AppendLine("            <button class=\"action\" @onclick=\"StopAsync\" disabled=\"@(!Pulse.IsListening)\">Pause</button>");
        Sb.AppendLine("            <button class=\"action\" @onclick=\"RefreshAsync\">Refresh</button>");
        Sb.AppendLine("            <button class=\"action\" @onclick=\"OpenSettingsAsync\" disabled=\"@(!Pulse.IsWssConnected)\">NFC settings</button>");
        Sb.AppendLine("            @if (Pulse.SupportsTagIntentPreference)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                <button class=\"action\" @onclick=\"OpenRoutingAsync\">Tag routing</button>");
        Sb.AppendLine("            }");
        Sb.AppendLine("        </div>");
        Sb.AppendLine("    </section>");

        Sb.AppendLine("    <section class=\"status-grid\">");
        Sb.AppendLine("        <article class=\"panel-card\">");
        Sb.AppendLine("            <h2>Adapter state</h2>");
        Sb.AppendLine("            <div class=\"badge-row\">");
        Sb.AppendLine("                <span class=\"@GetBadgeClass(Pulse.IsSupported)\">@(Pulse.IsSupported ? \"NFC ready\" : \"NFC missing\")</span>");
        Sb.AppendLine("                <span class=\"@GetBadgeClass(Pulse.IsEnabled)\">@(Pulse.IsEnabled ? \"Radio on\" : \"Radio off\")</span>");
        Sb.AppendLine("                <span class=\"@GetBadgeClass(Pulse.IsListening)\">@(Pulse.IsListening ? \"Reader live\" : \"Reader paused\")</span>");
        Sb.AppendLine("                <span class=\"@GetBadgeClass(Pulse.SupportsHce)\">@(Pulse.SupportsHce ? \"HCE yes\" : \"HCE no\")</span>");
        Sb.AppendLine("                <span class=\"@GetBadgeClass(Pulse.SupportsNfcFCardEmulation)\">@(Pulse.SupportsNfcFCardEmulation ? \"NFC-F yes\" : \"NFC-F no\")</span>");
        Sb.AppendLine("                <span class=\"@GetBadgeClass(Pulse.SupportsObserveMode)\">@(Pulse.SupportsObserveMode ? \"Observe mode\" : \"No observe mode\")</span>");
        Sb.AppendLine("                <span class=\"@GetBadgeClass(Pulse.SupportsSecureNfc)\">@(Pulse.SupportsSecureNfc ? (Pulse.IsSecureNfcEnabled ? \"Secure NFC on\" : \"Secure NFC off\") : \"No secure NFC\")</span>");
        Sb.AppendLine("                <span class=\"@GetBadgeClass(Pulse.SupportsReaderOption)\">@(Pulse.SupportsReaderOption ? (Pulse.IsReaderOptionEnabled ? \"Reader option on\" : \"Reader option off\") : \"No reader option\")</span>");
        Sb.AppendLine("                <span class=\"@GetBadgeClass(Pulse.IsWssConnected)\">@(Pulse.IsWssConnected ? \"WSS connected\" : \"WSS offline\")</span>");
        Sb.AppendLine("                <span class=\"@GetBadgeClass(Pulse.HasWebNfc)\">@(Pulse.HasWebNfc ? \"Web NFC\" : \"No Web NFC\")</span>");
        Sb.AppendLine("                @if (Pulse.SupportsObserveMode)");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    <span class=\"@GetBadgeClass(Pulse.IsObserveModeEnabled)\">@(Pulse.IsObserveModeEnabled ? \"Observing\" : \"Transactions\")</span>");
        Sb.AppendLine("                }");
        Sb.AppendLine("                @if (Pulse.SupportsTagIntentPreference)");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    <span class=\"@GetBadgeClass(Pulse.IsTagIntentAllowed == true)\">@(Pulse.IsTagIntentAllowed == true ? \"Tag intents allowed\" : \"Tag intents blocked\")</span>");
        Sb.AppendLine("                }");
        Sb.AppendLine("                @if (Pulse.HasCustomDiscoveryTechnology)");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    <span class=\"badge good\">Custom discovery</span>");
        Sb.AppendLine("                }");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("            <p class=\"status-text\">@Pulse.StatusText</p>");
        Sb.AppendLine("            <ul class=\"detail-list\">");
        Sb.AppendLine("                @foreach (var Note in Pulse.CapabilityNotes) { <li>@Note</li> }");
        Sb.AppendLine("            </ul>");
        Sb.AppendLine("            <ul class=\"detail-list\">");
        Sb.AppendLine("                @foreach (var Fact in Pulse.AntennaFacts) { <li>@Fact</li> }");
        Sb.AppendLine("            </ul>");
        Sb.AppendLine("            <div class=\"chip-row\">");
        Sb.AppendLine("                <span class=\"chip\">Payment: @Pulse.PreferredPaymentDescription</span>");
        Sb.AppendLine("                <span class=\"chip\">Route: @Pulse.PreferredPaymentRoute</span>");
        Sb.AppendLine("                @if (Pulse.DefaultNfcSubscriptionId >= 0)");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    <span class=\"chip\">Sub ID: @Pulse.DefaultNfcSubscriptionId</span>");
        Sb.AppendLine("                }");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("        </article>");
        Sb.AppendLine();
        Sb.AppendLine("        <article class=\"panel-card\">");
        Sb.AppendLine("            <h2>Latest tag</h2>");
        Sb.AppendLine("            @if (_Latest is null)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                <p class=\"empty-state\">Nothing captured yet. Start the reader and tap a tag.</p>");
        Sb.AppendLine("            }");
        Sb.AppendLine("            else");
        Sb.AppendLine("            {");
        Sb.AppendLine("                <p class=\"snapshot-title\">@_Latest.Summary</p>");
        Sb.AppendLine("                <p class=\"snapshot-time\">@_Latest.CapturedAtUtc.ToLocalTime().ToString(\"yyyy-MM-dd HH:mm:ss\")</p>");
        Sb.AppendLine("                <code class=\"mono\">@_Latest.IdentifierHex</code>");
        Sb.AppendLine("                <p class=\"status-text write-note\">@_Latest.WriteOutcome</p>");
        Sb.AppendLine("                <div class=\"hero-actions compact\">");
        Sb.AppendLine("                    <button class=\"action\" @onclick=\"IgnoreTagAsync\" disabled=\"@(!Pulse.IsWssConnected)\">Ignore tag (@_DebounceMs ms)</button>");
        Sb.AppendLine("                    <input type=\"number\" @bind=\"_DebounceMs\" style=\"width:5em\" min=\"100\" max=\"10000\" step=\"100\" />");
        Sb.AppendLine("                </div>");
        Sb.AppendLine("            }");
        Sb.AppendLine("        </article>");
        Sb.AppendLine("    </section>");

        Sb.AppendLine("    <section class=\"detail-grid\">");
        Sb.AppendLine("        <article class=\"panel-card detail-wide\">");
        Sb.AppendLine("            <h2>Next NDEF write</h2>");
        Sb.AppendLine("            <p class=\"status-text\">Arm a write for the next scanned tag. Uses Web NFC or WSS proxy.</p>");
        Sb.AppendLine("            <div class=\"form-grid\">");
        Sb.AppendLine("                <label><span>Payload kind</span><select @bind=\"_WriteKind\"><option value=\"Text\">Text</option><option value=\"Uri\">URI</option><option value=\"Mime\">MIME</option></select></label>");
        Sb.AppendLine("                @if (_WriteKind == \"Mime\") { <label><span>MIME type</span><input @bind=\"_MimeType\" placeholder=\"text/plain\" /></label> }");
        Sb.AppendLine("                <label class=\"wide\"><span>Payload</span><textarea @bind=\"_PayloadText\" rows=\"4\" placeholder=\"Hello from Willow Maze\"></textarea></label>");
        Sb.AppendLine("                <label class=\"toggle\"><input type=\"checkbox\" @bind=\"_MakeReadOnly\" /><span>Lock tag after write</span></label>");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("            <div class=\"hero-actions compact\">");
        Sb.AppendLine("                <button class=\"action primary\" @onclick=\"ArmWriteAsync\">Arm next write</button>");
        Sb.AppendLine("                <button class=\"action\" @onclick=\"ClearWriteAsync\" disabled=\"@(Pulse.PendingWrite is null)\">Clear pending write</button>");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("            <div class=\"badge-row inline-gap\">");
        Sb.AppendLine("                <span class=\"badge neutral\">@(Pulse.PendingWrite is null ? \"No pending write\" : Pulse.PendingWrite.Summary)</span>");
        Sb.AppendLine("                <span class=\"badge neutral\">@Pulse.LastWriteStatus</span>");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("        </article>");

        Sb.AppendLine("        <article class=\"panel-card\">");
        Sb.AppendLine("            <h2>ISO-DEP applet (in-process)</h2>");
        Sb.AppendLine("            <p class=\"status-text\">HCE APDU applet runs entirely in browser WASM. SELECT AID + GET DATA + PUT DATA + ECHO + async response.</p>");
        Sb.AppendLine("            <div class=\"chip-row\">");
        Sb.AppendLine("                <span class=\"chip\">AID @Pulse.HceAidHex</span>");
        Sb.AppendLine("                @if (Pulse.SupportsAidPrefixRegistration) { <span class=\"chip\">AID prefix supported</span> }");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("            <p class=\"status-text\">@Pulse.HceStatusText</p>");
        Sb.AppendLine("            <label class=\"wide\"><span>Response text</span><textarea @bind=\"_HceResponseText\" rows=\"3\"></textarea></label>");
        Sb.AppendLine("            <div class=\"hero-actions compact\">");
        Sb.AppendLine("                <button class=\"action primary\" @onclick=\"SaveHceAsync\">Save APDU text</button>");
        Sb.AppendLine("                <button class=\"action\" @onclick=\"PreferHceAsync\" disabled=\"@(!Pulse.IsWssConnected)\">Prefer service</button>");
        Sb.AppendLine("                <button class=\"action\" @onclick=\"ReleaseHceAsync\" disabled=\"@(!Pulse.IsPreferredService)\">Release preference</button>");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("        </article>");

        Sb.AppendLine("        <article class=\"panel-card\">");
        Sb.AppendLine("            <h2>Dynamic AID management</h2>");
        Sb.AppendLine("            <p class=\"status-text\">Register additional AIDs for the APDU applet. Enter hex AIDs separated by commas or newlines.</p>");
        Sb.AppendLine("            <label class=\"wide\"><span>AID hex values</span><textarea @bind=\"_DynamicAidText\" rows=\"3\" placeholder=\"F0010203040506, F0394148148100\"></textarea></label>");
        Sb.AppendLine("            <div class=\"hero-actions compact\">");
        Sb.AppendLine("                <button class=\"action primary\" @onclick=\"RegisterAidsAsync\">Register AIDs</button>");
        Sb.AppendLine("                <button class=\"action\" @onclick=\"ClearAidsAsync\">Clear dynamic AIDs</button>");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("            @if (Pulse.RegisteredHceAids.Count > 0) { <div class=\"chip-row\">@foreach (var Aid in Pulse.RegisteredHceAids) { <span class=\"chip\">@Aid</span> }</div> }");
        Sb.AppendLine("        </article>");

        Sb.AppendLine("        <article class=\"panel-card\">");
        Sb.AppendLine("            <h2>ISO-DEP events</h2>");
        Sb.AppendLine("            @if (Pulse.HceEvents.Count == 0) { <p class=\"empty-state\">No APDU events yet.</p> }");
        Sb.AppendLine("            else { <ul class=\"detail-list\">@foreach (var Entry in Pulse.HceEvents) { <li>@Entry</li> }</ul> }");
        Sb.AppendLine("        </article>");

        Sb.AppendLine("        <article class=\"panel-card\">");
        Sb.AppendLine("            <h2>Observe mode</h2>");
        Sb.AppendLine("            <p class=\"status-text\">Observe mode logs polling frames without completing the transaction (requires WSS).</p>");
        Sb.AppendLine("            <p class=\"status-text\">@Pulse.ObserveModeStatusText</p>");
        Sb.AppendLine("            <div class=\"hero-actions compact\">");
        Sb.AppendLine("                <button class=\"action primary\" @onclick=\"EnableObserveAsync\" disabled=\"@(!Pulse.IsWssConnected || !Pulse.SupportsObserveMode)\">Enable observe</button>");
        Sb.AppendLine("                <button class=\"action\" @onclick=\"DisableObserveAsync\" disabled=\"@(!Pulse.IsObserveModeEnabled)\">Disable observe</button>");
        Sb.AppendLine("                <button class=\"action\" @onclick=\"SetDefaultObserveTrueAsync\" disabled=\"@(!Pulse.IsWssConnected || !Pulse.SupportsObserveMode)\">Default on</button>");
        Sb.AppendLine("                <button class=\"action\" @onclick=\"SetDefaultObserveFalseAsync\" disabled=\"@(!Pulse.ShouldDefaultToObserveMode)\">Default off</button>");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("        </article>");

        Sb.AppendLine("        <article class=\"panel-card\">");
        Sb.AppendLine("            <h2>Polling loop filters</h2>");
        Sb.AppendLine("            <p class=\"status-text\">Register exact hex or regex-pattern polling loop filters (requires WSS).</p>");
        Sb.AppendLine("            <div class=\"form-grid\">");
        Sb.AppendLine("                <label class=\"wide\"><span>Hex filter</span><input @bind=\"_PollingFilterHex\" placeholder=\"050506070809\" /></label>");
        Sb.AppendLine("                <label class=\"toggle\"><input type=\"checkbox\" @bind=\"_PollingAutoTransact\" /><span>Auto-transact on match</span></label>");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("            <div class=\"hero-actions compact\">");
        Sb.AppendLine("                <button class=\"action primary\" @onclick=\"AddPollingFilterAsync\" disabled=\"@(!Pulse.IsWssConnected)\">Add exact filter</button>");
        Sb.AppendLine("                <button class=\"action\" @onclick=\"RemovePollingFilterAsync\" disabled=\"@(Pulse.PollingFilters.Count == 0)\">Remove</button>");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("            @if (Pulse.PollingFilters.Count > 0) { <div class=\"chip-row\">@foreach (var F in Pulse.PollingFilters) { <span class=\"chip\">@F</span> }</div> }");
        Sb.AppendLine("            <div class=\"form-grid\">");
        Sb.AppendLine("                <label class=\"wide\"><span>Pattern filter (regex)</span><input @bind=\"_PollingPatternFilter\" placeholder=\"05050[0-9A-F]*\" /></label>");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("            <div class=\"hero-actions compact\">");
        Sb.AppendLine("                <button class=\"action primary\" @onclick=\"AddPollingPatternFilterAsync\" disabled=\"@(!Pulse.IsWssConnected)\">Add pattern filter</button>");
        Sb.AppendLine("                <button class=\"action\" @onclick=\"RemovePollingPatternFilterAsync\" disabled=\"@(Pulse.PollingPatternFilters.Count == 0)\">Remove pattern</button>");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("            @if (Pulse.PollingPatternFilters.Count > 0) { <div class=\"chip-row\">@foreach (var P in Pulse.PollingPatternFilters) { <span class=\"chip\">@P</span> }</div> }");
        Sb.AppendLine("        </article>");
        Sb.AppendLine("    </section>");

        Sb.AppendLine("    <section class=\"detail-grid\">");
        Sb.AppendLine("        <article class=\"panel-card detail-wide\">");
        Sb.AppendLine("            <h2>Discovery technology</h2>");
        Sb.AppendLine("            <p class=\"status-text\">Override NFC poll and listen technologies via WSS. @Pulse.DiscoveryStatusText</p>");
        Sb.AppendLine("            <div class=\"form-grid\">");
        Sb.AppendLine("                <label class=\"toggle\"><input type=\"checkbox\" @bind=\"_PollNfcA\" /><span>Poll NFC-A</span></label>");
        Sb.AppendLine("                <label class=\"toggle\"><input type=\"checkbox\" @bind=\"_PollNfcB\" /><span>Poll NFC-B</span></label>");
        Sb.AppendLine("                <label class=\"toggle\"><input type=\"checkbox\" @bind=\"_PollNfcF\" /><span>Poll NFC-F</span></label>");
        Sb.AppendLine("                <label class=\"toggle\"><input type=\"checkbox\" @bind=\"_PollNfcV\" /><span>Poll NFC-V</span></label>");
        Sb.AppendLine("                <label class=\"toggle\"><input type=\"checkbox\" @bind=\"_PollBarcode\" /><span>Poll Barcode</span></label>");
        Sb.AppendLine("                <label class=\"toggle\"><input type=\"checkbox\" @bind=\"_ListenA\" /><span>Listen passive A</span></label>");
        Sb.AppendLine("                <label class=\"toggle\"><input type=\"checkbox\" @bind=\"_ListenB\" /><span>Listen passive B</span></label>");
        Sb.AppendLine("                <label class=\"toggle\"><input type=\"checkbox\" @bind=\"_ListenF\" /><span>Listen passive F</span></label>");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("            <div class=\"hero-actions compact\">");
        Sb.AppendLine("                <button class=\"action primary\" @onclick=\"SetDiscoveryAsync\" disabled=\"@(!Pulse.IsWssConnected)\">Apply discovery</button>");
        Sb.AppendLine("                <button class=\"action\" @onclick=\"ResetDiscoveryAsync\" disabled=\"@(!Pulse.HasCustomDiscoveryTechnology)\">Reset to defaults</button>");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("        </article>");

        Sb.AppendLine("        <article class=\"panel-card detail-wide\">");
        Sb.AppendLine("            <h2>Raw Tech I/O</h2>");
        Sb.AppendLine("            <p class=\"status-text\">Send raw hex frames over NFC tech layers via WSS proxy.</p>");
        Sb.AppendLine("            <div class=\"form-grid\">");
        Sb.AppendLine("                <label><span>Technology</span><select @bind=\"_RawTechnology\"><option value=\"IsoDep\">IsoDep</option><option value=\"NfcA\">NfcA</option><option value=\"NfcB\">NfcB</option><option value=\"NfcF\">NfcF</option><option value=\"NfcV\">NfcV</option><option value=\"MifareClassic\">MifareClassic</option><option value=\"MifareUltralight\">MifareUltralight</option></select></label>");
        Sb.AppendLine("                <label class=\"wide\"><span>Hex command</span><input @bind=\"_RawCommandHex\" placeholder=\"00 A4 04 00 07 F0 77 0A 11 B1 C2 D3\" /></label>");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("            <div class=\"hero-actions compact\">");
        Sb.AppendLine("                <button class=\"action primary\" @onclick=\"SendRawAsync\" disabled=\"@(!Pulse.IsWssConnected)\">Send raw frame</button>");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("            <div class=\"badge-row inline-gap\"><span class=\"badge neutral\">@Pulse.LastRawStatus</span></div>");
        Sb.AppendLine("        </article>");

        Sb.AppendLine("        <article class=\"panel-card\">");
        Sb.AppendLine("            <h2>Raw events</h2>");
        Sb.AppendLine("            @if (Pulse.RawEvents.Count == 0) { <p class=\"empty-state\">No raw frames sent yet.</p> }");
        Sb.AppendLine("            else { <ul class=\"detail-list\">@foreach (var Entry in Pulse.RawEvents) { <li>@Entry</li> }</ul> }");
        Sb.AppendLine("        </article>");

        Sb.AppendLine("        <article class=\"panel-card\">");
        Sb.AppendLine("            <h2>NFC-F applet (in-process)</h2>");
        Sb.AppendLine("            <p class=\"status-text\">NFC-F host card emulation runs in browser WASM. Enable/disable via WSS proxy.</p>");
        Sb.AppendLine("            <div class=\"chip-row\">");
        Sb.AppendLine("                <span class=\"chip\">System Code @Pulse.HceFSystemCodeHex</span>");
        Sb.AppendLine("                <span class=\"chip\">NFCID2 @Pulse.HceFNfcid2Hex</span>");
        Sb.AppendLine("                <span class=\"chip\">T3T PMm @Pulse.HceFT3tPmmHex</span>");
        Sb.AppendLine("                <span class=\"chip\">@(Pulse.IsHceFEnabled ? \"NFC-F enabled\" : \"NFC-F disabled\")</span>");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("            <p class=\"status-text\">@Pulse.HceFStatusText</p>");
        Sb.AppendLine("            <label class=\"wide\"><span>NFC-F response text</span><textarea @bind=\"_HceFResponseText\" rows=\"3\"></textarea></label>");
        Sb.AppendLine("            <div class=\"hero-actions compact\">");
        Sb.AppendLine("                <button class=\"action primary\" @onclick=\"SaveHceFAsync\">Save NFC-F text</button>");
        Sb.AppendLine("                <button class=\"action\" @onclick=\"EnableHceFAsync\" disabled=\"@(!Pulse.IsWssConnected)\">Enable NFC-F</button>");
        Sb.AppendLine("                <button class=\"action\" @onclick=\"DisableHceFAsync\" disabled=\"@(!Pulse.IsHceFEnabled)\">Disable NFC-F</button>");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("        </article>");

        Sb.AppendLine("        <article class=\"panel-card\">");
        Sb.AppendLine("            <h2>NFC-F events</h2>");
        Sb.AppendLine("            @if (Pulse.HceFEvents.Count == 0) { <p class=\"empty-state\">No NFC-F events yet.</p> }");
        Sb.AppendLine("            else { <ul class=\"detail-list\">@foreach (var Entry in Pulse.HceFEvents) { <li>@Entry</li> }</ul> }");
        Sb.AppendLine("        </article>");
        Sb.AppendLine("    </section>");

        Sb.AppendLine("    @if (_Latest is not null)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        <section class=\"detail-grid\">");
        Sb.AppendLine("            <article class=\"panel-card\">");
        Sb.AppendLine("                <h2>Tech stack</h2>");
        Sb.AppendLine("                <div class=\"chip-row\">@foreach (var Item in _Latest.Technologies) { <span class=\"chip\">@Item</span> }</div>");
        Sb.AppendLine("                <div class=\"headline-grid\">@foreach (var Fact in _Latest.HeadlineFacts) { <div class=\"headline-chip\">@Fact</div> }</div>");
        Sb.AppendLine("            </article>");
        Sb.AppendLine("            <article class=\"panel-card\">");
        Sb.AppendLine("                <h2>NDEF records</h2>");
        Sb.AppendLine("                @if (_Latest.Records.Count == 0) { <p class=\"empty-state\">No NDEF records decoded.</p> }");
        Sb.AppendLine("                else { <div class=\"record-grid\">@foreach (var Record in _Latest.Records) { <article class=\"record-card\"><p class=\"record-kind\">@Record.Icon @Record.Kind</p><p class=\"record-summary\">@Record.Summary</p><code class=\"mono mini\">@Record.PayloadHex</code></article> }</div> }");
        Sb.AppendLine("            </article>");
        Sb.AppendLine("            <article class=\"panel-card detail-wide\">");
        Sb.AppendLine("                <h2>Tech details</h2>");
        Sb.AppendLine("                <ul class=\"detail-list\">@foreach (var Line in _Latest.Details) { <li>@Line</li> }</ul>");
        Sb.AppendLine("            </article>");
        Sb.AppendLine("        </section>");
        Sb.AppendLine("    }");

        Sb.AppendLine("    <section class=\"detail-grid\">");
        Sb.AppendLine("        <article class=\"panel-card detail-wide\">");
        Sb.AppendLine("            <h2>JSONL logs</h2>");
        Sb.AppendLine("            <p class=\"status-text\">All NFC events logged in JSONL format.</p>");
        Sb.AppendLine("            <div class=\"hero-actions compact\">");
        Sb.AppendLine("                <button class=\"action @(_ActiveLog == \"session\" ? \"primary\" : \"\")\" @onclick='() => _ActiveLog = \"session\"'>Session</button>");
        Sb.AppendLine("                <button class=\"action @(_ActiveLog == \"tag\" ? \"primary\" : \"\")\" @onclick='() => _ActiveLog = \"tag\"'>Tag</button>");
        Sb.AppendLine("                <button class=\"action @(_ActiveLog == \"raw\" ? \"primary\" : \"\")\" @onclick='() => _ActiveLog = \"raw\"'>Raw</button>");
        Sb.AppendLine("                <button class=\"action @(_ActiveLog == \"hce\" ? \"primary\" : \"\")\" @onclick='() => _ActiveLog = \"hce\"'>HCE</button>");
        Sb.AppendLine("                <button class=\"action @(_ActiveLog == \"hcef\" ? \"primary\" : \"\")\" @onclick='() => _ActiveLog = \"hcef\"'>HCE-F</button>");
        Sb.AppendLine("                <button class=\"action @(_ActiveLog == \"adapter\" ? \"primary\" : \"\")\" @onclick='() => _ActiveLog = \"adapter\"'>Adapter</button>");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("            <pre class=\"jsonl-viewer\">@GetActiveLogContent()</pre>");
        Sb.AppendLine("        </article>");
        Sb.AppendLine("    </section>");
        Sb.AppendLine("</div>");

        Sb.AppendLine();
        Sb.AppendLine("@code {");
        Sb.AppendLine("    private NfcTagSnapshot? _Latest;");
        Sb.AppendLine("    private string _WriteKind = nameof(NdefPayloadKind.Text);");
        Sb.AppendLine("    private string _PayloadText = \"Hello from Willow Maze\";");
        Sb.AppendLine("    private string _MimeType = \"text/plain\";");
        Sb.AppendLine("    private bool _MakeReadOnly;");
        Sb.AppendLine("    private string _RawTechnology = \"IsoDep\";");
        Sb.AppendLine("    private string _RawCommandHex = \"00 A4 04 00 07 F0 77 0A 11 B1 C2 D3\";");
        Sb.AppendLine("    private string _HceResponseText = \"Willow Maze demo payload\";");
        Sb.AppendLine("    private string _HceFResponseText = \"Willow Maze flare payload\";");
        Sb.AppendLine("    private string _DynamicAidText = string.Empty;");
        Sb.AppendLine("    private string _PollingFilterHex = string.Empty;");
        Sb.AppendLine("    private string _PollingPatternFilter = string.Empty;");
        Sb.AppendLine("    private bool _PollingAutoTransact;");
        Sb.AppendLine("    private int _DebounceMs = 1500;");
        Sb.AppendLine("    private string _ActiveLog = \"session\";");
        Sb.AppendLine("    private bool _PollNfcA = true, _PollNfcB = true, _PollNfcF = true, _PollNfcV = true, _PollBarcode = true;");
        Sb.AppendLine("    private bool _ListenA = true, _ListenB = true, _ListenF = true;");
        Sb.AppendLine("    private string _wssUrl = \"wss://0.0.0.0:51234\";");
        Sb.AppendLine();
        Sb.AppendLine("    protected override async Task OnInitializedAsync()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        Pulse.Changed += HandleChanged;");
        Sb.AppendLine("        await Pulse.InitializeAsync();");
        Sb.AppendLine("        _Latest = Pulse.LatestTag;");
        Sb.AppendLine("        _HceResponseText = Pulse.HceResponseText;");
        Sb.AppendLine("        _HceFResponseText = Pulse.HceFResponseText;");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private Task ConnectWssAsync() => Pulse.ConnectWssAsync(_wssUrl);");
        Sb.AppendLine("    private Task DisconnectWssAsync() => Pulse.DisconnectWssAsync();");
        Sb.AppendLine("    private Task StartAsync() => Pulse.StartReaderAsync();");
        Sb.AppendLine("    private Task StopAsync() => Pulse.StopReaderAsync();");
        Sb.AppendLine("    private Task RefreshAsync() => Pulse.RefreshAsync();");
        Sb.AppendLine("    private Task OpenSettingsAsync() => Pulse.OpenNfcSettingsAsync();");
        Sb.AppendLine("    private Task OpenRoutingAsync() => Pulse.OpenTagRoutingAsync();");
        Sb.AppendLine("    private Task ClearWriteAsync() => Pulse.ClearWriteAsync();");
        Sb.AppendLine("    private Task SendRawAsync() => Pulse.SendRawAsync(_RawTechnology, _RawCommandHex);");
        Sb.AppendLine("    private Task SaveHceAsync() => Pulse.UpdateHceResponseAsync(_HceResponseText);");
        Sb.AppendLine("    private Task SaveHceFAsync() => Pulse.UpdateHceFResponseAsync(_HceFResponseText);");
        Sb.AppendLine("    private Task PreferHceAsync() => Pulse.SetPreferredServiceAsync(true);");
        Sb.AppendLine("    private Task ReleaseHceAsync() => Pulse.SetPreferredServiceAsync(false);");
        Sb.AppendLine("    private Task EnableHceFAsync() => Pulse.SetHceFEnabledAsync(true);");
        Sb.AppendLine("    private Task DisableHceFAsync() => Pulse.SetHceFEnabledAsync(false);");
        Sb.AppendLine("    private Task EnableObserveAsync() => Pulse.SetObserveModeEnabledAsync(true);");
        Sb.AppendLine("    private Task DisableObserveAsync() => Pulse.SetObserveModeEnabledAsync(false);");
        Sb.AppendLine("    private Task SetDefaultObserveTrueAsync() => Pulse.SetDefaultObserveModeAsync(true);");
        Sb.AppendLine("    private Task SetDefaultObserveFalseAsync() => Pulse.SetDefaultObserveModeAsync(false);");
        Sb.AppendLine("    private Task IgnoreTagAsync() => Pulse.IgnoreCurrentTagAsync(_DebounceMs);");
        Sb.AppendLine("    private Task RegisterAidsAsync() => Pulse.RegisterHceAidsAsync(_DynamicAidText);");
        Sb.AppendLine("    private Task ClearAidsAsync() => Pulse.ClearHceAidsAsync();");
        Sb.AppendLine("    private Task AddPollingFilterAsync() => Pulse.AddPollingFilterAsync(_PollingFilterHex, _PollingAutoTransact);");
        Sb.AppendLine("    private Task RemovePollingFilterAsync() => Pulse.RemovePollingFilterAsync(_PollingFilterHex);");
        Sb.AppendLine("    private Task AddPollingPatternFilterAsync() => Pulse.AddPollingPatternFilterAsync(_PollingPatternFilter, _PollingAutoTransact);");
        Sb.AppendLine("    private Task RemovePollingPatternFilterAsync() => Pulse.RemovePollingPatternFilterAsync(_PollingPatternFilter);");
        Sb.AppendLine("    private Task ResetDiscoveryAsync() => Pulse.ResetDiscoveryTechnologyAsync();");
        Sb.AppendLine();
        Sb.AppendLine("    private Task ArmWriteAsync()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        var Kind = Enum.TryParse<NdefPayloadKind>(_WriteKind, true, out var Parsed) ? Parsed : NdefPayloadKind.Text;");
        Sb.AppendLine("        return Pulse.ArmWriteAsync(new NdefWriteDraft(Kind, _PayloadText, _MimeType, string.Empty, string.Empty, _MakeReadOnly, DateTimeOffset.UtcNow, string.Empty, string.Empty, string.Empty, string.Empty));");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private Task SetDiscoveryAsync()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        var PollFlags = 0x80;");
        Sb.AppendLine("        if (_PollNfcA) PollFlags |= 0x01;");
        Sb.AppendLine("        if (_PollNfcB) PollFlags |= 0x02;");
        Sb.AppendLine("        if (_PollNfcF) PollFlags |= 0x04;");
        Sb.AppendLine("        if (_PollNfcV) PollFlags |= 0x08;");
        Sb.AppendLine("        if (_PollBarcode) PollFlags |= 0x10;");
        Sb.AppendLine("        var ListenFlags = 0;");
        Sb.AppendLine("        if (_ListenA) ListenFlags |= 0x01;");
        Sb.AppendLine("        if (_ListenB) ListenFlags |= 0x02;");
        Sb.AppendLine("        if (_ListenF) ListenFlags |= 0x04;");
        Sb.AppendLine("        return Pulse.SetDiscoveryTechnologyAsync(PollFlags, ListenFlags);");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private string GetActiveLogContent() => _ActiveLog switch");
        Sb.AppendLine("    {");
        Sb.AppendLine("        \"session\" => string.IsNullOrWhiteSpace(Pulse.SessionJsonl) ? \"(no session events yet)\" : Pulse.SessionJsonl,");
        Sb.AppendLine("        \"tag\" => string.IsNullOrWhiteSpace(Pulse.LatestTagJsonl) ? \"(no tag scanned yet)\" : Pulse.LatestTagJsonl,");
        Sb.AppendLine("        \"raw\" => string.IsNullOrWhiteSpace(Pulse.RawJsonl) ? \"(no raw events yet)\" : Pulse.RawJsonl,");
        Sb.AppendLine("        \"hce\" => string.IsNullOrWhiteSpace(Pulse.HceJsonl) ? \"(no HCE events yet)\" : Pulse.HceJsonl,");
        Sb.AppendLine("        \"hcef\" => string.IsNullOrWhiteSpace(Pulse.HceFJsonl) ? \"(no HCE-F events yet)\" : Pulse.HceFJsonl,");
        Sb.AppendLine("        \"adapter\" => Pulse.AdapterSnapshotJson,");
        Sb.AppendLine("        _ => \"(select a log stream)\"");
        Sb.AppendLine("    };");
        Sb.AppendLine();
        Sb.AppendLine("    private void HandleChanged(object? Sender, EventArgs E)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        _Latest = Pulse.LatestTag;");
        Sb.AppendLine("        _HceResponseText = Pulse.HceResponseText;");
        Sb.AppendLine("        _HceFResponseText = Pulse.HceFResponseText;");
        Sb.AppendLine("        _ = InvokeAsync(StateHasChanged);");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private static string GetBadgeClass(bool Value) => Value ? \"badge good\" : \"badge bad\";");
        Sb.AppendLine();
        Sb.AppendLine("    public void Dispose() => Pulse.Changed -= HandleChanged;");
        Sb.AppendLine("}");

        File.WriteAllText(Path.Combine(OutputDir, "Pages", "Index.razor"), Sb.ToString());
    }

    private void WriteDecompiledCoreTypes()
    {
        var CoreModelTypes = new[] { "NfcTagSnapshot", "NdefRecordSnapshot", "NdefWriteDraft", "NdefPayloadKind",
            "MifareClassicSectorDump", "MifareClassicBlockDump", "MifareUltralightPageDump" };
        var ModelCount = 0;

        foreach (var AsmKvp in Decompiler.GetAllAssemblies())
        {
            foreach (var Type in AsmKvp.Value.Types)
            {
                if (CoreModelTypes.Contains(Type.TypeName, StringComparer.Ordinal))
                {
                    var Source = Decompiler.GenerateSourceFile(Type, Namespace + ".Models");
                    File.WriteAllText(Path.Combine(OutputDir, "Models", Type.TypeName + ".cs"), Source);
                    Console.WriteLine(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                        "  Binary→Model: {0} ({1} properties)",
                        Type.TypeName, Type.Properties.Count));
                    ModelCount++;
                }
                else if (Type.TypeName == "INfcWorkbenchService" && Type.IsInterface)
                {
                    var InterfaceSource = Decompiler.GenerateSourceFile(Type, Namespace + ".Services");
                    File.WriteAllText(Path.Combine(OutputDir, "Services", "INfcWorkbenchService.binary.cs"), InterfaceSource);
                    Console.WriteLine(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                        "  Binary→Reference: INfcWorkbenchService ({0} methods, {1} properties, {2} events)",
                        Type.Methods.Count(M => !IsAccessorName(M.Name)),
                        Type.Properties.Count, Type.Events.Count));
                }
                else if (Type.TypeName is "HceAppletRuntime" or "HceFAppletRuntime" or "NfcJson")
                {
                    var RefSource = Decompiler.GenerateSourceFile(Type, Namespace + ".Services", StripAndroidFromBody);
                    File.WriteAllText(Path.Combine(OutputDir, "Services", Type.TypeName + ".binary.cs"), RefSource);
                    Console.WriteLine(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                        "  Binary→Reference: {0} ({1} methods, {2} fields)",
                        Type.TypeName, Type.Methods.Count, Type.Fields.Count));
                }
            }
        }

        if (ModelCount == 0)
        {
            Console.WriteLine("  No model types found in APK binary — using fallback templates");
            WriteModels();
        }
        else
        {
            Console.WriteLine(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "  {0} models from compiled binary", ModelCount));
        }

        WriteNfcJson();
        WriteHceAppletRuntime();
        WriteHceFAppletRuntime();
    }

    private static bool IsAccessorName(string Name)
    {
        return Name.StartsWith("get_", StringComparison.Ordinal) ||
               Name.StartsWith("set_", StringComparison.Ordinal) ||
               Name.StartsWith("add_", StringComparison.Ordinal) ||
               Name.StartsWith("remove_", StringComparison.Ordinal);
    }

    private static string StripAndroidFromBody(string Body)
    {
        return Body
            .Replace("Android.Nfc.", "/* NFC: */")
            .Replace("Android.Content.", "/* Content: */")
            .Replace("Android.App.", "/* App: */")
            .Replace("Java.Lang.", "/* Java: */")
            .Replace("DeactivationReason", "string")
            .Replace("DeactivationReasonF", "string")
            .Replace("PollingFrame", "object");
    }

    private void WriteDecompiledSources()
    {
        var DecompiledDir = Path.Combine(OutputDir, "Decompiled");
        Directory.CreateDirectory(DecompiledDir);

        var SkipTypes = new HashSet<string>(StringComparer.Ordinal)
        {
            "INfcWorkbenchService", "NfcWorkbenchService",
            "HceAppletRuntime", "HceFAppletRuntime", "NfcJson",
            "NfcTagSnapshot", "NdefRecordSnapshot", "NdefWriteDraft", "NdefPayloadKind",
            "GlowGlyphService", "MossPulseService", "NfcBroadcastReceiver",
            "TapRelayClient", "ServerDiscovery", "PaymentFlow",
            "App", "MauiProgram", "MainPage", "MainActivity", "MainApplication",
            "Resource", "ResourceConstant", "ValidatableTypeAttribute", "EmbeddedAttribute",
            "Home", "Routes", "_Imports", "MainLayout", "NotFound",
            "Animation", "Animator", "Attribute", "Boolean", "Color", "Dimension",
            "Drawable", "Id", "Integer", "Interpolator", "Layout", "Mipmap",
            "Plurals", "String", "Style", "Styleable", "Xml"
        };

        var AndroidNamespaces = new HashSet<string>(StringComparer.Ordinal)
        {
            "Android.App", "Android.Content", "Android.Nfc", "Android.Nfc.CardEmulators",
            "Android.Nfc.Tech", "Android.OS", "Android.Provider",
            "Microsoft.Maui", "Microsoft.Maui.ApplicationModel"
        };

        var TypeCount = 0;
        var MethodCount = 0;

        foreach (var AsmKvp in Decompiler.GetAllAssemblies())
        {
            var Asm = AsmKvp.Value;
            foreach (var Type in Asm.Types)
            {
                if (SkipTypes.Contains(Type.TypeName))
                {
                    continue;
                }

                if (AndroidNamespaces.Any(Ns => Type.TypeNamespace.StartsWith(Ns, StringComparison.Ordinal)))
                {
                    continue;
                }

                if (Type.TypeName.StartsWith("<", StringComparison.Ordinal))
                {
                    continue;
                }

                var Source = Decompiler.GenerateSourceFile(Type, Namespace + ".Decompiled", MapAndroidApi);
                if (Source.Length == 0)
                {
                    continue;
                }

                var SubDir = Type.IsEnum || Type.IsRecord
                    ? Path.Combine(DecompiledDir, "Models")
                    : Type.IsInterface
                        ? Path.Combine(DecompiledDir, "Contracts")
                        : Path.Combine(DecompiledDir, "Types");
                Directory.CreateDirectory(SubDir);

                var FileName = Type.TypeName + ".cs";
                File.WriteAllText(Path.Combine(SubDir, FileName), Source);
                TypeCount++;
                MethodCount += Type.Methods.Count;

                Console.WriteLine(string.Format(
                    System.Globalization.CultureInfo.InvariantCulture,
                    "  Decompiled: {0} ({1} methods, {2} properties, {3} fields)",
                    Type.TypeName, Type.Methods.Count, Type.Properties.Count, Type.Fields.Count));
            }
        }

        Console.WriteLine(string.Format(
            System.Globalization.CultureInfo.InvariantCulture,
            "  Total decompiled: {0} types, {1} methods",
            TypeCount, MethodCount));
    }

    private static string MapAndroidApi(string Body)
    {
        return Body
            .Replace("Android.Nfc.NfcAdapter", "/* WSS: NfcAdapter */")
            .Replace("Android.Nfc.CardEmulators.", "/* WSS: CardEmulation */")
            .Replace("Android.Nfc.Tech.", "/* WSS: NfcTech */")
            .Replace("Android.Content.", "/* WSS: Android.Content */")
            .Replace("Android.App.", "/* WSS: Android.App */")
            .Replace("Platform.CurrentActivity", "/* WSS: Activity */")
            .Replace("MainThread.InvokeOnMainThreadAsync", "Task.Run");
    }
}
