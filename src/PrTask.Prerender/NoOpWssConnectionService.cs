using PrTask.Application.Services;
namespace PrTask.Prerender;
public sealed class NoOpWssConnectionService : IWssConnectionService
{
    public Task ConnectAsync(string Endpoint, CancellationToken Cancellation = default) => Task.CompletedTask;
    public Task DisconnectAsync(CancellationToken Cancellation = default) => Task.CompletedTask;
    public Task<string> QueryAsync(string Message, CancellationToken Cancellation = default) => Task.FromResult(string.Empty);
    public Task SendAsync(string Message, CancellationToken Cancellation = default) => Task.CompletedTask;
    public Task SubscribeAsync(string Channel, Action<string> Handler, CancellationToken Cancellation = default) => Task.CompletedTask;
    public bool IsConnected => false;
}
