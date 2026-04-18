using PrTask.Domain.Models;

namespace PrTask.Application.Contracts;

public record DisbursementDto(
    string Id, DisbursementStatus Status, int BeneficiaryCount,
    long TotalAmountCents, DateTimeOffset CreatedAt,
    DateTimeOffset? ProcessedAt, DateTimeOffset? CompletedAt)
{
    public static DisbursementDto FromEntity(DisbursementEntity E) =>
        new(E.Id, E.Status, E.BeneficiaryCount,
            E.TotalAmountCents, E.CreatedAt,
            E.ProcessedAt, E.CompletedAt);
}
