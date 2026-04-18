using PrTask.Domain.Models;
namespace PrTask.Application.Services;
public interface IUserService
{
    Task<UserEntity?> GetByIdAsync(string UserId);
    Task<UserEntity?> GetByGitHubIdAsync(long GitHubId);
    Task<UserEntity> CreateOrUpdateFromGitHubAsync(long GitHubId, string Username, string? DisplayName, string? AvatarUrl, string? Email);
    Task<UserEntity> CreateOrUpdateFromOidcAsync(string Provider, string SubjectId, string? Name, string? Email, string? AvatarUrl);
    Task<UserEntity> UpdateAsync(UserEntity User);
    Task<IReadOnlyList<UserEntity>> ListAsync();
    Task DeleteAsync(string UserId);
}
