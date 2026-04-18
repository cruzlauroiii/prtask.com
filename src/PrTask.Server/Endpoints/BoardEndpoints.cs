using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Server.Endpoints;
public static class BoardEndpoints
{
    public static void MapBoardEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiBoards)
            .RequireAuthorization(PermissionConstants.ToPolicyName(PermissionConstants.ManageBoards));
        Group.MapGet(RouteConstants.SubByOwner, async (string OwnerId, IBoardService Service) =>
            Results.Ok((await Service.ListByOwnerAsync(OwnerId)).Select(BoardDto.FromEntity)));
        Group.MapGet(RouteConstants.SubBoardById, async (string BoardId, IBoardService Service) =>
            await Service.GetByIdAsync(BoardId) is { } Entity
                ? Results.Ok(BoardDto.FromEntity(Entity))
                : Results.NotFound());
        Group.MapPost(RouteConstants.SubRoot, async (CreateBoardRequest Request, IBoardService Service) =>
        {
            var Entity = new BoardEntity
            {
                Id = Guid.NewGuid().ToString(),
                Name = Request.Name,
                OwnerId = Request.OwnerId,
                Type = Request.Type,
                SprintId = Request.SprintId
            };
            return Results.Created(
                FormatStrings.ApiResourcePath(RouteConstants.ApiBoards, Entity.Id),
                BoardDto.FromEntity(await Service.CreateAsync(Entity)));
        });
        Group.MapPut(RouteConstants.SubBoardById, async (string BoardId, UpdateBoardRequest Request, IBoardService Service) =>
        {
            var Existing = await Service.GetByIdAsync(BoardId);
            if (Existing is null)
            {
                return Results.NotFound();
            }
            Existing.Name = Request.Name;
            Existing.Type = Request.Type;
            Existing.SprintId = Request.SprintId;
            var Updated = await Service.UpdateAsync(Existing);
            return Results.Ok(BoardDto.FromEntity(Updated));
        });
        Group.MapDelete(RouteConstants.SubBoardById, async (string BoardId, IBoardService Service) =>
        {
            await Service.DeleteAsync(BoardId);
            return Results.NoContent();
        });
        Group.MapGet(RouteConstants.SubColumns, async (string BoardId, IBoardService Service) =>
            Results.Ok((await Service.ListColumnsAsync(BoardId)).Select(BoardColumnDto.FromEntity)));
        Group.MapPost(RouteConstants.SubColumns, async (string BoardId, CreateBoardColumnRequest Request, IBoardService Service) =>
        {
            var Entity = new BoardColumnEntity
            {
                Id = Guid.NewGuid().ToString(),
                BoardId = BoardId,
                Name = Request.Name,
                Order = Request.Order,
                WipLimit = Request.WipLimit
            };
            return Results.Created(
                FormatStrings.ApiResourcePath(RouteConstants.ApiBoards, Entity.Id),
                BoardColumnDto.FromEntity(await Service.CreateColumnAsync(Entity)));
        });
        Group.MapPut(RouteConstants.SubColumnById, async (string BoardId, string ColumnId, UpdateBoardColumnRequest Request, IBoardService Service) =>
        {
            var Existing = await Service.GetColumnByIdAsync(ColumnId);
            if (Existing is null)
            {
                return Results.NotFound();
            }
            Existing.Name = Request.Name;
            Existing.Order = Request.Order;
            Existing.WipLimit = Request.WipLimit;
            var Updated = await Service.UpdateColumnAsync(Existing);
            return Results.Ok(BoardColumnDto.FromEntity(Updated));
        });
        Group.MapDelete(RouteConstants.SubColumnById, async (string BoardId, string ColumnId, IBoardService Service) =>
        {
            await Service.DeleteColumnAsync(ColumnId);
            return Results.NoContent();
        });
    }
}
