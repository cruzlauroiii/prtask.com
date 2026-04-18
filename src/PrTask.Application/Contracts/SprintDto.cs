using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record SprintDto(
    string Id, string Name, string? Goal, string OwnerId,
    SprintStatus Status, DateTime StartDate, DateTime EndDate,
    DateTime CreatedAt, DateTime UpdatedAt)
{
    public static SprintDto FromEntity(SprintEntity E) =>
        new(E.Id, E.Name, E.Goal, E.OwnerId, E.Status,
            E.StartDate, E.EndDate, E.CreatedAt, E.UpdatedAt);
}
