using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Server.Endpoints;
public static class TaskEndpoints
{
    public static void MapTaskEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiTasks);
        Group.MapGet("/", async (ITaskService Service) => Results.Ok(await Service.ListOpenAsync()));
        Group.MapGet("/{TaskId}", async (string TaskId, ITaskService Service) =>
            await Service.GetByIdAsync(TaskId) is { } Entity ? Results.Ok(Entity) : Results.NotFound());
        Group.MapPost("/", async (TaskEntity Entity, ITaskService Service) =>
            Results.Created($"{RouteConstants.ApiTasks}/{Entity.Id}", await Service.CreateAsync(Entity)))
            .RequireAuthorization();
        Group.MapPost("/{TaskId}/claim", async (string TaskId, ClaimTaskRequest Request, ITaskService Service) =>
        {
            await Service.ClaimAsync(TaskId, Request.DeveloperId);
            return Results.Ok();
        }).RequireAuthorization();
    }
}
