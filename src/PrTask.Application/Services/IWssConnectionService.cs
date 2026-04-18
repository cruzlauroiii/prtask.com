namespace PrTask.Application.Services;
public interface IWssConnectionService
{
    Task ConnectAsync(string Endpoint, CancellationToken Cancellation = default);
    Task DisconnectAsync(CancellationToken Cancellation = default);
    Task<string> QueryAsync(string Message, CancellationToken Cancellation = default);
    Task SendAsync(string Message, CancellationToken Cancellation = default);
    Task SubscribeAsync(string Channel, Action<string> Handler, CancellationToken Cancellation = default);
    bool IsConnected { get; }
}
