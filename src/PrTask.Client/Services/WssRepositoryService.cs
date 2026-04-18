using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class WssRepositoryService(ILocalStoreService Store) : IRepositoryService
{
    public async Task<RepositoryEntity?> GetByIdAsync(string RepositoryId) =>
        await Store.GetRecordAsync<RepositoryEntity>(OpfsConstants.CollectionRepositories, RepositoryId);

    public async Task<IReadOnlyList<RepositoryEntity>> ListByOwnerAsync(string OwnerId) =>
        (await Store.GetRecordsAsync<RepositoryEntity>(OpfsConstants.CollectionRepositories))
            .Where(R => R.OwnerId == OwnerId).ToArray();

    public async Task<RepositoryEntity> CreateAsync(RepositoryEntity Entity)
    {
        await Store.SaveRecordAsync(OpfsConstants.CollectionRepositories, Entity);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeCreateRepository, Entity });
        return Entity;
    }

    public async Task<RepositoryEntity> UpdateAsync(RepositoryEntity Entity)
    {
        Entity.UpdatedAt = DateTime.UtcNow;
        await Store.SaveRecordAsync(OpfsConstants.CollectionRepositories, Entity);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeUpdateRepository, Entity });
        return Entity;
    }

    public async Task DeleteAsync(string RepositoryId)
    {
        await Store.DeleteRecordAsync(OpfsConstants.CollectionRepositories, RepositoryId);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeDeleteRepository, RepositoryId });
    }
}
