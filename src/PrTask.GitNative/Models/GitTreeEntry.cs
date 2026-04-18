namespace PrTask.GitNative.Models;

#pragma warning disable SA1600
public sealed class GitTreeEntry
{
    public string Mode { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Hash { get; set; } = string.Empty;

    public bool IsDirectory => Mode == "40000";
    public bool IsFile => Mode == "100644" || Mode == "100755";
    public bool IsExecutable => Mode == "100755";
    public bool IsSymlink => Mode == "120000";
    public bool IsSubmodule => Mode == "160000";
}
#pragma warning restore SA1600
