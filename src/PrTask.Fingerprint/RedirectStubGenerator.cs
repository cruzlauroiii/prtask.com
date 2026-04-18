using System.Text.RegularExpressions;
using PrTask.Domain.Constants;

namespace PrTask.Fingerprint;

public static partial class RedirectStubGenerator
{
    [GeneratedRegex("([a-z])([A-Z])")]
    private static partial Regex PascalCaseSplitter();

    public static string Generate(string CleanName, string FingerprintedName)
    {
        var SlashCount = CleanName.Split(FingerprintConstants.PathSeparator).Length - 1;
        var Target = SlashCount > 0
            ? string.Concat(Enumerable.Repeat(FingerprintConstants.ParentDir, SlashCount)) + FingerprintedName
            : FingerprintedName;

        var Title = DeriveTitleFromCleanName(CleanName);
        return string.Format(FingerprintConstants.RedirectStubTemplate, Target, Title, SeoConstants.DefaultDescription);
    }

    private static string DeriveTitleFromCleanName(string CleanName)
    {
        var Name = CleanName.Replace(FingerprintConstants.HtmlExtension, string.Empty);
        var LastSegment = Name.Contains(FingerprintConstants.PathSeparator)
            ? Name[(Name.LastIndexOf(FingerprintConstants.PathSeparator, StringComparison.Ordinal) + 1)..]
            : Name;

        if (string.Equals(LastSegment, FingerprintConstants.IndexClean, StringComparison.OrdinalIgnoreCase))
        {
            return SeoConstants.DefaultTitle;
        }

        var Spaced = PascalCaseSplitter().Replace(LastSegment, "$1 $2");
        return $"{Spaced} - {AppConstants.AppName}";
    }
}
