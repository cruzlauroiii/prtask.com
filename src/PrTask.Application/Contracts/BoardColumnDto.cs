using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record BoardColumnDto(string Id, string BoardId, string Name, int Order, int? WipLimit, DateTime CreatedAt)
{
    public static BoardColumnDto FromEntity(BoardColumnEntity E) =>
        new(E.Id, E.BoardId, E.Name, E.Order, E.WipLimit, E.CreatedAt);
}
