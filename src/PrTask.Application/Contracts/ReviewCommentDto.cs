using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record ReviewCommentDto(
    string Id, string PullRequestId, string AuthorId,
    string? FilePath, int? LineNumber, string Body,
    string? ParentCommentId, bool IsResolved, DateTime CreatedAt)
{
    public static ReviewCommentDto FromEntity(ReviewComment E) =>
        new(E.Id, E.PullRequestId, E.AuthorId, E.FilePath, E.LineNumber,
            E.Body, E.ParentCommentId, E.IsResolved, E.CreatedAt);
}
