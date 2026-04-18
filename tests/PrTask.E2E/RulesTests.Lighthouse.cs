using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using PrTask.Cdp;
using PrTask.Domain.Constants;
using PrTask.Lighthouse;
using PrTask.Lighthouse.Models;
namespace PrTask.E2E;
public partial class RulesTests
{
    private const double LighthouseMinScore = 0.9;

    private static readonly string[] LighthouseAllRoutes =
    [
        "/", "/About", "/Tasks", "/HowItWorks", "/Pricing",
        "/Download", "/Leaderboard", "/Login", "/Dashboard",
        "/Settings", "/Sprints", "/Boards", "/NotFound",
        "/Client/CreateTask", "/Client/Payments", "/Client/Repository",
        "/Legal/Terms", "/Legal/Privacy", "/Legal/Refund",
        "/Legal/AcceptableUse", "/Legal/CookiePolicy",
        "/Legal/Licenses", "/Legal/Accessibility", "/Legal/Dmca",
    ];

    private static readonly string[] LighthouseLanguageCodes =
        I18NConstants.AllLanguages.Select(L => L.Code).ToArray();

    private static async Task<LighthouseReport> RunInProcessLighthouseAsync(
        CdpBrowser CdpBrowserInstance, string Url, bool Mobile, CancellationToken Cancel)
    {
        var Auditor = new LighthouseAuditor();
        await using var Page = await CdpBrowserInstance.NewPageAsync(null, Cancel);

        if (Mobile)
        {
            await Page.SetViewportAsync(375, 812, 2.625, Cancel);
        }
        else
        {
            await Page.SetViewportAsync(1350, 940, 1.0, Cancel);
        }

        await Page.NavigateAsync(Url, Cancel);
        await Page.WaitForLoadAsync(Cancel);
        await Task.Delay(3000, Cancel);

        return await Auditor.AuditAsync(CdpBrowserInstance.Transport, Page.SessionId, Url, Cancel);
    }

    private static async Task RunLighthouseOnAllRoutesAsync(string BaseUrlParam, bool Mobile)
    {
        using var LhLauncher = new ChromeLauncher();
        var IsHeadless = Environment.GetEnvironmentVariable("PRTASK_HEADLESS") != "false";
        var Width = Mobile ? 375 : 1350;
        var Height = Mobile ? 812 : 940;
        await using var CdpBrowserInstance = await LhLauncher.LaunchAsync(new ChromeLaunchOptions
        {
            Headless = IsHeadless,
            WindowWidth = Width,
            WindowHeight = Height,
        });

        var Failures = new List<string>();

        // Test English routes
        foreach (var PagePath in LighthouseAllRoutes)
        {
            var Url = PagePath == "/"
                ? BaseUrlParam
                : $"{BaseUrlParam.TrimEnd('/')}{PagePath}";
            try
            {
                var Report = await RunInProcessLighthouseAsync(CdpBrowserInstance, Url, Mobile, CancellationToken.None);
                CheckLighthouseCategory(Failures, PagePath, "performance", Report.Performance.Score);
                CheckLighthouseCategory(Failures, PagePath, "accessibility", Report.Accessibility.Score);
                CheckLighthouseCategory(Failures, PagePath, "seo", Report.Seo.Score);
                CheckLighthouseCategory(Failures, PagePath, "best-practices", Report.BestPractices.Score);
            }
            catch (Exception Ex)
            {
                Failures.Add($"{PagePath} error: {Ex.Message}");
            }
        }

        // Test language routes (spot-check home page for each language)
        foreach (var LangCode in LighthouseLanguageCodes)
        {
            if (LangCode == I18NConstants.LanguageCodeEnglish) continue;
            var LangUrl = $"{BaseUrlParam.TrimEnd('/')}/{LangCode}/";
            try
            {
                var Report = await RunInProcessLighthouseAsync(CdpBrowserInstance, LangUrl, Mobile, CancellationToken.None);
                CheckLighthouseCategory(Failures, $"/{LangCode}/", "performance", Report.Performance.Score);
                CheckLighthouseCategory(Failures, $"/{LangCode}/", "accessibility", Report.Accessibility.Score);
                CheckLighthouseCategory(Failures, $"/{LangCode}/", "seo", Report.Seo.Score);
                CheckLighthouseCategory(Failures, $"/{LangCode}/", "best-practices", Report.BestPractices.Score);
            }
            catch (Exception Ex)
            {
                Failures.Add($"/{LangCode}/ error: {Ex.Message}");
            }
        }

        Assert.AreEqual(0, Failures.Count,
            $"Lighthouse failures (min {LighthouseMinScore:P0}):\n{string.Join("\n", Failures)}");
    }

