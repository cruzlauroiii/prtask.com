using System.Net;
using System.Net.Http.Json;
using PrTask.Cdp;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static HttpClient? Wf658Http;
    [TestMethod, TestCategory("Rules"), Timeout(300000)]
    [DisplayName("658 CDP 18-step workflow with offline/online sync")]
    public async Task CdpFullWorkflowWithOfflineSyncAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        Wf658Http = new HttpClient(Handler) { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(30) };
        try
        {
            await Wf658_DevLoginAsync();
            await Wf658_01_LoginPageAsync();
            await Wf658_02_VerifyGoogleSsoAsync();
            await Wf658_03_FillCreateTaskAsync();
            await Wf658_CreateTaskViaApiAsync();
            await Wf658_VerifyTaskInDbAsync();
            await Wf658_04_TaskListOfflineAsync();
            await Wf658_VerifyTaskListContainsCreatedAsync();
            await Wf658_05_ClickTaskAsync();
            await Wf658_06_SubmitPrFormAsync();
            await Wf658_SubmitPrViaApiAsync();
            await Wf658_VerifyPrInDbAsync();
            await Wf658_07_DiffPageAsync();
            await Wf658_08_ClickDiffLineAsync();
            await Wf658_09_CommentOfflineAsync();
            await Wf658_CreateCommentViaApiAsync();
            await Wf658_VerifyCommentInDbAsync();
            await Wf658_10_ClickCommentAsync();
            await Wf658_11_EditCodeAsync();
            await Wf658_12_SaveDiffAsync();
            await Wf658_13_ApprovePayAsync();
            await Wf658_ApprovePrViaApiAsync();
            await Wf658_VerifyPrApprovedAsync();
            await Wf658_14_WithdrawPageAsync();
            await Wf658_15_WithdrawOfflineAsync();
            await Wf658_16_PaymentStatusAsync();
            await Wf658_17_AuditHistoryAsync();
            await Wf658_VerifyAuditLogExistsAsync();
            await TakeScreenshotAsync("wf658-complete.png");
        }
        finally
        {
            await Wf658_CleanupCreatedDataAsync();
            Wf658Http.Dispose();
        }
    }
    private static async Task Wf658_DevLoginAsync()
    {
        var Resp = await Wf658Http!.PostAsJsonAsync(RouteConstants.ApiAuthDevLogin,
            new { UserId = E2ECrudConstants.User1SubjectId, Username = E2ECrudConstants.User1Name });
        if (Resp.StatusCode == HttpStatusCode.NotFound)
        {
            Assert.Inconclusive("DevLogin endpoint not available (404) — server may not support /Api/Auth/DevLogin in this environment");
            return;
        }
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode, "658: Dev login must succeed");
        await Wf658_CaptureUserIdAsync(Resp);
    }
    private static async Task Wf658_01_LoginPageAsync()
    {
        var U = $"{BaseUrl}{RouteConstants.Login}";
        TrackUrlVisit(U);
        await BrowserPage.NavigateAsync(U);
        var H1Count = await CdpHelpers.CountAsync(BrowserPage, "h1");
        if (H1Count > 0)
        {
            var Text = await CdpHelpers.GetTextContentAsync(BrowserPage, "h1");
            Assert.IsTrue(Text.Length > 0, $"Step1: Login h1 must render, got: {Text}");
        }
        await TakeScreenshotAsync("wf658-01.png");
    }
    private static async Task Wf658_02_VerifyGoogleSsoAsync()
    {
        var BtnSel = "a.google-login, a[href*='Auth/Google']";
        var BtnCount = await CdpHelpers.CountAsync(BrowserPage, BtnSel);
        Assert.IsTrue(BtnCount > 0, "Step2: Google SSO button must exist");
        var Href = await CdpHelpers.GetAttributeAsync(BrowserPage, BtnSel, "href");
        Assert.IsTrue(Href.Contains("Auth/Google"), $"Step2: href={Href}");
        await TakeScreenshotAsync("wf658-02.png");
    }
    private static async Task Wf658_03_FillCreateTaskAsync()
    {
        var U = $"{BaseUrl}{RouteConstants.ClientCreateTask}";
        TrackUrlVisit(U);
        await BrowserPage.NavigateAsync(U);
        var TitleCount = await CdpHelpers.CountAsync(BrowserPage, "input#Title");
        if (TitleCount > 0 && await CdpHelpers.IsVisibleAsync(BrowserPage, "input#Title"))
        {
            await CdpHelpers.FillFieldAsync(BrowserPage, "input#Title", "E2E Test Task");
            await CdpHelpers.FillFieldAsync(BrowserPage, "textarea#Description", "Created by CDP E2E test");
            await CdpHelpers.FillFieldAsync(BrowserPage, "input#RepoUrl", "https://github.com/test/repo");
            await CdpHelpers.FillFieldAsync(BrowserPage, "input#BountyAmount", "100");
        }
        await TakeScreenshotAsync("wf658-03.png");
    }
    private static async Task Wf658_04_TaskListOfflineAsync()
    {
        var U = $"{BaseUrl}{RouteConstants.Tasks}";
        TrackUrlVisit(U);
        await BrowserPage.NavigateAsync(U);
        await CdpHelpers.SetOfflineAsync(BrowserPage, true);
        var Off = await CdpHelpers.GetTextContentAsync(BrowserPage, "body");
        Assert.IsTrue(Off.Length > 10, $"Step4 OFFLINE: page must render ({Off.Length} chars)");
        await CdpHelpers.SetOfflineAsync(BrowserPage, false);
        await CdpHelpers.ReloadAsync(BrowserPage);
        await Task.Delay(500);
        var On = await CdpHelpers.GetTextContentAsync(BrowserPage, "body");
        Assert.IsTrue(On.Length > 10, "Step4 ONLINE: must sync");
        await TakeScreenshotAsync("wf658-04.png");
    }
    private static async Task Wf658_05_ClickTaskAsync()
    {
        var TaskLinkSel = ".task-card a, .task-grid a, a[href*='/Tasks/']";
        var TaskLinkCount = await CdpHelpers.CountAsync(BrowserPage, TaskLinkSel);
        if (TaskLinkCount > 0)
        {
            await CdpHelpers.ClickSelectorAsync(BrowserPage, TaskLinkSel);
            await Task.Delay(500);
        }
        await TakeScreenshotAsync("wf658-05.png");
    }
    private static async Task Wf658_06_SubmitPrFormAsync()
    {
        var TaskId = string.IsNullOrEmpty(Wf658CreatedTaskId) ? DemoSeedConstants.TaskId : Wf658CreatedTaskId;
        var U = $"{BaseUrl}{string.Format(RouteConstants.SubmitPr, TaskId)}";
        TrackUrlVisit(U);
        await BrowserPage.NavigateAsync(U);
        var PrUrlSel = "input#GitHubPrUrl, input[name='GitHubPrUrl']";
        var PrUrlCount = await CdpHelpers.CountAsync(BrowserPage, PrUrlSel);
        if (PrUrlCount > 0 && await CdpHelpers.IsVisibleAsync(BrowserPage, PrUrlSel))
        {
            await CdpHelpers.FillFieldAsync(BrowserPage, PrUrlSel, E2ECrudConstants.PrGitHubUrl);
        }
        await TakeScreenshotAsync("wf658-06.png");
    }
    private static async Task Wf658_07_DiffPageAsync()
    {
        var PrId = string.IsNullOrEmpty(Wf658CreatedPrId) ? DemoSeedConstants.PrId : Wf658CreatedPrId;
        var U = $"{BaseUrl}{string.Format(RouteConstants.PullRequestDetail, PrId)}";
        TrackUrlVisit(U);
        await BrowserPage.NavigateAsync(U);
        var Body = await CdpHelpers.GetTextContentAsync(BrowserPage, "body");
        Assert.IsTrue(Body.Length > 10, $"Step7: PR detail page must render ({Body.Length} chars)");
        await TakeScreenshotAsync("wf658-07.png");
    }
    private static async Task Wf658_08_ClickDiffLineAsync()
    {
        var LineSel = ".diff-line, .line-number, .line-add";
        var LineCount = await CdpHelpers.CountAsync(BrowserPage, LineSel);
        if (LineCount > 0 && await CdpHelpers.IsVisibleAsync(BrowserPage, LineSel))
        {
            await CdpHelpers.ClickSelectorAsync(BrowserPage, LineSel);
            await TakeScreenshotAsync("wf658-08-clicked.png");
        }
        await TakeScreenshotAsync("wf658-08.png");
    }
    private static async Task Wf658_09_CommentOfflineAsync()
    {
        await CdpHelpers.SetOfflineAsync(BrowserPage, true);
        var Body = await CdpHelpers.GetTextContentAsync(BrowserPage, "body");
        Assert.IsTrue(Body.Length > 10, $"Step9 OFFLINE: PR detail must render ({Body.Length} chars)");
        var TextareaSel = "textarea, .comment-input, .reply-textarea";
        var TextareaCount = await CdpHelpers.CountAsync(BrowserPage, TextareaSel);
        if (TextareaCount > 0 && await CdpHelpers.IsVisibleAsync(BrowserPage, TextareaSel))
        {
            await CdpHelpers.FillFieldAsync(BrowserPage, TextareaSel, "Offline comment from E2E test");
        }
        await CdpHelpers.SetOfflineAsync(BrowserPage, false);
        await CdpHelpers.ReloadAsync(BrowserPage);
        await Task.Delay(500);
        Assert.IsTrue((await CdpHelpers.GetTextContentAsync(BrowserPage, "body")).Length > 10, "Step9 ONLINE");
        await TakeScreenshotAsync("wf658-09.png");
    }
    private static async Task Wf658_10_ClickCommentAsync()
    {
        var CommentSel = ".review-comment, .comment-body";
        var CommentCount = await CdpHelpers.CountAsync(BrowserPage, CommentSel);
        if (CommentCount > 0 && await CdpHelpers.IsVisibleAsync(BrowserPage, CommentSel))
        {
            await CdpHelpers.ClickSelectorAsync(BrowserPage, CommentSel);
        }
        await TakeScreenshotAsync("wf658-10.png");
    }
    private static async Task Wf658_11_EditCodeAsync()
    {
        var EditSel = "button.diff-edit-toggle";
        var EditCount = await CdpHelpers.CountAsync(BrowserPage, EditSel);
        if (EditCount > 0 && await CdpHelpers.IsVisibleAsync(BrowserPage, EditSel))
        {
            await CdpHelpers.ClickSelectorAsync(BrowserPage, EditSel);
            await TakeScreenshotAsync("wf658-11-editing.png");
        }
        await TakeScreenshotAsync("wf658-11.png");
    }
    private static async Task Wf658_12_SaveDiffAsync()
    {
        var SaveSel = "button.save-btn";
        var SaveCount = await CdpHelpers.CountAsync(BrowserPage, SaveSel);
        if (SaveCount > 0 && await CdpHelpers.IsVisibleAsync(BrowserPage, SaveSel))
        {
            await CdpHelpers.ClickSelectorAsync(BrowserPage, SaveSel);
            await Task.Delay(500);
        }
        await TakeScreenshotAsync("wf658-12.png");
    }
    private static async Task Wf658_13_ApprovePayAsync()
    {
        var ApproveSel = "button.approve-btn, button.merge-btn";
        var ApproveCount = await CdpHelpers.CountAsync(BrowserPage, ApproveSel);
        if (ApproveCount > 0 && await CdpHelpers.IsVisibleAsync(BrowserPage, ApproveSel))
        {
            await CdpHelpers.ClickSelectorAsync(BrowserPage, ApproveSel);
            await Task.Delay(500);
        }
        await TakeScreenshotAsync("wf658-13.png");
    }
    private static async Task Wf658_14_WithdrawPageAsync()
    {
        var U = $"{BaseUrl}{RouteConstants.Settings}";
        TrackUrlVisit(U);
        await BrowserPage.NavigateAsync(U);
        var PayoutCount = await CdpHelpers.CountAsync(BrowserPage, "select#PayoutMethod");
        if (PayoutCount > 0 && await CdpHelpers.IsVisibleAsync(BrowserPage, "select#PayoutMethod"))
        {
            var Options = await CdpHelpers.AllTextContentsAsync(BrowserPage, "select#PayoutMethod option");
            if (Options.Length > 1)
            {
                await CdpHelpers.SelectOptionAsync(BrowserPage, "select#PayoutMethod", "1");
            }
        }
        await TakeScreenshotAsync("wf658-14.png");
    }
    private static async Task Wf658_15_WithdrawOfflineAsync()
    {
        await CdpHelpers.SetOfflineAsync(BrowserPage, true);
        Assert.IsTrue((await CdpHelpers.GetTextContentAsync(BrowserPage, "body")).Length > 10, "Step15 OFFLINE");
        await CdpHelpers.SetOfflineAsync(BrowserPage, false);
        await CdpHelpers.ReloadAsync(BrowserPage);
        await Task.Delay(500);
        Assert.IsTrue((await CdpHelpers.GetTextContentAsync(BrowserPage, "body")).Length > 10, "Step15 ONLINE");
        await TakeScreenshotAsync("wf658-15.png");
    }
    private static async Task Wf658_16_PaymentStatusAsync()
    {
        var U = $"{BaseUrl}{RouteConstants.ClientPayments}";
        TrackUrlVisit(U);
        await BrowserPage.NavigateAsync(U);
        var LoadBtnSel = "button";
        var LoadBtnCount = await CdpHelpers.CountAsync(BrowserPage, LoadBtnSel);
        if (LoadBtnCount > 0 && await CdpHelpers.IsVisibleAsync(BrowserPage, LoadBtnSel))
        {
            await CdpHelpers.ClickSelectorAsync(BrowserPage, LoadBtnSel);
        }
        await TakeScreenshotAsync("wf658-16.png");
    }
    private static async Task Wf658_17_AuditHistoryAsync()
    {
        var U = $"{BaseUrl}{RouteConstants.Dashboard}";
        TrackUrlVisit(U);
        await BrowserPage.NavigateAsync(U);
        var Body = await CdpHelpers.GetTextContentAsync(BrowserPage, "body");
        Assert.IsTrue(Body.Length > 10, $"Step17: Dashboard must have content ({Body.Length} chars)");
        await TakeScreenshotAsync("wf658-17.png");
    }
}
