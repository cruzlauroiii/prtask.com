using System.Net.Http.Json;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class HttpRepositoryService(HttpClient Http) : IRepositoryService
{
    public async Task<RepositoryEntity?> GetByIdAsync(string RepositoryId)
    {
        try { return await Http.GetFromJsonAsync<RepositoryEntity>(FormatStrings.ApiResourcePath(RouteConstants.ApiRepositories, RepositoryId)); }
        catch { return null; }
    }
    public async Task<IReadOnlyList<RepositoryEntity>> ListByOwnerAsync(string OwnerId)
    {
        try { return await Http.GetFromJsonAsync<RepositoryEntity[]>(FormatStrings.OwnerPath(RouteConstants.ApiRepositories, OwnerId)) ?? []; }
        catch { return []; }
    }
    public async Task<RepositoryEntity> CreateAsync(RepositoryEntity Entity)
    {
        var Resp = await Http.PostAsJsonAsync(RouteConstants.ApiRepositories, Entity);
        return await Resp.Content.ReadFromJsonAsync<RepositoryEntity>() ?? Entity;
    }
    public async Task<RepositoryEntity> UpdateAsync(RepositoryEntity Entity)
    {
        await Http.PatchAsJsonAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiRepositories, Entity.Id), Entity);
        return Entity;
    }
    public async Task DeleteAsync(string RepositoryId) =>
        await Http.DeleteAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiRepositories, RepositoryId));
}
