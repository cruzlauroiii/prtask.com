using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Server.Endpoints;
public static class RepositoryEndpoints
{
    public static void MapRepositoryEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiRepositories)
            .RequireAuthorization(PermissionConstants.ToPolicyName(PermissionConstants.ManageRepositories));
        Group.MapGet(RouteConstants.SubByOwner, async (string OwnerId, IRepositoryService Service) =>
            Results.Ok((await Service.ListByOwnerAsync(OwnerId)).Select(RepositoryDto.FromEntity)));
        Group.MapGet(RouteConstants.SubRepositoryById, async (string RepositoryId, IRepositoryService Service) =>
            await Service.GetByIdAsync(RepositoryId) is { } Entity
                ? Results.Ok(RepositoryDto.FromEntity(Entity))
                : Results.NotFound());
        Group.MapPost(RouteConstants.SubRoot, async (CreateRepositoryRequest Request, IRepositoryService Service) =>
        {
            var Entity = new RepositoryEntity
            {
                Id = Guid.NewGuid().ToString(),
                OwnerId = Request.OwnerId,
                Url = Request.Url,
                Name = Request.Name ?? ExtractRepoName(Request.Url),
                Visibility = Request.Visibility
            };
            return Results.Created(
                FormatStrings.ApiResourcePath(RouteConstants.ApiRepositories, Entity.Id),
                RepositoryDto.FromEntity(await Service.CreateAsync(Entity)));
        });
        Group.MapPatch(RouteConstants.SubRepositoryById, async (
            string RepositoryId, UpdateRepositoryRequest Request, IRepositoryService Service) =>
        {
            var Entity = await Service.GetByIdAsync(RepositoryId);
            if (Entity is null)
            {
                return Results.NotFound();
            }
            if (Request.Url is not null)
            {
                Entity.Url = Request.Url;
            }
            if (Request.Name is not null)
            {
                Entity.Name = Request.Name;
            }
            if (Request.Visibility.HasValue)
            {
                Entity.Visibility = Request.Visibility.Value;
            }
            return Results.Ok(RepositoryDto.FromEntity(await Service.UpdateAsync(Entity)));
        });
        Group.MapDelete(RouteConstants.SubRepositoryById, async (string RepositoryId, IRepositoryService Service) =>
        {
            await Service.DeleteAsync(RepositoryId);
            return Results.NoContent();
        });
    }
    private static string ExtractRepoName(string Url)
    {
        var Segments = Url.TrimEnd('/').Split('/');
        return Segments.Length > 0 ? Segments[^1] : Url;
    }
}
