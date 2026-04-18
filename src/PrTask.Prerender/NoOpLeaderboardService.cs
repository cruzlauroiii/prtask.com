using PrTask.Application.Services;
using PrTask.Domain.Models;
namespace PrTask.Prerender;
public sealed class NoOpLeaderboardService : ILeaderboardService
{
    public Task<int> GetRankAsync(string UserId) => Task.FromResult(0);
    public Task<IReadOnlyList<LeaderboardEntry>> GetTopAsync(int Count) => Task.FromResult<IReadOnlyList<LeaderboardEntry>>([]);
    public Task<IReadOnlyList<LeaderboardEntry>> GetTopBySpendingAsync(int Count) => Task.FromResult<IReadOnlyList<LeaderboardEntry>>([]);
}
