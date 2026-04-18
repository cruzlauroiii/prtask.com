namespace PrTask.LowDb;
public interface IAdapter<T>
{
    Task<T?> ReadAsync(CancellationToken CancellationToken = default);
    Task WriteAsync(T Data, CancellationToken CancellationToken = default);
}
