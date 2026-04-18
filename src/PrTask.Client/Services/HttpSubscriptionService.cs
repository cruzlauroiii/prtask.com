using System.Net.Http.Json;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class HttpSubscriptionService(HttpClient Http) : ISubscriptionService
{
    public async Task<SubscriptionEntity> CreateSubscriptionAsync(
        string CustomerId, string CardTokenId, string Description,
        decimal Amount, string Currency, string Interval, int IntervalCount, DateTimeOffset StartDate)
    {
        var Resp = await Http.PostAsJsonAsync(RouteConstants.ApiSubscriptions,
            new { CustomerId, CardTokenId, Description, Amount, Currency, Interval, IntervalCount, StartDate });
        return await Resp.Content.ReadFromJsonAsync<SubscriptionEntity>()
            ?? new SubscriptionEntity { Id = string.Empty, CustomerId = CustomerId, CardTokenId = CardTokenId, Description = Description };
    }
    public async Task<IReadOnlyList<SubscriptionEntity>> ListSubscriptionsAsync(string CustomerId, string CardTokenId)
    {
        try
        {
            return await Http.GetFromJsonAsync<SubscriptionEntity[]>(
                RouteConstants.ApiSubscriptions) ?? [];
        }
        catch { return []; }
    }
    public async Task<SubscriptionEntity?> GetSubscriptionAsync(string SubscriptionId)
    {
        try
        {
            return await Http.GetFromJsonAsync<SubscriptionEntity>(
                FormatStrings.ApiResourcePath(RouteConstants.ApiSubscriptions, SubscriptionId));
        }
        catch { return null; }
    }
    public async Task<bool> CancelSubscriptionAsync(string SubscriptionId)
    {
        var Resp = await Http.DeleteAsync(
            FormatStrings.ApiResourcePath(RouteConstants.ApiSubscriptions, SubscriptionId));
        return Resp.IsSuccessStatusCode;
    }
    public async Task<string> GetSubscriptionPaymentsAsync(string SubscriptionId)
    {
        try
        {
            return await Http.GetStringAsync(
                FormatStrings.ApiResourcePath(RouteConstants.ApiSubscriptions, SubscriptionId)
                + RouteConstants.SubPaymentsList) ?? string.Empty;
        }
        catch { return string.Empty; }
    }
}
