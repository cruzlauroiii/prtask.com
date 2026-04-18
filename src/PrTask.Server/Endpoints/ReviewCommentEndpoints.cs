using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Server.Endpoints;
public static class ReviewCommentEndpoints
{
    public static void MapReviewCommentEndpoints(this IEndpointRouteBuilder Routes)
    {
        var Group = Routes.MapGroup(RouteConstants.ApiReviewComments);
        Group.MapGet(RouteConstants.SubReviewCommentsByPr, async (string PullRequestId, IReviewCommentService Service) =>
            Results.Ok((await Service.ListByPullRequestAsync(PullRequestId)).Select(ReviewCommentDto.FromEntity)));
        Group.MapPost(RouteConstants.SubRoot, async (CreateReviewCommentRequest Request, IReviewCommentService Service) =>
        {
            var Entity = new ReviewComment
            {
                Id = Guid.NewGuid().ToString(),
                PullRequestId = Request.PullRequestId,
                AuthorId = Request.AuthorId,
                Body = Request.Body,
                FilePath = Request.FilePath ?? string.Empty,
                LineNumber = Request.LineNumber ?? 0,
                ParentCommentId = Request.ParentCommentId
            };
            return Results.Created(
                FormatStrings.ApiResourcePath(RouteConstants.ApiReviewComments, Entity.Id),
                ReviewCommentDto.FromEntity(await Service.CreateAsync(Entity)));
        }).RequireAuthorization();
        Group.MapPost(RouteConstants.SubReviewCommentResolve, async (string CommentId, IReviewCommentService Service) =>
        {
            await Service.ResolveAsync(CommentId);
            return Results.Ok();
        }).RequireAuthorization();
        Group.MapDelete(RouteConstants.SubReviewCommentById, async (string CommentId, IReviewCommentService Service) =>
        {
            await Service.DeleteAsync(CommentId);
            return Results.NoContent();
        }).RequireAuthorization();
    }
}
