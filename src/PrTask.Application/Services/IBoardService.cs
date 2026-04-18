using PrTask.Domain.Models;
namespace PrTask.Application.Services;
public interface IBoardService
{
    Task<BoardEntity?> GetByIdAsync(string BoardId);
    Task<IReadOnlyList<BoardEntity>> ListByOwnerAsync(string OwnerId);
    Task<BoardEntity> CreateAsync(BoardEntity Entity);
    Task<BoardEntity> UpdateAsync(BoardEntity Entity);
    Task DeleteAsync(string BoardId);
    Task<BoardColumnEntity?> GetColumnByIdAsync(string ColumnId);
    Task<IReadOnlyList<BoardColumnEntity>> ListColumnsAsync(string BoardId);
    Task<BoardColumnEntity> CreateColumnAsync(BoardColumnEntity Entity);
    Task<BoardColumnEntity> UpdateColumnAsync(BoardColumnEntity Entity);
    Task DeleteColumnAsync(string ColumnId);
}
