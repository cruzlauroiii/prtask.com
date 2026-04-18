namespace PrTask.Application.Services;
public interface IWssService
{
    Task ConnectAsync(string Url, string JwtToken, CancellationToken Cancellation = default);
    Task SendMutationAsync(string Collection, string Operation, object Payload, CancellationToken Cancellation = default);
    Task SendJsonAsync(string Json, CancellationToken Cancellation = default);
    IObservable<WssMessage> Messages { get; }
    Task DisconnectAsync();
    bool IsConnected { get; }
}
