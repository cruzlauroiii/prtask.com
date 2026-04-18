using System.Text.Json;
namespace PrTask.Application.Services;
public interface ICloudflareD1Service
{
    Task<JsonElement> QueryAsync(string Sql, params object[] Parameters);
    Task<bool> ExecuteAsync(string Sql, params object[] Parameters);
    bool IsConfigured { get; }
}
