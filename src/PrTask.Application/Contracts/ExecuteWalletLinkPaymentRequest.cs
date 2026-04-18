namespace PrTask.Application.Contracts;
public record ExecuteWalletLinkPaymentRequest(
    decimal Amount, string Currency, string RequestReferenceNumber, string? IdempotencyKey);
