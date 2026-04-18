using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Infrastructure.Services;

public sealed partial class SyncService
{
    public async Task LoadSnapshotAsync(CancellationToken Cancellation = default)
    {
        var Client = HttpFactory.CreateClient(AppConstants.AppName);
        var Address = FormatStrings.SnapshotEndpoint(AppConstants.AppBaseUrl);
        var Response = await Client.GetAsync(Address, Cancellation);
        Response.EnsureSuccessStatusCode();
        var ResponseBytes = await Response.Content.ReadAsByteArrayAsync(Cancellation);
        var SnapshotJson = JsonDocument.Parse(ResponseBytes);
        if (SnapshotJson.RootElement.TryGetProperty(WssConstants.JsonTimestamp, out var TimestampElement))
        {
            SnapshotTimestamp = TimestampElement.GetInt64();
        }
        Logger.LogInformation(AiConstants.LogSyncSnapshotFetched, Address, ResponseBytes.Length);
        Logger.LogInformation(WssConstants.LogSnapshotLoaded, SnapshotTimestamp);
    }

    public async Task ConnectDiffSyncAsync(string Endpoint, string AuthToken, CancellationToken Cancellation = default)
    {
        SyncStatus = AiConstants.SyncStatusConnecting;
        await DisconnectDiffSyncAsync(Cancellation);
        DiffCts = CancellationTokenSource.CreateLinkedTokenSource(Cancellation);
        DiffSocket = new ClientWebSocket();
        DiffSocket.Options.AddSubProtocol(WssConstants.ProtocolName);
        DiffSocket.Options.SetRequestHeader(WssConstants.JsonId, AuthToken);
        await DiffSocket.ConnectAsync(new Uri(Endpoint), DiffCts.Token);
        Logger.LogInformation(AiConstants.LogSyncWssConnected, Endpoint);
        SyncStatus = AiConstants.SyncStatusConnected;
        _ = Task.Run(() => ReceiveLoopAsync(DiffCts.Token), DiffCts.Token);
    }

    public async Task DisconnectDiffSyncAsync(CancellationToken Cancellation = default)
    {
        if (DiffCts is not null)
        {
            await DiffCts.CancelAsync();
            DiffCts.Dispose();
            DiffCts = null;
        }
        if (DiffSocket?.State == WebSocketState.Open)
        {
            try
            {
                await DiffSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, Cancellation);
            }
            catch (WebSocketException)
            {
            }
        }
        DiffSocket?.Dispose();
        DiffSocket = null;
        SyncStatus = AiConstants.SyncStatusDisconnected;
    }

    public async Task RequestCatchupAsync(long SinceTimestamp, CancellationToken Cancellation = default)
    {
        if (DiffSocket?.State != WebSocketState.Open)
        {
            return;
        }
        SyncStatus = AiConstants.SyncStatusCatchingUp;
        var RequestId = Guid.NewGuid().ToString(WssConstants.GuidFormatNoDashes);
        var Message = FormatStrings.WssCatchupRequestMessage(RequestId, SinceTimestamp);
        var Bytes = Encoding.UTF8.GetBytes(Message);
        await DiffSocket.SendAsync(Bytes, WebSocketMessageType.Text, true, Cancellation);
        Logger.LogInformation(WssConstants.LogCatchupRequested, SinceTimestamp);
    }

    private async Task ReceiveLoopAsync(CancellationToken Cancellation)
    {
        var Buffer = new byte[WssConstants.ReceiveBufferSize];
        var MessageBuffer = new MemoryStream();
        try
        {
            while (!Cancellation.IsCancellationRequested && DiffSocket?.State == WebSocketState.Open)
            {
                WebSocketReceiveResult ReceiveResult;
                MessageBuffer.SetLength(0);
                do
                {
                    ReceiveResult = await DiffSocket.ReceiveAsync(Buffer, Cancellation);
                    MessageBuffer.Write(Buffer, 0, ReceiveResult.Count);
                } while (!ReceiveResult.EndOfMessage);

                if (ReceiveResult.MessageType == WebSocketMessageType.Close)
                {
                    break;
                }

                var RawMessage = Encoding.UTF8.GetString(MessageBuffer.GetBuffer(), 0, (int)MessageBuffer.Length);
                ProcessMessage(RawMessage);
            }
        }
        catch (OperationCanceledException)
        {
        }
        catch (WebSocketException)
        {
        }
        finally
        {
            MessageBuffer.Dispose();
            SyncStatus = AiConstants.SyncStatusDisconnected;
        }
    }

    private void ProcessMessage(string RawMessage)
    {
        using var Json = JsonDocument.Parse(RawMessage);
        var Root = Json.RootElement;
        if (!Root.TryGetProperty(WssConstants.JsonType, out var TypeElement))
        {
            return;
        }
        var MessageType = TypeElement.GetString();
        switch (MessageType)
        {
            case WssConstants.MessageTypeDiff:
                HandleDiffPatch(Root);
                break;
            case WssConstants.MessageTypeCatchup:
                HandleCatchupResponse(Root);
                break;
            case WssConstants.MessageTypeSnapshotInfo:
                HandleSnapshotInfo(Root);
                break;
        }
    }

    private void HandleDiffPatch(JsonElement Root)
    {
        var Collection = Root.TryGetProperty(WssConstants.JsonCollection, out var ColElement)
            ? ColElement.GetString() ?? string.Empty
            : string.Empty;
        var Operation = Root.TryGetProperty(WssConstants.JsonOperation, out var OpElement)
            ? OpElement.GetString() ?? string.Empty
            : string.Empty;
        var Data = Root.TryGetProperty(WssConstants.JsonData, out var DataElement)
            ? DataElement.GetRawText()
            : string.Empty;
        Logger.LogInformation(AiConstants.LogSyncDiffApplied, Collection, Operation);
        ApplyDiffToAutomerge(Collection, Operation, Data);
        OnDiffPatchReceived?.Invoke(this, new DiffPatchEventArgs(Collection, Operation, Data));
    }

    private void HandleCatchupResponse(JsonElement Root)
    {
        if (!Root.TryGetProperty(WssConstants.JsonMutations, out var MutationsElement)
            || MutationsElement.ValueKind != JsonValueKind.Array)
        {
            SyncStatus = AiConstants.SyncStatusConnected;
            return;
        }

        var Count = 0;
        foreach (var Mutation in MutationsElement.EnumerateArray())
        {
            var Collection = Mutation.TryGetProperty(WssConstants.JsonCollection, out var ColElement)
                ? ColElement.GetString() ?? string.Empty
                : string.Empty;
            var Operation = Mutation.TryGetProperty(WssConstants.JsonOperation, out var OpElement)
                ? OpElement.GetString() ?? string.Empty
                : string.Empty;
            var Data = Mutation.TryGetProperty(WssConstants.JsonData, out var DataElement)
                ? DataElement.GetRawText()
                : string.Empty;
            ApplyDiffToAutomerge(Collection, Operation, Data);
            OnDiffPatchReceived?.Invoke(this, new DiffPatchEventArgs(Collection, Operation, Data));
            Count++;
        }

        Logger.LogInformation(AiConstants.LogSyncCatchupComplete, Count);
        SyncStatus = AiConstants.SyncStatusConnected;
    }

    private void HandleSnapshotInfo(JsonElement Root)
    {
        if (Root.TryGetProperty(WssConstants.JsonTimestamp, out var TimestampElement))
        {
            SnapshotTimestamp = TimestampElement.GetInt64();
            Logger.LogInformation(WssConstants.LogSnapshotLoaded, SnapshotTimestamp);
        }
    }
}
