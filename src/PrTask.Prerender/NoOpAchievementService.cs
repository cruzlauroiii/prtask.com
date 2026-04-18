using PrTask.Application.Services;
using PrTask.Domain.Models;
namespace PrTask.Prerender;
public sealed class NoOpAchievementService : IAchievementService
{
    public Task<IReadOnlyList<AchievementEntity>> GetByUserAsync(string UserId) => Task.FromResult<IReadOnlyList<AchievementEntity>>([]);
    public Task EvaluateAndAwardBadgesAsync(string UserId, int TotalPrsMerged, long TotalEarnedCents, int StreakDays, int LeaderboardRank) => Task.CompletedTask;
}
