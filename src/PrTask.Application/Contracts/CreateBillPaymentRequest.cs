namespace PrTask.Application.Contracts;
public record CreateBillPaymentRequest(
    string BillerSlug, string AccountNumber, decimal Amount,
    string Currency, string? CallbackUrl);
