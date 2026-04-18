namespace PrTask.Application.Services;

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
