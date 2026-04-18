using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class DisbursementEndpoints
{
    public static void MapDisbursementEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiDisbursements).RequireAuthorization();
        Group.MapPost(RouteConstants.SubRoot, async (CreateDisbursementSessionRequest Request, IDisbursementService Service) =>
        {
            var SessionId = await Service.CreateSessionAsync(Request.Email, Request.Password);
            return string.IsNullOrEmpty(SessionId) ? Results.BadRequest() : Results.Ok(new { SessionId });
        });
        Group.MapDelete(RouteConstants.SubRoot, async (IDisbursementService Service) =>
        {
            await Service.TerminateSessionAsync();
            return Results.NoContent();
        });
        Group.MapGet(RouteConstants.SubRoot, async (IDisbursementService Service) =>
        {
            var Result = await Service.GetWalletAsync();
            return string.IsNullOrEmpty(Result) ? Results.NotFound() : Results.Ok(Result);
        });
        Group.MapPost(RouteConstants.SubByCustomer, async (string CustomerId, CsvContentRequest Request, IDisbursementService Service) =>
        {
            var Result = await Service.RegisterBeneficiariesAsync(Request.CsvContent);
            return string.IsNullOrEmpty(Result) ? Results.BadRequest() : Results.Ok(Result);
        });
        Group.MapPost(RouteConstants.SubDisbursementById, async (string DisbursementId, CsvContentRequest Request, IDisbursementService Service) =>
        {
            var Result = await Service.SubmitDisbursementAsync(Request.CsvContent);
            return string.IsNullOrEmpty(Result) ? Results.BadRequest() : Results.Ok(Result);
        });
        Group.MapPost(RouteConstants.SubDisbursementProcess, async (string DisbursementId, IDisbursementService Service) =>
        {
            var Result = await Service.ProcessDisbursementAsync(DisbursementId);
            return string.IsNullOrEmpty(Result) ? Results.BadRequest() : Results.Ok(Result);
        });
        Group.MapGet(RouteConstants.SubDisbursementById, async (string DisbursementId, IDisbursementService Service) =>
        {
            var Result = await Service.GetDisbursementStatusAsync(DisbursementId);
            return string.IsNullOrEmpty(Result) ? Results.NotFound() : Results.Ok(Result);
        });
    }
}
