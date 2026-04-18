using System.Text.Json;
using System.Text.Json.Nodes;

namespace WillowMaze.Wasm.Services;

public static class NfcJson
{
    private static readonly JsonSerializerOptions Options = new(JsonSerializerDefaults.Web)
    {
        WriteIndented = false
    };

    public static string Line(string Stream, string EventType, object? Payload = null)
    {
        JsonObject Root;
        if (Payload is null)
        {
            Root = [];
        }
        else
        {
            var Node = JsonSerializer.SerializeToNode(Payload, Options);
            Root = Node as JsonObject ?? new JsonObject { ["value"] = Node };
        }

        Root["stream"] = Stream;
        Root["eventType"] = EventType;
        Root["timestampUtc"] = DateTimeOffset.UtcNow.ToString("O");
        return Root.ToJsonString(Options);
    }

    public static string Serialize(object Payload) => JsonSerializer.Serialize(Payload, Options);

    public static void Append(List<string> Target, int MaxEntries, string Stream, string EventType, object? Payload = null)
    {
        Target.Insert(0, Line(Stream, EventType, Payload));
        if (Target.Count > MaxEntries)
        {
            Target.RemoveRange(MaxEntries, Target.Count - MaxEntries);
        }
    }

    public static string Join(IReadOnlyList<string> Lines) => string.Join(Environment.NewLine, Lines);
}
