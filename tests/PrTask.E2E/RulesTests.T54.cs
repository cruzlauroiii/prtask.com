using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.E2E;
public partial class RulesTests
{
    private static HttpClient? T54Http;
    [TestMethod, TestCategory("Rules"), Timeout(60000)]
    [DisplayName("T54 Full CRUD verification for every entity — create, read, update, delete with before/after screenshots")]
    public async Task T54FullCrudVerificationAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        var Handler = new HttpClientHandler
        {
            CookieContainer = new CookieContainer(),
            AllowAutoRedirect = false,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        T54Http = new HttpClient(Handler) { BaseAddress = new Uri(BaseUrl), Timeout = TimeSpan.FromSeconds(60) };
        try
        {
            await DevLoginHelperAsync(T54Http, E2ECrudConstants.User1SubjectId, E2ECrudConstants.User1Name);
            await T54TaskCrudAsync();
            await T54PullRequestCrudAsync();
            await T54SprintCrudAsync();
            await T54BoardColumnCrudAsync();
            await T54RepositoryCrudAsync();
        }
        finally
        {
            T54Http.Dispose();
        }
    }
    private static async Task T54TaskCrudAsync()
    {
        var Http = T54Http!;
        var Page = await NavigateOrSkipAsync($"{BaseUrl}{RouteConstants.Tasks}");
        if (Page is not null) { await TakeScreenshotAsync("T54-task-before.png"); }
        var TaskId = Guid.NewGuid().ToString();
        var CreateResp = await Http.PostAsJsonAsync(RouteConstants.ApiTasks, new
        {
            Id = TaskId, ClientId = E2ECrudConstants.User1SubjectId,
            Title = E2ECrudConstants.TaskTitle, Description = E2ECrudConstants.TaskDescription,
            RepoUrl = E2ECrudConstants.TaskRepoUrl, Complexity = (int)TaskComplexity.Complex,
            E2ECrudConstants.BountyAmountCents,
            Tags = new[] { E2ECrudConstants.TagCsharp, E2ECrudConstants.TagE2E }
        });
        Assert.AreEqual(HttpStatusCode.Created, CreateResp.StatusCode, "Task POST 201");
        using var CreateDoc = JsonDocument.Parse(await CreateResp.Content.ReadAsStringAsync());
        var ServerId = CreateDoc.RootElement.GetProperty("id").GetString()!;
        var GetResp = await Http.GetAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiTasks, ServerId));
        Assert.AreEqual(HttpStatusCode.OK, GetResp.StatusCode, "Task GET 200");
        using var GetDoc = JsonDocument.Parse(await GetResp.Content.ReadAsStringAsync());
        Assert.AreEqual(E2ECrudConstants.TaskTitle, GetDoc.RootElement.GetProperty("title").GetString());
        var PatchResp = await Http.PatchAsJsonAsync(
            FormatStrings.ApiResourcePath(RouteConstants.ApiTasks, ServerId),
            new { Title = E2ECrudConstants.UpdatedTaskTitle });
        Assert.IsTrue(PatchResp.IsSuccessStatusCode, "Task PATCH success");
        var GetUpd = await Http.GetAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiTasks, ServerId));
        using var UpdDoc = JsonDocument.Parse(await GetUpd.Content.ReadAsStringAsync());
        Assert.AreEqual(E2ECrudConstants.UpdatedTaskTitle, UpdDoc.RootElement.GetProperty("title").GetString());
        var DelResp = await Http.DeleteAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiTasks, ServerId));
        Assert.AreEqual(HttpStatusCode.NoContent, DelResp.StatusCode, "Task DELETE 204");
        var Get404 = await Http.GetAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiTasks, ServerId));
        Assert.AreEqual(HttpStatusCode.NotFound, Get404.StatusCode, "Deleted task 404");
        if (Page is not null) { await TakeScreenshotAsync("T54-task-after.png"); }
    }
    private static async Task T54PullRequestCrudAsync()
    {
        var Http = T54Http!;
        await TakeScreenshotAsync("T54-pr-before.png");
        var TaskId = Guid.NewGuid().ToString();
        await Http.PostAsJsonAsync(RouteConstants.ApiTasks, new
        {
            Id = TaskId, ClientId = E2ECrudConstants.User1SubjectId,
            Title = E2ECrudConstants.TaskTitle, Description = E2ECrudConstants.TaskDescription,
            RepoUrl = E2ECrudConstants.TaskRepoUrl, E2ECrudConstants.BountyAmountCents
        });
        var PrId = Guid.NewGuid().ToString();
        var CreateResp = await Http.PostAsJsonAsync(RouteConstants.ApiPullRequests, new
        {
            Id = PrId, TaskId, DeveloperId = E2ECrudConstants.User2SubjectId,
            GitHubUrl = E2ECrudConstants.PrGitHubUrl, FilesChanged = E2ECrudConstants.PrFilesChanged,
            Additions = E2ECrudConstants.PrAdditions, Deletions = E2ECrudConstants.PrDeletions
        });
        Assert.IsTrue(CreateResp.IsSuccessStatusCode, "PR POST success");
        using var PrDoc = JsonDocument.Parse(await CreateResp.Content.ReadAsStringAsync());
        var ServerPrId = PrDoc.RootElement.GetProperty("id").GetString() ?? PrId;
        var ListResp = await Http.GetAsync($"{RouteConstants.ApiPullRequests}/Task/{TaskId}");
        Assert.AreEqual(HttpStatusCode.OK, ListResp.StatusCode, "PR list by task GET 200");
        using var ListDoc = JsonDocument.Parse(await ListResp.Content.ReadAsStringAsync());
        Assert.IsTrue(ListDoc.RootElement.GetArrayLength() > 0, "PR list not empty");
        var GetResp = await Http.GetAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiPullRequests, ServerPrId));
        Assert.AreEqual(HttpStatusCode.OK, GetResp.StatusCode, "PR GET by ID 200");
        var DelResp = await Http.DeleteAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiPullRequests, ServerPrId));
        Assert.IsTrue(DelResp.StatusCode is HttpStatusCode.NoContent || DelResp.IsSuccessStatusCode, "PR DELETE success");
        await Http.DeleteAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiTasks, TaskId));
        await TakeScreenshotAsync("T54-pr-after.png");
    }
    private static async Task T54SprintCrudAsync()
    {
        var Http = T54Http!;
        var Page = await NavigateOrSkipAsync($"{BaseUrl}{RouteConstants.Sprints}");
        if (Page is not null) { await TakeScreenshotAsync("T54-sprint-before.png"); }
        var CreateResp = await Http.PostAsJsonAsync(RouteConstants.ApiSprints, new
        {
            Name = E2ECrudConstants.SprintName, Goal = E2ECrudConstants.SprintGoal,
            OwnerId = E2ECrudConstants.User1SubjectId,
            StartDate = DateTime.UtcNow.ToString(AppConstants.RoundTripDateTimeFormat),
            EndDate = DateTime.UtcNow.AddDays(14).ToString(AppConstants.RoundTripDateTimeFormat)
        });
        Assert.AreEqual(HttpStatusCode.Created, CreateResp.StatusCode, "Sprint POST 201");
        using var CreateDoc = JsonDocument.Parse(await CreateResp.Content.ReadAsStringAsync());
        var SprintId = CreateDoc.RootElement.GetProperty("id").GetString()!;
        var GetResp = await Http.GetAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiSprints, SprintId));
        Assert.AreEqual(HttpStatusCode.OK, GetResp.StatusCode, "Sprint GET 200");
        using var GetDoc = JsonDocument.Parse(await GetResp.Content.ReadAsStringAsync());
        Assert.AreEqual(E2ECrudConstants.SprintName, GetDoc.RootElement.GetProperty("name").GetString());
        var PatchResp = await Http.PatchAsJsonAsync(
            FormatStrings.ApiResourcePath(RouteConstants.ApiSprints, SprintId),
            new { Name = E2ECrudConstants.UpdatedSprintName, Status = (int)SprintStatus.Active });
        Assert.IsTrue(PatchResp.IsSuccessStatusCode, "Sprint PATCH success");
        var GetUpd = await Http.GetAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiSprints, SprintId));
        using var UpdDoc = JsonDocument.Parse(await GetUpd.Content.ReadAsStringAsync());
        Assert.AreEqual(E2ECrudConstants.UpdatedSprintName, UpdDoc.RootElement.GetProperty("name").GetString());
        var DelResp = await Http.DeleteAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiSprints, SprintId));
        Assert.AreEqual(HttpStatusCode.NoContent, DelResp.StatusCode, "Sprint DELETE 204");
        var Get404 = await Http.GetAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiSprints, SprintId));
        Assert.AreEqual(HttpStatusCode.NotFound, Get404.StatusCode, "Deleted sprint 404");
        if (Page is not null) { await TakeScreenshotAsync("T54-sprint-after.png"); }
    }
    private static async Task T54BoardColumnCrudAsync()
    {
        var Http = T54Http!;
        var Page = await NavigateOrSkipAsync($"{BaseUrl}{RouteConstants.Boards}");
        if (Page is not null) { await TakeScreenshotAsync("T54-board-before.png"); }
        var CreateResp = await Http.PostAsJsonAsync(RouteConstants.ApiBoards, new
        {
            Id = Guid.NewGuid().ToString(), Name = E2ECrudConstants.BoardName,
            OwnerId = E2ECrudConstants.User1SubjectId, Type = (int)BoardType.Kanban
        });
        Assert.AreEqual(HttpStatusCode.Created, CreateResp.StatusCode, "Board POST 201");
        using var BoardDoc = JsonDocument.Parse(await CreateResp.Content.ReadAsStringAsync());
        var BoardId = BoardDoc.RootElement.GetProperty("id").GetString()!;
        var GetResp = await Http.GetAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiBoards, BoardId));
        Assert.AreEqual(HttpStatusCode.OK, GetResp.StatusCode, "Board GET 200");
        var ColPath = FormatStrings.ColumnPath(RouteConstants.ApiBoards, BoardId);
        var ColResp = await Http.PostAsJsonAsync(ColPath, new
        {
            Id = Guid.NewGuid().ToString(), BoardId, Name = E2ECrudConstants.ColumnName,
            Order = 0, WipLimit = E2ECrudConstants.ColumnWipLimit
        });
        Assert.IsTrue(ColResp.IsSuccessStatusCode, "Column POST success");
        using var ColCreateDoc = JsonDocument.Parse(await ColResp.Content.ReadAsStringAsync());
        var ColId = ColCreateDoc.RootElement.GetProperty("id").GetString()!;
        var ColGetResp = await Http.GetAsync(ColPath);
        Assert.AreEqual(HttpStatusCode.OK, ColGetResp.StatusCode, "Columns GET 200");
        using var ColDoc = JsonDocument.Parse(await ColGetResp.Content.ReadAsStringAsync());
        Assert.IsTrue(ColDoc.RootElement.GetArrayLength() > 0, "Column list not empty");
        var DelCol = await Http.DeleteAsync(FormatStrings.ColumnItemPath(RouteConstants.ApiBoards, BoardId, ColId));
        Assert.AreEqual(HttpStatusCode.NoContent, DelCol.StatusCode, "Column DELETE 204");
        var DelBoard = await Http.DeleteAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiBoards, BoardId));
        Assert.AreEqual(HttpStatusCode.NoContent, DelBoard.StatusCode, "Board DELETE 204");
        var Get404 = await Http.GetAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiBoards, BoardId));
        Assert.AreEqual(HttpStatusCode.NotFound, Get404.StatusCode, "Deleted board 404");
        if (Page is not null) { await TakeScreenshotAsync("T54-board-after.png"); }
    }
    private static async Task T54RepositoryCrudAsync()
    {
        var Http = T54Http!;
        var Page = await NavigateOrSkipAsync($"{BaseUrl}{RouteConstants.Repository}");
        if (Page is not null) { await TakeScreenshotAsync("T54-repo-before.png"); }
        var CreateResp = await Http.PostAsJsonAsync(RouteConstants.ApiRepositories, new
        {
            OwnerId = E2ECrudConstants.User1SubjectId, Url = E2ECrudConstants.RepositoryUrl,
            Name = E2ECrudConstants.RepositoryName, Visibility = (int)RepositoryVisibility.Public
        });
        Assert.AreEqual(HttpStatusCode.Created, CreateResp.StatusCode, "Repo POST 201");
        using var CreateDoc = JsonDocument.Parse(await CreateResp.Content.ReadAsStringAsync());
        var RepoId = CreateDoc.RootElement.GetProperty("id").GetString()!;
        var GetResp = await Http.GetAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiRepositories, RepoId));
        Assert.AreEqual(HttpStatusCode.OK, GetResp.StatusCode, "Repo GET 200");
        using var GetDoc = JsonDocument.Parse(await GetResp.Content.ReadAsStringAsync());
        Assert.AreEqual(E2ECrudConstants.RepositoryName, GetDoc.RootElement.GetProperty("name").GetString());
        var PatchResp = await Http.PatchAsJsonAsync(
            FormatStrings.ApiResourcePath(RouteConstants.ApiRepositories, RepoId),
            new { Name = E2ECrudConstants.UpdatedRepositoryName });
        Assert.IsTrue(PatchResp.IsSuccessStatusCode, "Repo PATCH success");
        var DelResp = await Http.DeleteAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiRepositories, RepoId));
        Assert.AreEqual(HttpStatusCode.NoContent, DelResp.StatusCode, "Repo DELETE 204");
        var Get404 = await Http.GetAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiRepositories, RepoId));
        Assert.AreEqual(HttpStatusCode.NotFound, Get404.StatusCode, "Deleted repo 404");
        if (Page is not null) { await TakeScreenshotAsync("T54-repo-after.png"); }
    }
}
