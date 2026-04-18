using PrTask.Application.Services;
namespace PrTask.Prerender;
public sealed class NoOpLocalStoreService : ILocalStoreService
{
    public Task InitAsync() => Task.CompletedTask;
    public Task<string?> ReadFileAsync(string Path) => Task.FromResult<string?>(null);
    public Task WriteFileAsync(string Path, string Content) => Task.CompletedTask;
    public Task DeleteFileAsync(string Path) => Task.CompletedTask;
    public Task<string[]> ListFilesAsync(string Directory) => Task.FromResult(Array.Empty<string>());
    public Task<bool> FileExistsAsync(string Path) => Task.FromResult(false);
    public Task WriteBytesAsync(string Path, byte[] Bytes) => Task.CompletedTask;
    public Task<byte[]?> ReadBytesAsync(string Path) => Task.FromResult<byte[]?>(null);
    public Task<T[]> GetRecordsAsync<T>(string Collection) => Task.FromResult(Array.Empty<T>());
    public Task<T?> GetRecordAsync<T>(string Collection, string Id) => Task.FromResult<T?>(default);
    public Task SaveRecordAsync<T>(string Collection, T Record) => Task.CompletedTask;
    public Task DeleteRecordAsync(string Collection, string Id) => Task.CompletedTask;
    public Task QueueMutationAsync(object Mutation) => Task.CompletedTask;
    public Task<object[]> GetQueueAsync() => Task.FromResult(Array.Empty<object>());
    public Task ClearQueueAsync() => Task.CompletedTask;
    public Task<string?> GetMetaAsync(string Key) => Task.FromResult<string?>(null);
    public Task SetMetaAsync(string Key, string Value) => Task.CompletedTask;
}
