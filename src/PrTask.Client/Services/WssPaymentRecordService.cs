using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class WssPaymentRecordService(ILocalStoreService Store) : IPaymentRecordService
{
    public async Task<PaymentEntity?> GetByIdAsync(string PaymentId) =>
        await Store.GetRecordAsync<PaymentEntity>(OpfsConstants.CollectionPayments, PaymentId);

    public async Task<PaymentEntity?> GetByMayaPaymentIdAsync(string MayaPaymentId) =>
        (await Store.GetRecordsAsync<PaymentEntity>(OpfsConstants.CollectionPayments))
            .FirstOrDefault(P => P.MayaPaymentId == MayaPaymentId);

    public async Task<IReadOnlyList<PaymentEntity>> ListByPayerAsync(string PayerId) =>
        (await Store.GetRecordsAsync<PaymentEntity>(OpfsConstants.CollectionPayments))
            .Where(P => P.PayerId == PayerId).ToArray();

    public async Task<IReadOnlyList<PaymentEntity>> ListByTaskAsync(string TaskId) =>
        (await Store.GetRecordsAsync<PaymentEntity>(OpfsConstants.CollectionPayments))
            .Where(P => P.TaskId == TaskId).ToArray();

    public async Task<PaymentEntity> CreateAsync(PaymentEntity Entity)
    {
        await Store.SaveRecordAsync(OpfsConstants.CollectionPayments, Entity);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeCreatePayment, Entity });
        return Entity;
    }

    public async Task<PaymentEntity> UpdateAsync(PaymentEntity Entity)
    {
        Entity.UpdatedAt = DateTime.UtcNow;
        await Store.SaveRecordAsync(OpfsConstants.CollectionPayments, Entity);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeUpdatePayment, Entity });
        return Entity;
    }

    public async Task UpdateStatusFromWebhookAsync(string MayaPaymentId, string MayaStatus, string WebhookData) =>
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeUpdatePaymentStatus, MayaPaymentId, MayaStatus, WebhookData });

    public async Task DeleteAsync(string PaymentId)
    {
        await Store.DeleteRecordAsync(OpfsConstants.CollectionPayments, PaymentId);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeDeletePayment, PaymentId });
    }
}
