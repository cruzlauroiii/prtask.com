namespace PrTask.Domain.Models;
public class LeaderboardEntry
{
    public required string UserId { get; init; }
    public required string GitHubUsername { get; init; }
    public string? AvatarUrl { get; set; }
    public int Rank { get; set; }
    public int PrsMerged { get; set; }
    public long TotalEarnedCents { get; set; }
    public int ComplexityScoreSum { get; set; }
    public int Xp { get; set; }
    public int Level { get; set; }
    public int EarningsRank { get; set; }
    public int SpendingRank { get; set; }
    public int TasksPosted { get; set; }
    public long TotalSpentCents { get; set; }
}
