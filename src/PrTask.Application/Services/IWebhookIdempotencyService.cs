namespace PrTask.Application.Services;
public interface IWebhookIdempotencyService
{
    Task<bool> IsProcessedAsync(string EventId);
    Task MarkProcessedAsync(string EventId);
}
