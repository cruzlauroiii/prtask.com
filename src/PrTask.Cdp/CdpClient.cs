using System.Collections.Concurrent;
using System.Globalization;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace PrTask.Cdp;

#pragma warning disable SA1600
public sealed class CdpClient : IAsyncDisposable
{
    private const int ReceiveBufferSize = 65536;
    private const int DefaultTimeoutMs = 30000;

    private readonly ClientWebSocket Socket = new();
    private readonly ConcurrentDictionary<int, TaskCompletionSource<JsonNode>> PendingRequests = new();
    private readonly ConcurrentDictionary<string, List<Action<JsonNode>>> EventHandlers = new();
    private readonly CancellationTokenSource DisposeCts = new();
    private int NextId;
    private Task? ReceiveLoop;

    public bool IsConnected => Socket.State == WebSocketState.Open;

    public async Task ConnectAsync(string WebSocketUrl, CancellationToken Cancel = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(WebSocketUrl);
        try
        {
            await Socket.ConnectAsync(new Uri(WebSocketUrl), Cancel).ConfigureAwait(false);
        }
        catch (WebSocketException Ex)
        {
            throw new CdpConnectionException(
                string.Format(CultureInfo.InvariantCulture, "Failed to connect to {0}", WebSocketUrl), Ex);
        }

        ReceiveLoop = Task.Run(() => ReceiveMessagesAsync(DisposeCts.Token), DisposeCts.Token);
    }

    public async Task<JsonNode> SendAsync(string Method, JsonNode? Params = null, CancellationToken Cancel = default)
    {
        var Id = Interlocked.Increment(ref NextId);
        var Request = new JsonObject
        {
            ["id"] = Id,
            ["method"] = Method,
        };
        if (Params is not null)
        {
            Request["params"] = Params.DeepClone();
        }

        var Tcs = new TaskCompletionSource<JsonNode>(TaskCreationOptions.RunContinuationsAsynchronously);
        PendingRequests[Id] = Tcs;

        var Bytes = Encoding.UTF8.GetBytes(Request.ToJsonString());
        await Socket.SendAsync(new ArraySegment<byte>(Bytes), WebSocketMessageType.Text, true, Cancel).ConfigureAwait(false);

        using var TimeoutCts = CancellationTokenSource.CreateLinkedTokenSource(Cancel);
        TimeoutCts.CancelAfter(DefaultTimeoutMs);

        try
        {
            return await Tcs.Task.WaitAsync(TimeoutCts.Token).ConfigureAwait(false);
        }
        catch (OperationCanceledException) when (!Cancel.IsCancellationRequested)
        {
            PendingRequests.TryRemove(Id, out _);
            throw new CdpTimeoutException(string.Format(CultureInfo.InvariantCulture, "Timeout waiting for response to {0} (id={1})", Method, Id));
        }
    }

    public async Task<JsonNode> SendToTargetAsync(string SessionId, string Method, JsonNode? Params = null, CancellationToken Cancel = default)
    {
        var InnerParams = new JsonObject
        {
            ["method"] = Method,
        };
        if (Params is not null)
        {
            InnerParams["params"] = Params.DeepClone();
        }

        var OuterParams = new JsonObject
        {
            ["sessionId"] = SessionId,
            ["message"] = InnerParams.ToJsonString(),
        };

        // For Target.sendMessageToTarget, we embed and use a flat command approach
        // Instead, use the sessionId-flattened approach (CDP supports this directly)
        var Id = Interlocked.Increment(ref NextId);
        var Request = new JsonObject
        {
            ["id"] = Id,
            ["method"] = Method,
            ["sessionId"] = SessionId,
        };
        if (Params is not null)
        {
            Request["params"] = Params.DeepClone();
        }

        var Tcs = new TaskCompletionSource<JsonNode>(TaskCreationOptions.RunContinuationsAsynchronously);
        PendingRequests[Id] = Tcs;

        var Bytes = Encoding.UTF8.GetBytes(Request.ToJsonString());
        await Socket.SendAsync(new ArraySegment<byte>(Bytes), WebSocketMessageType.Text, true, Cancel).ConfigureAwait(false);

        using var TimeoutCts = CancellationTokenSource.CreateLinkedTokenSource(Cancel);
        TimeoutCts.CancelAfter(DefaultTimeoutMs);

        try
        {
            return await Tcs.Task.WaitAsync(TimeoutCts.Token).ConfigureAwait(false);
        }
        catch (OperationCanceledException) when (!Cancel.IsCancellationRequested)
        {
            PendingRequests.TryRemove(Id, out _);
            throw new CdpTimeoutException(string.Format(CultureInfo.InvariantCulture, "Timeout waiting for response to {0} (session={1})", Method, SessionId));
        }
    }

