using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record InvoiceDto(
    string Id, string UserId, string? MayaInvoiceId, string? InvoiceUrl,
    long AmountCents, string Currency, string? Description,
    string Status, DateTimeOffset CreatedAt, DateTimeOffset? PaidAt)
{
    public static InvoiceDto FromEntity(InvoiceEntity E) =>
        new(E.Id, E.UserId, E.MayaInvoiceId, E.InvoiceUrl,
            E.AmountCents, E.Currency, E.Description,
            E.Status, E.CreatedAt, E.PaidAt);
}
