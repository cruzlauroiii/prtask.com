using Microsoft.Playwright;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Playwright E2E full workflow 10 steps with screenshots")]
    public async Task FullWorkflowWithScreenshotsAsync()
    {
        Directory.CreateDirectory(ScreenshotDir);
        await Step1LoginGoogleSsoAsync();
        await Step2CreateTaskAsync();
        await Step3CheckTaskListAsync();
        await Step4SubmitPrAsync();
        await Step5CheckDiffViewerAsync();
        await Step6ReviewCommentsAsync();
        await Step7ApprovePrPayMayaAsync();
        await Step8PaymentHistoryAsync();
        await Step9WithdrawSettingsAsync();
        Step10VerifyAllScreenshots();
    }
    private static async Task NavigateAndWaitAsync(string Url, string ExpectedH1)
    {
        await BrowserPage.GotoAsync(Url, new PageGotoOptions { Timeout = 60000, WaitUntil = WaitUntilState.NetworkIdle });
        var Found = await WaitForBlazorAsync(ExpectedH1);
        if (!Found)
        {
            var SafeName = ExpectedH1.Replace(" ", "-").Replace("'", string.Empty);
            await TakeScreenshotAsync($"FAIL-{SafeName}.png");
            var ActualH1 = "N/A";
            try { ActualH1 = await BrowserPage.Locator("h1").TextContentAsync(); } catch { }
            Assert.Fail($"Page '{Url}': expected h1 '{ExpectedH1}', got '{ActualH1}'. See FAIL-{SafeName}.png");
        }
    }
    private static async Task Step1LoginGoogleSsoAsync()
    {
        await NavigateAndWaitAsync($"{BaseUrl}{RouteConstants.Login}", "Sign In");
        await TakeScreenshotAsync("01-login-page.png");
        var GoogleBtn = BrowserPage.Locator("a.google-login");
        Assert.IsTrue(await GoogleBtn.IsVisibleAsync(), "Step1: Google SSO button must be visible");
        var GoogleHref = await GoogleBtn.GetAttributeAsync("href");
        Assert.IsTrue(GoogleHref is not null && GoogleHref.Contains(RouteConstants.ApiAuthGoogle),
            $"Step1: Google href must contain {RouteConstants.ApiAuthGoogle}, got '{GoogleHref}'");
        Assert.IsTrue(await BrowserPage.Locator("a.github-login").IsVisibleAsync(), "Step1: GitHub button visible");
        Assert.IsTrue(await BrowserPage.Locator("a.azure-login").IsVisibleAsync(), "Step1: Azure button visible");
        Assert.IsTrue(await BrowserPage.Locator("a.okta-login").IsVisibleAsync(), "Step1: Okta button visible");
        var AuthResp = await GetOrSkipAsync($"{LiveSiteUrl}{RouteConstants.ApiAuthGoogle}");
        Assert.AreEqual(HttpStatusCode.Found, AuthResp.StatusCode, "Step1: Must get 302");
        var Loc = AuthResp.Headers.Location?.ToString() ?? string.Empty;
        Assert.IsTrue(Loc.Contains("accounts.google.com"), "Step1: Must redirect to Google");
        Assert.IsTrue(Loc.Contains("code_challenge"), "Step1: Must have PKCE code_challenge");
    }
    private static async Task Step2CreateTaskAsync()
    {
        await NavigateAndWaitAsync($"{BaseUrl}{RouteConstants.ClientCreateTask}", "Create a New Task");
        Assert.IsTrue(await BrowserPage.Locator("input#Title").IsVisibleAsync(), "Step2: Title input visible");
        Assert.IsTrue(await BrowserPage.Locator("textarea#Description").IsVisibleAsync(), "Step2: Description visible");
        Assert.IsTrue(await BrowserPage.Locator("input#RepoUrl").IsVisibleAsync(), "Step2: RepoUrl visible");
        Assert.IsTrue(await BrowserPage.Locator("select#Complexity").IsVisibleAsync(), "Step2: Complexity visible");
        Assert.IsTrue(await BrowserPage.Locator("input#BountyAmount").IsVisibleAsync(), "Step2: BountyAmount visible");
        await BrowserPage.Locator("input#Title").FillAsync("Fix auth bug in user service");
        await BrowserPage.Locator("textarea#Description").FillAsync("Login returns 500 when OAuth token expired.");
        await BrowserPage.Locator("input#RepoUrl").FillAsync("https://github.com/prtask/demo-repo");
        await BrowserPage.Locator("select#Complexity").SelectOptionAsync("Medium");
        await BrowserPage.Locator("input#BountyAmount").FillAsync("100");
        await BrowserPage.Locator("input#Tags").FillAsync("csharp, blazor, bug-fix");
        await TakeScreenshotAsync("02-create-task-form.png");
    }
    private static async Task Step3CheckTaskListAsync()
    {
        await NavigateAndWaitAsync($"{BaseUrl}{RouteConstants.Tasks}", "Open Tasks");
        await TakeScreenshotAsync("03-task-list.png");
        var HasGrid = await BrowserPage.Locator(".task-grid").CountAsync() > 0;
        var HasEmpty = await BrowserPage.Locator(".empty-state").CountAsync() > 0;
        Assert.IsTrue(HasGrid || HasEmpty, "Step3: Must show task-grid or empty-state");
    }
}
