using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class LocalLeaderboardService(ILocalStoreService Store) : ILeaderboardService
{
    public async Task<int> GetRankAsync(string UserId)
    {
        var All = await Store.GetRecordsAsync<LeaderboardEntry>(OpfsConstants.CollectionLeaderboard);
        var Entry = All.FirstOrDefault(E => E.UserId == UserId);
        return Entry?.EarningsRank ?? 0;
    }

    public async Task<IReadOnlyList<LeaderboardEntry>> GetTopAsync(int Count)
    {
        var All = await Store.GetRecordsAsync<LeaderboardEntry>(OpfsConstants.CollectionLeaderboard);
        return All.OrderBy(E => E.EarningsRank).Take(Count).ToList();
    }

    public async Task<IReadOnlyList<LeaderboardEntry>> GetTopBySpendingAsync(int Count)
    {
        var All = await Store.GetRecordsAsync<LeaderboardEntry>(OpfsConstants.CollectionLeaderboard);
        return All.OrderBy(E => E.SpendingRank).Take(Count).ToList();
    }

    public async Task UpdateEntryAsync(UserEntity User, int PrsMerged, int ComplexityScoreSum) =>
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeUpdateLeaderboard, UserId = User.Id, PrsMerged, ComplexityScoreSum });
}
