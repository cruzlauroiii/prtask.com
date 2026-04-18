using System.Net.Http.Json;
using System.Text.Json;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Client.Services;
public class HttpInferenceService(HttpClient Http) : IInferenceService
{
    public async Task<float[]> GenerateEmbeddingAsync(string Text)
    {
        var Resp = await Http.PostAsJsonAsync(RouteConstants.ApiInferenceEmbedding, new { Text });
        if (!Resp.IsSuccessStatusCode) { return []; }
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        return Doc.RootElement.TryGetProperty(AiConstants.JsonEmbedding, out var Arr)
            ? [.. Arr.EnumerateArray().Select(E => E.GetSingle())] : [];
    }
    public async Task<string> GenerateCompletionAsync(string Prompt)
    {
        var Resp = await Http.PostAsJsonAsync(RouteConstants.ApiInferenceCompletion, new { Prompt });
        if (!Resp.IsSuccessStatusCode) { return string.Empty; }
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        return Doc.RootElement.TryGetProperty(AiConstants.JsonCompletion, out var Val)
            ? Val.GetString() ?? string.Empty : string.Empty;
    }
    public async Task<bool> IsModelLoadedAsync()
    {
        var Resp = await Http.GetAsync(RouteConstants.ApiInferenceStatus);
        if (!Resp.IsSuccessStatusCode) { return false; }
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        return Doc.RootElement.TryGetProperty(AiConstants.JsonModelLoaded, out var Val) && Val.GetBoolean();
    }
}
