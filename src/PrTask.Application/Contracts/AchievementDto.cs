using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record AchievementDto(string Id, string UserId, string BadgeType, DateTime EarnedAt)
{
    public static AchievementDto FromEntity(AchievementEntity E) =>
        new(E.Id, E.UserId, E.BadgeType, E.EarnedAt);
}
