using PrTask.Application.Services;
namespace PrTask.Infrastructure.Services;
public sealed class VisibilitySyncService : IVisibilitySyncService
{
    private volatile bool Paused;

    public Task PauseSyncAsync()
    {
        Paused = true;
        return Task.CompletedTask;
    }

    public Task ResumeSyncAsync()
    {
        Paused = false;
        return Task.CompletedTask;
    }

    public Task<bool> IsSyncPausedAsync() => Task.FromResult(Paused);
}
