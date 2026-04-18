using System.Net.Http.Json;
using System.Text.Json;
using PrTask.Application.Services;
using PrTask.Domain.Models;
namespace PrTask.Client.Services;
public class HttpSnapshotService(HttpClient Http) : ISnapshotService
{
    private const string SnapshotPath = "data/snapshot.json";
    private static readonly JsonSerializerOptions SnapshotJsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        PropertyNameCaseInsensitive = true
    };
    public async Task<DataSnapshot?> LoadAsync()
    {
        try
        {
            return await Http.GetFromJsonAsync<DataSnapshot>(SnapshotPath, SnapshotJsonOptions);
        }
        catch
        {
            return null;
        }
    }
}
