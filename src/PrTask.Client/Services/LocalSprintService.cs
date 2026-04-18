using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class LocalSprintService(ILocalStoreService Store) : ISprintService
{
    public async Task<SprintEntity?> GetByIdAsync(string SprintId) =>
        await Store.GetRecordAsync<SprintEntity>(OpfsConstants.CollectionSprints, SprintId);

    public async Task<IReadOnlyList<SprintEntity>> ListByOwnerAsync(string OwnerId)
    {
        var All = await Store.GetRecordsAsync<SprintEntity>(OpfsConstants.CollectionSprints);
        return All.Where(S => S.OwnerId == OwnerId).ToList();
    }

    public async Task<IReadOnlyList<SprintEntity>> ListActiveAsync()
    {
        var All = await Store.GetRecordsAsync<SprintEntity>(OpfsConstants.CollectionSprints);
        return All.Where(S => S.Status == SprintStatus.Active).ToList();
    }

    public async Task<SprintEntity> CreateAsync(SprintEntity Entity)
    {
        await Store.SaveRecordAsync(OpfsConstants.CollectionSprints, Entity);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeCreateSprint, Entity });
        return Entity;
    }

    public async Task<SprintEntity> UpdateAsync(SprintEntity Entity)
    {
        Entity.UpdatedAt = DateTime.UtcNow;
        await Store.SaveRecordAsync(OpfsConstants.CollectionSprints, Entity);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeUpdateSprint, Entity });
        return Entity;
    }

    public async Task DeleteAsync(string SprintId)
    {
        await Store.DeleteRecordAsync(OpfsConstants.CollectionSprints, SprintId);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeDeleteSprint, SprintId });
    }
}
