using Microsoft.EntityFrameworkCore;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
using PrTask.Infrastructure.Data;
namespace PrTask.Infrastructure.Services;
public class PaymentRecordService(AppDbContext Db) : IPaymentRecordService
{
    public async Task<PaymentEntity?> GetByIdAsync(string PaymentId) =>
        await Db.Payments.FindAsync(PaymentId);
    public Task<PaymentEntity?> GetByMayaPaymentIdAsync(string MayaPaymentId) =>
        Db.Payments.FirstOrDefaultAsync(P => P.MayaPaymentId == MayaPaymentId);
    public async Task<IReadOnlyList<PaymentEntity>> ListByPayerAsync(string PayerId) =>
        await Db.Payments
            .Where(P => P.PayerId == PayerId)
            .OrderByDescending(P => P.CreatedAt)
            .ToListAsync();
    public async Task<IReadOnlyList<PaymentEntity>> ListByTaskAsync(string TaskId) =>
        await Db.Payments
            .Where(P => P.TaskId == TaskId)
            .OrderByDescending(P => P.CreatedAt)
            .ToListAsync();
    public async Task<PaymentEntity> CreateAsync(PaymentEntity Entity)
    {
        Db.Payments.Add(Entity);
        await Db.SaveChangesAsync();
        return Entity;
    }
    public async Task<PaymentEntity> UpdateAsync(PaymentEntity Entity)
    {
        Entity.UpdatedAt = DateTime.UtcNow;
        Db.Payments.Update(Entity);
        await Db.SaveChangesAsync();
        return Entity;
    }
    public async Task UpdateStatusFromWebhookAsync(string MayaPaymentId, string MayaStatus, string WebhookData)
    {
        var Entity = await Db.Payments.FirstOrDefaultAsync(P => P.MayaPaymentId == MayaPaymentId);
        if (Entity is null)
        {
            return;
        }
        Entity.MayaStatus = MayaStatus;
        Entity.WebhookData = WebhookData;
        Entity.Status = MapMayaStatus(MayaStatus);
        Entity.UpdatedAt = DateTime.UtcNow;
        await Db.SaveChangesAsync();
    }
    public async Task DeleteAsync(string PaymentId)
    {
        var Entity = await Db.Payments.FindAsync(PaymentId);
        if (Entity is not null)
        {
            Db.Payments.Remove(Entity);
            await Db.SaveChangesAsync();
        }
    }
    private static PaymentStatus MapMayaStatus(string MayaStatus) =>
        MayaStatus switch
        {
            MayaConstants.StatusPaymentSuccess or MayaConstants.StatusCaptured => PaymentStatus.Completed,
            MayaConstants.StatusPaymentFailed or MayaConstants.StatusAuthFailed => PaymentStatus.Failed,
            MayaConstants.StatusRefunded => PaymentStatus.Refunded,
            MayaConstants.StatusPaymentProcessing or MayaConstants.StatusAuthenticating
                or MayaConstants.StatusForAuthentication => PaymentStatus.Processing,
            _ => PaymentStatus.Pending
        };
}
