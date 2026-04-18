namespace PrTask.Application.Contracts;
public record CreateWalletPaymentRequest(
    decimal Amount, string Currency, string RequestReferenceNumber,
    string SuccessUrl, string FailureUrl, string CancelUrl);
