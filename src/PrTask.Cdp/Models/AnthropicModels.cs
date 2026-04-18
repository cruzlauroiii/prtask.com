using System.Text.Json;
using System.Text.Json.Serialization;

namespace PrTask.Claude.Wasm.Models;

internal sealed class ApiMessage
{
    [JsonPropertyName("role")]
    public required string Role { get; init; }
    [JsonPropertyName("content")]
    public required IReadOnlyList<ApiContentBlock> Content { get; init; }
}

internal sealed class ApiContentBlock
{
    [JsonPropertyName("type")]
    public required string Type { get; init; }
    [JsonPropertyName("text")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Text { get; init; }
    [JsonPropertyName("id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Id { get; init; }
    [JsonPropertyName("name")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Name { get; init; }
    [JsonPropertyName("input")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public JsonElement? Input { get; init; }
    [JsonPropertyName("tool_use_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ToolUseId { get; init; }
    [JsonPropertyName("is_error")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? IsError { get; init; }
}

internal sealed class ApiRequest
{
    [JsonPropertyName("model")]
    public required string Model { get; init; }
    [JsonPropertyName("max_tokens")]
    public required int MaxTokens { get; init; }
    [JsonPropertyName("messages")]
    public required IReadOnlyList<ApiMessage> Messages { get; init; }
    [JsonPropertyName("system")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? System { get; init; }
    [JsonPropertyName("stream")]
    public bool Stream { get; init; }
    [JsonPropertyName("tools")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IReadOnlyList<ApiToolDefinition>? Tools { get; init; }
}

internal sealed class ApiResponse
{
    [JsonPropertyName("id")]
    public string Id { get; init; } = string.Empty;
    [JsonPropertyName("type")]
    public string Type { get; init; } = string.Empty;
    [JsonPropertyName("role")]
    public string Role { get; init; } = string.Empty;
    [JsonPropertyName("content")]
    public IReadOnlyList<ApiContentBlock> Content { get; init; } = [];
    [JsonPropertyName("model")]
    public string Model { get; init; } = string.Empty;
    [JsonPropertyName("stop_reason")]
    public string? StopReason { get; init; }
    [JsonPropertyName("usage")]
    public ApiTokenUsage? Usage { get; init; }
}

internal sealed class ApiTokenUsage
{
    [JsonPropertyName("input_tokens")]
    public int InputTokens { get; init; }
    [JsonPropertyName("output_tokens")]
    public int OutputTokens { get; init; }
    [JsonPropertyName("cache_creation_input_tokens")]
    public int? CacheCreationInputTokens { get; init; }
    [JsonPropertyName("cache_read_input_tokens")]
    public int? CacheReadInputTokens { get; init; }
}

internal sealed class ApiToolDefinition
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }
    [JsonPropertyName("description")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Description { get; init; }
    [JsonPropertyName("input_schema")]
    public required JsonElement InputSchema { get; init; }
}

internal sealed class ApiStreamDelta
{
    [JsonPropertyName("type")]
    public string Type { get; init; } = string.Empty;
    [JsonPropertyName("text")]
    public string? Text { get; init; }
    [JsonPropertyName("partial_json")]
    public string? PartialJson { get; init; }
    [JsonPropertyName("stop_reason")]
    public string? StopReason { get; init; }
    [JsonPropertyName("usage")]
    public ApiTokenUsage? Usage { get; init; }
}
