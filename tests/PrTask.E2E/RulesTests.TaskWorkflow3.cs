using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Playwright;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static HttpClient? T47Http;
    private static IPage? T47Page;
    private static IBrowserContext? T47Ctx;
    private static string T47User1Id = string.Empty;
    private static string T47User2Id = string.Empty;
    private static string T47TaskId = string.Empty;
    private static readonly string T47PrKey = Guid.NewGuid().ToString();
    [TestMethod, TestCategory("Rules")]
    [DisplayName("T47 User 2 modifies code on diff page with before/after screenshots and DB verification")]
    public async Task T47ModifyCodeOnDiffPageAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        T47Http = new HttpClient(Handler) { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        T47Ctx = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            ViewportSize = ViewportSize.NoViewport,
            IgnoreHTTPSErrors = true
        });
        T47Page = await T47Ctx.NewPageAsync();
        try
        {
            await T47SetupAsync();
            await T47Page!.GotoAsync(BaseUrl + string.Format(RouteConstants.PullRequestDetail, T47PrKey));
            await T47ScreenshotAsync(E2EWorkflowConstants.BeforeLabel);
            var ModFiles = new Dictionary<string, string>
            {
                [E2EWorkflowConstants.SourceFile1Path] = E2EWorkflowConstants.SourceFile1Modified,
                [E2EWorkflowConstants.SourceFile2Path] = E2EWorkflowConstants.SourceFile2Content
            };
            var ModResp = await T47Http!.PostAsJsonAsync(
                string.Format(RouteConstants.ApiSourceCodeModify, T47TaskId, T47PrKey), ModFiles);
            Assert.IsTrue(ModResp.IsSuccessStatusCode, "T47: Modify source code");
            var DiffResp = await T47Http!.GetAsync(
                string.Format(RouteConstants.ApiSourceCodeDiff, T47TaskId, T47PrKey));
            Assert.IsTrue(DiffResp.IsSuccessStatusCode, "T47: Get diff");
            using var Doc = JsonDocument.Parse(await DiffResp.Content.ReadAsStringAsync());
            var Diff = Doc.RootElement.GetProperty(SourceCodeConstants.JsonDiff).GetString() ?? string.Empty;
            Assert.IsTrue(Diff.Contains(E2EWorkflowConstants.DiffMarker), "T47: Diff header present");
            Assert.IsTrue(Diff.Contains(E2EWorkflowConstants.SubtractMarker),
                E2EWorkflowConstants.DiffContainsEditAssertMsg);
            await T47Page!.GotoAsync(BaseUrl + string.Format(RouteConstants.PullRequestDetail, T47PrKey));
            await T47ScreenshotAsync(E2EWorkflowConstants.AfterLabel);
            T47VerifyScreenshots();
            await T47CleanupAsync();
        }
        finally
        {
            T47Http.Dispose();
            if (T47Page is not null) { await T47Page.CloseAsync(); }
            if (T47Ctx is not null) { await T47Ctx.DisposeAsync(); }
        }
    }
    private static async Task T47SetupAsync()
    {
        await T47LoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
        var TaskResp = await T47Http!.PostAsJsonAsync(RouteConstants.ApiTasks, new
        {
            ClientId = T47User1Id,
            Title = E2ECrudConstants.TaskTitle, Description = E2ECrudConstants.TaskDescription,
            RepoUrl = E2ECrudConstants.TaskRepoUrl, Complexity = (int)TaskComplexity.Complex,
            E2ECrudConstants.BountyAmountCents,
            Tags = new[] { E2ECrudConstants.TagCsharp, E2ECrudConstants.TagE2E }
        });
        Assert.AreEqual(HttpStatusCode.Created, TaskResp.StatusCode, "T47Setup: Create task");
        using var TaskDoc = JsonDocument.Parse(await TaskResp.Content.ReadAsStringAsync());
        T47TaskId = TaskDoc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        var OrigFiles = new Dictionary<string, string>
        {
            [E2EWorkflowConstants.SourceFile1Path] = E2EWorkflowConstants.SourceFile1Original,
            [E2EWorkflowConstants.SourceFile2Path] = E2EWorkflowConstants.SourceFile2Content
        };
        await T47Http!.PostAsJsonAsync(string.Format(RouteConstants.ApiSourceCodeUpload, T47TaskId), OrigFiles);
        await T47LoginAsync(E2ECrudConstants.User2SubjectId, E2ECrudConstants.User2Name, false);
        await T47Http!.PostAsJsonAsync(
            string.Format(RouteConstants.ApiTaskClaim, T47TaskId), new { DeveloperId = T47User2Id });
    }
    private static async Task T47LoginAsync(string SubjectId, string Name, bool IsUser1)
    {
        var Resp = await T47Http!.PostAsJsonAsync(RouteConstants.ApiAuthDevLogin,
            new { UserId = SubjectId, Username = Name });
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode);
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        var Id = Doc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        if (IsUser1) { T47User1Id = Id; } else { T47User2Id = Id; }
    }
    private static async Task T47ScreenshotAsync(string Label)
    {
        Directory.CreateDirectory(ScreenshotDir);
        var FileName = string.Format(E2EWorkflowConstants.StepScreenshotFormat,
            E2EWorkflowConstants.StepModifyCode, Label);
        await T47Page!.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = Path.Combine(ScreenshotDir, FileName), FullPage = true
        });
    }
    private static void T47VerifyScreenshots()
    {
        var BeforePath = Path.Combine(ScreenshotDir, string.Format(
            E2EWorkflowConstants.StepScreenshotFormat, E2EWorkflowConstants.StepModifyCode,
            E2EWorkflowConstants.BeforeLabel));
        var AfterPath = Path.Combine(ScreenshotDir, string.Format(
            E2EWorkflowConstants.StepScreenshotFormat, E2EWorkflowConstants.StepModifyCode,
            E2EWorkflowConstants.AfterLabel));
        Assert.IsTrue(File.Exists(BeforePath), "T47: Before screenshot exists");
        Assert.IsTrue(File.Exists(AfterPath), "T47: After screenshot exists");
        Assert.IsTrue(new FileInfo(BeforePath).Length > E2EWorkflowConstants.MinScreenshotBytes,
            "T47: Before screenshot not blank");
        Assert.IsTrue(new FileInfo(AfterPath).Length > E2EWorkflowConstants.MinScreenshotBytes,
            "T47: After screenshot not blank");
    }
    private static async Task T47CleanupAsync()
    {
        await T47LoginAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
        await T47Http!.DeleteAsync(string.Format(RouteConstants.ApiSourceCodeDelete, T47TaskId));
        await T47Http!.DeleteAsync(string.Format(RouteConstants.ApiTaskById, T47TaskId));
    }
}
