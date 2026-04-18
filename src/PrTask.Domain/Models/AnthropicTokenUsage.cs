namespace PrTask.Domain.Models;
public sealed class AnthropicTokenUsage
{
    public int InputTokens { get; init; }
    public int OutputTokens { get; init; }
    public int? CacheCreationInputTokens { get; init; }
    public int? CacheReadInputTokens { get; init; }
}
