using System.Diagnostics;
using PrTask.Cdp;
using PrTask.Domain.Constants;

namespace PrTask.E2E;

public partial class RulesTests
{
    private static readonly Dictionary<string, PlatformContext> PlatformContexts = [];
    private static Process? DesktopProcess { get; set; }

    public static async Task<PlatformContext> GetPlatformContextAsync(string Platform)
    {
        if (PlatformContexts.TryGetValue(Platform, out var Existing))
        {
            return Existing;
        }

        var Ctx = Platform switch
        {
            PlatformTestConstants.PlatformWeb => await CreateWebContextAsync(),
            PlatformTestConstants.PlatformDesktop => await CreateDesktopContextAsync(),
            PlatformTestConstants.PlatformAndroid => await CreateAndroidContextAsync(),
            _ => throw new ArgumentOutOfRangeException(nameof(Platform), Platform, null)
        };
        PlatformContexts[Platform] = Ctx;
        return Ctx;
    }

    private static Task<PlatformContext> CreateWebContextAsync()
    {
        var Url = Environment.GetEnvironmentVariable(PlatformTestConstants.WebBaseUrlEnv)
            ?? PlatformTestConstants.DefaultWebUrl;
        return Task.FromResult(new PlatformContext(PlatformTestConstants.PlatformWeb, Url, BrowserPage, Browser, null));
    }

    private static async Task<PlatformContext> CreateDesktopContextAsync()
    {
        var Url = Environment.GetEnvironmentVariable(PlatformTestConstants.DesktopBaseUrlEnv)
            ?? PlatformTestConstants.DefaultDesktopUrl;
        if (DesktopProcess is null)
        {
            DesktopProcess = StartDesktopApp();
            await Task.Delay(PlatformTestConstants.DesktopStartupWaitMs);
        }
        return new PlatformContext(PlatformTestConstants.PlatformDesktop, Url, BrowserPage, Browser, null);
    }

    private static Process StartDesktopApp()
    {
        var ExePath = Path.Combine(SolutionRoot, "publish-output", PlatformTestConstants.DesktopExePath);
        var Proc = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = ExePath,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                Environment = { ["ASPNETCORE_ENVIRONMENT"] = "Development" }
            }
        };
        Proc.Start();
        return Proc;
    }

    private static Task<PlatformContext> CreateAndroidContextAsync()
    {
        var Url = Environment.GetEnvironmentVariable(PlatformTestConstants.AndroidBaseUrlEnv)
            ?? PlatformTestConstants.DefaultAndroidUrl;
        return Task.FromResult(new PlatformContext(PlatformTestConstants.PlatformAndroid, Url, BrowserPage, Browser, null));
    }

    public static async Task TakePlatformScreenshotAsync(PlatformContext Ctx, string Step, string Label)
    {
        Directory.CreateDirectory(ScreenshotDir);
        var FileName = string.Format(PlatformTestConstants.PlatformScreenshotFormat, Ctx.Platform, Step, Label);
        var Bytes = await Ctx.Page.CaptureScreenshotAsync();
        await File.WriteAllBytesAsync(Path.Combine(ScreenshotDir, FileName), Bytes);
    }

    public static void VerifyPlatformScreenshot(string Platform, string Step, string Label)
    {
        var FileName = string.Format(PlatformTestConstants.PlatformScreenshotFormat, Platform, Step, Label);
        var FilePath = Path.Combine(ScreenshotDir, FileName);
        Assert.IsTrue(File.Exists(FilePath),
            string.Format(PlatformTestConstants.ScreenshotExistsAssert, Label, Platform));
        Assert.IsTrue(new FileInfo(FilePath).Length > PlatformTestConstants.MinPlatformScreenshotBytes,
            string.Format(PlatformTestConstants.ScreenshotExistsAssert, Label, Platform));
    }

    public static HttpClient CreatePlatformHttpClient(string BaseAddress)
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        return new HttpClient(Handler) { BaseAddress = new Uri(BaseAddress), Timeout = TimeSpan.FromSeconds(60) };
    }

    public static Task CleanupPlatformContextsAsync()
    {
        foreach (var Kvp in PlatformContexts)
        {
            Kvp.Value.Http?.Dispose();
        }
        PlatformContexts.Clear();
        if (DesktopProcess is not null && !DesktopProcess.HasExited)
        {
            DesktopProcess.Kill(true);
            DesktopProcess.Dispose();
            DesktopProcess = null;
        }
        return Task.CompletedTask;
    }

    public static string[] AllPlatforms => [
        PlatformTestConstants.PlatformWeb,
        PlatformTestConstants.PlatformDesktop,
        PlatformTestConstants.PlatformAndroid
    ];
}
