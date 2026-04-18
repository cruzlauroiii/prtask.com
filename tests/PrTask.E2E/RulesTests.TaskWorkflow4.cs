using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Playwright;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static HttpClient? T48Http;
    private static IPage? T48Page;
    private static IBrowserContext? T48Ctx;
    private static string T48User1Id = string.Empty;
    private static string T48User2Id = string.Empty;
    private static string T48TaskId = string.Empty;
    private static string T48PrId = string.Empty;
    private static readonly string T48PrKey = Guid.NewGuid().ToString();
    [TestMethod, TestCategory("Rules")]
    [DisplayName("T48 User 2 submits PR with before/after screenshots and DB verification")]
    public async Task T48SubmitPrAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        T48Http = new HttpClient(Handler) { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        T48Ctx = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            ViewportSize = ViewportSize.NoViewport,
            IgnoreHTTPSErrors = true
        });
        T48Page = await T48Ctx.NewPageAsync();
        try
        {
            await T48SetupAsync();
            await T48Page!.GotoAsync(BaseUrl + string.Format(RouteConstants.SubmitPr, T48TaskId));
            await T48ScreenshotAsync(E2EWorkflowConstants.BeforeLabel);
            var Pr = new
            {
                TaskId = T48TaskId,
                DeveloperId = T48User2Id, GitHubPrUrl = E2ECrudConstants.PrGitHubUrl,
                FilesChanged = E2ECrudConstants.PrFilesChanged,
                Additions = E2ECrudConstants.PrAdditions, Deletions = E2ECrudConstants.PrDeletions
            };
            var Resp = await T48Http!.PostAsJsonAsync(RouteConstants.ApiPullRequests, Pr);
            Assert.AreEqual(HttpStatusCode.Created, Resp.StatusCode, E2EWorkflowConstants.PrCreatedAssertMsg);
            using var PrDoc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
            T48PrId = PrDoc.RootElement.GetProperty("id").GetString() ?? string.Empty;
            Assert.IsFalse(string.IsNullOrEmpty(T48PrId), "T48: PR ID assigned");
            var GetResp = await T48Http!.GetAsync(
                string.Format(RouteConstants.ApiPullRequestById, T48PrId));
            Assert.AreEqual(HttpStatusCode.OK, GetResp.StatusCode, "T48: PR persisted in DB");
            using var Doc = JsonDocument.Parse(await GetResp.Content.ReadAsStringAsync());
            Assert.AreEqual(E2ECrudConstants.PrGitHubUrl,
                Doc.RootElement.GetProperty("gitHubPrUrl").GetString(), "T48: PR URL matches");
            Assert.AreEqual(T48TaskId,
                Doc.RootElement.GetProperty("taskId").GetString(), "T48: TaskId matches");
            Assert.AreEqual((int)PullRequestStatus.Submitted,
                Doc.RootElement.GetProperty("status").GetInt32(), "T48: Status is Submitted");
            var DiffResp = await T48Http!.GetAsync(
                string.Format(RouteConstants.ApiSourceCodeDiff, T48TaskId, T48PrKey));
            if (DiffResp.IsSuccessStatusCode)
            {
                using var DiffDoc = JsonDocument.Parse(await DiffResp.Content.ReadAsStringAsync());
                var Diff = DiffDoc.RootElement.GetProperty(SourceCodeConstants.JsonDiff).GetString()
                    ?? string.Empty;
                Assert.IsTrue(Diff.Contains(E2EWorkflowConstants.SubtractMarker),
                    E2EWorkflowConstants.PrDiffMatchAssertMsg);
            }
            await T48Page!.GotoAsync(BaseUrl + string.Format(RouteConstants.PullRequestDetail, T48PrId));
            await T48ScreenshotAsync(E2EWorkflowConstants.AfterLabel);
            T48VerifyScreenshots();
            await T48CleanupAsync();
        }
        finally
        {
            T48Http.Dispose();
            if (T48Page is not null) { await T48Page.CloseAsync(); }
            if (T48Ctx is not null) { await T48Ctx.DisposeAsync(); }
        }
    }
    private static async Task T48SetupAsync()
    {
        await T48LoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
        var TaskResp = await T48Http!.PostAsJsonAsync(RouteConstants.ApiTasks, new
        {
            ClientId = T48User1Id,
            Title = E2ECrudConstants.TaskTitle, Description = E2ECrudConstants.TaskDescription,
            RepoUrl = E2ECrudConstants.TaskRepoUrl, Complexity = (int)TaskComplexity.Complex,
            E2ECrudConstants.BountyAmountCents,
            Tags = new[] { E2ECrudConstants.TagCsharp, E2ECrudConstants.TagE2E }
        });
        Assert.AreEqual(HttpStatusCode.Created, TaskResp.StatusCode, "T48Setup: Create task");
        using var TaskDoc = JsonDocument.Parse(await TaskResp.Content.ReadAsStringAsync());
        T48TaskId = TaskDoc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        var OrigFiles = new Dictionary<string, string>
        {
            [E2EWorkflowConstants.SourceFile1Path] = E2EWorkflowConstants.SourceFile1Original,
            [E2EWorkflowConstants.SourceFile2Path] = E2EWorkflowConstants.SourceFile2Content
        };
        await T48Http!.PostAsJsonAsync(string.Format(RouteConstants.ApiSourceCodeUpload, T48TaskId), OrigFiles);
        await T48LoginAsync(E2ECrudConstants.User2SubjectId, E2ECrudConstants.User2Name, false);
        await T48Http!.PostAsJsonAsync(
            string.Format(RouteConstants.ApiTaskClaim, T48TaskId), new { DeveloperId = T48User2Id });
        var ModFiles = new Dictionary<string, string>
        {
            [E2EWorkflowConstants.SourceFile1Path] = E2EWorkflowConstants.SourceFile1Modified,
            [E2EWorkflowConstants.SourceFile2Path] = E2EWorkflowConstants.SourceFile2Content
        };
        await T48Http!.PostAsJsonAsync(
            string.Format(RouteConstants.ApiSourceCodeModify, T48TaskId, T48PrKey), ModFiles);
    }
    private static async Task T48LoginAsync(string SubjectId, string Name, bool IsUser1)
    {
        var Resp = await T48Http!.PostAsJsonAsync(RouteConstants.ApiAuthDevLogin,
            new { UserId = SubjectId, Username = Name });
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode);
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        var Id = Doc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        if (IsUser1) { T48User1Id = Id; } else { T48User2Id = Id; }
    }
    private static async Task T48ScreenshotAsync(string Label)
    {
        Directory.CreateDirectory(ScreenshotDir);
        var FileName = string.Format(E2EWorkflowConstants.StepScreenshotFormat,
            E2EWorkflowConstants.StepSubmitPr, Label);
        await T48Page!.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = Path.Combine(ScreenshotDir, FileName), FullPage = true
        });
    }
    private static void T48VerifyScreenshots()
    {
        var BeforePath = Path.Combine(ScreenshotDir, string.Format(
            E2EWorkflowConstants.StepScreenshotFormat, E2EWorkflowConstants.StepSubmitPr,
            E2EWorkflowConstants.BeforeLabel));
        var AfterPath = Path.Combine(ScreenshotDir, string.Format(
            E2EWorkflowConstants.StepScreenshotFormat, E2EWorkflowConstants.StepSubmitPr,
            E2EWorkflowConstants.AfterLabel));
        Assert.IsTrue(File.Exists(BeforePath), "T48: Before screenshot exists");
        Assert.IsTrue(File.Exists(AfterPath), "T48: After screenshot exists");
        Assert.IsTrue(new FileInfo(BeforePath).Length > E2EWorkflowConstants.MinScreenshotBytes,
            "T48: Before screenshot not blank");
        Assert.IsTrue(new FileInfo(AfterPath).Length > E2EWorkflowConstants.MinScreenshotBytes,
            "T48: After screenshot not blank");
    }
    private static async Task T48CleanupAsync()
    {
        await T48LoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
        await T48Http!.DeleteAsync(string.Format(RouteConstants.ApiPullRequestById, T48PrId));
        await T48Http!.DeleteAsync(string.Format(RouteConstants.ApiSourceCodeDelete, T48TaskId));
        await T48Http!.DeleteAsync(string.Format(RouteConstants.ApiTaskById, T48TaskId));
    }
}
