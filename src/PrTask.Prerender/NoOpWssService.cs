using PrTask.Application.Services;
namespace PrTask.Prerender;
public sealed class NoOpWssService : IWssService
{
    private static readonly EmptyObservable<WssMessage> EmptyMessages = new();
    public Task ConnectAsync(string Url, string JwtToken, CancellationToken Cancellation = default) => Task.CompletedTask;
    public Task SendMutationAsync(string Collection, string Operation, object Payload, CancellationToken Cancellation = default) => Task.CompletedTask;
    public Task SendJsonAsync(string Json, CancellationToken Cancellation = default) => Task.CompletedTask;
    public IObservable<WssMessage> Messages => EmptyMessages;
    public Task DisconnectAsync() => Task.CompletedTask;
    public bool IsConnected => false;
}
