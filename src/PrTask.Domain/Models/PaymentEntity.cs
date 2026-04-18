namespace PrTask.Domain.Models;
public class PaymentEntity
{
    public required string Id { get; init; }
    public string? MayaCheckoutId { get; set; }
    public string? MayaPaymentId { get; set; }
    public required string PayerId { get; init; }
    public string? PayeeId { get; set; }
    public string? TaskId { get; set; }
    public string? PullRequestId { get; set; }
    public long AmountCents { get; set; }
    public long PlatformFeeCents { get; set; }
    public PaymentType Type { get; set; }
    public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
    public string? MayaStatus { get; set; }
    public string? WebhookData { get; set; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
