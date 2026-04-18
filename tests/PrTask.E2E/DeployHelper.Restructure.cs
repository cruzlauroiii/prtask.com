namespace PrTask.E2E;
public static partial class DeployHelper
{
    private static void FixHtmlPathRefs(string DeployDir)
    {
        foreach (var HtmlFile in GetAllHtml(DeployDir))
        {
            var Content = File.ReadAllText(HtmlFile)
                .Replace(FrameworkOld, FrameworkNew)
                .Replace(ContentCssOld, ContentCssNew)
                .Replace(ContentJsOld, ContentJsNew)
                .Replace(ContentRootOld, ContentRootNew)
                .Replace(JsSrcLower1, JsSrcUpper1)
                .Replace(JsSrcLower2, JsSrcUpper2)
                .Replace(DataLower, DataUpper)
                .Replace(DownloadsLower, DownloadsUpper)
                .Replace(ManifestLink1, string.Empty)
                .Replace(ManifestLink2, string.Empty)
                .Replace(OriginalBaseHref1, GitPagesBaseHref)
                .Replace(OriginalBaseHref2, GitPagesBaseHref);
            if (!PrTask.Domain.Constants.AppConstants.ServiceWorkerEnabled)
            {
                Content = SwRegistrationRegex().Replace(Content, string.Empty);
                Content = SwUpdateScriptRegex().Replace(Content, string.Empty);
            }

            File.WriteAllText(HtmlFile, Content);
        }
    }

    [System.Text.RegularExpressions.GeneratedRegex(@"<script>\s*navigator\.serviceWorker\.register\([^)]+\)[^<]*</script>")]
    private static partial System.Text.RegularExpressions.Regex SwRegistrationRegex();

    [System.Text.RegularExpressions.GeneratedRegex(@"<script\s+src=""[^""]*sw-update[^""]*""\s*>\s*</script>")]
    private static partial System.Text.RegularExpressions.Regex SwUpdateScriptRegex();

    private static void ReplaceBlazorJsInHtml(string DeployDir, string? BlazorFile)
    {
        if (BlazorFile is null)
        {
            return;
        }

        var BlazorFileName = Path.GetFileName(BlazorFile);
        foreach (var HtmlFile in GetAllHtml(DeployDir))
        {
            var Content = File.ReadAllText(HtmlFile).Replace(BlazorJsPlain, BlazorFileName);
            File.WriteAllText(HtmlFile, Content);
        }
    }

    private static string FixServiceWorkerPublished(string DeployDir)
    {
        var SwPath = Path.Combine(DeployDir, ServiceWorkerPublished);
        return File.ReadAllText(SwPath)
            .Replace(FrameworkOld, FrameworkNew)
            .Replace(ContentOldSw, ContentNewSw)
            .Replace(SwImportLine, string.Empty);
    }

    private static void FixBlazorJsRefs(string? BlazorFile)
    {
        if (BlazorFile is null || !File.Exists(BlazorFile))
        {
            return;
        }

        var Content = File.ReadAllText(BlazorFile).Replace(FrameworkOld, FrameworkNew);
        File.WriteAllText(BlazorFile, Content);
    }

    private static void CreateFrameworkAliases(string DeployDir)
    {
        var FrameworkDir = Path.Combine(DeployDir, "Framework");
        if (!Directory.Exists(FrameworkDir))
        {
            return;
        }

        foreach (var FilePath in Directory.EnumerateFiles(FrameworkDir))
        {
            var Ext = Path.GetExtension(FilePath);
            if (Ext is not ".js" and not ".wasm" and not ".dat")
            {
                continue;
            }

            if (FilePath.EndsWith(".br") || FilePath.EndsWith(".gz"))
            {
                continue;
            }

            var FileName = Path.GetFileName(FilePath);
            var Match = FrameworkFingerprintRegex().Match(FileName);
            if (!Match.Success)
            {
                continue;
            }

            var BaseName = Match.Groups[1].Value + "." + Match.Groups[2].Value;
            var AliasPath = Path.Combine(FrameworkDir, BaseName);
            if (!File.Exists(AliasPath))
            {
                File.Copy(FilePath, AliasPath, false);
            }
        }
    }

    private static Dictionary<string, string> BuildFrameworkAliasMap(string DeployDir)
    {
        var Map = new Dictionary<string, string>();
        var FrameworkDir = Path.Combine(DeployDir, "Framework");
        if (!Directory.Exists(FrameworkDir))
        {
            return Map;
        }

        foreach (var FilePath in Directory.EnumerateFiles(FrameworkDir))
        {
            var FileName = Path.GetFileName(FilePath);
            var Match = FrameworkFingerprintRegex().Match(FileName);
            if (!Match.Success)
            {
                continue;
            }

            var BaseName = Match.Groups[1].Value + "." + Match.Groups[2].Value;
            var AliasPath = Path.Combine(FrameworkDir, BaseName);
            if (!File.Exists(AliasPath))
            {
                continue;
            }

            if (ComputeFileHash(AliasPath) == ComputeFileHash(FilePath))
            {
                Map[BaseName] = FileName;
            }
        }

        return Map;
    }

