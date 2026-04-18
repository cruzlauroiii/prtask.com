using System.Text;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Builder;
using PrTask.Cdp;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
[TestClass]
public partial class RulesTests
{
    private static readonly string SolutionRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", ".."));
    private static readonly string SourceRoot = Path.Combine(SolutionRoot, "src");
    private static readonly string ScreenshotDir = Path.Combine(SolutionRoot, "output", "screenshots");
    private static readonly string LiveSiteUrl = $"https://{AppConstants.AppDomain}";
    private static string BaseUrl { get; set; } = string.Empty;
    private static readonly System.Reflection.Assembly DomainAssembly = typeof(AppConstants).Assembly;
    private static HttpClient LiveClient { get; set; } = null!;
    private static ChromeLauncher Launcher { get; set; } = null!;
    private static CdpBrowser Browser { get; set; } = null!;
    private static CdpPage BrowserPage { get; set; } = null!;
    internal static WebApplication? InProcessApp { get; set; }
    internal static string LocalServerUrl { get; set; } = string.Empty;
    private static int BrowserContextCount;
    private static int BrowserPageCount;
    private static readonly List<string> ConsoleErrors = [];
    private static readonly Lock ConsoleErrorLock = new();
    [ClassInitialize]
    public static async Task InitAsync(TestContext Context)
    {
        BaseUrl = Environment.GetEnvironmentVariable("PRTASK_BASE_URL") ?? string.Empty;
        if (string.IsNullOrEmpty(BaseUrl))
        {
            await StartLocalServerAsync();
            BaseUrl = LocalServerUrl;
        }
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        LiveClient = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(60) };
        var IsHeadless = Environment.GetEnvironmentVariable("PRTASK_HEADLESS") != "false";
        Launcher = new ChromeLauncher();
        Browser = await Launcher.LaunchAsync(new ChromeLaunchOptions
        {
            Headless = IsHeadless,
            WindowWidth = 1280,
            WindowHeight = 720,
            ExtraArgs = IsHeadless ? [] : ["--start-maximized"],
        });
        BrowserContextCount = 1;
        BrowserPage = await Browser.NewPageAsync();
        BrowserPageCount = 1;
        await BrowserPage.EnableConsoleAsync();
        AttachConsoleErrorListener(BrowserPage);
    }
    public TestContext TestContext { get; set; } = null!;
    [TestInitialize]
    public void TestInit()
    {
        ResetUrlTrackingForTest(TestContext.TestName ?? "unknown");
    }
    private static void AttachConsoleErrorListener(CdpPage Page)
    {
        var Client = CdpHelpers.GetTransport(Page);
        CdpConsole.OnRuntimeConsoleApiCalled(Client, Call =>
        {
            if (Call.Type == "error")
            {
                var ErrorText = $"[{DateTime.UtcNow:O}] CONSOLE ERROR: {string.Join(" ", Call.Args)}";
                lock (ConsoleErrorLock)
                {
                    ConsoleErrors.Add(ErrorText);
                }
                LogError(ErrorText);
            }
        });
        CdpConsole.OnRuntimeExceptionThrown(Client, Ex =>
        {
            var ErrorText = $"[{DateTime.UtcNow:O}] PAGE ERROR: {Ex.Text}";
            lock (ConsoleErrorLock)
            {
                ConsoleErrors.Add(ErrorText);
            }
            LogError(ErrorText);
        });
    }
    private static void GuardSingleBrowser()
    {
        if (BrowserContextCount > 1)
        {
            var Msg = $"MULTIPLE BROWSERS: {BrowserContextCount} browser contexts created. Only 1 allowed.";
            LogError(Msg);
            Assert.Fail(Msg);
        }
        if (BrowserPageCount > 1)
        {
            var Msg = $"MULTIPLE PAGES: {BrowserPageCount} browser pages created. Only 1 allowed.";
            LogError(Msg);
            Assert.Fail(Msg);
        }
    }
    private static readonly string[] IgnoredConsoleErrors =
    [
        "_framework/blazor", "Failed to load resource", "MIME type",
        "favicon.ico", "manifest.json", "service-worker",
        "appsettings.json", "MONO_WASM", "mono_download_assets",
        "Failed to start platform", "Failed to fetch",
        "net::ERR_", "TypeError: Failed to fetch"
    ];
    private static bool IsIgnoredConsoleError(string Error) =>
        IgnoredConsoleErrors.Any(Pattern => Error.Contains(Pattern, StringComparison.OrdinalIgnoreCase));
    private static async Task CheckPageForErrorsAsync(string Url)
    {
        string[] ConsoleErrorsCopy;
        lock (ConsoleErrorLock)
        {
            ConsoleErrorsCopy = [.. ConsoleErrors];
            ConsoleErrors.Clear();
        }
        var AppErrors = ConsoleErrorsCopy.Where(E => !IsIgnoredConsoleError(E)).ToArray();
        if (AppErrors.Length > 0)
        {
            var AllErrors = string.Join("\n", AppErrors);
            LogError($"BROWSER CONSOLE ERRORS after navigating {Url}:\n{AllErrors}");
            Assert.Fail($"Browser console errors on {Url}:\n{AllErrors}");
        }
        foreach (var Ignored in ConsoleErrorsCopy.Where(IsIgnoredConsoleError))
        {
            LogWarning($"Ignored console error: {Ignored}");
        }
        var ErrorNodes = await BrowserPage.QuerySelectorAllAsync(".blazor-error-boundary, .error-boundary, [data-error='true']");
        if (ErrorNodes.Length > 0)
        {
            var ErrorText = await CdpHelpers.GetTextContentAsync(BrowserPage, ".blazor-error-boundary, .error-boundary, [data-error='true']");
            var Msg = $"SCREEN ERROR on {Url}: {ErrorText}";
            LogError(Msg);
            await TakeScreenshotAsync($"ERROR-{DateTime.UtcNow:HHmmss}.png");
            Assert.Fail(Msg);
        }
    }
    private static Task StartLocalServerAsync() => InProcessServerHelper.StartAsync();
    [ClassCleanup]
    public static async Task CleanupAsync()
    {
        LiveClient.Dispose();
        try { if (BrowserPage is not null) { await BrowserPage.DisposeAsync().AsTask().WaitAsync(TimeSpan.FromSeconds(5)); } } catch { }
        try { if (Browser is not null) { await Browser.DisposeAsync().AsTask().WaitAsync(TimeSpan.FromSeconds(5)); } } catch { }
        Launcher?.Dispose();
        try { await InProcessServerHelper.StopAsync().WaitAsync(TimeSpan.FromSeconds(5)); } catch { }
    }
    private static async Task<CdpPage?> NavigateOrSkipAsync(string Url)
    {
        GuardSingleBrowser();
        TrackUrlVisit(Url);
        try
        {
            await BrowserPage.NavigateAsync(Url);
            try
            {
                using var Cts = new CancellationTokenSource(15000);
                await BrowserPage.WaitForLoadAsync(Cts.Token);
            }
            catch (OperationCanceledException) { }
            catch (CdpTimeoutException)
            {
                LogWarning($"Load timeout on {Url} — continuing");
            }
            await Task.Delay(500);
            await CheckPageForErrorsAsync(Url);
            return BrowserPage;
        }
        catch (CdpException Ex)
        {
            LogError($"Navigate {Url} failed: {Ex.Message}");
            Assert.Fail($"Navigate {Url} failed: {Ex.Message}");
            return null;
        }
    }
    private static async Task<string> DumpPagePlaintextAsync(string Url)
    {
        try
        {
            var Text = await CdpHelpers.GetTextContentAsync(BrowserPage, "body");
            if (string.IsNullOrEmpty(Text))
            {
                Text = "(empty body)";
            }
            var Trimmed = Text.Length > 2000 ? Text[..2000] + "...(truncated)" : Text;
            var PlaintextLogPath = Path.Combine(SolutionRoot, "output", "e2e-page-plaintext.log");
            Directory.CreateDirectory(Path.GetDirectoryName(PlaintextLogPath)!);
            File.AppendAllText(PlaintextLogPath,
                $"\n=== {DateTime.UtcNow:O} === {Url} ===\n{Text}\n");
            return Trimmed;
        }
        catch
        {
            return "(could not read page body)";
        }
    }
    private static async Task TakeScreenshotAsync(string FileName)
    {
        Directory.CreateDirectory(ScreenshotDir);
        var FilePath = Path.Combine(ScreenshotDir, FileName);
        var Bytes = await BrowserPage.CaptureScreenshotAsync();
        await File.WriteAllBytesAsync(FilePath, Bytes);
    }
    private static async Task<bool> WaitForBlazorAsync(string? ExpectedH1Text = null)
    {
        try
        {
            await CdpHelpers.WaitForSelectorAsync(BrowserPage, "h1", 30000);
            if (ExpectedH1Text is not null)
            {
                await CdpHelpers.WaitForFunctionAsync(BrowserPage,
                    $"() => document.querySelector('h1')?.textContent?.includes('{ExpectedH1Text}')",
                    30000);
            }
            return true;
        }
        catch (TimeoutException)
        {
            return false;
        }
    }
    private static readonly string ErrorLogPath = Path.Combine(SolutionRoot, "output", "e2e-errors.log");
    private static readonly string UrlVisitLogPath = Path.Combine(SolutionRoot, "output", "e2e-url-visits.log");
    private static readonly HashSet<string> VisitedUrls = new(StringComparer.OrdinalIgnoreCase);
    private static readonly Lock UrlLock = new();
    private static void TrackUrlVisit(string Url)
    {
        var NormalizedUrl = Url.TrimEnd('/');
        if (string.IsNullOrEmpty(NormalizedUrl)) { NormalizedUrl = "/"; }
        lock (UrlLock)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(UrlVisitLogPath)!);
            File.AppendAllText(UrlVisitLogPath,
                $"[{DateTime.UtcNow:O}] VISIT: {NormalizedUrl}" + Environment.NewLine);
            if (!VisitedUrls.Add(NormalizedUrl))
            {
                var ErrorMsg = $"DUPLICATE URL VISIT: {NormalizedUrl} — already visited. Merge this test step with the first visit.";
                LogError(ErrorMsg);
                Assert.Fail(ErrorMsg);
            }
        }
    }
    private static void LogWarning(string Message)
    {
        var Line = $"[{DateTime.UtcNow:O}] WARN: {Message}";
        Directory.CreateDirectory(Path.GetDirectoryName(ErrorLogPath)!);
        File.AppendAllText(ErrorLogPath, Line + Environment.NewLine);
    }
    private static void LogError(string Message)
    {
        var Line = $"[{DateTime.UtcNow:O}] ERROR: {Message}";
        Directory.CreateDirectory(Path.GetDirectoryName(ErrorLogPath)!);
        File.AppendAllText(ErrorLogPath, Line + Environment.NewLine);
    }
    private static readonly string ErrorLogPath = Path.Combine(SolutionRoot, "output", "e2e-errors.log");
    private static readonly string UrlVisitLogPath = Path.Combine(SolutionRoot, "output", "e2e-url-visits.log");
    private static readonly HashSet<string> VisitedUrls = new(StringComparer.OrdinalIgnoreCase);
    private static readonly Lock UrlLock = new();
    private static void TrackUrlVisit(string Url)
    {
        var NormalizedUrl = Url.TrimEnd('/');
        if (string.IsNullOrEmpty(NormalizedUrl)) { NormalizedUrl = "/"; }
        lock (UrlLock)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(UrlVisitLogPath)!);
            File.AppendAllText(UrlVisitLogPath,
                $"[{DateTime.UtcNow:O}] VISIT: {NormalizedUrl}" + Environment.NewLine);
            if (!VisitedUrls.Add(NormalizedUrl))
            {
                var ErrorMsg = $"DUPLICATE URL VISIT: {NormalizedUrl} — already visited. Merge this test step with the first visit.";
                LogError(ErrorMsg);
                Assert.Fail(ErrorMsg);
            }
        }
    }
    private static void LogWarning(string Message)
    {
        var Line = $"[{DateTime.UtcNow:O}] WARN: {Message}";
        Directory.CreateDirectory(Path.GetDirectoryName(ErrorLogPath)!);
        File.AppendAllText(ErrorLogPath, Line + Environment.NewLine);
    }
    private static void LogError(string Message)
    {
        var Line = $"[{DateTime.UtcNow:O}] ERROR: {Message}";
        Directory.CreateDirectory(Path.GetDirectoryName(ErrorLogPath)!);
        File.AppendAllText(ErrorLogPath, Line + Environment.NewLine);
    }
    private static string ReadSource(string Project, params string[] Parts)
    {
        var Segments = new[] { SourceRoot, Project }.Concat(Parts).ToArray();
        return File.ReadAllText(Path.Combine(Segments));
    }
    private static string ReadInfra(params string[] Parts)
    {
        var Segments = new[] { SolutionRoot, "infra" }.Concat(Parts).ToArray();
        return File.ReadAllText(Path.Combine(Segments));
    }
    private static IEnumerable<string> GetSourceFiles(string Extension) =>
        Directory.EnumerateFiles(SourceRoot, $"*{Extension}", SearchOption.AllDirectories)
            .Where(F => !F.Contains($"{Path.DirectorySeparatorChar}bin{Path.DirectorySeparatorChar}")
                && !F.Contains($"{Path.DirectorySeparatorChar}obj{Path.DirectorySeparatorChar}"));
    private static IEnumerable<string> GetAllProjectFiles() =>
        Directory.EnumerateFiles(SolutionRoot, "*.csproj", SearchOption.AllDirectories)
            .Where(F => !F.Contains($"{Path.DirectorySeparatorChar}bin{Path.DirectorySeparatorChar}")
                && !F.Contains($"{Path.DirectorySeparatorChar}obj{Path.DirectorySeparatorChar}"));
    private static bool ContainsByteSequence(byte[] Source, byte[] Pattern) =>
        ((ReadOnlySpan<byte>)Source).IndexOf((ReadOnlySpan<byte>)Pattern) >= 0;
    [GeneratedRegex(@"""name"":\s*""(PrTask\.(Client|SharedUI)\.[a-z0-9]+\.wasm)""")]
    private static partial Regex WasmAssemblyNamePattern();
    [GeneratedRegex(@"""\./_framework/dotnet\.js"":\s*""(\.\/_framework\/dotnet\.[a-z0-9]+\.js)""")]
    private static partial Regex ImportmapDotnetJsPattern();
    [GeneratedRegex(@"\[DisplayName\(""(Task\d+\s)")]
    private static partial Regex DisplayNameTaskPrefixPattern();
    [GeneratedRegex(@"\[DisplayName\(""(Task\d+\s)")]
    private static partial Regex DisplayNameTaskPrefixPattern();
    [GeneratedRegex(@"\[DisplayName\(""(Task\d+\s)")]
    private static partial Regex DisplayNameTaskPrefixPattern();
    [GeneratedRegex(@"\[DisplayName\(""(Task\d+\s)")]
    private static partial Regex DisplayNameTaskPrefixPattern();
    [GeneratedRegex(@"\[DisplayName\(""(Task\d+\s)")]
    private static partial Regex DisplayNameTaskPrefixPattern();
    [GeneratedRegex(@"Now listening on: (https://[^\s]+)")]
    private static partial Regex ListeningUrlPattern();
    private static string ResolveFingerprintedDotnetJs(string IndexHtml)
    {
        var Match = ImportmapDotnetJsPattern().Match(IndexHtml);
        return Match.Success
            ? Match.Groups[1].Value.TrimStart('.', '/')
            : "_framework/dotnet.js";
    }

    private static async Task<CdpPage> CreateEmulatedPageAsync(int Width = 1280, int Height = 720, bool Mobile = false, bool TouchEnabled = false, bool DisableJs = false)
    {
        var Page = await Browser.NewPageAsync();
        await Page.SetViewportAsync(Width, Height);
        if (Mobile || TouchEnabled)
        {
            await CdpEmulation.SetTouchEmulationEnabledAsync(
                CdpHelpers.GetTransport(Page), Page.SessionId, true);
            await CdpEmulation.SetDeviceMetricsOverrideAsync(
                CdpHelpers.GetTransport(Page), Page.SessionId, Width, Height, 1.0, Mobile);
        }
        if (DisableJs)
        {
            await CdpEmulation.SetScriptExecutionDisabledAsync(
                CdpHelpers.GetTransport(Page), Page.SessionId, true);
        }
        await Page.EnableConsoleAsync();
        return Page;
    }

    private static async Task ClosePageAsync(CdpPage Page)
    {
        try
        {
            await Browser.CloseTargetAsync(Page.TargetId);
        }
        catch { }
        try
        {
            await Page.DisposeAsync();
        }
        catch { }
    }
}
