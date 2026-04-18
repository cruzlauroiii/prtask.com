namespace PrTask.SharedUI.Services;

public enum ConnectionState
{
    Offline = 0,
    Connecting = 1,
    Syncing = 2,
    Online = 3,
    GitPulling = 4,
    SetupNeeded = 5
}

public sealed class ConnectionStateChangedEventArgs(ConnectionState NewState) : EventArgs
{
    public ConnectionState NewState { get; } = NewState;
}

public interface IConnectionStateService
{
    ConnectionState State { get; }
    int SyncProgress { get; }
    int SyncTotal { get; }
    DateTime? LastSyncTime { get; }
    event EventHandler<ConnectionStateChangedEventArgs>? OnStateChanged;
    Func<Task>? SyncCallback { get; set; }
    Task GoOnlineAsync();
    Task GoOfflineAsync();
    Task SyncNowAsync();
    void UpdateSyncProgress(int Progress, int Total);
    void SetLastSyncTime(DateTime Time);
    void SetGitPulling();
    void SetSetupNeeded();
}
