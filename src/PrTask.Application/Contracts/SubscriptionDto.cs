using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record SubscriptionDto(
    string Id, string CustomerId, string CardTokenId, string? MayaSubscriptionId,
    string Description, long AmountCents, string Currency,
    SubscriptionInterval Interval, int IntervalCount,
    DateTimeOffset StartDate, DateTimeOffset? EndDate,
    SubscriptionStatus Status, DateTimeOffset CreatedAt, DateTimeOffset UpdatedAt)
{
    public static SubscriptionDto FromEntity(SubscriptionEntity E) =>
        new(E.Id, E.CustomerId, E.CardTokenId, E.MayaSubscriptionId,
            E.Description, E.AmountCents, E.Currency,
            E.Interval, E.IntervalCount,
            E.StartDate, E.EndDate,
            E.Status, E.CreatedAt, E.UpdatedAt);
}
