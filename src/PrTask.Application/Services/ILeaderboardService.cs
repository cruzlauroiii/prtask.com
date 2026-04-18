using PrTask.Domain.Models;
namespace PrTask.Application.Services;
public interface ILeaderboardService
{
    Task<int> GetRankAsync(string UserId);
    Task<IReadOnlyList<LeaderboardEntry>> GetTopAsync(int Count);
    Task<IReadOnlyList<LeaderboardEntry>> GetTopBySpendingAsync(int Count);
}
