using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Infrastructure.Services;
public class DiditKycService(IHttpClientFactory HttpFactory, IConfiguration Configuration, ILogger<DiditKycService> Logger) : IKycVerificationService
{
    private static readonly JsonSerializerOptions JsonOpts = new() { PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower };
    public async Task<(string SessionId, string VerificationUrl)> CreateSessionAsync(string UserId, string? CallbackUrl)
    {
        var Client = CreateClient();
        var Body = new Dictionary<string, object>
        {
            [DiditConstants.PropertyWorkflowId] = Configuration[DiditConstants.ConfigWorkflowId] ?? DiditConstants.DefaultWorkflowId,
            [DiditConstants.PropertyVendorData] = UserId
        };
        if (!string.IsNullOrEmpty(CallbackUrl))
        {
            Body[DiditConstants.PropertyCallback] = CallbackUrl;
        }
        var Json = JsonSerializer.Serialize(Body, JsonOpts);
        var Response = await Client.PostAsync(DiditConstants.CreateSessionPath,
            new StringContent(Json, Encoding.UTF8, DiditConstants.ContentTypeJson));
        var ResponseJson = await Response.Content.ReadAsStringAsync();
        if (!Response.IsSuccessStatusCode)
        {
            Logger.LogError("Didit create session failed: {Status} {Body}", Response.StatusCode, ResponseJson);
            return (string.Empty, string.Empty);
        }
        using var Doc = JsonDocument.Parse(ResponseJson);
        var SessionId = Doc.RootElement.TryGetProperty(DiditConstants.PropertySessionId, out var IdEl)
            ? IdEl.GetString() ?? string.Empty : string.Empty;
        var Url = Doc.RootElement.TryGetProperty(DiditConstants.PropertyUrl, out var UrlEl)
            ? UrlEl.GetString() ?? string.Empty : string.Empty;
        return (SessionId, Url);
    }
    public async Task<(string Status, string FullName)> GetSessionStatusAsync(string SessionId)
    {
        var Client = CreateClient();
        var Path = string.Format(DiditConstants.RetrieveSessionPath, SessionId);
        var Response = await Client.GetAsync(Path);
        var ResponseJson = await Response.Content.ReadAsStringAsync();
        if (!Response.IsSuccessStatusCode)
        {
            Logger.LogError("Didit get session failed: {Status}", Response.StatusCode);
            return (string.Empty, string.Empty);
        }
        using var Doc = JsonDocument.Parse(ResponseJson);
        var Status = Doc.RootElement.TryGetProperty(DiditConstants.PropertyStatus, out var StatusEl)
            ? StatusEl.GetString() ?? string.Empty : string.Empty;
        var FullName = Doc.RootElement.TryGetProperty(DiditConstants.PropertyFullName, out var NameEl)
            ? NameEl.GetString() ?? string.Empty : string.Empty;
        return (Status, FullName);
    }
    public async Task UpdateSessionStatusAsync(string SessionId, string NewStatus, string? Comment)
    {
        var Client = CreateClient();
        var Path = string.Format(DiditConstants.UpdateStatusPath, SessionId);
        var Body = new Dictionary<string, object> { [DiditConstants.PropertyNewStatus] = NewStatus };
        if (!string.IsNullOrEmpty(Comment)) { Body[DiditConstants.PropertyComment] = Comment; }
        var Json = JsonSerializer.Serialize(Body, JsonOpts);
        var Response = await Client.PatchAsync(Path, new StringContent(Json, Encoding.UTF8, DiditConstants.ContentTypeJson));
        if (!Response.IsSuccessStatusCode)
        {
            Logger.LogError("Didit update status failed: {Status}", Response.StatusCode);
        }
    }
    public async Task<string> ListSessionsAsync(string? VendorData, string? Status)
    {
        var Client = CreateClient();
        var Query = new List<string>();
        if (!string.IsNullOrEmpty(VendorData)) { Query.Add(string.Format(DiditConstants.QueryVendorDataFormat, Uri.EscapeDataString(VendorData))); }
        if (!string.IsNullOrEmpty(Status)) { Query.Add(string.Format(DiditConstants.QueryStatusFormat, Uri.EscapeDataString(Status))); }
        var Path = Query.Count > 0
            ? string.Format(DiditConstants.QueryPathFormat, DiditConstants.ListSessionsPath, string.Join('&', Query))
            : DiditConstants.ListSessionsPath;
        var Response = await Client.GetAsync(Path);
        return await Response.Content.ReadAsStringAsync();
    }
    public async Task DeleteSessionAsync(string SessionId)
    {
        var Client = CreateClient();
        var Path = string.Format(DiditConstants.DeleteSessionPath, SessionId);
        await Client.DeleteAsync(Path);
    }
    private HttpClient CreateClient()
    {
        var Client = HttpFactory.CreateClient(DiditConstants.HttpClientName);
        var ApiKey = Configuration[DiditConstants.ConfigApiKey] ?? string.Empty;
        if (!string.IsNullOrEmpty(ApiKey))
        {
            Client.DefaultRequestHeaders.Remove(DiditConstants.ApiKeyHeader);
            Client.DefaultRequestHeaders.Add(DiditConstants.ApiKeyHeader, ApiKey);
        }
        return Client;
    }
}
