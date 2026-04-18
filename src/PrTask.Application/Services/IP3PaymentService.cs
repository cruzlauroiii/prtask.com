namespace PrTask.Application.Services;
public interface IP3PaymentService
{
    Task<string> PayAsync(string CardNumber, string ExpMonth, string ExpYear, string Cvc, decimal Amount, string Currency, string RequestReferenceNumber);
    Task<string> AuthorizeAsync(string CardNumber, string ExpMonth, string ExpYear, string Cvc, decimal Amount, string Currency, string RequestReferenceNumber);
    Task<string> CaptureAsync(string TransactionRefNo);
    Task<string> FinalCaptureAsync(string TransactionRefNo);
    Task<bool> VoidP3Async(string TransactionRefNo, string? Reason, string? IdempotencyKey);
    Task<bool> RefundP3Async(string TransactionRefNo, decimal Amount, string? Reason, string? IdempotencyKey);
    Task<string> GetTransactionAsync(string RefNo);
    Task<string> ListTransactionsAsync(string? MerchantId, int? Page, int? Size);
    Task<string> BalanceInquiryAsync();
    Task<string> GetBinAsync(string Bin);
    Task<string> QueryBinsAsync();
    Task<string> GetBinPatternsAsync();
    Task<string> GetBinDeltaAsync();
    Task<string> CreateApiKeyAsync();
    Task<string> GetApiKeyAsync(string KeyId);
    Task<string> ListApiKeysAsync();
    Task<bool> DeleteApiKeyAsync(string KeyId);
    Task<string> PingAsync();
    Task<string> CreateRecurringPaymentAsync(string CardNumber, string ExpMonth, string ExpYear, string Cvc, decimal Amount, string Currency, string RequestReferenceNumber, string FrequencyIndicator);
}
