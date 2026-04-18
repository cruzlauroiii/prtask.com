using PrTask.Application.Services;
using PrTask.Domain.Models;
namespace PrTask.Prerender;
public sealed class NoOpUserService : IUserService
{
    public Task<UserEntity?> GetByIdAsync(string UserId) => Task.FromResult<UserEntity?>(null);
    public Task<UserEntity?> GetByGitHubIdAsync(long GitHubId) => Task.FromResult<UserEntity?>(null);
    public Task<UserEntity> CreateOrUpdateFromGitHubAsync(long GitHubId, string Username, string? DisplayName, string? AvatarUrl, string? Email) => Task.FromResult(new UserEntity { Id = string.Empty });
    public Task<UserEntity> CreateOrUpdateFromOidcAsync(string Provider, string SubjectId, string? Name, string? Email, string? AvatarUrl) => Task.FromResult(new UserEntity { Id = string.Empty });
    public Task<UserEntity> UpdateAsync(UserEntity User) => Task.FromResult(User);
    public Task<IReadOnlyList<UserEntity>> ListAsync() => Task.FromResult<IReadOnlyList<UserEntity>>(Array.Empty<UserEntity>());
    public Task DeleteAsync(string UserId) => Task.CompletedTask;
}
