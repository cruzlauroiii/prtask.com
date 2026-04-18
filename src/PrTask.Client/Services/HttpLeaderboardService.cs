using System.Net.Http.Json;
using PrTask.Application.Contracts;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class HttpLeaderboardService(HttpClient Http) : ILeaderboardService
{
    public async Task<int> GetRankAsync(string UserId)
    {
        try
        {
            var Resp = await Http.GetFromJsonAsync<LeaderboardRankResponse>(
                FormatStrings.ApiResourcePath(RouteConstants.ApiLeaderboard, UserId));
            return Resp?.Rank ?? 0;
        }
        catch { return 0; }
    }
    public async Task<IReadOnlyList<LeaderboardEntry>> GetTopAsync(int Count)
    {
        try { return await Http.GetFromJsonAsync<LeaderboardEntry[]>(RouteConstants.ApiLeaderboard) ?? []; }
        catch { return []; }
    }
    public async Task<IReadOnlyList<LeaderboardEntry>> GetTopBySpendingAsync(int Count)
    {
        try
        {
            return await Http.GetFromJsonAsync<LeaderboardEntry[]>(
                RouteConstants.ApiLeaderboard + RouteConstants.SubLeaderboardSpending) ?? [];
        }
        catch { return []; }
    }
    public Task UpdateEntryAsync(UserEntity User, int PrsMerged, int ComplexityScoreSum) =>
        Task.CompletedTask;
}
