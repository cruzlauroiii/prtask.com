using System.Text.Json;

namespace PrTask.Domain.Models;
public sealed class AnthropicContentBlock
{
    public required string Type { get; init; }
    public string? Text { get; init; }
    public string? Id { get; init; }
    public string? Name { get; init; }
    public JsonElement? Input { get; init; }
    public string? ToolUseId { get; init; }
    public bool? IsError { get; init; }
}
