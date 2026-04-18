namespace PrTask.Domain.Models;
public sealed class BundleComparisonResult
{
    public required bool IsMatch { get; init; }
    public long ExtractedSize { get; init; }
    public long ReferenceSize { get; init; }
    public int FirstDifferenceOffset { get; init; }
    public string ExtractedContext { get; init; } = string.Empty;
    public string ReferenceContext { get; init; } = string.Empty;
}
