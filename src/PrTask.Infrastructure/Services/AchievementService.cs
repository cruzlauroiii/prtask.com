using System.Collections.Concurrent;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Infrastructure.Services;
public class AchievementService : IAchievementService
{
    private static readonly ConcurrentDictionary<string, List<AchievementEntity>> Store = new(StringComparer.Ordinal);
    public Task<IReadOnlyList<AchievementEntity>> GetByUserAsync(string UserId) =>
        Task.FromResult<IReadOnlyList<AchievementEntity>>(Store.GetValueOrDefault(UserId) ?? []);
    public Task EvaluateAndAwardBadgesAsync(string UserId, int TotalPrsMerged, long TotalEarnedCents, int StreakDays, int LeaderboardRank)
    {
        var EligibleBadges = DetermineEligibleBadges(TotalPrsMerged, TotalEarnedCents, StreakDays, LeaderboardRank);
        var Existing = Store.GetOrAdd(UserId, _ => []);
        var ExistingTypes = new HashSet<string>(Existing.Select(A => A.BadgeType), StringComparer.Ordinal);
        foreach (var BadgeType in EligibleBadges.Where(B => !ExistingTypes.Contains(B)))
        {
            Existing.Add(new AchievementEntity
            {
                Id = Guid.NewGuid().ToString(),
                UserId = UserId,
                BadgeType = BadgeType
            });
        }
        return Task.CompletedTask;
    }
    internal static List<string> DetermineEligibleBadges(int TotalPrsMerged, long TotalEarnedCents, int StreakDays, int LeaderboardRank)
    {
        var Badges = new List<string>();
        if (TotalPrsMerged >= BadgeConstants.FirstPrThreshold)
        {
            Badges.Add(BadgeConstants.FirstPrMerged);
        }
        if (TotalPrsMerged >= BadgeConstants.TenPrsThreshold)
        {
            Badges.Add(BadgeConstants.TenPrsMerged);
        }
        if (TotalPrsMerged >= BadgeConstants.FiftyPrsThreshold)
        {
            Badges.Add(BadgeConstants.FiftyPrsMerged);
        }
        if (TotalPrsMerged >= BadgeConstants.HundredPrsThreshold)
        {
            Badges.Add(BadgeConstants.HundredPrsMerged);
        }
        if (TotalEarnedCents >= BadgeConstants.ThousandPhpThreshold)
        {
            Badges.Add(BadgeConstants.ThousandPhpEarned);
        }
        if (TotalEarnedCents >= BadgeConstants.TenThousandPhpThreshold)
        {
            Badges.Add(BadgeConstants.TenThousandPhpEarned);
        }
        if (StreakDays >= BadgeConstants.WeekStreakThreshold)
        {
            Badges.Add(BadgeConstants.WeekStreak);
        }
        if (StreakDays >= BadgeConstants.MonthStreakThreshold)
        {
            Badges.Add(BadgeConstants.MonthStreak);
        }
        if (LeaderboardRank is > 0 and <= BadgeConstants.TopTenThreshold)
        {
            Badges.Add(BadgeConstants.TopTenLeaderboard);
        }
        return Badges;
    }
}
