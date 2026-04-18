using PrTask.Application.Services;
using PrTask.Domain.Models;
namespace PrTask.Prerender;
public sealed class NoOpPaymentRecordService : IPaymentRecordService
{
    public Task<PaymentEntity?> GetByIdAsync(string PaymentId) => Task.FromResult<PaymentEntity?>(null);
    public Task<PaymentEntity?> GetByMayaPaymentIdAsync(string MayaPaymentId) => Task.FromResult<PaymentEntity?>(null);
    public Task<IReadOnlyList<PaymentEntity>> ListByPayerAsync(string PayerId) => Task.FromResult<IReadOnlyList<PaymentEntity>>([]);
    public Task<IReadOnlyList<PaymentEntity>> ListByTaskAsync(string TaskId) => Task.FromResult<IReadOnlyList<PaymentEntity>>([]);
    public Task<PaymentEntity> CreateAsync(PaymentEntity Entity) => Task.FromResult(Entity);
    public Task<PaymentEntity> UpdateAsync(PaymentEntity Entity) => Task.FromResult(Entity);
    public Task UpdateStatusFromWebhookAsync(string MayaPaymentId, string MayaStatus, string WebhookData) => Task.CompletedTask;
    public Task DeleteAsync(string PaymentId) => Task.CompletedTask;
}
