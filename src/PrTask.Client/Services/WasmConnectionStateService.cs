using PrTask.Application.Services;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public sealed class WasmConnectionStateService : IConnectionStateService
{
    public WebSocketConnectionState CurrentState { get; private set; } = WebSocketConnectionState.Disconnected;
    public event EventHandler<ConnectionStateChangedEventArgs>? StateChanged;
    public void SetState(WebSocketConnectionState State)
    {
        if (CurrentState == State)
        {
            return;
        }
        CurrentState = State;
        StateChanged?.Invoke(this, new ConnectionStateChangedEventArgs(State));
    }
}
