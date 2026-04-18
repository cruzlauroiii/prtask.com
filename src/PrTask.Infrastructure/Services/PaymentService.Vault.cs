using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Infrastructure.Services;
public partial class PaymentService
{
    public async Task<string> CreateCustomerAsync(string Email, string FirstName, string LastName)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Body = new { FirstName, LastName, Contact = new { Email } };
        var Response = await PostJsonAsync(Client, MayaConstants.CustomerEndpoint, Body);
        return Response is null ? string.Empty : GetStringProperty(Response, MayaConstants.IdProperty);
    }
    public async Task<string> GetCustomerAsync(string CustomerId)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(FormatStrings.MayaCustomerPath(CustomerId));
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<bool> UpdateCustomerAsync(string CustomerId, string? Email, string? FirstName, string? LastName)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Body = new { FirstName, LastName, Contact = new { Email } };
        var Response = await PutJsonAsync(Client, FormatStrings.MayaCustomerPath(CustomerId), Body);
        return Response is not null;
    }
    public async Task<bool> DeleteCustomerAsync(string CustomerId)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.DeleteAsync(FormatStrings.MayaCustomerPath(CustomerId));
        return Response.IsSuccessStatusCode;
    }
    public async Task<string> VaultCardAsync(string CustomerId, string PaymentTokenId, bool IsDefault)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Body = new { PaymentTokenId, IsDefault };
        var Response = await PostJsonAsync(Client, FormatStrings.MayaCustomerCardsPath(CustomerId), Body);
        return Response is null ? string.Empty : GetStringProperty(Response, MayaConstants.CardTokenIdProperty);
    }
    public async Task<string> GetVaultedCardsAsync(string CustomerId)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(FormatStrings.MayaCustomerCardsPath(CustomerId));
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<string> GetVaultedCardAsync(string CustomerId, string CardToken)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(FormatStrings.MayaCustomerCardPath(CustomerId, CardToken));
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<bool> UpdateVaultedCardAsync(string CustomerId, string CardToken, bool IsDefault)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Body = new { IsDefault };
        var Response = await PutJsonAsync(Client, FormatStrings.MayaCustomerCardPath(CustomerId, CardToken), Body);
        return Response is not null;
    }
    public async Task<bool> DeleteVaultedCardAsync(string CustomerId, string CardToken)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.DeleteAsync(FormatStrings.MayaCustomerCardPath(CustomerId, CardToken));
        return Response.IsSuccessStatusCode;
    }
    public async Task<string> PayWithVaultedCardAsync(string CustomerId, string CardToken, string TaskId, long AmountCents)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Body = new
        {
            TotalAmount = new { Amount = AmountCents / AppConstants.CentsToDollarsDivisor, Currency = AppConstants.CurrencyCode },
            RequestReferenceNumber = FormatStrings.PaymentReferenceNumber(TaskId),
            RedirectUrl = new
            {
                Success = FormatStrings.PaymentSuccessRedirect(TaskId),
                Failure = FormatStrings.PaymentFailureRedirect(TaskId),
                Cancel = FormatStrings.PaymentCancelRedirect(TaskId)
            }
        };
        var Response = await PostJsonAsync(Client, FormatStrings.MayaCustomerCardPaymentsPath(CustomerId, CardToken), Body);
        if (Response is null)
        {
            return string.Empty;
        }
        var VerificationUrl = GetStringProperty(Response, MayaConstants.VerificationUrlProperty);
        var MayaPaymentId = GetStringProperty(Response, MayaConstants.IdProperty);
        await RecordService.CreateAsync(new PaymentEntity
        {
            Id = Guid.NewGuid().ToString(),
            MayaPaymentId = MayaPaymentId,
            PayerId = CustomerId,
            TaskId = TaskId,
            AmountCents = AmountCents,
            Type = PaymentType.AutomaticCharge,
            Status = PaymentStatus.Processing
        });
        return VerificationUrl;
    }
    public async Task<string> RegisterWebhookAsync(string EventName, string CallbackUrl)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Body = new { Name = EventName, CallbackUrl };
        var Response = await PostJsonAsync(Client, MayaConstants.WebhookEndpoint, Body);
        return Response is null ? string.Empty : GetStringProperty(Response, MayaConstants.IdProperty);
    }
    public async Task<string> GetWebhooksAsync()
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(MayaConstants.WebhookEndpoint);
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<bool> UpdateWebhookAsync(string WebhookId, string? EventName, string? CallbackUrl)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Body = new { Name = EventName, CallbackUrl };
        var Response = await PutJsonAsync(Client, FormatStrings.MayaWebhookPath(WebhookId), Body);
        return Response is not null;
    }
    public async Task<bool> DeleteWebhookAsync(string WebhookId)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.DeleteAsync(FormatStrings.MayaWebhookPath(WebhookId));
        return Response.IsSuccessStatusCode;
    }
    private static void AddIdempotencyHeader(HttpClient Client, string IdempotencyKey)
    {
        Client.DefaultRequestHeaders.Remove(MayaConstants.IdempotencyKeyHeader);
        Client.DefaultRequestHeaders.Add(MayaConstants.IdempotencyKeyHeader, IdempotencyKey);
    }

    private static bool IsBeforeVoidCutoff(DateTimeOffset Timestamp)
    {
        var PhilippineZone = TimeZoneInfo.FindSystemTimeZoneById(MayaConstants.VoidCutoffTimezone);
        var LocalTime = TimeZoneInfo.ConvertTime(Timestamp, PhilippineZone);
        var CutoffParts = MayaConstants.VoidCutoffTime.Split(':');
        var CutoffHour = int.Parse(CutoffParts[0], System.Globalization.CultureInfo.InvariantCulture);
        var CutoffMinute = int.Parse(CutoffParts[1], System.Globalization.CultureInfo.InvariantCulture);
        return LocalTime.Hour < CutoffHour || (LocalTime.Hour == CutoffHour && LocalTime.Minute < CutoffMinute);
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
    private async Task<JsonDocument?> PutJsonAsync(HttpClient Client, string Endpoint, object Body)
    {
        var Json = JsonSerializer.Serialize(Body, JsonOptions);
        var Response = await Client.PutAsync(Endpoint, new StringContent(Json, Encoding.UTF8, AppConstants.ContentTypeJson));
        if (!Response.IsSuccessStatusCode)
        {
            var ErrorBody = await Response.Content.ReadAsStringAsync();
            Logger.LogError("Maya PUT {Endpoint} failed: {Status} {Error}", Endpoint, Response.StatusCode, ErrorBody);
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
    public async Task<string> ListVoidsAsync(string PaymentId)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(FormatStrings.MayaPaymentVoidsPath(PaymentId));
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<string> GetVoidAsync(string PaymentId, string VoidId)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(FormatStrings.MayaPaymentVoidPath(PaymentId, VoidId));
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<string> ListRefundsAsync(string PaymentId)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(FormatStrings.MayaPaymentRefundsPath(PaymentId));
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<string> GetRefundAsync(string PaymentId, string RefundId)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Response = await Client.GetAsync(FormatStrings.MayaPaymentRefundPath(PaymentId, RefundId));
        return await ReadResponseOrEmptyAsync(Response);
    }
    public async Task<string> CapturePaymentAsync(string PaymentId, long AmountCents)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Body = new { TotalAmount = new { Amount = AmountCents / AppConstants.CentsToDollarsDivisor, Currency = AppConstants.CurrencyCode } };
        var Response = await PostJsonAsync(Client, FormatStrings.MayaPaymentCapturePath(PaymentId), Body);
        return Response is null ? string.Empty : GetStringProperty(Response, MayaConstants.IdProperty);
    }
    public async Task<bool> CancelPaymentAsync(string PaymentId, string Reason)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Body = new { Reason, RequestReferenceNumber = FormatStrings.MayaCancelReference(PaymentId) };
        var Response = await PostJsonAsync(Client, FormatStrings.MayaPaymentCancelPath(PaymentId), Body);
        return Response is not null;
    }
    public async Task<string> CalculateFeesAsync(long AmountCents)
    {
        var Client = CreateClient(UsesSecretKey: true);
        var Body = new { TotalAmount = new { Value = AmountCents / AppConstants.CentsToDollarsDivisor, Currency = AppConstants.CurrencyCode } };
        var Response = await PostJsonAsync(Client, MayaConstants.FeesEndpoint, Body);
        return Response is null ? string.Empty : Response.RootElement.ToString();
    }
    private static string GetStringProperty(JsonDocument Document, string PropertyName) =>
        Document.RootElement.TryGetProperty(PropertyName, out var Element)
            ? Element.GetString() ?? string.Empty
            : string.Empty;
}
