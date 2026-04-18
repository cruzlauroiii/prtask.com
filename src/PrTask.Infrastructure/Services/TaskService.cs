using System.Collections.Concurrent;
using PrTask.Application.Services;
using PrTask.Domain.Models;
namespace PrTask.Infrastructure.Services;
public class TaskService : ITaskService
{
    private static readonly ConcurrentDictionary<string, TaskEntity> Store = new(StringComparer.Ordinal);
    public Task<bool> ExistsAsync(string TaskId) => Task.FromResult(Store.ContainsKey(TaskId));
    public Task<TaskEntity?> GetByIdAsync(string TaskId) =>
        Task.FromResult(Store.GetValueOrDefault(TaskId));
    public Task<IReadOnlyList<TaskEntity>> ListOpenAsync() =>
        Task.FromResult<IReadOnlyList<TaskEntity>>(Store.Values
            .Where(T => T.Status == PrTaskStatus.Open)
            .OrderByDescending(T => T.CreatedAt)
            .ToList());
    public Task<TaskEntity> CreateAsync(TaskEntity Entity)
    {
        Store[Entity.Id] = Entity;
        return Task.FromResult(Entity);
    }
    public Task ClaimAsync(string TaskId, string DeveloperId)
    {
        if (Store.TryGetValue(TaskId, out var Existing))
        {
            Existing.Status = PrTaskStatus.Claimed;
            Existing.UpdatedAt = DateTime.UtcNow;
        }
        return Task.CompletedTask;
    }
    public Task<TaskEntity> UpdateAsync(TaskEntity Entity)
    {
        Entity.UpdatedAt = DateTime.UtcNow;
        Store[Entity.Id] = Entity;
        return Task.FromResult(Entity);
    }
    public Task DeleteAsync(string TaskId)
    {
        Store.TryRemove(TaskId, out _);
        return Task.CompletedTask;
    }
}
