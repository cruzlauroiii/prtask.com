using PrTask.Domain.Models;
namespace PrTask.Application.Services;
public interface IPullRequestService
{
    Task<bool> ExistsAsync(string PullRequestId);
    Task<PullRequestEntity?> GetByIdAsync(string PullRequestId);
    Task<IReadOnlyList<PullRequestEntity>> ListByDeveloperAsync(string DeveloperId);
    Task<PullRequestEntity> SubmitAsync(PullRequestEntity Entity);
    Task ApproveAsync(string PullRequestId);
    Task RejectAsync(string PullRequestId, string Notes);
}
