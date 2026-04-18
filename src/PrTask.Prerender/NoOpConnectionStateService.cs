using PrTask.Domain.Models;
namespace PrTask.Prerender;
public sealed class NoOpConnectionStateService : PrTask.Application.Services.IConnectionStateService
{
    public WebSocketConnectionState CurrentState => WebSocketConnectionState.Disconnected;
#pragma warning disable CS0067
    public event EventHandler<ConnectionStateChangedEventArgs>? StateChanged;
#pragma warning restore CS0067
    public void SetState(WebSocketConnectionState State)
    {
    }
}
