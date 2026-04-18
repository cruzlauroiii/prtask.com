using System.Net;
using Microsoft.Playwright;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Playwright E2E 14-step two-user workflow via How It Works")]
    public async Task TwoUserWorkflowAsync()
    {
        Directory.CreateDirectory(ScreenshotDir);
        await WfStep01LoginSsoAsync();
        await WfStep02KycVerificationAsync();
        await WfStep03CreateTaskAsync();
        await WfStep04UploadSourceCodeAsync();
        await WfStep05BrowseTasksAsync();
        await WfStep06ViewTaskDetailAsync();
        await WfStep07EditCodeDiffAsync();
        await WfStep08SubmitPrAsync();
        await WfStep09ReviewDiffAsync();
        await WfStep10AddCommentsAsync();
        await WfStep11ResolveCommentsAsync();
        await WfStep12ApprovePayMayaAsync();
        await WfStep13PaymentHistoryAsync();
        await WfStep14WithdrawalSettingsAsync();
        WfStepVerifyAllScreenshots();
    }
    private static async Task ClickWorkflowLinkAsync(string StepNumber, string ExpectedH1)
    {
        await BrowserPage.GotoAsync(
            $"{BaseUrl}{RouteConstants.HowItWorks}",
            new PageGotoOptions { Timeout = 60000, WaitUntil = WaitUntilState.NetworkIdle });
        await WaitForBlazorAsync("How It Works");
        var Link = BrowserPage.Locator($"a[data-workflow-step='{StepNumber}']");
        Assert.IsTrue(await Link.CountAsync() > 0,
            $"Workflow link step {StepNumber} must exist on How It Works page");
        await Link.ScrollIntoViewIfNeededAsync();
        await Link.ClickAsync();
        await BrowserPage.WaitForLoadStateAsync(LoadState.NetworkIdle,
            new PageWaitForLoadStateOptions { Timeout = 30000 });
        var Found = await WaitForBlazorAsync(ExpectedH1);
        if (!Found)
        {
            var SafeName = ExpectedH1.Replace(" ", "-").Replace("'", string.Empty);
            await TakeScreenshotAsync($"WF-FAIL-{SafeName}.png");
            var ActualH1 = "N/A";
            try { ActualH1 = await BrowserPage.Locator("h1").TextContentAsync(); } catch { }
            Assert.Fail($"Step {StepNumber}: expected h1 '{ExpectedH1}', got '{ActualH1}'");
        }
    }
    private static async Task WfStep01LoginSsoAsync()
    {
        await ClickWorkflowLinkAsync("1", "Sign In");
        await TakeScreenshotAsync("wf-01-login-sso.png");
        Assert.IsTrue(await BrowserPage.Locator("a.google-login").IsVisibleAsync(),
            "WfStep01: Google SSO button visible");
        Assert.IsTrue(await BrowserPage.Locator("a.github-login").IsVisibleAsync(),
            "WfStep01: GitHub SSO button visible");
        Assert.IsTrue(await BrowserPage.Locator("a.azure-login").IsVisibleAsync(),
            "WfStep01: Azure SSO button visible");
        Assert.IsTrue(await BrowserPage.Locator("a.okta-login").IsVisibleAsync(),
            "WfStep01: Okta SSO button visible");
        var GoogleHref = await BrowserPage.Locator("a.google-login").GetAttributeAsync("href");
        Assert.IsTrue(GoogleHref is not null && GoogleHref.Contains(RouteConstants.ApiAuthGoogle),
            "WfStep01: Google href must point to auth endpoint");
        var AuthResp = await GetOrSkipAsync($"{LiveSiteUrl}{RouteConstants.ApiAuthGoogle}");
        Assert.AreEqual(HttpStatusCode.Found, AuthResp.StatusCode, "WfStep01: Must get 302");
        var Location = AuthResp.Headers.Location?.ToString() ?? string.Empty;
        Assert.IsTrue(Location.Contains("accounts.google.com"), "WfStep01: Must redirect to Google");
        Assert.IsTrue(Location.Contains("code_challenge"), "WfStep01: Must have PKCE");
    }
    private static async Task WfStep02KycVerificationAsync()
    {
        await ClickWorkflowLinkAsync("2", "Settings");
        await TakeScreenshotAsync("wf-02-kyc-verification.png");
        var KycHeading = BrowserPage.Locator("h2:has-text('KYC - Identity Verification')");
        Assert.IsTrue(await KycHeading.IsVisibleAsync(), "WfStep02: KYC heading visible");
        Assert.IsTrue(await BrowserPage.Locator("select#KycDocumentType").IsVisibleAsync(),
            "WfStep02: KycDocumentType select visible");
        Assert.IsTrue(await BrowserPage.Locator("input#KycDocumentId").IsVisibleAsync(),
            "WfStep02: KycDocumentId input visible");
        Assert.IsTrue(await BrowserPage.Locator("button:has-text('Submit KYC Verification')").IsVisibleAsync(),
            "WfStep02: Submit KYC button visible");
        await BrowserPage.Locator("select#KycDocumentType").SelectOptionAsync("passport");
        await BrowserPage.Locator("input#KycDocumentId").FillAsync("P1234567890");
        await TakeScreenshotAsync("wf-02-kyc-verification.png");
    }
    private static async Task WfStep03CreateTaskAsync()
    {
        await ClickWorkflowLinkAsync("3", "Create a New Task");
        Assert.IsTrue(await BrowserPage.Locator("input#Title").IsVisibleAsync(),
            "WfStep03: Title input visible");
        Assert.IsTrue(await BrowserPage.Locator("textarea#Description").IsVisibleAsync(),
            "WfStep03: Description visible");
        Assert.IsTrue(await BrowserPage.Locator("input#RepoUrl").IsVisibleAsync(),
            "WfStep03: RepoUrl visible");
        Assert.IsTrue(await BrowserPage.Locator("select#Complexity").IsVisibleAsync(),
            "WfStep03: Complexity visible");
        Assert.IsTrue(await BrowserPage.Locator("input#BountyAmount").IsVisibleAsync(),
            "WfStep03: BountyAmount visible");
        await BrowserPage.Locator("input#Title").FillAsync("Refactor payment module");
        await BrowserPage.Locator("textarea#Description").FillAsync(
            "Refactor the payment service to use the new Maya API v2 endpoints.");
        await BrowserPage.Locator("input#RepoUrl").FillAsync("https://github.com/prtask/demo-repo");
        await BrowserPage.Locator("select#Complexity").SelectOptionAsync("Hard");
        await BrowserPage.Locator("input#BountyAmount").FillAsync("500");
        await BrowserPage.Locator("input#Tags").FillAsync("csharp, payments, refactor");
        await TakeScreenshotAsync("wf-03-create-task.png");
    }
    private static async Task WfStep04UploadSourceCodeAsync()
    {
        await ClickWorkflowLinkAsync("4", "demo-task");
        var UploadHeading = BrowserPage.Locator("h2:has-text('Source Code')");
        if (await UploadHeading.CountAsync() > 0)
        {
            Assert.IsTrue(await UploadHeading.IsVisibleAsync(), "WfStep04: Source Code heading visible");
        }
        Assert.IsTrue(await BrowserPage.Locator("input#SourceCodeUpload").IsVisibleAsync(),
            "WfStep04: File upload input visible");
        Assert.IsTrue(await BrowserPage.Locator("button.upload-btn").IsVisibleAsync(),
            "WfStep04: Upload button visible");
        await TakeScreenshotAsync("wf-04-upload-source.png");
        var Src = ReadSource("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(Src.Contains("source-upload-section"), "WfStep04: Source has upload section");
        Assert.IsTrue(Src.Contains("SourceCodeUpload"), "WfStep04: Source has file input");
    }
    private static async Task WfStep05BrowseTasksAsync()
    {
        await ClickWorkflowLinkAsync("5", "Open Tasks");
        await TakeScreenshotAsync("wf-05-browse-tasks.png");
        var HasGrid = await BrowserPage.Locator(".task-grid").CountAsync() > 0;
        var HasEmpty = await BrowserPage.Locator(".empty-state").CountAsync() > 0;
        Assert.IsTrue(HasGrid || HasEmpty, "WfStep05: Must show task-grid or empty-state");
    }
    private static async Task WfStep06ViewTaskDetailAsync()
    {
        await ClickWorkflowLinkAsync("6", "demo-task");
        await TakeScreenshotAsync("wf-06-task-detail.png");
        var Src = ReadSource("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(Src.Contains("pr-list-section"), "WfStep06: Source has PR list section");
        Assert.IsTrue(Src.Contains("Submit a Pull Request"), "WfStep06: Source has submit PR link");
        Assert.IsTrue(Src.Contains("task-bounty"), "WfStep06: Source has bounty display");
        Assert.IsTrue(Src.Contains("task-complexity"), "WfStep06: Source has complexity display");
    }
    private static async Task WfStep07EditCodeDiffAsync()
    {
        await ClickWorkflowLinkAsync("7", "Pull Request Details");
        await TakeScreenshotAsync("wf-07-diff-editor.png");
        var Src = ReadSource("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(Src.Contains("diff-editor"), "WfStep07: Source has diff-editor section");
        Assert.IsTrue(Src.Contains("diff-editor-textarea"), "WfStep07: Source has editor textarea");
        Assert.IsTrue(Src.Contains("DiffEditorArea"), "WfStep07: Source has DiffEditorArea id");
        Assert.IsTrue(Src.Contains("diff-edit-toggle"), "WfStep07: Source has edit toggle button");
        Assert.IsTrue(Src.Contains("SaveEdits"), "WfStep07: Source has SaveEdits handler");
        var EditToggle = BrowserPage.Locator("button.diff-edit-toggle");
        if (await EditToggle.CountAsync() > 0 && await EditToggle.IsVisibleAsync())
        {
            await EditToggle.ClickAsync();
            await Task.Delay(500);
            await TakeScreenshotAsync("wf-07-diff-editor.png");
        }
    }
    private static async Task WfStep08SubmitPrAsync()
    {
        await ClickWorkflowLinkAsync("8", "Submit Pull Request");
        await TakeScreenshotAsync("wf-08-submit-pr.png");
        var Src = ReadSource("PrTask.SharedUI", "Pages", "SubmitPrPage.razor");
        Assert.IsTrue(Src.Contains("GitHubPrUrl"), "WfStep08: Source has GitHubPrUrl field");
        Assert.IsTrue(Src.Contains("DeveloperId"), "WfStep08: Source has DeveloperId field");
        var PrUrlField = BrowserPage.Locator("input#GitHubPrUrl");
        if (await PrUrlField.CountAsync() > 0 && await PrUrlField.IsVisibleAsync())
        {
            await PrUrlField.FillAsync("https://github.com/prtask/demo-repo/pull/42");
            await BrowserPage.Locator("input#DeveloperId").FillAsync("developer-user-2");
            await TakeScreenshotAsync("wf-08-submit-pr.png");
        }
    }
    private static async Task WfStep09ReviewDiffAsync()
    {
        await ClickWorkflowLinkAsync("9", "Pull Request Details");
        await TakeScreenshotAsync("wf-09-review-diff.png");
        var Src = ReadSource("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(Src.Contains("diff-viewer"), "WfStep09: Source has diff-viewer");
        Assert.IsTrue(Src.Contains("diff-file-tree"), "WfStep09: Source has file tree");
        Assert.IsTrue(Src.Contains("line-add") && Src.Contains("line-del"),
            "WfStep09: Source has add/del lines");
        Assert.IsTrue(Src.Contains("diff-toolbar"), "WfStep09: Source has diff toolbar");
        if (await BrowserPage.Locator(".diff-viewer").CountAsync() > 0)
        {
            Assert.IsTrue(await BrowserPage.Locator(".diff-viewer").IsVisibleAsync(),
                "WfStep09: diff-viewer visible");
        }
    }
    private static async Task WfStep10AddCommentsAsync()
    {
        await ClickWorkflowLinkAsync("10", "Pull Request Details");
        await TakeScreenshotAsync("wf-10-add-comments.png");
        var Src = ReadSource("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(Src.Contains("pr-comments"), "WfStep10: Source has comments section");
        Assert.IsTrue(Src.Contains("inline-comment-form"), "WfStep10: Source has inline comment form");
        Assert.IsTrue(Src.Contains("CommentBody"), "WfStep10: Source has CommentBody textarea");
        Assert.IsTrue(Src.Contains("Add Comment"), "WfStep10: Source has Add Comment button");
        Assert.IsTrue(Src.Contains("StartInlineComment"), "WfStep10: Source has StartInlineComment handler");
        Assert.IsTrue(Src.Contains("SubmitComment"), "WfStep10: Source has SubmitComment handler");
    }
    private static async Task WfStep11ResolveCommentsAsync()
    {
        await ClickWorkflowLinkAsync("11", "Pull Request Details");
        await TakeScreenshotAsync("wf-11-resolve-comments.png");
        var Src = ReadSource("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(Src.Contains("reply-textarea"), "WfStep11: Source has reply textarea");
        Assert.IsTrue(Src.Contains("Resolve"), "WfStep11: Source has Resolve button");
        Assert.IsTrue(Src.Contains("comment-resolved"), "WfStep11: Source has resolved CSS class");
        Assert.IsTrue(Src.Contains("ResolveComment"), "WfStep11: Source has ResolveComment handler");
        Assert.IsTrue(Src.Contains("comment-reply-section"), "WfStep11: Source has reply section");
    }
    private static async Task WfStep12ApprovePayMayaAsync()
    {
        await ClickWorkflowLinkAsync("12", "Pull Request Details");
        await TakeScreenshotAsync("wf-12-approve-pay.png");
        var Src = ReadSource("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(Src.Contains("Approve and Merge"), "WfStep12: Source has Approve button");
        Assert.IsTrue(Src.Contains("maya-checkout"), "WfStep12: Source has maya-checkout section");
        Assert.IsTrue(Src.Contains("checkout-provider"), "WfStep12: Source has checkout provider");
        Assert.IsTrue(Src.Contains("Powered by Maya"), "WfStep12: Source shows Maya branding");
        var Pay = ReadSource("PrTask.Server", "Endpoints", "PaymentEndpoints.cs");
        Assert.IsTrue(Pay.Contains("CreateCheckoutAsync"), "WfStep12: Server has CreateCheckoutAsync");
        var Maya = ReadSource("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(Maya.Contains("SandboxPublicKey") && Maya.Contains("pk-"),
            "WfStep12: Maya has sandbox public key");
        Assert.IsTrue(Maya.Contains("SandboxSecretKey") && Maya.Contains("sk-"),
            "WfStep12: Maya has sandbox secret key");
        var Cards = ReadSource("PrTask.Domain", "Constants", "MayaTestCards.cs");
        Assert.IsTrue(Cards.Contains("VisaNoThreeDsNumber"), "WfStep12: Has Visa test card");
        Assert.IsTrue(Cards.Contains("MasterCardNoThreeDsNumber"), "WfStep12: Has MC test card");
    }
    private static async Task WfStep13PaymentHistoryAsync()
    {
        await ClickWorkflowLinkAsync("13", "Payment History");
        Assert.IsTrue(await BrowserPage.Locator("input#PayerIdInput").IsVisibleAsync(),
            "WfStep13: PayerIdInput visible");
        Assert.IsTrue(await BrowserPage.Locator("button:has-text('Load Payments')").IsVisibleAsync(),
            "WfStep13: Load Payments button visible");
        await BrowserPage.Locator("input#PayerIdInput").FillAsync("developer-user-2");
        await TakeScreenshotAsync("wf-13-payment-history.png");
        var Src = ReadSource("PrTask.SharedUI", "Pages", "Client", "PaymentsPage.razor");
        Assert.IsTrue(Src.Contains("leaderboard-table"), "WfStep13: Source has payment table");
        Assert.IsTrue(Src.Contains("ListByPayerAsync"), "WfStep13: Source calls ListByPayerAsync");
    }
    private static async Task WfStep14WithdrawalSettingsAsync()
    {
        await ClickWorkflowLinkAsync("14", "Settings");
        Assert.IsTrue(await BrowserPage.Locator("h2:has-text('Withdrawal Settings')").IsVisibleAsync(),
            "WfStep14: Withdrawal Settings heading visible");
        var Payout = BrowserPage.Locator("select#PayoutMethod");
        Assert.IsTrue(await Payout.IsVisibleAsync(), "WfStep14: PayoutMethod select visible");
        var Opts = await Payout.Locator("option").AllTextContentsAsync();
        Assert.IsTrue(Opts.Any(O => O.Contains("Bank")), "WfStep14: Bank option exists");
        Assert.IsTrue(Opts.Any(O => O.Contains("PayPal")), "WfStep14: PayPal option exists");
        Assert.IsTrue(await BrowserPage.Locator("input#PayoutDetails").IsVisibleAsync(),
            "WfStep14: PayoutDetails input visible");
        Assert.IsTrue(await BrowserPage.Locator("button:has-text('Save Settings')").IsVisibleAsync(),
            "WfStep14: Save Settings button visible");
        await TakeScreenshotAsync("wf-14-withdrawal-settings.png");
    }
    private static void WfStepVerifyAllScreenshots()
    {
        var Files = new[]
        {
            "wf-01-login-sso.png", "wf-02-kyc-verification.png", "wf-03-create-task.png",
            "wf-04-upload-source.png", "wf-05-browse-tasks.png", "wf-06-task-detail.png",
            "wf-07-diff-editor.png", "wf-08-submit-pr.png", "wf-09-review-diff.png",
            "wf-10-add-comments.png", "wf-11-resolve-comments.png", "wf-12-approve-pay.png",
            "wf-13-payment-history.png", "wf-14-withdrawal-settings.png"
        };
        foreach (var F in Files)
        {
            var P = Path.Combine(ScreenshotDir, F);
            Assert.IsTrue(File.Exists(P), $"WfVerify: {F} must exist");
            Assert.IsTrue(new FileInfo(P).Length > 10240, $"WfVerify: {F} must be > 10KB");
        }
    }
}
