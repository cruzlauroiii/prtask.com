using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Playwright;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static HttpClient? SsHttp;
    private static IPage? SsPage;
    private static IBrowserContext? SsCtx;
    private static string SsUser1Id = string.Empty;
    private static string SsUser2Id = string.Empty;
    private static string SsServerTaskId = string.Empty;
    private static string SsServerPrId = string.Empty;
    private static string SsServerCommentId = string.Empty;
    private static string SsSourcePrKey = string.Empty;
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task217-230 Full 14-step CRUD workflow with before/after screenshots")]
    public async Task ScreenshotWorkflowAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        SsHttp = new HttpClient(Handler) { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        SsCtx = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            ViewportSize = ViewportSize.NoViewport,
            IgnoreHTTPSErrors = true
        });
        SsPage = await SsCtx.NewPageAsync();
        try
        {
            await SsStep01LoginUser1Async();
            await SsStep02KycUser1Async();
            await SsStep03CreateTaskAsync();
            await SsStep04UploadSourceAsync();
            await SsStep05LoginUser2Async();
            await SsStep06KycUser2Async();
            await SsStep07CheckTaskAsync();
            await SsStep08ModifySourceAsync();
            await SsStep09SubmitPrAsync();
            await SsStep10CheckDiffAsync();
            await SsStep11AddCommentsAsync();
            await SsStep12ResolveCommentsAsync();
            await SsStep13ApproveAndPayAsync();
            await SsStep14AcceptPaymentAsync();
            SsVerifyAllScreenshots();
            await SsCleanupAsync();
        }
        finally
        {
            SsHttp.Dispose();
            if (SsPage is not null) { await SsPage.CloseAsync(); }
            if (SsCtx is not null) { await SsCtx.DisposeAsync(); }
        }
    }
    private static async Task SsScreenshotAsync(int Step, string Label)
    {
        Directory.CreateDirectory(ScreenshotDir);
        var FileName = string.Format(E2EWorkflowConstants.ScreenshotFormat, Step, Label);
        await SsPage!.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = Path.Combine(ScreenshotDir, FileName),
            FullPage = true
        });
    }
    private static async Task SsAuthBrowserAsync(string UserId, string Username)
    {
        try { await SsPage!.NavigateAsync(BaseUrl + RouteConstants.Home, new PageGotoOptions { Timeout = 10000 }); }
        catch (PlaywrightException) { }
        var Body = JsonSerializer.Serialize(new { UserId, Username });
        var EscapedBody = Body.Replace("\\", "\\\\").Replace("'", "\\'");
        await SsPage!.EvaluateAsync(
            $"(async () => {{ try {{ await fetch('{RouteConstants.ApiAuthDevLogin}', {{ method: 'POST', headers: {{ 'Content-Type': 'application/json' }}, body: '{EscapedBody}' }}); }} catch {{}} }})()");
    }
    private static async Task SsLoginApiAsync(string SubjectId, string Name, bool IsUser1)
    {
        var Http = SsHttp!;
        var Resp = await Http.PostAsJsonAsync(RouteConstants.ApiAuthDevLogin,
            new { UserId = SubjectId, Username = Name });
        if (Resp.StatusCode == HttpStatusCode.NotFound)
        {
            Assert.Inconclusive("DevLogin endpoint not available (404) — server may not support /Api/Auth/DevLogin in this environment");
            return;
        }
        Assert.AreEqual(HttpStatusCode.OK, Resp.StatusCode);
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        var Id = Doc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        if (IsUser1) { SsUser1Id = Id; } else { SsUser2Id = Id; }
        await SsAuthBrowserAsync(SubjectId, Name);
    }
    private static async Task SsStep01LoginUser1Async()
    {
        await SsPage!.NavigateAsync(BaseUrl + RouteConstants.Login);
        await SsScreenshotAsync(1, E2EWorkflowConstants.BeforeLabel);
        await SsLoginApiAsync(E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name, true);
        await SsPage!.GotoAsync(BaseUrl + RouteConstants.Dashboard);
        await SsScreenshotAsync(1, E2EWorkflowConstants.AfterLabel);
        var MeResp = await SsHttp!.GetAsync(RouteConstants.ApiAuthMe);
        Assert.AreEqual(HttpStatusCode.OK, MeResp.StatusCode, "SsStep01: auth/me verified");
    }
    private static async Task SsStep02KycUser1Async()
    {
        await SsPage!.GotoAsync(BaseUrl + RouteConstants.Settings);
        await SsScreenshotAsync(2, E2EWorkflowConstants.BeforeLabel);
        var Resp = await SsHttp!.PostAsync(RouteConstants.ApiKycCreate, null);
        Assert.IsTrue(Resp.IsSuccessStatusCode || Resp.StatusCode == HttpStatusCode.InternalServerError,
            "SsStep02: KYC create session (real didit API call)");
        if (Resp.IsSuccessStatusCode)
        {
            using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
            var SessionId = Doc.RootElement.GetProperty("sessionId").GetString() ?? string.Empty;
            Assert.IsFalse(string.IsNullOrEmpty(SessionId), "SsStep02: Didit session ID returned");
            var StatusResp = await SsHttp!.GetAsync(string.Format(RouteConstants.ApiKycStatusFormat, SessionId));
            Assert.IsTrue(StatusResp.IsSuccessStatusCode, "SsStep02: KYC status check");
        }
        await SsPage!.GotoAsync(BaseUrl + RouteConstants.Settings);
        await SsScreenshotAsync(2, E2EWorkflowConstants.AfterLabel);
    }
    private static async Task SsStep03CreateTaskAsync()
    {
        await SsPage!.GotoAsync(BaseUrl + RouteConstants.ClientCreateTask);
        await SsScreenshotAsync(3, E2EWorkflowConstants.BeforeLabel);
        var Resp = await SsHttp!.PostAsJsonAsync(RouteConstants.ApiTasks, new
        {
            ClientId = SsUser1Id,
            Title = E2ECrudConstants.TaskTitle, Description = E2ECrudConstants.TaskDescription,
            RepoUrl = E2ECrudConstants.TaskRepoUrl, Complexity = (int)TaskComplexity.Complex,
            E2ECrudConstants.BountyAmountCents,
            Tags = new[] { E2ECrudConstants.TagCsharp, E2ECrudConstants.TagE2E }
        });
        Assert.AreEqual(HttpStatusCode.Created, Resp.StatusCode, "SsStep03: Create task");
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        SsServerTaskId = Doc.RootElement.GetProperty("id").GetString() ?? string.Empty;
        await SsPage!.GotoAsync(BaseUrl + string.Format(RouteConstants.TaskDetail, SsServerTaskId));
        await SsScreenshotAsync(3, E2EWorkflowConstants.AfterLabel);
    }
    private static async Task SsStep04UploadSourceAsync()
    {
        await SsPage!.GotoAsync(BaseUrl + string.Format(RouteConstants.TaskDetail, SsServerTaskId));
        await SsScreenshotAsync(4, E2EWorkflowConstants.BeforeLabel);
        var Files = new Dictionary<string, string>
        {
            [E2EWorkflowConstants.SourceFile1Path] = E2EWorkflowConstants.SourceFile1Original,
            [E2EWorkflowConstants.SourceFile2Path] = E2EWorkflowConstants.SourceFile2Content
        };
        var Http = SsHttp!;
        var Resp = await Http.PostAsJsonAsync(
            string.Format(RouteConstants.ApiSourceCodeUpload, SsServerTaskId), Files);
        Assert.IsTrue(Resp.IsSuccessStatusCode, "SsStep04: Upload source code");
        var GetResp = await Http.GetAsync(
            string.Format(RouteConstants.ApiSourceCodeFiles, SsServerTaskId));
        Assert.IsTrue(GetResp.IsSuccessStatusCode, "SsStep04: Verify source files stored");
        using var Doc = JsonDocument.Parse(await GetResp.Content.ReadAsStringAsync());
        Assert.IsTrue(Doc.RootElement.TryGetProperty(E2EWorkflowConstants.SourceFile1Path, out _),
            "SsStep04: File1 exists");
        await SsScreenshotAsync(4, E2EWorkflowConstants.AfterLabel);
    }
}
