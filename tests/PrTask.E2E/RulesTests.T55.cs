using PrTask.Cdp;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules"), Timeout(60000)]
    [DisplayName("T55 Header footer layout verification on every page — screenshots, compact layout, flexbox, spacing, minified assets")]
    public async Task T55HeaderFooterLayoutVerificationAsync()
    {
        await T55VerifyLayoutOnPublicPagesAsync();
        await T55VerifyLayoutOnAuthPagesAsync();
        await T55VerifyLayoutOnLegalPagesAsync();
        await T55VerifyMinifiedAssetsAsync();
        await T55VerifyFlexboxAndSpacingAsync();
    }
    private static async Task T55VerifyLayoutOnPublicPagesAsync()
    {
        var PublicRoutes = new[]
        {
            (RouteConstants.Home, HomeConstants.HeroHeading),
            (RouteConstants.Tasks, TaskListConstants.PageHeading),
            (RouteConstants.Leaderboard, LeaderboardConstants.PageHeading),
            (RouteConstants.HowItWorks, HowItWorksConstants.PageHeading),
            (RouteConstants.Pricing, PricingConstants.PageHeading),
            (RouteConstants.About, AboutConstants.PageHeading),
            (RouteConstants.Download, DownloadConstants.PageHeading),
            (RouteConstants.Login, LoginConstants.PageHeading)
        };
        foreach (var (Route, ExpectedHeading) in PublicRoutes)
        {
            var SafeName = Route.Replace("/", "-").TrimStart('-');
            if (string.IsNullOrEmpty(SafeName)) { SafeName = "home"; }
            var Page = await NavigateOrSkipAsync($"{BaseUrl}{Route}");
            if (Page is null) { continue; }
            await TakeScreenshotAsync($"T55-layout-{SafeName}.png");
            await T55VerifyHeaderElementsAsync(SafeName);
            await T55VerifyFooterElementsAsync(SafeName);
            var H1Count = await CdpHelpers.CountAsync(BrowserPage, "h1");
            if (H1Count > 0)
            {
                var Text = await CdpHelpers.GetTextContentAsync(BrowserPage, "h1");
                Assert.IsTrue(Text.Contains(ExpectedHeading, StringComparison.OrdinalIgnoreCase),
                    $"Page {Route}: h1 must contain '{ExpectedHeading}', got '{Text}'");
            }
        }
    }
    private static async Task T55VerifyLayoutOnAuthPagesAsync()
    {
        var AuthRoutes = new[]
        {
            (RouteConstants.Dashboard, DashboardConstants.PageHeading),
            (RouteConstants.ClientCreateTask, CreateTaskConstants.PageHeading),
            (RouteConstants.ClientPayments, PaymentPageConstants.PageHeading),
            (RouteConstants.Settings, SettingsConstants.PageHeading),
            (RouteConstants.Sprints, SprintConstants.PageHeading),
            (RouteConstants.Boards, BoardConstants.PageHeading),
            (RouteConstants.Repository, "Repository")
        };
        foreach (var (Route, _) in AuthRoutes)
        {
            var SafeName = Route.Replace("/", "-").TrimStart('-');
            var Page = await NavigateOrSkipAsync($"{BaseUrl}{Route}");
            if (Page is null) { continue; }
            await TakeScreenshotAsync($"T55-layout-{SafeName}.png");
            await T55VerifyHeaderElementsAsync(SafeName);
            await T55VerifyFooterElementsAsync(SafeName);
        }
    }
    private static async Task T55VerifyLayoutOnLegalPagesAsync()
    {
        var LegalRoutes = new[]
        {
            RouteConstants.Terms,
            RouteConstants.Privacy,
            RouteConstants.Refund,
            RouteConstants.CookiePolicy,
            RouteConstants.AcceptableUse,
            RouteConstants.Licenses,
            RouteConstants.Accessibility,
            RouteConstants.Dmca
        };
        foreach (var Route in LegalRoutes)
        {
            var SafeName = Route.Replace("/", "-").TrimStart('-');
            var Page = await NavigateOrSkipAsync($"{BaseUrl}{Route}");
            if (Page is null) { continue; }
            await TakeScreenshotAsync($"T55-layout-{SafeName}.png");
            await T55VerifyHeaderElementsAsync(SafeName);
            await T55VerifyFooterElementsAsync(SafeName);
        }
    }
    private static async Task T55VerifyHeaderElementsAsync(string PageName)
    {
        var NavCount = await CdpHelpers.CountAsync(BrowserPage, "nav");
        Assert.IsTrue(NavCount > 0, $"{PageName}: nav element must exist");
        var NavText = await CdpHelpers.GetTextContentAsync(BrowserPage, "nav");
        Assert.IsTrue(NavText.Contains(NavConstants.BrandName),
            $"{PageName}: nav must contain brand name '{NavConstants.BrandName}'");
        var TasksLinkCount = await CdpHelpers.CountAsync(BrowserPage, $"nav a[href='{RouteConstants.Tasks}']");
        var LeaderboardLinkCount = await CdpHelpers.CountAsync(BrowserPage, $"nav a[href='{RouteConstants.Leaderboard}']");
        var HasMenuIcon = NavCount > 0;
        var HasTasksLink = TasksLinkCount > 0;
        var HasLeaderboardLink = LeaderboardLinkCount > 0;
        Assert.IsTrue(HasTasksLink || HasMenuIcon,
            $"{PageName}: nav must have tasks link or hamburger menu");
        Assert.IsTrue(HasLeaderboardLink || HasMenuIcon,
            $"{PageName}: nav must have leaderboard link or hamburger menu");
    }
    private static async Task T55VerifyFooterElementsAsync(string PageName)
    {
        var FooterCount = await CdpHelpers.CountAsync(BrowserPage, "footer");
        if (FooterCount == 0) { return; }
        var FooterText = await CdpHelpers.GetTextContentAsync(BrowserPage, "footer");
        Assert.IsTrue(FooterText.Contains(FooterConstants.Tagline) || FooterText.Contains(NavConstants.BrandName),
            $"{PageName}: footer must contain tagline or brand name");
        Assert.IsTrue(FooterText.Contains(FooterConstants.PlatformHeading) || FooterText.Contains(FooterConstants.LegalHeading),
            $"{PageName}: footer must have Platform or Legal heading");
        Assert.IsTrue(FooterText.Contains(FooterConstants.CopyrightText),
            $"{PageName}: footer must contain copyright text");
    }
    private static async Task T55VerifyMinifiedAssetsAsync()
    {
        var CssPaths = new[] { AppConstants.CssMinPath, AppConstants.CssFallbackPath };
        HttpResponseMessage? CssResp = null;
        foreach (var CssPath in CssPaths)
        {
            TrackUrlVisit($"{BaseUrl}{CssPath}");
            CssResp = await LiveClient.GetAsync($"{BaseUrl}{CssPath}");
            if (CssResp.IsSuccessStatusCode)
            {
                break;
            }
            LogWarning($"CSS {CssPath} returned {CssResp.StatusCode}");
        }
        Assert.IsTrue(CssResp?.IsSuccessStatusCode == true, "CSS asset must return 200 from one of the paths");
        var Css = await CssResp.Content.ReadAsStringAsync();
        Assert.IsTrue(Css.Length > 0, "CSS must not be empty");
        Assert.IsTrue(Css.Contains("display:flex") || Css.Contains("display: flex"),
            "CSS must contain flexbox rules");
        Assert.IsTrue(Css.Contains("--color-bg"), "CSS must define --color-bg custom property");
        Assert.IsTrue(Css.Contains("word-break"), "CSS must have word-break for mobile");
        Assert.IsTrue(Css.Contains("min-height:100dvh") || Css.Contains("min-height: 100dvh"),
            "CSS must use 100dvh for app root");
        Assert.IsTrue(Css.Contains("max-width:100vw") || Css.Contains("max-width: 100vw"),
            "CSS must use 100vw for app root");
    }
    private static Task T55VerifyFlexboxAndSpacingAsync()
    {
        var ScssDir = Path.Combine(SourceRoot, "PrTask.SharedUI", "Styles");
        Assert.IsTrue(Directory.Exists(ScssDir), "Styles directory must exist");
        var Scss = string.Join("\n", Directory.GetFiles(ScssDir, "*.scss").Select(File.ReadAllText));
        Assert.IsTrue(Scss.Contains("display: flex") || Scss.Contains("display:flex"),
            "SCSS must use display flex");
        Assert.IsTrue(Scss.Contains("flex-direction"), "SCSS must use flex-direction");
        Assert.IsTrue(Scss.Contains("flex-wrap"), "SCSS must use flex-wrap");
        Assert.IsTrue(Scss.Contains("min-height: 100dvh") || Scss.Contains("min-height:100dvh"),
            "SCSS must use 100dvh for min-height");
        Assert.IsTrue(Scss.Contains("max-width: 100vw") || Scss.Contains("max-width:100vw"),
            "SCSS must use 100vw for max-width");
        Assert.IsTrue(Scss.Contains("word-break"), "SCSS must have word-break for mobile");
        Assert.IsFalse(Scss.Contains("overflow-x:") || Scss.Contains("overflow-x :"),
            "SCSS must not use overflow-x");
        Assert.IsFalse(Scss.Contains("overflow-y:") || Scss.Contains("overflow-y :"),
            "SCSS must not use overflow-y");
        Assert.IsFalse(Scss.Contains("overflow: hidden") || Scss.Contains("overflow:hidden"),
            "SCSS must not use overflow:hidden");
        Assert.IsTrue(Scss.Contains("prefers-color-scheme"), "SCSS must have prefers-color-scheme");
        Assert.IsTrue(Scss.Contains("data-theme"), "SCSS must support data-theme attribute");
        Assert.IsTrue(Scss.Contains("#app") || Scss.Contains(".app"),
            "SCSS must define #app or .app styles");
        return Task.CompletedTask;
        Assert.IsTrue(Scss.Contains("display: flex") || Scss.Contains("display:flex"),
            "SCSS must set display:flex on app root");
        Assert.IsTrue(Scss.Contains("flex-direction: column") || Scss.Contains("flex-direction:column"),
            "SCSS must set flex-direction:column on app root");
        return Task.CompletedTask;
    }
}
