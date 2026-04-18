using System.Net.Http.Json;
using System.Text.Json;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Client.Services;
public class HttpSourceCodeService(HttpClient Http) : ISourceCodeService
{
    public async Task StoreFilesAsync(string TaskId, IDictionary<string, string> Files) =>
        await Http.PostAsJsonAsync(string.Format(RouteConstants.ApiSourceCodeUpload, TaskId), Files);
#pragma warning disable IDE0028
    public async Task<IDictionary<string, string>> GetFilesAsync(string TaskId)
    {
        try
        {
            return await Http.GetFromJsonAsync<Dictionary<string, string>>(
                string.Format(RouteConstants.ApiSourceCodeFiles, TaskId)) ?? new Dictionary<string, string>();
        }
        catch { return new Dictionary<string, string>(); }
    }
    public async Task<IDictionary<string, string>> GetModifiedFilesAsync(string TaskId, string PrId)
    {
        try
        {
            return await Http.GetFromJsonAsync<Dictionary<string, string>>(
                string.Format(RouteConstants.ApiSourceCodeModifiedFiles, TaskId, PrId)) ?? new Dictionary<string, string>();
        }
        catch { return new Dictionary<string, string>(); }
    }
#pragma warning restore IDE0028
    public async Task StoreModifiedFilesAsync(string TaskId, string PrId, IDictionary<string, string> Files) =>
        await Http.PostAsJsonAsync(string.Format(RouteConstants.ApiSourceCodeModify, TaskId, PrId), Files);
    public async Task<string> GenerateDiffAsync(string TaskId, string PrId)
    {
        var Resp = await Http.GetAsync(string.Format(RouteConstants.ApiSourceCodeDiff, TaskId, PrId));
        if (!Resp.IsSuccessStatusCode) { return string.Empty; }
        using var Doc = JsonDocument.Parse(await Resp.Content.ReadAsStringAsync());
        return Doc.RootElement.TryGetProperty(SourceCodeConstants.JsonDiff, out var D) ? D.GetString() ?? string.Empty : string.Empty;
    }
    public async Task DeleteFilesAsync(string TaskId) =>
        await Http.DeleteAsync(string.Format(RouteConstants.ApiSourceCodeDelete, TaskId));
}
