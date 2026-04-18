using PrTask.Domain.Models;
namespace PrTask.Application.Services;
public interface ITaskService
{
    Task<bool> ExistsAsync(string TaskId);
    Task<TaskEntity?> GetByIdAsync(string TaskId);
    Task<IReadOnlyList<TaskEntity>> ListOpenAsync();
    Task<TaskEntity> CreateAsync(TaskEntity Entity);
    Task ClaimAsync(string TaskId, string DeveloperId);
    Task<TaskEntity> UpdateAsync(TaskEntity Entity);
    Task DeleteAsync(string TaskId);
}
