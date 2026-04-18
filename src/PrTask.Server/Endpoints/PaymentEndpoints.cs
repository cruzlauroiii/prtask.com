using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static partial class PaymentEndpoints
{
    public static void MapPaymentEndpoints(this IEndpointRouteBuilder Routes)
    {
        Routes.MapPost(RouteConstants.ApiPaymentsCheckout, async (PaymentCheckoutRequest Request, IPaymentService Service) =>
            Results.Ok(new PaymentCheckoutResponse(await Service.CreateCheckoutAsync(Request.TaskId, Request.PayerId, Request.AmountCents))))
            .RequireAuthorization();
        Routes.MapPost(RouteConstants.ApiPaymentsWebhook, async (PaymentWebhookRequest Request, IPaymentService Service) =>
        {
            await Service.HandleWebhookAsync(Request.EventType, Request.PayloadJson);
            return Results.Ok();
        });
        Routes.MapGet($"{RouteConstants.ApiPaymentsStatus}/{{PaymentId}}", async (string PaymentId, IPaymentService Service) =>
            Results.Ok(new PaymentStatusResponse(await Service.GetStatusAsync(PaymentId))));
    }
}
