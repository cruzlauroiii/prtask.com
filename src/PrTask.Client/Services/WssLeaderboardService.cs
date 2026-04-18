using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class WssLeaderboardService(ILocalStoreService Store) : ILeaderboardService
{
    public async Task<int> GetRankAsync(string UserId)
    {
        var All = await Store.GetRecordsAsync<LeaderboardEntry>(OpfsConstants.CollectionLeaderboard);
        var Sorted = All.OrderByDescending(E => E.TotalEarnedCents).ToArray();
        for (var I = 0; I < Sorted.Length; I++)
        {
            if (Sorted[I].UserId == UserId)
            {
                return I + 1;
            }
        }
        return 0;
    }

    public async Task<IReadOnlyList<LeaderboardEntry>> GetTopAsync(int Count) =>
        (await Store.GetRecordsAsync<LeaderboardEntry>(OpfsConstants.CollectionLeaderboard))
            .OrderByDescending(E => E.TotalEarnedCents).Take(Count).ToArray();

    public async Task<IReadOnlyList<LeaderboardEntry>> GetTopBySpendingAsync(int Count) =>
        (await Store.GetRecordsAsync<LeaderboardEntry>(OpfsConstants.CollectionLeaderboard))
            .OrderByDescending(E => E.TotalSpentCents).Take(Count).ToArray();

    public async Task UpdateEntryAsync(UserEntity User, int PrsMerged, int ComplexityScoreSum) =>
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeUpdateLeaderboard, UserId = User.Id, PrsMerged, ComplexityScoreSum });
}
