using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class LocalTaskService(ILocalStoreService Store) : ITaskService
{
    public async Task<bool> ExistsAsync(string TaskId) =>
        await Store.GetRecordAsync<TaskEntity>(OpfsConstants.CollectionTasks, TaskId) is not null;

    public async Task<TaskEntity?> GetByIdAsync(string TaskId) =>
        await Store.GetRecordAsync<TaskEntity>(OpfsConstants.CollectionTasks, TaskId);

    public async Task<IReadOnlyList<TaskEntity>> ListOpenAsync()
    {
        var All = await Store.GetRecordsAsync<TaskEntity>(OpfsConstants.CollectionTasks);
        return All.Where(T => T.Status == PrTaskStatus.Open).ToList();
    }

    public async Task<IReadOnlyList<TaskEntity>> ListByClientAsync(string ClientId)
    {
        var All = await Store.GetRecordsAsync<TaskEntity>(OpfsConstants.CollectionTasks);
        return All.Where(T => T.ClientId == ClientId).ToList();
    }

    public async Task<TaskEntity> CreateAsync(TaskEntity Entity)
    {
        await Store.SaveRecordAsync(OpfsConstants.CollectionTasks, Entity);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeCreateTask, Entity });
        return Entity;
    }

    public async Task ClaimAsync(string TaskId, string DeveloperId)
    {
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeClaimTask, TaskId, DeveloperId });
    }

    public async Task<TaskEntity> UpdateAsync(TaskEntity Entity)
    {
        Entity.UpdatedAt = DateTime.UtcNow;
        await Store.SaveRecordAsync(OpfsConstants.CollectionTasks, Entity);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeUpdateTask, Entity });
        return Entity;
    }

    public async Task DeleteAsync(string TaskId)
    {
        await Store.DeleteRecordAsync(OpfsConstants.CollectionTasks, TaskId);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeDeleteTask, TaskId });
    }
}
