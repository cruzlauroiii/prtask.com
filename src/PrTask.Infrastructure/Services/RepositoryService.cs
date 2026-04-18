using Microsoft.EntityFrameworkCore;
using PrTask.Application.Services;
using PrTask.Domain.Models;
using PrTask.Infrastructure.Data;
namespace PrTask.Infrastructure.Services;
public class RepositoryService(AppDbContext Db) : IRepositoryService
{
    public async Task<RepositoryEntity?> GetByIdAsync(string RepositoryId) =>
        await Db.Repositories.FindAsync(RepositoryId);
    public async Task<IReadOnlyList<RepositoryEntity>> ListByOwnerAsync(string OwnerId) =>
        await Db.Repositories
            .Where(R => R.OwnerId == OwnerId)
            .OrderByDescending(R => R.CreatedAt)
            .ToListAsync();
    public async Task<RepositoryEntity> CreateAsync(RepositoryEntity Entity)
    {
        Db.Repositories.Add(Entity);
        await Db.SaveChangesAsync();
        return Entity;
    }
    public async Task<RepositoryEntity> UpdateAsync(RepositoryEntity Entity)
    {
        Entity.UpdatedAt = DateTime.UtcNow;
        Db.Repositories.Update(Entity);
        await Db.SaveChangesAsync();
        return Entity;
    }
    public async Task DeleteAsync(string RepositoryId)
    {
        var Entity = await Db.Repositories.FindAsync(RepositoryId);
        if (Entity is not null)
        {
            Db.Repositories.Remove(Entity);
            await Db.SaveChangesAsync();
        }
    }
}
