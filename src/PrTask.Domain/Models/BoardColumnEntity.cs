namespace PrTask.Domain.Models;
public class BoardColumnEntity
{
    public required string Id { get; init; }
    public required string BoardId { get; init; }
    public required string Name { get; set; }
    public int Order { get; set; }
    public int? WipLimit { get; set; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
}
