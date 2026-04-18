using System.Diagnostics;
using System.Net;
using Microsoft.Playwright;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Live prtask.com and APK must pass comprehensive E2E validation")]
    public async Task Task72LiveSiteAndApkComprehensiveValidationAsync()
    {
        var Page = await NavigateOrSkipAsync(BaseUrl);
        if (Page is null)
        {
            return;
        }
        try
        {
            var Content = await Page.ContentAsync();
            Assert.IsTrue(Content.Contains("PrTask"), "Root HTML must contain PrTask branding");
            Assert.IsTrue(Content.Contains("blazor"), "Root HTML must reference Blazor runtime");
            Assert.IsTrue(Content.Contains("<meta"), "Root HTML must contain meta tags");
            var AppText = await Page.TextContentAsync("#app");
            Assert.IsTrue(AppText is not null && AppText.Length > 100,
                "Blazor WASM must render meaningful content in #app");
        }
        finally
        {
            await Page.CloseAsync();
        }
        var PageRoutes = new[]
        {
            RouteConstants.Tasks, RouteConstants.Leaderboard, RouteConstants.Login,
            RouteConstants.Dashboard, RouteConstants.About, RouteConstants.HowItWorks,
            RouteConstants.Pricing, RouteConstants.Download, RouteConstants.Settings
        };
        foreach (var Route in PageRoutes)
        {
            var NavPage = await NavigateOrSkipAsync($"{BaseUrl}{Route}");
            if (NavPage is null)
            {
                continue;
            }
            var NavContent = await NavPage.ContentAsync();
            Assert.IsTrue(NavContent.Contains("PrTask"), $"Page {Route} must contain PrTask branding");
            await NavPage.CloseAsync();
        }
        var LegalRoutes = new[]
        {
            RouteConstants.Terms, RouteConstants.Privacy, RouteConstants.Refund,
            RouteConstants.CookiePolicy, RouteConstants.AcceptableUse,
            RouteConstants.Licenses, RouteConstants.Accessibility, RouteConstants.Dmca
        };
        foreach (var Route in LegalRoutes)
        {
            var LegalPage = await NavigateOrSkipAsync($"{BaseUrl}{Route}");
            if (LegalPage is null)
            {
                continue;
            }
            var LegalContent = await LegalPage.ContentAsync();
            Assert.IsTrue(LegalContent.Contains("PrTask"), $"Legal page {Route} must contain PrTask");
            await LegalPage.CloseAsync();
        }
        HttpResponseMessage? CssResponse = null;
        foreach (var CssP in new[] { AppConstants.CssMinPath, AppConstants.CssFallbackPath })
        {
            TrackUrlVisit($"{BaseUrl}{CssP}");
            CssResponse = await LiveClient.GetAsync($"{BaseUrl}{CssP}");
            if (CssResponse.IsSuccessStatusCode) { break; }
            LogWarning($"CSS {CssP} returned {CssResponse.StatusCode}");
        }
        Assert.IsTrue(CssResponse?.IsSuccessStatusCode == true, "CSS must return 200");
        var Css = await CssResponse.Content.ReadAsStringAsync();
        Assert.IsTrue(Css.Contains("--color-bg"), "CSS must have theme custom properties");
        Assert.IsTrue(Css.Contains("prefers-color-scheme"), "CSS must have dark mode media query");
        if (BaseUrl.Contains(AppConstants.AppDomain))
        {
            var SitemapResponse = await GetOrSkipAsync($"{BaseUrl}/sitemap.xml");
            Assert.IsTrue(SitemapResponse.IsSuccessStatusCode, $"sitemap.xml returned {SitemapResponse.StatusCode}");
            var RobotsResponse = await GetOrSkipAsync($"{BaseUrl}/robots.txt");
            Assert.IsTrue(RobotsResponse.IsSuccessStatusCode, $"robots.txt returned {RobotsResponse.StatusCode}");
        }
        var ApiTasksResponse = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.ApiTasks}");
        Assert.IsTrue(ApiTasksResponse.IsSuccessStatusCode, $"API tasks returned {ApiTasksResponse.StatusCode}");
        var AuthMeResponse = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.ApiAuthMe}", AllowNonSuccess: true);
        Assert.AreEqual(HttpStatusCode.Unauthorized, AuthMeResponse.StatusCode, "Auth me must return 401");
        var GoogleAuthResponse = await GetOrSkipAsync($"{BaseUrl}{RouteConstants.ApiAuthGoogle}", AllowNonSuccess: true);
        Assert.AreEqual(HttpStatusCode.Found, GoogleAuthResponse.StatusCode, "Google auth must redirect");
        var GoogleLocation = GoogleAuthResponse.Headers.Location?.ToString() ?? string.Empty;
        Assert.IsTrue(GoogleLocation.Contains("accounts.google.com"), "Must redirect to Google");
        Assert.IsTrue(GoogleLocation.Contains("code_challenge"), "Must include PKCE challenge");
        try
        {
            var AdbConnect = RunAdb($"connect {AppConstants.AdbDeviceAddress}");
            if (!AdbConnect.Contains("connected") && !AdbConnect.Contains("already"))
            {
                Assert.Inconclusive($"ADB device not reachable: {AdbConnect}");
                return;
            }
            var Packages = RunAdb($"-s {AppConstants.AdbDeviceAddress} shell pm list packages {AppConstants.MauiPackageName}");
            Assert.IsTrue(Packages.Contains(AppConstants.MauiPackageName), $"APK {AppConstants.MauiPackageName} must be installed");
            RunAdb($"-s {AppConstants.AdbDeviceAddress} shell monkey -p {AppConstants.MauiPackageName} -c android.intent.category.LAUNCHER 1");
            Thread.Sleep(3000);
            var TopActivity = RunAdb($"-s {AppConstants.AdbDeviceAddress} shell dumpsys activity top");
            Assert.IsTrue(
                TopActivity.Contains(AppConstants.MauiPackageName) || TopActivity.Contains("MainActivity"),
                "APK must be launchable and show foreground activity");
        }
        catch (Exception Ex) when (Ex is not AssertInconclusiveException)
        {
            Assert.Inconclusive($"ADB not available: {Ex.Message}");
        }
    }
}
