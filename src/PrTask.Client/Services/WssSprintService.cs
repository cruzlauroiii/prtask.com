using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class WssSprintService(ILocalStoreService Store) : ISprintService
{
    public async Task<SprintEntity?> GetByIdAsync(string SprintId) =>
        await Store.GetRecordAsync<SprintEntity>(OpfsConstants.CollectionSprints, SprintId);

    public async Task<IReadOnlyList<SprintEntity>> ListByOwnerAsync(string OwnerId) =>
        (await Store.GetRecordsAsync<SprintEntity>(OpfsConstants.CollectionSprints))
            .Where(S => S.OwnerId == OwnerId).ToArray();

    public async Task<IReadOnlyList<SprintEntity>> ListActiveAsync() =>
        (await Store.GetRecordsAsync<SprintEntity>(OpfsConstants.CollectionSprints))
            .Where(S => S.Status == SprintStatus.Active).ToArray();

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
