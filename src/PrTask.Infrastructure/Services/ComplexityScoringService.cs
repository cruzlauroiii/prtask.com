using PrTask.Application.Services;
using PrTask.Domain.Constants;
namespace PrTask.Infrastructure.Services;
public class ComplexityScoringService : IComplexityScoringService
{
    private static readonly Dictionary<string, int> LanguageDifficultyWeights = new(StringComparer.OrdinalIgnoreCase)
    {
        [".cs"] = 3,
        [".rs"] = 4,
        [".go"] = 3,
        [".java"] = 3,
        [".cpp"] = 4,
        [".c"] = 4,
        [".ts"] = 2,
        [".tsx"] = 2,
        [".js"] = 2,
        [".jsx"] = 2,
        [".py"] = 2,
        [".rb"] = 2,
        [".razor"] = 2,
        [".xaml"] = 1,
        [".xml"] = 1,
        [".json"] = 1,
        [".yml"] = 1,
        [".yaml"] = 1,
        [".css"] = 1,
        [".scss"] = 1,
        [".html"] = 1,
        [".sql"] = 3,
        [".tf"] = 2,
        [".proto"] = 2
    };
    public int CalculateComplexityScore(int FilesChanged, int Additions, int Deletions, string[] FileExtensions)
    {
        var FileScore = FilesChanged * 5;
        var LineScore = (Additions + Deletions) / 10;
        var LanguageScore = CalculateLanguageDifficultyScore(FileExtensions);
        return FileScore + LineScore + LanguageScore;
    }
    public int CalculateXpReward(int ComplexityScore, int StreakDays) =>
        ComplexityScore * AppConstants.XpPerComplexityPoint * (StreakDays > 0 ? AppConstants.StreakBonusMultiplier : 1);
    private static int CalculateLanguageDifficultyScore(string[] FileExtensions)
    {
        var TotalWeight = 0;
        foreach (var Extension in FileExtensions)
        {
            TotalWeight += LanguageDifficultyWeights.GetValueOrDefault(Extension, 1);
        }
        return TotalWeight;
    }
}
