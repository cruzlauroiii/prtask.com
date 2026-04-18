namespace PrTask.Domain.Models;
public class RepositoryEntity
{
    public required string Id { get; init; }
    public required string OwnerId { get; init; }
    public required string Url { get; set; }
    public string? Name { get; set; }
    public RepositoryVisibility Visibility { get; set; } = RepositoryVisibility.Public;
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