    public void On(string EventName, Action<JsonNode> Handler)
    {
        var Handlers = EventHandlers.GetOrAdd(EventName, _ => new List<Action<JsonNode>>());
        lock (Handlers)
        {
            Handlers.Add(Handler);
        }
    }

    public void Off(string EventName, Action<JsonNode>? Handler = null)
    {
        if (Handler is null)
        {
            EventHandlers.TryRemove(EventName, out _);
        }
        else if (EventHandlers.TryGetValue(EventName, out var Handlers))
        {
            lock (Handlers)
            {
                Handlers.Remove(Handler);
            }
        }
    }

    private async Task ReceiveMessagesAsync(CancellationToken Cancel)
    {
        var Buffer = new byte[ReceiveBufferSize];
        var MessageBuffer = new MemoryStream();

        while (!Cancel.IsCancellationRequested && Socket.State == WebSocketState.Open)
        {
            try
            {
                var Received = await Socket.ReceiveAsync(new ArraySegment<byte>(Buffer), Cancel).ConfigureAwait(false);
                if (Received.MessageType == WebSocketMessageType.Close)
                {
                    break;
                }

                MessageBuffer.Write(Buffer, 0, Received.Count);
                if (!Received.EndOfMessage)
                {
                    continue;
                }

                var Json = Encoding.UTF8.GetString(MessageBuffer.GetBuffer(), 0, (int)MessageBuffer.Length);
                MessageBuffer.SetLength(0);

                var Node = JsonNode.Parse(Json);
                if (Node is null)
                {
                    continue;
                }

                if (Node["id"] is not null)
                {
                    HandleResponse(Node);
                }
                else if (Node["method"] is not null)
                {
                    HandleEvent(Node);
                }
            }
            catch (OperationCanceledException)
            {
                break;
            }
            catch (WebSocketException)
            {
                break;
            }
        }

        // Cancel all pending requests on disconnect
        foreach (var Kvp in PendingRequests)
        {
            if (PendingRequests.TryRemove(Kvp.Key, out var Tcs))
            {
                Tcs.TrySetException(new CdpConnectionException("WebSocket connection closed"));
            }
        }
    }

    private void HandleResponse(JsonNode Node)
    {
        var Id = Node["id"]!.GetValue<int>();
        if (!PendingRequests.TryRemove(Id, out var Tcs))
        {
            return;
        }

        if (Node["error"] is JsonNode ErrorNode)
        {
            var Code = ErrorNode["code"]?.GetValue<int>() ?? -1;
            var Message = ErrorNode["message"]?.GetValue<string>() ?? "Unknown error";
            var Data = ErrorNode["data"]?.ToJsonString();
            Tcs.TrySetException(new CdpProtocolException(Code, Message, Data));
        }
        else
        {
            Tcs.TrySetResult(Node["result"] ?? new JsonObject());
        }
    }

    private void HandleEvent(JsonNode Node)
    {
        var MethodName = Node["method"]!.GetValue<string>();
        if (!EventHandlers.TryGetValue(MethodName, out var Handlers))
        {
            return;
        }

        var EventParams = Node["params"] ?? new JsonObject();
        List<Action<JsonNode>> Snapshot;
        lock (Handlers)
        {
            Snapshot = new List<Action<JsonNode>>(Handlers);
        }

        foreach (var Handler in Snapshot)
        {
            try
            {
                Handler(EventParams);
            }
            catch
            {
                // Event handlers must not throw
            }
        }
    }

    public async ValueTask DisposeAsync()
    {
        DisposeCts.Cancel();
        if (Socket.State == WebSocketState.Open)
        {
            try
            {
                await Socket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Disposing", CancellationToken.None).ConfigureAwait(false);
            }
            catch
            {
                // Best effort close
            }
        }

        if (ReceiveLoop is not null)
        {
            try
            {
                await ReceiveLoop.ConfigureAwait(false);
            }
            catch
            {
                // Ignore receive loop errors on dispose
            }
        }

        Socket.Dispose();
        DisposeCts.Dispose();
    }
}
#pragma warning restore SA1600
