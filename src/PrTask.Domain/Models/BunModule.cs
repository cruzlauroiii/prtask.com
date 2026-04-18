namespace PrTask.Domain.Models;
public sealed class BunModule
{
    public required string Name { get; init; }
    public required string Source { get; init; }
    public int SourceOffset { get; init; }
    public int SourceLength { get; init; }
    public byte Encoding { get; init; }
    public byte Loader { get; init; }
    public byte ModuleFormat { get; init; }
    public byte Side { get; init; }
}
