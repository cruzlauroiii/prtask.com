using PrTask.Application.Services;
using PrTask.Domain.Models;
namespace PrTask.Prerender;
public sealed class NoOpSubscriptionService : ISubscriptionService
{
    public Task<SubscriptionEntity> CreateSubscriptionAsync(string CustomerId, string CardTokenId, string Description, decimal Amount, string Currency, string Interval, int IntervalCount, DateTimeOffset StartDate) =>
        Task.FromResult(new SubscriptionEntity { Id = string.Empty, CustomerId = CustomerId, CardTokenId = CardTokenId, Description = Description });
    public Task<IReadOnlyList<SubscriptionEntity>> ListSubscriptionsAsync(string CustomerId, string CardTokenId) => Task.FromResult<IReadOnlyList<SubscriptionEntity>>([]);
    public Task<SubscriptionEntity?> GetSubscriptionAsync(string SubscriptionId) => Task.FromResult<SubscriptionEntity?>(null);
    public Task<bool> CancelSubscriptionAsync(string SubscriptionId) => Task.FromResult(false);
    public Task<string> GetSubscriptionPaymentsAsync(string SubscriptionId) => Task.FromResult(string.Empty);
}
