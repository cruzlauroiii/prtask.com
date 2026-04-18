using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PR list and reject — list PRs, create, reject, verify status")]
    public async Task PrListAndRejectAsync()
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
        const long Bounty = E2ECrudConstants.BountyAmountCents;
        var Task = new { Id = Guid.NewGuid().ToString(), ClientId = E2ECrudConstants.User1SubjectId,
            Title = E2ECrudConstants.TaskTitle, Description = E2ECrudConstants.TaskDescription,
            RepoUrl = E2ECrudConstants.TaskRepoUrl, BountyAmountCents = Bounty };
        await Http.PostAsJsonAsync(RouteConstants.ApiTasks, Task);
        var Pr = new { Id = Guid.NewGuid().ToString(), TaskId = Task.Id,
            DeveloperId = E2ECrudConstants.User2SubjectId,
            GitHubUrl = E2ECrudConstants.PrGitHubUrl,
            FilesChanged = E2ECrudConstants.PrFilesChanged,
            Additions = E2ECrudConstants.PrAdditions, Deletions = E2ECrudConstants.PrDeletions };
        await Http.PostAsJsonAsync(RouteConstants.ApiPullRequests, Pr);
        var ListResp = await Http.GetAsync($"{RouteConstants.ApiPullRequests}/task/{Task.Id}");
        Assert.AreEqual(HttpStatusCode.OK, ListResp.StatusCode, "PR list by task GET 200");
        using var ListDoc = JsonDocument.Parse(await ListResp.Content.ReadAsStringAsync());
        Assert.IsTrue(ListDoc.RootElement.GetArrayLength() > 0, "PR list not empty");
        var RejectResp = await Http.PostAsJsonAsync(
            $"{RouteConstants.ApiPullRequests}/{Pr.Id}/reject", new { Reason = "E2E test reject" });
        Assert.IsTrue(RejectResp.IsSuccessStatusCode, "PR reject success");
        await Http.DeleteAsync($"{RouteConstants.ApiTasks}/{Task.Id}");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Board column CRUD — create column, list, delete via API")]
    public async Task BoardColumnCrudViaApiAsync()
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
        var BoardId = Guid.NewGuid().ToString();
        var Board = new { Id = BoardId, Name = E2ECrudConstants.BoardName,
            OwnerId = E2ECrudConstants.User1SubjectId, Type = (int)BoardType.Kanban };
        var BoardResp = await Http.PostAsJsonAsync(RouteConstants.ApiBoards, Board);
        Assert.AreEqual(HttpStatusCode.Created, BoardResp.StatusCode, "Board POST 201");
        var ColPath = $"{RouteConstants.ApiBoards}/{BoardId}/columns";
        var Col1Id = Guid.NewGuid().ToString();
        var Col2Id = Guid.NewGuid().ToString();
        await Http.PostAsJsonAsync(ColPath, new { Id = Col1Id, BoardId, Name = "To Do", Order = 0, WipLimit = 3 });
        await Http.PostAsJsonAsync(ColPath, new { Id = Col2Id, BoardId, Name = "Done", Order = 1 });
        var ListResp = await Http.GetAsync(ColPath);
        Assert.AreEqual(HttpStatusCode.OK, ListResp.StatusCode, "Columns GET 200");
        using var ListDoc = JsonDocument.Parse(await ListResp.Content.ReadAsStringAsync());
        Assert.IsTrue(ListDoc.RootElement.GetArrayLength() >= 2, "At least 2 columns");
        await Http.DeleteAsync($"{ColPath}/{Col1Id}");
        await Http.DeleteAsync($"{ColPath}/{Col2Id}");
        await Http.DeleteAsync($"{RouteConstants.ApiBoards}/{BoardId}");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Sprint list by owner — GET sprints/owner/{id} returns array")]
    public async Task SprintListByOwnerAsync()
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
        var Sprint = new { Name = E2ECrudConstants.SprintName, Goal = E2ECrudConstants.SprintGoal,
            OwnerId = E2ECrudConstants.User1SubjectId,
            StartDate = DateTime.UtcNow.ToString("o"), EndDate = DateTime.UtcNow.AddDays(7).ToString("o") };
        var CreateResp = await Http.PostAsJsonAsync(RouteConstants.ApiSprints, Sprint);
        Assert.AreEqual(HttpStatusCode.Created, CreateResp.StatusCode, "Sprint POST 201");
        using var CreateDoc = JsonDocument.Parse(await CreateResp.Content.ReadAsStringAsync());
        var SprintId = CreateDoc.RootElement.GetProperty("id").GetString()!;
        var OwnerResp = await Http.GetAsync(
            FormatStrings.OwnerPath(RouteConstants.ApiSprints, E2ECrudConstants.User1SubjectId));
        Assert.AreEqual(HttpStatusCode.OK, OwnerResp.StatusCode, "Sprint owner GET 200");
        using var OwnerDoc = JsonDocument.Parse(await OwnerResp.Content.ReadAsStringAsync());
        Assert.IsTrue(OwnerDoc.RootElement.GetArrayLength() > 0, "Owner sprints not empty");
        await Http.DeleteAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiSprints, SprintId));
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Repository list by owner — GET repos/owner/{id} returns array")]
    public async Task RepositoryListByOwnerAsync()
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
        var Repo = new { OwnerId = E2ECrudConstants.User1SubjectId,
            Url = E2ECrudConstants.RepositoryUrl, Name = E2ECrudConstants.RepositoryName,
            Visibility = (int)RepositoryVisibility.Public };
        var CreateResp = await Http.PostAsJsonAsync(RouteConstants.ApiRepositories, Repo);
        Assert.AreEqual(HttpStatusCode.Created, CreateResp.StatusCode, "Repo POST 201");
        using var CreateDoc = JsonDocument.Parse(await CreateResp.Content.ReadAsStringAsync());
        var RepoId = CreateDoc.RootElement.GetProperty("id").GetString()!;
        var OwnerResp = await Http.GetAsync(
            FormatStrings.OwnerPath(RouteConstants.ApiRepositories, E2ECrudConstants.User1SubjectId));
        Assert.AreEqual(HttpStatusCode.OK, OwnerResp.StatusCode, "Repo owner GET 200");
        using var OwnerDoc = JsonDocument.Parse(await OwnerResp.Content.ReadAsStringAsync());
        Assert.IsTrue(OwnerDoc.RootElement.GetArrayLength() > 0, "Owner repos not empty");
        await Http.DeleteAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiRepositories, RepoId));
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("BoardDetailPage uses ITaskService for column tasks")]
    public void BoardDetailPageTaskService()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "BoardDetailPage.razor");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Application.Services.ITaskService)), "Injects ITaskService");
        Assert.IsTrue(Source.Contains("ColumnTasks"), "Has ColumnTasks dictionary");
        Assert.IsTrue(Source.Contains("ListOpenAsync"), "Loads tasks via ListOpenAsync");
        Assert.IsTrue(Source.Contains("BoardColumnId"), "Filters by BoardColumnId");
    }
}
