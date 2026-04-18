using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
[TestClass]
public class DeploymentTests
{
    private static readonly string AccountId = AppConstants.CloudflareAccountId;
    private static readonly string Project = AppConstants.CloudflarePagesProject;
    private static readonly string ApiBase = AppConstants.CloudflareApiBase;
    private static readonly string ApiKey = Environment.GetEnvironmentVariable("CLOUDFLARE_API_KEY") ?? string.Empty;
    private static readonly string ApiEmail = Environment.GetEnvironmentVariable("CLOUDFLARE_EMAIL") ?? string.Empty;
    private static HttpClient CfClient { get; set; } = null!;
    [ClassInitialize]
    public static void ClassInitializeDeploymentHttpClient(TestContext Context)
    {
        var Handler = new HttpClientHandler { CheckCertificateRevocationList = true };
        CfClient = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(60) };
        CfClient.DefaultRequestHeaders.Add("X-Auth-Key", ApiKey);
        CfClient.DefaultRequestHeaders.Add("X-Auth-Email", ApiEmail);
    }
    [ClassCleanup]
    public static void ClassCleanupDeploymentHttpClient()
    {
        CfClient.Dispose();
    }
    [TestMethod, TestCategory("Deployment")]
    [DisplayName("Cloudflare Pages stale deployments must be deleted to save cost keeping only the latest production deployment")]
    public async Task CloudflarePagesStaleDeploymentsMustBeDeletedToSaveCostKeepingOnlyTheLatestProductionDeploymentAsync()
    {
        if (string.IsNullOrEmpty(ApiKey) || string.IsNullOrEmpty(ApiEmail))
        {
            Assert.Inconclusive("Set CLOUDFLARE_API_KEY and CLOUDFLARE_EMAIL env vars to run deployment tests");
        }
        var AllDeployments = new List<DeploymentInfo>();
        var Page = 1;
        while (true)
        {
            var Url = $"{ApiBase}/accounts/{AccountId}/pages/projects/{Project}/deployments?per_page=25&page={Page}";
            var Response = await CfClient.GetAsync(Url);
            Assert.IsTrue(Response.IsSuccessStatusCode, $"List deployments page {Page} returned {Response.StatusCode}");
            var Json = await Response.Content.ReadAsStringAsync();
            var Doc = JsonDocument.Parse(Json);
            var Results = Doc.RootElement.GetProperty("result");
            if (Results.GetArrayLength() == 0)
            {
                break;
            }
            foreach (var Deployment in Results.EnumerateArray())
            {
                AllDeployments.Add(new DeploymentInfo
                {
                    Id = Deployment.GetProperty("id").GetString() ?? string.Empty,
                    ShortId = Deployment.TryGetProperty("short_id", out var Sid) ? Sid.GetString() ?? string.Empty : string.Empty,
                    Environment = Deployment.TryGetProperty("environment", out var Env) ? Env.GetString() ?? string.Empty : string.Empty,
                    CreatedOn = Deployment.TryGetProperty("created_on", out var Created) ? Created.GetString() ?? string.Empty : string.Empty
                });
            }
            var ResultInfo = Doc.RootElement.GetProperty("result_info");
            var TotalPages = (int)Math.Ceiling((double)ResultInfo.GetProperty("total_count").GetInt32() / ResultInfo.GetProperty("per_page").GetInt32());
            if (Page >= TotalPages)
            {
                break;
            }
            Page++;
        }
        Assert.IsTrue(AllDeployments.Count > 0, "Must have at least one deployment");
        var Sorted = AllDeployments.OrderByDescending(D => D.CreatedOn).ToList();
        var LatestId = Sorted[0].Id;
        var StaleDeployments = Sorted.Skip(1).ToList();
        var DeletedCount = 0;
        var FailedCount = 0;
        foreach (var Stale in StaleDeployments)
        {
            var DeleteUrl = $"{ApiBase}/accounts/{AccountId}/pages/projects/{Project}/deployments/{Stale.Id}?force=true";
            var DeleteResponse = await CfClient.DeleteAsync(DeleteUrl);
            if (DeleteResponse.IsSuccessStatusCode || DeleteResponse.StatusCode == HttpStatusCode.NotFound)
            {
                DeletedCount++;
            }
            else
            {
                FailedCount++;
            }
        }
        Assert.AreEqual(0, FailedCount, $"Failed to delete {FailedCount} stale deployment(s)");
        var VerifyUrl = $"{ApiBase}/accounts/{AccountId}/pages/projects/{Project}/deployments?per_page=25&page=1";
        var VerifyResponse = await CfClient.GetAsync(VerifyUrl);
        Assert.IsTrue(VerifyResponse.IsSuccessStatusCode, $"Verify deployments returned {VerifyResponse.StatusCode}");
        var VerifyJson = await VerifyResponse.Content.ReadAsStringAsync();
        var VerifyDoc = JsonDocument.Parse(VerifyJson);
        var RemainingCount = VerifyDoc.RootElement.GetProperty("result_info").GetProperty("total_count").GetInt32();
        Assert.IsTrue(RemainingCount <= 1, $"Expected at most 1 deployment remaining, got {RemainingCount}");
    }
    [TestMethod, TestCategory("Deployment")]
    [DisplayName("Cloudflare Pages latest deployment must be active and serving the live site successfully")]
    public async Task CloudflarePagesLatestDeploymentMustBeActiveAndServingTheLiveSiteSuccessfullyAsync()
    {
        using var SiteClient = new HttpClient(new HttpClientHandler { CheckCertificateRevocationList = true }) { Timeout = TimeSpan.FromSeconds(30) };
        var Response = await SiteClient.GetAsync($"https://{AppConstants.AppDomain}");
        Assert.IsTrue(Response.IsSuccessStatusCode, $"Live site returned {Response.StatusCode} after deployment cleanup");
        var Html = await Response.Content.ReadAsStringAsync();
        Assert.IsTrue(Html.Contains("PrTask"), "Live site must contain PrTask branding after cleanup");
        Assert.IsTrue(Html.Contains("blazor.webassembly.js"), "Live site must reference Blazor WASM after cleanup");
    }
    private sealed class DeploymentInfo
    {
        public string Id { get; set; } = string.Empty;
        public string ShortId { get; set; } = string.Empty;
        public string Environment { get; set; } = string.Empty;
        public string CreatedOn { get; set; } = string.Empty;
    }
}
