namespace PrTask.Application.Contracts;
public record CreateReviewCommentRequest(
    string PullRequestId, string AuthorId, string Body,
    string? FilePath, int? LineNumber, string? ParentCommentId);
