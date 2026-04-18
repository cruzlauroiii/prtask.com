using PrTask.Application.Services;
using PrTask.Domain.Models;
namespace PrTask.Prerender;
public sealed class NoOpTaskService : ITaskService
{
    public Task<bool> ExistsAsync(string TaskId) => Task.FromResult(false);
    public Task<TaskEntity?> GetByIdAsync(string TaskId) => Task.FromResult<TaskEntity?>(null);
    public Task<IReadOnlyList<TaskEntity>> ListOpenAsync() => Task.FromResult<IReadOnlyList<TaskEntity>>([]);
    public Task<TaskEntity> CreateAsync(TaskEntity Entity) => Task.FromResult(Entity);
    public Task ClaimAsync(string TaskId, string DeveloperId) => Task.CompletedTask;
    public Task<TaskEntity> UpdateAsync(TaskEntity Entity) => Task.FromResult(Entity);
    public Task DeleteAsync(string TaskId) => Task.CompletedTask;
}
