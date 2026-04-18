using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record CreateTaskRequest(
    string ClientId, string Title, string Description, string RepoUrl,
    TaskComplexity Complexity, long BountyAmountCents, int MaxClaims,
    string[]? Tags, DateTime? Deadline);
