using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static partial class P3PaymentEndpoints
{
    public static void MapP3PaymentEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiP3);
        MapCoreEndpoints(Group);
        MapBinEndpoints(Group);
        MapApiKeyEndpoints(Group);
        MapRecurringEndpoints(Group);
    }

    private static void MapCoreEndpoints(RouteGroupBuilder Group)
    {
        Group.MapPost(RouteConstants.SubP3Pay, async (P3PayRequest Request, IP3PaymentService Service) =>
        {
            var Result = await Service.PayAsync(
                Request.CardNumber, Request.ExpMonth, Request.ExpYear, Request.Cvc,
                Request.Amount, Request.Currency, Request.RequestReferenceNumber);
            return string.IsNullOrEmpty(Result) ? Results.BadRequest() : Results.Ok(Result);
        }).RequireAuthorization();

        Group.MapPost(RouteConstants.SubP3Authorize, async (P3AuthorizeRequest Request, IP3PaymentService Service) =>
        {
            var Result = await Service.AuthorizeAsync(
                Request.CardNumber, Request.ExpMonth, Request.ExpYear, Request.Cvc,
                Request.Amount, Request.Currency, Request.RequestReferenceNumber);
            return string.IsNullOrEmpty(Result) ? Results.BadRequest() : Results.Ok(Result);
        }).RequireAuthorization();

        Group.MapPost(RouteConstants.SubP3Capture, async (P3CaptureRequest Request, IP3PaymentService Service) =>
        {
            var Result = await Service.CaptureAsync(Request.TransactionRefNo);
            return string.IsNullOrEmpty(Result) ? Results.BadRequest() : Results.Ok(Result);
        }).RequireAuthorization();

        Group.MapPost(RouteConstants.SubP3FinalCapture, async (P3FinalCaptureRequest Request, IP3PaymentService Service) =>
        {
            var Result = await Service.FinalCaptureAsync(Request.TransactionRefNo);
            return string.IsNullOrEmpty(Result) ? Results.BadRequest() : Results.Ok(Result);
        }).RequireAuthorization();

        Group.MapPost(RouteConstants.SubP3Void, async (P3VoidRequest Request, IP3PaymentService Service) =>
            await Service.VoidP3Async(Request.TransactionRefNo, Request.Reason, Request.IdempotencyKey)
                ? Results.Ok() : Results.BadRequest())
            .RequireAuthorization();

        Group.MapPost(RouteConstants.SubP3Refund, async (P3RefundRequest Request, IP3PaymentService Service) =>
            await Service.RefundP3Async(Request.TransactionRefNo, Request.Amount, Request.Reason, Request.IdempotencyKey)
                ? Results.Ok() : Results.BadRequest())
            .RequireAuthorization();

        Group.MapGet(RouteConstants.SubP3TransactionById, async (string RefNo, IP3PaymentService Service) =>
        {
            var Result = await Service.GetTransactionAsync(RefNo);
            return string.IsNullOrEmpty(Result) ? Results.NotFound() : Results.Ok(Result);
        }).RequireAuthorization();

        Group.MapGet(RouteConstants.SubP3Transactions, async (string? MerchantId, int? Page, int? Size, IP3PaymentService Service) =>
            Results.Ok(await Service.ListTransactionsAsync(MerchantId, Page, Size)))
            .RequireAuthorization();

        Group.MapPost(RouteConstants.SubP3Balance, async (IP3PaymentService Service) =>
        {
            var Result = await Service.BalanceInquiryAsync();
            return string.IsNullOrEmpty(Result) ? Results.BadRequest() : Results.Ok(Result);
        }).RequireAuthorization();

        Group.MapGet(RouteConstants.SubP3Ping, async (IP3PaymentService Service) =>
            Results.Ok(await Service.PingAsync()))
            .RequireAuthorization();
    }
}
