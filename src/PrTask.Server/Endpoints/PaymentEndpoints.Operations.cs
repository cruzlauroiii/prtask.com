using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static partial class PaymentEndpoints
{
    private static void MapOperationEndpoints(RouteGroupBuilder Group)
    {
        MapVoidRetrievalEndpoints(Group);
        MapRefundRetrievalEndpoints(Group);
        MapCaptureAndCancelEndpoints(Group);
        MapFeesEndpoint(Group);
    }

    private static void MapVoidRetrievalEndpoints(RouteGroupBuilder Group)
    {
        Group.MapGet(RouteConstants.SubPaymentVoids, async (string PaymentId, IPaymentService Service) =>
        {
            var Voids = await Service.ListVoidsAsync(PaymentId);
            return string.IsNullOrEmpty(Voids) ? Results.NotFound() : Results.Ok(Voids);
        }).RequireAuthorization();
        Group.MapGet(RouteConstants.SubPaymentVoidById, async (string PaymentId, string VoidId, IPaymentService Service) =>
        {
            var VoidRecord = await Service.GetVoidAsync(PaymentId, VoidId);
            return string.IsNullOrEmpty(VoidRecord) ? Results.NotFound() : Results.Ok(VoidRecord);
        }).RequireAuthorization();
    }

    private static void MapRefundRetrievalEndpoints(RouteGroupBuilder Group)
    {
        Group.MapGet(RouteConstants.SubPaymentRefunds, async (string PaymentId, IPaymentService Service) =>
        {
            var Refunds = await Service.ListRefundsAsync(PaymentId);
            return string.IsNullOrEmpty(Refunds) ? Results.NotFound() : Results.Ok(Refunds);
        }).RequireAuthorization();
        Group.MapGet(RouteConstants.SubPaymentRefundById, async (string PaymentId, string RefundId, IPaymentService Service) =>
        {
            var RefundRecord = await Service.GetRefundAsync(PaymentId, RefundId);
            return string.IsNullOrEmpty(RefundRecord) ? Results.NotFound() : Results.Ok(RefundRecord);
        }).RequireAuthorization();
    }

    private static void MapCaptureAndCancelEndpoints(RouteGroupBuilder Group)
    {
        Group.MapPost(RouteConstants.SubPaymentCapture, async (string PaymentId, CapturePaymentRequest Request, IPaymentService Service) =>
        {
            var Result = await Service.CapturePaymentAsync(PaymentId, Request.AmountCents);
            return string.IsNullOrEmpty(Result) ? Results.BadRequest() : Results.Ok(Result);
        }).RequireAuthorization();
        Group.MapPost(RouteConstants.SubPaymentCancel, async (string PaymentId, CancelPaymentRequest Request, IPaymentService Service) =>
            await Service.CancelPaymentAsync(PaymentId, Request.Reason) ? Results.Ok() : Results.BadRequest())
            .RequireAuthorization();
    }

    private static void MapFeesEndpoint(RouteGroupBuilder Group)
    {
        Group.MapPost(RouteConstants.SubFees, async (CalculateFeesRequest Request, IPaymentService Service) =>
            Results.Ok(await Service.CalculateFeesAsync(Request.AmountCents)))
            .RequireAuthorization();
    }
}
