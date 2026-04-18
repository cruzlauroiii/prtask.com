namespace PrTask.Application.Contracts;
public record P3RefundRequest(string TransactionRefNo, decimal Amount, string? Reason, string? IdempotencyKey);
