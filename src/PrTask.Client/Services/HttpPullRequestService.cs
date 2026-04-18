using System.Net.Http.Json;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class HttpPullRequestService(HttpClient Http) : IPullRequestService
{
    public async Task<bool> ExistsAsync(string PullRequestId)
    {
        var Pr = await GetByIdAsync(PullRequestId);
        return Pr is not null;
    }
    public async Task<PullRequestEntity?> GetByIdAsync(string PullRequestId)
    {
        try { return await Http.GetFromJsonAsync<PullRequestEntity>(string.Format(RouteConstants.ApiPullRequestById, PullRequestId)); }
        catch { return null; }
    }
    public async Task<IReadOnlyList<PullRequestEntity>> ListByDeveloperAsync(string DeveloperId)
    {
        try { return await Http.GetFromJsonAsync<PullRequestEntity[]>(string.Format(RouteConstants.ApiPullRequestsByDeveloper, DeveloperId)) ?? []; }
        catch { return []; }
    }
    public async Task<IReadOnlyList<PullRequestEntity>> ListRecentAsync(int Count)
    {
        try { return await Http.GetFromJsonAsync<PullRequestEntity[]>(RouteConstants.ApiPullRequestsRecent) ?? []; }
        catch { return []; }
    }
    public async Task<IReadOnlyList<PullRequestEntity>> ListByTaskAsync(string TaskId)
    {
        try { return await Http.GetFromJsonAsync<PullRequestEntity[]>(string.Format(RouteConstants.ApiPullRequestsByTask, TaskId)) ?? []; }
        catch { return []; }
    }
    public async Task<PullRequestEntity> SubmitAsync(PullRequestEntity Entity)
    {
        var Resp = await Http.PostAsJsonAsync(RouteConstants.ApiPullRequests, Entity);
        return await Resp.Content.ReadFromJsonAsync<PullRequestEntity>() ?? Entity;
    }
    public async Task ApproveAsync(string PullRequestId) =>
        await Http.PostAsync(string.Format(RouteConstants.ApiPullRequestApprove, PullRequestId), null);
    public async Task RejectAsync(string PullRequestId, string Notes) =>
        await Http.PostAsJsonAsync(string.Format(RouteConstants.ApiPullRequestReject, PullRequestId), new { Notes });
    public async Task<PullRequestEntity> UpdateAsync(PullRequestEntity Entity)
    {
        await Http.PutAsJsonAsync(string.Format(RouteConstants.ApiPullRequestById, Entity.Id), Entity);
        return Entity;
    }
    public async Task DeleteAsync(string PullRequestId) =>
        await Http.DeleteAsync(string.Format(RouteConstants.ApiPullRequestById, PullRequestId));
}
