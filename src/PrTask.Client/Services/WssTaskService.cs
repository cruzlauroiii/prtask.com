using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class WssTaskService(ILocalStoreService Store) : ITaskService
{
    public async Task<bool> ExistsAsync(string TaskId) =>
        await Store.GetRecordAsync<TaskEntity>(OpfsConstants.CollectionTasks, TaskId) is not null;

    public async Task<TaskEntity?> GetByIdAsync(string TaskId) =>
        await Store.GetRecordAsync<TaskEntity>(OpfsConstants.CollectionTasks, TaskId);

    public async Task<IReadOnlyList<TaskEntity>> ListOpenAsync() =>
        (await Store.GetRecordsAsync<TaskEntity>(OpfsConstants.CollectionTasks))
            .Where(T => T.Status == PrTaskStatus.Open).ToArray();

    public async Task<IReadOnlyList<TaskEntity>> ListByClientAsync(string ClientId) =>
        (await Store.GetRecordsAsync<TaskEntity>(OpfsConstants.CollectionTasks))
            .Where(T => T.ClientId == ClientId).ToArray();

    public async Task<TaskEntity> CreateAsync(TaskEntity Entity)
    {
        await Store.SaveRecordAsync(OpfsConstants.CollectionTasks, Entity);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeCreateTask, Entity });
        return Entity;
    }

    public async Task ClaimAsync(string TaskId, string DeveloperId) =>
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeClaimTask, TaskId, DeveloperId });

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
