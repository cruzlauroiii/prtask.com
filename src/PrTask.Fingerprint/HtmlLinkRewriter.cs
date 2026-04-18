using System.Text.RegularExpressions;
using PrTask.Domain.Constants;

namespace PrTask.Fingerprint;

public static partial class HtmlLinkRewriter
{
    [GeneratedRegex(FingerprintConstants.AnchorHrefDotSlash)]
    private static partial Regex AnchorDotSlashRegex();

    [GeneratedRegex(FingerprintConstants.AnchorHrefSlash)]
    private static partial Regex AnchorSlashRegex();

    [GeneratedRegex(FingerprintConstants.LangIndexPattern)]
    private static partial Regex LangIndexRegex();

    public static string RewriteLinks(string Html, IDictionary<string, string> Map)
    {
        var Result = Html.Replace(FingerprintConstants.BaseHrefTag, string.Empty);

        foreach (var Pair in Map)
        {
            var Clean = Pair.Key;
            var Fingerprinted = Pair.Value;

            Result = Result
                .Replace(
                    FingerprintConstants.HrefPattern + Clean + FingerprintConstants.QuoteClose,
                    FingerprintConstants.HrefPattern + Fingerprinted + FingerprintConstants.QuoteClose)
                .Replace(
                    FingerprintConstants.SlashHrefPattern + Clean + FingerprintConstants.QuoteClose,
                    FingerprintConstants.HrefPattern + Fingerprinted + FingerprintConstants.QuoteClose)
                .Replace(
                    FingerprintConstants.DotSlashHrefPattern + Clean + FingerprintConstants.QuoteClose,
                    FingerprintConstants.DotSlashHrefPattern + Fingerprinted + FingerprintConstants.QuoteClose)
                .Replace(
                    FingerprintConstants.ParentHrefPattern + Clean + FingerprintConstants.QuoteClose,
                    FingerprintConstants.ParentHrefPattern + Fingerprinted + FingerprintConstants.QuoteClose)
                .Replace(
                    FingerprintConstants.DoubleParentHrefPattern + Clean + FingerprintConstants.QuoteClose,
                    FingerprintConstants.DoubleParentHrefPattern + Fingerprinted + FingerprintConstants.QuoteClose)
                .Replace(
                    FingerprintConstants.HrefPattern + Clean + FingerprintConstants.HashMark,
                    FingerprintConstants.HrefPattern + Fingerprinted + FingerprintConstants.HashMark)
                .Replace(
                    FingerprintConstants.SlashHrefPattern + Clean + FingerprintConstants.HashMark,
                    FingerprintConstants.HrefPattern + Fingerprinted + FingerprintConstants.HashMark)
                .Replace(
                    FingerprintConstants.DotSlashHrefPattern + Clean + FingerprintConstants.HashMark,
                    FingerprintConstants.DotSlashHrefPattern + Fingerprinted + FingerprintConstants.HashMark)
                .Replace(
                    FingerprintConstants.ParentHrefPattern + Clean + FingerprintConstants.HashMark,
                    FingerprintConstants.ParentHrefPattern + Fingerprinted + FingerprintConstants.HashMark)
                .Replace(
                    FingerprintConstants.DoubleParentHrefPattern + Clean + FingerprintConstants.HashMark,
                    FingerprintConstants.DoubleParentHrefPattern + Fingerprinted + FingerprintConstants.HashMark)
                .Replace(
                    FingerprintConstants.MetaRefreshUrl + Clean + FingerprintConstants.QuoteClose,
                    FingerprintConstants.MetaRefreshUrl + Fingerprinted + FingerprintConstants.QuoteClose)
                .Replace(
                    FingerprintConstants.MetaRefreshSlashUrl + Clean + FingerprintConstants.QuoteClose,
                    FingerprintConstants.MetaRefreshUrl + Fingerprinted + FingerprintConstants.QuoteClose)
                .Replace(
                    FingerprintConstants.MetaRefreshDotSlashUrl + Clean + FingerprintConstants.QuoteClose,
                    FingerprintConstants.MetaRefreshDotSlashUrl + Fingerprinted + FingerprintConstants.QuoteClose)
                .Replace(
                    FingerprintConstants.MetaRefreshParentUrl + Clean + FingerprintConstants.QuoteClose,
                    FingerprintConstants.MetaRefreshParentUrl + Fingerprinted + FingerprintConstants.QuoteClose)
                .Replace(
                    FingerprintConstants.MetaRefreshDoubleParentUrl + Clean + FingerprintConstants.QuoteClose,
                    FingerprintConstants.MetaRefreshDoubleParentUrl + Fingerprinted + FingerprintConstants.QuoteClose);

            if (Clean == FingerprintConstants.IndexClean)
            {
                var IndexReplacement = FingerprintConstants.RegexGroupReplace
                    + FingerprintConstants.HrefPattern
                    + Fingerprinted
                    + FingerprintConstants.QuoteClose;

                Result = AnchorDotSlashRegex().Replace(Result, IndexReplacement);
                Result = AnchorSlashRegex().Replace(Result, IndexReplacement);
            }

            var LangMatch = LangIndexRegex().Match(Clean);
            if (LangMatch.Success)
            {
                var LangSlash = LangMatch.Groups[1].Value + FingerprintConstants.PathSeparator;

                Result = Result
                    .Replace(
                        FingerprintConstants.HrefPattern + LangSlash + FingerprintConstants.QuoteClose,
                        FingerprintConstants.HrefPattern + Fingerprinted + FingerprintConstants.QuoteClose)
                    .Replace(
                        FingerprintConstants.DotSlashHrefPattern + LangSlash + FingerprintConstants.QuoteClose,
                        FingerprintConstants.DotSlashHrefPattern + Fingerprinted + FingerprintConstants.QuoteClose)
                    .Replace(
                        FingerprintConstants.ParentHrefPattern + LangSlash + FingerprintConstants.QuoteClose,
                        FingerprintConstants.ParentHrefPattern + Fingerprinted + FingerprintConstants.QuoteClose)
                    .Replace(
                        FingerprintConstants.DoubleParentHrefPattern + LangSlash + FingerprintConstants.QuoteClose,
                        FingerprintConstants.DoubleParentHrefPattern + Fingerprinted + FingerprintConstants.QuoteClose)
                    .Replace(
                        FingerprintConstants.MetaRefreshUrl + LangSlash + FingerprintConstants.QuoteClose,
                        FingerprintConstants.MetaRefreshUrl + Fingerprinted + FingerprintConstants.QuoteClose)
                    .Replace(
                        FingerprintConstants.MetaRefreshParentUrl + LangSlash + FingerprintConstants.QuoteClose,
                        FingerprintConstants.MetaRefreshParentUrl + Fingerprinted + FingerprintConstants.QuoteClose)
                    .Replace(
                        FingerprintConstants.MetaRefreshDoubleParentUrl + LangSlash + FingerprintConstants.QuoteClose,
                        FingerprintConstants.MetaRefreshDoubleParentUrl + Fingerprinted + FingerprintConstants.QuoteClose);
            }
        }

        return Result;
    }
}
