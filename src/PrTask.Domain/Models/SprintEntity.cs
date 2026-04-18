namespace PrTask.Domain.Models;
public class SprintEntity
{
    public required string Id { get; init; }
    public required string Name { get; set; }
    public string? Goal { get; set; }
    public required string OwnerId { get; init; }
    public SprintStatus Status { get; set; } = SprintStatus.Planned;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
