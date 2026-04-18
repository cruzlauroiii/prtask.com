using PrTask.Application.Services;
using PrTask.Domain.Models;
namespace PrTask.Prerender;
public sealed class NoOpSyncService : ISyncService
{
    public Task SyncAsync() => Task.CompletedTask;
    public Task<string> GetSyncStatusAsync() => Task.FromResult(string.Empty);
    public Task RegisterChangeAsync(string EntityType, string EntityId) => Task.CompletedTask;
    public Task LoadSnapshotAsync(CancellationToken Cancellation = default) => Task.CompletedTask;
    public Task ConnectDiffSyncAsync(string Endpoint, string AuthToken, CancellationToken Cancellation = default) => Task.CompletedTask;
    public Task DisconnectDiffSyncAsync(CancellationToken Cancellation = default) => Task.CompletedTask;
    public Task RequestCatchupAsync(long SinceTimestamp, CancellationToken Cancellation = default) => Task.CompletedTask;
#pragma warning disable CS0067
    public event EventHandler<DiffPatchEventArgs>? OnDiffPatchReceived;
#pragma warning restore CS0067
    public bool IsDiffSyncConnected => false;
}
