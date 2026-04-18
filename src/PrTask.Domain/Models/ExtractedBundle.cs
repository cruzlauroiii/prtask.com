namespace PrTask.Domain.Models;
public sealed class ExtractedBundle
{
    public required IReadOnlyList<BunModule> Modules { get; init; }
    public int EntryPointId { get; init; }
    public long TotalSize { get; init; }
}
