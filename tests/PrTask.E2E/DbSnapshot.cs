using System.Text.Json;
namespace PrTask.E2E;
public sealed record DbSnapshot(DateTime Timestamp, IDictionary<string, JsonElement> Data);
