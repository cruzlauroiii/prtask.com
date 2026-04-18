using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Server.Endpoints;
public static class AuditEndpoints
{
    public static void MapAuditEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiAuditLogs)
            .RequireAuthorization(PermissionConstants.ToPolicyName(PermissionConstants.ViewAuditLogs));
        Group.MapGet(RouteConstants.SubRoot, async (int? Page, int? PageSize, IAuditService Service) =>
        {
            var ResolvedPage = Page ?? AuditConstants.FirstPage;
            var ResolvedPageSize = PageSize ?? AuditConstants.DefaultPageSize;
            var Items = await Service.ListRecentAsync(ResolvedPage, ResolvedPageSize);
            var TotalCount = await Service.CountAsync();
            return Results.Ok(new { Items = Items.Select(AuditLogDto.FromEntity), TotalCount });
        });
        Group.MapGet(RouteConstants.SubAuditLogById, async (string AuditLogId, IAuditService Service) =>
            await Service.GetByIdAsync(AuditLogId) is { } Entity
                ? Results.Ok(AuditLogDto.FromEntity(Entity))
                : Results.NotFound());
        Group.MapGet(RouteConstants.SubByEntity, async (string EntityType, string EntityId, IAuditService Service) =>
            Results.Ok((await Service.ListByEntityAsync(EntityType, EntityId)).Select(AuditLogDto.FromEntity)));
        Group.MapGet(RouteConstants.SubByUser, async (string UserId, IAuditService Service) =>
            Results.Ok((await Service.ListByUserAsync(UserId)).Select(AuditLogDto.FromEntity)));
    }
}
