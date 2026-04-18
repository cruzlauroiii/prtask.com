using System.Net.Http.Json;
using System.Text.Json;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Client.Services;
public class HttpCloudflareD1Service(HttpClient Http) : ICloudflareD1Service
{
    public bool IsConfigured => true;
    public async Task<JsonElement> QueryAsync(string Sql, params object[] Parameters)
    {
        var Resp = await Http.PostAsJsonAsync(
            RouteConstants.ApiCloudflareD1 + RouteConstants.SubQuery,
            new { Sql });
        if (!Resp.IsSuccessStatusCode) { return default; }
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        return Doc.RootElement.TryGetProperty(CloudflareConstants.JsonData, out var Data)
            ? Data.Clone() : default;
    }
    public async Task<bool> ExecuteAsync(string Sql, params object[] Parameters)
    {
        var Resp = await Http.PostAsJsonAsync(
            RouteConstants.ApiCloudflareD1 + RouteConstants.SubQuery,
            new { Sql });
        return Resp.IsSuccessStatusCode;
    }
}
