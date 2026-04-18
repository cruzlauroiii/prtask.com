namespace PrTask.Application.Services;
public interface IWalletPaymentService
{
    Task<string> CreateWalletPaymentAsync(decimal Amount, string Currency, string RequestReferenceNumber, string SuccessUrl, string FailureUrl, string CancelUrl);
    Task<string> CreateWalletLinkAsync(string RequestReferenceNumber, string SuccessUrl, string FailureUrl, string CancelUrl);
    Task<string> ExecuteWalletLinkPaymentAsync(string LinkId, decimal Amount, string Currency, string RequestReferenceNumber, string? IdempotencyKey);
    Task<string> GetWalletLinkAsync(string LinkId);
    Task<bool> DeleteWalletLinkAsync(string LinkId);
}
