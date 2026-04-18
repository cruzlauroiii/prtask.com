namespace PrTask.Domain.Models;
public record RefundEntity
{
    public required string Id { get; init; }
    public required string PaymentId { get; init; }
    public string Status { get; set; } = "PENDING";
    public string? Reason { get; set; }
    public long AmountCents { get; set; }
    public string Currency { get; set; } = "PHP";
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
    public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;
}
