using PrTask.Domain.Constants;
using PrTask.Fingerprint;

var PublishDir = args.Length > 0 ? args[0] : FingerprintConstants.DefaultPublishDir;
var WwwRoot = Path.Combine(PublishDir, FingerprintConstants.WwwRootDir);
var EndpointsPath = Path.Combine(PublishDir, FingerprintConstants.EndpointsFileName);

if (!File.Exists(EndpointsPath))
{
    Console.Error.WriteLine(string.Concat(FingerprintConstants.ErrorNotFound, EndpointsPath));
    return 1;
}

foreach (var OldFile in Directory.EnumerateFiles(WwwRoot, FingerprintConstants.HtmlGlob, SearchOption.AllDirectories))
{
    if (FingerprintRegex.AlreadyFingerprintedFile().IsMatch(Path.GetFileName(OldFile)))
    {
        File.Delete(OldFile);
    }
}

foreach (var CompressedFile in Directory.EnumerateFiles(WwwRoot, FingerprintConstants.BrGlob, SearchOption.AllDirectories))
{
    File.Delete(CompressedFile);
}

foreach (var CompressedFile in Directory.EnumerateFiles(WwwRoot, FingerprintConstants.GzGlob, SearchOption.AllDirectories))
{
    File.Delete(CompressedFile);
}

var HtmlMap = EndpointsReader.ReadHtmlMap(EndpointsPath);

Console.WriteLine(string.Format(FingerprintConstants.LogFoundFormat, HtmlMap.Count));

var LocaleMap = LocaleHtmlScanner.ScanLocaleHtml(WwwRoot, HtmlMap);
foreach (var Pair in LocaleMap)
{
    HtmlMap[Pair.Key] = Pair.Value;
}

Console.WriteLine(string.Format(FingerprintConstants.LogStartFormat, HtmlMap.Count, WwwRoot));

foreach (var Pair in HtmlMap)
{
    var CleanPath = Path.Combine(WwwRoot, Pair.Key);
    var FingerprintedPath = Path.Combine(WwwRoot, Pair.Value);

    if (!File.Exists(CleanPath))
    {
        Console.Error.WriteLine(string.Concat(FingerprintConstants.ErrorCleanNotFound, CleanPath));
        continue;
    }

    var IsHtml = Pair.Key.EndsWith(FingerprintConstants.HtmlExtension, StringComparison.Ordinal);
    var IsText = IsHtml || Pair.Key.EndsWith(FingerprintConstants.CssExtension, StringComparison.Ordinal);

    var ParentDirectory = Path.GetDirectoryName(FingerprintedPath);
    if (ParentDirectory != null && !Directory.Exists(ParentDirectory))
    {
        Directory.CreateDirectory(ParentDirectory);
    }

    if (IsText)
    {
        var Content = File.ReadAllText(CleanPath);
        var Rewritten = IsHtml ? HtmlLinkRewriter.RewriteLinks(Content, HtmlMap) : Content;
        File.WriteAllText(FingerprintedPath, Rewritten);
    }
    else
    {
        File.Copy(CleanPath, FingerprintedPath, true);
    }

    if (IsHtml)
    {
        var RedirectHtml = RedirectStubGenerator.Generate(Pair.Key, Pair.Value);
        File.WriteAllText(CleanPath, RedirectHtml);
    }

    Console.WriteLine(string.Format(FingerprintConstants.LogEntryFormat, Pair.Key, Pair.Value));
}

if (HtmlMap.ContainsKey(FingerprintConstants.RootIndexFile)
    && HtmlMap.TryGetValue(FingerprintConstants.EnIndexFile, out var EnFingerprinted))
{
    var RootIndexPath = Path.Combine(WwwRoot, FingerprintConstants.RootIndexFile);
    var RootRedirect = RedirectStubGenerator.Generate(FingerprintConstants.RootIndexFile, EnFingerprinted);
    File.WriteAllText(RootIndexPath, RootRedirect);
    Console.WriteLine(string.Format(FingerprintConstants.LogEntryFormat, FingerprintConstants.RootIndexFile, EnFingerprinted));

    var NotFoundPath = Path.Combine(WwwRoot, FingerprintConstants.NotFoundFile);
    var NotFoundAbsoluteUrl = string.Concat(PrerenderConstants.BaseUrlSlash, EnFingerprinted);
    var NotFoundRedirect = string.Format(FingerprintConstants.RedirectStubTemplate, NotFoundAbsoluteUrl, SeoConstants.DefaultTitle, SeoConstants.DefaultDescription);
    File.WriteAllText(NotFoundPath, NotFoundRedirect);
    Console.WriteLine(string.Format(FingerprintConstants.LogEntryFormat, FingerprintConstants.NotFoundFile, EnFingerprinted));
}

Console.WriteLine(string.Format(FingerprintConstants.LogCompleteFormat, HtmlMap.Count));

return 0;
