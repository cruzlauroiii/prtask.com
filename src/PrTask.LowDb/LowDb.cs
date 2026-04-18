namespace PrTask.LowDb;
public sealed class LowDatabase<T> where T : class, new()
{
    private readonly LowSync<T> Db;
    internal LowDatabase(ISyncAdapter<T> Adapter)
    {
        Db = new LowSync<T>(Adapter, new T());
    }
    public void Read()
    {
        Db.Read();
    }
    public T Get()
    {
        return Db.Data;
    }
    public void Update(Action<T> Fn)
    {
        Db.Update(Fn);
    }
    public void Write()
    {
        Db.Write();
    }
}
