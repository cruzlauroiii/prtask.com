namespace PrTask.Domain.Models;
public record VoidEntity
{
    public required string Id { get; init; }
    public required string PaymentId { get; init; }
    public string Status { get; set; } = "PENDING";
    public string? Reason { get; set; }
    public long? AmountCents { get; set; }
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
    public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;
}
