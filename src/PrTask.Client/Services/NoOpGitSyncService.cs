using PrTask.Application.Services;
namespace PrTask.Client.Services;

public sealed class NoOpGitSyncService : IGitSyncService
{
    public Task InitAsync() => Task.CompletedTask;
    public Task CloneAsync(string Branch) => Task.CompletedTask;
    public Task PullAsync() => Task.CompletedTask;
    public Task<string?> GetCurrentBranchAsync() => Task.FromResult<string?>(null);
    public Task SwitchBranchAsync(string Branch) => Task.CompletedTask;
    public Task<string?> GetLastCommitHashAsync() => Task.FromResult<string?>(null);
    public Task ResetHardAsync(string Ref) => Task.CompletedTask;
    public Task CommitAsync(string Message) => Task.CompletedTask;
    public Task PushAsync(string Remote, string Branch) => Task.CompletedTask;
}
