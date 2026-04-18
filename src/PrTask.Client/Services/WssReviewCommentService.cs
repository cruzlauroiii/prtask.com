using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class WssReviewCommentService(ILocalStoreService Store) : IReviewCommentService
{
    public async Task<IReadOnlyList<ReviewComment>> ListByPullRequestAsync(string PullRequestId) =>
        (await Store.GetRecordsAsync<ReviewComment>(OpfsConstants.CollectionReviewComments))
            .Where(C => C.PullRequestId == PullRequestId).ToArray();

    public async Task<ReviewComment> CreateAsync(ReviewComment Comment)
    {
        await Store.SaveRecordAsync(OpfsConstants.CollectionReviewComments, Comment);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeCreateComment, Entity = Comment });
        return Comment;
    }

    public async Task ResolveAsync(string CommentId) =>
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeResolveComment, CommentId });

    public async Task DeleteAsync(string CommentId)
    {
        await Store.DeleteRecordAsync(OpfsConstants.CollectionReviewComments, CommentId);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeDeleteComment, CommentId });
    }
}
