namespace PrTask.LowDb;
public sealed class LowSync<T> where T : class
{
    private readonly ISyncAdapter<T> Adapter;
    public T Data { get; set; }
    public LowSync(ISyncAdapter<T> Adapter, T DefaultData)
    {
        ArgumentNullException.ThrowIfNull(Adapter);
        ArgumentNullException.ThrowIfNull(DefaultData);
        this.Adapter = Adapter;
        Data = DefaultData;
    }
    public void Read()
    {
        var Result = Adapter.Read();
        if (Result is not null)
        {
            Data = Result;
        }
    }
    public void Write()
    {
        Adapter.Write(Data);
    }
    public void Update(Action<T> Fn)
    {
        ArgumentNullException.ThrowIfNull(Fn);
        Fn(Data);
        Write();
    }
}
