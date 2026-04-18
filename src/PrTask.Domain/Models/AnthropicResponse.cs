namespace PrTask.Domain.Models;
public sealed class AnthropicResponse
{
    public required string Id { get; init; }
    public required string Type { get; init; }
    public required string Role { get; init; }
    public required IReadOnlyList<AnthropicContentBlock> Content { get; init; }
    public required string Model { get; init; }
    public string? StopReason { get; init; }
    public AnthropicTokenUsage? Usage { get; init; }
}
