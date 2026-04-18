using System.Net.WebSockets;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Client.Services;
public sealed class WasmWssService(ILogger<WasmWssService> Logger) : IWssService, IAsyncDisposable
{
    private readonly Subject<WssMessage> MessageSubject = new();
    private ClientWebSocket? Socket;
    private CancellationTokenSource? ReceiveCts;
    private string? CurrentUrl;
    private string? CurrentToken;
    private bool Disposed;
    public IObservable<WssMessage> Messages => MessageSubject.AsObservable();
    public bool IsConnected => Socket?.State == WebSocketState.Open;
    public async Task ConnectAsync(string Url, string JwtToken, CancellationToken Cancellation = default)
    {
        ObjectDisposedException.ThrowIf(Disposed, this);
        CurrentUrl = Url;
        CurrentToken = JwtToken;
        await DisconnectInternalAsync().ConfigureAwait(false);
        Logger.LogInformation(WssConstants.LogWssConnecting, Url);
        Socket = new ClientWebSocket();
        Socket.Options.AddSubProtocol(WssConstants.ProtocolName);
        var UriBuilder = new UriBuilder(Url);
        UriBuilder.Query = string.IsNullOrEmpty(UriBuilder.Query)
            ? FormatStrings.WssTokenQuery(JwtToken)
            : FormatStrings.WssTokenQueryAppend(UriBuilder.Query[1..], JwtToken);
        await Socket.ConnectAsync(UriBuilder.Uri, Cancellation).ConfigureAwait(false);
        Logger.LogInformation(WssConstants.LogWssConnected, Socket.SubProtocol);
        ReceiveCts = CancellationTokenSource.CreateLinkedTokenSource(Cancellation);
        _ = Task.Run(() => ReceiveLoopAsync(ReceiveCts.Token), CancellationToken.None);
    }
    public async Task SendMutationAsync(string Collection, string Operation, object Payload, CancellationToken Cancellation = default)
    {
        ObjectDisposedException.ThrowIf(Disposed, this);
        Logger.LogDebug(WssConstants.LogWssSendingMutation, Collection, Operation);
        var Envelope = new
        {
            type = WssConstants.MessageTypeMutation,
            id = Guid.NewGuid().ToString(WssConstants.GuidFormatNoDashes),
            collection = Collection,
            operation = Operation,
            data = Payload,
        };
        var Json = JsonSerializer.Serialize(Envelope);
        var Bytes = Encoding.UTF8.GetBytes(Json);
        await Socket!.SendAsync(Bytes, WebSocketMessageType.Text, true, Cancellation).ConfigureAwait(false);
    }
    public async Task SendJsonAsync(string Json, CancellationToken Cancellation = default)
    {
        ObjectDisposedException.ThrowIf(Disposed, this);
        var Bytes = Encoding.UTF8.GetBytes(Json);
        await Socket!.SendAsync(Bytes, WebSocketMessageType.Text, true, Cancellation).ConfigureAwait(false);
    }
    public async Task DisconnectAsync()
    {
        ObjectDisposedException.ThrowIf(Disposed, this);
        await DisconnectInternalAsync().ConfigureAwait(false);
        Logger.LogInformation(WssConstants.LogWssDisconnected);
    }
    public async ValueTask DisposeAsync()
    {
        if (Disposed)
        {
            return;
        }
        Disposed = true;
        await DisconnectInternalAsync().ConfigureAwait(false);
        MessageSubject.Dispose();
        Logger.LogDebug(WssConstants.LogWssDisposed);
    }
    private async Task ReceiveLoopAsync(CancellationToken Cancellation)
    {
        Logger.LogDebug(WssConstants.LogWssReceiveLoopStarted);
        var Buffer = new byte[WssConstants.ReceiveBufferSize];
        try
        {
            while (!Cancellation.IsCancellationRequested && Socket?.State == WebSocketState.Open)
            {
                using var Stream = new MemoryStream();
                WebSocketReceiveResult Result;
                do
                {
                    Result = await Socket.ReceiveAsync(Buffer, Cancellation).ConfigureAwait(false);
                    Stream.Write(Buffer, 0, Result.Count);
                }
                while (!Result.EndOfMessage);
                if (Result.MessageType == WebSocketMessageType.Close)
                {
                    Logger.LogInformation(WssConstants.LogWssConnectionClosed);
                    break;
                }
                var Raw = Encoding.UTF8.GetString(Stream.ToArray());
                var Parsed = ParseMessage(Raw);
                if (Parsed is not null)
                {
                    MessageSubject.OnNext(Parsed);
                }
            }
        }
        catch (OperationCanceledException)
        {
        }
        catch (WebSocketException Ex)
        {
            Logger.LogWarning(Ex, WssConstants.LogWssReceiveError);
        }
        Logger.LogDebug(WssConstants.LogWssReceiveLoopStopped);
        if (!Disposed && !Cancellation.IsCancellationRequested)
        {
            _ = Task.Run(() => ReconnectAsync(Cancellation), CancellationToken.None);
        }
    }
    private async Task ReconnectAsync(CancellationToken Cancellation)
    {
        for (var Attempt = 1; Attempt <= WssConstants.MaxReconnectRetries; Attempt++)
        {
            if (Cancellation.IsCancellationRequested || Disposed)
            {
                return;
            }
            var DelaySeconds = WssConstants.ReconnectBaseDelaySeconds
                * (int)Math.Pow(WssConstants.ReconnectBackoffMultiplier, Attempt - 1);
            Logger.LogInformation(WssConstants.LogWssReconnecting, Attempt, WssConstants.MaxReconnectRetries);
            try
            {
                await Task.Delay(TimeSpan.FromSeconds(DelaySeconds), Cancellation).ConfigureAwait(false);
                await ConnectAsync(CurrentUrl!, CurrentToken!, Cancellation).ConfigureAwait(false);
                if (IsConnected)
                {
                    return;
                }
            }
            catch (OperationCanceledException)
            {
                return;
            }
            catch (WebSocketException)
            {
            }
        }
        Logger.LogError(WssConstants.LogWssReconnectFailed, WssConstants.MaxReconnectRetries);
    }
    private async Task DisconnectInternalAsync()
    {
        if (ReceiveCts is not null)
        {
            await ReceiveCts.CancelAsync().ConfigureAwait(false);
            ReceiveCts.Dispose();
            ReceiveCts = null;
        }
        if (Socket is not null)
        {
            if (Socket.State == WebSocketState.Open)
            {
                try
                {
                    await Socket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None)
                        .ConfigureAwait(false);
                }
                catch (WebSocketException)
                {
                }
            }
            Socket.Dispose();
            Socket = null;
        }
    }
    private static WssMessage? ParseMessage(string Raw)
    {
        try
        {
            using var Doc = JsonDocument.Parse(Raw);
            var Root = Doc.RootElement;
            return new WssMessage(
                Type: Root.TryGetProperty(WssConstants.JsonType, out var TypeProp) ? TypeProp.GetString() ?? string.Empty : string.Empty,
                Id: Root.TryGetProperty(WssConstants.JsonId, out var IdProp) ? IdProp.GetString() : null,
                Collection: Root.TryGetProperty(WssConstants.JsonCollection, out var ColProp) ? ColProp.GetString() : null,
                Operation: Root.TryGetProperty(WssConstants.JsonOperation, out var OpProp) ? OpProp.GetString() : null,
                Channel: Root.TryGetProperty(WssConstants.JsonChannel, out var ChanProp) ? ChanProp.GetString() : null,
                Message: Root.TryGetProperty(WssConstants.JsonMessage, out var MsgProp) ? MsgProp.GetString() : null,
                Data: Root.TryGetProperty(WssConstants.JsonData, out var DataProp) ? DataProp.Clone()
                    : Root.TryGetProperty(WssConstants.JsonMutations, out var MutProp) ? MutProp.Clone()
                    : Root.TryGetProperty(WssConstants.JsonChanges, out var ChgProp) ? ChgProp.Clone() : null,
                Timestamp: Root.TryGetProperty(WssConstants.JsonTimestamp, out var TsProp) ? TsProp.GetString()
                    : Root.TryGetProperty(WssConstants.JsonSnapshotTimestamp, out var SnapTsProp) ? SnapTsProp.GetString() : null);
        }
        catch (JsonException)
        {
            return null;
        }
    }
}
