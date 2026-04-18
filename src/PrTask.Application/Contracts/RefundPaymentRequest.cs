namespace PrTask.Application.Contracts;
public record RefundPaymentRequest(long AmountCents, string Reason);
