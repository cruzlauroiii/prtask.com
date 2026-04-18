using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class QrPaymentEndpoints
{
    public static void MapQrPaymentEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiQrPayments).RequireAuthorization();
        Group.MapPost(RouteConstants.SubQrDynamic, async (CreateDynamicQrRequest Request, IQrPaymentService Service) =>
        {
            var Result = await Service.CreateDynamicQrAsync(
                Request.Amount, Request.Currency, Request.RequestReferenceNumber,
                Request.SuccessUrl, Request.FailureUrl, Request.CancelUrl);
            return string.IsNullOrEmpty(Result) ? Results.BadRequest() : Results.Ok(Result);
        });
        Group.MapPost(RouteConstants.SubQrStatic, async (CreateStaticQrPaymentRequest Request, IQrPaymentService Service) =>
        {
            var Result = await Service.CreateStaticQrPaymentAsync(
                Request.P2mId, Request.Amount, Request.Currency, Request.RequestReferenceNumber);
            return string.IsNullOrEmpty(Result) ? Results.BadRequest() : Results.Ok(Result);
        });
        Group.MapPost(RouteConstants.SubQrExecute, async (string PaymentId, IQrPaymentService Service) =>
        {
            var Result = await Service.ExecuteQrPaymentAsync(PaymentId);
            return string.IsNullOrEmpty(Result) ? Results.BadRequest() : Results.Ok(Result);
        });
        Group.MapGet(RouteConstants.SubQrStatus, async (string PaymentId, IQrPaymentService Service) =>
        {
            var Result = await Service.GetQrPaymentAsync(PaymentId);
            return string.IsNullOrEmpty(Result) ? Results.NotFound() : Results.Ok(Result);
        });
    }
    public record CreateDynamicQrRequest(
        decimal Amount, string Currency, string RequestReferenceNumber,
        string SuccessUrl, string FailureUrl, string CancelUrl);
    public record CreateStaticQrPaymentRequest(
        string P2mId, decimal Amount, string Currency, string RequestReferenceNumber);
}