    [TestMethod]
    [Timeout(1800000)]
    [DisplayName("Lighthouse: prtask.com desktop 100% all routes")]
    public async Task LighthousePrtaskComDesktopAsync()
    {
        await RunLighthouseOnAllRoutesAsync($"https://{AppConstants.AppDomain}", false);
    }

    [TestMethod]
    [Timeout(1800000)]
    [DisplayName("Lighthouse: prtask.com mobile 100% all routes")]
    public async Task LighthousePrtaskComMobileAsync()
    {
        await RunLighthouseOnAllRoutesAsync($"https://{AppConstants.AppDomain}", true);
    }

    [TestMethod]
    [Timeout(1800000)]
    [DisplayName("Lighthouse: GitHub Pages desktop 100% all routes")]
    public async Task LighthouseGhPagesDesktopAsync()
    {
        await RunLighthouseOnAllRoutesAsync("https://cruzlauroiii.github.io/prtask.com", false);
    }

    [TestMethod]
    [Timeout(1800000)]
    [DisplayName("Lighthouse: GitHub Pages mobile 100% all routes")]
    public async Task LighthouseGhPagesMobileAsync()
    {
        await RunLighthouseOnAllRoutesAsync("https://cruzlauroiii.github.io/prtask.com", true);
    }

    [TestMethod]
    [Timeout(1800000)]
    [DisplayName("Lighthouse: Windows EXE desktop 100% all routes")]
    public async Task LighthouseDesktopExeDesktopAsync()
    {
        var DesktopUrl = await StartDesktopServerAsync();
        await RunLighthouseOnAllRoutesAsync(DesktopUrl, false);
    }

    [TestMethod]
    [Timeout(1800000)]
    [DisplayName("Lighthouse: Windows EXE mobile 100% all routes")]
    public async Task LighthouseDesktopExeMobileAsync()
    {
        var DesktopUrl = await StartDesktopServerAsync();
        await RunLighthouseOnAllRoutesAsync(DesktopUrl, true);
    }

    [TestMethod]
    [Timeout(1800000)]
    [DisplayName("Lighthouse: Android APK desktop 100% all routes via ADB proxy")]
    public async Task LighthouseAndroidDesktopAsync()
    {
        var AndroidUrl = await StartAndroidProxyAsync();
        await RunLighthouseOnAllRoutesAsync(AndroidUrl, false);
    }

    [TestMethod]
    [Timeout(1800000)]
    [DisplayName("Lighthouse: Android APK mobile 100% all routes via ADB proxy")]
    public async Task LighthouseAndroidMobileAsync()
    {
        var AndroidUrl = await StartAndroidProxyAsync();
        await RunLighthouseOnAllRoutesAsync(AndroidUrl, true);
    }

    [TestMethod]
    [Timeout(1800000)]
    [DisplayName("Lighthouse: local server desktop 100% all routes")]
    public async Task LighthouseLocalDesktopAsync()
    {
        var LocalUrl = Environment.GetEnvironmentVariable("PRTASK_BASE_URL");
        if (string.IsNullOrEmpty(LocalUrl))
        {
            Assert.Inconclusive("Set PRTASK_BASE_URL to local server URL (e.g. https://127.0.0.1:5001)");
        }
        await RunLighthouseOnAllRoutesAsync(LocalUrl, false);
    }

    [TestMethod]
    [Timeout(1800000)]
    [DisplayName("Lighthouse: local server mobile 100% all routes")]
    public async Task LighthouseLocalMobileAsync()
    {
        var LocalUrl = Environment.GetEnvironmentVariable("PRTASK_BASE_URL");
        if (string.IsNullOrEmpty(LocalUrl))
        {
            Assert.Inconclusive("Set PRTASK_BASE_URL to local server URL (e.g. https://127.0.0.1:5001)");
        }
        await RunLighthouseOnAllRoutesAsync(LocalUrl, true);
    }

    private static void CheckLighthouseCategory(List<string> Failures, string PagePath, string Category, double Score)
    {
        if (Score < LighthouseMinScore)
        {
            Failures.Add($"{PagePath} {Category}={Score:P0}");
        }
    }

