namespace PrTask.Domain.Models;
public class BoardEntity
{
    public required string Id { get; init; }
    public required string Name { get; set; }
    public required string OwnerId { get; init; }
    public BoardType Type { get; set; } = BoardType.Kanban;
    public string? SprintId { get; set; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
