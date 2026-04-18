using System.Net.WebSockets;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Infrastructure.Services.Wss;
public sealed class WssService : IWssService, IDisposable
{
    private ClientWebSocket? Socket;
    public IObservable<WssMessage> Messages { get; } = new WssObservable();
    public bool IsConnected => Socket?.State == WebSocketState.Open;
    public async Task ConnectAsync(string Url, string JwtToken, CancellationToken Cancellation = default)
    {
        Socket = new ClientWebSocket();
        Socket.Options.AddSubProtocol(WssConstants.ProtocolName);
        await Socket.ConnectAsync(new Uri(Url), Cancellation);
    }
    public async Task SendMutationAsync(string Collection, string Operation, object Payload, CancellationToken Cancellation = default)
    {
        if (Socket is null || Socket.State != WebSocketState.Open) { return; }
        var Json = System.Text.Json.JsonSerializer.Serialize(new { Type = WssConstants.MessageTypeMutation, Collection, Operation, Data = Payload });
        await Socket.SendAsync(System.Text.Encoding.UTF8.GetBytes(Json), WebSocketMessageType.Text, true, Cancellation);
    }
    public async Task SendJsonAsync(string Json, CancellationToken Cancellation = default)
    {
        if (Socket is null || Socket.State != WebSocketState.Open) { return; }
        await Socket.SendAsync(System.Text.Encoding.UTF8.GetBytes(Json), WebSocketMessageType.Text, true, Cancellation);
    }
    public async Task DisconnectAsync()
    {
        if (Socket is { State: WebSocketState.Open })
        {
            await Socket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None);
        }
    }
    public void Dispose() => Socket?.Dispose();
    private sealed class WssObservable : IObservable<WssMessage>
    {
        public IDisposable Subscribe(IObserver<WssMessage> Observer) => new WssSub();
    }
    private sealed class WssSub : IDisposable
    {
        public void Dispose() { }
    }
}
