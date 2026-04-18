using PrTask.Domain.Models;
namespace PrTask.Application.Services;
public interface IReviewCommentService
{
    Task<IReadOnlyList<ReviewComment>> ListByPullRequestAsync(string PullRequestId);
    Task<ReviewComment> CreateAsync(ReviewComment Comment);
    Task ResolveAsync(string CommentId);
    Task DeleteAsync(string CommentId);
}
