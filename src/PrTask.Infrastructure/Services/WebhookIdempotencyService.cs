using System.Collections.Concurrent;
using PrTask.Application.Services;
namespace PrTask.Infrastructure.Services;
public class WebhookIdempotencyService : IWebhookIdempotencyService
{
    private readonly ConcurrentDictionary<string, byte> ProcessedEvents = new();
    public Task<bool> IsProcessedAsync(string EventId)
    {
        return Task.FromResult(ProcessedEvents.ContainsKey(EventId));
    }
    public Task MarkProcessedAsync(string EventId)
    {
        ProcessedEvents.TryAdd(EventId, 0);
        return Task.CompletedTask;
    }
}
