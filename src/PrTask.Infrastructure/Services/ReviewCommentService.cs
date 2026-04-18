using PrTask.Application.Services;
using PrTask.Domain.Models;
namespace PrTask.Infrastructure.Services;
public class ReviewCommentService : IReviewCommentService
{
    private static readonly List<ReviewComment> Store = [];
    public Task<IReadOnlyList<ReviewComment>> ListByPullRequestAsync(string PullRequestId) =>
        Task.FromResult<IReadOnlyList<ReviewComment>>(Store.Where(C => C.PullRequestId == PullRequestId).ToList());
    public Task<ReviewComment> CreateAsync(ReviewComment Comment)
    {
        Store.Add(Comment);
        return Task.FromResult(Comment);
    }
    public Task ResolveAsync(string CommentId)
    {
        foreach (var Comment in Store.Where(C => C.Id == CommentId))
        {
            Comment.IsResolved = true;
        }
        return Task.CompletedTask;
    }
    public Task DeleteAsync(string CommentId)
    {
        Store.RemoveAll(C => C.Id == CommentId);
        return Task.CompletedTask;
    }
}
