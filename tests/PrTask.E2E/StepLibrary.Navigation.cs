using PrTask.Cdp;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static async Task NavigateAndVerifyAsync(string Route, string? ExpectedH1 = null)
    {
        var Url = $"{BaseUrl}{Route}";
        var Page = await NavigateOrSkipAsync(Url);
        Assert.IsNotNull(Page, $"NavigateAndVerify: navigation to {Route} must succeed");
        if (ExpectedH1 is not null)
        {
            var Loaded = await WaitForBlazorAsync(ExpectedH1);
            Assert.IsTrue(Loaded, $"NavigateAndVerify: h1 must contain '{ExpectedH1}' on {Route}");
            var Text = await CdpHelpers.GetTextContentAsync(BrowserPage, "h1");
            Assert.IsTrue(Text.Contains(ExpectedH1, StringComparison.OrdinalIgnoreCase),
                $"NavigateAndVerify: h1 on {Route} must contain '{ExpectedH1}', got '{Text}'");
        }
    }

    private static async Task VerifyPageLoadedAsync(string PageName)
    {
        var ErrorNodes = await BrowserPage.QuerySelectorAllAsync(".blazor-error-boundary, .error-boundary, [data-error='true']");
        Assert.IsTrue(ErrorNodes.Length == 0,
            $"VerifyPageLoaded: {PageName} must have no error boundary");
        var BodyText = await CdpHelpers.GetTextContentAsync(BrowserPage, "body");
        Assert.IsTrue(BodyText.Length > 0,
            $"VerifyPageLoaded: {PageName} body must have content, got {BodyText.Length} chars");
    }

    private static async Task WaitForElementAsync(string Selector, int TimeoutMs = 30000)
    {
        await CdpHelpers.WaitForSelectorAsync(BrowserPage, Selector, TimeoutMs);
        var Nodes = await BrowserPage.QuerySelectorAllAsync(Selector);
        Assert.IsTrue(Nodes.Length > 0,
            $"WaitForElement: '{Selector}' must be visible within {TimeoutMs}ms");
    }

    private static async Task VerifyPageLayoutAsync(string Route, string ExpectedH1)
    {
        await NavigateAndVerifyAsync(Route, ExpectedH1);

        var SafeName = Route.Replace("/", "-").TrimStart('-');
        if (string.IsNullOrEmpty(SafeName)) { SafeName = "home"; }

        var NavCount = await CdpHelpers.CountAsync(BrowserPage, "nav");
        Assert.IsTrue(NavCount > 0,
            $"VerifyPageLayout: {SafeName} must have nav element");

        var NavText = await CdpHelpers.GetTextContentAsync(BrowserPage, "nav");
        Assert.IsTrue(NavText.Contains(NavConstants.BrandName),
            $"VerifyPageLayout: {SafeName} nav must contain brand name '{NavConstants.BrandName}'");

        var HasTasksLink = await CdpHelpers.CountAsync(BrowserPage, $"nav a[href='{RouteConstants.Tasks}']") > 0;
        var HasMenuIcon = NavText.Contains(NavConstants.MenuIcon);
        var HasLeaderboardLink = await CdpHelpers.CountAsync(BrowserPage, $"nav a[href='{RouteConstants.Leaderboard}']") > 0;
        Assert.IsTrue(HasTasksLink || HasMenuIcon,
            $"VerifyPageLayout: {SafeName} nav must have tasks link or hamburger menu");
        Assert.IsTrue(HasLeaderboardLink || HasMenuIcon,
            $"VerifyPageLayout: {SafeName} nav must have leaderboard link or hamburger menu");

        var FooterCount = await CdpHelpers.CountAsync(BrowserPage, "footer");
        if (FooterCount > 0)
        {
            var FooterText = await CdpHelpers.GetTextContentAsync(BrowserPage, "footer");
            Assert.IsTrue(FooterText.Contains(FooterConstants.Tagline) || FooterText.Contains(NavConstants.BrandName),
                $"VerifyPageLayout: {SafeName} footer must contain tagline or brand name");
            Assert.IsTrue(FooterText.Contains(FooterConstants.PlatformHeading) || FooterText.Contains(FooterConstants.LegalHeading),
                $"VerifyPageLayout: {SafeName} footer must have Platform or Legal heading");
            Assert.IsTrue(FooterText.Contains(FooterConstants.CopyrightText),
                $"VerifyPageLayout: {SafeName} footer must contain copyright text");
        }
    }

    private static async Task NavigateToDiffViewAsync(string Route)
    {
        var Url = $"{BaseUrl}{Route}";
        var Page = await NavigateOrSkipAsync(Url);
        Assert.IsNotNull(Page, $"NavigateToDiffView: navigation to {Route} must succeed");
        var Body = await CdpHelpers.GetTextContentAsync(BrowserPage, "body");
        Assert.IsTrue(Body.Length > 10,
            $"NavigateToDiffView: PR diff page at {Route} must render ({Body.Length} chars)");
    }

    private static async Task VerifyPageOfflineAsync(string Route)
    {
        var Url = $"{BaseUrl}{Route}";
        TrackUrlVisit(Url);
        await BrowserPage.NavigateAsync(Url);
        try { using var Cts = new CancellationTokenSource(30000); await BrowserPage.WaitForLoadAsync(Cts.Token); } catch { }
        await Task.Delay(500);

        await CdpHelpers.SetOfflineAsync(BrowserPage, true);
        var OfflineBody = await CdpHelpers.GetTextContentAsync(BrowserPage, "body");
        Assert.IsTrue(OfflineBody.Length > 10,
            $"VerifyPageOffline: {Route} must render offline ({OfflineBody.Length} chars)");

        await CdpHelpers.SetOfflineAsync(BrowserPage, false);
        await CdpHelpers.ReloadAsync(BrowserPage, 15000);
        var OnlineBody = await CdpHelpers.GetTextContentAsync(BrowserPage, "body");
        Assert.IsTrue(OnlineBody.Length > 10,
            $"VerifyPageOffline: {Route} must sync after coming back online ({OnlineBody.Length} chars)");
    }
}
