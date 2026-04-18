namespace PrTask.Application.Contracts;
public record P3VoidRequest(string TransactionRefNo, string? Reason, string? IdempotencyKey);
