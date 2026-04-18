using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record CreatePaymentRecordRequest(
    string PayerId, string? PayeeId, string? TaskId,
    string? PullRequestId, long AmountCents,
    long PlatformFeeCents, PaymentType Type);
