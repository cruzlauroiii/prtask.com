namespace PrTask.Git.Models;

#pragma warning disable SA1600
public sealed class PackIndexEntry
{
    public string Hash { get; set; } = string.Empty;
    public uint Offset { get; set; }
    public uint Crc32 { get; set; }
}
#pragma warning restore SA1600
