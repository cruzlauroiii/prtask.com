using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Client.Services;
public class LocalSourceCodeService(ILocalStoreService Store) : ISourceCodeService
{
    private static string FilesKey(string TaskId) => string.Format(OpfsConstants.SourceCodeFilesKeyFormat, TaskId);
    private static string ModifiedKey(string TaskId, string PrId) => string.Format(OpfsConstants.SourceCodeModifiedKeyFormat, TaskId, PrId);

    public async Task StoreFilesAsync(string TaskId, IDictionary<string, string> Files)
    {
        await Store.SaveRecordAsync(OpfsConstants.CollectionSourceCode, new SourceCodeRecord { Id = FilesKey(TaskId), Files = Files });
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeStoreSourceCode, TaskId, Files });
    }

#pragma warning disable IDE0028
    public async Task<IDictionary<string, string>> GetFilesAsync(string TaskId)
    {
        var Record = await Store.GetRecordAsync<SourceCodeRecord>(OpfsConstants.CollectionSourceCode, FilesKey(TaskId));
        return Record?.Files ?? new Dictionary<string, string>();
    }

    public async Task<IDictionary<string, string>> GetModifiedFilesAsync(string TaskId, string PrId)
    {
        var Record = await Store.GetRecordAsync<SourceCodeRecord>(OpfsConstants.CollectionSourceCode, ModifiedKey(TaskId, PrId));
        return Record?.Files ?? new Dictionary<string, string>();
    }
#pragma warning restore IDE0028

    public async Task StoreModifiedFilesAsync(string TaskId, string PrId, IDictionary<string, string> Files)
    {
        await Store.SaveRecordAsync(OpfsConstants.CollectionSourceCode, new SourceCodeRecord { Id = ModifiedKey(TaskId, PrId), Files = Files });
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeStoreModifiedFiles, TaskId, PrId, Files });
    }

    public Task<string> GenerateDiffAsync(string TaskId, string PrId) =>
        Task.FromResult(string.Empty);

    public async Task DeleteFilesAsync(string TaskId)
    {
        await Store.DeleteRecordAsync(OpfsConstants.CollectionSourceCode, FilesKey(TaskId));
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeDeleteSourceCode, TaskId });
    }
}
