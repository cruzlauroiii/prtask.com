using PrTask.Application.Services;
namespace PrTask.Prerender;
public sealed class NoOpComplexityScoringService : IComplexityScoringService
{
    public int CalculateComplexityScore(int FilesChanged, int Additions, int Deletions, string[] FileExtensions) => 0;
    public int CalculateXpReward(int ComplexityScore, int StreakDays) => 0;
}
