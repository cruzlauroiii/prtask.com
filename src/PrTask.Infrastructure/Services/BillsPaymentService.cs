using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Infrastructure.Services;
public class BillsPaymentService(IHttpClientFactory HttpFactory, IConfiguration Configuration, ILogger<BillsPaymentService> Logger) : IBillsPaymentService
{
    private static readonly JsonSerializerOptions JsonOptions = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
    public async Task<IReadOnlyList<BillerInfo>> GetBillersAsync()
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(MayaConstants.BillersEndpoint);
        var Json = await ReadResponseOrEmptyAsync(Response);
        return string.IsNullOrEmpty(Json)
            ? Array.Empty<BillerInfo>()
            : JsonSerializer.Deserialize<List<BillerInfo>>(Json, JsonOptions) ?? [];
    }
    public async Task<BillerInfo?> GetBillerAsync(string Slug)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(FormatStrings.MayaBillerPath(Slug));
        var Json = await ReadResponseOrEmptyAsync(Response);
        return string.IsNullOrEmpty(Json)
            ? null
            : JsonSerializer.Deserialize<BillerInfo>(Json, JsonOptions);
    }
    public async Task<string> CreateBillPaymentAsync(string BillerSlug, string AccountNumber, decimal Amount, string Currency, string? CallbackUrl)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Body = new
        {
            BillerSlug,
            AccountNumber,
            TotalAmount = new { Value = Amount, Currency },
            CallbackUrl
        };
        var Response = await PostJsonAsync(Client, MayaConstants.BillPaymentEndpoint, Body);
        return Response is null ? string.Empty : GetStringProperty(Response, MayaConstants.IdProperty);
    }
    public async Task ExecuteBillPaymentAsync(string BillPaymentId, string? CardNumber, string? ExpMonth, string? ExpYear, string? Cvc, bool UsePushPayment)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Body = new
        {
            Card = CardNumber is not null ? new { Number = CardNumber, ExpMonth, ExpYear, Cvc } : null,
            UsePushPayment
        };
        var Response = await PostJsonAsync(Client, FormatStrings.MayaBillPaymentExecutePath(BillPaymentId), Body);
        if (Response is null)
        {
            Logger.LogError("Maya execute bill payment failed for {BillPaymentId}", BillPaymentId);
        }
    }
    public async Task<string> GetBillPaymentStatusAsync(string BillPaymentId)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(FormatStrings.MayaBillPaymentStatusPath(BillPaymentId));
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
