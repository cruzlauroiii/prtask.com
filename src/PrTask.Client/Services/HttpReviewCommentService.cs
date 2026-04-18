using System.Net.Http.Json;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class HttpReviewCommentService(HttpClient Http) : IReviewCommentService
{
    public async Task<IReadOnlyList<ReviewComment>> ListByPullRequestAsync(string PullRequestId)
    {
        try
        {
            return await Http.GetFromJsonAsync<ReviewComment[]>(
                string.Format(RouteConstants.ApiReviewCommentsByPr, PullRequestId)) ?? [];
        }
        catch { return []; }
    }
    public async Task<ReviewComment> CreateAsync(ReviewComment Comment)
    {
        var Resp = await Http.PostAsJsonAsync(RouteConstants.ApiReviewComments, Comment);
        return await Resp.Content.ReadFromJsonAsync<ReviewComment>() ?? Comment;
    }
    public async Task ResolveAsync(string CommentId) =>
        await Http.PostAsync(string.Format(RouteConstants.ApiReviewCommentResolve, CommentId), null);
    public async Task DeleteAsync(string CommentId) =>
        await Http.DeleteAsync(string.Format(RouteConstants.ApiReviewCommentById, CommentId));
}
