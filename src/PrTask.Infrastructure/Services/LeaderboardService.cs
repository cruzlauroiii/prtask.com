using System.Collections.Concurrent;
using PrTask.Application.Services;
using PrTask.Domain.Models;
namespace PrTask.Infrastructure.Services;
public class LeaderboardService : ILeaderboardService
{
    private static readonly ConcurrentDictionary<string, LeaderboardEntry> Store = new(StringComparer.Ordinal);
    public Task<int> GetRankAsync(string UserId) =>
        Task.FromResult(GetRankedEntries().FindIndex(E => string.Equals(E.UserId, UserId, StringComparison.Ordinal)) + 1);
    public Task<IReadOnlyList<LeaderboardEntry>> GetTopAsync(int Count)
    {
        var Ranked = GetRankedEntries();
        for (var I = 0; I < Ranked.Count; I++)
        {
            Ranked[I].Rank = I + 1;
        }
        return Task.FromResult<IReadOnlyList<LeaderboardEntry>>(Ranked.Take(Count).ToList());
    }
    public Task<IReadOnlyList<LeaderboardEntry>> GetTopBySpendingAsync(int Count)
    {
        var Ranked = Store.Values.OrderByDescending(E => E.TotalSpentCents).ToList();
        for (var I = 0; I < Ranked.Count; I++)
        {
            Ranked[I].Rank = I + 1;
        }
        return Task.FromResult<IReadOnlyList<LeaderboardEntry>>(Ranked.Take(Count).ToList());
    }
    internal static void UpdateEntry(UserEntity User, int PrsMerged, int ComplexityScoreSum)
    {
        Store[User.Id] = new LeaderboardEntry
        {
            UserId = User.Id,
            GitHubUsername = User.GitHubUsername,
            AvatarUrl = User.AvatarUrl,
            PrsMerged = PrsMerged,
            TotalEarnedCents = User.TotalEarnedCents,
            ComplexityScoreSum = ComplexityScoreSum,
            Xp = User.Xp,
            Level = User.Level
        };
    }
    private static List<LeaderboardEntry> GetRankedEntries() =>
        [.. Store.Values
            .OrderByDescending(E => E.Xp)
            .ThenByDescending(E => E.PrsMerged)];
}
