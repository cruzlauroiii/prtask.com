using PrTask.Cdp;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static async Task AssertElementVisibleAsync(string Selector, string ErrorMessage)
    {
        var Count = await CdpHelpers.CountAsync(BrowserPage, Selector);
        Assert.IsTrue(Count > 0, $"{ErrorMessage} — selector '{Selector}' not found in DOM");
        var Visible = await CdpHelpers.IsVisibleAsync(BrowserPage, Selector);
        Assert.IsTrue(Visible,
            $"{ErrorMessage} — selector '{Selector}' exists but is not visible");
    }
    private static async Task AssertElementCountAsync(string Selector, int ExpectedCount, string ErrorMessage)
    {
        var ActualCount = await CdpHelpers.CountAsync(BrowserPage, Selector);
        Assert.AreEqual(ExpectedCount, ActualCount,
            $"{ErrorMessage} — selector '{Selector}' expected {ExpectedCount} elements, found {ActualCount}");
    }
    private static async Task AssertTextContainsAsync(string Selector, string ExpectedText, string ErrorMessage)
    {
        var Count = await CdpHelpers.CountAsync(BrowserPage, Selector);
        Assert.IsTrue(Count > 0,
            $"{ErrorMessage} — selector '{Selector}' not found in DOM");
        var ActualText = await CdpHelpers.GetTextContentAsync(BrowserPage, Selector);
        Assert.IsTrue(ActualText.Contains(ExpectedText, StringComparison.OrdinalIgnoreCase),
            $"{ErrorMessage} — expected text containing '{ExpectedText}', got '{ActualText}'");
    }
    private static Task AssertHttpStatusAsync(HttpResponseMessage Response, HttpStatusCode Expected, string ErrorMessage)
    {
        Assert.AreEqual(Expected, Response.StatusCode,
            $"{ErrorMessage} — expected HTTP {(int)Expected} {Expected}, got {(int)Response.StatusCode} {Response.StatusCode}");
        return Task.CompletedTask;
    }
    private static async Task VerifyHeaderElementsAsync(string PageName)
    {
        var NavCount = await CdpHelpers.CountAsync(BrowserPage, "nav");
        Assert.IsTrue(NavCount > 0, $"{PageName}: nav element must exist");
        var NavText = await CdpHelpers.GetTextContentAsync(BrowserPage, "nav");
        Assert.IsTrue(NavText.Contains(NavConstants.BrandName),
            $"{PageName}: nav must contain brand name '{NavConstants.BrandName}'");
        var HasTasksLink = await CdpHelpers.CountAsync(BrowserPage, $"nav a[href='{RouteConstants.Tasks}']") > 0;
        var HasLeaderboardLink = await CdpHelpers.CountAsync(BrowserPage, $"nav a[href='{RouteConstants.Leaderboard}']") > 0;
        var HasMenuIcon = NavText.Contains(NavConstants.MenuIcon);
        Assert.IsTrue(HasTasksLink || HasMenuIcon,
            $"{PageName}: nav must have tasks link or hamburger menu");
        Assert.IsTrue(HasLeaderboardLink || HasMenuIcon,
            $"{PageName}: nav must have leaderboard link or hamburger menu");
    }
    private static async Task VerifyFooterElementsAsync(string PageName)
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
    private static async Task VerifyNoBlazorErrorsAsync(string PageName)
    {
        var ErrorCount = await CdpHelpers.CountAsync(BrowserPage, ".blazor-error-boundary, .error-boundary, [data-error='true']");
        if (ErrorCount > 0)
        {
            var ErrorText = await CdpHelpers.GetTextContentAsync(BrowserPage, ".blazor-error-boundary, .error-boundary, [data-error='true']");
            await TakeScreenshotAsync($"ERROR-{PageName}-{DateTime.UtcNow:HHmmss}.png");
            Assert.Fail($"{PageName}: Blazor error boundary detected — {ErrorText}");
        }
    }
    private static async Task VerifyMinifiedAssetsAsync()
    {
        HttpResponseMessage? CssResp = null;
        foreach (var CssP in new[] { AppConstants.CssMinPath, AppConstants.CssFallbackPath })
        {
            TrackUrlVisit($"{BaseUrl}{CssP}");
            CssResp = await LiveClient.GetAsync($"{BaseUrl}{CssP}");
            if (CssResp.IsSuccessStatusCode) { break; }
            LogWarning($"CSS {CssP} returned {CssResp.StatusCode}");
        }
        Assert.IsTrue(CssResp?.IsSuccessStatusCode == true, "CSS must return 200");
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
    private static async Task AssertElementHasAttributeAsync(string Selector, string Attribute, string ExpectedValue)
    {
        var Count = await CdpHelpers.CountAsync(BrowserPage, Selector);
        Assert.IsTrue(Count > 0,
            $"Element '{Selector}' must exist to check attribute '{Attribute}'");
        var ActualValue = await CdpHelpers.GetAttributeAsync(BrowserPage, Selector, Attribute);
        Assert.AreEqual(ExpectedValue, ActualValue,
            $"Element '{Selector}' attribute '{Attribute}' expected '{ExpectedValue}', got '{ActualValue}'");
    }
}
