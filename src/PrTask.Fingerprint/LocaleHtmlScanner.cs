using System.Security.Cryptography;
using System.Text.RegularExpressions;
using PrTask.Domain.Constants;

namespace PrTask.Fingerprint;

public static partial class LocaleHtmlScanner
{
    [GeneratedRegex(FingerprintConstants.AlreadyFingerprintedFilePattern)]
    private static partial Regex AlreadyFingerprintedFileRegex();

    public static IDictionary<string, string> ScanLocaleHtml(string WwwRoot, IDictionary<string, string> ExistingMap)
    {
        var LocaleMap = new Dictionary<string, string>();
        var LocaleCount = 0;

        foreach (var (LanguageCode, _) in I18NConstants.AllLanguages)
        {
            var LangDir = Path.Combine(WwwRoot, LanguageCode);
            if (!Directory.Exists(LangDir))
            {
                continue;
            }

            foreach (var LangFile in Directory.EnumerateFiles(LangDir, FingerprintConstants.HtmlGlob, SearchOption.AllDirectories))
            {
                var FileName = Path.GetFileName(LangFile);
                if (AlreadyFingerprintedFileRegex().IsMatch(FileName))
                {
                    continue;
                }

                var RelPath = Path.GetRelativePath(WwwRoot, LangFile).Replace(Path.DirectorySeparatorChar, '/');
                if (ExistingMap.ContainsKey(RelPath))
                {
                    continue;
                }

                var FileBytes = File.ReadAllBytes(LangFile);
                var HashBytes = SHA256.HashData(FileBytes);
                var HashStr = Convert.ToHexString(HashBytes)[..FingerprintConstants.FingerprintHashLength]
                    .ToLowerInvariant();

                var BaseName = Path.GetFileNameWithoutExtension(RelPath);
                var DirPart = Path.GetDirectoryName(RelPath)?.Replace(Path.DirectorySeparatorChar, '/');

                var FingerprintedName = string.IsNullOrEmpty(DirPart)
                    ? string.Format(FingerprintConstants.FingerprintDotFormat, BaseName, HashStr)
                    : string.Format(FingerprintConstants.FingerprintDotDirFormat, DirPart, BaseName, HashStr);

                LocaleMap[RelPath] = FingerprintedName;
                LocaleCount++;
            }
        }

        Console.WriteLine(string.Format(FingerprintConstants.LogLocaleFoundFormat, LocaleCount));
        return LocaleMap;
    }
}
