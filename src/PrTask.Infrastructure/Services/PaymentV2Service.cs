using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Infrastructure.Services;
public class PaymentV2Service(IHttpClientFactory HttpFactory, IConfiguration Configuration, ILogger<PaymentV2Service> Logger) : IPaymentV2Service
{
    private static readonly JsonSerializerOptions JsonOptions = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
    public async Task<string> CreatePaymentV2Async(string ConnectToken, decimal Amount, string Currency, string RequestReferenceNumber)
    {
        var Client = CreateClient(UsesSecretKey: false);
        var Body = new
        {
            TotalAmount = new { Value = Amount, Currency },
            RequestReferenceNumber,
            ConnectToken
        };
        var Json = JsonSerializer.Serialize(Body, JsonOptions);
        var Response = await Client.PostAsync(MayaConstants.PaymentV2Endpoint, new StringContent(Json, Encoding.UTF8, AppConstants.ContentTypeJson));
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<string> GetPaymentV2Async(string PaymentId)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(FormatStrings.MayaPaymentV2Path(PaymentId));
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
    private async Task<string> ReadResponseOrEmptyAsync(HttpResponseMessage Response)
    {
        if (!Response.IsSuccessStatusCode)
        {
            var ErrorBody = await Response.Content.ReadAsStringAsync();
            Logger.LogError("Maya Payment V2 failed: {Status} {Error}", Response.StatusCode, ErrorBody);
            return string.Empty;
        }
        return await Response.Content.ReadAsStringAsync();
    }
}
