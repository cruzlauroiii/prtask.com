using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Server.Endpoints;
public static class SprintEndpoints
{
    public static void MapSprintEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiSprints)
            .RequireAuthorization(PermissionConstants.ToPolicyName(PermissionConstants.ManageSprints));
        Group.MapGet(RouteConstants.SubRoot, async (ISprintService Service) =>
            Results.Ok((await Service.ListActiveAsync()).Select(SprintDto.FromEntity)));
        Group.MapGet(RouteConstants.SubSprintById, async (string SprintId, ISprintService Service) =>
            await Service.GetByIdAsync(SprintId) is { } Entity
                ? Results.Ok(SprintDto.FromEntity(Entity))
                : Results.NotFound());
        Group.MapGet(RouteConstants.SubByOwner, async (string OwnerId, ISprintService Service) =>
            Results.Ok((await Service.ListByOwnerAsync(OwnerId)).Select(SprintDto.FromEntity)));
        Group.MapPost(RouteConstants.SubRoot, async (CreateSprintRequest Request, ISprintService Service) =>
        {
            var Entity = new SprintEntity
            {
                Id = Guid.NewGuid().ToString(),
                Name = Request.Name,
                Goal = Request.Goal,
                OwnerId = Request.OwnerId,
                StartDate = Request.StartDate,
                EndDate = Request.EndDate
            };
            return Results.Created(
                FormatStrings.ApiResourcePath(RouteConstants.ApiSprints, Entity.Id),
                SprintDto.FromEntity(await Service.CreateAsync(Entity)));
        });
        Group.MapPatch(RouteConstants.SubSprintById, async (string SprintId, UpdateSprintRequest Request, ISprintService Service) =>
        {
            var Entity = await Service.GetByIdAsync(SprintId);
            if (Entity is null)
            {
                return Results.NotFound();
            }
            Entity.Name = Request.Name ?? Entity.Name;
            Entity.Goal = Request.Goal ?? Entity.Goal;
            Entity.Status = Request.Status ?? Entity.Status;
            Entity.StartDate = Request.StartDate ?? Entity.StartDate;
            Entity.EndDate = Request.EndDate ?? Entity.EndDate;
            return Results.Ok(SprintDto.FromEntity(await Service.UpdateAsync(Entity)));
        });
        Group.MapDelete(RouteConstants.SubSprintById, async (string SprintId, ISprintService Service) =>
        {
            await Service.DeleteAsync(SprintId);
            return Results.NoContent();
        });
    }
}
