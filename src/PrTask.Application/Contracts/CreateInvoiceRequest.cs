namespace PrTask.Application.Contracts;
public record CreateInvoiceRequest(decimal Amount, string Currency, string Description, string? UserId);
