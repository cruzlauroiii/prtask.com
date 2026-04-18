using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class LocalPullRequestService(ILocalStoreService Store) : IPullRequestService
{
    public async Task<bool> ExistsAsync(string PullRequestId) =>
        await Store.GetRecordAsync<PullRequestEntity>(OpfsConstants.CollectionPullRequests, PullRequestId) is not null;

    public async Task<PullRequestEntity?> GetByIdAsync(string PullRequestId) =>
        await Store.GetRecordAsync<PullRequestEntity>(OpfsConstants.CollectionPullRequests, PullRequestId);

    public async Task<IReadOnlyList<PullRequestEntity>> ListByDeveloperAsync(string DeveloperId)
    {
        var All = await Store.GetRecordsAsync<PullRequestEntity>(OpfsConstants.CollectionPullRequests);
        return All.Where(P => P.DeveloperId == DeveloperId).ToList();
    }

    public async Task<IReadOnlyList<PullRequestEntity>> ListRecentAsync(int Count)
    {
        var All = await Store.GetRecordsAsync<PullRequestEntity>(OpfsConstants.CollectionPullRequests);
        return All.OrderByDescending(P => P.SubmittedAt).Take(Count).ToList();
    }

    public async Task<IReadOnlyList<PullRequestEntity>> ListByTaskAsync(string TaskId)
    {
        var All = await Store.GetRecordsAsync<PullRequestEntity>(OpfsConstants.CollectionPullRequests);
        return All.Where(P => P.TaskId == TaskId).ToList();
    }

    public async Task<PullRequestEntity> SubmitAsync(PullRequestEntity Entity)
    {
        await Store.SaveRecordAsync(OpfsConstants.CollectionPullRequests, Entity);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeSubmitPr, Entity });
        return Entity;
    }

    public async Task ApproveAsync(string PullRequestId)
    {
        var Entity = await GetByIdAsync(PullRequestId);
        if (Entity is not null)
        {
            Entity.Status = PullRequestStatus.Approved;
            Entity.ReviewedAt = DateTime.UtcNow;
            await Store.SaveRecordAsync(OpfsConstants.CollectionPullRequests, Entity);
        }
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeApprovePr, PullRequestId });
    }

    public async Task RejectAsync(string PullRequestId, string Notes)
    {
        var Entity = await GetByIdAsync(PullRequestId);
        if (Entity is not null)
        {
            Entity.Status = PullRequestStatus.Rejected;
            Entity.ReviewerNotes = Notes;
            Entity.ReviewedAt = DateTime.UtcNow;
            await Store.SaveRecordAsync(OpfsConstants.CollectionPullRequests, Entity);
        }
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeRejectPr, PullRequestId, Notes });
    }

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
