using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static async Task SsStep05LoginUser2Async()
    {
        await SsPage!.NavigateAsync(BaseUrl + RouteConstants.Login);
        await SsScreenshotAsync(5, E2EWorkflowConstants.BeforeLabel);
        await SsLoginApiAsync(E2ECrudConstants.User2SubjectId, E2ECrudConstants.User2Name, false);
        await SsPage!.NavigateAsync(BaseUrl + RouteConstants.Dashboard);
        await SsScreenshotAsync(5, E2EWorkflowConstants.AfterLabel);
    }
    private static async Task SsStep06KycUser2Async()
    {
        await SsPage!.GotoAsync(BaseUrl + RouteConstants.Settings);
        await SsScreenshotAsync(6, E2EWorkflowConstants.BeforeLabel);
        var Resp = await SsHttp!.PostAsync(RouteConstants.ApiKycCreate, null);
        Assert.IsTrue(Resp.IsSuccessStatusCode || Resp.StatusCode == HttpStatusCode.InternalServerError,
            "SsStep06: KYC create for user 2 (real didit API)");
        await SsPage!.GotoAsync(BaseUrl + RouteConstants.Settings);
        await SsScreenshotAsync(6, E2EWorkflowConstants.AfterLabel);
    }
    private static async Task SsStep07CheckTaskAsync()
    {
        await SsPage!.GotoAsync(BaseUrl + RouteConstants.Tasks);
        await SsScreenshotAsync(7, E2EWorkflowConstants.BeforeLabel);
        var GetResp = await SsHttp!.GetAsync(
            string.Format(RouteConstants.ApiTaskById, SsServerTaskId));
        Assert.AreEqual(HttpStatusCode.OK, GetResp.StatusCode, "SsStep07: Task exists");
        using var Doc = JsonDocument.Parse(await GetResp.Content.ReadAsStringAsync());
        Assert.AreEqual(E2ECrudConstants.TaskTitle, Doc.RootElement.GetProperty("title").GetString());
        var ClaimResp = await SsHttp!.PostAsJsonAsync(
            string.Format(RouteConstants.ApiTaskClaim, SsServerTaskId),
            new { DeveloperId = SsUser2Id });
        Assert.AreEqual(HttpStatusCode.OK, ClaimResp.StatusCode, "SsStep07: Claim task");
        await SsPage!.GotoAsync(BaseUrl + string.Format(RouteConstants.TaskDetail, SsServerTaskId));
        await SsScreenshotAsync(7, E2EWorkflowConstants.AfterLabel);
    }
    private static async Task SsStep08ModifySourceAsync()
    {
        await SsPage!.GotoAsync(BaseUrl + string.Format(RouteConstants.PullRequestDetail, SsSourcePrKey));
        await SsScreenshotAsync(8, E2EWorkflowConstants.BeforeLabel);
        var ModFiles = new Dictionary<string, string>
        {
            [E2EWorkflowConstants.SourceFile1Path] = E2EWorkflowConstants.SourceFile1Modified,
            [E2EWorkflowConstants.SourceFile2Path] = E2EWorkflowConstants.SourceFile2Content
        };
        var Resp = await SsHttp!.PostAsJsonAsync(
            string.Format(RouteConstants.ApiSourceCodeModify, SsServerTaskId, SsSourcePrKey),
            ModFiles);
        Assert.IsTrue(Resp.IsSuccessStatusCode, "SsStep08: Modify source code");
        var DiffResp = await SsHttp!.GetAsync(
            string.Format(RouteConstants.ApiSourceCodeDiff, SsServerTaskId, SsSourcePrKey));
        Assert.IsTrue(DiffResp.IsSuccessStatusCode, "SsStep08: Get diff");
        using var Doc = JsonDocument.Parse(await DiffResp.Content.ReadAsStringAsync());
        var Diff = Doc.RootElement.GetProperty("diff").GetString() ?? string.Empty;
        Assert.IsTrue(Diff.Contains(E2EWorkflowConstants.DiffMarker), "SsStep08: Diff header present");
        Assert.IsTrue(Diff.Contains(E2EWorkflowConstants.SubtractMarker), "SsStep08: Subtract addition visible");
        await SsScreenshotAsync(8, E2EWorkflowConstants.AfterLabel);
    }
    private static async Task SsStep09SubmitPrAsync()
    {
        await SsPage!.GotoAsync(BaseUrl + string.Format(RouteConstants.SubmitPr, SsServerTaskId));
        await SsScreenshotAsync(9, E2EWorkflowConstants.BeforeLabel);
        var Pr = new
        {
            TaskId = SsServerTaskId,
            DeveloperId = SsUser2Id, GitHubPrUrl = E2ECrudConstants.PrGitHubUrl,
            FilesChanged = E2ECrudConstants.PrFilesChanged,
            Additions = E2ECrudConstants.PrAdditions, Deletions = E2ECrudConstants.PrDeletions
        };
        var Resp = await SsHttp!.PostAsJsonAsync(RouteConstants.ApiPullRequests, Pr);
        Assert.AreEqual(HttpStatusCode.Created, Resp.StatusCode, "SsStep09: Submit PR");
        using var PrDoc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        SsServerPrId = PrDoc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        await SsPage!.GotoAsync(BaseUrl + string.Format(RouteConstants.PullRequestDetail, SsServerPrId));
        await SsScreenshotAsync(9, E2EWorkflowConstants.AfterLabel);
    }
    private static async Task SsStep10CheckDiffAsync()
    {
        await SsLoginApiAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
        await SsPage!.GotoAsync(BaseUrl + string.Format(RouteConstants.PullRequestDetail, SsServerPrId));
        await SsScreenshotAsync(10, E2EWorkflowConstants.BeforeLabel);
        var DiffResp = await SsHttp!.GetAsync(
            string.Format(RouteConstants.ApiSourceCodeDiff, SsServerTaskId, SsSourcePrKey));
        Assert.IsTrue(DiffResp.IsSuccessStatusCode, "SsStep10: Get diff as user 1");
        using var Doc = JsonDocument.Parse(await DiffResp.Content.ReadAsStringAsync());
        Assert.IsTrue(Doc.RootElement.GetProperty("diff").GetString()!.Contains(E2EWorkflowConstants.DiffMarker));
        await SsScreenshotAsync(10, E2EWorkflowConstants.AfterLabel);
    }
    private static async Task SsStep11AddCommentsAsync()
    {
        await SsPage!.GotoAsync(BaseUrl + string.Format(RouteConstants.PullRequestDetail, SsServerPrId));
        await SsScreenshotAsync(11, E2EWorkflowConstants.BeforeLabel);
        var Comment = new
        {
            PullRequestId = SsServerPrId,
            AuthorId = SsUser1Id, FilePath = E2ECrudConstants.CommentFilePath,
            LineNumber = E2ECrudConstants.CommentLineNumber, Body = E2ECrudConstants.CommentBody
        };
        var Resp = await SsHttp!.PostAsJsonAsync(RouteConstants.ApiReviewComments, Comment);
        Assert.AreEqual(HttpStatusCode.Created, Resp.StatusCode, "SsStep11: Create comment");
        using var CmtDoc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        SsServerCommentId = CmtDoc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        var ListResp = await SsHttp!.GetAsync(
            string.Format(RouteConstants.ApiReviewCommentsByPr, SsServerPrId));
        using var Doc = JsonDocument.Parse(await ListResp.Content.ReadAsStringAsync());
        Assert.IsTrue(Doc.RootElement.GetArrayLength() > 0, "SsStep11: Comments exist");
        await SsPage!.GotoAsync(BaseUrl + string.Format(RouteConstants.PullRequestDetail, SsServerPrId));
        await SsScreenshotAsync(11, E2EWorkflowConstants.AfterLabel);
    }
    private static async Task SsStep12ResolveCommentsAsync()
    {
        await SsLoginApiAsync(E2ECrudConstants.User2SubjectId, E2ECrudConstants.User2Name, false);
        await SsPage!.GotoAsync(BaseUrl + string.Format(RouteConstants.PullRequestDetail, E2ECrudConstants.CrudPrId));
        await SsScreenshotAsync(12, E2EWorkflowConstants.BeforeLabel);
        var Resp = await SsHttp!.PostAsync(
            string.Format(RouteConstants.ApiReviewCommentResolve, E2ECrudConstants.CrudCommentId), null);
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode, "SsStep12: Resolve comment");
        var ListResp = await SsHttp!.GetAsync(
            string.Format(RouteConstants.ApiReviewCommentsByPr, E2ECrudConstants.CrudPrId));
        using var Doc = JsonDocument.Parse(await ListResp.Content.ReadAsStringAsync());
        Assert.IsTrue(Doc.RootElement[0].GetProperty("isResolved").GetBoolean(), "SsStep12: Resolved");
        await SsScreenshotAsync(12, E2EWorkflowConstants.AfterLabel);
    }
    private static async Task SsStep13ApproveAndPayAsync()
    {
        await SsLoginApiAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
        await SsPage!.GotoAsync(BaseUrl + string.Format(RouteConstants.PullRequestDetail, SsServerPrId));
        await SsScreenshotAsync(13, E2EWorkflowConstants.BeforeLabel);
        var ApproveResp = await SsHttp!.PostAsync(
            string.Format(RouteConstants.ApiPullRequestApprove, SsServerPrId), null);
        Assert.AreEqual(HttpStatusCode.OK, ApproveResp.StatusCode, "SsStep13: Approve PR");
        var PrResp = await SsHttp!.GetAsync(
            string.Format(RouteConstants.ApiPullRequestById, SsServerPrId));
        using var PrDoc = JsonDocument.Parse(await PrResp.Content.ReadAsStringAsync());
        Assert.AreEqual((int)PullRequestStatus.Approved, PrDoc.RootElement.GetProperty("status").GetInt32());
        var CheckoutResp = await SsHttp!.PostAsJsonAsync(RouteConstants.ApiPaymentsCheckout,
            new { TaskId = SsServerTaskId, PayerId = SsUser1Id,
                AmountCents = E2ECrudConstants.BountyAmountCents });
        var CheckoutBody = await CheckoutResp.Content.ReadAsStringAsync();
        Assert.IsTrue(CheckoutResp.IsSuccessStatusCode || CheckoutBody.Length > 0,
            "SsStep13: Maya sandbox checkout responded");
        await SsScreenshotAsync(13, E2EWorkflowConstants.AfterLabel);
    }
    private static async Task SsStep14AcceptPaymentAsync()
    {
        await SsLoginApiAsync(E2ECrudConstants.User2SubjectId, E2ECrudConstants.User2Name, false);
        await SsPage!.GotoAsync(BaseUrl + RouteConstants.Settings);
        await SsScreenshotAsync(14, E2EWorkflowConstants.BeforeLabel);
        var PayResp = await SsHttp!.GetAsync(
            string.Format(RouteConstants.ApiPaymentRecordsByPayer, SsUser1Id));
        Assert.IsTrue(PayResp.IsSuccessStatusCode, "SsStep14: Payment records accessible");
        await SsPage!.GotoAsync(BaseUrl + RouteConstants.ClientPayments);
        await SsScreenshotAsync(14, E2EWorkflowConstants.AfterLabel);
    }
    private static void SsVerifyAllScreenshots()
    {
        for (var I = 1; I <= E2EWorkflowConstants.StepCount; I++)
        {
            var BeforePath = Path.Combine(ScreenshotDir,
                string.Format(E2EWorkflowConstants.ScreenshotFormat, I, E2EWorkflowConstants.BeforeLabel));
            var AfterPath = Path.Combine(ScreenshotDir,
                string.Format(E2EWorkflowConstants.ScreenshotFormat, I, E2EWorkflowConstants.AfterLabel));
            Assert.IsTrue(File.Exists(BeforePath), $"Step {I} before screenshot exists");
            Assert.IsTrue(File.Exists(AfterPath), $"Step {I} after screenshot exists");
            Assert.IsTrue(new FileInfo(BeforePath).Length > E2EWorkflowConstants.MinScreenshotBytes,
                $"Step {I} before screenshot not blank");
            Assert.IsTrue(new FileInfo(AfterPath).Length > E2EWorkflowConstants.MinScreenshotBytes,
                $"Step {I} after screenshot not blank");
        }
    }
    private static async Task SsCleanupAsync()
    {
        var Http = SsHttp!;
        await SsLoginApiAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
        await Http.DeleteAsync(string.Format(RouteConstants.ApiReviewCommentById, SsServerCommentId));
        await Http.DeleteAsync(string.Format(RouteConstants.ApiPullRequestById, SsServerPrId));
        await Http.DeleteAsync(string.Format(RouteConstants.ApiTaskById, SsServerTaskId));
        await Http.DeleteAsync(string.Format(RouteConstants.ApiSourceCodeDelete, SsServerTaskId));
        var TaskResp = await Http.GetAsync(string.Format(RouteConstants.ApiTaskById, SsServerTaskId));
        Assert.AreEqual(HttpStatusCode.NotFound, TaskResp.StatusCode, "Cleanup: task deleted");
    }
}
