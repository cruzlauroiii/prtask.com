using System.Net.Http.Json;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class HttpSprintService(HttpClient Http) : ISprintService
{
    public async Task<SprintEntity?> GetByIdAsync(string SprintId)
    {
        try { return await Http.GetFromJsonAsync<SprintEntity>(FormatStrings.ApiResourcePath(RouteConstants.ApiSprints, SprintId)); }
        catch { return null; }
    }
    public async Task<IReadOnlyList<SprintEntity>> ListByOwnerAsync(string OwnerId)
    {
        try { return await Http.GetFromJsonAsync<SprintEntity[]>(FormatStrings.OwnerPath(RouteConstants.ApiSprints, OwnerId)) ?? []; }
        catch { return []; }
    }
    public async Task<IReadOnlyList<SprintEntity>> ListActiveAsync()
    {
        try { return await Http.GetFromJsonAsync<SprintEntity[]>(RouteConstants.ApiSprints) ?? []; }
        catch { return []; }
    }
    public async Task<SprintEntity> CreateAsync(SprintEntity Entity)
    {
        var Resp = await Http.PostAsJsonAsync(RouteConstants.ApiSprints, Entity);
        return await Resp.Content.ReadFromJsonAsync<SprintEntity>() ?? Entity;
    }
    public async Task<SprintEntity> UpdateAsync(SprintEntity Entity)
    {
        await Http.PatchAsJsonAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiSprints, Entity.Id), Entity);
        return Entity;
    }
    public async Task DeleteAsync(string SprintId) =>
        await Http.DeleteAsync(FormatStrings.ApiResourcePath(RouteConstants.ApiSprints, SprintId));
}
