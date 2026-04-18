namespace PrTask.Domain.Models;
public sealed class AnthropicContentBlockDelta
{
    public required string Type { get; init; }
    public string? Text { get; init; }
    public string? PartialJson { get; init; }
}
