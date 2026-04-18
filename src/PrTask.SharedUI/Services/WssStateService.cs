using System.Text.Json;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.SharedUI.Services;
public sealed class WssStateService(
    IWssService WssService,
    IJSRuntime JsRuntime,
    ILocalStoreService LocalStore,
    IConnectionStateService ConnectionState,
    IGitSyncService GitSync,
    ILogger<WssStateService> Logger) : IDisposable
{
    private readonly Lock HandlerLock = new();
    private readonly List<Action<WssMessage>> DiffHandlers = [];
    private IDisposable? Subscription;
    private bool Disposed;
    public bool IsConnected => WssService.IsConnected;
    public async Task ConnectAsync(CancellationToken Cancellation = default)
    {
        if (WssService.IsConnected)
        {
            return;
        }
        Logger.LogInformation(WssConstants.LogWssStateConnecting);
        var Token = await JsRuntime.InvokeAsync<string>(JsInteropConstants.GetSessionToken, Cancellation);
        if (string.IsNullOrEmpty(Token))
        {
            Logger.LogWarning(WssConstants.LogWssStateNoToken);
            return;
        }
        try
        {
            await WssService.ConnectAsync(WssConstants.ProductionEndpoint, Token, Cancellation);
            Subscription?.Dispose();
            Subscription = WssService.Messages.Subscribe(new SyncObserver(this));
            ConnectionState.SyncCallback = () => RequestSyncAsync(Cancellation);
            await ConnectionState.GoOnlineAsync();
            await RequestSyncAsync(Cancellation);
            Logger.LogInformation(WssConstants.LogWssStateConnected);
        }
        catch (Exception Ex)
        {
            Logger.LogWarning(Ex, WssConstants.LogWssStateConnectFailed);
        }
    }
    public async Task DisconnectAsync()
    {
        Subscription?.Dispose();
        Subscription = null;
        await WssService.DisconnectAsync();
        Logger.LogInformation(WssConstants.LogWssStateOffline);
        await ConnectionState.GoOfflineAsync();
    }
    public IDisposable OnDiff(Action<WssMessage> Handler)
    {
        lock (HandlerLock)
        {
            DiffHandlers.Add(Handler);
        }
        return new DiffUnsubscriber(this, Handler);
    }
    public void Dispose()
    {
        if (Disposed)
        {
            return;
        }
        Disposed = true;
        ConnectionState.SyncCallback = null;
        Subscription?.Dispose();
        lock (HandlerLock)
        {
            DiffHandlers.Clear();
        }
    }
    private async Task RequestSyncAsync(CancellationToken Cancellation = default)
    {
        if (!WssService.IsConnected)
        {
            return;
        }
        try
        {
            var LastSync = await LocalStore.GetMetaAsync(WssConstants.MetaLastSyncTime);
            Logger.LogInformation(WssConstants.LogWssStateSyncStarting, LastSync ?? "never");
            ConnectionState.UpdateSyncProgress(0, 0);
            var QueuedMutations = await LocalStore.GetQueueAsync();
            if (QueuedMutations.Length > 0)
            {
                Logger.LogInformation(WssConstants.LogWssStateSendingMutations, QueuedMutations.Length);
                foreach (var Mutation in QueuedMutations)
                {
                    var MutationJson = JsonSerializer.Serialize(Mutation);
                    await WssService.SendJsonAsync(MutationJson, Cancellation);
                }
            }
            var RequestId = Guid.NewGuid().ToString(WssConstants.GuidFormatNoDashes);
            var SinceTimestamp = 0L;
            if (!string.IsNullOrEmpty(LastSync) && DateTime.TryParse(LastSync, out var ParsedSync))
            {
                SinceTimestamp = new DateTimeOffset(ParsedSync, TimeSpan.Zero).ToUnixTimeMilliseconds();
            }
            Logger.LogInformation(WssConstants.LogWssStateSendingCatchup, SinceTimestamp);
            var CatchupJson = FormatStrings.WssCatchupRequestMessage(RequestId, SinceTimestamp);
            await WssService.SendJsonAsync(CatchupJson, Cancellation);
        }
        catch (Exception Ex)
        {
            Logger.LogWarning(Ex, WssConstants.LogWssStateSyncFailed);
        }
    }
    private async Task HandleMessageAsync(WssMessage Message)
    {
        try
        {
            if (Message.Type == WssConstants.MessageTypeDiff)
            {
                await HandleDiffAsync(Message);
            }
            else if (Message.Type == WssConstants.MessageTypeCatchup)
            {
                await HandleCatchupAsync(Message);
            }
            else if (Message.Type == WssConstants.MessageTypeAutomergePatch)
            {
                await HandleAutomergePatchAsync(Message);
            }
            else if (Message.Type == WssConstants.MessageTypeGitPushComplete)
            {
                await HandleGitPushCompleteAsync(Message);
            }
        }
        catch (Exception Ex)
        {
            Logger.LogWarning(Ex, WssConstants.LogWssStateSyncFailed);
        }
    }
    private async Task HandleDiffAsync(WssMessage Message)
    {
        Logger.LogDebug(WssConstants.LogWssStateDiffReceived, Message.Collection);
        if (Message.Collection is not null && Message.Data is not null)
        {
            await LocalStore.SaveRecordAsync(Message.Collection, Message.Data);
            Logger.LogDebug(WssConstants.LogWssStateRecordSaved, Message.Collection);
            if (Message.Timestamp is not null)
            {
                await LocalStore.SetMetaAsync(WssConstants.MetaLastSyncTime, Message.Timestamp);
            }
        }
        Action<WssMessage>[] Snapshot;
        lock (HandlerLock)
        {
            Snapshot = [.. DiffHandlers];
        }
        foreach (var Handler in Snapshot)
        {
            Handler(Message);
        }
    }
    private async Task HandleCatchupAsync(WssMessage Message)
    {
        if (Message.Data is not JsonElement DataElement)
        {
            return;
        }
        var MutationCount = 0;
        if (DataElement.ValueKind == JsonValueKind.Array)
        {
            MutationCount = DataElement.GetArrayLength();
            Logger.LogInformation(WssConstants.LogWssStateCatchupReceived, MutationCount);
            ConnectionState.UpdateSyncProgress(0, MutationCount);
            var Index = 0;
            foreach (var MutationElement in DataElement.EnumerateArray())
            {
                var Collection = MutationElement.TryGetProperty(WssConstants.JsonCollection, out var ColProp)
                    ? ColProp.GetString() : null;
                if (Collection is not null)
                {
                    var RecordData = MutationElement.TryGetProperty(WssConstants.JsonData, out var DataProp)
                        ? (object)DataProp.Clone() : null;
                    if (RecordData is not null)
                    {
                        await LocalStore.SaveRecordAsync(Collection, RecordData);
                    }
                }
                Index++;
                ConnectionState.UpdateSyncProgress(Index, MutationCount);
            }
        }
        await LocalStore.ClearQueueAsync();
        Logger.LogDebug(WssConstants.LogWssStateQueueCleared);
        var SyncTime = DateTime.UtcNow.ToString(AppConstants.RoundTripDateTimeFormat);
        if (Message.Timestamp is not null)
        {
            SyncTime = Message.Timestamp;
        }
        await LocalStore.SetMetaAsync(WssConstants.MetaLastSyncTime, SyncTime);
        ConnectionState.SetLastSyncTime(DateTime.UtcNow);
        Logger.LogInformation(WssConstants.LogWssStateSyncComplete, MutationCount);
        await ConnectionState.GoOnlineAsync();
    }
    private async Task HandleAutomergePatchAsync(WssMessage Message)
    {
        if (Message.Collection is null || Message.Data is not JsonElement ChangesElement)
        {
            return;
        }
        if (ChangesElement.ValueKind == JsonValueKind.Array)
        {
            var AllBytes = new List<byte>();
            foreach (var ChangeArray in ChangesElement.EnumerateArray())
            {
                if (ChangeArray.ValueKind == JsonValueKind.Array)
                {
                    foreach (var ByteVal in ChangeArray.EnumerateArray())
                    {
                        AllBytes.Add(ByteVal.GetByte());
                    }
                }
            }
            if (AllBytes.Count > 0)
            {
                var Path = FormatStrings.AutomergePath(Message.Collection);
                var ExistingBytes = await LocalStore.ReadBytesAsync(Path);
                byte[] MergedBytes;
                if (ExistingBytes is not null)
                {
                    MergedBytes = new byte[ExistingBytes.Length + AllBytes.Count];
                    ExistingBytes.CopyTo(MergedBytes, 0);
                    AllBytes.CopyTo(MergedBytes, ExistingBytes.Length);
                }
                else
                {
                    MergedBytes = [.. AllBytes];
                }
                await LocalStore.WriteBytesAsync(Path, MergedBytes);
                Logger.LogDebug(WssConstants.LogWssStateAutomergeSaved, Message.Collection);
            }
        }
        if (Message.Timestamp is not null)
        {
            await LocalStore.SetMetaAsync(WssConstants.MetaLastSyncTime, Message.Timestamp);
        }
    }
    private async Task HandleGitPushCompleteAsync(WssMessage Message)
    {
        if (Message.Data is not JsonElement DataElement)
        {
            return;
        }
        var CommitSha = DataElement.ValueKind == JsonValueKind.String
            ? DataElement.GetString()
            : DataElement.TryGetProperty(WssConstants.JsonGitCommitSha, out var ShaProp)
                ? ShaProp.GetString()
                : null;
        if (string.IsNullOrEmpty(CommitSha))
        {
            Logger.LogWarning(WssConstants.LogWssStateGitPushNoSha);
            return;
        }
        Logger.LogInformation(WssConstants.LogWssStateGitPullStarting, CommitSha);
        ConnectionState.SetGitPulling();
        try
        {
            await GitSync.ResetHardAsync(CommitSha);
            Logger.LogInformation(WssConstants.LogWssStateGitPullComplete, CommitSha);
            await JsRuntime.InvokeVoidAsync(JsInteropConstants.NotifyServiceWorkerGitPull, Array.Empty<string>());
            await ConnectionState.GoOnlineAsync();
        }
        catch (Exception Ex)
        {
            Logger.LogWarning(Ex, WssConstants.LogWssStateGitPullFailed);
            await ConnectionState.GoOnlineAsync();
        }
    }
    private void RemoveHandler(Action<WssMessage> Handler)
    {
        lock (HandlerLock)
        {
            DiffHandlers.Remove(Handler);
        }
    }
    private sealed class SyncObserver(WssStateService State) : IObserver<WssMessage>
    {
        public void OnNext(WssMessage Value) => _ = State.HandleMessageAsync(Value);
        public void OnError(Exception Error) { }
        public void OnCompleted() { }
    }
    private sealed class DiffUnsubscriber(WssStateService State, Action<WssMessage> Handler) : IDisposable
    {
        public void Dispose() => State.RemoveHandler(Handler);
    }
}