    private static Dictionary<string, string> BuildFrameworkAliasMap(string DeployDir)
    {
        var Map = new Dictionary<string, string>();
        var FrameworkDir = Path.Combine(DeployDir, "Framework");
        if (!Directory.Exists(FrameworkDir))
        {
            return Map;
        }

        foreach (var FilePath in Directory.EnumerateFiles(FrameworkDir))
        {
            var FileName = Path.GetFileName(FilePath);
            var Match = FrameworkFingerprintRegex().Match(FileName);
            if (!Match.Success)
            {
                continue;
            }

            var BaseName = Match.Groups[1].Value + "." + Match.Groups[2].Value;
            var AliasPath = Path.Combine(FrameworkDir, BaseName);
            if (!File.Exists(AliasPath))
            {
                continue;
            }

            if (ComputeFileHash(AliasPath) == ComputeFileHash(FilePath))
            {
                Map[BaseName] = FileName;
            }
        }

        return Map;
    }

    private static Dictionary<string, string> BuildFrameworkAliasMap(string DeployDir)
    {
        var Map = new Dictionary<string, string>();
        var FrameworkDir = Path.Combine(DeployDir, "Framework");
        if (!Directory.Exists(FrameworkDir))
        {
            return Map;
        }

        foreach (var FilePath in Directory.EnumerateFiles(FrameworkDir))
        {
            var FileName = Path.GetFileName(FilePath);
            var Match = FrameworkFingerprintRegex().Match(FileName);
            if (!Match.Success)
            {
                continue;
            }

            var BaseName = Match.Groups[1].Value + "." + Match.Groups[2].Value;
            var AliasPath = Path.Combine(FrameworkDir, BaseName);
            if (!File.Exists(AliasPath))
            {
                continue;
            }

            if (ComputeFileHash(AliasPath) == ComputeFileHash(FilePath))
            {
                Map[BaseName] = FileName;
            }
        }

        return Map;
    }

    private static Dictionary<string, string> BuildFrameworkAliasMap(string DeployDir)
    {
        var Map = new Dictionary<string, string>();
        var FrameworkDir = Path.Combine(DeployDir, "Framework");
        if (!Directory.Exists(FrameworkDir))
        {
            return Map;
        }

        foreach (var FilePath in Directory.EnumerateFiles(FrameworkDir))
        {
            var FileName = Path.GetFileName(FilePath);
            var Match = FrameworkFingerprintRegex().Match(FileName);
            if (!Match.Success)
            {
                continue;
            }

            var BaseName = Match.Groups[1].Value + "." + Match.Groups[2].Value;
            var AliasPath = Path.Combine(FrameworkDir, BaseName);
            if (!File.Exists(AliasPath))
            {
                continue;
            }

            if (ComputeFileHash(AliasPath) == ComputeFileHash(FilePath))
            {
                Map[BaseName] = FileName;
            }
        }

        return Map;
    }

    private static Dictionary<string, string> BuildFrameworkAliasMap(string DeployDir)
    {
        var Map = new Dictionary<string, string>();
        var FrameworkDir = Path.Combine(DeployDir, "Framework");
        if (!Directory.Exists(FrameworkDir))
        {
            return Map;
        }

        foreach (var FilePath in Directory.EnumerateFiles(FrameworkDir))
        {
            var FileName = Path.GetFileName(FilePath);
            var Match = FrameworkFingerprintRegex().Match(FileName);
            if (!Match.Success)
            {
                continue;
            }

            var BaseName = Match.Groups[1].Value + "." + Match.Groups[2].Value;
            var AliasPath = Path.Combine(FrameworkDir, BaseName);
            if (!File.Exists(AliasPath))
            {
                continue;
            }

            if (ComputeFileHash(AliasPath) == ComputeFileHash(FilePath))
            {
                Map[BaseName] = FileName;
            }
        }

        return Map;
    }

    private static void CopyAndFixSwAssets(string DeployDir, string SwAssetsSrc)
    {
        var Content = File.ReadAllText(SwAssetsSrc)
            .Replace(FrameworkOld, FrameworkNew)
            .Replace(ContentCssOld, ContentCssNew)
            .Replace(ContentJsOld, ContentJsNew)
            .Replace(ContentRootOld, ContentRootNew)
            .Replace("\"js/", "\"Js/")
            .Replace("\"data/", "\"Data/")
            .Replace("\"downloads/", "\"Downloads/");
        File.WriteAllText(Path.Combine(DeployDir, ServiceWorkerAssets), Content);
    }
}
