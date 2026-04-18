using System.Net.Http.Json;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class HttpBoardService(HttpClient Http) : IBoardService
{
    public async Task<BoardEntity?> GetByIdAsync(string BoardId)
    {
        try { return await Http.GetFromJsonAsync<BoardEntity>(FormatStrings.ApiResourcePath(RouteConstants.ApiBoards, BoardId)); }
        catch { return null; }
    }
    public async Task<IReadOnlyList<BoardEntity>> ListByOwnerAsync(string OwnerId)
    {
        try { return await Http.GetFromJsonAsync<BoardEntity[]>(FormatStrings.OwnerPath(RouteConstants.ApiBoards, OwnerId)) ?? []; }
        catch { return []; }
    }
    public async Task<BoardEntity> CreateAsync(BoardEntity Entity)
    {
        var Resp = await Http.PostAsJsonAsync(RouteConstants.ApiBoards, Entity);
        return await Resp.Content.ReadFromJsonAsync<BoardEntity>() ?? Entity;
    }
    public async Task<BoardEntity> UpdateAsync(BoardEntity Entity)
    {
        await Http.PatchAsJsonAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiBoards, Entity.Id), Entity);
        return Entity;
    }
    public async Task DeleteAsync(string BoardId) =>
        await Http.DeleteAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiBoards, BoardId));
    public async Task<BoardColumnEntity?> GetColumnByIdAsync(string ColumnId)
    {
        try { return await Http.GetFromJsonAsync<BoardColumnEntity>(FormatStrings.ApiResourcePath(RouteConstants.ApiBoards, ColumnId)); }
        catch { return null; }
    }
    public async Task<IReadOnlyList<BoardColumnEntity>> ListColumnsAsync(string BoardId)
    {
        try { return await Http.GetFromJsonAsync<BoardColumnEntity[]>(FormatStrings.ColumnPath(RouteConstants.ApiBoards, BoardId)) ?? []; }
        catch { return []; }
    }
    public async Task<BoardColumnEntity> CreateColumnAsync(BoardColumnEntity Entity)
    {
        var Resp = await Http.PostAsJsonAsync(FormatStrings.ColumnPath(RouteConstants.ApiBoards, Entity.BoardId), Entity);
        return await Resp.Content.ReadFromJsonAsync<BoardColumnEntity>() ?? Entity;
    }
    public async Task<BoardColumnEntity> UpdateColumnAsync(BoardColumnEntity Entity)
    {
        await Http.PatchAsJsonAsync(FormatStrings.ColumnItemPath(RouteConstants.ApiBoards, Entity.BoardId, Entity.Id), Entity);
        return Entity;
    }
    public async Task DeleteColumnAsync(string ColumnId) =>
        await Http.DeleteAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiBoards, ColumnId));
}
