using System.Net.Http.Json;
using System.Text.Json;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Client.Services;
public class HttpVectorSearchService(HttpClient Http) : IVectorSearchService
{
    public async Task IndexAsync(string Id, float[] Embedding) =>
        await Http.PostAsJsonAsync(RouteConstants.ApiVectorSearchIndex, new { Id, Embedding });
    public async Task<IReadOnlyList<string>> SearchAsync(float[] Query, int TopK)
    {
        var Resp = await Http.PostAsJsonAsync(RouteConstants.ApiVectorSearchQuery, new { Query, TopK });
        if (!Resp.IsSuccessStatusCode) { return []; }
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        return Doc.RootElement.TryGetProperty(AiConstants.JsonResults, out var Arr)
            ? Arr.EnumerateArray().Select(E => E.GetString() ?? string.Empty).ToList() : [];
    }
    public async Task DeleteAsync(string Id) =>
        await Http.DeleteAsync(string.Format(RouteConstants.ApiVectorSearchById, Id));
    public async Task<long> CountAsync()
    {
        var Resp = await Http.GetAsync(RouteConstants.ApiVectorSearchCount);
        if (!Resp.IsSuccessStatusCode) { return 0; }
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        return Doc.RootElement.TryGetProperty(AiConstants.JsonCount, out var Val) ? Val.GetInt64() : 0;
    }
}
