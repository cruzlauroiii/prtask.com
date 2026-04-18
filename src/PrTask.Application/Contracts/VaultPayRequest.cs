namespace PrTask.Application.Contracts;
public record VaultPayRequest(string CustomerId, string CardToken, string TaskId, long AmountCents);
