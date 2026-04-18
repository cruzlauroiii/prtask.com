using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record PaymentDto(
    string Id, string? MayaCheckoutId, string? MayaPaymentId,
    string PayerId, string? PayeeId, string? TaskId, string? PullRequestId,
    long AmountCents, long PlatformFeeCents, PaymentType Type,
    PaymentStatus Status, string? MayaStatus, DateTime CreatedAt, DateTime UpdatedAt)
{
    public static PaymentDto FromEntity(PaymentEntity E) =>
        new(E.Id, E.MayaCheckoutId, E.MayaPaymentId, E.PayerId, E.PayeeId,
            E.TaskId, E.PullRequestId, E.AmountCents, E.PlatformFeeCents,
            E.Type, E.Status, E.MayaStatus, E.CreatedAt, E.UpdatedAt);
}
