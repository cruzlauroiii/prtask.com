using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Repository full CRUD — create, read, update, delete, verify 404")]
    public async Task RepositoryCrudAsync()
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
        var RepoId = "e2e-repo-" + Guid.NewGuid().ToString("N")[..8];
        var Repo = new
        {
            OwnerId = E2ECrudConstants.User1SubjectId,
            Url = E2ECrudConstants.RepositoryUrl,
            Name = E2ECrudConstants.RepositoryName,
            Visibility = (int)RepositoryVisibility.Public
        };
        var CreateResp = await Http.PostAsJsonAsync(RouteConstants.ApiRepositories, Repo);
        Assert.AreEqual(HttpStatusCode.Created, CreateResp.StatusCode, "Repository POST 201");
        using var CreateDoc = JsonDocument.Parse(await CreateResp.Content.ReadAsStringAsync());
        var CreatedId = CreateDoc.RootElement.GetProperty("id").GetString()!;
        var GetResp = await Http.GetAsync($"{RouteConstants.ApiRepositories}/{CreatedId}");
        Assert.AreEqual(HttpStatusCode.OK, GetResp.StatusCode, "Repository GET 200");
        using var GetDoc = JsonDocument.Parse(await GetResp.Content.ReadAsStringAsync());
        Assert.AreEqual(E2ECrudConstants.RepositoryName, GetDoc.RootElement.GetProperty("name").GetString());
        var PatchResp = await Http.PatchAsJsonAsync(
            $"{RouteConstants.ApiRepositories}/{CreatedId}",
            new { Name = E2ECrudConstants.UpdatedRepositoryName, Visibility = (int)RepositoryVisibility.Private });
        Assert.IsTrue(PatchResp.IsSuccessStatusCode, "Repository PATCH success");
        var GetUpdated = await Http.GetAsync($"{RouteConstants.ApiRepositories}/{CreatedId}");
        using var UpdDoc = JsonDocument.Parse(await GetUpdated.Content.ReadAsStringAsync());
        Assert.AreEqual(E2ECrudConstants.UpdatedRepositoryName, UpdDoc.RootElement.GetProperty("name").GetString());
        var DelResp = await Http.DeleteAsync($"{RouteConstants.ApiRepositories}/{CreatedId}");
        Assert.AreEqual(HttpStatusCode.NoContent, DelResp.StatusCode, "Repository DELETE 204");
        var Get404 = await Http.GetAsync($"{RouteConstants.ApiRepositories}/{CreatedId}");
        Assert.AreEqual(HttpStatusCode.NotFound, Get404.StatusCode, "Deleted repository 404");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RepositoryPage has real CRUD with service injection")]
    public async Task RepositoryPageContentAsync()
    {
        var Razor = ReadSource("PrTask.SharedUI", "Pages", "Client", "RepositoryPage.razor");
        Assert.IsTrue(Razor.Contains("IRepositoryService"), "Injects IRepositoryService");
        Assert.IsTrue(Razor.Contains("ListByOwnerAsync"), "Lists repositories");
        Assert.IsTrue(Razor.Contains("CreateAsync"), "Creates repositories");
        Assert.IsTrue(Razor.Contains("DeleteAsync"), "Deletes repositories");
        Assert.IsTrue(Razor.Contains("id=\"RepoUrl\""), "Has RepoUrl input");
        Assert.IsTrue(Razor.Contains("id=\"Visibility\""), "Has Visibility select");
        Assert.IsTrue(Razor.Contains("data-table"), "Has data table for listing");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("DeploymentPreviewPage loads real PR data via service")]
    public async Task DeploymentPreviewPageContentAsync()
    {
        var Razor = ReadSource("PrTask.SharedUI", "Pages", "DeploymentPreviewPage.razor");
        Assert.IsTrue(Razor.Contains("IPullRequestService"), "Injects IPullRequestService");
        Assert.IsTrue(Razor.Contains("GetByIdAsync"), "Loads PR data");
        Assert.IsTrue(Razor.Contains("FilesChanged"), "Shows files changed");
        Assert.IsTrue(Razor.Contains("Additions"), "Shows additions");
        Assert.IsTrue(Razor.Contains("Deletions"), "Shows deletions");
        Assert.IsTrue(Razor.Contains("deploy-log"), "Has deploy log section");
        Assert.IsTrue(Razor.Contains("DeployPreviewAddress"), "Uses FormatStrings for Cloudflare Pages URL");
        await Task.CompletedTask;
    }
}
