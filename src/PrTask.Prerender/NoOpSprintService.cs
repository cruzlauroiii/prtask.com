using PrTask.Application.Services;
using PrTask.Domain.Models;
namespace PrTask.Prerender;
public sealed class NoOpSprintService : ISprintService
{
    public Task<SprintEntity?> GetByIdAsync(string SprintId) => Task.FromResult<SprintEntity?>(null);
    public Task<IReadOnlyList<SprintEntity>> ListByOwnerAsync(string OwnerId) => Task.FromResult<IReadOnlyList<SprintEntity>>([]);
    public Task<IReadOnlyList<SprintEntity>> ListActiveAsync() => Task.FromResult<IReadOnlyList<SprintEntity>>([]);
    public Task<SprintEntity> CreateAsync(SprintEntity Entity) => Task.FromResult(Entity);
    public Task<SprintEntity> UpdateAsync(SprintEntity Entity) => Task.FromResult(Entity);
    public Task DeleteAsync(string SprintId) => Task.CompletedTask;
}
