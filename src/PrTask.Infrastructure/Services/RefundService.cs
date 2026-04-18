using Microsoft.EntityFrameworkCore;
using PrTask.Application.Services;
using PrTask.Domain.Models;
using PrTask.Infrastructure.Data;
namespace PrTask.Infrastructure.Services;
public class RefundService(AppDbContext Db) : IRefundService
{
    public async Task<RefundEntity?> GetByIdAsync(string RefundId) =>
        await Db.Refunds.FindAsync(RefundId);
    public async Task<IReadOnlyList<RefundEntity>> ListByPaymentIdAsync(string PaymentId) =>
        await Db.Refunds
            .Where(R => R.PaymentId == PaymentId)
            .OrderByDescending(R => R.CreatedAt)
            .ToListAsync();
    public async Task<RefundEntity> CreateRefundAsync(RefundEntity Entity)
    {
        Db.Refunds.Add(Entity);
        await Db.SaveChangesAsync();
        return Entity;
    }
    public async Task<RefundEntity?> UpdateStatusAsync(string RefundId, string Status)
    {
        var Entity = await Db.Refunds.FindAsync(RefundId);
        if (Entity is null)
        {
            return null;
        }
        Entity.Status = Status;
        Entity.UpdatedAt = DateTimeOffset.UtcNow;
        await Db.SaveChangesAsync();
        return Entity;
    }
    public async Task<bool> DeleteAsync(string RefundId)
    {
        var Entity = await Db.Refunds.FindAsync(RefundId);
        if (Entity is null)
        {
            return false;
        }
        Db.Refunds.Remove(Entity);
        await Db.SaveChangesAsync();
        return true;
    }
}
