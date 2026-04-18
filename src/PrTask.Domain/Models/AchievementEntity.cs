namespace PrTask.Domain.Models;
public class AchievementEntity
{
    public required string Id { get; init; }
    public required string UserId { get; init; }
    public required string BadgeType { get; init; }
    public DateTime EarnedAt { get; init; } = DateTime.UtcNow;
}
