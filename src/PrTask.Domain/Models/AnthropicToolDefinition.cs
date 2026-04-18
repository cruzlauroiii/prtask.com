using System.Text.Json;

namespace PrTask.Domain.Models;
public sealed class AnthropicToolDefinition
{
    public required string Name { get; init; }
    public string? Description { get; init; }
    public required JsonElement InputSchema { get; init; }
}
