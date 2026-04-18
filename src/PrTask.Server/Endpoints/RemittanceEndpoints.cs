using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class RemittanceEndpoints
{
    public static void MapRemittanceEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiRemittances).RequireAuthorization();
        Group.MapPost(RouteConstants.SubRoot, async (CreateRemittanceRequest Request, IRemittanceService Service) =>
        {
            var Result = await Service.CreateRemittanceAsync(
                Request.RecipientMayaAccount, Request.Amount,
                Request.Currency, Request.RequestReferenceNumber);
            return string.IsNullOrEmpty(Result)
                ? Results.BadRequest()
                : Results.Created(FormatStrings.ApiResourcePath(RouteConstants.ApiRemittances, Result), Result);
        });
        Group.MapPost(RouteConstants.SubRemittanceExecute, async (string TransactionReferenceNumber, IRemittanceService Service) =>
        {
            await Service.ExecuteRemittanceAsync(TransactionReferenceNumber);
            return Results.Ok();
        });
        Group.MapGet(RouteConstants.SubRemittanceStatus, async (string TransactionReferenceNumber, IRemittanceService Service) =>
        {
            var Result = await Service.GetRemittanceStatusAsync(TransactionReferenceNumber);
            return string.IsNullOrEmpty(Result) ? Results.NotFound() : Results.Ok(Result);
        });
    }
    internal record CreateRemittanceRequest(
        string RecipientMayaAccount, decimal Amount,
        string Currency, string RequestReferenceNumber);
}
