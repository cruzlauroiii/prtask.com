using Microsoft.EntityFrameworkCore;
using PrTask.Application.Services;
using PrTask.Domain.Models;
using PrTask.Infrastructure.Data;
namespace PrTask.Infrastructure.Services;
public class SprintService(AppDbContext Db) : ISprintService
{
    public async Task<SprintEntity?> GetByIdAsync(string SprintId) =>
        await Db.Sprints.FindAsync(SprintId);
    public async Task<IReadOnlyList<SprintEntity>> ListByOwnerAsync(string OwnerId) =>
        await Db.Sprints
            .Where(S => S.OwnerId == OwnerId)
            .OrderByDescending(S => S.CreatedAt)
            .ToListAsync();
    public async Task<IReadOnlyList<SprintEntity>> ListActiveAsync() =>
        await Db.Sprints
            .Where(S => S.Status == SprintStatus.Active)
            .OrderBy(S => S.EndDate)
            .ToListAsync();
    public async Task<SprintEntity> CreateAsync(SprintEntity Entity)
    {
        Db.Sprints.Add(Entity);
        await Db.SaveChangesAsync();
        return Entity;
    }
    public async Task<SprintEntity> UpdateAsync(SprintEntity Entity)
    {
        Entity.UpdatedAt = DateTime.UtcNow;
        Db.Sprints.Update(Entity);
        await Db.SaveChangesAsync();
        return Entity;
    }
    public async Task DeleteAsync(string SprintId)
    {
        var Entity = await Db.Sprints.FindAsync(SprintId);
        if (Entity is not null)
        {
            Db.Sprints.Remove(Entity);
            await Db.SaveChangesAsync();
        }
    }
}
