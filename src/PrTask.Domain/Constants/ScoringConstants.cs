using System.Collections.Frozen;
namespace PrTask.Domain.Constants;
public static class ScoringConstants
{
    public const int WeightHigh = 4;
    public const int WeightMedium = 3;
    public const int WeightLow = 2;
    public const int WeightMinimal = 1;
    public const int DefaultWeight = 1;
    public const int FileScoreMultiplier = 10;
    public const int AdditionScoreMultiplier = 2;
    public const int DeletionScoreMultiplier = 1;
    public static readonly FrozenDictionary<string, int> LanguageDifficultyWeights = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
    {
        [".cs"] = WeightMedium,
        [".rs"] = WeightHigh,
        [".go"] = WeightMedium,
        [".java"] = WeightMedium,
        [".cpp"] = WeightHigh,
        [".c"] = WeightHigh,
        [".ts"] = WeightLow,
        [".tsx"] = WeightLow,
        [".js"] = WeightLow,
        [".jsx"] = WeightLow,
        [".py"] = WeightLow,
        [".rb"] = WeightLow,
        [".razor"] = WeightLow,
        [".xaml"] = WeightMinimal,
        [".xml"] = WeightMinimal,
        [".json"] = WeightMinimal,
        [".yml"] = WeightMinimal,
        [".yaml"] = WeightMinimal,
        [".css"] = WeightMinimal,
        [".scss"] = WeightMinimal,
        [".html"] = WeightMinimal,
        [".sql"] = WeightMedium,
        [".tf"] = WeightLow,
        [".proto"] = WeightLow
    }.ToFrozenDictionary(StringComparer.OrdinalIgnoreCase);
}
