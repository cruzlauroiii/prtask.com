using PrTask.Application.Services;
namespace PrTask.Prerender;
public sealed class NoOpWebSocketReconnectionService : IWebSocketReconnectionService
{
    public Task StartAsync(string Endpoint, CancellationToken Cancellation = default) => Task.CompletedTask;
    public Task StopAsync(CancellationToken Cancellation = default) => Task.CompletedTask;
    public Task SendOrQueueAsync(string Message, CancellationToken Cancellation = default) => Task.CompletedTask;
    public int QueuedMessageCount => 0;
}
