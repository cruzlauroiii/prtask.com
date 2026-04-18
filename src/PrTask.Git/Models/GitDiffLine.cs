namespace PrTask.Git.Models;

#pragma warning disable SA1600
public sealed class GitDiffLine
{
    public GitDiffLineType Type { get; set; }
    public string Content { get; set; } = string.Empty;
}
#pragma warning restore SA1600
