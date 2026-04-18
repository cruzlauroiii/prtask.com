using PrTask.Domain.Models;
namespace PrTask.Application.Services;
public interface IConnectionStateService
{
    WebSocketConnectionState CurrentState { get; }
    event EventHandler<ConnectionStateChangedEventArgs>? StateChanged;
    void SetState(WebSocketConnectionState State);
}
