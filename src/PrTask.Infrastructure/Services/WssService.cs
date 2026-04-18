using System.Net.WebSockets;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Infrastructure.Services;
public sealed class WssService : IWssService, IDisposable
{
    private ClientWebSocket? Socket;
    private Action<WssMessage>? MessageCallback;
    public IObservable<WssMessage> Messages => new WssObservable(Handler => MessageCallback = Handler);
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
        var Bytes = System.Text.Encoding.UTF8.GetBytes(Json);
        await Socket.SendAsync(Bytes, WebSocketMessageType.Text, true, Cancellation);
    }
    public async Task SendJsonAsync(string Json, CancellationToken Cancellation = default)
    {
        if (Socket is null || Socket.State != WebSocketState.Open) { return; }
        var Bytes = System.Text.Encoding.UTF8.GetBytes(Json);
        await Socket.SendAsync(Bytes, WebSocketMessageType.Text, true, Cancellation);
    }
    public async Task DisconnectAsync()
    {
        if (Socket is not null && Socket.State == WebSocketState.Open)
        {
            await Socket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None);
        }
    }
    public void Dispose() => Socket?.Dispose();
    private sealed class WssObservable(Action<Action<WssMessage>> Register) : IObservable<WssMessage>
    {
        public IDisposable Subscribe(IObserver<WssMessage> Observer)
        {
            Register(Observer.OnNext);
            return new WssSubscription();
        }
    }
    private sealed class WssSubscription : IDisposable
    {
        public void Dispose() { }
    }
}
