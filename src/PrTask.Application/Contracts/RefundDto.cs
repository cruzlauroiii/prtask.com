using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record RefundDto(
    string Id, string PaymentId, string Status, string? Reason,
    long AmountCents, string Currency, DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt)
{
    public static RefundDto FromEntity(RefundEntity E) =>
        new(E.Id, E.PaymentId, E.Status, E.Reason,
            E.AmountCents, E.Currency, E.CreatedAt, E.UpdatedAt);
}
