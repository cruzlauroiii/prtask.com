using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class LocalSubscriptionService(ILocalStoreService Store) : ISubscriptionService
{
    public async Task<SubscriptionEntity> CreateSubscriptionAsync(
        string CustomerId, string CardTokenId, string Description,
        decimal Amount, string Currency, string Interval, int IntervalCount, DateTimeOffset StartDate)
    {
        var Entity = new SubscriptionEntity
        {
            Id = Guid.NewGuid().ToString(),
            CustomerId = CustomerId,
            CardTokenId = CardTokenId,
            Description = Description,
            AmountCents = (long)(Amount * 100),
            Currency = Currency,
            IntervalCount = IntervalCount,
            StartDate = StartDate
        };
        await Store.SaveRecordAsync(OpfsConstants.CollectionSubscriptions, Entity);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeCreateSubscription, Entity });
        return Entity;
    }

    public async Task<IReadOnlyList<SubscriptionEntity>> ListSubscriptionsAsync(string CustomerId, string CardTokenId)
    {
        var All = await Store.GetRecordsAsync<SubscriptionEntity>(OpfsConstants.CollectionSubscriptions);
        return All.Where(S => S.CustomerId == CustomerId).ToList();
    }

    public async Task<SubscriptionEntity?> GetSubscriptionAsync(string SubscriptionId) =>
        await Store.GetRecordAsync<SubscriptionEntity>(OpfsConstants.CollectionSubscriptions, SubscriptionId);

    public async Task<bool> CancelSubscriptionAsync(string SubscriptionId)
    {
        var Entity = await GetSubscriptionAsync(SubscriptionId);
        if (Entity is not null)
        {
            Entity.Status = SubscriptionStatus.Cancelled;
            Entity.UpdatedAt = DateTimeOffset.UtcNow;
            await Store.SaveRecordAsync(OpfsConstants.CollectionSubscriptions, Entity);
        }
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeCancelSubscription, SubscriptionId });
        return true;
    }

    public Task<string> GetSubscriptionPaymentsAsync(string SubscriptionId) =>
        Task.FromResult(string.Empty);
}
