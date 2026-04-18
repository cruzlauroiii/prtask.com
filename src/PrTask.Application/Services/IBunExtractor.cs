using PrTask.Domain.Models;
namespace PrTask.Application.Services;
public interface IBunExtractor
{
    ExtractedBundle ExtractBundle(string ExePath);
    BundleComparisonResult CompareWithSource(ExtractedBundle Bundle, string SourcePath);
}
