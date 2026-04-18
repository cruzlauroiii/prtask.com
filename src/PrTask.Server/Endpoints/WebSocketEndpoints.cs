using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class WebSocketEndpoints
{
    private static readonly ConcurrentDictionary<string, List<WebSocket>> Channels = new();
    public static void MapWebSocketEndpoint(this IEndpointRouteBuilder Routes)
    {
        Routes.Map(WssConstants.PathPrefix, async (HttpContext Context, ILogger<Program> Logger) =>
        {
            if (!Context.WebSockets.IsWebSocketRequest)
            {
                Context.Response.StatusCode = StatusCodes.Status400BadRequest;
                return;
            }
            using var Socket = await Context.WebSockets.AcceptWebSocketAsync(WssConstants.ProtocolName);
            Logger.LogInformation(WssConstants.LogWssConnected, WssConstants.ProtocolName);
            var Buffer = new byte[WssConstants.ReceiveBufferSize];
            var ClientChannels = new List<string>();
            try
            {
                while (Socket.State == WebSocketState.Open)
                {
                    var Result = await Socket.ReceiveAsync(Buffer, CancellationToken.None);
                    if (Result.MessageType == WebSocketMessageType.Close)
                    {
                        break;
                    }
                    var Message = Encoding.UTF8.GetString(Buffer, 0, Result.Count);
                    Logger.LogInformation(WssConstants.LogWssMessageReceived, Message);
                    var Response = await HandleMessageAsync(Socket, Message, ClientChannels, Logger);
                    if (Response is not null)
                    {
                        var ResponseBytes = Encoding.UTF8.GetBytes(Response);
                        await Socket.SendAsync(ResponseBytes, WebSocketMessageType.Text, true, CancellationToken.None);
                    }
                }
            }
            finally
            {
                foreach (var Channel in ClientChannels)
                {
                    RemoveFromChannel(Channel, Socket);
                }
                Logger.LogInformation(WssConstants.LogWssDisconnected);
            }
        });
    }
    private static async Task<string?> HandleMessageAsync(
        WebSocket Socket, string Message, List<string> ClientChannels, ILogger Logger)
    {
        await Task.CompletedTask;
        using var Doc = JsonDocument.Parse(Message);
        var Root = Doc.RootElement;
        if (!Root.TryGetProperty(WssConstants.JsonType, out var TypeProp))
        {
            return BuildError(WssConstants.UnknownMessageType);
        }
        var Type = TypeProp.GetString();
        return Type == WssConstants.MessageTypeSubscription
            ? HandleSubscription(Socket, Root, ClientChannels, Logger)
            : Type == WssConstants.MessageTypeQuery
                ? HandleQuery(Root)
                : Type == WssConstants.MessageTypeMutation
                    ? HandleMutation(Root) : BuildAck();
    }
    private static string HandleSubscription(
        WebSocket Socket, JsonElement Root, List<string> ClientChannels, ILogger Logger)
    {
        if (!Root.TryGetProperty(WssConstants.JsonChannel, out var ChannelProp))
        {
            return BuildError(WssConstants.UnknownMessageType);
        }
        var Channel = ChannelProp.GetString() ?? string.Empty;
        var Subscribers = Channels.GetOrAdd(Channel, _ => []);
        lock (Subscribers)
        {
            Subscribers.Add(Socket);
        }
        ClientChannels.Add(Channel);
        Logger.LogInformation(WssConstants.LogWssSubscribed, Channel);
        return BuildAck();
    }
    private static string HandleQuery(JsonElement Root)
    {
        var Collection = Root.TryGetProperty(WssConstants.JsonCollection, out var ColProp)
            ? ColProp.GetString() ?? string.Empty : string.Empty;
        return JsonSerializer.Serialize(new
        {
            Type = WssConstants.MessageTypeAck,
            Collection,
            Data = Array.Empty<object>()
        });
    }
    private static string HandleMutation(JsonElement Root)
    {
        var Collection = Root.TryGetProperty(WssConstants.JsonCollection, out var ColProp)
            ? ColProp.GetString() ?? string.Empty : string.Empty;
        _ = BroadcastToChannelAsync(Collection, Root);
        return BuildAck();
    }
    private static string BuildAck() =>
        JsonSerializer.Serialize(new { Type = WssConstants.MessageTypeAck });
    private static string BuildError(string ErrorMessage) =>
        JsonSerializer.Serialize(new { Type = WssConstants.MessageTypeError, Message = ErrorMessage });
    public static async Task BroadcastToChannelAsync(string Channel, JsonElement Data)
    {
        if (!Channels.TryGetValue(Channel, out var Subscribers))
        {
            return;
        }
        var Payload = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(new
        {
            Type = WssConstants.MessageTypeMutation,
            Channel,
            Data
        }));
        List<WebSocket> Snapshot;
        lock (Subscribers)
        {
            Snapshot = [.. Subscribers];
        }
        foreach (var Socket in Snapshot)
        {
            if (Socket.State == WebSocketState.Open)
            {
                await Socket.SendAsync(Payload, WebSocketMessageType.Text, true, CancellationToken.None);
            }
        }
    }
    private static void RemoveFromChannel(string Channel, WebSocket Socket)
    {
        if (!Channels.TryGetValue(Channel, out var Subscribers))
        {
            return;
        }
        lock (Subscribers)
        {
            Subscribers.Remove(Socket);
        }
    }
}
