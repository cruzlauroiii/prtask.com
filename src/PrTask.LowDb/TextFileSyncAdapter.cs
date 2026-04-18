namespace PrTask.LowDb;
public sealed class TextFileSyncAdapter : ISyncAdapter<string>
{
    private readonly string FilePath;
    public TextFileSyncAdapter(string FilePath)
    {
        ArgumentException.ThrowIfNullOrEmpty(FilePath);
        this.FilePath = FilePath;
    }
    public string? Read()
    {
        return !File.Exists(FilePath) ? null : File.ReadAllText(FilePath);
    }
    public void Write(string Data)
    {
        var Dir = Path.GetDirectoryName(FilePath);
        if (!string.IsNullOrEmpty(Dir))
        {
            Directory.CreateDirectory(Dir);
        }
        var TempPath = FilePath + LowDbConstants.TempFileExtension;
        File.WriteAllText(TempPath, Data);
        File.Move(TempPath, FilePath, overwrite: true);
    }
}
