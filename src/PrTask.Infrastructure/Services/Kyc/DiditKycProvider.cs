using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Infrastructure.Services.Kyc;
public class DiditKycProvider(IHttpClientFactory HttpFactory, IConfiguration Configuration, ILogger<DiditKycProvider> Logger) : IKycProvider
{
    private static readonly JsonSerializerOptions JsonOpts = new() { PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower };
    public string ProviderName => DiditConstants.ProviderName;
    public async Task<KycSessionResult> CreateSessionAsync(string UserId, string? CallbackUrl, KycSessionOptions? Options)
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
        if (Options is not null)
        {
            if (!string.IsNullOrEmpty(Options.Language)) { Body[DiditConstants.PropertyLanguage] = Options.Language; }
            var ContactDetails = BuildContactDetails(Options);
            if (ContactDetails.Count > 0) { Body[DiditConstants.PropertyContactDetails] = ContactDetails; }
            var ExpectedDetails = BuildExpectedDetails(Options);
            if (ExpectedDetails.Count > 0) { Body[DiditConstants.PropertyExpectedDetails] = ExpectedDetails; }
        }
        var Json = JsonSerializer.Serialize(Body, JsonOpts);
        var Response = await Client.PostAsync(DiditConstants.CreateSessionPath,
            new StringContent(Json, Encoding.UTF8, DiditConstants.ContentTypeJson));
        var ResponseJson = await Response.Content.ReadAsStringAsync();
        if (!Response.IsSuccessStatusCode)
        {
            Logger.LogError(DiditConstants.LogCreateSessionFailed, Response.StatusCode, ResponseJson);
            return new KycSessionResult(string.Empty, string.Empty, string.Empty);
        }
        using var Doc = JsonDocument.Parse(ResponseJson);
        var Root = Doc.RootElement;
        return new KycSessionResult(
            SessionId: GetProp(Root, DiditConstants.PropertySessionId),
            VerificationUrl: GetProp(Root, DiditConstants.PropertyUrl),
            Status: GetProp(Root, DiditConstants.PropertyStatus));
    }
    public async Task<KycSessionStatus> GetSessionStatusAsync(string SessionId)
    {
        var Client = CreateClient();
        var Path = string.Format(DiditConstants.RetrieveSessionPath, SessionId);
        var Response = await Client.GetAsync(Path);
        var ResponseJson = await Response.Content.ReadAsStringAsync();
        if (!Response.IsSuccessStatusCode)
        {
            Logger.LogError(DiditConstants.LogGetSessionFailed, Response.StatusCode);
            return new KycSessionStatus(SessionId, string.Empty, null, null, null);
        }
        using var Doc = JsonDocument.Parse(ResponseJson);
        var Root = Doc.RootElement;
        return new KycSessionStatus(
            SessionId: SessionId,
            Status: GetProp(Root, DiditConstants.PropertyStatus),
            FullName: GetOptionalProp(Root, DiditConstants.PropertyFullName),
            DocumentType: GetOptionalProp(Root, DiditConstants.PropertyDocumentType),
            DecisionAt: Root.TryGetProperty(DiditConstants.PropertyDecisionTime, out var Dt) && Dt.ValueKind != JsonValueKind.Null
                ? Dt.TryGetDateTime(out var Parsed) ? Parsed : null : null);
    }
    public Task<bool> HandleWebhookAsync(string Payload, string? Signature)
    {
        if (string.IsNullOrEmpty(Payload)) { return Task.FromResult(false); }
        try
        {
            using var Doc = JsonDocument.Parse(Payload);
            var Root = Doc.RootElement;
            var SessionId = GetProp(Root, DiditConstants.PropertySessionId);
            var Status = GetProp(Root, DiditConstants.PropertyStatus);
            if (string.IsNullOrEmpty(SessionId) || string.IsNullOrEmpty(Status))
            {
                return Task.FromResult(false);
            }
            Logger.LogInformation(DiditConstants.LogWebhookReceived, SessionId, Status);
            return Task.FromResult(true);
        }
        catch (JsonException Ex)
        {
            Logger.LogError(Ex, DiditConstants.LogWebhookParseError);
            return Task.FromResult(false);
        }
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
    private static Dictionary<string, object> BuildContactDetails(KycSessionOptions Options)
    {
        var Details = new Dictionary<string, object>();
        if (!string.IsNullOrEmpty(Options.Email)) { Details[DiditConstants.PropertyEmail] = Options.Email; }
        if (!string.IsNullOrEmpty(Options.Phone)) { Details[DiditConstants.PropertyPhone] = Options.Phone; }
        return Details;
    }
    private static Dictionary<string, object> BuildExpectedDetails(KycSessionOptions Options)
    {
        var Details = new Dictionary<string, object>();
        if (!string.IsNullOrEmpty(Options.FirstName)) { Details[DiditConstants.PropertyFirstName] = Options.FirstName; }
        if (!string.IsNullOrEmpty(Options.LastName)) { Details[DiditConstants.PropertyLastName] = Options.LastName; }
        if (!string.IsNullOrEmpty(Options.DateOfBirth)) { Details[DiditConstants.PropertyDateOfBirth] = Options.DateOfBirth; }
        if (!string.IsNullOrEmpty(Options.Nationality)) { Details[DiditConstants.PropertyNationality] = Options.Nationality; }
        return Details;
    }
    private static string GetProp(JsonElement El, string Name) =>
        El.TryGetProperty(Name, out var Val) ? Val.GetString() ?? string.Empty : string.Empty;
    private static string? GetOptionalProp(JsonElement El, string Name) =>
        El.TryGetProperty(Name, out var Val) && Val.ValueKind != JsonValueKind.Null ? Val.GetString() : null;
}
