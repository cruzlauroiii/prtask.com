namespace PrTask.Git.Models;

#pragma warning disable SA1600
public sealed class GitRemoteInfo
{
    public string Name { get; set; } = string.Empty;
    public string FetchUrl { get; set; } = string.Empty;
    public string PushUrl { get; set; } = string.Empty;
}
#pragma warning restore SA1600
