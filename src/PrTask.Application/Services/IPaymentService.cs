namespace PrTask.Application.Services;
public interface IPaymentService
{
    Task<bool> ExistsAsync(string PaymentId);
    Task<string> CreateCheckoutAsync(string TaskId, string PayerId, long AmountCents);
    Task HandleWebhookAsync(string EventType, string PayloadJson);
    Task<string> GetStatusAsync(string PaymentId);
    Task<string> CreateCustomerAsync(string Email, string FirstName, string LastName);
    Task<string> GetCustomerAsync(string CustomerId);
    Task<bool> UpdateCustomerAsync(string CustomerId, string? Email, string? FirstName, string? LastName);
    Task<bool> DeleteCustomerAsync(string CustomerId);
    Task<string> VaultCardAsync(string CustomerId, string PaymentTokenId, bool IsDefault);
    Task<string> GetVaultedCardsAsync(string CustomerId);
    Task<string> GetVaultedCardAsync(string CustomerId, string CardToken);
    Task<bool> UpdateVaultedCardAsync(string CustomerId, string CardToken, bool IsDefault);
    Task<bool> DeleteVaultedCardAsync(string CustomerId, string CardToken);
    Task<string> PayWithVaultedCardAsync(string CustomerId, string CardToken, string TaskId, long AmountCents);
    Task<string> RegisterWebhookAsync(string EventName, string CallbackUrl);
    Task<string> GetWebhooksAsync();
    Task<bool> UpdateWebhookAsync(string WebhookId, string? EventName, string? CallbackUrl);
    Task<bool> DeleteWebhookAsync(string WebhookId);
    Task<string> ListVoidsAsync(string PaymentId);
    Task<string> GetVoidAsync(string PaymentId, string VoidId);
    Task<string> ListRefundsAsync(string PaymentId);
    Task<string> GetRefundAsync(string PaymentId, string RefundId);
    Task<string> CapturePaymentAsync(string PaymentId, long AmountCents);
    Task<bool> CancelPaymentAsync(string PaymentId, string Reason);
    Task<string> CalculateFeesAsync(long AmountCents);
}
