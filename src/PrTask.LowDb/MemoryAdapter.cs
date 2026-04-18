namespace PrTask.LowDb;
public sealed class MemoryAdapter<T> : IAdapter<T> where T : class
{
    private T? StoredData;
    public Task<T?> ReadAsync(CancellationToken CancellationToken = default)
    {
        return Task.FromResult(StoredData);
    }
    public Task WriteAsync(T Data, CancellationToken CancellationToken = default)
    {
        StoredData = Data;
        return Task.CompletedTask;
    }
}
