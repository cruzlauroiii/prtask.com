namespace PrTask.LowDb;
public sealed class MemorySyncAdapter<T> : ISyncAdapter<T> where T : class
{
    private T? StoredData;
    public T? Read()
    {
        return StoredData;
    }
    public void Write(T Data)
    {
        StoredData = Data;
    }
}
