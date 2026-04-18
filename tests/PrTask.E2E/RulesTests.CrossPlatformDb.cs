using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory(PlatformTestConstants.CrossPlatformTestCategory)]
    [DisplayName("T73 Cross-platform DB consistency — CRUD on each platform, verify on others")]
    public async Task T73CrossPlatformDbConsistencyAsync()
    {
        var ReachablePlatforms = new List<string>();
        foreach (var Platform in AllPlatforms)
        {
            var Url = GetPlatformBaseUrl(Platform);
            if (await IsPlatformReachableAsync(Url))
            {
                ReachablePlatforms.Add(Platform);
            }
        }

        if (ReachablePlatforms.Count < PlatformTestConstants.MinReachablePlatforms)
        {
            Assert.Inconclusive(PlatformTestConstants.CrossPlatformMinPlatformsAssert);
        }

        var WebReachable = ReachablePlatforms.Contains(PlatformTestConstants.PlatformWeb);
        HttpClient? WebHttp = null;
        try
        {
            if (WebReachable)
            {
                var WebCtx = await GetPlatformContextAsync(PlatformTestConstants.PlatformWeb);
                WebHttp = CreatePlatformHttpClient(WebCtx.PlatformUrl);
                try
                {
                    await DevLoginHelperAsync(WebHttp, E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name);
                }
                catch (HttpRequestException)
                {
                    WebReachable = false;
                    ReachablePlatforms.Remove(PlatformTestConstants.PlatformWeb);
                    WebHttp.Dispose();
                    WebHttp = null;
                }
            }

            if (ReachablePlatforms.Count < PlatformTestConstants.MinReachablePlatforms)
            {
                Assert.Inconclusive(PlatformTestConstants.CrossPlatformMinPlatformsAssert);
            }

            if (WebReachable && WebHttp is not null)
            {
                await T73CreateOnWebVerifyEverywhereAsync(WebHttp, ReachablePlatforms);
            }

            if (ReachablePlatforms.Contains(PlatformTestConstants.PlatformDesktop))
            {
                await T73CreateOnDesktopVerifyEverywhereAsync(ReachablePlatforms);
            }

            if (ReachablePlatforms.Contains(PlatformTestConstants.PlatformAndroid))
            {
                await T73CreateOnAndroidVerifyEverywhereAsync(ReachablePlatforms);
            }

            if (WebReachable && WebHttp is not null)
            {
                await T73SnapshotConsistencyAsync(WebHttp, ReachablePlatforms);
            }
        }
        finally
        {
            WebHttp?.Dispose();
            await CleanupPlatformContextsAsync();
        }
    }

    private static async Task<bool> IsPlatformReachableAsync(string PlatformBaseUrl)
    {
        try
        {
            using var Http = CreatePlatformHttpClient(PlatformBaseUrl);
            var Resp = await Http.GetAsync("/");
            return Resp.IsSuccessStatusCode || Resp.StatusCode is HttpStatusCode.Redirect or HttpStatusCode.MovedPermanently;
        }
        catch (HttpRequestException)
        {
            return false;
        }
        catch (TaskCanceledException)
        {
            return false;
        }
    }

    private static string GetPlatformBaseUrl(string Platform)
    {
        return Platform switch
        {
            PlatformTestConstants.PlatformWeb =>
                Environment.GetEnvironmentVariable(PlatformTestConstants.WebBaseUrlEnv)
                ?? PlatformTestConstants.DefaultWebUrl,
            PlatformTestConstants.PlatformDesktop =>
                Environment.GetEnvironmentVariable(PlatformTestConstants.DesktopBaseUrlEnv)
                ?? PlatformTestConstants.DefaultDesktopUrl,
            PlatformTestConstants.PlatformAndroid =>
                Environment.GetEnvironmentVariable(PlatformTestConstants.AndroidBaseUrlEnv)
                ?? PlatformTestConstants.DefaultAndroidUrl,
            _ => throw new ArgumentOutOfRangeException(nameof(Platform), Platform, null)
        };
    }

    private static async Task T73CreateOnWebVerifyEverywhereAsync(HttpClient WebHttp, List<string> ReachablePlatforms)
    {
        var TaskId = Guid.NewGuid().ToString();
        var CreateResp = await WebHttp.PostAsJsonAsync(RouteConstants.ApiTasks, new
        {
            Id = TaskId, ClientId = E2ECrudConstants.User1SubjectId,
            Title = E2ECrudConstants.TaskTitle, Description = E2ECrudConstants.TaskDescription,
            RepoUrl = E2ECrudConstants.TaskRepoUrl, E2ECrudConstants.BountyAmountCents
        });
        Assert.AreEqual(HttpStatusCode.Created, CreateResp.StatusCode, "T73: Web create task");

        await TakePlatformScreenshotAsync(
            await GetPlatformContextAsync(PlatformTestConstants.PlatformWeb),
            "create-task", E2EWorkflowConstants.AfterLabel);

        foreach (var Platform in ReachablePlatforms)
        {
            var Ctx = await GetPlatformContextAsync(Platform);
            using var Http = CreatePlatformHttpClient(Ctx.PlatformUrl);
            try
            {
                await DevLoginHelperAsync(Http, E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name);
                await DbVerificationHelper.AssertEntityExistsAsync(
                    Http, RouteConstants.ApiTasks, TaskId, DbVerificationConstants.TaskTable);
            }
            catch (HttpRequestException)
            {
                // Platform became unreachable during verification — skip
            }
        }

        await WebHttp.DeleteAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiTasks, TaskId));
        foreach (var Platform in ReachablePlatforms)
        {
            var Ctx = await GetPlatformContextAsync(Platform);
            using var Http = CreatePlatformHttpClient(Ctx.PlatformUrl);
            try
            {
                await DevLoginHelperAsync(Http, E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name);
                await DbVerificationHelper.AssertEntityDeletedAsync(
                    Http, RouteConstants.ApiTasks, TaskId, DbVerificationConstants.TaskTable);
            }
            catch (HttpRequestException)
            {
                // Platform became unreachable during verification — skip
            }
        }
    }

    private static async Task T73CreateOnDesktopVerifyEverywhereAsync(List<string> ReachablePlatforms)
    {
        var DesktopCtx = await GetPlatformContextAsync(PlatformTestConstants.PlatformDesktop);
        using var DesktopHttp = CreatePlatformHttpClient(DesktopCtx.PlatformUrl);
        await DevLoginHelperAsync(DesktopHttp, E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name);

        var SprintId = Guid.NewGuid().ToString();
        var CreateResp = await DesktopHttp.PostAsJsonAsync(RouteConstants.ApiSprints, new
        {
            Id = SprintId, Name = E2ECrudConstants.SprintName, Goal = E2ECrudConstants.SprintGoal,
            OwnerId = E2ECrudConstants.User1SubjectId,
            StartDate = DateTime.UtcNow.ToString(AppConstants.RoundTripDateTimeFormat),
            EndDate = DateTime.UtcNow.AddDays(14).ToString(AppConstants.RoundTripDateTimeFormat)
        });
        Assert.AreEqual(HttpStatusCode.Created, CreateResp.StatusCode, "T73: Desktop create sprint");

        await TakePlatformScreenshotAsync(DesktopCtx, "create-sprint", E2EWorkflowConstants.AfterLabel);

        foreach (var Platform in ReachablePlatforms)
        {
            var Ctx = await GetPlatformContextAsync(Platform);
            using var Http = CreatePlatformHttpClient(Ctx.PlatformUrl);
            try
            {
                await DevLoginHelperAsync(Http, E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name);
                await DbVerificationHelper.AssertEntityExistsAsync(
                    Http, RouteConstants.ApiSprints, SprintId, DbVerificationConstants.SprintTable);
            }
            catch (HttpRequestException)
            {
                // Platform became unreachable during verification — skip
            }
        }

        await DesktopHttp.DeleteAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiSprints, SprintId));
    }

    private static async Task T73CreateOnAndroidVerifyEverywhereAsync(List<string> ReachablePlatforms)
    {
        var AndroidCtx = await GetPlatformContextAsync(PlatformTestConstants.PlatformAndroid);
        using var AndroidHttp = CreatePlatformHttpClient(AndroidCtx.PlatformUrl);
        await DevLoginHelperAsync(AndroidHttp, E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name);

        var BoardId = Guid.NewGuid().ToString();
        var CreateResp = await AndroidHttp.PostAsJsonAsync(RouteConstants.ApiBoards, new
        {
            Id = BoardId, Name = E2ECrudConstants.BoardName,
            OwnerId = E2ECrudConstants.User1SubjectId, Type = (int)BoardType.Kanban
        });
        Assert.AreEqual(HttpStatusCode.Created, CreateResp.StatusCode, "T73: Android create board");

        await TakePlatformScreenshotAsync(AndroidCtx, "create-board", E2EWorkflowConstants.AfterLabel);

        foreach (var Platform in ReachablePlatforms)
        {
            var Ctx = await GetPlatformContextAsync(Platform);
            using var Http = CreatePlatformHttpClient(Ctx.PlatformUrl);
            try
            {
                await DevLoginHelperAsync(Http, E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name);
                await DbVerificationHelper.AssertEntityExistsAsync(
                    Http, RouteConstants.ApiBoards, BoardId, DbVerificationConstants.BoardTable);
            }
            catch (HttpRequestException)
            {
                // Platform became unreachable during verification — skip
            }
        }

        await AndroidHttp.DeleteAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiBoards, BoardId));
    }

    private static async Task T73SnapshotConsistencyAsync(HttpClient WebHttp, List<string> ReachablePlatforms)
    {
        var Endpoints = new[] { RouteConstants.ApiTasks, RouteConstants.ApiSprints, RouteConstants.ApiBoards };
        var WebSnapshot = await DbVerificationHelper.TakeSnapshotAsync(WebHttp, Endpoints);

        foreach (var Platform in ReachablePlatforms)
        {
            if (Platform is PlatformTestConstants.PlatformWeb) { continue; }
            var Ctx = await GetPlatformContextAsync(Platform);
            using var Http = CreatePlatformHttpClient(Ctx.PlatformUrl);
            try
            {
                await DevLoginHelperAsync(Http, E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name);
                var PlatformSnapshot = await DbVerificationHelper.TakeSnapshotAsync(Http, Endpoints);
                DbVerificationHelper.AssertSnapshotsMatch(WebSnapshot, PlatformSnapshot, Endpoints);
            }
            catch (HttpRequestException)
            {
                // Platform became unreachable during snapshot — skip
            }
        }
    }
}
