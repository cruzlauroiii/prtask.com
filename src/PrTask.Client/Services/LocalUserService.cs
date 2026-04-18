using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class LocalUserService(ILocalStoreService Store) : IUserService
{
    public async Task<UserEntity?> GetByIdAsync(string UserId) =>
        await Store.GetRecordAsync<UserEntity>(OpfsConstants.CollectionUsers, UserId);

    public async Task<UserEntity?> GetByGitHubIdAsync(long GitHubId)
    {
        var All = await Store.GetRecordsAsync<UserEntity>(OpfsConstants.CollectionUsers);
        return All.FirstOrDefault(U => U.GitHubId == GitHubId);
    }

    public async Task<IReadOnlyList<UserEntity>> ListAsync() =>
        await Store.GetRecordsAsync<UserEntity>(OpfsConstants.CollectionUsers);

    public async Task<UserEntity> CreateOrUpdateFromGitHubAsync(long GitHubId, string Username, string? DisplayName, string? AvatarUrl, string? Email)
    {
        var Existing = await GetByGitHubIdAsync(GitHubId);
        var Entity = Existing ?? new UserEntity { Id = GitHubId.ToString(), GitHubId = GitHubId };
        Entity.GitHubUsername = Username;
        Entity.DisplayName = DisplayName ?? Username;
        Entity.AvatarUrl = AvatarUrl;
        Entity.Email = Email;
        Entity.UpdatedAt = DateTime.UtcNow;
        await Store.SaveRecordAsync(OpfsConstants.CollectionUsers, Entity);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeUpsertUser, Entity });
        return Entity;
    }

    public async Task<UserEntity> CreateOrUpdateFromOidcAsync(string Provider, string SubjectId, string? Name, string? Email, string? AvatarUrl)
    {
        var Existing = await GetByIdAsync(SubjectId);
        var Entity = Existing ?? new UserEntity { Id = SubjectId };
        Entity.DisplayName = Name ?? SubjectId;
        Entity.Email = Email;
        Entity.AvatarUrl = AvatarUrl;
        Entity.LinkedProviders = Provider;
        Entity.UpdatedAt = DateTime.UtcNow;
        await Store.SaveRecordAsync(OpfsConstants.CollectionUsers, Entity);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeUpsertUser, Entity });
        return Entity;
    }

    public async Task<UserEntity> UpdateAsync(UserEntity Entity)
    {
        Entity.UpdatedAt = DateTime.UtcNow;
        await Store.SaveRecordAsync(OpfsConstants.CollectionUsers, Entity);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeUpdateUser, Entity });
        return Entity;
    }

    public async Task DeleteAsync(string UserId)
    {
        await Store.DeleteRecordAsync(OpfsConstants.CollectionUsers, UserId);
        await Store.QueueMutationAsync(new { Type = OpfsConstants.MutationTypeDeleteUser, UserId });
    }
}
