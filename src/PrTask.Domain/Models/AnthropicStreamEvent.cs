using System.Text.Json;

namespace PrTask.Domain.Models;
public sealed class AnthropicStreamEvent
{
    public required string EventType { get; init; }
    public JsonElement Data { get; init; }
    public int? Index { get; init; }
    public AnthropicContentBlock? ContentBlock { get; init; }
    public AnthropicContentBlockDelta? Delta { get; init; }
    public AnthropicResponse? Message { get; init; }
    public AnthropicTokenUsage? Usage { get; init; }
    public string? StopReason { get; init; }
}
