using System.Net.Http.Json;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class HttpTaskService(HttpClient Http) : ITaskService
{
    public async Task<bool> ExistsAsync(string TaskId)
    {
        var Task = await GetByIdAsync(TaskId);
        return Task is not null;
    }
    public async Task<TaskEntity?> GetByIdAsync(string TaskId)
    {
        try { return await Http.GetFromJsonAsync<TaskEntity>(string.Format(RouteConstants.ApiTaskById, TaskId)); }
        catch { return null; }
    }
    public async Task<IReadOnlyList<TaskEntity>> ListOpenAsync()
    {
        try { return await Http.GetFromJsonAsync<TaskEntity[]>(RouteConstants.ApiTasks) ?? []; }
        catch { return []; }
    }
    public async Task<IReadOnlyList<TaskEntity>> ListByClientAsync(string ClientId)
    {
        try { return await Http.GetFromJsonAsync<TaskEntity[]>(string.Format(RouteConstants.ApiTasksByClient, ClientId)) ?? []; }
        catch { return []; }
    }
    public async Task<TaskEntity> CreateAsync(TaskEntity Entity)
    {
        var Resp = await Http.PostAsJsonAsync(RouteConstants.ApiTasks, Entity);
        return await Resp.Content.ReadFromJsonAsync<TaskEntity>() ?? Entity;
    }
    public async Task ClaimAsync(string TaskId, string DeveloperId) =>
        await Http.PostAsJsonAsync(string.Format(RouteConstants.ApiTaskClaim, TaskId), new { DeveloperId });
    public async Task<TaskEntity> UpdateAsync(TaskEntity Entity)
    {
        await Http.PutAsJsonAsync(string.Format(RouteConstants.ApiTaskById, Entity.Id), Entity);
        return Entity;
    }
    public async Task DeleteAsync(string TaskId) =>
        await Http.DeleteAsync(string.Format(RouteConstants.ApiTaskById, TaskId));
}
