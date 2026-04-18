using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Infrastructure.Services;
public class RemittanceService(IHttpClientFactory HttpFactory, IConfiguration Configuration, ILogger<RemittanceService> Logger) : IRemittanceService
{
    private static readonly JsonSerializerOptions JsonOptions = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
    public async Task<string> CreateRemittanceAsync(string RecipientMayaAccount, decimal Amount, string Currency, string RequestReferenceNumber)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Body = new
        {
            RecipientMayaAccount,
            TotalAmount = new { Value = Amount, Currency },
            RequestReferenceNumber
        };
        var Response = await PostJsonAsync(Client, MayaConstants.RemittanceEndpoint, Body);
        return Response is null ? string.Empty : GetStringProperty(Response, MayaConstants.IdProperty);
    }
    public async Task ExecuteRemittanceAsync(string TransactionReferenceNumber)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await PostJsonAsync(Client, FormatStrings.MayaRemittanceExecutePath(TransactionReferenceNumber), new { });
        if (Response is null)
        {
            Logger.LogError("Maya execute remittance failed for {TransactionReferenceNumber}", TransactionReferenceNumber);
        }
    }
    public async Task<string> GetRemittanceStatusAsync(string TransactionReferenceNumber)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(FormatStrings.MayaRemittancePath(TransactionReferenceNumber));
        return await ReadResponseOrEmptyAsync(Response);
    }
    private HttpClient CreateClient(bool UsesSecretKey)
    {
        var Client = HttpFactory.CreateClient(MayaConstants.HttpClientName);
        var Key = UsesSecretKey
            ? Configuration[MayaConstants.ConfigSecretKey]
            : Configuration[MayaConstants.ConfigPublicKey];
        if (!string.IsNullOrEmpty(Key))
        {
            var Encoded = Convert.ToBase64String(Encoding.ASCII.GetBytes(FormatStrings.BasicAuthPayload(Key)));
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(AppConstants.AuthSchemeBasic, Encoded);
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
