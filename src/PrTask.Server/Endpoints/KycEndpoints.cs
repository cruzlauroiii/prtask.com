using System.Security.Claims;
using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class KycEndpoints
{
    public static void MapKycEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiKyc);
        Group.MapPost(RouteConstants.SubKycCreate, async (HttpContext Context, IKycVerificationService Service) =>
        {
            var UserId = Context.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(UserId)) { return Results.Unauthorized(); }
            var CallbackUrl = Context.Request.Query[DiditConstants.QueryKeyCallback].FirstOrDefault();
            var (SessionId, Url) = await Service.CreateSessionAsync(UserId, CallbackUrl);
            return string.IsNullOrEmpty(SessionId)
                ? Results.Problem(DiditConstants.ErrorCreateSession)
                : Results.Ok(new { SessionId, VerificationUrl = Url });
        }).RequireAuthorization();
        Group.MapGet(RouteConstants.SubKycStatus, async (string SessionId, IKycVerificationService Service) =>
        {
            var (Status, FullName) = await Service.GetSessionStatusAsync(SessionId);
            return Results.Ok(new { Status, FullName });
        }).RequireAuthorization();
        Group.MapPatch(RouteConstants.SubKycUpdate, async (string SessionId, KycUpdateRequest Req, IKycVerificationService Service) =>
        {
            await Service.UpdateSessionStatusAsync(SessionId, Req.NewStatus, Req.Comment);
            return Results.Ok();
        }).RequireAuthorization();
        Group.MapGet(RouteConstants.SubKycList, async (HttpContext Context, IKycVerificationService Service) =>
        {
            var VendorData = Context.Request.Query[DiditConstants.QueryKeyVendorData].FirstOrDefault();
            var Status = Context.Request.Query[DiditConstants.QueryKeyStatus].FirstOrDefault();
            var Json = await Service.ListSessionsAsync(VendorData, Status);
            return Results.Content(Json, DiditConstants.ContentTypeJson);
        }).RequireAuthorization();
        Group.MapDelete(RouteConstants.SubKycDelete, async (string SessionId, IKycVerificationService Service) =>
        {
            await Service.DeleteSessionAsync(SessionId);
            return Results.NoContent();
        }).RequireAuthorization();
    }
}
