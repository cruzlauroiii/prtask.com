using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record UpdatePaymentRecordRequest(
    string? MayaCheckoutId, string? MayaPaymentId,
    string? PayeeId, long AmountCents,
    long PlatformFeeCents, PaymentStatus Status,
    string? MayaStatus);
