namespace PrTask.Domain.Models;
public sealed class DiffResultModel
{
    public IReadOnlyList<DiffLineModel> InlineLines { get; init; } = [];
    public IReadOnlyList<DiffLineModel> OldLines { get; init; } = [];
    public IReadOnlyList<DiffLineModel> NewLines { get; init; } = [];
    public int Additions { get; init; }
    public int Deletions { get; init; }
    public int Modifications { get; init; }
}
