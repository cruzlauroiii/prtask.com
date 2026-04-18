namespace PrTask.Domain.Models;
public sealed class DiffLineModel
{
    public DiffLineType Type { get; init; }
    public string Text { get; init; } = string.Empty;
    public int? OldLineNumber { get; init; }
    public int? NewLineNumber { get; init; }
}
