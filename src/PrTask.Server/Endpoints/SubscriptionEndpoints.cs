using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class SubscriptionEndpoints
{
    public static void MapSubscriptionEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiSubscriptions).RequireAuthorization();
        Group.MapPost(RouteConstants.SubRoot, async (CreateSubscriptionRequest Request, ISubscriptionService Service) =>
        {
            var Entity = await Service.CreateSubscriptionAsync(
                Request.CustomerId, Request.CardTokenId, Request.Description,
                Request.Amount, Request.Currency, Request.Interval,
                Request.IntervalCount, Request.StartDate);
            return Results.Created(
                FormatStrings.ApiResourcePath(RouteConstants.ApiSubscriptions, Entity.Id),
                SubscriptionDto.FromEntity(Entity));
        });
        Group.MapGet(RouteConstants.SubRoot, async (string? CustomerId, string? CardTokenId, ISubscriptionService Service) =>
            Results.Ok((await Service.ListSubscriptionsAsync(CustomerId ?? string.Empty, CardTokenId ?? string.Empty))
                .Select(SubscriptionDto.FromEntity)));
        Group.MapGet(RouteConstants.SubSubscriptionById, async (string SubscriptionId, ISubscriptionService Service) =>
        {
            var Entity = await Service.GetSubscriptionAsync(SubscriptionId);
            return Entity is null ? Results.NotFound() : Results.Ok(SubscriptionDto.FromEntity(Entity));
        });
        Group.MapDelete(RouteConstants.SubSubscriptionById, async (string SubscriptionId, ISubscriptionService Service) =>
            await Service.CancelSubscriptionAsync(SubscriptionId) ? Results.NoContent() : Results.NotFound());
        Group.MapGet(RouteConstants.SubSubscriptionPayments, async (string SubscriptionId, ISubscriptionService Service) =>
        {
            var Result = await Service.GetSubscriptionPaymentsAsync(SubscriptionId);
            return string.IsNullOrEmpty(Result) ? Results.NotFound() : Results.Ok(Result);
        });
    }
}
