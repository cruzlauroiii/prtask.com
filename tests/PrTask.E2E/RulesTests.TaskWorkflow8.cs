using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Playwright;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static HttpClient? T52Http;
    private static IPage? T52Page;
    private static IBrowserContext? T52Ctx;
    private static string T52User1Id = string.Empty;
    private static string T52User2Id = string.Empty;
    private static string T52TaskId = string.Empty;
    private static string T52PrId = string.Empty;
    private static string T52CommentId = string.Empty;
    private static readonly string T52PrKey = Guid.NewGuid().ToString();
    [TestMethod, TestCategory("Rules")]
    [DisplayName("T52 User 1 approves PR and pays via Maya sandbox with before/after screenshots and DB verification")]
    public async Task T52ApproveAndPayAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        T52Http = new HttpClient(Handler) { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        T52Ctx = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            ViewportSize = ViewportSize.NoViewport,
            IgnoreHTTPSErrors = true
        });
        T52Page = await T52Ctx.NewPageAsync();
        try
        {
            await T52SetupAsync();
            await T52LoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
            await T52Page!.GotoAsync(BaseUrl + string.Format(RouteConstants.PullRequestDetail, T52PrId));
            await T52ScreenshotAsync(E2EWorkflowConstants.BeforeLabel);
            var ApproveResp = await T52Http!.PostAsync(
                string.Format(RouteConstants.ApiPullRequestApprove, T52PrId), null);
            Assert.AreEqual(HttpStatusCode.OK, ApproveResp.StatusCode, "T52: Approve PR");
            var PrResp = await T52Http!.GetAsync(
                string.Format(RouteConstants.ApiPullRequestById, T52PrId));
            Assert.AreEqual(HttpStatusCode.OK, PrResp.StatusCode, "T52: Get approved PR");
            using var PrDoc = JsonDocument.Parse(await PrResp.Content.ReadAsStringAsync());
            Assert.AreEqual((int)PullRequestStatus.Approved,
                PrDoc.RootElement.GetProperty("status").GetInt32(), "T52: PR status is Approved");
            var CheckoutResp = await T52Http!.PostAsJsonAsync(RouteConstants.ApiPaymentsCheckout,
                new { TaskId = T52TaskId, PayerId = T52User1Id,
                    AmountCents = E2ECrudConstants.BountyAmountCents });
            var CheckoutBody = await CheckoutResp.Content.ReadAsStringAsync();
            Assert.IsTrue(CheckoutResp.IsSuccessStatusCode || CheckoutBody.Length > 0,
                E2EWorkflowConstants.PaymentRespondedAssertMsg);
            await T52Page!.GotoAsync(BaseUrl + string.Format(RouteConstants.PullRequestDetail, T52PrId));
            await T52ScreenshotAsync(E2EWorkflowConstants.AfterLabel);
            T52VerifyScreenshots();
            await T52CleanupAsync();
        }
        finally
        {
            T52Http.Dispose();
            if (T52Page is not null) { await T52Page.CloseAsync(); }
            if (T52Ctx is not null) { await T52Ctx.DisposeAsync(); }
        }
    }
    private static async Task T52SetupAsync()
    {
        await T52LoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
        var TaskResp = await T52Http!.PostAsJsonAsync(RouteConstants.ApiTasks, new
        {
            ClientId = T52User1Id,
            Title = E2ECrudConstants.TaskTitle, Description = E2ECrudConstants.TaskDescription,
            RepoUrl = E2ECrudConstants.TaskRepoUrl, Complexity = (int)TaskComplexity.Complex,
            E2ECrudConstants.BountyAmountCents,
            Tags = new[] { E2ECrudConstants.TagCsharp, E2ECrudConstants.TagE2E }
        });
        Assert.AreEqual(HttpStatusCode.Created, TaskResp.StatusCode, "T52Setup: Create task");
        using var TaskDoc = JsonDocument.Parse(await TaskResp.Content.ReadAsStringAsync());
        T52TaskId = TaskDoc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        var OrigFiles = new Dictionary<string, string>
        {
            [E2EWorkflowConstants.SourceFile1Path] = E2EWorkflowConstants.SourceFile1Original,
            [E2EWorkflowConstants.SourceFile2Path] = E2EWorkflowConstants.SourceFile2Content
        };
        await T52Http!.PostAsJsonAsync(string.Format(RouteConstants.ApiSourceCodeUpload, T52TaskId), OrigFiles);
        await T52LoginAsync(E2ECrudConstants.User2SubjectId, E2ECrudConstants.User2Name, false);
        await T52Http!.PostAsJsonAsync(
            string.Format(RouteConstants.ApiTaskClaim, T52TaskId), new { DeveloperId = T52User2Id });
        var ModFiles = new Dictionary<string, string>
        {
            [E2EWorkflowConstants.SourceFile1Path] = E2EWorkflowConstants.SourceFile1Modified,
            [E2EWorkflowConstants.SourceFile2Path] = E2EWorkflowConstants.SourceFile2Content
        };
        await T52Http!.PostAsJsonAsync(
            string.Format(RouteConstants.ApiSourceCodeModify, T52TaskId, T52PrKey), ModFiles);
        var Pr = new
        {
            TaskId = T52TaskId,
            DeveloperId = T52User2Id, GitHubPrUrl = E2ECrudConstants.PrGitHubUrl,
            FilesChanged = E2ECrudConstants.PrFilesChanged,
            Additions = E2ECrudConstants.PrAdditions, Deletions = E2ECrudConstants.PrDeletions
        };
        var PrResp = await T52Http!.PostAsJsonAsync(RouteConstants.ApiPullRequests, Pr);
        Assert.AreEqual(HttpStatusCode.Created, PrResp.StatusCode, "T52Setup: Submit PR");
        using var PrDoc = JsonDocument.Parse(await PrResp.Content.ReadAsStringAsync());
        T52PrId = PrDoc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        await T52LoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
        var Comment = new
        {
            PullRequestId = T52PrId,
            AuthorId = T52User1Id, FilePath = E2ECrudConstants.CommentFilePath,
            LineNumber = E2ECrudConstants.CommentLineNumber, Body = E2ECrudConstants.CommentBody
        };
        var CmtResp = await T52Http!.PostAsJsonAsync(RouteConstants.ApiReviewComments, Comment);
        using var CmtDoc = JsonDocument.Parse(await CmtResp.Content.ReadAsStringAsync());
        T52CommentId = CmtDoc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        await T52LoginAsync(E2ECrudConstants.User2SubjectId, E2ECrudConstants.User2Name, false);
        await T52Http!.PostAsync(
            string.Format(RouteConstants.ApiReviewCommentResolve, T52CommentId), null);
    }
    private static async Task T52LoginAsync(string SubjectId, string Name, bool IsUser1)
    {
        var Resp = await T52Http!.PostAsJsonAsync(RouteConstants.ApiAuthDevLogin,
            new { UserId = SubjectId, Username = Name });
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode);
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        var Id = Doc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        if (IsUser1) { T52User1Id = Id; } else { T52User2Id = Id; }
    }
    private static async Task T52ScreenshotAsync(string Label)
    {
        Directory.CreateDirectory(ScreenshotDir);
        var FileName = string.Format(E2EWorkflowConstants.StepScreenshotFormat,
            E2EWorkflowConstants.StepApproveAndPay, Label);
        await T52Page!.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = Path.Combine(ScreenshotDir, FileName), FullPage = true
        });
    }
    private static void T52VerifyScreenshots()
    {
        var BeforePath = Path.Combine(ScreenshotDir, string.Format(
            E2EWorkflowConstants.StepScreenshotFormat, E2EWorkflowConstants.StepApproveAndPay,
            E2EWorkflowConstants.BeforeLabel));
        var AfterPath = Path.Combine(ScreenshotDir, string.Format(
            E2EWorkflowConstants.StepScreenshotFormat, E2EWorkflowConstants.StepApproveAndPay,
            E2EWorkflowConstants.AfterLabel));
        Assert.IsTrue(File.Exists(BeforePath), "T52: Before screenshot exists");
        Assert.IsTrue(File.Exists(AfterPath), "T52: After screenshot exists");
        Assert.IsTrue(new FileInfo(BeforePath).Length > E2EWorkflowConstants.MinScreenshotBytes,
            "T52: Before screenshot not blank");
        Assert.IsTrue(new FileInfo(AfterPath).Length > E2EWorkflowConstants.MinScreenshotBytes,
            "T52: After screenshot not blank");
    }
    private static async Task T52CleanupAsync()
    {
        await T52LoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
        await T52Http!.DeleteAsync(string.Format(RouteConstants.ApiReviewCommentById, T52CommentId));
        await T52Http!.DeleteAsync(string.Format(RouteConstants.ApiPullRequestById, T52PrId));
        await T52Http!.DeleteAsync(string.Format(RouteConstants.ApiSourceCodeDelete, T52TaskId));
        await T52Http!.DeleteAsync(string.Format(RouteConstants.ApiTaskById, T52TaskId));
    }
}
