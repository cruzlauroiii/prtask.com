using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Playwright;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static HttpClient? T51Http;
    private static IPage? T51Page;
    private static IBrowserContext? T51Ctx;
    private static string T51User1Id = string.Empty;
    private static string T51User2Id = string.Empty;
    private static string T51TaskId = string.Empty;
    private static string T51PrId = string.Empty;
    private static string T51CommentId = string.Empty;
    private static readonly string T51PrKey = Guid.NewGuid().ToString();
    [TestMethod, TestCategory("Rules")]
    [DisplayName("T51 User 2 fixes replies and resolves comments with before/after screenshots and DB verification")]
    public async Task T51ResolveCommentsAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        T51Http = new HttpClient(Handler) { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        T51Ctx = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            ViewportSize = ViewportSize.NoViewport,
            IgnoreHTTPSErrors = true
        });
        T51Page = await T51Ctx.NewPageAsync();
        try
        {
            await T51SetupAsync();
            await T51LoginAsync(E2ECrudConstants.User2SubjectId, E2ECrudConstants.User2Name, false);
            await T51Page!.GotoAsync(BaseUrl + string.Format(RouteConstants.PullRequestDetail, T51PrId));
            await T51ScreenshotAsync(E2EWorkflowConstants.BeforeLabel);
            var ReplyComment = new
            {
                PullRequestId = T51PrId,
                AuthorId = T51User2Id, FilePath = E2ECrudConstants.CommentFilePath,
                LineNumber = E2ECrudConstants.CommentLineNumber,
                Body = E2EWorkflowConstants.ReplyBody,
                ParentCommentId = T51CommentId
            };
            var ReplyResp = await T51Http!.PostAsJsonAsync(RouteConstants.ApiReviewComments, ReplyComment);
            Assert.IsTrue(ReplyResp.IsSuccessStatusCode, "T51: Reply comment created");
            var ResolveResp = await T51Http!.PostAsync(
                string.Format(RouteConstants.ApiReviewCommentResolve, T51CommentId), null);
            Assert.AreEqual(HttpStatusCode.OK, ResolveResp.StatusCode, "T51: Resolve comment");
            var ListResp = await T51Http!.GetAsync(
                string.Format(RouteConstants.ApiReviewCommentsByPr, T51PrId));
            Assert.AreEqual(HttpStatusCode.OK, ListResp.StatusCode, "T51: List comments");
            using var Doc = JsonDocument.Parse(await ListResp.Content.ReadAsStringAsync());
            Assert.IsTrue(Doc.RootElement.GetArrayLength() >= 2, "T51: Reply and original exist");
            var FoundResolved = false;
            for (var I = 0; I < Doc.RootElement.GetArrayLength(); I++)
            {
                var Cmt = Doc.RootElement[I];
                if (Cmt.GetProperty("id").GetString() == T51CommentId)
                {
                    Assert.IsTrue(Cmt.GetProperty("isResolved").GetBoolean(),
                        E2EWorkflowConstants.CommentResolvedAssertMsg);
                    FoundResolved = true;
                }
            }
            Assert.IsTrue(FoundResolved, "T51: Original comment found and verified resolved");
            await T51Page!.GotoAsync(BaseUrl + string.Format(RouteConstants.PullRequestDetail, T51PrId));
            await T51ScreenshotAsync(E2EWorkflowConstants.AfterLabel);
            T51VerifyScreenshots();
            await T51CleanupAsync();
        }
        finally
        {
            T51Http.Dispose();
            if (T51Page is not null) { await T51Page.CloseAsync(); }
            if (T51Ctx is not null) { await T51Ctx.DisposeAsync(); }
        }
    }
    private static async Task T51SetupAsync()
    {
        await T51LoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
        var TaskResp = await T51Http!.PostAsJsonAsync(RouteConstants.ApiTasks, new
        {
            ClientId = T51User1Id,
            Title = E2ECrudConstants.TaskTitle, Description = E2ECrudConstants.TaskDescription,
            RepoUrl = E2ECrudConstants.TaskRepoUrl, Complexity = (int)TaskComplexity.Complex,
            E2ECrudConstants.BountyAmountCents,
            Tags = new[] { E2ECrudConstants.TagCsharp, E2ECrudConstants.TagE2E }
        });
        Assert.AreEqual(HttpStatusCode.Created, TaskResp.StatusCode, "T51Setup: Create task");
        using var TaskDoc = JsonDocument.Parse(await TaskResp.Content.ReadAsStringAsync());
        T51TaskId = TaskDoc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        var OrigFiles = new Dictionary<string, string>
        {
            [E2EWorkflowConstants.SourceFile1Path] = E2EWorkflowConstants.SourceFile1Original,
            [E2EWorkflowConstants.SourceFile2Path] = E2EWorkflowConstants.SourceFile2Content
        };
        await T51Http!.PostAsJsonAsync(string.Format(RouteConstants.ApiSourceCodeUpload, T51TaskId), OrigFiles);
        await T51LoginAsync(E2ECrudConstants.User2SubjectId, E2ECrudConstants.User2Name, false);
        await T51Http!.PostAsJsonAsync(
            string.Format(RouteConstants.ApiTaskClaim, T51TaskId), new { DeveloperId = T51User2Id });
        var ModFiles = new Dictionary<string, string>
        {
            [E2EWorkflowConstants.SourceFile1Path] = E2EWorkflowConstants.SourceFile1Modified,
            [E2EWorkflowConstants.SourceFile2Path] = E2EWorkflowConstants.SourceFile2Content
        };
        await T51Http!.PostAsJsonAsync(
            string.Format(RouteConstants.ApiSourceCodeModify, T51TaskId, T51PrKey), ModFiles);
        var Pr = new
        {
            TaskId = T51TaskId,
            DeveloperId = T51User2Id, GitHubPrUrl = E2ECrudConstants.PrGitHubUrl,
            FilesChanged = E2ECrudConstants.PrFilesChanged,
            Additions = E2ECrudConstants.PrAdditions, Deletions = E2ECrudConstants.PrDeletions
        };
        var PrResp = await T51Http!.PostAsJsonAsync(RouteConstants.ApiPullRequests, Pr);
        Assert.AreEqual(HttpStatusCode.Created, PrResp.StatusCode, "T51Setup: Submit PR");
        using var PrDoc = JsonDocument.Parse(await PrResp.Content.ReadAsStringAsync());
        T51PrId = PrDoc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        await T51LoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
        var Comment = new
        {
            PullRequestId = T51PrId,
            AuthorId = T51User1Id, FilePath = E2ECrudConstants.CommentFilePath,
            LineNumber = E2ECrudConstants.CommentLineNumber, Body = E2ECrudConstants.CommentBody
        };
        var CmtResp = await T51Http!.PostAsJsonAsync(RouteConstants.ApiReviewComments, Comment);
        Assert.AreEqual(HttpStatusCode.Created, CmtResp.StatusCode, "T51Setup: Create comment");
        using var CmtDoc = JsonDocument.Parse(await CmtResp.Content.ReadAsStringAsync());
        T51CommentId = CmtDoc.RootElement.GetProperty("id").GetString() ?? string.Empty;
    }
    private static async Task T51LoginAsync(string SubjectId, string Name, bool IsUser1)
    {
        var Resp = await T51Http!.PostAsJsonAsync(RouteConstants.ApiAuthDevLogin,
            new { UserId = SubjectId, Username = Name });
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode);
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        var Id = Doc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        if (IsUser1) { T51User1Id = Id; } else { T51User2Id = Id; }
    }
    private static async Task T51ScreenshotAsync(string Label)
    {
        Directory.CreateDirectory(ScreenshotDir);
        var FileName = string.Format(E2EWorkflowConstants.StepScreenshotFormat,
            E2EWorkflowConstants.StepResolveComments, Label);
        await T51Page!.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = Path.Combine(ScreenshotDir, FileName), FullPage = true
        });
    }
    private static void T51VerifyScreenshots()
    {
        var BeforePath = Path.Combine(ScreenshotDir, string.Format(
            E2EWorkflowConstants.StepScreenshotFormat, E2EWorkflowConstants.StepResolveComments,
            E2EWorkflowConstants.BeforeLabel));
        var AfterPath = Path.Combine(ScreenshotDir, string.Format(
            E2EWorkflowConstants.StepScreenshotFormat, E2EWorkflowConstants.StepResolveComments,
            E2EWorkflowConstants.AfterLabel));
        Assert.IsTrue(File.Exists(BeforePath), "T51: Before screenshot exists");
        Assert.IsTrue(File.Exists(AfterPath), "T51: After screenshot exists");
        Assert.IsTrue(new FileInfo(BeforePath).Length > E2EWorkflowConstants.MinScreenshotBytes,
            "T51: Before screenshot not blank");
        Assert.IsTrue(new FileInfo(AfterPath).Length > E2EWorkflowConstants.MinScreenshotBytes,
            "T51: After screenshot not blank");
    }
    private static async Task T51CleanupAsync()
    {
        await T51LoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
        await T51Http!.DeleteAsync(string.Format(RouteConstants.ApiReviewCommentById, T51CommentId));
        await T51Http!.DeleteAsync(string.Format(RouteConstants.ApiPullRequestById, T51PrId));
        await T51Http!.DeleteAsync(string.Format(RouteConstants.ApiSourceCodeDelete, T51TaskId));
        await T51Http!.DeleteAsync(string.Format(RouteConstants.ApiTaskById, T51TaskId));
    }
}
