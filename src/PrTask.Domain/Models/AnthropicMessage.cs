namespace PrTask.Domain.Models;
public sealed class AnthropicMessage
{
    public required string Role { get; init; }
    public required IReadOnlyList<AnthropicContentBlock> Content { get; init; }
}
