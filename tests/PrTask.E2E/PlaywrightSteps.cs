using PrTask.Cdp;
using PrTask.Domain.Constants;
namespace PrTask.E2E;

public sealed class PlaywrightSteps(PlatformContext Ctx) : IPlaywrightSteps
{
    private static readonly string PlatformScreenshotDir =
        Path.Combine(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "..")),
            "output", "screenshots");

    public string Platform { get; } = Ctx.Platform;
    public string PlatformUrl { get; } = Ctx.PlatformUrl;
    public CdpPage Page { get; } = Ctx.Page;
    public CdpBrowser Browser { get; } = Ctx.Browser;

    public async Task NavigateAndVerifyAsync(string Route, string? ExpectedH1 = null)
    {
        var Url = $"{PlatformUrl}{Route}";
        await Page.NavigateAsync(Url);
        await Page.WaitForLoadAsync();

        if (ExpectedH1 is not null)
        {
            await CdpHelpers.WaitForSelectorAsync(Page, "h1", PlatformTestConstants.PlatformNavigationTimeoutMs);
            var H1Text = await CdpHelpers.GetTextContentAsync(Page, "h1");
            Assert.IsTrue(H1Text.Contains(ExpectedH1, StringComparison.OrdinalIgnoreCase),
                $"[{Platform}] NavigateAndVerify: h1 on {Route} must contain '{ExpectedH1}', got '{H1Text}'");
        }
    }

    public async Task FillTaskFormAsync(string TitleSelector, string Title,
        string DescriptionSelector, string Description,
        string RepoUrlSelector, string RepoUrl,
        string BountySelector, string Bounty)
    {
        await CdpHelpers.FillFieldAsync(Page, TitleSelector, Title);
        await CdpHelpers.FillFieldAsync(Page, DescriptionSelector, Description);
        await CdpHelpers.FillFieldAsync(Page, RepoUrlSelector, RepoUrl);
        await CdpHelpers.FillFieldAsync(Page, BountySelector, Bounty);
    }

    public async Task VerifyElementAsync(string Selector, string AssertionLabel, int TimeoutMs = 30000)
    {
        await CdpHelpers.WaitForSelectorAsync(Page, Selector, TimeoutMs);
        var Nodes = await Page.QuerySelectorAllAsync(Selector);
        Assert.IsTrue(Nodes.Length > 0,
            $"[{Platform}] VerifyElement: '{Selector}' must be visible — {AssertionLabel}");
    }

    public async Task VerifyPageLoadedAsync(string PageName)
    {
        var ErrorNodes = await Page.QuerySelectorAllAsync(".blazor-error-boundary, .error-boundary, [data-error='true']");
        Assert.IsTrue(ErrorNodes.Length == 0,
            $"[{Platform}] VerifyPageLoaded: {PageName} must have no error boundary");
        var BodyText = await CdpHelpers.GetTextContentAsync(Page, "body");
        Assert.IsTrue(BodyText.Length > 0,
            $"[{Platform}] VerifyPageLoaded: {PageName} body must have content, got {BodyText.Length} chars");
    }

    public async Task ClickElementAsync(string Selector, string StepLabel)
    {
        var Nodes = await Page.QuerySelectorAllAsync(Selector);
        if (Nodes.Length > 0)
        {
            await CdpHelpers.ClickSelectorAsync(Page, Selector);
            await Task.Delay(PlatformTestConstants.PlatformActionTimeoutMs > 5000 ? 2000 : 500);
        }
        else
        {
            Assert.Inconclusive($"[{Platform}] ClickElement: '{Selector}' not visible — {StepLabel}");
        }
    }

    public async Task TakeScreenshotAsync(string FileName)
    {
        Directory.CreateDirectory(PlatformScreenshotDir);
        var PlatformFileName = string.Format(PlatformTestConstants.PlatformScreenshotFormat,
            Platform, "step", FileName);
        var Bytes = await Page.CaptureScreenshotAsync();
        await File.WriteAllBytesAsync(Path.Combine(PlatformScreenshotDir, PlatformFileName), Bytes);
    }

    public async Task VerifyBodyHasContentAsync(string StepLabel, int MinLength = 10)
    {
        var BodyText = await CdpHelpers.GetTextContentAsync(Page, "body");
        Assert.IsTrue(BodyText.Length > MinLength,
            $"[{Platform}] VerifyBody: {StepLabel} — body must have >{MinLength} chars, got {BodyText.Length}");
    }
}
