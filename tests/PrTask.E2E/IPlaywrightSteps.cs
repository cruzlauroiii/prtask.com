using PrTask.Cdp;
namespace PrTask.E2E;
public interface IPlaywrightSteps
{
    string Platform { get; }
    string PlatformUrl { get; }
    CdpPage Page { get; }
    CdpBrowser Browser { get; }

    Task NavigateAndVerifyAsync(string Route, string? ExpectedH1 = null);
    Task FillTaskFormAsync(string TitleSelector, string Title, string DescriptionSelector,
        string Description, string RepoUrlSelector, string RepoUrl, string BountySelector, string Bounty);
    Task VerifyElementAsync(string Selector, string AssertionLabel, int TimeoutMs = 30000);
    Task VerifyPageLoadedAsync(string PageName);
    Task ClickElementAsync(string Selector, string StepLabel);
    Task TakeScreenshotAsync(string FileName);
    Task VerifyBodyHasContentAsync(string StepLabel, int MinLength = 10);
}
