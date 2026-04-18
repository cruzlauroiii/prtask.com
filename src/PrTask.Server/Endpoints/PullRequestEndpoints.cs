using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Server.Endpoints;
public static class PullRequestEndpoints
{
    public static void MapPullRequestEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiPullRequests);
        Group.MapGet("/{PullRequestId}", async (string PullRequestId, IPullRequestService Service) =>
            await Service.GetByIdAsync(PullRequestId) is { } Entity ? Results.Ok(Entity) : Results.NotFound());
        Group.MapGet("/developer/{DeveloperId}", async (string DeveloperId, IPullRequestService Service) =>
            Results.Ok(await Service.ListByDeveloperAsync(DeveloperId)));
        Group.MapPost("/", async (PullRequestEntity Entity, IPullRequestService Service) =>
            Results.Created($"{RouteConstants.ApiPullRequests}/{Entity.Id}", await Service.SubmitAsync(Entity)))
            .RequireAuthorization();
        Group.MapPost("/{PullRequestId}/approve", async (string PullRequestId, IPullRequestService Service) =>
        {
            await Service.ApproveAsync(PullRequestId);
            return Results.Ok();
        }).RequireAuthorization();
        Group.MapPost("/{PullRequestId}/reject", async (string PullRequestId, RejectPullRequestRequest Request, IPullRequestService Service) =>
        {
            await Service.RejectAsync(PullRequestId, Request.Notes);
            return Results.Ok();
        }).RequireAuthorization();
    }
}
