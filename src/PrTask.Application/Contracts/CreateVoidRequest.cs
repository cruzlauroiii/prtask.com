namespace PrTask.Application.Contracts;
public record CreateVoidRequest(string PaymentId, string? Reason, long? AmountCents);
