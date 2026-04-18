using System.Text;
using PrTask.Domain.Constants;

namespace PrTask.Transpiler;

public sealed class BlazorProjectGenerator
{
    private readonly string OutputDir;
    private readonly string Namespace;
    private readonly string AppTitle;
    private readonly string SourcePath;

    public BlazorProjectGenerator(string OutputDir, string Namespace, string AppTitle, string SourcePath)
    {
        this.OutputDir = OutputDir;
        this.Namespace = Namespace;
        this.AppTitle = AppTitle;
        this.SourcePath = SourcePath;
    }

    public void Generate()
    {
        Directory.CreateDirectory(OutputDir);
        Directory.CreateDirectory(Path.Combine(OutputDir, AnthropicConstants.GeneratedWwwrootDirectory));
        Directory.CreateDirectory(Path.Combine(OutputDir, AnthropicConstants.GeneratedWwwrootDirectory, AnthropicConstants.GeneratedCssDirectory));
        Directory.CreateDirectory(Path.Combine(OutputDir, AnthropicConstants.GeneratedPagesDirectory));
        Directory.CreateDirectory(Path.Combine(OutputDir, AnthropicConstants.GeneratedLayoutDirectory));
        Directory.CreateDirectory(Path.Combine(OutputDir, AnthropicConstants.GeneratedServicesDirectory));
        Directory.CreateDirectory(Path.Combine(OutputDir, AnthropicConstants.GeneratedModelsDirectory));

        WriteCsproj();
        WriteProgram();
        WriteImports();
        WriteAppRazor();
        WriteMainLayout();
        WriteIndexPage();
        WriteIndexHtml();
        WriteCss();

        var ClientGenerator = new AnthropicClientGenerator(OutputDir, Namespace);
        ClientGenerator.Generate();
    }

    public void GenerateClaudeCodeProject()
    {
        var ClaudeOutputDir = Path.Combine(OutputDir, AnthropicConstants.GeneratedProjectName);
        var ClaudeNamespace = AnthropicConstants.GeneratedNamespace;
        var ClaudeTitle = AnthropicConstants.GeneratedAppTitle;

        Directory.CreateDirectory(ClaudeOutputDir);
        Directory.CreateDirectory(Path.Combine(ClaudeOutputDir, AnthropicConstants.GeneratedWwwrootDirectory));
        Directory.CreateDirectory(Path.Combine(ClaudeOutputDir, AnthropicConstants.GeneratedWwwrootDirectory, AnthropicConstants.GeneratedCssDirectory));
        Directory.CreateDirectory(Path.Combine(ClaudeOutputDir, AnthropicConstants.GeneratedPagesDirectory));
        Directory.CreateDirectory(Path.Combine(ClaudeOutputDir, AnthropicConstants.GeneratedLayoutDirectory));
        Directory.CreateDirectory(Path.Combine(ClaudeOutputDir, AnthropicConstants.GeneratedServicesDirectory));
        Directory.CreateDirectory(Path.Combine(ClaudeOutputDir, AnthropicConstants.GeneratedModelsDirectory));

        WriteClaudeCodeCsproj(ClaudeOutputDir, ClaudeNamespace);
        WriteClaudeCodeProgram(ClaudeOutputDir, ClaudeNamespace);
        WriteClaudeCodeImports(ClaudeOutputDir, ClaudeNamespace);
        WriteClaudeCodeAppRazor(ClaudeOutputDir, ClaudeNamespace);
        WriteClaudeCodeMainLayout(ClaudeOutputDir);
        WriteClaudeCodeIndexPage(ClaudeOutputDir, ClaudeNamespace);
        WriteClaudeCodeIndexHtml(ClaudeOutputDir, ClaudeTitle);
        WriteClaudeCodeCss(ClaudeOutputDir);
        WriteClaudeCodeFavicon(ClaudeOutputDir);

        var ClientGenerator = new AnthropicClientGenerator(ClaudeOutputDir, ClaudeNamespace);
        ClientGenerator.Generate();

        var ProxyOutputDir = Path.Combine(OutputDir, AnthropicConstants.ProxyProjectName);
        WriteProxyProject(ProxyOutputDir);
    }

    private void WriteCsproj()
    {
        var Sb = new StringBuilder();
        Sb.Append("<Project Sdk=\"").Append(AnthropicConstants.GeneratedProjectSdk).AppendLine("\">");
        Sb.AppendLine("  <PropertyGroup>");
        Sb.Append("    <TargetFramework>").Append(AnthropicConstants.GeneratedTargetFramework).AppendLine("</TargetFramework>");
        Sb.AppendLine("    <ImplicitUsings>enable</ImplicitUsings>");
        Sb.AppendLine("    <Nullable>enable</Nullable>");
        Sb.AppendLine("    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>");
        Sb.Append("    <NoWarn>").Append(AnthropicConstants.NoWarnList).AppendLine("</NoWarn>");
        Sb.AppendLine("    <EnableTrimAnalyzer>false</EnableTrimAnalyzer>");
        Sb.AppendLine("    <TrimMode>partial</TrimMode>");
        Sb.AppendLine("  </PropertyGroup>");
        Sb.AppendLine("  <ItemGroup>");
        Sb.Append("    <PackageReference Include=\"").Append(AnthropicConstants.GeneratedWasmPackageId).Append("\" Version=\"").Append(AnthropicConstants.GeneratedWasmPackageVersion).AppendLine("\" />");
        Sb.AppendLine("  </ItemGroup>");
        Sb.AppendLine("  <ItemGroup>");
        Sb.AppendLine("    <Compile Remove=\"..\\*.g.cs\" />");
        Sb.AppendLine("  </ItemGroup>");
        Sb.AppendLine("  <ItemGroup>");
        Sb.AppendLine("    <Compile Remove=\"..\\*.g.cs\" />");
        Sb.AppendLine("  </ItemGroup>");
        Sb.AppendLine("  <ItemGroup>");
        Sb.AppendLine("    <Compile Include=\"..\\*.g.cs\" Link=\"Generated\\%(Filename)%(Extension)\" />");
        Sb.AppendLine("  </ItemGroup>");
        Sb.AppendLine("</Project>");

        File.WriteAllText(Path.Combine(OutputDir, string.Concat(Namespace, AnthropicConstants.GeneratedCsprojExtension)), Sb.ToString());
    }

    private void WriteProgram()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("using Microsoft.AspNetCore.Components.WebAssembly.Hosting;");
        Sb.AppendLine();
        Sb.AppendLine("var Builder = WebAssemblyHostBuilder.CreateDefault(args);");
        Sb.Append("Builder.RootComponents.Add<").Append(Namespace).Append(".App>(\"").Append(AnthropicConstants.GeneratedRootSelector).AppendLine("\");");
        Sb.AppendLine("await Builder.Build().RunAsync();");

