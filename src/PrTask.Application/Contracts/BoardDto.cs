using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record BoardDto(
    string Id, string Name, string OwnerId, BoardType Type,
    string? SprintId, DateTime CreatedAt, DateTime UpdatedAt)
{
    public static BoardDto FromEntity(BoardEntity E) =>
        new(E.Id, E.Name, E.OwnerId, E.Type, E.SprintId,
            E.CreatedAt, E.UpdatedAt);
}
