namespace PrTask.Application.Services;
public interface ISourceCodeService
{
    Task StoreFilesAsync(string TaskId, IDictionary<string, string> Files);
    Task<IDictionary<string, string>> GetFilesAsync(string TaskId);
    Task StoreModifiedFilesAsync(string TaskId, string PrId, IDictionary<string, string> Files);
    Task<IDictionary<string, string>> GetModifiedFilesAsync(string TaskId, string PrId);
    Task<string> GenerateDiffAsync(string TaskId, string PrId);
    Task DeleteFilesAsync(string TaskId);
}
