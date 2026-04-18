using System.Text.Json;
namespace PrTask.LowDb;
public sealed class JsonFileSyncAdapter<T> : ISyncAdapter<T> where T : class
{
    private readonly TextFileSyncAdapter TextAdapter;
    private readonly JsonSerializerOptions Options;
    public JsonFileSyncAdapter(string FilePath, JsonSerializerOptions? Options = null)
    {
        TextAdapter = new TextFileSyncAdapter(FilePath);
        this.Options = Options ?? new JsonSerializerOptions { WriteIndented = true };
    }
    public T? Read()
    {
        var Text = TextAdapter.Read();
        return Text is null ? default : JsonSerializer.Deserialize<T>(Text, Options);
    }
    public void Write(T Data)
    {
        var Text = JsonSerializer.Serialize(Data, Options);
        TextAdapter.Write(Text);
    }
}
