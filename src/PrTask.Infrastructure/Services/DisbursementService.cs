using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Infrastructure.Services;
public class DisbursementService(IHttpClientFactory HttpFactory, ILogger<DisbursementService> Logger) : IDisbursementService
{
    private static readonly JsonSerializerOptions JsonOptions = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
    private string? SessionToken;
    public async Task<string> CreateSessionAsync(string Email, string Password)
    {
        var Client = CreateSessionClient();
        var Body = new { Email, Password };
        var Response = await PostJsonAsync(Client, MayaConstants.DisbursementSessionEndpoint, Body);
        if (Response is null)
        {
            return string.Empty;
        }
        SessionToken = GetStringProperty(Response, MayaConstants.SessionTokenProperty);
        return SessionToken;
    }
    public async Task TerminateSessionAsync()
    {
        if (string.IsNullOrEmpty(SessionToken))
        {
            return;
        }
        var Client = CreateAuthenticatedClient();
        var Response = await Client.DeleteAsync(MayaConstants.DisbursementSessionEndpoint);
        if (!Response.IsSuccessStatusCode)
        {
            Logger.LogError("Maya terminate session failed: {Status}", Response.StatusCode);
        }
        SessionToken = null;
    }
    public async Task<string> GetWalletAsync()
    {
        var Client = CreateAuthenticatedClient();
        var Response = await Client.GetAsync(MayaConstants.DisbursementWalletEndpoint);
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<string> RegisterBeneficiariesAsync(string CsvContent)
    {
        var Client = CreateAuthenticatedClient();
        var Body = new { CsvContent };
        var Response = await PostJsonAsync(Client, MayaConstants.DisbursementBeneficiariesEndpoint, Body);
        return Response is null ? string.Empty : GetStringProperty(Response, MayaConstants.IdProperty);
    }
    public async Task<string> SubmitDisbursementAsync(string CsvContent)
    {
        var Client = CreateAuthenticatedClient();
        var Body = new { CsvContent };
        var Response = await PostJsonAsync(Client, MayaConstants.DisbursementsEndpoint, Body);
        return Response is null ? string.Empty : GetStringProperty(Response, MayaConstants.IdProperty);
    }
    public async Task<string> ProcessDisbursementAsync(string DisbursementId)
    {
        var Client = CreateAuthenticatedClient();
        var Response = await PostJsonAsync(Client, FormatStrings.MayaDisbursementProcessPath(DisbursementId), new { });
        return Response is null ? string.Empty : GetStringProperty(Response, MayaConstants.StatusProperty);
    }
    public async Task<string> GetDisbursementStatusAsync(string DisbursementId)
    {
        var Client = CreateAuthenticatedClient();
        var Response = await Client.GetAsync(FormatStrings.MayaDisbursementPath(DisbursementId));
        return await ReadResponseOrEmptyAsync(Response);
    }
    private HttpClient CreateSessionClient()
    {
        return HttpFactory.CreateClient(MayaConstants.HttpClientName);
    }
    private HttpClient CreateAuthenticatedClient()
    {
        var Client = HttpFactory.CreateClient(MayaConstants.HttpClientName);
        if (!string.IsNullOrEmpty(SessionToken))
        {
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(MayaConstants.BearerScheme, SessionToken);
        }
        return Client;
    }
    private async Task<JsonDocument?> PostJsonAsync(HttpClient Client, string Endpoint, object Body)
    {
        var Json = JsonSerializer.Serialize(Body, JsonOptions);
        var Response = await Client.PostAsync(Endpoint, new StringContent(Json, Encoding.UTF8, AppConstants.ContentTypeJson));
        if (!Response.IsSuccessStatusCode)
        {
            var ErrorBody = await Response.Content.ReadAsStringAsync();
            Logger.LogError("Maya {Endpoint} failed: {Status} {Error}", Endpoint, Response.StatusCode, ErrorBody);
            return null;
        }
        var ResponseJson = await Response.Content.ReadAsStringAsync();
        return JsonDocument.Parse(ResponseJson);
    }
    private async Task<string> ReadResponseOrEmptyAsync(HttpResponseMessage Response)
    {
        if (!Response.IsSuccessStatusCode)
        {
            Logger.LogError("Maya request failed: {Status}", Response.StatusCode);
            return string.Empty;
        }
        return await Response.Content.ReadAsStringAsync();
    }
    private static string GetStringProperty(JsonDocument Document, string PropertyName) =>
        Document.RootElement.TryGetProperty(PropertyName, out var Element)
            ? Element.GetString() ?? string.Empty
            : string.Empty;
}
