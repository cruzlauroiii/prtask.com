using System.Text.Json;
namespace PrTask.LowDb;
public sealed class JsonFileAdapter<T> : IAdapter<T> where T : class
{
    private readonly TextFileAdapter TextAdapter;
    private readonly JsonSerializerOptions Options;
    public JsonFileAdapter(string FilePath, JsonSerializerOptions? Options = null)
    {
        TextAdapter = new TextFileAdapter(FilePath);
        this.Options = Options ?? new JsonSerializerOptions { WriteIndented = true };
    }
    public async Task<T?> ReadAsync(CancellationToken CancellationToken = default)
    {
        var Text = await TextAdapter.ReadAsync(CancellationToken).ConfigureAwait(false);
        return Text is null ? default : JsonSerializer.Deserialize<T>(Text, Options);
    }
    public async Task WriteAsync(T Data, CancellationToken CancellationToken = default)
    {
        var Text = JsonSerializer.Serialize(Data, Options);
        await TextAdapter.WriteAsync(Text, CancellationToken).ConfigureAwait(false);
    }
}
