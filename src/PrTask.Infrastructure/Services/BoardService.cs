using Microsoft.EntityFrameworkCore;
using PrTask.Application.Services;
using PrTask.Domain.Models;
using PrTask.Infrastructure.Data;
namespace PrTask.Infrastructure.Services;
public class BoardService(AppDbContext Db) : IBoardService
{
    public async Task<BoardEntity?> GetByIdAsync(string BoardId) =>
        await Db.Boards.FindAsync(BoardId);
    public async Task<IReadOnlyList<BoardEntity>> ListByOwnerAsync(string OwnerId) =>
        await Db.Boards
            .Where(B => B.OwnerId == OwnerId)
            .OrderByDescending(B => B.CreatedAt)
            .ToListAsync();
    public async Task<BoardEntity> CreateAsync(BoardEntity Entity)
    {
        Db.Boards.Add(Entity);
        await Db.SaveChangesAsync();
        return Entity;
    }
    public async Task<BoardEntity> UpdateAsync(BoardEntity Entity)
    {
        Entity.UpdatedAt = DateTime.UtcNow;
        Db.Boards.Update(Entity);
        await Db.SaveChangesAsync();
        return Entity;
    }
    public async Task DeleteAsync(string BoardId)
    {
        var Entity = await Db.Boards.FindAsync(BoardId);
        if (Entity is not null)
        {
            Db.Boards.Remove(Entity);
            await Db.SaveChangesAsync();
        }
    }
    public async Task<BoardColumnEntity?> GetColumnByIdAsync(string ColumnId) =>
        await Db.BoardColumns.FindAsync(ColumnId);
    public async Task<IReadOnlyList<BoardColumnEntity>> ListColumnsAsync(string BoardId) =>
        await Db.BoardColumns
            .Where(C => C.BoardId == BoardId)
            .OrderBy(C => C.Order)
            .ToListAsync();
    public async Task<BoardColumnEntity> CreateColumnAsync(BoardColumnEntity Entity)
    {
        Db.BoardColumns.Add(Entity);
        await Db.SaveChangesAsync();
        return Entity;
    }
    public async Task<BoardColumnEntity> UpdateColumnAsync(BoardColumnEntity Entity)
    {
        Db.BoardColumns.Update(Entity);
        await Db.SaveChangesAsync();
        return Entity;
    }
    public async Task DeleteColumnAsync(string ColumnId)
    {
        var Entity = await Db.BoardColumns.FindAsync(ColumnId);
        if (Entity is not null)
        {
            Db.BoardColumns.Remove(Entity);
            await Db.SaveChangesAsync();
        }
    }
}
