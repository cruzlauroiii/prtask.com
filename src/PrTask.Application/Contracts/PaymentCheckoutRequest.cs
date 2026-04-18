namespace PrTask.Application.Contracts;
public record PaymentCheckoutRequest(string TaskId, string PayerId, long AmountCents);
