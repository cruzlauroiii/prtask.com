using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Infrastructure.Services;
public partial class PaymentService(IHttpClientFactory HttpFactory, IConfiguration Configuration, ILogger<PaymentService> Logger, IPaymentRecordService RecordService) : IPaymentService
{
    private static readonly JsonSerializerOptions JsonOptions = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
    public Task<bool> ExistsAsync(string PaymentId) => Task.FromResult(!string.IsNullOrEmpty(PaymentId));
    public async Task<string> CreateCheckoutAsync(string TaskId, string PayerId, long AmountCents)
    {
        var Client = HttpFactory.CreateClient("Maya");
        ApplyMayaAuthHeaders(Client, UsesSecretKey: false);
        var CheckoutBody = new
        {
            TotalAmount = new { Value = AmountCents / 100m, Currency = "USD" },
            Buyer = new { Contact = new { Email = $"{PayerId}@prtask.com" } },
            Items = new[]
            {
                new
                {
                    Name = $"Task Bounty: {TaskId}",
                    Quantity = 1,
                    TotalAmount = new { Value = AmountCents / 100m }
                }
            },
            RedirectUrl = new
            {
                Success = $"https://{AppConstants.AppDomain}/dashboard?payment=success&task={TaskId}",
                Failure = $"https://{AppConstants.AppDomain}/dashboard?payment=failed&task={TaskId}",
                Cancel = $"https://{AppConstants.AppDomain}/dashboard?payment=cancelled&task={TaskId}"
            },
            RequestReferenceNumber = $"PRTASK-{TaskId}-{DateTime.UtcNow:yyyyMMddHHmmss}"
        };
        var JsonContent = JsonSerializer.Serialize(CheckoutBody, JsonOptions);
        var Response = await Client.PostAsync(MayaConstants.CheckoutEndpoint, new StringContent(JsonContent, Encoding.UTF8, "application/json"));
        if (!Response.IsSuccessStatusCode)
        {
            var ErrorBody = await Response.Content.ReadAsStringAsync();
            Logger.LogError("Maya checkout failed for task {TaskId}: {StatusCode} {Error}", TaskId, Response.StatusCode, ErrorBody);
            return string.Empty;
        }
        var ResponseJson = await Response.Content.ReadAsStringAsync();
        using var Document = JsonDocument.Parse(ResponseJson);
        return Document.RootElement.TryGetProperty("redirectUrl", out var RedirectUrlElement)
            ? RedirectUrlElement.GetString() ?? string.Empty
            : string.Empty;
    }
    public Task HandleWebhookAsync(string EventType, string PayloadJson)
    {
        Logger.LogInformation("Maya webhook received: {EventType}", EventType);
        return Task.CompletedTask;
    }
    public Task<string> GetStatusAsync(string PaymentId) => Task.FromResult("pending");
    private void ApplyMayaAuthHeaders(HttpClient Client, bool UsesSecretKey)
    {
        var Key = UsesSecretKey
            ? Configuration["Maya:SecretKey"]
            : Configuration["Maya:PublicKey"];
        if (!string.IsNullOrEmpty(Key))
        {
            var Encoded = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{Key}:"));
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Encoded);
        }
    }
}
