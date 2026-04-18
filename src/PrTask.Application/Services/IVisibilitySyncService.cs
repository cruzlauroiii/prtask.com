namespace PrTask.Application.Services;
public interface IVisibilitySyncService
{
    Task PauseSyncAsync();
    Task ResumeSyncAsync();
    Task<bool> IsSyncPausedAsync();
}
