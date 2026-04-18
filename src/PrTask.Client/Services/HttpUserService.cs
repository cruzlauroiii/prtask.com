using System.Net.Http.Json;
using System.Text.Json;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class HttpUserService(HttpClient Http) : IUserService
{
    private static readonly JsonSerializerOptions JsonOptions = new() { PropertyNameCaseInsensitive = true };
    public async Task<UserEntity?> GetByIdAsync(string UserId)
    {
        try { return await Http.GetFromJsonAsync<UserEntity>(string.Format(RouteConstants.ApiUserById, UserId), JsonOptions); }
        catch { return null; }
    }
    public async Task<UserEntity?> GetByGitHubIdAsync(long GitHubId)
    {
        try { return await Http.GetFromJsonAsync<UserEntity>(string.Format(RouteConstants.ApiUserByGitHubId, GitHubId), JsonOptions); }
        catch { return null; }
    }
    public async Task<IReadOnlyList<UserEntity>> ListAsync()
    {
        try { return await Http.GetFromJsonAsync<UserEntity[]>(RouteConstants.ApiUsers, JsonOptions) ?? []; }
        catch { return []; }
    }
    public Task<UserEntity> CreateOrUpdateFromGitHubAsync(long GitHubId, string Username, string? DisplayName, string? AvatarUrl, string? Email) =>
        Task.FromResult(new UserEntity { Id = GitHubId.ToString(), GitHubUsername = Username, DisplayName = DisplayName ?? Username });
    public Task<UserEntity> CreateOrUpdateFromOidcAsync(string Provider, string SubjectId, string? Name, string? Email, string? AvatarUrl) =>
        Task.FromResult(new UserEntity { Id = SubjectId, DisplayName = Name ?? SubjectId });
    public async Task<UserEntity> UpdateAsync(UserEntity Entity)
    {
        await Http.PutAsJsonAsync(string.Format(RouteConstants.ApiUserById, Entity.Id), Entity);
        return Entity;
    }
    public async Task DeleteAsync(string UserId) =>
        await Http.DeleteAsync(string.Format(RouteConstants.ApiUserById, UserId));
}
