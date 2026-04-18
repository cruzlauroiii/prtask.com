using System.Text.Json;

namespace PrTask.Domain.Models;
public sealed class AnthropicToolUse
{
    public required string Id { get; init; }
    public required string Name { get; init; }
    public required JsonElement Input { get; init; }
}
