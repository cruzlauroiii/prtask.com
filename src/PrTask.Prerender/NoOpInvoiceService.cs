using PrTask.Application.Services;
using PrTask.Domain.Models;
namespace PrTask.Prerender;
public sealed class NoOpInvoiceService : IInvoiceService
{
    public Task<InvoiceEntity> CreateInvoiceAsync(decimal Amount, string Currency, string Description, string? UserId) =>
        Task.FromResult(new InvoiceEntity { Id = string.Empty, UserId = UserId ?? string.Empty });
    public Task<InvoiceEntity?> GetInvoiceAsync(string InvoiceId) => Task.FromResult<InvoiceEntity?>(null);
    public Task<IReadOnlyList<InvoiceEntity>> ListInvoicesAsync(string? UserId) => Task.FromResult<IReadOnlyList<InvoiceEntity>>([]);
    public Task<bool> DeleteInvoiceAsync(string InvoiceId) => Task.FromResult(false);
}
