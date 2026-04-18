using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class LocalInvoiceService(ILocalStoreService Store) : IInvoiceService
{
    public async Task<InvoiceEntity> CreateInvoiceAsync(
        decimal Amount, string Currency, string Description, string? UserId)
    {
        var Entity = new InvoiceEntity
        {
            Id = Guid.NewGuid().ToString(),
            UserId = UserId ?? string.Empty,
            AmountCents = (long)(Amount * 100),
            Currency = Currency,
            Description = Description
        };
        await Store.SaveRecordAsync(OpfsConstants.CollectionInvoices, Entity);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeCreateInvoice, Entity });
        return Entity;
    }

    public async Task<InvoiceEntity?> GetInvoiceAsync(string InvoiceId) =>
        await Store.GetRecordAsync<InvoiceEntity>(OpfsConstants.CollectionInvoices, InvoiceId);

    public async Task<IReadOnlyList<InvoiceEntity>> ListInvoicesAsync(string? UserId)
    {
        var All = await Store.GetRecordsAsync<InvoiceEntity>(OpfsConstants.CollectionInvoices);
        return !string.IsNullOrEmpty(UserId)
            ? [.. All.Where(I => I.UserId == UserId)]
            : [.. All];
    }

    public async Task<bool> DeleteInvoiceAsync(string InvoiceId)
    {
        await Store.DeleteRecordAsync(OpfsConstants.CollectionInvoices, InvoiceId);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeDeleteInvoice, InvoiceId });
        return true;
    }
}
