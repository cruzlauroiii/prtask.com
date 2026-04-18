namespace PrTask.Application.Services;
public interface IDiffSanitizationService
{
    string SanitizeDiffForPublicDisplay(string RawDiff);
    string ExtractFileExtensions(string RawDiff);
}
