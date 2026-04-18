namespace PrTask.Git;

#pragma warning disable SA1611, SA1615, RCS1141
public interface IGitSyncService
{
    Task InitAsync();
    Task CloneAsync(string Branch);
    Task PullAsync();
    Task<string?> GetCurrentBranchAsync();
    Task SwitchBranchAsync(string Branch);
    Task<string?> GetLastCommitHashAsync();
    Task ResetHardAsync(string Ref);
    Task CommitAsync(string Message);
    Task PushAsync(string Remote, string Branch);
}
#pragma warning restore SA1611, SA1615, RCS1141
