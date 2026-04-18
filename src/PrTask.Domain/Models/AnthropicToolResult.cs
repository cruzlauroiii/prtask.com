namespace PrTask.Domain.Models;
public sealed class AnthropicToolResult
{
    public required string ToolUseId { get; init; }
    public required string Content { get; init; }
    public bool IsError { get; init; }
}
