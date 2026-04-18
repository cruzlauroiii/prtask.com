using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Infrastructure.Services;
public class CloudflareD1Service(
    IHttpClientFactory HttpFactory,
    IConfiguration Configuration,
    ILogger<CloudflareD1Service> Logger) : ICloudflareD1Service
{
    private string? AccountId => Configuration[CloudflareConstants.ConfigAccountId];
    private string? DatabaseId => Configuration[CloudflareConstants.ConfigD1DatabaseId];
    private string? ApiToken => Configuration[CloudflareConstants.ConfigApiToken];
    public bool IsConfigured => !string.IsNullOrEmpty(AccountId)
        && !string.IsNullOrEmpty(DatabaseId)
        && !string.IsNullOrEmpty(ApiToken);
    public async Task<JsonElement> QueryAsync(string Sql, params object[] Parameters)
    {
        if (!IsConfigured)
        {
            Logger.LogWarning(CloudflareConstants.LogD1NotConfigured);
            return default;
        }
        var Client = HttpFactory.CreateClient(CloudflareConstants.HttpClientName);
        var Path = string.Format(CloudflareConstants.D1QueryPathFormat, AccountId, DatabaseId);
        var Request = new HttpRequestMessage(HttpMethod.Post, Path);
        Request.Headers.Add(CloudflareConstants.AuthorizationHeader,
            CloudflareConstants.BearerPrefix + ApiToken);
        Request.Content = JsonContent.Create(new { Sql, Params = Parameters });
        var Response = await Client.SendAsync(Request);
        if (!Response.IsSuccessStatusCode)
        {
            Logger.LogError(CloudflareConstants.LogD1QueryFailed, await Response.Content.ReadAsStringAsync());
            return default;
        }
        Logger.LogInformation(CloudflareConstants.LogD1QueryExecuted, Sql);
        using var Doc = JsonDocument.Parse(await Response.Content.ReadAsStringAsync());
        return Doc.RootElement.TryGetProperty(CloudflareConstants.JsonResult, out var Result)
            ? Result.Clone() : default;
    }
    public async Task<bool> ExecuteAsync(string Sql, params object[] Parameters)
    {
        if (!IsConfigured)
        {
            Logger.LogWarning(CloudflareConstants.LogD1NotConfigured);
            return false;
        }
        var Client = HttpFactory.CreateClient(CloudflareConstants.HttpClientName);
        var Path = string.Format(CloudflareConstants.D1QueryPathFormat, AccountId, DatabaseId);
        var Request = new HttpRequestMessage(HttpMethod.Post, Path);
        Request.Headers.Add(CloudflareConstants.AuthorizationHeader,
            CloudflareConstants.BearerPrefix + ApiToken);
        Request.Content = JsonContent.Create(new { Sql, Params = Parameters });
        var Response = await Client.SendAsync(Request);
        if (!Response.IsSuccessStatusCode)
        {
            Logger.LogError(CloudflareConstants.LogD1QueryFailed, await Response.Content.ReadAsStringAsync());
            return false;
        }
        Logger.LogInformation(CloudflareConstants.LogD1QueryExecuted, Sql);
        using var Doc = JsonDocument.Parse(await Response.Content.ReadAsStringAsync());
        return Doc.RootElement.TryGetProperty(CloudflareConstants.JsonSuccess, out var Success)
            && Success.GetBoolean();
    }
}
