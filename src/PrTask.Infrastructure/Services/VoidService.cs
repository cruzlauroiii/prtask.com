using Microsoft.EntityFrameworkCore;
using PrTask.Application.Services;
using PrTask.Domain.Models;
using PrTask.Infrastructure.Data;
namespace PrTask.Infrastructure.Services;
public class VoidService(AppDbContext Db) : IVoidService
{
    public async Task<VoidEntity?> GetByIdAsync(string VoidId) =>
        await Db.Voids.FindAsync(VoidId);
    public async Task<IReadOnlyList<VoidEntity>> ListByPaymentIdAsync(string PaymentId) =>
        await Db.Voids
            .Where(V => V.PaymentId == PaymentId)
            .OrderByDescending(V => V.CreatedAt)
            .ToListAsync();
    public async Task<VoidEntity> CreateVoidAsync(VoidEntity Entity)
    {
        Db.Voids.Add(Entity);
        await Db.SaveChangesAsync();
        return Entity;
    }
    public async Task<VoidEntity?> UpdateStatusAsync(string VoidId, string Status)
    {
        var Entity = await Db.Voids.FindAsync(VoidId);
        if (Entity is null)
        {
            return null;
        }
        Entity.Status = Status;
        Entity.UpdatedAt = DateTimeOffset.UtcNow;
        await Db.SaveChangesAsync();
        return Entity;
    }
    public async Task<bool> DeleteAsync(string VoidId)
    {
        var Entity = await Db.Voids.FindAsync(VoidId);
        if (Entity is null)
        {
            return false;
        }
        Db.Voids.Remove(Entity);
        await Db.SaveChangesAsync();
        return true;
    }
}
