using PrTask.Domain.Models;

namespace PrTask.Application.Contracts;

public record BillPaymentDto(
    string Id, string BillerSlug, string AccountNumber,
    long AmountCents, string? ReceiptNumber, string Status,
    DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt, DateTimeOffset? CompletedAt)
{
    public static BillPaymentDto FromEntity(BillPaymentEntity E) =>
        new(E.Id, E.BillerSlug, E.AccountNumber,
            E.AmountCents, E.ReceiptNumber, E.Status,
            E.CreatedAt, E.UpdatedAt, E.CompletedAt);
}
