namespace PrTask.Application.Services;
public interface IWebSocketReconnectionService
{
    Task StartAsync(string Endpoint, CancellationToken Cancellation = default);
    Task StopAsync(CancellationToken Cancellation = default);
    Task SendOrQueueAsync(string Message, CancellationToken Cancellation = default);
    int QueuedMessageCount { get; }
}
