using System.Net.WebSockets;
using System.Text;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Infrastructure.Services;
public sealed class WssConnectionService : IWssConnectionService, IDisposable
{
    private ClientWebSocket? Socket;
    private readonly Dictionary<string, Action<string>> Subscriptions = [];
    public bool IsConnected => Socket?.State == WebSocketState.Open;
    public async Task ConnectAsync(string Endpoint, CancellationToken Cancellation = default)
    {
        Socket?.Dispose();
        Socket = new ClientWebSocket();
        Socket.Options.AddSubProtocol(WssConstants.ProtocolName);
        await Socket.ConnectAsync(new Uri(Endpoint), Cancellation);
    }
    public async Task DisconnectAsync(CancellationToken Cancellation = default)
    {
        if (Socket?.State == WebSocketState.Open)
        {
            await Socket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, Cancellation);
        }
    }
    public async Task<string> QueryAsync(string Message, CancellationToken Cancellation = default)
    {
        await SendAsync(Message, Cancellation);
        var Buffer = new byte[WssConstants.ReceiveBufferSize];
        var Result = await Socket!.ReceiveAsync(Buffer, Cancellation);
        return Encoding.UTF8.GetString(Buffer, 0, Result.Count);
    }
    public async Task SendAsync(string Message, CancellationToken Cancellation = default)
    {
        var Bytes = Encoding.UTF8.GetBytes(Message);
        await Socket!.SendAsync(Bytes, WebSocketMessageType.Text, true, Cancellation);
    }
    public Task SubscribeAsync(string Channel, Action<string> Handler, CancellationToken Cancellation = default)
    {
        Subscriptions[Channel] = Handler;
        return SendAsync(FormatStrings.WssSubscriptionMessage(Channel), Cancellation);
    }
    public void Dispose() => Socket?.Dispose();
}
