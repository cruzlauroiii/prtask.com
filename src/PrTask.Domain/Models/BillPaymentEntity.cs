namespace PrTask.Domain.Models;
public class BillPaymentEntity
{
    public required string Id { get; init; }
    public required string BillerSlug { get; init; }
    public required string AccountNumber { get; init; }
    public long AmountCents { get; set; }
    public string? ReceiptNumber { get; set; }
    public string Status { get; set; } = "PENDING";
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
    public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? CompletedAt { get; set; }
}
