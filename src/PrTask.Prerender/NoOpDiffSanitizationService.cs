using PrTask.Application.Services;
namespace PrTask.Prerender;
public sealed class NoOpDiffSanitizationService : IDiffSanitizationService
{
    public string SanitizeDiffForPublicDisplay(string RawDiff) => RawDiff;
    public string ExtractFileExtensions(string RawDiff) => string.Empty;
}
