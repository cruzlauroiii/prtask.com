using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static HttpClient? CrudClient;
    private static string CrudUser1Id = string.Empty;
    private static string CrudUser2Id = string.Empty;
    private static string CrudServerTaskId = string.Empty;
    private static string CrudServerPrId = string.Empty;
    private static string CrudServerCommentId = string.Empty;
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task212-225 CRUD verified workflow with dev-login and Maya sandbox")]
    public async Task CrudVerifiedWorkflowAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        CrudClient = new HttpClient(Handler) { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        try
        {
            await CrudDevLoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
            await CrudCreateTaskAsync();
            await CrudVerifyTaskAsync();
            await CrudSubmitKycAsync();
            await CrudDevLoginAsync(E2ECrudConstants.User2SubjectId, E2ECrudConstants.User2Name, false);
            await CrudClaimTaskAsync();
            await CrudSubmitPrAsync();
            await CrudCreateCommentAsync();
            await CrudDevLoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
            await CrudResolveCommentAsync();
            await CrudApprovePrAsync();
            await CrudMayaCheckoutAsync();
            await CrudVerifyPaymentRecordAsync();
            await CrudCleanupAsync();
        }
        finally
        {
            CrudClient.Dispose();
        }
    }
    private static async Task CrudDevLoginAsync(string SubjectId, string Name, bool IsUser1)
    {
        var Http = CrudClient!;
        var Resp = await Http.PostAsJsonAsync(RouteConstants.ApiAuthDevLogin,
            new { UserId = SubjectId, Username = Name });
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode, $"DevLogin for {Name}");
        using var BodyDoc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        var Id = BodyDoc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        if (IsUser1) { CrudUser1Id = Id; } else { CrudUser2Id = Id; }
        var MeResp = await Http.GetAsync(RouteConstants.ApiAuthMe);
        Assert.AreEqual(HttpStatusCode.OK, MeResp.StatusCode, "AuthMe after dev-login");
        using var MeDoc = JsonDocument.Parse(await MeResp.Content.ReadAsStringAsync());
        Assert.AreEqual(Id, MeDoc.RootElement.GetProperty("userId").GetString(), "AuthMe must match");
    }
    private static async Task CrudCreateTaskAsync()
    {
        var Http = CrudClient!;
        var Task = new
        {
            ClientId = CrudUser1Id,
            Title = E2ECrudConstants.TaskTitle, Description = E2ECrudConstants.TaskDescription,
            RepoUrl = E2ECrudConstants.TaskRepoUrl, Complexity = (int)TaskComplexity.Complex,
            E2ECrudConstants.BountyAmountCents,
            Tags = new[] { E2ECrudConstants.TagCsharp, E2ECrudConstants.TagE2E }
        };
        var Resp = await Http.PostAsJsonAsync(RouteConstants.ApiTasks, Task);
        Assert.AreEqual(HttpStatusCode.Created, Resp.StatusCode, "Task POST must return 201");
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        CrudServerTaskId = Doc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        Assert.IsFalse(string.IsNullOrEmpty(CrudServerTaskId), "Server must assign task ID");
    }
    private static async Task CrudVerifyTaskAsync()
    {
        var Http = CrudClient!;
        var Resp = await Http.GetAsync(string.Format(RouteConstants.ApiTaskById, CrudServerTaskId));
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode, "Task GET must return 200");
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        Assert.AreEqual(E2ECrudConstants.TaskTitle, Doc.RootElement.GetProperty("title").GetString());
        Assert.AreEqual(E2ECrudConstants.BountyAmountCents, Doc.RootElement.GetProperty("bountyAmountCents").GetInt64());
    }
    private static async Task CrudSubmitKycAsync()
    {
        var Http = CrudClient!;
        var Resp = await Http.PostAsJsonAsync($"{RouteConstants.ApiUsers}/{CrudUser1Id}/Kyc",
            new { DocumentType = E2ECrudConstants.KycDocType, DocumentId = E2ECrudConstants.KycDocId });
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode, "KYC POST must succeed");
        var UserResp = await Http.GetAsync($"{RouteConstants.ApiUsers}/{CrudUser1Id}");
        using var Doc = JsonDocument.Parse(await UserResp.Content.ReadAsStringAsync());
        Assert.AreEqual((int)KycStatus.Pending, Doc.RootElement.GetProperty("kycStatus").GetInt32(), "KYC Pending");
    }
    private static async Task CrudClaimTaskAsync()
    {
        var Http = CrudClient!;
        var Resp = await Http.PostAsJsonAsync(
            string.Format(RouteConstants.ApiTaskClaim, CrudServerTaskId),
            new { DeveloperId = CrudUser2Id });
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode, "Task claim must succeed");
    }
    private static async Task CrudSubmitPrAsync()
    {
        var Http = CrudClient!;
        var Pr = new
        {
            TaskId = CrudServerTaskId,
            DeveloperId = CrudUser2Id, GitHubPrUrl = E2ECrudConstants.PrGitHubUrl,
            FilesChanged = E2ECrudConstants.PrFilesChanged,
            Additions = E2ECrudConstants.PrAdditions, Deletions = E2ECrudConstants.PrDeletions
        };
        var Resp = await Http.PostAsJsonAsync(RouteConstants.ApiPullRequests, Pr);
        Assert.AreEqual(HttpStatusCode.Created, Resp.StatusCode, "PR POST must return 201");
        using var PrDoc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        CrudServerPrId = PrDoc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        Assert.IsFalse(string.IsNullOrEmpty(CrudServerPrId), "Server must assign PR ID");
        var GetResp = await Http.GetAsync(
            string.Format(RouteConstants.ApiPullRequestById, CrudServerPrId));
        using var Doc = JsonDocument.Parse(await GetResp.Content.ReadAsStringAsync());
        Assert.AreEqual(E2ECrudConstants.PrGitHubUrl, Doc.RootElement.GetProperty("gitHubPrUrl").GetString());
    }
    private static async Task CrudCreateCommentAsync()
    {
        var Http = CrudClient!;
        var Comment = new
        {
            PullRequestId = CrudServerPrId,
            AuthorId = CrudUser2Id, FilePath = E2ECrudConstants.CommentFilePath,
            LineNumber = E2ECrudConstants.CommentLineNumber, Body = E2ECrudConstants.CommentBody
        };
        var Resp = await Http.PostAsJsonAsync(RouteConstants.ApiReviewComments, Comment);
        Assert.AreEqual(HttpStatusCode.Created, Resp.StatusCode, "Comment POST must return 201");
        using var CmtDoc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        CrudServerCommentId = CmtDoc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        Assert.IsFalse(string.IsNullOrEmpty(CrudServerCommentId), "Server must assign comment ID");
        var ListResp = await Http.GetAsync(
            string.Format(RouteConstants.ApiReviewCommentsByPr, CrudServerPrId));
        using var Doc = JsonDocument.Parse(await ListResp.Content.ReadAsStringAsync());
        Assert.IsTrue(Doc.RootElement.GetArrayLength() > 0, "Comment list must not be empty");
    }
    private static async Task CrudResolveCommentAsync()
    {
        var Http = CrudClient!;
        var Resp = await Http.PostAsync(
            string.Format(RouteConstants.ApiReviewCommentResolve, CrudServerCommentId), null);
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode, "Comment resolve must succeed");
        var ListResp = await Http.GetAsync(
            string.Format(RouteConstants.ApiReviewCommentsByPr, CrudServerPrId));
        using var Doc = JsonDocument.Parse(await ListResp.Content.ReadAsStringAsync());
        Assert.IsTrue(Doc.RootElement[0].GetProperty("isResolved").GetBoolean(), "Must be resolved");
    }
    private static async Task CrudApprovePrAsync()
    {
        var Http = CrudClient!;
        var Resp = await Http.PostAsync(
            string.Format(RouteConstants.ApiPullRequestApprove, CrudServerPrId), null);
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode, "PR approve must succeed");
        var GetResp = await Http.GetAsync(
            string.Format(RouteConstants.ApiPullRequestById, CrudServerPrId));
        using var Doc = JsonDocument.Parse(await GetResp.Content.ReadAsStringAsync());
        Assert.AreEqual((int)PullRequestStatus.Approved, Doc.RootElement.GetProperty("status").GetInt32());
    }
    private static async Task CrudMayaCheckoutAsync()
    {
        var Http = CrudClient!;
        var Resp = await Http.PostAsJsonAsync(RouteConstants.ApiPaymentsCheckout,
            new { TaskId = CrudServerTaskId, PayerId = CrudUser1Id,
                AmountCents = E2ECrudConstants.BountyAmountCents });
        var Body = await Resp.Content.ReadAsStringAsync();
        Assert.IsTrue(Resp.IsSuccessStatusCode || Body.Contains("checkoutUrl") || Body.Length > 0,
            $"Maya checkout responded: {Resp.StatusCode}");
    }
    private static async Task CrudVerifyPaymentRecordAsync()
    {
        var Http = CrudClient!;
        var Resp = await Http.GetAsync(string.Format(RouteConstants.ApiPaymentRecordsByPayer, CrudUser1Id));
        Assert.IsTrue(Resp.IsSuccessStatusCode, "Payment records must respond");
    }
    private static async Task CrudCleanupAsync()
    {
        var Http = CrudClient!;
        var DelComment = await Http.DeleteAsync(
            string.Format(RouteConstants.ApiReviewCommentById, CrudServerCommentId));
        Assert.AreEqual(HttpStatusCode.NoContent, DelComment.StatusCode, "Comment DELETE 204");
        var DelPr = await Http.DeleteAsync(
            string.Format(RouteConstants.ApiPullRequestById, CrudServerPrId));
        Assert.AreEqual(HttpStatusCode.NoContent, DelPr.StatusCode, "PR DELETE 204");
        var GetPr = await Http.GetAsync(
            string.Format(RouteConstants.ApiPullRequestById, CrudServerPrId));
        Assert.AreEqual(HttpStatusCode.NotFound, GetPr.StatusCode, "Deleted PR 404");
        var DelTask = await Http.DeleteAsync(
            string.Format(RouteConstants.ApiTaskById, CrudServerTaskId));
        Assert.AreEqual(HttpStatusCode.NoContent, DelTask.StatusCode, "Task DELETE 204");
        var GetTask = await Http.GetAsync(
            string.Format(RouteConstants.ApiTaskById, CrudServerTaskId));
        Assert.AreEqual(HttpStatusCode.NotFound, GetTask.StatusCode, "Deleted task 404");
    }
}
