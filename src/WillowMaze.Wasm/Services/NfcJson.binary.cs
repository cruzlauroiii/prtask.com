using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace WillowMaze.Wasm.Services;

public static class NfcJson
{
    private static readonly JsonSerializerOptions Options;
    public static string Line(string stream, string eventType, object payload)
    {
        // Decompiled from IL
        // Method: Line IL size: 170 bytes
        // Strings: 5, Method calls: 13, Field refs: 2
        // String: "value"
        // String: "stream"
        // String: "eventType"
        // String: "timestampUtc"
        // String: "O"
        // Calls: new:JsonObject..ctor
        // Calls: token:0x2B000027
        // Calls: JsonNode.set_Item
        // Calls: JsonNode.op_Implicit
        // Calls: DateTimeOffset.get_UtcNow
        // Calls: DateTimeOffset.ToString
        // Calls: JsonNode.ToJsonString
        // Field: Options
        return string.Empty;
    }

    public static string Serialize(object payload)
    {
        // Decompiled from IL
        // Method: Serialize IL size: 17 bytes
        // Strings: 0, Method calls: 1, Field refs: 1
        // Calls: token:0x2B000028
        // Field: Options
        return string.Empty;
    }

    public static void Append(List<string> target, int maxEntries, string stream, string eventType, object payload)
    {
        // Decompiled from IL
        // Method: Append IL size: 50 bytes
        // Strings: 0, Method calls: 5, Field refs: 0
        // Calls: NfcJson.Line
        // Calls: List<string>.Insert
        // Calls: List<string>.get_Count
        // Calls: List<string>.RemoveRange
    }

    public static string Join(IReadOnlyList<string> lines)
    {
        // Decompiled from IL
        // Method: Join IL size: 17 bytes
        // Strings: 0, Method calls: 2, Field refs: 0
        // Calls: Environment.get_NewLine
        // Calls: string.Join
        return string.Empty;
    }

    private static void .cctor()
    {
        // Decompiled from IL
        // Method: .cctor IL size: 20 bytes
        // Strings: 0, Method calls: 2, Field refs: 1
        // Calls: new:JsonSerializerOptions..ctor
        // Calls: JsonSerializerOptions.set_WriteIndented
        // Field: Options
    }

}
