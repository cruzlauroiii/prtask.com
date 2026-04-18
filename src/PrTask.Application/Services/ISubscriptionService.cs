using PrTask.Domain.Models;
namespace PrTask.Application.Services;
public interface ISubscriptionService
{
    Task<SubscriptionEntity> CreateSubscriptionAsync(string CustomerId, string CardTokenId, string Description, decimal Amount, string Currency, string Interval, int IntervalCount, DateTimeOffset StartDate);
    Task<IReadOnlyList<SubscriptionEntity>> ListSubscriptionsAsync(string CustomerId, string CardTokenId);
    Task<SubscriptionEntity?> GetSubscriptionAsync(string SubscriptionId);
    Task<bool> CancelSubscriptionAsync(string SubscriptionId);
    Task<string> GetSubscriptionPaymentsAsync(string SubscriptionId);
}
