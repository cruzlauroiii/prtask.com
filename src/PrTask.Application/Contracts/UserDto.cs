using PrTask.Domain.Models;
namespace PrTask.Application.Contracts;
public record UserDto(
    string Id, long GitHubId, string GitHubUsername, string? DisplayName,
    string? AvatarUrl, string? Email, UserRole Role, string? MayaCustomerId,
    long TotalEarnedCents, long TotalSpentCents,
    KycStatus KycStatus, DateTime? KycVerifiedAt,
    DateTime CreatedAt, DateTime UpdatedAt)
{
    public static UserDto FromEntity(UserEntity E) =>
        new(E.Id, E.GitHubId, E.GitHubUsername, E.DisplayName, E.AvatarUrl,
            E.Email, E.Role, E.MayaCustomerId, E.TotalEarnedCents,
            E.TotalSpentCents, E.KycStatus, E.KycVerifiedAt,
            E.CreatedAt, E.UpdatedAt);
}
