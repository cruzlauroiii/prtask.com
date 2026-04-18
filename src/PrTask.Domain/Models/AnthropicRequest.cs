namespace PrTask.Domain.Models;
public sealed class AnthropicRequest
{
    public required string Model { get; init; }
    public required int MaxTokens { get; init; }
    public required IReadOnlyList<AnthropicMessage> Messages { get; init; }
    public string? System { get; init; }
    public bool Stream { get; init; }
    public IReadOnlyList<AnthropicToolDefinition>? Tools { get; init; }
}
