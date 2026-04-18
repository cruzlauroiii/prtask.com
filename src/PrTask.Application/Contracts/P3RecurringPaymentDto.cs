using PrTask.Domain.Models;

namespace PrTask.Application.Contracts;

public record P3RecurringPaymentDto(
    string Id, string OriginalTransactionRefNo, string FrequencyIndicator,
    string RecurringStatus, long AmountCents, string Currency,
    DateTimeOffset CreatedAt, DateTimeOffset? LastChargedAt)
{
    public static P3RecurringPaymentDto FromEntity(P3RecurringPaymentEntity E) =>
        new(E.Id, E.OriginalTransactionRefNo, E.FrequencyIndicator,
            E.RecurringStatus, E.AmountCents, E.Currency,
            E.CreatedAt, E.LastChargedAt);
}
