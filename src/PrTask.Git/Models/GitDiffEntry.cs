namespace PrTask.Git.Models;

#pragma warning disable SA1600
public sealed class GitDiffEntry
{
    public string OldPath { get; set; } = string.Empty;
    public string NewPath { get; set; } = string.Empty;
    public string OldHash { get; set; } = string.Empty;
    public string NewHash { get; set; } = string.Empty;
    public GitDiffStatus Status { get; set; }
    public List<GitDiffHunk> Hunks { get; set; } = new();
}

public enum GitDiffStatus
{
    Added,
    Modified,
    Deleted,
    Renamed,
    Copied,
}

public sealed class GitDiffHunk
{
    public int OldStart { get; set; }
    public int OldCount { get; set; }
    public int NewStart { get; set; }
    public int NewCount { get; set; }
    public string Header { get; set; } = string.Empty;
    public List<GitDiffLine> Lines { get; set; } = new();
}

public sealed class GitDiffLine
{
    public GitDiffLineType Type { get; set; }
    public string Content { get; set; } = string.Empty;
}

public enum GitDiffLineType
{
    Context,
    Addition,
    Deletion,
}
#pragma warning restore SA1600
