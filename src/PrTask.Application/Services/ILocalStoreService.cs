namespace PrTask.Application.Services;
public interface ILocalStoreService
{
    Task InitAsync();
    Task<string?> ReadFileAsync(string Path);
    Task WriteFileAsync(string Path, string Content);
    Task DeleteFileAsync(string Path);
    Task<string[]> ListFilesAsync(string Directory);
    Task<bool> FileExistsAsync(string Path);
    Task WriteBytesAsync(string Path, byte[] Bytes);
    Task<byte[]?> ReadBytesAsync(string Path);
    Task<T[]> GetRecordsAsync<T>(string Collection);
    Task<T?> GetRecordAsync<T>(string Collection, string Id);
    Task SaveRecordAsync<T>(string Collection, T Record);
    Task DeleteRecordAsync(string Collection, string Id);
    Task QueueMutationAsync(object Mutation);
    Task<object[]> GetQueueAsync();
    Task ClearQueueAsync();
    Task<string?> GetMetaAsync(string Key);
    Task SetMetaAsync(string Key, string Value);
}
