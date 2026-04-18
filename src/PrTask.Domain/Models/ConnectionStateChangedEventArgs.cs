namespace PrTask.Domain.Models;
public sealed class ConnectionStateChangedEventArgs(WebSocketConnectionState NewState) : EventArgs
{
    public WebSocketConnectionState NewState { get; } = NewState;
}
