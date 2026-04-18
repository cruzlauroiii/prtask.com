using PrTask.Application.Services;
namespace PrTask.Prerender;
public sealed class NoOpVisibilitySyncService : IVisibilitySyncService
{
    public Task PauseSyncAsync() => Task.CompletedTask;
    public Task ResumeSyncAsync() => Task.CompletedTask;
    public Task<bool> IsSyncPausedAsync() => Task.FromResult(false);
}
