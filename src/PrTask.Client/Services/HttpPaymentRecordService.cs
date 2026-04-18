using System.Net.Http.Json;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class HttpPaymentRecordService(HttpClient Http) : IPaymentRecordService
{
    public async Task<PaymentEntity?> GetByIdAsync(string PaymentId)
    {
        try { return await Http.GetFromJsonAsync<PaymentEntity>(string.Format(RouteConstants.ApiPaymentRecordById, PaymentId)); }
        catch { return null; }
    }
    public async Task<PaymentEntity?> GetByMayaPaymentIdAsync(string MayaPaymentId)
    {
        try { return await Http.GetFromJsonAsync<PaymentEntity>(string.Format(RouteConstants.ApiPaymentRecordByMaya, MayaPaymentId)); }
        catch { return null; }
    }
    public async Task<IReadOnlyList<PaymentEntity>> ListByPayerAsync(string PayerId)
    {
        try { return await Http.GetFromJsonAsync<PaymentEntity[]>(string.Format(RouteConstants.ApiPaymentRecordsByPayer, PayerId)) ?? []; }
        catch { return []; }
    }
    public async Task<IReadOnlyList<PaymentEntity>> ListByTaskAsync(string TaskId)
    {
        try { return await Http.GetFromJsonAsync<PaymentEntity[]>(string.Format(RouteConstants.ApiPaymentRecordsByTask, TaskId)) ?? []; }
        catch { return []; }
    }
    public async Task<PaymentEntity> CreateAsync(PaymentEntity Entity)
    {
        var Resp = await Http.PostAsJsonAsync(RouteConstants.ApiPaymentRecords, Entity);
        return await Resp.Content.ReadFromJsonAsync<PaymentEntity>() ?? Entity;
    }
    public async Task<PaymentEntity> UpdateAsync(PaymentEntity Entity)
    {
        await Http.PutAsJsonAsync(string.Format(RouteConstants.ApiPaymentRecordById, Entity.Id), Entity);
        return Entity;
    }
    public async Task UpdateStatusFromWebhookAsync(string MayaPaymentId, string MayaStatus, string WebhookData) =>
        await Http.PostAsJsonAsync(
            string.Format(RouteConstants.ApiPaymentRecordMayaStatus, MayaPaymentId),
            new { MayaStatus, WebhookData });
    public async Task DeleteAsync(string PaymentId) =>
        await Http.DeleteAsync(string.Format(RouteConstants.ApiPaymentRecordById, PaymentId));
}
