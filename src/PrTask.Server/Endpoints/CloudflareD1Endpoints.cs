using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class CloudflareD1Endpoints
{
    public static void MapCloudflareD1Endpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiCloudflareD1).RequireAuthorization();
        Group.MapGet(RouteConstants.SubStatus, (ICloudflareD1Service Service) =>
            Results.Ok(new { Configured = Service.IsConfigured }));
        Group.MapPost(RouteConstants.SubQuery, async (D1QueryRequest Request, ICloudflareD1Service Service) =>
        {
            var Result = await Service.QueryAsync(Request.Sql);
            return Results.Ok(new { Data = Result });
        });
    }
}
