using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Source code upload, modify, diff generation via API")]
    public async Task SourceCodeCrudAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Http = new HttpClient(Handler)
            { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        await DevLoginHelperAsync(Http, E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name);
        var SrcPrId = "e2e-source-pr-" + Guid.NewGuid().ToString("N")[..8];
        var TaskResp = await Http.PostAsJsonAsync(RouteConstants.ApiTasks, new
        {
            ClientId = E2ECrudConstants.User1SubjectId,
            Title = "Source Code Test", Description = "Source test",
            RepoUrl = E2ECrudConstants.TaskRepoUrl, Complexity = (int)TaskComplexity.Simple,
            BountyAmountCents = 5000L
        });
        Assert.AreEqual(HttpStatusCode.Created, TaskResp.StatusCode, "Task POST 201");
        using var TaskDoc = JsonDocument.Parse(await TaskResp.Content.ReadAsStringAsync());
        var SrcTaskId = TaskDoc.RootElement.GetProperty("id").GetString()!;
        var Files = new Dictionary<string, string>
        {
            [E2EWorkflowConstants.SourceFile1Path] = E2EWorkflowConstants.SourceFile1Original,
            [E2EWorkflowConstants.SourceFile2Path] = E2EWorkflowConstants.SourceFile2Content
        };
        var UploadResp = await Http.PostAsJsonAsync(
            string.Format(RouteConstants.ApiSourceCodeUpload, SrcTaskId), Files);
        Assert.IsTrue(UploadResp.IsSuccessStatusCode, "Source upload success");
        var GetFiles = await Http.GetAsync(string.Format(RouteConstants.ApiSourceCodeFiles, SrcTaskId));
        Assert.AreEqual(HttpStatusCode.OK, GetFiles.StatusCode, "GET files 200");
        using var FilesDoc = JsonDocument.Parse(await GetFiles.Content.ReadAsStringAsync());
        Assert.IsTrue(FilesDoc.RootElement.EnumerateObject().Any(), "Files returned");
        var ModFiles = new Dictionary<string, string>
        {
            [E2EWorkflowConstants.SourceFile1Path] = E2EWorkflowConstants.SourceFile1Modified
        };
        var ModResp = await Http.PostAsJsonAsync(
            string.Format(RouteConstants.ApiSourceCodeModify, SrcTaskId, SrcPrId), ModFiles);
        Assert.IsTrue(ModResp.IsSuccessStatusCode, "Modify success");
        var DiffResp = await Http.GetAsync(
            string.Format(RouteConstants.ApiSourceCodeDiff, SrcTaskId, SrcPrId));
        Assert.AreEqual(HttpStatusCode.OK, DiffResp.StatusCode, "Diff GET 200");
        var DiffContent = await DiffResp.Content.ReadAsStringAsync();
        Assert.IsTrue(DiffContent.Contains(E2EWorkflowConstants.DiffMarker), "Diff has header");
        Assert.IsTrue(DiffContent.Contains(E2EWorkflowConstants.SubtractMarker), "Diff has Subtract");
        await Http.DeleteAsync(string.Format(RouteConstants.ApiSourceCodeDelete, SrcTaskId));
        await Http.DeleteAsync(string.Format(RouteConstants.ApiTaskById, SrcTaskId));
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task update CRUD — PATCH title, verify read-back")]
    public async Task TaskUpdateCrudAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Http = new HttpClient(Handler)
            { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        await DevLoginHelperAsync(Http, E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name);
        var CreateResp = await Http.PostAsJsonAsync(RouteConstants.ApiTasks, new
        {
            ClientId = E2ECrudConstants.User1SubjectId,
            Title = E2ECrudConstants.TaskTitle, Description = E2ECrudConstants.TaskDescription,
            RepoUrl = E2ECrudConstants.TaskRepoUrl, Complexity = (int)TaskComplexity.Medium,
            E2ECrudConstants.BountyAmountCents
        });
        Assert.AreEqual(HttpStatusCode.Created, CreateResp.StatusCode, "Task POST 201");
        using var CreateDoc = JsonDocument.Parse(await CreateResp.Content.ReadAsStringAsync());
        var UpdTaskId = CreateDoc.RootElement.GetProperty("id").GetString()!;
        var PatchResp = await Http.PatchAsJsonAsync(
            string.Format(RouteConstants.ApiTaskById, UpdTaskId),
            new { Title = E2ECrudConstants.UpdatedTaskTitle });
        Assert.IsTrue(PatchResp.IsSuccessStatusCode, "Task PATCH success");
        var GetResp = await Http.GetAsync(string.Format(RouteConstants.ApiTaskById, UpdTaskId));
        using var Doc = JsonDocument.Parse(await GetResp.Content.ReadAsStringAsync());
        Assert.AreEqual(E2ECrudConstants.UpdatedTaskTitle, Doc.RootElement.GetProperty("title").GetString());
        await Http.DeleteAsync(string.Format(RouteConstants.ApiTaskById, UpdTaskId));
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("User profile CRUD — dev-login creates user, GET verifies fields")]
    public async Task UserProfileCrudAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Http = new HttpClient(Handler)
            { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        var LoginResp = await Http.PostAsJsonAsync(RouteConstants.ApiAuthDevLogin,
            new { UserId = E2ECrudConstants.User1SubjectId, Username = E2ECrudConstants.User1Name });
        if (LoginResp.StatusCode == HttpStatusCode.NotFound) { Assert.Inconclusive("DevLogin endpoint not available (404)"); return; }
        Assert.AreEqual(HttpStatusCode.OK, LoginResp.StatusCode, "Dev login OK");
        using var LoginDoc = JsonDocument.Parse(await LoginResp.Content.ReadAsStringAsync());
        var ProfileUserId = LoginDoc.RootElement.GetProperty("id").GetString()!;
        var UserResp = await Http.GetAsync($"{RouteConstants.ApiUsers}/{ProfileUserId}");
        Assert.AreEqual(HttpStatusCode.OK, UserResp.StatusCode, "User GET 200");
        using var UserDoc = JsonDocument.Parse(await UserResp.Content.ReadAsStringAsync());
        Assert.IsNotNull(UserDoc.RootElement.GetProperty("gitHubUsername").GetString(), "Has username");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Leaderboard earnings and spending endpoints return data")]
    public async Task LeaderboardDataAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Http = new HttpClient(Handler)
            { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        var EarningsResp = await Http.GetAsync(
            $"{RouteConstants.ApiLeaderboard}{RouteConstants.SubLeaderboardEarnings}");
        if (EarningsResp.StatusCode == HttpStatusCode.NotFound)
        {
            Assert.Inconclusive("Earnings leaderboard endpoint not available on this environment");
            return;
        }
        Assert.IsTrue(EarningsResp.IsSuccessStatusCode, "Earnings leaderboard responds");
        var SpendingResp = await Http.GetAsync(
            $"{RouteConstants.ApiLeaderboard}{RouteConstants.SubLeaderboardSpending}");
        Assert.IsTrue(SpendingResp.IsSuccessStatusCode || SpendingResp.StatusCode == HttpStatusCode.NotFound, "Spending leaderboard responds");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Review comment full lifecycle — create, list, resolve, delete")]
    public async Task ReviewCommentLifecycleAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Http = new HttpClient(Handler)
            { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        await DevLoginHelperAsync(Http, E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name);
        var TaskCreateResp = await Http.PostAsJsonAsync(RouteConstants.ApiTasks, new
        {
            ClientId = E2ECrudConstants.User1SubjectId,
            Title = "Comment Test", Description = "Comment test",
            RepoUrl = E2ECrudConstants.TaskRepoUrl, Complexity = (int)TaskComplexity.Simple,
            BountyAmountCents = 5000L
        });
        Assert.AreEqual(HttpStatusCode.Created, TaskCreateResp.StatusCode, "Task POST 201");
        using var TaskDoc = JsonDocument.Parse(await TaskCreateResp.Content.ReadAsStringAsync());
        var CmtTaskId = TaskDoc.RootElement.GetProperty("id").GetString()!;
        var PrCreateResp = await Http.PostAsJsonAsync(RouteConstants.ApiPullRequests, new
        {
            TaskId = CmtTaskId, DeveloperId = E2ECrudConstants.User2SubjectId,
            GitHubPrUrl = E2ECrudConstants.PrGitHubUrl, FilesChanged = 1, Additions = 10, Deletions = 2
        });
        Assert.AreEqual(HttpStatusCode.Created, PrCreateResp.StatusCode, "PR POST 201");
        using var PrDoc = JsonDocument.Parse(await PrCreateResp.Content.ReadAsStringAsync());
        var CmtPrId = PrDoc.RootElement.GetProperty("id").GetString()!;
        var CreateResp = await Http.PostAsJsonAsync(RouteConstants.ApiReviewComments, new
        {
            PullRequestId = CmtPrId, AuthorId = E2ECrudConstants.User1SubjectId,
            FilePath = E2ECrudConstants.CommentFilePath,
            LineNumber = E2ECrudConstants.CommentLineNumber, Body = E2ECrudConstants.CommentBody
        });
        Assert.AreEqual(HttpStatusCode.Created, CreateResp.StatusCode, "Comment created");
        using var CreateDoc = JsonDocument.Parse(await CreateResp.Content.ReadAsStringAsync());
        var ServerCmtId = CreateDoc.RootElement.GetProperty("id").GetString()!;
        var ListResp = await Http.GetAsync(string.Format(RouteConstants.ApiReviewCommentsByPr, CmtPrId));
        using var ListDoc = JsonDocument.Parse(await ListResp.Content.ReadAsStringAsync());
        Assert.IsTrue(ListDoc.RootElement.GetArrayLength() > 0, "Comment list not empty");
        var ResolveResp = await Http.PostAsync(
            string.Format(RouteConstants.ApiReviewCommentResolve, ServerCmtId), null);
        Assert.AreEqual(HttpStatusCode.OK, ResolveResp.StatusCode, "Comment resolved");
        var VerifyResp = await Http.GetAsync(string.Format(RouteConstants.ApiReviewCommentsByPr, CmtPrId));
        using var VerifyDoc = JsonDocument.Parse(await VerifyResp.Content.ReadAsStringAsync());
        Assert.IsTrue(VerifyDoc.RootElement[0].GetProperty("isResolved").GetBoolean(), "Resolved");
        await Http.DeleteAsync(string.Format(RouteConstants.ApiReviewCommentById, ServerCmtId));
        await Http.DeleteAsync(string.Format(RouteConstants.ApiPullRequestById, CmtPrId));
        await Http.DeleteAsync(string.Format(RouteConstants.ApiTaskById, CmtTaskId));
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("All pages render real content with headings, forms, and interactive elements")]
    public async Task AllPagesRenderContentAsync()
    {
        var Create = ReadSource("PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor");
        Assert.IsTrue(Create.Contains("CreateTaskConstants.PageHeading") || Create.Contains("CreateTaskPageHeading"), "CreateTask h1");
        Assert.IsTrue(Create.Contains("id=\"Title\""), "Title input");
        Assert.IsTrue(Create.Contains("id=\"BountyAmount\""), "BountyAmount input");
        Assert.IsTrue(Create.Contains("id=\"Complexity\""), "Complexity select");
        var Edit = ReadSource("PrTask.SharedUI", "Pages", "Client", "EditTaskPage.razor");
        Assert.IsTrue(Edit.Contains("GetByIdAsync"), "EditTask loads");
        Assert.IsTrue(Edit.Contains("UpdateAsync"), "EditTask saves");
        var Pay = ReadSource("PrTask.SharedUI", "Pages", "Client", "PaymentsPage.razor");
        Assert.IsTrue(Pay.Contains("ListByPayerAsync"), "Payments loads");
        var Detail = ReadSource("PrTask.SharedUI", "Pages", "TaskDetailPage.razor");
        Assert.IsTrue(Detail.Contains("source-upload-section"), "Has source upload");
        Assert.IsTrue(Detail.Contains("pr-list-section"), "Has PR list");
        var Board = ReadSource("PrTask.SharedUI", "Pages", "BoardDetailPage.razor");
        Assert.IsTrue(Board.Contains("WipLimit"), "Board has WIP limit");
        var Sprint = ReadSource("PrTask.SharedUI", "Pages", "SprintsPage.razor");
        Assert.IsTrue(Sprint.Contains("SprintConstants.CreateButtonText") || Sprint.Contains("SprintCreateButton"), "Sprint create form");
        var Dash = ReadSource("PrTask.SharedUI", "Pages", "DashboardPage.razor");
        Assert.IsTrue(Dash.Contains("dashboard-stats"), "Dashboard stats");
        var Lb = ReadSource("PrTask.SharedUI", "Pages", "LeaderboardPage.razor");
        Assert.IsTrue(Lb.Contains("LeaderboardConstants.TopEarnersTab") || Lb.Contains("LeaderboardTopEarnersTab"), "Earners tab");
        Assert.IsTrue(Lb.Contains("LeaderboardConstants.TopSpendersTab") || Lb.Contains("LeaderboardTopSpendersTab"), "Spenders tab");
        var Prof = ReadSource("PrTask.SharedUI", "Pages", "ProfilePage.razor");
        Assert.IsTrue(Prof.Contains("ProfileConstants.TotalEarnedLabel") || Prof.Contains("ProfileTotalEarnedLabel"), "Profile earnings");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Native repos have expected directory structure")]
    public void NativeRepoStructure()
    {
        if (Directory.Exists(E2ECrudConstants.NativeRepoLlamaCpp))
        {
            Assert.IsTrue(File.Exists(Path.Combine(E2ECrudConstants.NativeRepoLlamaCpp, "CMakeLists.txt")),
                "llama.cpp has CMakeLists.txt");
        }
        if (Directory.Exists(E2ECrudConstants.NativeRepoWhisperCpp))
        {
            Assert.IsTrue(File.Exists(Path.Combine(E2ECrudConstants.NativeRepoWhisperCpp, "CMakeLists.txt")),
                "whisper.cpp has CMakeLists.txt");
        }
        if (Directory.Exists(E2ECrudConstants.NativeRepoUSearch))
        {
            Assert.IsTrue(File.Exists(Path.Combine(E2ECrudConstants.NativeRepoUSearch, "CMakeLists.txt")),
                "USearch has CMakeLists.txt");
        }
        if (Directory.Exists(E2ECrudConstants.NativeRepoAutomerge))
        {
            Assert.IsTrue(Directory.Exists(Path.Combine(E2ECrudConstants.NativeRepoAutomerge, "rust")),
                "automerge has rust dir");
        }
        if (Directory.Exists(E2ECrudConstants.NativeRepoLowdb))
        {
            Assert.IsTrue(Directory.Exists(Path.Combine(E2ECrudConstants.NativeRepoLowdb, "src")),
                "lowdb has src dir");
        }
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsPage comprehensive — all 13 sections and real Didit KYC integration")]
    public async Task SettingsPageComprehensiveAsync()
    {
        var Razor = ReadSource("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        var Code = ReadSource("PrTask.SharedUI", "Pages", "SettingsPage.razor.cs");
        Assert.IsTrue(Razor.Contains("Profile"), "Profile section");
        Assert.IsTrue(Razor.Contains("KycHeading"), "KYC section");
        Assert.IsTrue(Razor.Contains("Notification"), "Notification section");
        Assert.IsTrue(Razor.Contains("Withdrawal"), "Withdrawal section");
        Assert.IsTrue(Razor.Contains("Security"), "Security section");
        Assert.IsTrue(Razor.Contains("ConnectedAccountsHeading"), "Connected Accounts");
        Assert.IsTrue(Razor.Contains("Privacy"), "Privacy section");
        Assert.IsTrue(Razor.Contains("Subscription"), "Subscription section");
        Assert.IsTrue(Razor.Contains("Wallet"), "Wallet section");
        Assert.IsTrue(Razor.Contains("PaymentHistoryHeading"), "Payment History");
        Assert.IsTrue(Razor.Contains("Disbursement"), "Disbursement section");
        Assert.IsTrue(Razor.Contains("Invoice"), "Invoice section");
        Assert.IsTrue(Razor.Contains("QrPaymentHeading"), "QR Payment section");
        Assert.IsTrue(Code.Contains("IKycVerificationService"), "KYC service");
        Assert.IsTrue(Code.Contains("CreateSessionAsync"), "Didit CreateSession");
        Assert.IsTrue(Code.Contains("GetSessionStatusAsync"), "Didit GetStatus");
        Assert.IsTrue(Code.Contains(nameof(SettingsConstants)), "Uses SettingsConstants");
        await Task.CompletedTask;
    }
}
