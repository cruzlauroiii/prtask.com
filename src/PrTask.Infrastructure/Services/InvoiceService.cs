using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Infrastructure.Services;
public class InvoiceService(IHttpClientFactory HttpFactory, IConfiguration Configuration, ILogger<InvoiceService> Logger) : IInvoiceService
{
    private static readonly JsonSerializerOptions JsonOptions = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
    public async Task<InvoiceEntity> CreateInvoiceAsync(decimal Amount, string Currency, string Description, string? UserId)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Body = new
        {
            TotalAmount = new { Value = Amount, Currency },
            Description
        };
        var Response = await PostJsonAsync(Client, MayaConstants.InvoiceEndpoint, Body);
        var MayaInvoiceId = Response is null ? string.Empty : GetStringProperty(Response, MayaConstants.InvoiceIdProperty);
        var InvoiceUrl = Response is null ? string.Empty : GetStringProperty(Response, MayaConstants.InvoiceUrlProperty);
        return new InvoiceEntity
        {
            Id = Guid.NewGuid().ToString(),
            UserId = UserId ?? string.Empty,
            MayaInvoiceId = MayaInvoiceId,
            InvoiceUrl = InvoiceUrl,
            AmountCents = (long)(Amount * AppConstants.CentsToDollarsDivisor),
            Currency = Currency,
            Description = Description
        };
    }
    public async Task<InvoiceEntity?> GetInvoiceAsync(string InvoiceId)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(FormatStrings.MayaInvoicePath(InvoiceId));
        var Json = await ReadResponseOrEmptyAsync(Response);
        return string.IsNullOrEmpty(Json)
            ? null
            : JsonSerializer.Deserialize<InvoiceEntity>(Json, JsonOptions);
    }
    public async Task<IReadOnlyList<InvoiceEntity>> ListInvoicesAsync(string? UserId)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(MayaConstants.InvoiceEndpoint);
        var Json = await ReadResponseOrEmptyAsync(Response);
        return string.IsNullOrEmpty(Json)
            ? Array.Empty<InvoiceEntity>()
            : JsonSerializer.Deserialize<List<InvoiceEntity>>(Json, JsonOptions) ?? [];
    }
    public async Task<bool> DeleteInvoiceAsync(string InvoiceId)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.DeleteAsync(FormatStrings.MayaInvoicePath(InvoiceId));
        return Response.IsSuccessStatusCode;
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
