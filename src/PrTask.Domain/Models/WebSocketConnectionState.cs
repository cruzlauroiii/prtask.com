namespace PrTask.Domain.Models;
public enum WebSocketConnectionState
{
    Disconnected = 0,
    Connecting = 1,
    Connected = 2,
    Reconnecting = 3
}
