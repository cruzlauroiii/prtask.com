using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class WalletPaymentEndpoints
{
    public static void MapWalletPaymentEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiWalletPayments).RequireAuthorization();
        Group.MapPost(RouteConstants.SubRoot, async (CreateWalletPaymentRequest Request, IWalletPaymentService Service) =>
        {
            var Result = await Service.CreateWalletPaymentAsync(
                Request.Amount, Request.Currency, Request.RequestReferenceNumber,
                Request.SuccessUrl, Request.FailureUrl, Request.CancelUrl);
            return string.IsNullOrEmpty(Result) ? Results.BadRequest() : Results.Ok(Result);
        });
        Group.MapPost(RouteConstants.SubWalletLink, async (CreateWalletLinkRequest Request, IWalletPaymentService Service) =>
        {
            var Result = await Service.CreateWalletLinkAsync(
                Request.RequestReferenceNumber, Request.SuccessUrl,
                Request.FailureUrl, Request.CancelUrl);
            return string.IsNullOrEmpty(Result) ? Results.BadRequest() : Results.Ok(Result);
        });
        Group.MapPost(RouteConstants.SubWalletLinkExecute, async (string LinkId, ExecuteWalletLinkPaymentRequest Request, IWalletPaymentService Service) =>
        {
            var Result = await Service.ExecuteWalletLinkPaymentAsync(
                LinkId, Request.Amount, Request.Currency,
                Request.RequestReferenceNumber, Request.IdempotencyKey);
            return string.IsNullOrEmpty(Result) ? Results.BadRequest() : Results.Ok(Result);
        });
        Group.MapGet(RouteConstants.SubWalletLinkById, async (string LinkId, IWalletPaymentService Service) =>
        {
            var Result = await Service.GetWalletLinkAsync(LinkId);
            return string.IsNullOrEmpty(Result) ? Results.NotFound() : Results.Ok(Result);
        });
        Group.MapDelete(RouteConstants.SubWalletLinkById, async (string LinkId, IWalletPaymentService Service) =>
            await Service.DeleteWalletLinkAsync(LinkId) ? Results.NoContent() : Results.NotFound());
    }
    public record CreateWalletPaymentRequest(
        decimal Amount, string Currency, string RequestReferenceNumber,
        string SuccessUrl, string FailureUrl, string CancelUrl);
    public record CreateWalletLinkRequest(
        string RequestReferenceNumber, string SuccessUrl,
        string FailureUrl, string CancelUrl);
    public record ExecuteWalletLinkPaymentRequest(
        decimal Amount, string Currency, string RequestReferenceNumber, string? IdempotencyKey);
}
