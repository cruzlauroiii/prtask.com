using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Playwright;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static HttpClient? T50Http;
    private static IPage? T50Page;
    private static IBrowserContext? T50Ctx;
    private static string T50User1Id = string.Empty;
    private static string T50User2Id = string.Empty;
    private static string T50TaskId = string.Empty;
    private static string T50PrId = string.Empty;
    private static string T50CommentId = string.Empty;
    private static readonly string T50PrKey = Guid.NewGuid().ToString();
    [TestMethod, TestCategory("Rules")]
    [DisplayName("T50 User 1 adds annotations and comments on diff with before/after screenshots and DB verification")]
    public async Task T50AddCommentsOnDiffAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        T50Http = new HttpClient(Handler) { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        T50Ctx = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            ViewportSize = ViewportSize.NoViewport,
            IgnoreHTTPSErrors = true
        });
        T50Page = await T50Ctx.NewPageAsync();
        try
        {
            await T50SetupAsync();
            await T50LoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
            await T50Page!.GotoAsync(BaseUrl + string.Format(RouteConstants.PullRequestDetail, T50PrId));
            await T50ScreenshotAsync(E2EWorkflowConstants.BeforeLabel);
            var Comment = new
            {
                PullRequestId = T50PrId,
                AuthorId = T50User1Id, FilePath = E2ECrudConstants.CommentFilePath,
                LineNumber = E2ECrudConstants.CommentLineNumber, Body = E2ECrudConstants.CommentBody
            };
            var Resp = await T50Http!.PostAsJsonAsync(RouteConstants.ApiReviewComments, Comment);
            Assert.AreEqual(HttpStatusCode.Created, Resp.StatusCode, "T50: Create comment");
            using var CmtDoc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
            T50CommentId = CmtDoc.RootElement.GetProperty("id").GetString() ?? string.Empty;
            Assert.IsFalse(string.IsNullOrEmpty(T50CommentId), "T50: Comment ID assigned");
            var ListResp = await T50Http!.GetAsync(
                string.Format(RouteConstants.ApiReviewCommentsByPr, T50PrId));
            Assert.AreEqual(HttpStatusCode.OK, ListResp.StatusCode, "T50: List comments");
            using var Doc = JsonDocument.Parse(await ListResp.Content.ReadAsStringAsync());
            Assert.IsTrue(Doc.RootElement.GetArrayLength() > 0, "T50: Comments exist in DB");
            var FirstComment = Doc.RootElement[0];
            Assert.AreEqual(E2ECrudConstants.CommentBody,
                FirstComment.GetProperty("body").GetString(), "T50: Comment body matches");
            Assert.AreEqual(E2ECrudConstants.CommentFilePath,
                FirstComment.GetProperty("filePath").GetString(), "T50: Comment file path matches");
            Assert.AreEqual(E2ECrudConstants.CommentLineNumber,
                FirstComment.GetProperty("lineNumber").GetInt32(), "T50: Comment line number matches");
            Assert.IsFalse(FirstComment.GetProperty("isResolved").GetBoolean(),
                "T50: Comment is not resolved");
            await T50Page!.GotoAsync(BaseUrl + string.Format(RouteConstants.PullRequestDetail, T50PrId));
            await T50ScreenshotAsync(E2EWorkflowConstants.AfterLabel);
            T50VerifyScreenshots();
            await T50CleanupAsync();
        }
        finally
        {
            T50Http.Dispose();
            if (T50Page is not null) { await T50Page.CloseAsync(); }
            if (T50Ctx is not null) { await T50Ctx.DisposeAsync(); }
        }
    }
    private static async Task T50SetupAsync()
    {
        await T50LoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
        var TaskResp = await T50Http!.PostAsJsonAsync(RouteConstants.ApiTasks, new
        {
            ClientId = T50User1Id,
            Title = E2ECrudConstants.TaskTitle, Description = E2ECrudConstants.TaskDescription,
            RepoUrl = E2ECrudConstants.TaskRepoUrl, Complexity = (int)TaskComplexity.Complex,
            E2ECrudConstants.BountyAmountCents,
            Tags = new[] { E2ECrudConstants.TagCsharp, E2ECrudConstants.TagE2E }
        });
        Assert.AreEqual(HttpStatusCode.Created, TaskResp.StatusCode, "T50Setup: Create task");
        using var TaskDoc = JsonDocument.Parse(await TaskResp.Content.ReadAsStringAsync());
        T50TaskId = TaskDoc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        var OrigFiles = new Dictionary<string, string>
        {
            [E2EWorkflowConstants.SourceFile1Path] = E2EWorkflowConstants.SourceFile1Original,
            [E2EWorkflowConstants.SourceFile2Path] = E2EWorkflowConstants.SourceFile2Content
        };
        await T50Http!.PostAsJsonAsync(string.Format(RouteConstants.ApiSourceCodeUpload, T50TaskId), OrigFiles);
        await T50LoginAsync(E2ECrudConstants.User2SubjectId, E2ECrudConstants.User2Name, false);
        await T50Http!.PostAsJsonAsync(
            string.Format(RouteConstants.ApiTaskClaim, T50TaskId), new { DeveloperId = T50User2Id });
        var ModFiles = new Dictionary<string, string>
        {
            [E2EWorkflowConstants.SourceFile1Path] = E2EWorkflowConstants.SourceFile1Modified,
            [E2EWorkflowConstants.SourceFile2Path] = E2EWorkflowConstants.SourceFile2Content
        };
        await T50Http!.PostAsJsonAsync(
            string.Format(RouteConstants.ApiSourceCodeModify, T50TaskId, T50PrKey), ModFiles);
        var Pr = new
        {
            TaskId = T50TaskId,
            DeveloperId = T50User2Id, GitHubPrUrl = E2ECrudConstants.PrGitHubUrl,
            FilesChanged = E2ECrudConstants.PrFilesChanged,
            Additions = E2ECrudConstants.PrAdditions, Deletions = E2ECrudConstants.PrDeletions
        };
        var PrResp = await T50Http!.PostAsJsonAsync(RouteConstants.ApiPullRequests, Pr);
        Assert.AreEqual(HttpStatusCode.Created, PrResp.StatusCode, "T50Setup: Submit PR");
        using var PrDoc = JsonDocument.Parse(await PrResp.Content.ReadAsStringAsync());
        T50PrId = PrDoc.RootElement.GetProperty("id").GetString() ?? string.Empty;
    }
    private static async Task T50LoginAsync(string SubjectId, string Name, bool IsUser1)
    {
        var Resp = await T50Http!.PostAsJsonAsync(RouteConstants.ApiAuthDevLogin,
            new { UserId = SubjectId, Username = Name });
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode);
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        var Id = Doc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        if (IsUser1) { T50User1Id = Id; } else { T50User2Id = Id; }
    }
    private static async Task T50ScreenshotAsync(string Label)
    {
        Directory.CreateDirectory(ScreenshotDir);
        var FileName = string.Format(E2EWorkflowConstants.StepScreenshotFormat,
            E2EWorkflowConstants.StepAddComments, Label);
        await T50Page!.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = Path.Combine(ScreenshotDir, FileName), FullPage = true
        });
    }
    private static void T50VerifyScreenshots()
    {
        var BeforePath = Path.Combine(ScreenshotDir, string.Format(
            E2EWorkflowConstants.StepScreenshotFormat, E2EWorkflowConstants.StepAddComments,
            E2EWorkflowConstants.BeforeLabel));
        var AfterPath = Path.Combine(ScreenshotDir, string.Format(
            E2EWorkflowConstants.StepScreenshotFormat, E2EWorkflowConstants.StepAddComments,
            E2EWorkflowConstants.AfterLabel));
        Assert.IsTrue(File.Exists(BeforePath), "T50: Before screenshot exists");
        Assert.IsTrue(File.Exists(AfterPath), "T50: After screenshot exists");
        Assert.IsTrue(new FileInfo(BeforePath).Length > E2EWorkflowConstants.MinScreenshotBytes,
            "T50: Before screenshot not blank");
        Assert.IsTrue(new FileInfo(AfterPath).Length > E2EWorkflowConstants.MinScreenshotBytes,
            "T50: After screenshot not blank");
    }
    private static async Task T50CleanupAsync()
    {
        await T50LoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
        await T50Http!.DeleteAsync(string.Format(RouteConstants.ApiReviewCommentById, T50CommentId));
        await T50Http!.DeleteAsync(string.Format(RouteConstants.ApiPullRequestById, T50PrId));
        await T50Http!.DeleteAsync(string.Format(RouteConstants.ApiSourceCodeDelete, T50TaskId));
        await T50Http!.DeleteAsync(string.Format(RouteConstants.ApiTaskById, T50TaskId));
    }
}
