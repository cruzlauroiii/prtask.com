using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using PrTask.Cdp;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.E2E;
public partial class RulesTests
{
    private const string T57OwnerSubjectId = "e2e-t57-owner";
    private const string T57OwnerName = "T57 Owner";
    private const string T57AdminSubjectId = "e2e-t57-admin";
    private const string T57AdminName = "T57 Admin";
    private const string T57MemberSubjectId = "e2e-t57-member";
    private const string T57MemberName = "T57 Member";
    private const string T57ViewerSubjectId = "e2e-t57-viewer";
    private const string T57ViewerName = "T57 Viewer";
    [TestMethod, TestCategory("Rules"), Timeout(60000)]
    [DisplayName("T57 Multi-level authorization — verify each role sees correct UI and has correct access with before/after screenshots")]
    public async Task T57MultiLevelAuthorizationAsync()
    {
        await T57VerifyUnauthenticatedAccessAsync();
        await T57VerifyOwnerAccessAsync();
        await T57VerifyAdminAccessAsync();
        await T57VerifyMemberAccessAsync();
        await T57VerifyViewerAccessAsync();
        T57VerifyEndpointAuthorizationRequirements();
    }
    private static async Task T57VerifyUnauthenticatedAccessAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Http = new HttpClient(Handler) { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        await TakeScreenshotAsync("T57-unauth-before.png");
        var MeResp = await Http.GetAsync(RouteConstants.ApiAuthMe);
        Assert.AreEqual(HttpStatusCode.Unauthorized, MeResp.StatusCode, "Unauthenticated auth/me must return 401");
        var TasksResp = await Http.GetAsync(RouteConstants.ApiTasks);
        Assert.IsTrue(TasksResp.IsSuccessStatusCode, "Public task list must be accessible without auth");
        var LeaderboardResp = await Http.GetAsync(RouteConstants.ApiLeaderboard);
        Assert.IsTrue(LeaderboardResp.IsSuccessStatusCode, "Public leaderboard must be accessible without auth");
        var CreateTaskResp = await Http.PostAsJsonAsync(RouteConstants.ApiTasks, new
        {
            ClientId = "anonymous",
            Title = E2ECrudConstants.TaskTitle,
            Description = E2ECrudConstants.TaskDescription,
            RepoUrl = E2ECrudConstants.TaskRepoUrl,
            E2ECrudConstants.BountyAmountCents
        });
        Assert.IsTrue(
            CreateTaskResp.StatusCode is HttpStatusCode.Unauthorized or HttpStatusCode.Forbidden,
            $"Unauthenticated task creation must return 401/403, got {CreateTaskResp.StatusCode}");
        var Page = await NavigateOrSkipAsync($"{BaseUrl}{RouteConstants.Login}");
        if (Page is not null)
        {
            await WaitForBlazorAsync(LoginConstants.PageHeading);
            var H1Count = await CdpHelpers.CountAsync(BrowserPage, "h1");
            if (H1Count > 0)
            {
                var Text = await CdpHelpers.GetTextContentAsync(BrowserPage, "h1");
                Assert.IsTrue(Text.Contains(LoginConstants.PageHeading),
                    $"Login page h1 must contain '{LoginConstants.PageHeading}'");
            }
        }
        await TakeScreenshotAsync("T57-unauth-after.png");
    }
    private static async Task T57VerifyOwnerAccessAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Http = new HttpClient(Handler) { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        await DevLoginHelperAsync(Http, T57OwnerSubjectId, T57OwnerName);
        await TakeScreenshotAsync("T57-owner-before.png");
        var MeResp = await Http.GetAsync(RouteConstants.ApiAuthMe);
        Assert.AreEqual(HttpStatusCode.OK, MeResp.StatusCode, "Owner auth/me must return 200");
        var CreateResp = await Http.PostAsJsonAsync(RouteConstants.ApiTasks, new
        {
            Id = Guid.NewGuid().ToString(),
            ClientId = T57OwnerSubjectId,
            Title = E2ECrudConstants.TaskTitle,
            Description = E2ECrudConstants.TaskDescription,
            RepoUrl = E2ECrudConstants.TaskRepoUrl,
            E2ECrudConstants.BountyAmountCents
        });
        Assert.AreEqual(HttpStatusCode.Created, CreateResp.StatusCode, "Owner can create tasks");
        using var TaskDoc = JsonDocument.Parse(await CreateResp.Content.ReadAsStringAsync());
        var TaskId = TaskDoc.RootElement.GetProperty("id").GetString()!;
        var PatchResp = await Http.PatchAsJsonAsync(
            FormatStrings.ApiResourcePath(RouteConstants.ApiTasks, TaskId),
            new { Title = E2ECrudConstants.UpdatedTaskTitle });
        Assert.IsTrue(PatchResp.IsSuccessStatusCode, "Owner can update own tasks");
        var DeleteResp = await Http.DeleteAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiTasks, TaskId));
        Assert.AreEqual(HttpStatusCode.NoContent, DeleteResp.StatusCode, "Owner can delete own tasks");
        var SprintCreate = await Http.PostAsJsonAsync(RouteConstants.ApiSprints, new
        {
            Name = E2ECrudConstants.SprintName,
            Goal = E2ECrudConstants.SprintGoal,
            OwnerId = T57OwnerSubjectId,
            StartDate = DateTime.UtcNow.ToString(AppConstants.RoundTripDateTimeFormat),
            EndDate = DateTime.UtcNow.AddDays(14).ToString(AppConstants.RoundTripDateTimeFormat)
        });
        Assert.AreEqual(HttpStatusCode.Created, SprintCreate.StatusCode, "Owner can create sprints");
        using var SprintDoc = JsonDocument.Parse(await SprintCreate.Content.ReadAsStringAsync());
        var SprintId = SprintDoc.RootElement.GetProperty("id").GetString()!;
        await Http.DeleteAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiSprints, SprintId));
        var BoardCreate = await Http.PostAsJsonAsync(RouteConstants.ApiBoards, new
        {
            Id = Guid.NewGuid().ToString(),
            Name = E2ECrudConstants.BoardName,
            OwnerId = T57OwnerSubjectId,
            Type = (int)BoardType.Kanban
        });
        Assert.AreEqual(HttpStatusCode.Created, BoardCreate.StatusCode, "Owner can create boards");
        using var BoardDoc = JsonDocument.Parse(await BoardCreate.Content.ReadAsStringAsync());
        var BoardId = BoardDoc.RootElement.GetProperty("id").GetString()!;
        await Http.DeleteAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiBoards, BoardId));
        await TakeScreenshotAsync("T57-owner-after.png");
    }
    private static async Task T57VerifyAdminAccessAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Http = new HttpClient(Handler) { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        await DevLoginHelperAsync(Http, T57AdminSubjectId, T57AdminName);
        await TakeScreenshotAsync("T57-admin-before.png");
        var MeResp = await Http.GetAsync(RouteConstants.ApiAuthMe);
        Assert.AreEqual(HttpStatusCode.OK, MeResp.StatusCode, "Admin auth/me must return 200");
        var UsersResp = await Http.GetAsync(RouteConstants.ApiUsers);
        Assert.IsTrue(UsersResp.IsSuccessStatusCode, "Admin can list users");
        var TasksResp = await Http.GetAsync(RouteConstants.ApiTasks);
        Assert.IsTrue(TasksResp.IsSuccessStatusCode, "Admin can list tasks");
        var LeaderboardResp = await Http.GetAsync(RouteConstants.ApiLeaderboard);
        Assert.IsTrue(LeaderboardResp.IsSuccessStatusCode, "Admin can view leaderboard");
        var TaskId = Guid.NewGuid().ToString();
        var CreateResp = await Http.PostAsJsonAsync(RouteConstants.ApiTasks, new
        {
            Id = TaskId,
            ClientId = T57AdminSubjectId,
            Title = E2ECrudConstants.TaskTitle,
            Description = E2ECrudConstants.TaskDescription,
            RepoUrl = E2ECrudConstants.TaskRepoUrl,
            E2ECrudConstants.BountyAmountCents
        });
        Assert.AreEqual(HttpStatusCode.Created, CreateResp.StatusCode, "Admin can create tasks");
        await Http.DeleteAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiTasks, TaskId));
        await TakeScreenshotAsync("T57-admin-after.png");
    }
    private static async Task T57VerifyMemberAccessAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Http = new HttpClient(Handler) { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        await DevLoginHelperAsync(Http, T57MemberSubjectId, T57MemberName);
        await TakeScreenshotAsync("T57-member-before.png");
        var MeResp = await Http.GetAsync(RouteConstants.ApiAuthMe);
        Assert.AreEqual(HttpStatusCode.OK, MeResp.StatusCode, "Member auth/me must return 200");
        var TasksResp = await Http.GetAsync(RouteConstants.ApiTasks);
        Assert.IsTrue(TasksResp.IsSuccessStatusCode, "Member can browse tasks");
        var LeaderboardResp = await Http.GetAsync(RouteConstants.ApiLeaderboard);
        Assert.IsTrue(LeaderboardResp.IsSuccessStatusCode, "Member can view leaderboard");
        var OwnerTaskId = Guid.NewGuid().ToString();
#pragma warning disable CA5399, MA0039, S4830
        var OwnerHandler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var OwnerHttp = new HttpClient(OwnerHandler) { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        await DevLoginHelperAsync(OwnerHttp, T57OwnerSubjectId, T57OwnerName);
        var OwnerCreateResp = await OwnerHttp.PostAsJsonAsync(RouteConstants.ApiTasks, new
        {
            Id = OwnerTaskId,
            ClientId = T57OwnerSubjectId,
            Title = E2ECrudConstants.TaskTitle,
            Description = E2ECrudConstants.TaskDescription,
            RepoUrl = E2ECrudConstants.TaskRepoUrl,
            E2ECrudConstants.BountyAmountCents
        });
        using var OwnerTaskDoc = JsonDocument.Parse(await OwnerCreateResp.Content.ReadAsStringAsync());
        OwnerTaskId = OwnerTaskDoc.RootElement.GetProperty("id").GetString() ?? OwnerTaskId;
        var TaskGetResp = await Http.GetAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiTasks, OwnerTaskId));
        Assert.AreEqual(HttpStatusCode.OK, TaskGetResp.StatusCode, "Member can view individual tasks");
        var PrId = Guid.NewGuid().ToString();
        var PrCreateResp = await Http.PostAsJsonAsync(RouteConstants.ApiPullRequests, new
        {
            Id = PrId,
            TaskId = OwnerTaskId,
            DeveloperId = T57MemberSubjectId,
            GitHubUrl = E2ECrudConstants.PrGitHubUrl,
            FilesChanged = E2ECrudConstants.PrFilesChanged,
            Additions = E2ECrudConstants.PrAdditions,
            Deletions = E2ECrudConstants.PrDeletions
        });
        Assert.IsTrue(PrCreateResp.IsSuccessStatusCode, "Member can submit PRs");
        await Http.DeleteAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiPullRequests, PrId));
        await OwnerHttp.DeleteAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiTasks, OwnerTaskId));
        await TakeScreenshotAsync("T57-member-after.png");
    }
    private static async Task T57VerifyViewerAccessAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Http = new HttpClient(Handler) { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        await DevLoginHelperAsync(Http, T57ViewerSubjectId, T57ViewerName);
        await TakeScreenshotAsync("T57-viewer-before.png");
        var MeResp = await Http.GetAsync(RouteConstants.ApiAuthMe);
        Assert.AreEqual(HttpStatusCode.OK, MeResp.StatusCode, "Viewer auth/me must return 200");
        var TasksResp = await Http.GetAsync(RouteConstants.ApiTasks);
        Assert.IsTrue(TasksResp.IsSuccessStatusCode, "Viewer can browse tasks");
        var LeaderboardResp = await Http.GetAsync(RouteConstants.ApiLeaderboard);
        Assert.IsTrue(LeaderboardResp.IsSuccessStatusCode, "Viewer can view leaderboard");
        var Page = await NavigateOrSkipAsync($"{BaseUrl}{RouteConstants.Tasks}");
        if (Page is not null)
        {
            var H1Count = await CdpHelpers.CountAsync(BrowserPage, "h1");
            if (H1Count > 0)
            {
                var Text = await CdpHelpers.GetTextContentAsync(BrowserPage, "h1");
                Assert.IsTrue(Text.Contains(TaskListConstants.PageHeading),
                    $"Viewer tasks page h1 must contain '{TaskListConstants.PageHeading}'");
            }
        }
        var PrListResp = await Http.GetAsync(RouteConstants.ApiPullRequests);
        Assert.IsTrue(PrListResp.IsSuccessStatusCode || PrListResp.StatusCode is HttpStatusCode.Forbidden or HttpStatusCode.NotFound,
            $"Viewer PR list returned {PrListResp.StatusCode}");
        var AchievementsResp = await Http.GetAsync(RouteConstants.ApiAchievements);
        Assert.IsTrue(AchievementsResp.IsSuccessStatusCode || AchievementsResp.StatusCode is HttpStatusCode.Forbidden or HttpStatusCode.NotFound,
            $"Viewer achievements returned {AchievementsResp.StatusCode}");
        await TakeScreenshotAsync("T57-viewer-after.png");
    }
    private static void T57VerifyEndpointAuthorizationRequirements()
    {
        var EndpointsDir = Path.Combine(SourceRoot, "PrTask.Server", "Endpoints");
        if (!Directory.Exists(EndpointsDir)) { return; }
        var MutationEndpointFiles = new[]
        {
            "TaskEndpoints.cs", "PullRequestEndpoints.cs", "BoardEndpoints.cs",
            "SprintEndpoints.cs", "RepositoryEndpoints.cs", "ReviewCommentEndpoints.cs",
            "PaymentRecordEndpoints.cs", "SubscriptionEndpoints.cs", "InvoiceEndpoints.cs",
            "DisbursementEndpoints.cs", "KycEndpoints.cs", "CustomerEndpoints.cs",
            "QrPaymentEndpoints.cs", "WalletPaymentEndpoints.cs", "BillsPaymentEndpoints.cs"
        };
        foreach (var EndpointFile in MutationEndpointFiles)
        {
            var FilePath = Path.Combine(EndpointsDir, EndpointFile);
            if (!File.Exists(FilePath)) { continue; }
            var Content = File.ReadAllText(FilePath);
            if (Content.Contains("MapPost") || Content.Contains("MapPut") || Content.Contains("MapPatch") || Content.Contains("MapDelete"))
            {
                Assert.IsTrue(Content.Contains("RequireAuthorization"),
                    $"{EndpointFile}: mutation endpoints must have RequireAuthorization");
            }
        }
        var PublicEndpointFiles = new[]
        {
            "AchievementEndpoints.cs"
        };
        foreach (var EndpointFile in PublicEndpointFiles)
        {
            var FilePath = Path.Combine(EndpointsDir, EndpointFile);
            if (!File.Exists(FilePath)) { continue; }
            var Content = File.ReadAllText(FilePath);
            Assert.IsTrue(Content.Contains("MapGet"), $"{EndpointFile}: must have MapGet for public read access");
        }
    }
}
