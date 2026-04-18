using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Playwright;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static HttpClient? T49Http;
    private static IPage? T49Page;
    private static IBrowserContext? T49Ctx;
    private static string T49User1Id = string.Empty;
    private static string T49User2Id = string.Empty;
    private static string T49TaskId = string.Empty;
    private static string T49PrId = string.Empty;
    private static readonly string T49PrKey = Guid.NewGuid().ToString();
    [TestMethod, TestCategory("Rules")]
    [DisplayName("T49 User 1 reviews diff changes with before/after screenshots and DB verification")]
    public async Task T49ReviewDiffChangesAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        T49Http = new HttpClient(Handler) { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        T49Ctx = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            ViewportSize = ViewportSize.NoViewport,
            IgnoreHTTPSErrors = true
        });
        T49Page = await T49Ctx.NewPageAsync();
        try
        {
            await T49SetupAsync();
            await T49LoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
            await T49Page!.GotoAsync(BaseUrl + string.Format(RouteConstants.PullRequestDetail, T49PrId));
            await T49ScreenshotAsync(E2EWorkflowConstants.BeforeLabel);
            var DiffResp = await T49Http!.GetAsync(
                string.Format(RouteConstants.ApiSourceCodeDiff, T49TaskId, T49PrKey));
            Assert.IsTrue(DiffResp.IsSuccessStatusCode, "T49: Get diff as user 1");
            using var Doc = JsonDocument.Parse(await DiffResp.Content.ReadAsStringAsync());
            var Diff = Doc.RootElement.GetProperty(SourceCodeConstants.JsonDiff).GetString() ?? string.Empty;
            Assert.IsTrue(Diff.Contains(E2EWorkflowConstants.DiffMarker), "T49: Diff header present");
            Assert.IsTrue(Diff.Contains(E2EWorkflowConstants.SubtractMarker),
                "T49: Diff contains modified code");
            var PrResp = await T49Http!.GetAsync(
                string.Format(RouteConstants.ApiPullRequestById, T49PrId));
            Assert.AreEqual(HttpStatusCode.OK, PrResp.StatusCode, "T49: PR exists in DB");
            using var PrDoc = JsonDocument.Parse(await PrResp.Content.ReadAsStringAsync());
            Assert.AreEqual((int)PullRequestStatus.Submitted,
                PrDoc.RootElement.GetProperty("status").GetInt32(), "T49: PR status is Submitted");
            Assert.AreEqual(E2ECrudConstants.PrGitHubUrl,
                PrDoc.RootElement.GetProperty("gitHubPrUrl").GetString(), "T49: PR URL matches DB");
            var ModFilesResp = await T49Http!.GetAsync(
                string.Format(RouteConstants.ApiSourceCodeModifiedFiles, T49TaskId, T49PrKey));
            if (ModFilesResp.IsSuccessStatusCode)
            {
                using var FilesDoc = JsonDocument.Parse(await ModFilesResp.Content.ReadAsStringAsync());
                Assert.IsTrue(FilesDoc.RootElement.TryGetProperty(
                    E2EWorkflowConstants.SourceFile1Path, out _), "T49: Modified file exists in DB");
            }
            await T49Page!.GotoAsync(BaseUrl + string.Format(RouteConstants.PullRequestDetail, T49PrId));
            await T49ScreenshotAsync(E2EWorkflowConstants.AfterLabel);
            T49VerifyScreenshots();
            await T49CleanupAsync();
        }
        finally
        {
            T49Http.Dispose();
            if (T49Page is not null) { await T49Page.CloseAsync(); }
            if (T49Ctx is not null) { await T49Ctx.DisposeAsync(); }
        }
    }
    private static async Task T49SetupAsync()
    {
        await T49LoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
        var TaskResp = await T49Http!.PostAsJsonAsync(RouteConstants.ApiTasks, new
        {
            ClientId = T49User1Id,
            Title = E2ECrudConstants.TaskTitle, Description = E2ECrudConstants.TaskDescription,
            RepoUrl = E2ECrudConstants.TaskRepoUrl, Complexity = (int)TaskComplexity.Complex,
            E2ECrudConstants.BountyAmountCents,
            Tags = new[] { E2ECrudConstants.TagCsharp, E2ECrudConstants.TagE2E }
        });
        Assert.AreEqual(HttpStatusCode.Created, TaskResp.StatusCode, "T49Setup: Create task");
        using var TaskDoc = JsonDocument.Parse(await TaskResp.Content.ReadAsStringAsync());
        T49TaskId = TaskDoc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        var OrigFiles = new Dictionary<string, string>
        {
            [E2EWorkflowConstants.SourceFile1Path] = E2EWorkflowConstants.SourceFile1Original,
            [E2EWorkflowConstants.SourceFile2Path] = E2EWorkflowConstants.SourceFile2Content
        };
        await T49Http!.PostAsJsonAsync(string.Format(RouteConstants.ApiSourceCodeUpload, T49TaskId), OrigFiles);
        await T49LoginAsync(E2ECrudConstants.User2SubjectId, E2ECrudConstants.User2Name, false);
        await T49Http!.PostAsJsonAsync(
            string.Format(RouteConstants.ApiTaskClaim, T49TaskId), new { DeveloperId = T49User2Id });
        var ModFiles = new Dictionary<string, string>
        {
            [E2EWorkflowConstants.SourceFile1Path] = E2EWorkflowConstants.SourceFile1Modified,
            [E2EWorkflowConstants.SourceFile2Path] = E2EWorkflowConstants.SourceFile2Content
        };
        await T49Http!.PostAsJsonAsync(
            string.Format(RouteConstants.ApiSourceCodeModify, T49TaskId, T49PrKey), ModFiles);
        var Pr = new
        {
            TaskId = T49TaskId,
            DeveloperId = T49User2Id, GitHubPrUrl = E2ECrudConstants.PrGitHubUrl,
            FilesChanged = E2ECrudConstants.PrFilesChanged,
            Additions = E2ECrudConstants.PrAdditions, Deletions = E2ECrudConstants.PrDeletions
        };
        var PrResp = await T49Http!.PostAsJsonAsync(RouteConstants.ApiPullRequests, Pr);
        Assert.AreEqual(HttpStatusCode.Created, PrResp.StatusCode, "T49Setup: Submit PR");
        using var PrDoc = JsonDocument.Parse(await PrResp.Content.ReadAsStringAsync());
        T49PrId = PrDoc.RootElement.GetProperty("id").GetString() ?? string.Empty;
    }
    private static async Task T49LoginAsync(string SubjectId, string Name, bool IsUser1)
    {
        var Resp = await T49Http!.PostAsJsonAsync(RouteConstants.ApiAuthDevLogin,
            new { UserId = SubjectId, Username = Name });
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode);
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        var Id = Doc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        if (IsUser1) { T49User1Id = Id; } else { T49User2Id = Id; }
    }
    private static async Task T49ScreenshotAsync(string Label)
    {
        Directory.CreateDirectory(ScreenshotDir);
        var FileName = string.Format(E2EWorkflowConstants.StepScreenshotFormat,
            E2EWorkflowConstants.StepReviewDiff, Label);
        await T49Page!.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = Path.Combine(ScreenshotDir, FileName), FullPage = true
        });
    }
    private static void T49VerifyScreenshots()
    {
        var BeforePath = Path.Combine(ScreenshotDir, string.Format(
            E2EWorkflowConstants.StepScreenshotFormat, E2EWorkflowConstants.StepReviewDiff,
            E2EWorkflowConstants.BeforeLabel));
        var AfterPath = Path.Combine(ScreenshotDir, string.Format(
            E2EWorkflowConstants.StepScreenshotFormat, E2EWorkflowConstants.StepReviewDiff,
            E2EWorkflowConstants.AfterLabel));
        Assert.IsTrue(File.Exists(BeforePath), "T49: Before screenshot exists");
        Assert.IsTrue(File.Exists(AfterPath), "T49: After screenshot exists");
        Assert.IsTrue(new FileInfo(BeforePath).Length > E2EWorkflowConstants.MinScreenshotBytes,
            "T49: Before screenshot not blank");
        Assert.IsTrue(new FileInfo(AfterPath).Length > E2EWorkflowConstants.MinScreenshotBytes,
            "T49: After screenshot not blank");
    }
    private static async Task T49CleanupAsync()
    {
        await T49LoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
        await T49Http!.DeleteAsync(string.Format(RouteConstants.ApiPullRequestById, T49PrId));
        await T49Http!.DeleteAsync(string.Format(RouteConstants.ApiSourceCodeDelete, T49TaskId));
        await T49Http!.DeleteAsync(string.Format(RouteConstants.ApiTaskById, T49TaskId));
    }
}