        File.WriteAllText(Path.Combine(OutputDir, AnthropicConstants.GeneratedProgramFileName), Sb.ToString());
    }

    private void WriteImports()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("@using Microsoft.AspNetCore.Components.Web");
        Sb.AppendLine("@using Microsoft.AspNetCore.Components.Routing");
        Sb.AppendLine("@using Microsoft.JSInterop");
        Sb.Append("@using ").AppendLine(Namespace);
        Sb.Append("@using ").Append(Namespace).Append('.').AppendLine(AnthropicConstants.GeneratedPagesDirectory);
        Sb.Append("@using ").Append(Namespace).Append('.').AppendLine(AnthropicConstants.GeneratedLayoutDirectory);
        Sb.Append("@using ").Append(Namespace).Append('.').AppendLine(AnthropicConstants.GeneratedServicesDirectory);
        Sb.Append("@using ").Append(Namespace).Append('.').AppendLine(AnthropicConstants.GeneratedModelsDirectory);

        File.WriteAllText(Path.Combine(OutputDir, AnthropicConstants.GeneratedImportsRazorFileName), Sb.ToString());
    }

    private void WriteAppRazor()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("<Router AppAssembly=\"typeof(Program).Assembly\">");
        Sb.AppendLine("    <Found Context=\"routeData\">");
        Sb.Append("        <RouteView RouteData=\"routeData\" DefaultLayout=\"typeof(").Append(AnthropicConstants.GeneratedLayoutDirectory).AppendLine(".MainLayout)\" />");
        Sb.AppendLine("    </Found>");
        Sb.AppendLine("    <NotFound>");
        Sb.Append("        <LayoutView Layout=\"typeof(").Append(AnthropicConstants.GeneratedLayoutDirectory).AppendLine(".MainLayout)\">");
        Sb.AppendLine("            <p>Not found</p>");
        Sb.AppendLine("        </LayoutView>");
        Sb.AppendLine("    </NotFound>");
        Sb.AppendLine("</Router>");

        File.WriteAllText(Path.Combine(OutputDir, AnthropicConstants.GeneratedAppRazorFileName), Sb.ToString());
    }

    private void WriteMainLayout()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("@inherits LayoutComponentBase");
        Sb.AppendLine();
        Sb.AppendLine("<div class=\"app-container\">");
        Sb.AppendLine("    @Body");
        Sb.AppendLine("</div>");

        File.WriteAllText(Path.Combine(OutputDir, AnthropicConstants.GeneratedLayoutDirectory, AnthropicConstants.GeneratedMainLayoutFileName), Sb.ToString());
    }

    private void WriteIndexPage()
    {
        var ExeFiles = Directory.Exists(SourcePath) ? Directory.GetFiles(SourcePath, "*.exe") : [];
        var LargestExe = string.Empty;
        var LargestSize = 0L;
        foreach (var F in ExeFiles)
        {
            var Size = new FileInfo(F).Length;
            if (Size > LargestSize)
            {
                LargestSize = Size;
                LargestExe = Path.GetFileNameWithoutExtension(F);
            }
        }

        var ClassName = LargestExe.Length > 0 ? ToPascalCase(LargestExe) : string.Empty;

        var Sb = new StringBuilder();
        Sb.AppendLine("@page \"/\"");
        Sb.AppendLine();
        Sb.Append("<h1>").Append(AppTitle).AppendLine("</h1>");
        Sb.AppendLine();
        Sb.AppendLine("<div class=\"studio-viewport\">");
        Sb.AppendLine("    <div class=\"studio-status\">@Status</div>");
        Sb.AppendLine("    <div class=\"studio-output\">");
        Sb.AppendLine("        <pre>@Output</pre>");
        Sb.AppendLine("    </div>");
        Sb.AppendLine("</div>");
        Sb.AppendLine();
        Sb.AppendLine("<div class=\"studio-controls\">");
        Sb.AppendLine("    <button class=\"btn\" @onclick=\"RunEntry\">Run</button>");
        Sb.AppendLine("</div>");
        Sb.AppendLine();
        Sb.AppendLine("@code {");
        Sb.AppendLine("    private string Status = \"Ready\";");
        Sb.AppendLine("    private string Output = string.Empty;");
        Sb.AppendLine();
        Sb.AppendLine("    private void RunEntry()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        Status = \"Running...\";");
        Sb.AppendLine("        try");
        Sb.AppendLine("        {");
        if (ClassName.Length > 0)
        {
            Sb.Append("            ").Append(Namespace).Append('.').Append(ClassName).AppendLine(".Entry();");
        }

        Sb.AppendLine("            Status = \"Completed\";");
        Sb.AppendLine("            Output = \"Entry point executed successfully in browser via WASM\";");
        Sb.AppendLine("        }");
        Sb.AppendLine("        catch (System.Exception Ex)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            Status = \"Error\";");
        Sb.AppendLine("            Output = Ex.Message;");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine("}");

        File.WriteAllText(Path.Combine(OutputDir, AnthropicConstants.GeneratedPagesDirectory, AnthropicConstants.GeneratedIndexRazorFileName), Sb.ToString());
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
        Sb.AppendLine("    <base href=\"/\" />");
        Sb.Append("    <link rel=\"stylesheet\" href=\"").Append(AnthropicConstants.GeneratedCssDirectory).Append('/').Append(AnthropicConstants.GeneratedCssFileName).AppendLine("\" />");
        Sb.AppendLine("</head>");
        Sb.AppendLine("<body>");
        Sb.Append("    <div id=\"app\">Loading WASM...</div>");
        Sb.AppendLine();
        Sb.AppendLine("    <script src=\"_framework/blazor.webassembly.js\"></script>");
        Sb.AppendLine("</body>");
        Sb.AppendLine("</html>");

        File.WriteAllText(Path.Combine(OutputDir, AnthropicConstants.GeneratedWwwrootDirectory, AnthropicConstants.GeneratedIndexHtmlFileName), Sb.ToString());
    }

    private void WriteCss()
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("html, body { margin: 0; padding: 0; background: #0f172a; color: #e2e8f0; font-family: system-ui, sans-serif; }");
        Sb.AppendLine(".app-container { display: flex; flex-direction: column; align-items: center; padding: 2rem; min-height: 100vh; }");
        Sb.AppendLine("h1 { color: #22d3ee; margin-bottom: 1.5rem; font-size: 2rem; }");
        Sb.AppendLine(".studio-viewport { width: 100%; max-width: 1200px; border: 2px solid #334155; border-radius: 8px; padding: 1rem; background: #1e293b; }");
        Sb.AppendLine(".studio-status { color: #22d3ee; font-weight: 600; margin-bottom: 1rem; font-size: 1.1rem; }");
        Sb.AppendLine(".studio-registers pre, .studio-output pre { background: #0f172a; padding: 1rem; border-radius: 4px; font-size: 0.85rem; overflow-x: auto; color: #94a3b8; white-space: pre-wrap; word-break: break-all; }");
        Sb.AppendLine(".studio-controls { margin-top: 1.5rem; }");
        Sb.AppendLine(".btn { background: #22d3ee; color: #0f172a; border: none; padding: 0.75rem 2rem; border-radius: 6px; cursor: pointer; font-weight: 700; font-size: 1rem; }");
        Sb.AppendLine(".btn:hover { background: #06b6d4; }");
        Sb.AppendLine(".chat-container { width: 100%; max-width: 1200px; display: flex; flex-direction: column; gap: 1rem; }");
        Sb.AppendLine(".chat-messages { flex: 1; overflow-y: auto; max-height: 60vh; padding: 1rem; background: #1e293b; border-radius: 8px; border: 1px solid #334155; }");
        Sb.AppendLine(".chat-message { padding: 0.75rem; margin-bottom: 0.5rem; border-radius: 6px; }");
        Sb.AppendLine(".chat-message.user { background: #1e3a5f; text-align: right; }");
        Sb.AppendLine(".chat-message.assistant { background: #1e293b; border: 1px solid #334155; }");
        Sb.AppendLine(".chat-message.tool { background: #1a2332; border-left: 3px solid #22d3ee; font-family: monospace; font-size: 0.85rem; }");
        Sb.AppendLine(".chat-input { display: flex; gap: 0.5rem; }");
        Sb.AppendLine(".chat-input textarea { flex: 1; background: #1e293b; color: #e2e8f0; border: 1px solid #334155; border-radius: 6px; padding: 0.75rem; font-family: system-ui, sans-serif; font-size: 0.95rem; resize: none; }");
        Sb.AppendLine(".api-key-input { background: #1e293b; color: #e2e8f0; border: 1px solid #334155; border-radius: 6px; padding: 0.75rem; width: 100%; max-width: 400px; font-family: monospace; }");
        Sb.AppendLine(".streaming-indicator { color: #22d3ee; font-style: italic; }");

        File.WriteAllText(Path.Combine(OutputDir, AnthropicConstants.GeneratedWwwrootDirectory, AnthropicConstants.GeneratedCssDirectory, AnthropicConstants.GeneratedCssFileName), Sb.ToString());
    }

    private static void WriteClaudeCodeCsproj(string Dir, string Ns)
    {
        var Sb = new StringBuilder();
        Sb.Append("<Project Sdk=\"").Append(AnthropicConstants.GeneratedProjectSdk).AppendLine("\">");
        Sb.AppendLine("  <PropertyGroup>");
        Sb.Append("    <TargetFramework>").Append(AnthropicConstants.GeneratedTargetFramework).AppendLine("</TargetFramework>");
        Sb.AppendLine("    <ImplicitUsings>enable</ImplicitUsings>");
        Sb.AppendLine("    <Nullable>enable</Nullable>");
        Sb.Append("    <NoWarn>").Append(AnthropicConstants.NoWarnList).AppendLine("</NoWarn>");
        Sb.AppendLine("    <EnableTrimAnalyzer>false</EnableTrimAnalyzer>");
        Sb.AppendLine("    <TrimMode>partial</TrimMode>");
        Sb.Append("    <").Append(AnthropicConstants.GeneratedDebugTypeProperty).Append('>').Append(AnthropicConstants.GeneratedDebugTypeValue).Append("</").Append(AnthropicConstants.GeneratedDebugTypeProperty).AppendLine(">");
        Sb.Append("    <").Append(AnthropicConstants.GeneratedDebugSymbolsProperty).Append('>').Append(AnthropicConstants.GeneratedDebugSymbolsValue).Append("</").Append(AnthropicConstants.GeneratedDebugSymbolsProperty).AppendLine(">");
        Sb.Append("    <").Append(AnthropicConstants.GeneratedFingerprintProperty).Append('>').Append(AnthropicConstants.GeneratedFingerprintValue).Append("</").Append(AnthropicConstants.GeneratedFingerprintProperty).AppendLine(">");
        Sb.AppendLine("  </PropertyGroup>");
        Sb.AppendLine("  <ItemGroup>");
        Sb.Append("    <PackageReference Include=\"").Append(AnthropicConstants.GeneratedWasmPackageId).Append("\" Version=\"").Append(AnthropicConstants.GeneratedWasmPackageVersion).AppendLine("\" />");
        Sb.Append("    <PackageReference Include=\"").Append(AnthropicConstants.GeneratedDevServerPackageId).Append("\" Version=\"").Append(AnthropicConstants.GeneratedDevServerPackageVersion).AppendLine("\" PrivateAssets=\"all\" />");
        Sb.AppendLine("  </ItemGroup>");
        Sb.AppendLine("</Project>");

        File.WriteAllText(Path.Combine(Dir, string.Concat(Ns, AnthropicConstants.GeneratedCsprojExtension)), Sb.ToString());
    }

    private static void WriteClaudeCodeProgram(string Dir, string Ns)
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("using System.Text.Json;");
        Sb.AppendLine("using Microsoft.AspNetCore.Components.WebAssembly.Hosting;");
        Sb.Append("using ").Append(Ns).Append('.').Append(AnthropicConstants.GeneratedServicesDirectory).AppendLine(";");
        Sb.AppendLine();
        Sb.AppendLine("var Builder = WebAssemblyHostBuilder.CreateDefault(args);");
        Sb.Append("Builder.RootComponents.Add<").Append(Ns).Append(".App>(\"").Append(AnthropicConstants.GeneratedRootSelector).AppendLine("\");");
        Sb.AppendLine("Builder.Services.AddScoped(Sp => new HttpClient { BaseAddress = new Uri(Builder.HostEnvironment.BaseAddress) });");
        Sb.AppendLine("await Builder.Build().RunAsync();");

        File.WriteAllText(Path.Combine(Dir, AnthropicConstants.GeneratedProgramFileName), Sb.ToString());
    }

    private static void WriteClaudeCodeImports(string Dir, string Ns)
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("@using Microsoft.AspNetCore.Components.Web");
        Sb.AppendLine("@using Microsoft.AspNetCore.Components.Routing");
        Sb.AppendLine("@using Microsoft.JSInterop");
        Sb.Append("@using ").AppendLine(Ns);
        Sb.Append("@using ").Append(Ns).Append('.').AppendLine(AnthropicConstants.GeneratedPagesDirectory);
        Sb.Append("@using ").Append(Ns).Append('.').AppendLine(AnthropicConstants.GeneratedLayoutDirectory);
        Sb.Append("@using ").Append(Ns).Append('.').AppendLine(AnthropicConstants.GeneratedServicesDirectory);
        Sb.Append("@using ").Append(Ns).Append('.').AppendLine(AnthropicConstants.GeneratedModelsDirectory);

        File.WriteAllText(Path.Combine(Dir, AnthropicConstants.GeneratedImportsRazorFileName), Sb.ToString());
    }

    private static void WriteClaudeCodeAppRazor(string Dir, string Ns)
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("<Router AppAssembly=\"typeof(Program).Assembly\">");
        Sb.AppendLine("    <Found Context=\"routeData\">");
        Sb.Append("        <RouteView RouteData=\"routeData\" DefaultLayout=\"typeof(").Append(AnthropicConstants.GeneratedLayoutDirectory).AppendLine(".MainLayout)\" />");
        Sb.AppendLine("    </Found>");
        Sb.AppendLine("    <NotFound>");
        Sb.Append("        <LayoutView Layout=\"typeof(").Append(AnthropicConstants.GeneratedLayoutDirectory).AppendLine(".MainLayout)\">");
        Sb.AppendLine("            <p>Not found</p>");
        Sb.AppendLine("        </LayoutView>");
        Sb.AppendLine("    </NotFound>");
        Sb.AppendLine("</Router>");

        File.WriteAllText(Path.Combine(Dir, AnthropicConstants.GeneratedAppRazorFileName), Sb.ToString());
    }

    private static void WriteClaudeCodeMainLayout(string Dir)
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("@inherits LayoutComponentBase");
        Sb.AppendLine();
        Sb.AppendLine("<div class=\"app-container\">");
        Sb.AppendLine("    @Body");
        Sb.AppendLine("</div>");

        File.WriteAllText(Path.Combine(Dir, AnthropicConstants.GeneratedLayoutDirectory, AnthropicConstants.GeneratedMainLayoutFileName), Sb.ToString());
    }

    private static void WriteClaudeCodeIndexPage(string Dir, string Ns)
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("@page \"/\"");
        Sb.AppendLine("@inject IJSRuntime JsRuntime");
        Sb.AppendLine("@using System.Net.WebSockets");
        Sb.AppendLine("@using System.Text");
        Sb.AppendLine("@using System.Text.Json");
        Sb.AppendLine();
        Sb.Append("<h1>").Append(AnthropicConstants.GeneratedAppTitle).AppendLine("</h1>");
        Sb.AppendLine();
        Sb.AppendLine("@if (!IsConnected)");
        Sb.AppendLine("{");
        Sb.AppendLine("    <div class=\"chat-container\">");
        Sb.AppendLine("        <div class=\"streaming-indicator\">@StatusMessage</div>");
        Sb.AppendLine();
        Sb.AppendLine("        <div class=\"auth-options\">");
        Sb.Append("            <p>").Append(AnthropicConstants.ProxyStartInstruction).AppendLine("</p>");
        Sb.AppendLine("            <div class=\"proxy-input\">");
        Sb.AppendLine("                <label>Proxy URL:</label>");
        Sb.Append("                <input class=\"api-key-input\" @bind=\"ProxyUrlInput\" placeholder=\"").Append(AnthropicConstants.ProxyLocalhost).Append(":").Append(AnthropicConstants.ProxyPortRangeStart).AppendLine("\" />");
        Sb.AppendLine("                <button class=\"btn\" @onclick=\"ConnectToProxy\">Connect</button>");
        Sb.AppendLine("            </div>");
        Sb.AppendLine("            <button class=\"btn\" @onclick=\"AutoDiscoverProxy\">Auto-Discover</button>");
        Sb.AppendLine("        </div>");
        Sb.AppendLine("    </div>");
        Sb.AppendLine("}");
        Sb.AppendLine("else");
        Sb.AppendLine("{");
        Sb.AppendLine("    <div class=\"chat-container\">");
        Sb.AppendLine("        <div class=\"chat-messages\">");
        Sb.AppendLine("            @foreach (var Msg in DisplayMessages)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                <div class=\"chat-message @Msg.CssClass\">");
        Sb.AppendLine("                    <pre>@Msg.Text</pre>");
        Sb.AppendLine("                </div>");
        Sb.AppendLine("            }");
        Sb.AppendLine("            @if (IsStreaming)");
        Sb.AppendLine("            {");
        Sb.AppendLine("                <div class=\"streaming-indicator\">Thinking...</div>");
        Sb.AppendLine("            }");
        Sb.AppendLine("        </div>");
        Sb.AppendLine("        <div class=\"chat-input\">");
        Sb.AppendLine("            <textarea rows=\"3\" @bind=\"UserInput\" @onkeydown=\"HandleKeyDown\" disabled=\"@IsStreaming\"></textarea>");
        Sb.AppendLine("            <button class=\"btn\" @onclick=\"SendMessage\" disabled=\"@IsStreaming\">Send</button>");
        Sb.AppendLine("        </div>");
        Sb.AppendLine("    </div>");
        Sb.AppendLine("}");
        Sb.AppendLine();
        Sb.AppendLine("@code {");
        Sb.AppendLine("    private bool IsConnected;");
        Sb.Append("    private string StatusMessage = \"").Append(AnthropicConstants.ProxyAutoDiscoverMessage).AppendLine("\";");
        Sb.AppendLine("    private string ProxyUrlInput = string.Empty;");
        Sb.AppendLine("    private string UserInput = string.Empty;");
        Sb.AppendLine("    private bool IsStreaming;");
        Sb.AppendLine("    private string ProxyBaseUrl = string.Empty;");
        Sb.AppendLine("    private readonly List<DisplayMessage> DisplayMessages = new();");
        Sb.AppendLine("    private ClientWebSocket? WsClient;");
        Sb.AppendLine("    private ToolDispatcher? Dispatcher;");
        Sb.AppendLine("    private readonly List<ApiMessage> ConversationHistory = new();");
        Sb.AppendLine();
        Sb.AppendLine("    private sealed class DisplayMessage");
        Sb.AppendLine("    {");
        Sb.AppendLine("        internal required string Text { get; init; }");
        Sb.AppendLine("        internal required string CssClass { get; init; }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    protected override async Task OnAfterRenderAsync(bool FirstRender)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        if (!FirstRender)");
        Sb.AppendLine("            return;");
        Sb.AppendLine();
        Sb.AppendLine("        try");
        Sb.AppendLine("        {");
        Sb.Append("            var Saved = await JsRuntime.InvokeAsync<string?>(\"localStorage.getItem\", \"").Append(AnthropicConstants.ProxyUrlLocalStorageKey).AppendLine("\");");
        Sb.AppendLine("            if (!string.IsNullOrEmpty(Saved))");
        Sb.AppendLine("            {");
        Sb.AppendLine("                ProxyUrlInput = Saved;");
        Sb.AppendLine("                if (await TryConnectProxy(Saved))");
        Sb.AppendLine("                    return;");
        Sb.AppendLine("            }");
        Sb.AppendLine();
        Sb.AppendLine("            await AutoDiscoverProxy();");
        Sb.AppendLine("        }");
        Sb.AppendLine("        catch (Exception Ex)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            StatusMessage = string.Concat(\"Error: \", Ex.Message);");
        Sb.AppendLine("            StateHasChanged();");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private async Task<bool> TryConnectProxy(string Url)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        try");
        Sb.AppendLine("        {");
        Sb.AppendLine("            using var Probe = new HttpClient();");
        Sb.AppendLine("            Probe.Timeout = TimeSpan.FromSeconds(2);");
        Sb.Append("            var R = await Probe.GetAsync(string.Concat(Url, \"").Append(AnthropicConstants.ProxyMessagesRoute).AppendLine("\"));");
        Sb.AppendLine();
        Sb.AppendLine("            var WsUrl = Url.Replace(\"http://\", \"ws://\").Replace(\"https://\", \"wss://\");");
        Sb.Append("            WsUrl = string.Concat(WsUrl, \"").Append(AnthropicConstants.ProxyWssRoute).AppendLine("\");");
        Sb.AppendLine("            WsClient = new ClientWebSocket();");
        Sb.AppendLine("            await WsClient.ConnectAsync(new Uri(WsUrl), CancellationToken.None);");
        Sb.AppendLine();
        Sb.AppendLine("            ProxyBaseUrl = Url;");
        Sb.AppendLine("            Dispatcher = new ToolDispatcher();");
        Sb.AppendLine("            IsConnected = true;");
        Sb.Append("            StatusMessage = string.Format(System.Globalization.CultureInfo.InvariantCulture, \"").Append(AnthropicConstants.ProxyConnectedFormat).AppendLine("\", Url);");
        Sb.Append("            await JsRuntime.InvokeVoidAsync(\"localStorage.setItem\", \"").Append(AnthropicConstants.ProxyUrlLocalStorageKey).AppendLine("\", Url);");
        Sb.AppendLine("            StateHasChanged();");
        Sb.AppendLine("            return true;");
        Sb.AppendLine("        }");
        Sb.AppendLine("        catch");
        Sb.AppendLine("        {");
        Sb.AppendLine("            return false;");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private async Task ConnectToProxy()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        if (ProxyUrlInput.Length == 0)");
        Sb.AppendLine("            return;");
        Sb.AppendLine();
        Sb.AppendLine("        var Url = ProxyUrlInput.TrimEnd('/');");
        Sb.AppendLine("        StatusMessage = string.Concat(\"Connecting to \", Url, \"...\");");
        Sb.AppendLine("        StateHasChanged();");
        Sb.AppendLine();
        Sb.AppendLine("        if (!await TryConnectProxy(Url))");
        Sb.AppendLine("        {");
        Sb.AppendLine("            StatusMessage = string.Concat(\"Failed to connect to \", Url);");
        Sb.AppendLine("            StateHasChanged();");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private async Task AutoDiscoverProxy()");
        Sb.AppendLine("    {");
        Sb.Append("        StatusMessage = \"").Append(AnthropicConstants.ProxyAutoDiscoverMessage).AppendLine("\";");
        Sb.AppendLine("        StateHasChanged();");
        Sb.AppendLine();
        Sb.Append("        for (var Port = ").Append(AnthropicConstants.ProxyPortRangeStart).Append("; Port <= ").Append(AnthropicConstants.ProxyPortRangeEnd).AppendLine("; Port++)");
        Sb.AppendLine("        {");
        Sb.Append("            var Url = string.Concat(\"").Append(AnthropicConstants.ProxyLocalhost).AppendLine(":\", Port.ToString(System.Globalization.CultureInfo.InvariantCulture));");
        Sb.AppendLine("            if (await TryConnectProxy(Url))");
        Sb.AppendLine("                return;");
        Sb.AppendLine("        }");
        Sb.AppendLine();
        Sb.Append("        StatusMessage = \"").Append(AnthropicConstants.ProxyNotFoundMessage).AppendLine("\";");
        Sb.AppendLine("        StateHasChanged();");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private async Task HandleKeyDown(Microsoft.AspNetCore.Components.Web.KeyboardEventArgs E)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        if (string.Equals(E.Key, \"Enter\", StringComparison.Ordinal) && !E.ShiftKey)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            await SendMessage();");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private async Task<string> WsSendAndReceiveAsync(string RequestJson)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        if (WsClient is null || WsClient.State != WebSocketState.Open)");
        Sb.AppendLine("            throw new InvalidOperationException(\"WebSocket not connected\");");
        Sb.AppendLine();
        Sb.AppendLine("        var Bytes = Encoding.UTF8.GetBytes(RequestJson);");
        Sb.AppendLine("        await WsClient.SendAsync(new ArraySegment<byte>(Bytes), WebSocketMessageType.Text, true, CancellationToken.None);");
        Sb.AppendLine();
        Sb.AppendLine("        var ResponseBuffer = new byte[65536];");
        Sb.AppendLine("        var ResponseBuilder = new StringBuilder();");
        Sb.AppendLine();
        Sb.AppendLine("        while (true)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var Result = await WsClient.ReceiveAsync(new ArraySegment<byte>(ResponseBuffer), CancellationToken.None);");
        Sb.AppendLine("            var Chunk = Encoding.UTF8.GetString(ResponseBuffer, 0, Result.Count);");
        Sb.AppendLine("            var MsgDoc = JsonDocument.Parse(Chunk);");
        Sb.Append("            var MsgType = MsgDoc.RootElement.GetProperty(\"").Append(AnthropicConstants.WssJsonPropertyType).AppendLine("\").GetString();");
        Sb.AppendLine();
        Sb.Append("            if (string.Equals(MsgType, \"").Append(AnthropicConstants.WssMessageTypeResponse).AppendLine("\", StringComparison.Ordinal))");
        Sb.AppendLine("            {");
        Sb.Append("                var StatusCode = MsgDoc.RootElement.GetProperty(\"").Append(AnthropicConstants.WssJsonPropertyStatusCode).AppendLine("\").GetInt32();");
        Sb.Append("                var Data = MsgDoc.RootElement.GetProperty(\"").Append(AnthropicConstants.WssJsonPropertyData).AppendLine("\").GetString() ?? string.Empty;");
        Sb.AppendLine("                if (StatusCode >= 400)");
        Sb.AppendLine("                    throw new HttpRequestException(Data);");
        Sb.AppendLine("                return Data;");
        Sb.AppendLine("            }");
        Sb.Append("            else if (string.Equals(MsgType, \"").Append(AnthropicConstants.WssMessageTypeSseEvent).AppendLine("\", StringComparison.Ordinal))");
        Sb.AppendLine("            {");
        Sb.Append("                var Line = MsgDoc.RootElement.GetProperty(\"").Append(AnthropicConstants.WssJsonPropertyData).AppendLine("\").GetString() ?? string.Empty;");
        Sb.AppendLine("                ResponseBuilder.AppendLine(Line);");
        Sb.AppendLine();
        Sb.Append("                if (Line.StartsWith(\"").Append(AnthropicConstants.SseDataPrefix).AppendLine("\"))");
        Sb.AppendLine("                {");
        Sb.Append("                    var SseData = Line.Substring(").Append(AnthropicConstants.SseDataPrefix.Length).AppendLine(");");
        Sb.AppendLine("                    try");
        Sb.AppendLine("                    {");
        Sb.AppendLine("                        var SseDoc = JsonDocument.Parse(SseData);");
        Sb.Append("                        if (SseDoc.RootElement.TryGetProperty(\"").Append(AnthropicConstants.JsonPropertyDelta).AppendLine("\", out var DeltaEl))");
        Sb.AppendLine("                        {");
        Sb.Append("                            if (DeltaEl.TryGetProperty(\"").Append(AnthropicConstants.JsonPropertyText).AppendLine("\", out var TextEl))");
        Sb.AppendLine("                            {");
        Sb.AppendLine("                                var StreamText = TextEl.GetString();");
        Sb.AppendLine("                                if (StreamText is not null)");
        Sb.AppendLine("                                {");
        Sb.AppendLine("                                    if (DisplayMessages.Count > 0 && string.Equals(DisplayMessages[^1].CssClass, \"assistant\", StringComparison.Ordinal))");
        Sb.AppendLine("                                    {");
        Sb.AppendLine("                                        DisplayMessages[^1] = new DisplayMessage { Text = string.Concat(DisplayMessages[^1].Text, StreamText), CssClass = \"assistant\" };");
        Sb.AppendLine("                                    }");
        Sb.AppendLine("                                    else");
        Sb.AppendLine("                                    {");
        Sb.AppendLine("                                        DisplayMessages.Add(new DisplayMessage { Text = StreamText, CssClass = \"assistant\" });");
        Sb.AppendLine("                                    }");
        Sb.AppendLine("                                    StateHasChanged();");
        Sb.AppendLine("                                }");
        Sb.AppendLine("                            }");
        Sb.AppendLine("                        }");
        Sb.AppendLine("                    }");
        Sb.AppendLine("                    catch { }");
        Sb.AppendLine("                }");
        Sb.AppendLine("            }");
        Sb.Append("            else if (string.Equals(MsgType, \"").Append(AnthropicConstants.WssMessageTypeSseDone).AppendLine("\", StringComparison.Ordinal))");
        Sb.AppendLine("            {");
        Sb.AppendLine("                return ResponseBuilder.ToString();");
        Sb.AppendLine("            }");
        Sb.Append("            else if (string.Equals(MsgType, \"").Append(AnthropicConstants.WssMessageTypeError).AppendLine("\", StringComparison.Ordinal))");
        Sb.AppendLine("            {");
        Sb.Append("                var ErrMsg = MsgDoc.RootElement.TryGetProperty(\"").Append(AnthropicConstants.WssJsonPropertyMessage).AppendLine("\", out var MsgEl) ? MsgEl.GetString() ?? \"Unknown error\" : \"Unknown error\";");
        Sb.AppendLine("                throw new HttpRequestException(ErrMsg);");
        Sb.AppendLine("            }");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    private async Task SendMessage()");
        Sb.AppendLine("    {");
        Sb.AppendLine("        if (UserInput.Length == 0 || WsClient is null || Dispatcher is null)");
        Sb.AppendLine("            return;");
        Sb.AppendLine();
        Sb.AppendLine("        var MessageText = UserInput;");
        Sb.AppendLine("        UserInput = string.Empty;");
        Sb.AppendLine("        DisplayMessages.Add(new DisplayMessage { Text = MessageText, CssClass = \"user\" });");
        Sb.AppendLine();
        Sb.AppendLine("        ConversationHistory.Add(new ApiMessage");
        Sb.AppendLine("        {");
        Sb.Append("            Role = \"").Append(AnthropicConstants.RoleUser).AppendLine("\",");
        Sb.Append("            Content = [new ApiContentBlock { Type = \"").Append(AnthropicConstants.ContentTypeText).AppendLine("\", Text = MessageText }],");
        Sb.AppendLine("        });");
        Sb.AppendLine();
        Sb.AppendLine("        IsStreaming = true;");
        Sb.AppendLine("        StateHasChanged();");
        Sb.AppendLine();
        Sb.AppendLine("        try");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var JsonOptions = new JsonSerializerOptions");
        Sb.AppendLine("            {");
        Sb.AppendLine("                PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,");
        Sb.AppendLine("                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,");
        Sb.AppendLine("            };");
        Sb.AppendLine();
        Sb.AppendLine("            var Request = new ApiRequest");
        Sb.AppendLine("            {");
        Sb.Append("                Model = \"").Append(AnthropicConstants.DefaultModel).AppendLine("\",");
        Sb.Append("                MaxTokens = ").Append(AnthropicConstants.DefaultMaxTokens).AppendLine(",");
        Sb.AppendLine("                Messages = ConversationHistory,");
        Sb.AppendLine("                Stream = true,");
        Sb.AppendLine("            };");
        Sb.AppendLine();
        Sb.AppendLine("            var RequestJson = JsonSerializer.Serialize(Request, JsonOptions);");
        Sb.AppendLine("            var RawResponse = await WsSendAndReceiveAsync(RequestJson);");
        Sb.AppendLine();
        Sb.AppendLine("            var AssistantBlocks = new List<ApiContentBlock>();");
        Sb.AppendLine("            var FullText = new StringBuilder();");
        Sb.AppendLine();
        Sb.AppendLine("            foreach (var Line in RawResponse.Split('\\n', StringSplitOptions.RemoveEmptyEntries))");
        Sb.AppendLine("            {");
        Sb.Append("                if (!Line.StartsWith(\"").Append(AnthropicConstants.SseDataPrefix).AppendLine("\"))");
        Sb.AppendLine("                    continue;");
        Sb.Append("                var Data = Line.Substring(").Append(AnthropicConstants.SseDataPrefix.Length).AppendLine(");");
        Sb.AppendLine("                try");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    var Doc = JsonDocument.Parse(Data);");
        Sb.Append("                    if (Doc.RootElement.TryGetProperty(\"").Append(AnthropicConstants.JsonPropertyDelta).AppendLine("\", out var Delta))");
        Sb.AppendLine("                    {");
        Sb.Append("                        if (Delta.TryGetProperty(\"").Append(AnthropicConstants.JsonPropertyText).AppendLine("\", out var TextProp))");
        Sb.AppendLine("                            FullText.Append(TextProp.GetString());");
        Sb.AppendLine("                    }");
        Sb.Append("                    if (Doc.RootElement.TryGetProperty(\"").Append(AnthropicConstants.JsonPropertyMessage).AppendLine("\", out var MsgEl))");
        Sb.AppendLine("                    {");
        Sb.Append("                        if (MsgEl.TryGetProperty(\"").Append(AnthropicConstants.JsonPropertyContent).AppendLine("\", out var ContentEl))");
        Sb.AppendLine("                        {");
        Sb.AppendLine("                            foreach (var Block in ContentEl.EnumerateArray())");
        Sb.AppendLine("                            {");
        Sb.Append("                                var BlockType = Block.GetProperty(\"").Append(AnthropicConstants.JsonPropertyType).AppendLine("\").GetString();");
        Sb.Append("                                if (string.Equals(BlockType, \"").Append(AnthropicConstants.ContentTypeText).AppendLine("\", StringComparison.Ordinal))");
        Sb.AppendLine("                                {");
        Sb.Append("                                    AssistantBlocks.Add(new ApiContentBlock { Type = \"").Append(AnthropicConstants.ContentTypeText).AppendLine("\", Text = string.Empty });");
        Sb.AppendLine("                                }");
        Sb.AppendLine("                            }");
        Sb.AppendLine("                        }");
        Sb.AppendLine("                    }");
        Sb.AppendLine("                }");
        Sb.AppendLine("                catch { }");
        Sb.AppendLine("            }");
        Sb.AppendLine();
        Sb.AppendLine("            if (FullText.Length > 0)");
        Sb.AppendLine("            {");
        Sb.Append("                AssistantBlocks.Add(new ApiContentBlock { Type = \"").Append(AnthropicConstants.ContentTypeText).AppendLine("\", Text = FullText.ToString() });");
        Sb.AppendLine("            }");
        Sb.AppendLine();
        Sb.AppendLine("            if (AssistantBlocks.Count == 0)");
        Sb.AppendLine("            {");
        Sb.Append("                AssistantBlocks.Add(new ApiContentBlock { Type = \"").Append(AnthropicConstants.ContentTypeText).AppendLine("\", Text = string.Empty });");
        Sb.AppendLine("            }");
        Sb.AppendLine();
        Sb.AppendLine("            ConversationHistory.Add(new ApiMessage");
        Sb.AppendLine("            {");
        Sb.Append("                Role = \"").Append(AnthropicConstants.RoleAssistant).AppendLine("\",");
        Sb.AppendLine("                Content = AssistantBlocks,");
        Sb.AppendLine("            });");
        Sb.AppendLine("        }");
        Sb.AppendLine("        catch (Exception Ex)");
        Sb.AppendLine("        {");
        Sb.AppendLine("            DisplayMessages.Add(new DisplayMessage { Text = Ex.Message, CssClass = \"tool\" });");
        Sb.AppendLine("        }");
        Sb.AppendLine("        finally");
        Sb.AppendLine("        {");
        Sb.AppendLine("            IsStreaming = false;");
        Sb.AppendLine("            StateHasChanged();");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine("}");

        File.WriteAllText(Path.Combine(Dir, AnthropicConstants.GeneratedPagesDirectory, AnthropicConstants.GeneratedIndexRazorFileName), Sb.ToString());
    }

    private static void WriteClaudeCodeIndexHtml(string Dir, string Title)
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("<!DOCTYPE html>");
        Sb.AppendLine("<html lang=\"en\">");
        Sb.AppendLine("<head>");
        Sb.AppendLine("    <meta charset=\"utf-8\" />");
        Sb.AppendLine("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />");
        Sb.Append("    <title>").Append(Title).AppendLine("</title>");
        Sb.AppendLine("    <base href=\"/\" />");
        Sb.AppendLine(AnthropicConstants.GeneratedFaviconLinkTag);
        Sb.Append("    <link rel=\"stylesheet\" href=\"").Append(AnthropicConstants.GeneratedCssDirectory).Append('/').Append(AnthropicConstants.GeneratedCssFileName).AppendLine("\" />");
        Sb.AppendLine("</head>");
        Sb.AppendLine("<body>");
        Sb.Append("    <div id=\"app\">Loading ").Append(Title).AppendLine("...</div>");
        Sb.AppendLine("    <script src=\"_framework/blazor.webassembly.js\"></script>");
        Sb.AppendLine("</body>");
        Sb.AppendLine("</html>");

        File.WriteAllText(Path.Combine(Dir, AnthropicConstants.GeneratedWwwrootDirectory, AnthropicConstants.GeneratedIndexHtmlFileName), Sb.ToString());
    }

    private static void WriteClaudeCodeCss(string Dir)
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("html, body { margin: 0; padding: 0; background: #0f172a; color: #e2e8f0; font-family: system-ui, sans-serif; }");
        Sb.AppendLine(".app-container { display: flex; flex-direction: column; align-items: center; padding: 2rem; min-height: 100vh; }");
        Sb.AppendLine("h1 { color: #22d3ee; margin-bottom: 1.5rem; font-size: 2rem; }");
        Sb.AppendLine(".chat-container { width: 100%; max-width: 800px; display: flex; flex-direction: column; gap: 1rem; }");
        Sb.AppendLine(".chat-messages { flex: 1; overflow-y: auto; max-height: 65vh; padding: 1rem; background: #1e293b; border-radius: 8px; border: 1px solid #334155; }");
        Sb.AppendLine(".chat-message { padding: 0.75rem; margin-bottom: 0.5rem; border-radius: 6px; }");
        Sb.AppendLine(".chat-message pre { margin: 0; white-space: pre-wrap; word-break: break-word; }");
        Sb.AppendLine(".chat-message.user { background: #1e3a5f; text-align: right; }");
        Sb.AppendLine(".chat-message.assistant { background: #1e293b; border: 1px solid #334155; }");
        Sb.AppendLine(".chat-message.tool { background: #1a2332; border-left: 3px solid #22d3ee; font-family: monospace; font-size: 0.85rem; }");
        Sb.AppendLine(".chat-input { display: flex; gap: 0.5rem; }");
        Sb.AppendLine(".chat-input textarea { flex: 1; background: #1e293b; color: #e2e8f0; border: 1px solid #334155; border-radius: 6px; padding: 0.75rem; font-family: system-ui, sans-serif; font-size: 0.95rem; resize: none; }");
        Sb.AppendLine(".btn { background: #22d3ee; color: #0f172a; border: none; padding: 0.75rem 2rem; border-radius: 6px; cursor: pointer; font-weight: 700; font-size: 1rem; }");
        Sb.AppendLine(".btn:hover { background: #06b6d4; }");
        Sb.AppendLine(".btn:disabled { opacity: 0.5; cursor: not-allowed; }");
        Sb.AppendLine(".api-key-input { background: #1e293b; color: #e2e8f0; border: 1px solid #334155; border-radius: 6px; padding: 0.75rem; width: 100%; max-width: 400px; font-family: monospace; }");
        Sb.AppendLine(".streaming-indicator { color: #22d3ee; font-style: italic; padding: 0.5rem; }");
        Sb.AppendLine(".auth-options { display: flex; flex-direction: column; align-items: center; gap: 1rem; padding: 2rem; background: #1e293b; border-radius: 8px; border: 1px solid #334155; }");
        Sb.AppendLine(".auth-divider { color: #64748b; font-size: 0.9rem; }");
        Sb.AppendLine(".proxy-input { display: flex; gap: 0.5rem; align-items: center; flex-wrap: wrap; justify-content: center; }");
        Sb.AppendLine(".proxy-input label { color: #94a3b8; font-weight: 600; }");

        File.WriteAllText(Path.Combine(Dir, AnthropicConstants.GeneratedWwwrootDirectory, AnthropicConstants.GeneratedCssDirectory, AnthropicConstants.GeneratedCssFileName), Sb.ToString());
    }

    private static void WriteClaudeCodeFavicon(string Dir)
    {
        var DestPath = Path.Combine(Dir, AnthropicConstants.GeneratedWwwrootDirectory, AnthropicConstants.GeneratedFaviconFileName);
        File.WriteAllBytes(DestPath, Convert.FromBase64String(AnthropicConstants.GeneratedFaviconBase64));
    }

    private static void WriteProxyProject(string Dir)
    {
        Directory.CreateDirectory(Dir);

        WriteProxyCsproj(Dir);
        WriteProxyProgram(Dir);
    }

    private static void WriteProxyCsproj(string Dir)
    {
        var Sb = new StringBuilder();
        Sb.Append("<Project Sdk=\"").Append(AnthropicConstants.ProxyProjectSdk).AppendLine("\">");
        Sb.AppendLine("  <PropertyGroup>");
        Sb.Append("    <TargetFramework>").Append(AnthropicConstants.GeneratedTargetFramework).AppendLine("</TargetFramework>");
        Sb.AppendLine("    <ImplicitUsings>enable</ImplicitUsings>");
        Sb.AppendLine("    <Nullable>enable</Nullable>");
        Sb.Append("    <NoWarn>").Append(AnthropicConstants.NoWarnList).AppendLine("</NoWarn>");
        Sb.AppendLine("  </PropertyGroup>");
        Sb.AppendLine("</Project>");

        File.WriteAllText(Path.Combine(Dir, string.Concat(AnthropicConstants.ProxyNamespace, AnthropicConstants.GeneratedCsprojExtension)), Sb.ToString());
    }

    private static void WriteProxyProgram(string Dir)
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("using System.Net.Http.Headers;");
        Sb.AppendLine("using System.Net.WebSockets;");
        Sb.AppendLine("using System.Text;");
        Sb.AppendLine("using System.Text.Json;");
        Sb.AppendLine();
        Sb.AppendLine("var Builder = WebApplication.CreateBuilder(args);");
        Sb.Append("Builder.WebHost.UseUrls(\"").Append(AnthropicConstants.ProxyLocalhost).Append(":").Append(AnthropicConstants.ProxyPortRangeStart).AppendLine("\");");
        Sb.AppendLine("Builder.Services.AddCors();");
        Sb.AppendLine("var App = Builder.Build();");
        Sb.AppendLine("App.UseCors(P => P.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());");
        Sb.AppendLine("App.UseWebSockets();");
        Sb.AppendLine();
        Sb.Append("var CredsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), \"").Append(AnthropicConstants.ProxyCredentialsSubPath).AppendLine("\");");
        Sb.AppendLine();

        Sb.AppendLine("async Task<string> GetOAuthTokenAsync()");
        Sb.AppendLine("{");
        Sb.AppendLine("    var CredsJson = await File.ReadAllTextAsync(CredsPath);");
        Sb.AppendLine("    var Creds = JsonDocument.Parse(CredsJson);");
        Sb.Append("    return Creds.RootElement.GetProperty(\"").Append(AnthropicConstants.ProxyOAuthJsonPath).Append("\").GetProperty(\"").Append(AnthropicConstants.ProxyAccessTokenJsonPath).AppendLine("\").GetString()!;");
        Sb.AppendLine("}");
        Sb.AppendLine();

        Sb.Append("App.MapGet(\"").Append(AnthropicConstants.ProxyMessagesRoute).AppendLine("\", () => Results.Ok(\"Proxy running\"));");
        Sb.AppendLine();

        Sb.Append("App.Map(\"").Append(AnthropicConstants.ProxyWssRoute).AppendLine("\", async (HttpContext Ctx) =>");
        Sb.AppendLine("{");
        Sb.AppendLine("    if (!Ctx.WebSockets.IsWebSocketRequest)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        Ctx.Response.StatusCode = 400;");
        Sb.AppendLine("        return;");
        Sb.AppendLine("    }");
        Sb.AppendLine();
        Sb.AppendLine("    using var Ws = await Ctx.WebSockets.AcceptWebSocketAsync();");
        Sb.AppendLine("    var Buffer = new byte[65536];");
        Sb.AppendLine();
        Sb.AppendLine("    while (Ws.State == WebSocketState.Open)");
        Sb.AppendLine("    {");
        Sb.AppendLine("        var Received = await Ws.ReceiveAsync(new ArraySegment<byte>(Buffer), CancellationToken.None);");
        Sb.AppendLine("        if (Received.MessageType == WebSocketMessageType.Close)");
        Sb.AppendLine("            break;");
        Sb.AppendLine();
        Sb.AppendLine("        var RequestJson = Encoding.UTF8.GetString(Buffer, 0, Received.Count);");
        Sb.AppendLine();
        Sb.AppendLine("        try");
        Sb.AppendLine("        {");
        Sb.AppendLine("            var OAuthToken = await GetOAuthTokenAsync();");
        Sb.AppendLine("            using var ApiClient = new HttpClient();");
        Sb.Append("            var ApiRequest = new HttpRequestMessage(HttpMethod.Post, \"").Append(AnthropicConstants.ApiUrlWithBeta).AppendLine("\");");
        Sb.Append("            ApiRequest.Headers.Authorization = new AuthenticationHeaderValue(\"").Append("Bearer").AppendLine("\", OAuthToken);");
        Sb.Append("            ApiRequest.Headers.Add(\"").Append(AnthropicConstants.ApiVersionHeaderName).Append("\", \"").Append(AnthropicConstants.ApiVersionValue).AppendLine("\");");
        Sb.Append("            ApiRequest.Headers.Add(\"").Append(AnthropicConstants.AnthropicBetaHeaderName).Append("\", \"").Append(AnthropicConstants.FullBetaValue).AppendLine("\");");
        Sb.Append("            ApiRequest.Headers.Add(\"").Append(AnthropicConstants.DangerouslyAllowBrowserHeaderName).Append("\", \"").Append(AnthropicConstants.DangerouslyAllowBrowserHeaderValue).AppendLine("\");");
        Sb.AppendLine("            ApiRequest.Headers.TryAddWithoutValidation(\"user-agent\", \"" + AnthropicConstants.UserAgentValue + "\");");
        Sb.Append("            ApiRequest.Headers.Add(\"").Append(AnthropicConstants.XAppHeaderName).Append("\", \"").Append(AnthropicConstants.XAppValue).AppendLine("\");");
        Sb.Append("            ApiRequest.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(\"").Append(AnthropicConstants.AcceptJsonValue).AppendLine("\"));");
        Sb.Append("            ApiRequest.Content = new StringContent(RequestJson, Encoding.UTF8, \"").Append(AnthropicConstants.ContentTypeJson).AppendLine("\");");
        Sb.AppendLine();
        Sb.AppendLine("            var ParsedRequest = JsonDocument.Parse(RequestJson);");
        Sb.AppendLine("            var IsStreaming = false;");
        Sb.Append("            if (ParsedRequest.RootElement.TryGetProperty(\"").Append(AnthropicConstants.StreamParameterName).AppendLine("\", out var StreamProp))");
        Sb.AppendLine("                IsStreaming = StreamProp.GetBoolean();");
        Sb.AppendLine();
        Sb.AppendLine("            if (IsStreaming)");
        Sb.AppendLine("            {");
        Sb.Append("                ApiRequest.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(\"").Append(AnthropicConstants.AcceptHeaderValue).AppendLine("\"));");
        Sb.AppendLine("                var ApiResponse = await ApiClient.SendAsync(ApiRequest, HttpCompletionOption.ResponseHeadersRead);");
        Sb.AppendLine("                if (!ApiResponse.IsSuccessStatusCode)");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    var ErrorBody = await ApiResponse.Content.ReadAsStringAsync();");
        Sb.Append("                    var ErrorMsg = JsonSerializer.Serialize(new { type = \"").Append(AnthropicConstants.WssMessageTypeError).Append("\", status_code = (int)ApiResponse.StatusCode, message = ErrorBody });");
        Sb.AppendLine();
        Sb.AppendLine("                    await Ws.SendAsync(Encoding.UTF8.GetBytes(ErrorMsg), WebSocketMessageType.Text, true, CancellationToken.None);");
        Sb.AppendLine("                    continue;");
        Sb.AppendLine("                }");
        Sb.AppendLine();
        Sb.AppendLine("                using var Stream = await ApiResponse.Content.ReadAsStreamAsync();");
        Sb.AppendLine("                using var Reader = new StreamReader(Stream, Encoding.UTF8);");
        Sb.AppendLine("                while (!Reader.EndOfStream)");
        Sb.AppendLine("                {");
        Sb.AppendLine("                    var Line = await Reader.ReadLineAsync();");
        Sb.AppendLine("                    if (Line is null)");
        Sb.AppendLine("                        break;");
        Sb.AppendLine("                    if (Line.Length == 0)");
        Sb.AppendLine("                        continue;");
        Sb.Append("                    var SseMsg = JsonSerializer.Serialize(new { type = \"").Append(AnthropicConstants.WssMessageTypeSseEvent).AppendLine("\", data = Line });");
        Sb.AppendLine("                    await Ws.SendAsync(Encoding.UTF8.GetBytes(SseMsg), WebSocketMessageType.Text, true, CancellationToken.None);");
        Sb.AppendLine("                }");
        Sb.AppendLine();
        Sb.Append("                var DoneMsg = JsonSerializer.Serialize(new { type = \"").Append(AnthropicConstants.WssMessageTypeSseDone).AppendLine("\" });");
        Sb.AppendLine("                await Ws.SendAsync(Encoding.UTF8.GetBytes(DoneMsg), WebSocketMessageType.Text, true, CancellationToken.None);");
        Sb.AppendLine("            }");
        Sb.AppendLine("            else");
        Sb.AppendLine("            {");
        Sb.AppendLine("                var ApiResponse = await ApiClient.SendAsync(ApiRequest);");
        Sb.AppendLine("                var ResponseBody = await ApiResponse.Content.ReadAsStringAsync();");
        Sb.Append("                var ResponseMsg = JsonSerializer.Serialize(new { type = \"").Append(AnthropicConstants.WssMessageTypeResponse).Append("\", status_code = (int)ApiResponse.StatusCode, data = ResponseBody });");
        Sb.AppendLine();
        Sb.AppendLine("                await Ws.SendAsync(Encoding.UTF8.GetBytes(ResponseMsg), WebSocketMessageType.Text, true, CancellationToken.None);");
        Sb.AppendLine("            }");
        Sb.AppendLine("        }");
        Sb.AppendLine("        catch (Exception Ex)");
        Sb.AppendLine("        {");
        Sb.Append("            var ErrMsg = JsonSerializer.Serialize(new { type = \"").Append(AnthropicConstants.WssMessageTypeError).AppendLine("\", message = Ex.Message });");
        Sb.AppendLine("            await Ws.SendAsync(Encoding.UTF8.GetBytes(ErrMsg), WebSocketMessageType.Text, true, CancellationToken.None);");
        Sb.AppendLine("        }");
        Sb.AppendLine("    }");
        Sb.AppendLine("});");
        Sb.AppendLine();
        Sb.Append("Console.WriteLine(string.Concat(\"Proxy listening on ").Append(AnthropicConstants.ProxyLocalhost).Append(":").Append(AnthropicConstants.ProxyPortRangeStart).AppendLine("\"));");
        Sb.AppendLine("Console.WriteLine(string.Concat(\"WebSocket endpoint: ws://127.0.0.1:" + AnthropicConstants.ProxyPortRangeStart + AnthropicConstants.ProxyWssRoute + "\"));");
        Sb.AppendLine("Console.WriteLine(string.Concat(\"Credentials: \", CredsPath));");
        Sb.AppendLine("App.Run();");

        File.WriteAllText(Path.Combine(Dir, AnthropicConstants.GeneratedProgramFileName), Sb.ToString());
    }

    private static string ToPascalCase(string Input)
    {
        var Sb = new StringBuilder();
        var CapNext = true;
        foreach (var Ch in Input)
        {
            if (Ch is '_' or '-' or '.')
            {
                CapNext = true;
                continue;
            }

            Sb.Append(CapNext ? char.ToUpperInvariant(Ch) : Ch);
            CapNext = false;
        }

        return Sb.ToString();
    }
}
