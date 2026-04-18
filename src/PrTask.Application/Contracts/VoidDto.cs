using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record VoidDto(
    string Id, string PaymentId, string Status, string? Reason,
    long? AmountCents, DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt)
{
    public static VoidDto FromEntity(VoidEntity E) =>
        new(E.Id, E.PaymentId, E.Status, E.Reason,
            E.AmountCents, E.CreatedAt, E.UpdatedAt);
}
