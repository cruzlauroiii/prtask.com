namespace PrTask.Domain.Models;
public class SubscriptionEntity
{
    public required string Id { get; init; }
    public required string CustomerId { get; init; }
    public required string CardTokenId { get; init; }
    public string? MayaSubscriptionId { get; set; }
    public required string Description { get; set; }
    public long AmountCents { get; set; }
    public string Currency { get; set; } = "PHP";
    public SubscriptionInterval Interval { get; set; } = SubscriptionInterval.Month;
    public int IntervalCount { get; set; } = 1;
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset? EndDate { get; set; }
    public SubscriptionStatus Status { get; set; } = SubscriptionStatus.Active;
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
    public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;
}