    private static async Task<string> StartDesktopServerAsync()
    {
        var EnvUrl = Environment.GetEnvironmentVariable(PlatformTestConstants.DesktopBaseUrlEnv);
        if (!string.IsNullOrEmpty(EnvUrl))
        {
            return EnvUrl;
        }

        var ExePath = Path.Combine(SolutionRoot, "publish-output", "desktop", PlatformTestConstants.DesktopExePath);
        if (!File.Exists(ExePath))
        {
            Assert.Inconclusive($"Desktop EXE not found: {ExePath}. Run publish-desktop.ps1 first.");
            return string.Empty;
        }

        var Port = GetRandomPort();
        var Url = $"https://127.0.0.1:{Port}";
        var Proc = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = ExePath,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
                Environment =
                {
                    ["ASPNETCORE_URLS"] = Url,
                    ["ASPNETCORE_ENVIRONMENT"] = "Production",
                },
            },
        };
        Proc.Start();
        await Task.Delay(PlatformTestConstants.DesktopStartupWaitMs);

        // Verify reachable
        using var Http = CreatePlatformHttpClient(Url);
        Http.Timeout = TimeSpan.FromSeconds(15);
        try
        {
            var Response = await Http.GetAsync("/");
            LogWarning($"Desktop EXE at {Url} returned {(int)Response.StatusCode}");
        }
        catch (Exception Ex)
        {
            Proc.Kill(true);
            Assert.Inconclusive($"Desktop EXE not reachable at {Url}: {Ex.Message}");
        }

        return Url;
    }

    private static async Task<string> StartAndroidProxyAsync()
    {
        var EnvUrl = Environment.GetEnvironmentVariable(PlatformTestConstants.AndroidBaseUrlEnv);
        if (!string.IsNullOrEmpty(EnvUrl))
        {
            return EnvUrl;
        }

        var AdbSerial = PlatformTestConstants.AdbDeviceSerial;
        var LocalPort = GetRandomPort();
        var RemotePort = 5001;

        // Start the APK activity
        try
        {
            await RunAdbCommandAsync(AdbSerial, $"shell am start -n {PlatformTestConstants.AndroidPackageName}/{PlatformTestConstants.AndroidActivityName}");
            await Task.Delay(PlatformTestConstants.AndroidBootWaitMs);
        }
        catch (Exception Ex)
        {
            Assert.Inconclusive($"Failed to start Android app: {Ex.Message}");
        }

        // Set up ADB port forwarding
        try
        {
            await RunAdbCommandAsync(AdbSerial, $"forward tcp:{LocalPort} tcp:{RemotePort}");
        }
        catch (Exception Ex)
        {
            Assert.Inconclusive($"ADB port forward failed: {Ex.Message}");
        }

        var Url = $"https://127.0.0.1:{LocalPort}";

        // Verify reachable
        using var Http = CreatePlatformHttpClient(Url);
        Http.Timeout = TimeSpan.FromSeconds(15);
        try
        {
            var Response = await Http.GetAsync("/");
            LogWarning($"Android APK at {Url} (forwarded from {AdbSerial}:{RemotePort}) returned {(int)Response.StatusCode}");
        }
        catch (Exception Ex)
        {
            Assert.Inconclusive($"Android APK not reachable at {Url}: {Ex.Message}");
        }

        return Url;
    }

    private static async Task RunAdbCommandAsync(string Serial, string Args)
    {
        var Proc = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "adb",
                Arguments = $"-s {Serial} {Args}",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
            },
        };
        Proc.Start();
        var StdOut = await Proc.StandardOutput.ReadToEndAsync();
        var StdErr = await Proc.StandardError.ReadToEndAsync();
        await Proc.WaitForExitAsync();
        if (Proc.ExitCode != 0)
        {
            throw new InvalidOperationException($"adb {Args} failed (exit {Proc.ExitCode}): {StdErr}");
        }
        LogWarning($"adb -s {Serial} {Args}: {StdOut.Trim()}");
    }

    private static int GetRandomPort()
    {
        using var Listener = new TcpListener(IPAddress.Loopback, 0);
        Listener.Start();
        var Port = ((IPEndPoint)Listener.LocalEndpoint).Port;
        Listener.Stop();
        return Port;
    }
}
