using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record RepositoryDto(
    string Id, string OwnerId, string Url, string? Name,
    RepositoryVisibility Visibility, DateTime CreatedAt, DateTime UpdatedAt)
{
    public static RepositoryDto FromEntity(RepositoryEntity E) =>
        new(E.Id, E.OwnerId, E.Url, E.Name, E.Visibility, E.CreatedAt, E.UpdatedAt);
}
