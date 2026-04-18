using PrTask.Application.Services;
using PrTask.Domain.Models;
namespace PrTask.Prerender;
public sealed class NoOpPullRequestService : IPullRequestService
{
    public Task<bool> ExistsAsync(string PullRequestId) => Task.FromResult(false);
    public Task<PullRequestEntity?> GetByIdAsync(string PullRequestId) => Task.FromResult<PullRequestEntity?>(null);
    public Task<IReadOnlyList<PullRequestEntity>> ListByDeveloperAsync(string DeveloperId) => Task.FromResult<IReadOnlyList<PullRequestEntity>>([]);
    public Task<PullRequestEntity> SubmitAsync(PullRequestEntity Entity) => Task.FromResult(Entity);
    public Task ApproveAsync(string PullRequestId) => Task.CompletedTask;
    public Task RejectAsync(string PullRequestId, string Notes) => Task.CompletedTask;
}
