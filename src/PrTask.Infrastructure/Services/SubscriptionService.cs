using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Infrastructure.Services;
public class SubscriptionService(IHttpClientFactory HttpFactory, IConfiguration Configuration, ILogger<SubscriptionService> Logger) : ISubscriptionService
{
    private static readonly JsonSerializerOptions JsonOptions = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
    public async Task<SubscriptionEntity> CreateSubscriptionAsync(string CustomerId, string CardTokenId, string Description, decimal Amount, string Currency, string Interval, int IntervalCount, DateTimeOffset StartDate)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Body = new
        {
            CustomerId,
            CardTokenId,
            Description,
            TotalAmount = new { Value = Amount, Currency },
            Interval,
            IntervalCount,
            StartDate = StartDate.ToString(AppConstants.RoundTripDateTimeFormat)
        };
        var Response = await PostJsonAsync(Client, MayaConstants.SubscriptionEndpoint, Body);
        var MayaSubscriptionId = Response is null ? string.Empty : GetStringProperty(Response, MayaConstants.SubscriptionIdProperty);
        return new SubscriptionEntity
        {
            Id = Guid.NewGuid().ToString(),
            CustomerId = CustomerId,
            CardTokenId = CardTokenId,
            MayaSubscriptionId = MayaSubscriptionId,
            Description = Description,
            AmountCents = (long)(Amount * AppConstants.CentsToDollarsDivisor),
            Currency = Currency,
            Interval = Enum.TryParse<SubscriptionInterval>(Interval, true, out var Parsed) ? Parsed : SubscriptionInterval.Month,
            IntervalCount = IntervalCount,
            StartDate = StartDate
        };
    }
    public async Task<IReadOnlyList<SubscriptionEntity>> ListSubscriptionsAsync(string CustomerId, string CardTokenId)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(FormatStrings.MayaSubscriptionListPath(CustomerId, CardTokenId));
        var Json = await ReadResponseOrEmptyAsync(Response);
        return string.IsNullOrEmpty(Json)
            ? Array.Empty<SubscriptionEntity>()
            : JsonSerializer.Deserialize<List<SubscriptionEntity>>(Json, JsonOptions) ?? [];
    }
    public async Task<SubscriptionEntity?> GetSubscriptionAsync(string SubscriptionId)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(FormatStrings.MayaSubscriptionPath(SubscriptionId));
        var Json = await ReadResponseOrEmptyAsync(Response);
        return string.IsNullOrEmpty(Json)
            ? null
            : JsonSerializer.Deserialize<SubscriptionEntity>(Json, JsonOptions);
    }
    public async Task<bool> CancelSubscriptionAsync(string SubscriptionId)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.DeleteAsync(FormatStrings.MayaSubscriptionPath(SubscriptionId));
        return Response.IsSuccessStatusCode;
    }
    public async Task<string> GetSubscriptionPaymentsAsync(string SubscriptionId)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(FormatStrings.MayaSubscriptionPaymentsPath(SubscriptionId));
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
