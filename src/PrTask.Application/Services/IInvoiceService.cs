using PrTask.Domain.Models;
namespace PrTask.Application.Services;
public interface IInvoiceService
{
    Task<InvoiceEntity> CreateInvoiceAsync(decimal Amount, string Currency, string Description, string? UserId);
    Task<InvoiceEntity?> GetInvoiceAsync(string InvoiceId);
    Task<IReadOnlyList<InvoiceEntity>> ListInvoicesAsync(string? UserId);
    Task<bool> DeleteInvoiceAsync(string InvoiceId);
}
