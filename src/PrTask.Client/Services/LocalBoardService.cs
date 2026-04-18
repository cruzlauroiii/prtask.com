using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class LocalBoardService(ILocalStoreService Store) : IBoardService
{
    public async Task<BoardEntity?> GetByIdAsync(string BoardId) =>
        await Store.GetRecordAsync<BoardEntity>(OpfsConstants.CollectionBoards, BoardId);

    public async Task<IReadOnlyList<BoardEntity>> ListByOwnerAsync(string OwnerId)
    {
        var All = await Store.GetRecordsAsync<BoardEntity>(OpfsConstants.CollectionBoards);
        return All.Where(B => B.OwnerId == OwnerId).ToList();
    }

    public async Task<BoardEntity> CreateAsync(BoardEntity Entity)
    {
        await Store.SaveRecordAsync(OpfsConstants.CollectionBoards, Entity);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeCreateBoard, Entity });
        return Entity;
    }

    public async Task<BoardEntity> UpdateAsync(BoardEntity Entity)
    {
        Entity.UpdatedAt = DateTime.UtcNow;
        await Store.SaveRecordAsync(OpfsConstants.CollectionBoards, Entity);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeUpdateBoard, Entity });
        return Entity;
    }

    public async Task DeleteAsync(string BoardId)
    {
        await Store.DeleteRecordAsync(OpfsConstants.CollectionBoards, BoardId);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeDeleteBoard, BoardId });
    }

    public async Task<BoardColumnEntity?> GetColumnByIdAsync(string ColumnId) =>
        await Store.GetRecordAsync<BoardColumnEntity>(OpfsConstants.CollectionBoardColumns, ColumnId);

    public async Task<IReadOnlyList<BoardColumnEntity>> ListColumnsAsync(string BoardId)
    {
        var All = await Store.GetRecordsAsync<BoardColumnEntity>(OpfsConstants.CollectionBoardColumns);
        return All.Where(C => C.BoardId == BoardId).OrderBy(C => C.Order).ToList();
    }

    public async Task<BoardColumnEntity> CreateColumnAsync(BoardColumnEntity Entity)
    {
        await Store.SaveRecordAsync(OpfsConstants.CollectionBoardColumns, Entity);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeCreateColumn, Entity });
        return Entity;
    }

    public async Task<BoardColumnEntity> UpdateColumnAsync(BoardColumnEntity Entity)
    {
        await Store.SaveRecordAsync(OpfsConstants.CollectionBoardColumns, Entity);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeUpdateColumn, Entity });
        return Entity;
    }

    public async Task DeleteColumnAsync(string ColumnId)
    {
        await Store.DeleteRecordAsync(OpfsConstants.CollectionBoardColumns, ColumnId);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeDeleteColumn, ColumnId });
    }
}
