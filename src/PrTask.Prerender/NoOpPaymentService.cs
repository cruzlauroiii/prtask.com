using PrTask.Application.Services;
namespace PrTask.Prerender;
public sealed class NoOpPaymentService : IPaymentService
{
    public Task<bool> ExistsAsync(string PaymentId) => Task.FromResult(false);
    public Task<string> CreateCheckoutAsync(string TaskId, string PayerId, long AmountCents) => Task.FromResult(string.Empty);
    public Task HandleWebhookAsync(string EventType, string PayloadJson) => Task.CompletedTask;
    public Task<string> GetStatusAsync(string PaymentId) => Task.FromResult(string.Empty);
    public Task<string> CreateCustomerAsync(string Email, string FirstName, string LastName) => Task.FromResult(string.Empty);
    public Task<string> GetCustomerAsync(string CustomerId) => Task.FromResult(string.Empty);
    public Task<bool> UpdateCustomerAsync(string CustomerId, string? Email, string? FirstName, string? LastName) => Task.FromResult(false);
    public Task<bool> DeleteCustomerAsync(string CustomerId) => Task.FromResult(false);
    public Task<string> VaultCardAsync(string CustomerId, string PaymentTokenId, bool IsDefault) => Task.FromResult(string.Empty);
    public Task<string> GetVaultedCardsAsync(string CustomerId) => Task.FromResult(string.Empty);
    public Task<string> GetVaultedCardAsync(string CustomerId, string CardToken) => Task.FromResult(string.Empty);
    public Task<bool> UpdateVaultedCardAsync(string CustomerId, string CardToken, bool IsDefault) => Task.FromResult(false);
    public Task<bool> DeleteVaultedCardAsync(string CustomerId, string CardToken) => Task.FromResult(false);
    public Task<string> PayWithVaultedCardAsync(string CustomerId, string CardToken, string TaskId, long AmountCents) => Task.FromResult(string.Empty);
    public Task<string> RegisterWebhookAsync(string EventName, string CallbackUrl) => Task.FromResult(string.Empty);
    public Task<string> GetWebhooksAsync() => Task.FromResult(string.Empty);
    public Task<bool> UpdateWebhookAsync(string WebhookId, string? EventName, string? CallbackUrl) => Task.FromResult(false);
    public Task<bool> DeleteWebhookAsync(string WebhookId) => Task.FromResult(false);
    public Task<string> ListVoidsAsync(string PaymentId) => Task.FromResult(string.Empty);
    public Task<string> GetVoidAsync(string PaymentId, string VoidId) => Task.FromResult(string.Empty);
    public Task<string> ListRefundsAsync(string PaymentId) => Task.FromResult(string.Empty);
    public Task<string> GetRefundAsync(string PaymentId, string RefundId) => Task.FromResult(string.Empty);
    public Task<string> CapturePaymentAsync(string PaymentId, long AmountCents) => Task.FromResult(string.Empty);
    public Task<bool> CancelPaymentAsync(string PaymentId, string Reason) => Task.FromResult(false);
    public Task<string> CalculateFeesAsync(long AmountCents) => Task.FromResult(string.Empty);
}
