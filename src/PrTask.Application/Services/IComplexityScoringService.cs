using PrTask.Domain.Models;
namespace PrTask.Application.Services;
public interface IComplexityScoringService
{
    int CalculateComplexityScore(int FilesChanged, int Additions, int Deletions, string[] FileExtensions);
    int CalculateXpReward(int ComplexityScore, int StreakDays);
}
