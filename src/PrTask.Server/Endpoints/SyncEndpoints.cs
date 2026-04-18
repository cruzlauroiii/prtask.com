using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class SyncEndpoints
{
    public static void MapSyncEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiSync).RequireAuthorization();
        Group.MapPost(RouteConstants.SubSyncExecute, async (ISyncService Service) =>
        {
            await Service.SyncAsync();
            return Results.Ok();
        });
        Group.MapGet(RouteConstants.SubStatus, async (ISyncService Service) =>
            Results.Ok(new { Status = await Service.GetSyncStatusAsync() }));
        Group.MapPost(RouteConstants.SubSyncRegister, async (SyncRegisterRequest Request, ISyncService Service) =>
        {
            await Service.RegisterChangeAsync(Request.EntityType, Request.EntityId);
            return Results.Ok();
        });
    }
}
