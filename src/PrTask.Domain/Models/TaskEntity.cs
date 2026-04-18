namespace PrTask.Domain.Models;
public class TaskEntity
{
    public required string Id { get; init; }
    public required string ClientId { get; init; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required string RepoUrl { get; set; }
    public TaskComplexity Complexity { get; set; } = TaskComplexity.Medium;
    public long BountyAmountCents { get; set; }
    public PrTaskStatus Status { get; set; } = PrTaskStatus.Open;
    public int MaxClaims { get; set; } = 1;
    public string[]? Tags { get; set; }
    public DateTime? Deadline { get; set; }
    public string? PaymentId { get; set; }
    public WorkItemType WorkItemType { get; set; } = WorkItemType.Task;
    public string? ParentId { get; set; }
    public string? SprintId { get; set; }
    public string? BoardColumnId { get; set; }
    public int Priority { get; set; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
