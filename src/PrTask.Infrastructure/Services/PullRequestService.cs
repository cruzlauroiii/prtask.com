using System.Collections.Concurrent;
using PrTask.Application.Services;
using PrTask.Domain.Models;
namespace PrTask.Infrastructure.Services;
public class PullRequestService : IPullRequestService
{
    private static readonly ConcurrentDictionary<string, PullRequestEntity> Store = new(StringComparer.Ordinal);
    public Task<bool> ExistsAsync(string PullRequestId) => Task.FromResult(Store.ContainsKey(PullRequestId));
    public Task<PullRequestEntity?> GetByIdAsync(string PullRequestId) =>
        Task.FromResult(Store.GetValueOrDefault(PullRequestId));
    public Task<IReadOnlyList<PullRequestEntity>> ListByDeveloperAsync(string DeveloperId) =>
        Task.FromResult<IReadOnlyList<PullRequestEntity>>(Store.Values
            .Where(Pr => string.Equals(Pr.DeveloperId, DeveloperId, StringComparison.Ordinal))
            .OrderByDescending(Pr => Pr.SubmittedAt)
            .ToList());
    public Task<PullRequestEntity> SubmitAsync(PullRequestEntity Entity)
    {
        Store[Entity.Id] = Entity;
        return Task.FromResult(Entity);
    }
    public Task ApproveAsync(string PullRequestId)
    {
        if (Store.TryGetValue(PullRequestId, out var Existing))
        {
            Existing.Status = PullRequestStatus.Approved;
            Existing.ReviewedAt = DateTime.UtcNow;
        }
        return Task.CompletedTask;
    }
    public Task RejectAsync(string PullRequestId, string Notes)
    {
        if (Store.TryGetValue(PullRequestId, out var Existing))
        {
            Existing.Status = PullRequestStatus.Rejected;
            Existing.ReviewerNotes = Notes;
            Existing.ReviewedAt = DateTime.UtcNow;
        }
        return Task.CompletedTask;
    }
}
