namespace PrTask.Application.Contracts;
public record SubmitPullRequestRequest(string TaskId, string DeveloperId, string? GitHubPrUrl);
