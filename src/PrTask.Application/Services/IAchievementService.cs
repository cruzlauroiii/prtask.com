using PrTask.Domain.Models;
namespace PrTask.Application.Services;
public interface IAchievementService
{
    Task<IReadOnlyList<AchievementEntity>> GetByUserAsync(string UserId);
    Task EvaluateAndAwardBadgesAsync(string UserId, int TotalPrsMerged, long TotalEarnedCents, int StreakDays, int LeaderboardRank);
}
