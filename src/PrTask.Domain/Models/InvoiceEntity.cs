namespace PrTask.Domain.Models;
public class InvoiceEntity
{
    public required string Id { get; init; }
    public required string UserId { get; init; }
    public string? MayaInvoiceId { get; set; }
    public string? InvoiceUrl { get; set; }
    public long AmountCents { get; set; }
    public string Currency { get; set; } = "PHP";
    public string? Description { get; set; }
    public string Status { get; set; } = "PENDING";
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? PaidAt { get; set; }
}
