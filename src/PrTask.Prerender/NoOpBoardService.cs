using PrTask.Application.Services;
using PrTask.Domain.Models;
namespace PrTask.Prerender;
public sealed class NoOpBoardService : IBoardService
{
    public Task<BoardEntity?> GetByIdAsync(string BoardId) => Task.FromResult<BoardEntity?>(null);
    public Task<IReadOnlyList<BoardEntity>> ListByOwnerAsync(string OwnerId) => Task.FromResult<IReadOnlyList<BoardEntity>>([]);
    public Task<BoardEntity> CreateAsync(BoardEntity Entity) => Task.FromResult(Entity);
    public Task<BoardEntity> UpdateAsync(BoardEntity Entity) => Task.FromResult(Entity);
    public Task DeleteAsync(string BoardId) => Task.CompletedTask;
    public Task<BoardColumnEntity?> GetColumnByIdAsync(string ColumnId) => Task.FromResult<BoardColumnEntity?>(null);
    public Task<IReadOnlyList<BoardColumnEntity>> ListColumnsAsync(string BoardId) => Task.FromResult<IReadOnlyList<BoardColumnEntity>>([]);
    public Task<BoardColumnEntity> CreateColumnAsync(BoardColumnEntity Entity) => Task.FromResult(Entity);
    public Task<BoardColumnEntity> UpdateColumnAsync(BoardColumnEntity Entity) => Task.FromResult(Entity);
    public Task DeleteColumnAsync(string ColumnId) => Task.CompletedTask;
}
