namespace PrTask.Domain.Models;
public class P3RecurringPaymentEntity
{
    public required string Id { get; init; }
    public required string OriginalTransactionRefNo { get; init; }
    public required string FrequencyIndicator { get; init; }
    public string RecurringStatus { get; set; } = "ACTIVE";
    public long AmountCents { get; set; }
    public required string Currency { get; init; }
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? LastChargedAt { get; set; }
}
