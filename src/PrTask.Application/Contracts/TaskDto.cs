using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record TaskDto(
    string Id, string ClientId, string Title, string Description, string RepoUrl,
    TaskComplexity Complexity, long BountyAmountCents, PrTaskStatus Status,
    int MaxClaims, string[]? Tags, DateTime? Deadline, string? PaymentId,
    WorkItemType WorkItemType, string? ParentId, string? SprintId,
    string? BoardColumnId, int Priority,
    DateTime CreatedAt, DateTime UpdatedAt)
{
    public static TaskDto FromEntity(TaskEntity E) =>
        new(E.Id, E.ClientId, E.Title, E.Description, E.RepoUrl, E.Complexity,
            E.BountyAmountCents, E.Status, E.MaxClaims, E.Tags, E.Deadline,
            E.PaymentId, E.WorkItemType, E.ParentId, E.SprintId,
            E.BoardColumnId, E.Priority, E.CreatedAt, E.UpdatedAt);
}
