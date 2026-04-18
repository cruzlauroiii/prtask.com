using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class LeaderboardEndpoints
{
    public static void MapLeaderboardEndpoints(this IEndpointRouteBuilder Routes)
    {
        Routes.MapGet(RouteConstants.ApiLeaderboard, async (int? Count, ILeaderboardService Service) => Results.Ok(await Service.GetTopAsync(Count ?? 100)));
        Routes.MapGet($"{RouteConstants.ApiLeaderboard}/{{UserId}}", async (string UserId, ILeaderboardService Service) => Results.Ok(new LeaderboardRankResponse(await Service.GetRankAsync(UserId))));
    }
}
