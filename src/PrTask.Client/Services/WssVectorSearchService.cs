using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Client.Services;
public class WssVectorSearchService(ILocalStoreService Store) : IVectorSearchService
{
    public async Task IndexAsync(string Id, float[] Embedding) =>
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeIndexVector, Id, Embedding });

    public Task<IReadOnlyList<string>> SearchAsync(float[] Query, int TopK) =>
        Task.FromResult<IReadOnlyList<string>>([]);

    public async Task DeleteAsync(string Id) =>
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeDeleteVector, Id });

    public Task<long> CountAsync() =>
        Task.FromResult(0L);
}
