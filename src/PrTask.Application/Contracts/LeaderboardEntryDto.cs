using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record LeaderboardEntryDto(
    string UserId, string GitHubUsername, string? AvatarUrl,
    int EarningsRank, int SpendingRank, int PrsMerged, int TasksPosted,
    long TotalEarnedCents, long TotalSpentCents, int ComplexityScoreSum)
{
    public static LeaderboardEntryDto FromEntity(LeaderboardEntry E) =>
        new(E.UserId, E.GitHubUsername, E.AvatarUrl, E.EarningsRank,
            E.SpendingRank, E.PrsMerged, E.TasksPosted, E.TotalEarnedCents,
            E.TotalSpentCents, E.ComplexityScoreSum);
}
