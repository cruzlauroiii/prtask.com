using System.Net.Http.Json;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class HttpInvoiceService(HttpClient Http) : IInvoiceService
{
    public async Task<InvoiceEntity> CreateInvoiceAsync(
        decimal Amount, string Currency, string Description, string? UserId)
    {
        var Resp = await Http.PostAsJsonAsync(RouteConstants.ApiInvoices,
            new { Amount, Currency, Description, UserId });
        return await Resp.Content.ReadFromJsonAsync<InvoiceEntity>()
            ?? new InvoiceEntity { Id = string.Empty, UserId = UserId ?? string.Empty };
    }
    public async Task<InvoiceEntity?> GetInvoiceAsync(string InvoiceId)
    {
        try
        {
            return await Http.GetFromJsonAsync<InvoiceEntity>(
                FormatStrings.ApiResourcePath(RouteConstants.ApiInvoices, InvoiceId));
        }
        catch { return null; }
    }
    public async Task<IReadOnlyList<InvoiceEntity>> ListInvoicesAsync(string? UserId)
    {
        try { return await Http.GetFromJsonAsync<InvoiceEntity[]>(RouteConstants.ApiInvoices) ?? []; }
        catch { return []; }
    }
    public async Task<bool> DeleteInvoiceAsync(string InvoiceId)
    {
        var Resp = await Http.DeleteAsync(
            FormatStrings.ApiResourcePath(RouteConstants.ApiInvoices, InvoiceId));
        return Resp.IsSuccessStatusCode;
    }
}
