namespace PrTask.Git.Models;

#pragma warning disable SA1600
public sealed class GitDiffHunk
{
    public int OldStart { get; set; }
    public int OldCount { get; set; }
    public int NewStart { get; set; }
    public int NewCount { get; set; }
    public string Header { get; set; } = string.Empty;
    public IList<GitDiffLine> Lines { get; } = [];
}
#pragma warning restore SA1600
