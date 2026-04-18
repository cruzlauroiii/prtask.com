namespace PrTask.Git.Models;

#pragma warning disable SA1600
public sealed class GitRawObject
{
    public string Hash { get; set; } = string.Empty;
    public GitObjectType Type { get; set; }
    public byte[] Data { get; set; } = [];
    public int Size { get; set; }
}
#pragma warning restore SA1600
