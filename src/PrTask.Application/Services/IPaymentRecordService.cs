using PrTask.Domain.Models;
namespace PrTask.Application.Services;
public interface IPaymentRecordService
{
    Task<PaymentEntity?> GetByIdAsync(string PaymentId);
    Task<PaymentEntity?> GetByMayaPaymentIdAsync(string MayaPaymentId);
    Task<IReadOnlyList<PaymentEntity>> ListByPayerAsync(string PayerId);
    Task<IReadOnlyList<PaymentEntity>> ListByTaskAsync(string TaskId);
    Task<PaymentEntity> CreateAsync(PaymentEntity Entity);
    Task<PaymentEntity> UpdateAsync(PaymentEntity Entity);
    Task UpdateStatusFromWebhookAsync(string MayaPaymentId, string MayaStatus, string WebhookData);
    Task DeleteAsync(string PaymentId);
}
