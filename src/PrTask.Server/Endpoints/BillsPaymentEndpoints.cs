using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class BillsPaymentEndpoints
{
    public static void MapBillsPaymentEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiBillsPayments).RequireAuthorization();
        Group.MapGet(RouteConstants.SubBillers, async (IBillsPaymentService Service) =>
            Results.Ok(await Service.GetBillersAsync()));
        Group.MapGet(RouteConstants.SubBillerBySlug, async (string Slug, IBillsPaymentService Service) =>
            await Service.GetBillerAsync(Slug) is { } Biller
                ? Results.Ok(Biller)
                : Results.NotFound());
        Group.MapPost(RouteConstants.SubRoot, async (CreateBillPaymentRequest Request, IBillsPaymentService Service) =>
        {
            var Result = await Service.CreateBillPaymentAsync(
                Request.BillerSlug, Request.AccountNumber, Request.Amount,
                Request.Currency, Request.CallbackUrl);
            return string.IsNullOrEmpty(Result) ? Results.BadRequest() : Results.Created($"{RouteConstants.ApiBillsPayments}/{Result}", Result);
        });
        Group.MapPost(RouteConstants.SubBillPaymentExecute, async (string BillPaymentId, ExecuteBillPaymentRequest Request, IBillsPaymentService Service) =>
        {
            await Service.ExecuteBillPaymentAsync(
                BillPaymentId, Request.CardNumber, Request.ExpMonth,
                Request.ExpYear, Request.Cvc, Request.UsePushPayment);
            return Results.Ok();
        });
        Group.MapGet(RouteConstants.SubBillPaymentStatus, async (string BillPaymentId, IBillsPaymentService Service) =>
        {
            var Result = await Service.GetBillPaymentStatusAsync(BillPaymentId);
            return string.IsNullOrEmpty(Result) ? Results.NotFound() : Results.Ok(Result);
        });
    }
    internal record CreateBillPaymentRequest(
        string BillerSlug, string AccountNumber, decimal Amount,
        string Currency, string? CallbackUrl);
    internal record ExecuteBillPaymentRequest(
        string? CardNumber, string? ExpMonth, string? ExpYear,
        string? Cvc, bool UsePushPayment);
}
