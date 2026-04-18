namespace PrTask.LowDb;
public sealed class Low<T> where T : class
{
    private readonly IAdapter<T> Adapter;
    public T Data { get; set; }
    public Low(IAdapter<T> Adapter, T DefaultData)
    {
        ArgumentNullException.ThrowIfNull(Adapter);
        ArgumentNullException.ThrowIfNull(DefaultData);
        this.Adapter = Adapter;
        Data = DefaultData;
    }
    public async Task ReadAsync(CancellationToken CancellationToken = default)
    {
        var Result = await Adapter.ReadAsync(CancellationToken).ConfigureAwait(false);
        if (Result is not null)
        {
            Data = Result;
        }
    }
    public async Task WriteAsync(CancellationToken CancellationToken = default)
    {
        await Adapter.WriteAsync(Data, CancellationToken).ConfigureAwait(false);
    }
    public async Task UpdateAsync(Action<T> Fn, CancellationToken CancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(Fn);
        Fn(Data);
        await WriteAsync(CancellationToken).ConfigureAwait(false);
    }
}
