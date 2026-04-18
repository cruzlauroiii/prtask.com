using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class PaymentV2Endpoints
{
    public static void MapPaymentV2Endpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiPaymentsV2).RequireAuthorization();
        Group.MapPost(RouteConstants.SubRoot, async (CreatePaymentV2Request Request, IPaymentV2Service Service) =>
        {
            var Json = await Service.CreatePaymentV2Async(
                Request.ConnectToken, Request.Amount, Request.Currency, Request.RequestReferenceNumber);
            return string.IsNullOrEmpty(Json) ? Results.BadRequest() : Results.Content(Json, AppConstants.ContentTypeJson);
        });
        Group.MapGet(RouteConstants.SubPaymentV2ById, async (string PaymentId, IPaymentV2Service Service) =>
        {
            var Json = await Service.GetPaymentV2Async(PaymentId);
            return string.IsNullOrEmpty(Json) ? Results.NotFound() : Results.Content(Json, AppConstants.ContentTypeJson);
        });
    }
    internal record CreatePaymentV2Request(string ConnectToken, decimal Amount, string Currency, string RequestReferenceNumber);
}
