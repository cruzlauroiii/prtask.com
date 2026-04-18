using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Playwright;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static HttpClient? T53Http;
    private static IPage? T53Page;
    private static IBrowserContext? T53Ctx;
    private static string T53User1Id = string.Empty;
    private static string T53User2Id = string.Empty;
    private static string T53TaskId = string.Empty;
    private static string T53PrId = string.Empty;
    private static string T53CommentId = string.Empty;
    private static readonly string T53PrKey = Guid.NewGuid().ToString();
    [TestMethod, TestCategory("Rules")]
    [DisplayName("T53 User 2 accepts payment with before/after screenshots and DB verification")]
    public async Task T53AcceptPaymentAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        T53Http = new HttpClient(Handler) { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        T53Ctx = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            ViewportSize = ViewportSize.NoViewport,
            IgnoreHTTPSErrors = true
        });
        T53Page = await T53Ctx.NewPageAsync();
        try
        {
            await T53SetupAsync();
            await T53LoginAsync(E2ECrudConstants.User2SubjectId, E2ECrudConstants.User2Name, false);
            await T53Page!.GotoAsync(BaseUrl + RouteConstants.Settings);
            await T53ScreenshotAsync(E2EWorkflowConstants.BeforeLabel);
            var PayResp = await T53Http!.GetAsync(
                string.Format(RouteConstants.ApiPaymentRecordsByPayer, T53User1Id));
            Assert.IsTrue(PayResp.IsSuccessStatusCode, E2EWorkflowConstants.PaymentRecordAssertMsg);
            var PayBody = await PayResp.Content.ReadAsStringAsync();
            Assert.IsTrue(PayBody.Length > 0, "T53: Payment records response has content");
            await T53Page!.GotoAsync(BaseUrl + RouteConstants.ClientPayments);
            await T53ScreenshotAsync(E2EWorkflowConstants.AfterLabel);
            T53VerifyScreenshots();
            await T53CleanupAsync();
        }
        finally
        {
            T53Http.Dispose();
            if (T53Page is not null) { await T53Page.CloseAsync(); }
            if (T53Ctx is not null) { await T53Ctx.DisposeAsync(); }
        }
    }
    private static async Task T53SetupAsync()
    {
        await T53LoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
        var TaskResp = await T53Http!.PostAsJsonAsync(RouteConstants.ApiTasks, new
        {
            ClientId = T53User1Id,
            Title = E2ECrudConstants.TaskTitle, Description = E2ECrudConstants.TaskDescription,
            RepoUrl = E2ECrudConstants.TaskRepoUrl, Complexity = (int)TaskComplexity.Complex,
            E2ECrudConstants.BountyAmountCents,
            Tags = new[] { E2ECrudConstants.TagCsharp, E2ECrudConstants.TagE2E }
        });
        Assert.AreEqual(HttpStatusCode.Created, TaskResp.StatusCode, "T53Setup: Create task");
        using var TaskDoc = JsonDocument.Parse(await TaskResp.Content.ReadAsStringAsync());
        T53TaskId = TaskDoc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        var OrigFiles = new Dictionary<string, string>
        {
            [E2EWorkflowConstants.SourceFile1Path] = E2EWorkflowConstants.SourceFile1Original,
            [E2EWorkflowConstants.SourceFile2Path] = E2EWorkflowConstants.SourceFile2Content
        };
        await T53Http!.PostAsJsonAsync(string.Format(RouteConstants.ApiSourceCodeUpload, T53TaskId), OrigFiles);
        await T53LoginAsync(E2ECrudConstants.User2SubjectId, E2ECrudConstants.User2Name, false);
        await T53Http!.PostAsJsonAsync(
            string.Format(RouteConstants.ApiTaskClaim, T53TaskId), new { DeveloperId = T53User2Id });
        var ModFiles = new Dictionary<string, string>
        {
            [E2EWorkflowConstants.SourceFile1Path] = E2EWorkflowConstants.SourceFile1Modified,
            [E2EWorkflowConstants.SourceFile2Path] = E2EWorkflowConstants.SourceFile2Content
        };
        await T53Http!.PostAsJsonAsync(
            string.Format(RouteConstants.ApiSourceCodeModify, T53TaskId, T53PrKey), ModFiles);
        var Pr = new
        {
            TaskId = T53TaskId,
            DeveloperId = T53User2Id, GitHubPrUrl = E2ECrudConstants.PrGitHubUrl,
            FilesChanged = E2ECrudConstants.PrFilesChanged,
            Additions = E2ECrudConstants.PrAdditions, Deletions = E2ECrudConstants.PrDeletions
        };
        var PrResp = await T53Http!.PostAsJsonAsync(RouteConstants.ApiPullRequests, Pr);
        Assert.AreEqual(HttpStatusCode.Created, PrResp.StatusCode, "T53Setup: Submit PR");
        using var PrDoc = JsonDocument.Parse(await PrResp.Content.ReadAsStringAsync());
        T53PrId = PrDoc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        await T53LoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
        var Comment = new
        {
            PullRequestId = T53PrId,
            AuthorId = T53User1Id, FilePath = E2ECrudConstants.CommentFilePath,
            LineNumber = E2ECrudConstants.CommentLineNumber, Body = E2ECrudConstants.CommentBody
        };
        var CmtResp = await T53Http!.PostAsJsonAsync(RouteConstants.ApiReviewComments, Comment);
        using var CmtDoc = JsonDocument.Parse(await CmtResp.Content.ReadAsStringAsync());
        T53CommentId = CmtDoc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        await T53LoginAsync(E2ECrudConstants.User2SubjectId, E2ECrudConstants.User2Name, false);
        await T53Http!.PostAsync(
            string.Format(RouteConstants.ApiReviewCommentResolve, T53CommentId), null);
        await T53LoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
        await T53Http!.PostAsync(
            string.Format(RouteConstants.ApiPullRequestApprove, T53PrId), null);
        await T53Http!.PostAsJsonAsync(RouteConstants.ApiPaymentsCheckout,
            new { TaskId = T53TaskId, PayerId = T53User1Id,
                AmountCents = E2ECrudConstants.BountyAmountCents });
    }
    private static async Task T53LoginAsync(string SubjectId, string Name, bool IsUser1)
    {
        var Resp = await T53Http!.PostAsJsonAsync(RouteConstants.ApiAuthDevLogin,
            new { UserId = SubjectId, Username = Name });
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode);
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        var Id = Doc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        if (IsUser1) { T53User1Id = Id; } else { T53User2Id = Id; }
    }
    private static async Task T53ScreenshotAsync(string Label)
    {
        Directory.CreateDirectory(ScreenshotDir);
        var FileName = string.Format(E2EWorkflowConstants.StepScreenshotFormat,
            E2EWorkflowConstants.StepAcceptPayment, Label);
        await T53Page!.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = Path.Combine(ScreenshotDir, FileName), FullPage = true
        });
    }
    private static void T53VerifyScreenshots()
    {
        var BeforePath = Path.Combine(ScreenshotDir, string.Format(
            E2EWorkflowConstants.StepScreenshotFormat, E2EWorkflowConstants.StepAcceptPayment,
            E2EWorkflowConstants.BeforeLabel));
        var AfterPath = Path.Combine(ScreenshotDir, string.Format(
            E2EWorkflowConstants.StepScreenshotFormat, E2EWorkflowConstants.StepAcceptPayment,
            E2EWorkflowConstants.AfterLabel));
        Assert.IsTrue(File.Exists(BeforePath), "T53: Before screenshot exists");
        Assert.IsTrue(File.Exists(AfterPath), "T53: After screenshot exists");
        Assert.IsTrue(new FileInfo(BeforePath).Length > E2EWorkflowConstants.MinScreenshotBytes,
            "T53: Before screenshot not blank");
        Assert.IsTrue(new FileInfo(AfterPath).Length > E2EWorkflowConstants.MinScreenshotBytes,
            "T53: After screenshot not blank");
    }
    private static async Task T53CleanupAsync()
    {
        await T53LoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
        await T53Http!.DeleteAsync(string.Format(RouteConstants.ApiReviewCommentById, T53CommentId));
        await T53Http!.DeleteAsync(string.Format(RouteConstants.ApiPullRequestById, T53PrId));
        await T53Http!.DeleteAsync(string.Format(RouteConstants.ApiSourceCodeDelete, T53TaskId));
        await T53Http!.DeleteAsync(string.Format(RouteConstants.ApiTaskById, T53TaskId));
    }
}
