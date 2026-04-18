namespace PrTask.LowDb;
public sealed class TextFileAdapter : IAdapter<string>
{
    private readonly string FilePath;
    public TextFileAdapter(string FilePath)
    {
        ArgumentException.ThrowIfNullOrEmpty(FilePath);
        this.FilePath = FilePath;
    }
    public async Task<string?> ReadAsync(CancellationToken CancellationToken = default)
    {
        return !File.Exists(FilePath)
            ? null
            : await File.ReadAllTextAsync(FilePath, CancellationToken).ConfigureAwait(false);
    }
    public async Task WriteAsync(string Data, CancellationToken CancellationToken = default)
    {
        var Dir = Path.GetDirectoryName(FilePath);
        if (!string.IsNullOrEmpty(Dir))
        {
            Directory.CreateDirectory(Dir);
        }
        var TempPath = FilePath + LowDbConstants.TempFileExtension;
        await File.WriteAllTextAsync(TempPath, Data, CancellationToken).ConfigureAwait(false);
        File.Move(TempPath, FilePath, overwrite: true);
    }
}
