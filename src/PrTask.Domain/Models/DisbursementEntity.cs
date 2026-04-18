namespace PrTask.Domain.Models;
public class DisbursementEntity
{
    public required string Id { get; init; }
    public DisbursementStatus Status { get; set; } = DisbursementStatus.Created;
    public int BeneficiaryCount { get; set; }
    public long TotalAmountCents { get; set; }
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? ProcessedAt { get; set; }
    public DateTimeOffset? CompletedAt { get; set; }
}
