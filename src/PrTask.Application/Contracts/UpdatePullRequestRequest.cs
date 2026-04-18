using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record UpdatePullRequestRequest(
    PullRequestStatus? Status, string? GitHubPrUrl, string? ReviewerNotes);
