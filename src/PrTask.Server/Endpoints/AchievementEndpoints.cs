using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class AchievementEndpoints
{
    public static void MapAchievementEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiAchievements);
        Group.MapGet(RouteConstants.SubUserById, async (string UserId, IAchievementService Service) =>
            Results.Ok((await Service.GetByUserAsync(UserId)).Select(AchievementDto.FromEntity)));
    }
}
