using PrTask.Domain.Models;
namespace PrTask.Application.Services;
public interface ISyncService
{
    Task SyncAsync();
    Task<string> GetSyncStatusAsync();
    Task RegisterChangeAsync(string EntityType, string EntityId);
    Task LoadSnapshotAsync(CancellationToken Cancellation = default);
    Task ConnectDiffSyncAsync(string Endpoint, string AuthToken, CancellationToken Cancellation = default);
    Task DisconnectDiffSyncAsync(CancellationToken Cancellation = default);
    Task RequestCatchupAsync(long SinceTimestamp, CancellationToken Cancellation = default);
    event EventHandler<DiffPatchEventArgs>? OnDiffPatchReceived;
    bool IsDiffSyncConnected { get; }
}
