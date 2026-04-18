using System.Text.Json;
using System.Text.Json.Nodes;

namespace WillowMaze.App.Services;

internal static class NfcJson
{
    private static readonly JsonSerializerOptions Options = new(JsonSerializerDefaults.Web)
    {
        WriteIndented = false
    };

    public static string Line(string stream, string eventType, object? payload = null)
    {
        JsonObject root;

        if (payload is null)
        {
            root = [];
        }
        else
        {
            var node = JsonSerializer.SerializeToNode(payload, Options);
            root = node as JsonObject ?? new JsonObject
            {
                ["value"] = node
            };
        }

        root["stream"] = stream;
        root["eventType"] = eventType;
        root["timestampUtc"] = DateTimeOffset.UtcNow.ToString("O");
        return root.ToJsonString(Options);
    }

    public static string Serialize(object payload)
    {
        return JsonSerializer.Serialize(payload, Options);
    }

    public static void Append(List<string> target, int maxEntries, string stream, string eventType, object? payload = null)
    {
        target.Insert(0, Line(stream, eventType, payload));
        if (target.Count > maxEntries)
        {
            target.RemoveRange(maxEntries, target.Count - maxEntries);
        }
    }

    public static string Join(IReadOnlyList<string> lines)
    {
        return string.Join(Environment.NewLine, lines);
    }
}
