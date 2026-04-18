using System.Text.Json;
namespace PrTask.LowDb;
public static class LowDbFactory
{
    public static LowDatabase<T> CreateJsonLowDb<T>(string FilePath, JsonSerializerOptions? Options = null) where T : class, new()
    {
        var Adapter = new JsonFileSyncAdapter<T>(FilePath, Options);
        return new LowDatabase<T>(Adapter);
    }
    public static LowDatabase<T> CreateMemoryLowDb<T>() where T : class, new()
    {
        var Adapter = new MemorySyncAdapter<T>();
        return new LowDatabase<T>(Adapter);
    }
}
