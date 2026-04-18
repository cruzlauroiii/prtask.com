namespace PrTask.Application.Contracts;
public record CreateRefundRequest(string PaymentId, long AmountCents, string Currency, string? Reason);
