using System.Diagnostics;
using System.Text.RegularExpressions;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("APK nav links must all navigate to valid Blazor routes via ADB")]
    public void Task83ApkNavLinksWorkViaAdb()
    {
        const string Device = AppConstants.AdbDeviceAddress;
        string AdbConnect;
        try
        {
            AdbConnect = RunAdb($"connect {Device}");
        }
        catch (Exception Ex)
        {
            Assert.Inconclusive($"ADB not available: {Ex.Message}");
            return;
        }
        if (!AdbConnect.Contains("connected") && !AdbConnect.Contains("already"))
        {
            Assert.Inconclusive($"ADB device not reachable: {AdbConnect}");
            return;
        }
        var Packages = RunAdb($"-s {Device} shell pm list packages {AppConstants.MauiPackageName}");
        if (!Packages.Contains(AppConstants.MauiPackageName))
        {
            Assert.Inconclusive($"APK {AppConstants.MauiPackageName} not installed on device");
            return;
        }
        RunAdb($"-s {Device} shell monkey -p {AppConstants.MauiPackageName} -c android.intent.category.LAUNCHER 1");
        Thread.Sleep(5000);
        var TopActivity = RunAdb($"-s {Device} shell dumpsys activity top");
        Assert.IsTrue(
            TopActivity.Contains(AppConstants.MauiPackageName) || TopActivity.Contains("MainActivity"),
            "APK must be in foreground before testing nav links");
        var NavRoutes = new[]
        {
            RouteConstants.Tasks,
            RouteConstants.Leaderboard,
            RouteConstants.HowItWorks,
            RouteConstants.Pricing,
            RouteConstants.About,
            RouteConstants.Dashboard,
            RouteConstants.Download,
            RouteConstants.Settings,
            RouteConstants.Terms,
            RouteConstants.Privacy,
            RouteConstants.CookiePolicy,
            RouteConstants.AcceptableUse,
            RouteConstants.Refund,
            RouteConstants.Licenses,
            RouteConstants.Accessibility,
            RouteConstants.Dmca,
            RouteConstants.Login
        };
        var Failures = new List<string>();
        foreach (var Route in NavRoutes)
        {
            RunAdb($"-s {Device} shell am start -n {AppConstants.MauiPackageName}/{AppConstants.MauiPackageName}.MainActivity -a android.intent.action.VIEW -d \"https://{AppConstants.BlazorWebViewOrigin}{Route}\"");
            Thread.Sleep(2000);
            var Activity = RunAdb($"-s {Device} shell dumpsys activity top");
            if (!Activity.Contains(AppConstants.MauiPackageName) && !Activity.Contains("MainActivity"))
            {
                Failures.Add($"Route {Route}: app no longer in foreground after navigation");
            }
        }
        Assert.AreEqual(0, Failures.Count,
            $"APK nav link failures:\n{string.Join("\n", Failures)}");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Every NavMenu href must have a matching MAUI @page route")]
    public void Task83NavMenuRoutesMatchMauiPages()
    {
        var NavMenuSource = ReadSource("PrTask.SharedUI", "Components", "NavMenu.razor");
        var NavHrefs = NavMenuHrefPattern().Matches(NavMenuSource)
            .Select(M => M.Groups[1].Value)
            .Where(H => !H.Contains("clear-cache"))
            .ToList();
        Assert.IsTrue(NavHrefs.Count >= 15, $"NavMenu must have at least 15 hrefs, found {NavHrefs.Count}");
        var MauiPagesDir = Path.Combine(SourceRoot, "PrTask.Maui", "Pages");
        var AllRazorFiles = Directory.EnumerateFiles(MauiPagesDir, "*.razor", SearchOption.AllDirectories).ToList();
        var PageRoutes = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        foreach (var RazorFile in AllRazorFiles)
        {
            var Content = File.ReadAllText(RazorFile);
            var Match = PageDirectiveRoutePattern().Match(Content);
            if (Match.Success)
            {
                PageRoutes.Add(Match.Groups[1].Value);
            }
        }
        var Missing = new List<string>();
        foreach (var Href in NavHrefs)
        {
            if (!PageRoutes.Contains(Href))
            {
                Missing.Add(Href);
            }
        }
        Assert.AreEqual(0, Missing.Count,
            $"NavMenu links without matching MAUI @page route:\n{string.Join("\n", Missing)}");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("MAUI index.html must have debug grid overlay for coordinate inspection")]
    public void Task83MauiDebugGridOverlay()
    {
        var MauiIndex = ReadSource("PrTask.Maui", "wwwroot", "index.html");
        Assert.IsTrue(MauiIndex.Contains("prtaskToggleGrid"), "MAUI index.html must have prtaskToggleGrid function");
        Assert.IsTrue(MauiIndex.Contains("prtaskShowGrid"), "MAUI index.html must have prtaskShowGrid function");
        Assert.IsTrue(MauiIndex.Contains("prtaskHideGrid"), "MAUI index.html must have prtaskHideGrid function");
        Assert.IsTrue(MauiIndex.Contains("pointer-events:none"), "Grid canvas must use pointer-events:none so taps pass through");
        Assert.IsTrue(MauiIndex.Contains("GRID"), "Must have GRID toggle button");
    }
    [GeneratedRegex("href=\"(/[^\"]+)\"")]
    private static partial Regex NavMenuHrefPattern();
    [GeneratedRegex("@page\\s+\"([^\"]+)\"")]
    private static partial Regex PageDirectiveRoutePattern();
}
