using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record UpdateTaskRequest(
    string? Title, string? Description, string? RepoUrl,
    TaskComplexity? Complexity, long? BountyAmountCents, PrTaskStatus? Status,
    int? MaxClaims, string[]? Tags, DateTime? Deadline);
