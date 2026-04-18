using System.Collections.Concurrent;
using PrTask.Application.Services;
using PrTask.Domain.Models;
namespace PrTask.Infrastructure.Services;
public class UserService : IUserService
{
    private static readonly ConcurrentDictionary<string, UserEntity> StoreById = new(StringComparer.Ordinal);
    private static readonly ConcurrentDictionary<long, string> GitHubIdIndex = [];
    private static readonly ConcurrentDictionary<string, string> OidcIndex = new(StringComparer.Ordinal);
    public Task<UserEntity?> GetByIdAsync(string UserId) =>
        Task.FromResult(StoreById.GetValueOrDefault(UserId));
    public Task<UserEntity?> GetByGitHubIdAsync(long GitHubId) =>
        Task.FromResult(GitHubIdIndex.TryGetValue(GitHubId, out var UserId) ? StoreById.GetValueOrDefault(UserId) : null);
    public Task<UserEntity> CreateOrUpdateFromGitHubAsync(long GitHubId, string Username, string? DisplayName, string? AvatarUrl, string? Email)
    {
        if (GitHubIdIndex.TryGetValue(GitHubId, out var ExistingId) && StoreById.TryGetValue(ExistingId, out var Existing))
        {
            Existing.DisplayName = DisplayName;
            Existing.AvatarUrl = AvatarUrl;
            Existing.Email = Email;
            Existing.UpdatedAt = DateTime.UtcNow;
            return Task.FromResult(Existing);
        }
        var User = new UserEntity
        {
            Id = Guid.NewGuid().ToString(),
            GitHubId = GitHubId,
            GitHubUsername = Username,
            DisplayName = DisplayName,
            AvatarUrl = AvatarUrl,
            Email = Email
        };
        StoreById[User.Id] = User;
        GitHubIdIndex[GitHubId] = User.Id;
        return Task.FromResult(User);
    }
    public Task<UserEntity> CreateOrUpdateFromOidcAsync(string Provider, string SubjectId, string? Name, string? Email, string? AvatarUrl)
    {
        var OidcKey = $"{Provider}:{SubjectId}";
        if (OidcIndex.TryGetValue(OidcKey, out var ExistingId) && StoreById.TryGetValue(ExistingId, out var Existing))
        {
            Existing.DisplayName = Name;
            Existing.Email = Email;
            Existing.AvatarUrl = AvatarUrl;
            Existing.UpdatedAt = DateTime.UtcNow;
            return Task.FromResult(Existing);
        }
        var User = new UserEntity
        {
            Id = Guid.NewGuid().ToString(),
            GitHubUsername = $"{Provider}:{SubjectId}",
            DisplayName = Name,
            Email = Email,
            AvatarUrl = AvatarUrl
        };
        StoreById[User.Id] = User;
        OidcIndex[OidcKey] = User.Id;
        return Task.FromResult(User);
    }
    public Task<UserEntity> UpdateAsync(UserEntity User)
    {
        User.UpdatedAt = DateTime.UtcNow;
        StoreById[User.Id] = User;
        return Task.FromResult(User);
    }
    public Task<IReadOnlyList<UserEntity>> ListAsync() =>
        Task.FromResult<IReadOnlyList<UserEntity>>(StoreById.Values.ToList());
    public Task DeleteAsync(string UserId)
    {
        StoreById.TryRemove(UserId, out _);
        return Task.CompletedTask;
    }
}
