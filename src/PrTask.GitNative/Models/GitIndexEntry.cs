namespace PrTask.GitNative.Models;

#pragma warning disable SA1600
public sealed class GitIndexEntry
{
    public string Path { get; set; } = string.Empty;
    public string Hash { get; set; } = string.Empty;
    public int Mode { get; set; }
    public int Stage { get; set; }
    public long FileSize { get; set; }
    public DateTimeOffset ModifiedTime { get; set; }
}
#pragma warning restore SA1600
