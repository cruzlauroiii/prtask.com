using System.Text;
using System.Text.RegularExpressions;
using PrTask.Application.Services;
namespace PrTask.Infrastructure.Services;
public partial class DiffSanitizationService : IDiffSanitizationService
{
    public string SanitizeDiffForPublicDisplay(string RawDiff)
    {
        var Lines = RawDiff.Split('\n');
        var SanitizedBuilder = new StringBuilder();
        foreach (var Line in Lines)
        {
            if (Line.StartsWith("diff --git", StringComparison.Ordinal))
            {
                SanitizedBuilder.AppendLine(RedactFilePathInDiffHeader(Line));
            }
            else if (Line.StartsWith("+++", StringComparison.Ordinal) || Line.StartsWith("---", StringComparison.Ordinal))
            {
                SanitizedBuilder.AppendLine(RedactFilePath(Line));
            }
            else if (Line.StartsWith("@@", StringComparison.Ordinal))
            {
                SanitizedBuilder.AppendLine(Line);
            }
            else if (Line.StartsWith('+') || Line.StartsWith('-'))
            {
                SanitizedBuilder.AppendLine(RedactSensitiveContent(Line));
            }
            else
            {
                SanitizedBuilder.AppendLine(Line);
            }
        }
        return SanitizedBuilder.ToString().TrimEnd();
    }
    public string ExtractFileExtensions(string RawDiff) =>
        string.Join(',', FileExtensionPattern().Matches(RawDiff).Select(Match => Match.Groups[1].Value).Distinct());
    private static string RedactFilePathInDiffHeader(string Line)
    {
        var Parts = Line.Split(' ');
        return Parts.Length >= 4
            ? $"diff --git a/{GetFileName(Parts[2])} b/{GetFileName(Parts[3])}"
            : Line;
    }
    private static string RedactFilePath(string Line)
    {
        var Prefix = Line[..3];
        var Path = Line[3..].Trim();
        return $"{Prefix} {GetFileName(Path)}";
    }
    private static string GetFileName(string Path) =>
        Path.Contains('/') ? Path[(Path.LastIndexOf('/') + 1)..] : Path;
    private static string RedactSensitiveContent(string Line) =>
        SecretPattern().IsMatch(Line) ? $"{Line[0]}[REDACTED]" : Line;
    [GeneratedRegex(@"(?i)(password|secret|key|token|api[_-]?key|connection[_-]?string)\s*[=:]\s*\S+")]
    private static partial Regex SecretPattern();
    [GeneratedRegex(@"diff --git a/\S+(\.\w+)\s")]
    private static partial Regex FileExtensionPattern();
}
