namespace PrTask.LowDb;
public interface ISyncAdapter<T>
{
    T? Read();
    void Write(T Data);
}
