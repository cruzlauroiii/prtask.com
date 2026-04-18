using System.Text.Json;
using PrTask.Application.Services;
namespace PrTask.Client.Services;
public class LocalCloudflareD1Service : ICloudflareD1Service
{
    public bool IsConfigured => false;

    public Task<JsonElement> QueryAsync(string Sql, params object[] Parameters) =>
        Task.FromResult(default(JsonElement));

    public Task<bool> ExecuteAsync(string Sql, params object[] Parameters) =>
        Task.FromResult(false);
}
