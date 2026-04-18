using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class LocalRepositoryService(ILocalStoreService Store) : IRepositoryService
{
    public async Task<RepositoryEntity?> GetByIdAsync(string RepositoryId) =>
        await Store.GetRecordAsync<RepositoryEntity>(OpfsConstants.CollectionRepositories, RepositoryId);

    public async Task<IReadOnlyList<RepositoryEntity>> ListByOwnerAsync(string OwnerId)
    {
        var All = await Store.GetRecordsAsync<RepositoryEntity>(OpfsConstants.CollectionRepositories);
        return All.Where(R => R.OwnerId == OwnerId).ToList();
    }

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
