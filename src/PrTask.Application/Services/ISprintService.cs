using PrTask.Domain.Models;
namespace PrTask.Application.Services;
public interface ISprintService
{
    Task<SprintEntity?> GetByIdAsync(string SprintId);
    Task<IReadOnlyList<SprintEntity>> ListByOwnerAsync(string OwnerId);
    Task<IReadOnlyList<SprintEntity>> ListActiveAsync();
    Task<SprintEntity> CreateAsync(SprintEntity Entity);
    Task<SprintEntity> UpdateAsync(SprintEntity Entity);
    Task DeleteAsync(string SprintId);
}
