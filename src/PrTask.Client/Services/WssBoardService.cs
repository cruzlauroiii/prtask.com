using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class WssBoardService(ILocalStoreService Store) : IBoardService
{
    public async Task<BoardEntity?> GetByIdAsync(string BoardId) =>
        await Store.GetRecordAsync<BoardEntity>(OpfsConstants.CollectionBoards, BoardId);

    public async Task<IReadOnlyList<BoardEntity>> ListByOwnerAsync(string OwnerId) =>
        (await Store.GetRecordsAsync<BoardEntity>(OpfsConstants.CollectionBoards))
            .Where(B => B.OwnerId == OwnerId).ToArray();

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

    public async Task<IReadOnlyList<BoardColumnEntity>> ListColumnsAsync(string BoardId) =>
        (await Store.GetRecordsAsync<BoardColumnEntity>(OpfsConstants.CollectionBoardColumns))
            .Where(C => C.BoardId == BoardId).ToArray();

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
