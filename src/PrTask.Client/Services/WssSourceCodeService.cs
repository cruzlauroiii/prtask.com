using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Client.Services;
public class WssSourceCodeService(ILocalStoreService Store) : ISourceCodeService
{
    public async Task StoreFilesAsync(string TaskId, IDictionary<string, string> Files)
    {
        await Store.SaveRecordAsync(OpfsConstants.CollectionSourceCode, new { Id = TaskId, Files });
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeStoreSourceCode, TaskId, Files });
    }

#pragma warning disable IDE0028
    public async Task<IDictionary<string, string>> GetFilesAsync(string TaskId)
    {
        var Content = await Store.ReadFileAsync(string.Format(OpfsConstants.SourceCodeFilePath, OpfsConstants.CollectionSourceCode, TaskId));
        if (Content is null)
        {
            return new Dictionary<string, string>();
        }
        try
        {
            return System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(Content) ?? new Dictionary<string, string>();
        }
        catch { return new Dictionary<string, string>(); }
    }

    public async Task StoreModifiedFilesAsync(string TaskId, string PrId, IDictionary<string, string> Files)
    {
        await Store.SaveRecordAsync(OpfsConstants.CollectionSourceCode, new { Id = string.Format(OpfsConstants.SourceCodeModifiedFilePath, string.Empty, TaskId, PrId).TrimStart('/'), Files });
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeStoreModifiedFiles, TaskId, PrId, Files });
    }

    public async Task<IDictionary<string, string>> GetModifiedFilesAsync(string TaskId, string PrId)
    {
        var Content = await Store.ReadFileAsync(string.Format(OpfsConstants.SourceCodeModifiedFilePath, OpfsConstants.CollectionSourceCode, TaskId, PrId));
        if (Content is null)
        {
            return new Dictionary<string, string>();
        }
        try
        {
            return System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(Content) ?? new Dictionary<string, string>();
        }
        catch { return new Dictionary<string, string>(); }
    }
#pragma warning restore IDE0028

    public Task<string> GenerateDiffAsync(string TaskId, string PrId) =>
        Task.FromResult(string.Empty);

    public async Task DeleteFilesAsync(string TaskId)
    {
        await Store.DeleteRecordAsync(OpfsConstants.CollectionSourceCode, TaskId);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeDeleteSourceCode, TaskId });
    }
}
