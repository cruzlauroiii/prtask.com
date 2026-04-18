using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class WssPullRequestService(ILocalStoreService Store) : IPullRequestService
{
    public async Task<bool> ExistsAsync(string PullRequestId) =>
        await Store.GetRecordAsync<PullRequestEntity>(OpfsConstants.CollectionPullRequests, PullRequestId) is not null;

    public async Task<PullRequestEntity?> GetByIdAsync(string PullRequestId) =>
        await Store.GetRecordAsync<PullRequestEntity>(OpfsConstants.CollectionPullRequests, PullRequestId);

    public async Task<IReadOnlyList<PullRequestEntity>> ListByDeveloperAsync(string DeveloperId) =>
        (await Store.GetRecordsAsync<PullRequestEntity>(OpfsConstants.CollectionPullRequests))
            .Where(P => P.DeveloperId == DeveloperId).ToArray();

    public async Task<IReadOnlyList<PullRequestEntity>> ListByTaskAsync(string TaskId) =>
        (await Store.GetRecordsAsync<PullRequestEntity>(OpfsConstants.CollectionPullRequests))
            .Where(P => P.TaskId == TaskId).ToArray();

    public async Task<IReadOnlyList<PullRequestEntity>> ListRecentAsync(int Count) =>
        (await Store.GetRecordsAsync<PullRequestEntity>(OpfsConstants.CollectionPullRequests))
            .OrderByDescending(P => P.SubmittedAt).Take(Count).ToArray();

    public async Task<PullRequestEntity> SubmitAsync(PullRequestEntity Entity)
    {
        await Store.SaveRecordAsync(OpfsConstants.CollectionPullRequests, Entity);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeSubmitPr, Entity });
        return Entity;
    }

    public async Task ApproveAsync(string PullRequestId) =>
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeApprovePr, PullRequestId });

    public async Task RejectAsync(string PullRequestId, string Notes) =>
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeRejectPr, PullRequestId, Notes });

    public async Task<PullRequestEntity> UpdateAsync(PullRequestEntity Entity)
    {
        await Store.SaveRecordAsync(OpfsConstants.CollectionPullRequests, Entity);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeUpdatePr, Entity });
        return Entity;
    }

    public async Task DeleteAsync(string PullRequestId)
    {
        await Store.DeleteRecordAsync(OpfsConstants.CollectionPullRequests, PullRequestId);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeDeletePr, PullRequestId });
    }
}
