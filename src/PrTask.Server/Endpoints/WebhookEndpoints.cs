using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class WebhookEndpoints
{
    public static void MapWebhookEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiWebhooks)
            .RequireAuthorization(PermissionConstants.ToPolicyName(PermissionConstants.ManageWebhooks));
        Group.MapPost(RouteConstants.SubRoot, async (RegisterWebhookRequest Request, IPaymentService Service) =>
        {
            var WebhookId = await Service.RegisterWebhookAsync(Request.EventName, Request.CallbackUrl);
            return string.IsNullOrEmpty(WebhookId) ? Results.BadRequest() : Results.Ok(new { WebhookId });
        });
        Group.MapGet(RouteConstants.SubRoot, async (IPaymentService Service) =>
            Results.Ok(await Service.GetWebhooksAsync()));
        Group.MapPut(RouteConstants.SubWebhookById, async (string WebhookId, UpdateWebhookRequest Request, IPaymentService Service) =>
            await Service.UpdateWebhookAsync(WebhookId, Request.EventName, Request.CallbackUrl) ? Results.Ok() : Results.BadRequest());
        Group.MapDelete(RouteConstants.SubWebhookById, async (string WebhookId, IPaymentService Service) =>
            await Service.DeleteWebhookAsync(WebhookId) ? Results.NoContent() : Results.NotFound());
    }
}
