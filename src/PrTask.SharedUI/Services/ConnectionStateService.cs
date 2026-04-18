using PrTask.Domain.Constants;
namespace PrTask.SharedUI.Services;

public sealed class ConnectionStateService : IConnectionStateService
{
    public ConnectionState State { get; private set; } = ConnectionState.Offline;
    public int SyncProgress { get; private set; }
    public int SyncTotal { get; private set; }
    public DateTime? LastSyncTime { get; private set; }
    public event EventHandler<ConnectionStateChangedEventArgs>? OnStateChanged;
    public Func<Task>? SyncCallback { get; set; }

    public async Task GoOnlineAsync()
    {
        State = ConnectionState.Connecting;
        NotifyStateChanged();
        await Task.Delay(WssConstants.GoOnlineSimulationDelayMs);
        State = ConnectionState.Online;
        NotifyStateChanged();
    }

    public async Task GoOfflineAsync()
    {
        State = ConnectionState.Offline;
        NotifyStateChanged();
        await Task.CompletedTask;
    }

    public async Task SyncNowAsync()
    {
        if (SyncCallback is not null)
        {
            await SyncCallback();
            return;
        }
        State = ConnectionState.Syncing;
        SyncProgress = 0;
        SyncTotal = 0;
        NotifyStateChanged();
        await Task.Delay(WssConstants.GoOnlineSimulationDelayMs);
        LastSyncTime = DateTime.UtcNow;
        State = ConnectionState.Offline;
        NotifyStateChanged();
    }

    public void UpdateSyncProgress(int Progress, int Total)
    {
        SyncProgress = Progress;
        SyncTotal = Total;
        NotifyStateChanged();
    }

    public void SetLastSyncTime(DateTime Time)
    {
        LastSyncTime = Time;
        NotifyStateChanged();
    }

    public void SetGitPulling()
    {
        State = ConnectionState.GitPulling;
        NotifyStateChanged();
    }

    public void SetSetupNeeded()
    {
        State = ConnectionState.SetupNeeded;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnStateChanged?.Invoke(this, new ConnectionStateChangedEventArgs(State));
}
