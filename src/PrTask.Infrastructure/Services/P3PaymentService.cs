using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Infrastructure.Services;
public class P3PaymentService(IHttpClientFactory HttpFactory, IConfiguration Configuration, ILogger<P3PaymentService> Logger) : IP3PaymentService
{
    private static readonly JsonSerializerOptions JsonOptions = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
    public async Task<string> PayAsync(string CardNumber, string ExpMonth, string ExpYear, string Cvc, decimal Amount, string Currency, string RequestReferenceNumber)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Body = new
        {
            Card = new { Number = CardNumber, ExpMonth, ExpYear, Cvc },
            TotalAmount = new { Value = Amount, Currency },
            RequestReferenceNumber
        };
        var Response = await PostJsonAsync(Client, MayaConstants.P3PayEndpoint, Body);
        return Response is null ? string.Empty : GetStringProperty(Response, MayaConstants.TransactionRefNoProperty);
    }
    public async Task<string> AuthorizeAsync(string CardNumber, string ExpMonth, string ExpYear, string Cvc, decimal Amount, string Currency, string RequestReferenceNumber)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Body = new
        {
            Card = new { Number = CardNumber, ExpMonth, ExpYear, Cvc },
            TotalAmount = new { Value = Amount, Currency },
            RequestReferenceNumber
        };
        var Response = await PostJsonAsync(Client, MayaConstants.P3AuthorizeEndpoint, Body);
        return Response is null ? string.Empty : GetStringProperty(Response, MayaConstants.TransactionRefNoProperty);
    }
    public async Task<string> CaptureAsync(string TransactionRefNo)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Body = new { TransactionRefNo };
        var Response = await PostJsonAsync(Client, MayaConstants.P3CaptureEndpoint, Body);
        return Response is null ? string.Empty : GetStringProperty(Response, MayaConstants.StatusProperty);
    }
    public async Task<string> FinalCaptureAsync(string TransactionRefNo)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Body = new { TransactionRefNo };
        var Response = await PostJsonAsync(Client, MayaConstants.P3CaptureFinalEndpoint, Body);
        return Response is null ? string.Empty : GetStringProperty(Response, MayaConstants.StatusProperty);
    }
    public async Task<bool> VoidP3Async(string TransactionRefNo, string? Reason, string? IdempotencyKey)
    {
        var Client = CreateClient(UsesSecretKey: true);
        if (!string.IsNullOrEmpty(IdempotencyKey))
        {
            Client.DefaultRequestHeaders.Remove(MayaConstants.IdempotencyKeyHeader);
            Client.DefaultRequestHeaders.Add(MayaConstants.IdempotencyKeyHeader, IdempotencyKey);
        }
        var Body = new { TransactionRefNo, Reason };
        var Response = await PostJsonAsync(Client, MayaConstants.P3VoidEndpoint, Body);
        return Response is not null;
    }
    public async Task<bool> RefundP3Async(string TransactionRefNo, decimal Amount, string? Reason, string? IdempotencyKey)
    {
        var Client = CreateClient(UsesSecretKey: true);
        if (!string.IsNullOrEmpty(IdempotencyKey))
        {
            Client.DefaultRequestHeaders.Remove(MayaConstants.IdempotencyKeyHeader);
            Client.DefaultRequestHeaders.Add(MayaConstants.IdempotencyKeyHeader, IdempotencyKey);
        }
        var Body = new { TransactionRefNo, TotalAmount = new { Value = Amount }, Reason };
        var Response = await PostJsonAsync(Client, MayaConstants.P3RefundEndpoint, Body);
        return Response is not null;
    }
    public async Task<string> GetTransactionAsync(string RefNo)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(FormatStrings.MayaP3TransactionPath(RefNo));
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<string> ListTransactionsAsync(string? MerchantId, int? Page, int? Size)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(FormatStrings.P3TransactionsQuery(MerchantId, Page, Size));
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<string> BalanceInquiryAsync()
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(MayaConstants.P3BalanceInquiryEndpoint);
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<string> GetBinAsync(string Bin)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(FormatStrings.MayaP3BinPath(Bin));
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<string> QueryBinsAsync()
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(MayaConstants.P3BinsEndpoint);
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<string> GetBinPatternsAsync()
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(MayaConstants.P3BinsPatternsEndpoint);
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<string> GetBinDeltaAsync()
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(MayaConstants.P3BinsDeltaEndpoint);
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<string> CreateApiKeyAsync()
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await PostJsonAsync(Client, MayaConstants.P3KeysEndpoint, new { });
        return Response is null ? string.Empty : GetStringProperty(Response, MayaConstants.IdProperty);
    }
    public async Task<string> GetApiKeyAsync(string KeyId)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(FormatStrings.MayaP3KeyPath(KeyId));
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<string> ListApiKeysAsync()
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(MayaConstants.P3KeysEndpoint);
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<bool> DeleteApiKeyAsync(string KeyId)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.DeleteAsync(FormatStrings.MayaP3KeyPath(KeyId));
        return Response.IsSuccessStatusCode;
    }
    public async Task<string> PingAsync()
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(MayaConstants.P3ServicePingEndpoint);
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<string> CreateRecurringPaymentAsync(string CardNumber, string ExpMonth, string ExpYear, string Cvc, decimal Amount, string Currency, string RequestReferenceNumber, string FrequencyIndicator)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Body = new
        {
            Card = new { Number = CardNumber, ExpMonth, ExpYear, Cvc },
            TotalAmount = new { Value = Amount, Currency },
            RequestReferenceNumber,
            FrequencyIndicator
        };
        var Response = await PostJsonAsync(Client, MayaConstants.P3PayEndpoint, Body);
        return Response is null ? string.Empty : GetStringProperty(Response, MayaConstants.TransactionRefNoProperty);
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
