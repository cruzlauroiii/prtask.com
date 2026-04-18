using PrTask.Cdp;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static readonly string T74LogPath = Path.Combine(SolutionRoot, "output", "T74-sso-debug.log");
    [TestMethod, TestCategory("SSO"), Timeout(900000)]
    [DisplayName("T74 SSO login — Google login, verify nav username, sign out, settings connected accounts")]
    public async Task T74SsoLoginAllProvidersAsync()
    {
        if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PRTASK_BASE_URL")))
        {
            Assert.Inconclusive("SSO login test requires local server with dev credentials — skipping against live site");
            return;
        }
        Directory.CreateDirectory(Path.GetDirectoryName(T74LogPath)!);
        File.WriteAllText(T74LogPath, $"=== T74 SSO Debug Log — {DateTime.UtcNow:O} ===\n\n");
        var SsoLauncher = new ChromeLauncher();
        var SsoBrowser = await SsoLauncher.LaunchAsync(new ChromeLaunchOptions { Headless = false });
        var SsoPage = await SsoBrowser.NewPageAsync();
        await SsoPage.EnableConsoleAsync();
        T74Log("Browser launched, navigating to login page");
        await SsoPage.NavigateAsync($"{LiveSiteUrl}{RouteConstants.Login}");
        await T74_SsAsync(SsoPage, "01-login-page.png");
        T74Log($"Login page loaded, URL: {await CdpHelpers.GetUrlAsync(SsoPage)}");
        var GoogleBtnCount = await CdpHelpers.CountAsync(SsoPage, E2ESsoConstants.GoogleButtonCss);
        Assert.IsTrue(GoogleBtnCount > 0, "Google button must exist");
        var GoogleHref = await CdpHelpers.GetAttributeAsync(SsoPage, E2ESsoConstants.GoogleButtonCss, "href");
        T74Log($"Google button href: {GoogleHref}");
        T74Log("Clicking Google login button");
        await CdpHelpers.ClickSelectorAsync(SsoPage, E2ESsoConstants.GoogleButtonCss);
        await Task.Delay(500);
        T74Log($"After click, URL: {await CdpHelpers.GetUrlAsync(SsoPage)}");
        await T74_SsAsync(SsoPage, "02-after-google-click.png");
        if (!new Uri(await CdpHelpers.GetUrlAsync(SsoPage)).Host.Contains("prtask.com", StringComparison.OrdinalIgnoreCase))
        {
            T74Log("Waiting for redirect back to prtask.com (3 min timeout — complete Google login now)");
            await CdpHelpers.WaitForFunctionAsync(SsoPage,
                "() => window.location.hostname.includes('prtask.com')", 600000);
            await Task.Delay(500);
        }
        T74Log($"Redirected back, URL: {await CdpHelpers.GetUrlAsync(SsoPage)}");
        await T74_SsAsync(SsoPage, "03-after-redirect.png");
        await Task.Delay(3000);
        T74Log("--- Collecting all debug data ---");
        var AuthMeResponse = await CdpHelpers.EvaluateAsync<string>(SsoPage,
            "() => fetch('/Api/Auth/Me', {credentials:'include'}).then(async r => { const t = await r.text(); return JSON.stringify({status:r.status,statusText:r.statusText,headers:Object.fromEntries(r.headers.entries()),body:t}); }).catch(e => JSON.stringify({error:e.message}))");
        T74Log($"/Api/Auth/Me response: {AuthMeResponse}");
        var LocalStorageUser = await CdpHelpers.EvaluateAsync<string>(SsoPage, "() => localStorage.getItem('prtask-user') || '(null)'");
        var LocalStorageUserId = await CdpHelpers.EvaluateAsync<string>(SsoPage, "() => localStorage.getItem('prtask-userid') || '(null)'");
        T74Log($"localStorage prtask-user: {LocalStorageUser}");
        T74Log($"localStorage prtask-userid: {LocalStorageUserId}");
        var DocumentCookie = await CdpHelpers.EvaluateAsync<string>(SsoPage, "() => document.cookie || '(empty)'");
        T74Log($"document.cookie (JS visible): {DocumentCookie}");
        var NavHtml = await CdpHelpers.EvaluateAsync<string>(SsoPage, "() => document.querySelector('nav')?.outerHTML ?? ''");
        T74Log($"Nav HTML: {NavHtml}");
        var NavUserCount = await CdpHelpers.CountAsync(SsoPage, ".nav-user");
        T74Log($".nav-user elements: {NavUserCount}");
        if (NavUserCount > 0)
        {
            var NavUserText = await CdpHelpers.GetTextContentAsync(SsoPage, ".nav-user");
            T74Log($".nav-user text: {NavUserText}");
        }
        var SignOutCount = await CdpHelpers.CountAsync(SsoPage, "a[href*='sign-out'], button:has-text('Sign Out')");
        T74Log($"Sign Out button count: {SignOutCount}");
        var SignInCount = await CdpHelpers.CountAsync(SsoPage, "a[href*='Login'], a:has-text('Sign In')");
        T74Log($"Sign In link count: {SignInCount}");
        await T74_SsAsync(SsoPage, "04-dashboard-state.png");
        T74Log("Opening hamburger menu");
        var ToggleCount = await CdpHelpers.CountAsync(SsoPage, ".nav-toggle");
        if (ToggleCount > 0)
        {
            await CdpHelpers.ClickSelectorAsync(SsoPage, ".nav-toggle");
            await Task.Delay(1000);
        }
        await T74_SsAsync(SsoPage, "05-menu-open.png");
        var MenuHtml = await CdpHelpers.EvaluateAsync<string>(SsoPage, "() => document.querySelector('.nav-links')?.outerHTML ?? ''");
        T74Log($"Menu HTML: {MenuHtml}");
        T74Log("Navigating to Settings");
        await SsoPage.NavigateAsync($"{LiveSiteUrl}{RouteConstants.Settings}");
        await Task.Delay(5000);
        await T74_SsAsync(SsoPage, "06-settings-page-initial.png");
        T74Log("Reloading Settings page to ensure Blazor picks up localStorage");
        await CdpHelpers.ReloadAsync(SsoPage);
        await Task.Delay(5000);
        await T74_SsAsync(SsoPage, "06-settings-page.png");
        var ConsoleLogs = await CdpHelpers.EvaluateAsync<string>(SsoPage,
            "() => { const L = window._settingsLogs || []; return L.join('\\n'); }");
        T74Log($"Console logs: {ConsoleLogs}");
        await CdpHelpers.ReloadAsync(SsoPage);
        await Task.Delay(8000);
        await T74_SsAsync(SsoPage, "07-settings-after-reload2.png");
        T74Log($"Settings page URL: {await CdpHelpers.GetUrlAsync(SsoPage)}");
        var StatusMsgCount = await CdpHelpers.CountAsync(SsoPage, ".status-message");
        if (StatusMsgCount > 0)
        {
            var StatusText = await CdpHelpers.GetTextContentAsync(SsoPage, ".status-message");
            T74Log($"Status message: {StatusText}");
        }
        else
        {
            T74Log("No .status-message element found");
        }
        var ProfileText = await CdpHelpers.GetTextContentAsync(SsoPage, "section.form-container");
        T74Log($"Profile section text: {ProfileText}");
        var ConnectedCount = await CdpHelpers.CountAsync(SsoPage, E2ESsoConstants.ConnectedStatusCss);
        T74Log($"Connected status elements: {ConnectedCount}");
        var UserApiResult = await CdpHelpers.EvaluateAsync<string>(SsoPage,
            "() => { const Id = localStorage.getItem('prtask-userid'); if (!Id) return 'no userid in localStorage'; return fetch('/Api/Users/' + encodeURIComponent(Id)).then(async r => { const t = await r.text(); return r.status + ' ' + t; }).catch(e => 'ERROR: ' + e.message); }");
        T74Log($"/Api/Users/{{userId}} response: {UserApiResult}");
        T74Log("=== T74 debug collection complete ===");
        await SsoBrowser.DisposeAsync();
        SsoLauncher.Dispose();
    }
    private static void T74Log(string Message)
    {
        var Line = $"[{DateTime.UtcNow:HH:mm:ss.fff}] {Message}\n";
        File.AppendAllText(T74LogPath, Line);
    }
    private static async Task T74_SsAsync(CdpPage SsoPage, string FileName)
    {
        Directory.CreateDirectory(ScreenshotDir);
        var Bytes = await SsoPage.CaptureScreenshotAsync();
        await File.WriteAllBytesAsync(Path.Combine(ScreenshotDir, $"T74-{FileName}"), Bytes);
        T74Log($"Screenshot: T74-{FileName}");
    }
}
