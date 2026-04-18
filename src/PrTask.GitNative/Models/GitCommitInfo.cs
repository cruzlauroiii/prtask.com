namespace PrTask.GitNative.Models;

#pragma warning disable SA1600
public sealed class GitCommitInfo
{
    public string Hash { get; set; } = string.Empty;
    public string TreeHash { get; set; } = string.Empty;
    public string[] ParentHashes { get; set; } = [];
    public string AuthorName { get; set; } = string.Empty;
    public string AuthorEmail { get; set; } = string.Empty;
    public DateTimeOffset AuthorDate { get; set; }
    public string CommitterName { get; set; } = string.Empty;
    public string CommitterEmail { get; set; } = string.Empty;
    public DateTimeOffset CommitterDate { get; set; }
    public string Message { get; set; } = string.Empty;
}
#pragma warning restore SA1600
