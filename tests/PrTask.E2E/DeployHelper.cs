using System.Security.Cryptography;
using System.Text.Json;
using System.Text.RegularExpressions;
namespace PrTask.E2E;
public static partial class DeployHelper
{
    public const string DefaultDeployDir = @"C:\work\prtask-deploy";
    public const string DefaultPublishDir = @"C:\work\prtask.com\publish\web\wwwroot";
    private const string SourceTreeRoot = @"C:\work\prtask.com";
    private const string SourceTreeSentinelFile = "PrTask.sln";
    private const string SourceTreeSentinelDir = "src";
    private const string DeployAuthorName = "PrTask Deploy";
    private const string DeployAuthorEmail = "deploy@prtask.com";
    private const string PatchDir = "Patches";
    private const string SwAssetsRelPath = @"src\PrTask.Client\obj\Release\net11.0\service-worker\service-worker-assets.js.publish";
    private const string GitPagesBaseHref = @"<base href=""/prtask.com/"">";
    private const string OriginalBaseHref1 = @"<base href=""/"">";
    private const string OriginalBaseHref2 = @"<base href=""/"" />";
    private const string FrameworkOld = "_framework/";
    private const string FrameworkNew = "Framework/";
    private const string ContentCssOld = "_content/PrTask.SharedUI/css/";
    private const string ContentCssNew = "Css/";
    private const string ContentJsOld = "_content/PrTask.SharedUI/js/";
    private const string ContentJsNew = "Content/Js/";
    private const string ContentRootOld = "_content/PrTask.SharedUI/";
    private const string ContentRootNew = "Content/";
    private const string JsSrcLower1 = "src=\"js/";
    private const string JsSrcUpper1 = "src=\"Js/";
    private const string JsSrcLower2 = "src='js/";
    private const string JsSrcUpper2 = "src='Js/";
    private const string DataLower = "\"data/";
    private const string DataUpper = "\"Data/";
    private const string DownloadsLower = "\"downloads/";
    private const string DownloadsUpper = "\"Downloads/";
    private const string ManifestLink1 = "<link rel=\"manifest\" href=\"manifest.json\" />";
    private const string ManifestLink2 = "<link rel=\"manifest\" href=\"manifest.json\">";
    private const string ContentOldSw = "_content/";
    private const string ContentNewSw = "Content/";
    private const string SwImportLine = "importScripts('service-worker-assets.js');";
    private const string SwaPrefix = "self.assetsManifest = ";
    private const string BundleScopedPattern = "PrTask.SharedUI.*.bundle.scp.css";
    private const string BlazorJsGlob = "blazor.webassembly*.js";
    private const string BlazorJsPlain = "blazor.webassembly.js";
    private const string StylesCssName = "PrTask.Client.styles.css";
    private const string ServiceWorkerName = "service-worker.js";
    private const string ServiceWorkerPublished = "service-worker.published.js";
    private const string ServiceWorkerAssets = "service-worker-assets.js";
    private const string HtmlManifestFile = "_html-manifest.json";
    private const string NoJekyllFile = ".nojekyll";
    private const string GitAttributesContent = "* -text";
    private const string CustomDomain = "prtask.com";
    private const int HashLength = 10;
    private const string CommitMessage = "Deploy: restructured paths (Framework/, Css/, Content/, Js/), SEO route pages, minified, SRI fixed";

    [GeneratedRegex(@"^(.+?)\.[a-z0-9]{10,}\.(js|wasm|dat)$")]
    private static partial Regex FrameworkFingerprintRegex();

    [GeneratedRegex(@"\.[a-z0-9]{10,}\.\w+$")]
    private static partial Regex AlreadyFingerprintedRegex();

    [GeneratedRegex(@"^index\.[a-f0-9]{10}\.html$")]
    private static partial Regex FingerprintedIndexRegex();

    [GeneratedRegex(@"@import\s+'([^']+)'")]
    private static partial Regex CssImportRegex();

    private static void AssertNotSourceTree(string DeployDir)
    {
        var NormalizedDeploy = Path.GetFullPath(DeployDir);
        var NormalizedRoot = Path.GetFullPath(SourceTreeRoot);
        if (string.Equals(NormalizedDeploy, NormalizedRoot, StringComparison.OrdinalIgnoreCase))
        {
            throw new InvalidOperationException(
                $"SAFETY: refusing to operate on source tree root ({NormalizedDeploy})");
        }

        if (File.Exists(Path.Combine(DeployDir, SourceTreeSentinelFile)))
        {
            throw new InvalidOperationException(
                $"SAFETY: refusing to delete source tree (found {SourceTreeSentinelFile} in {DeployDir})");
        }

        if (Directory.Exists(Path.Combine(DeployDir, SourceTreeSentinelDir)))
        {
            throw new InvalidOperationException(
                $"SAFETY: refusing to delete source tree (found {SourceTreeSentinelDir} in {DeployDir})");
        }
    }

    public static async Task RestructureAndPushAsync(
        string DeployDir, string PublishDir, string SolutionRoot)
    {
        AssertNotSourceTree(DeployDir);
        var SwAssetsSrc = Path.Combine(SolutionRoot, SwAssetsRelPath);
        CleanDeployDir(DeployDir);
        WriteGitAttributes(DeployDir);
        CopyPublishOutput(PublishDir, DeployDir);
        RemoveCompressedAndCname(DeployDir);
        RenameFramework(DeployDir);
        FlattenContent(DeployDir);
        RenameLowercaseFolders(DeployDir);
        RemoveMinified(DeployDir);
        DeleteManifestJson(DeployDir);
        CreateNoJekyll(DeployDir);
        var BlazorFile = DiscoverBlazorJs(DeployDir);
        FixHtmlPathRefs(DeployDir);
        ReplaceBlazorJsInHtml(DeployDir, BlazorFile);
        var SwPubContent = FixServiceWorkerPublished(DeployDir);
        FixBlazorJsRefs(BlazorFile);
        CreateFrameworkAliases(DeployDir);
        CopyAndFixSwAssets(DeployDir, SwAssetsSrc);
        var AssetMap = FingerprintCustomAssets(DeployDir);
        UpdateHtmlWithFingerprints(DeployDir, AssetMap);
        UpdateSwPublishedWithFingerprints(DeployDir, AssetMap, ref SwPubContent);
        UpdateSwAssetsWithFingerprints(DeployDir, AssetMap);
        InlineServiceWorker(DeployDir, AssetMap, SwPubContent);
        InlineStylesCss(DeployDir);
        DeleteNonFingerprintedOriginals(DeployDir, AssetMap);
        DeleteHeaders(DeployDir);
        PatchFrameworkAppsettings(DeployDir, AssetMap);
        FingerprintAllHtml(DeployDir);
        CreateSeoPages(DeployDir);
        ReFingerprintNewHtml(DeployDir);
        RecomputeAllSriHashes(DeployDir);
        VerifyNoStaleRefs(DeployDir);
        await GitCommitAndPushAsync(DeployDir);
    }

    private static void CleanDeployDir(string DeployDir)
    {
        AssertNotSourceTree(DeployDir);
        foreach (var Entry in Directory.EnumerateFileSystemEntries(DeployDir))
        {
            var Name = Path.GetFileName(Entry);
            if (Name is ".git" or ".gitattributes")
            {
                continue;
            }

            if (Directory.Exists(Entry))
            {
                Directory.Delete(Entry, true);
            }
            else
            {
                File.Delete(Entry);
            }
        }
    }

    private static void WriteGitAttributes(string DeployDir) =>
        File.WriteAllText(Path.Combine(DeployDir, ".gitattributes"), GitAttributesContent);

    private static void CopyPublishOutput(string PublishDir, string DeployDir) =>
        CopyDirectoryRecursive(PublishDir, DeployDir);

    private static void RemoveCompressedAndCname(string DeployDir)
    {
        foreach (var F in Directory.EnumerateFiles(DeployDir, "*", SearchOption.AllDirectories))
        {
            if (F.EndsWith(".br", StringComparison.OrdinalIgnoreCase) ||
                F.EndsWith(".gz", StringComparison.OrdinalIgnoreCase))
            {
                File.Delete(F);
            }
        }

        var CnamePath = Path.Combine(DeployDir, "CNAME");
        if (File.Exists(CnamePath))
        {
            File.Delete(CnamePath);
        }
    }

    private static void RenameFramework(string DeployDir)
    {
        var Old = Path.Combine(DeployDir, "_framework");
        if (Directory.Exists(Old))
        {
            Directory.Move(Old, Path.Combine(DeployDir, "Framework"));
        }
    }

    private static void FlattenContent(string DeployDir)
    {
        var CssDir = Path.Combine(DeployDir, "Css");
        Directory.CreateDirectory(CssDir);
        CopyFilesFromDir(Path.Combine(DeployDir, "_content", "PrTask.SharedUI", "css"), CssDir);
        var ContentJsDir = Path.Combine(DeployDir, "Content", "Js");
        Directory.CreateDirectory(ContentJsDir);
        CopyFilesFromDir(Path.Combine(DeployDir, "_content", "PrTask.SharedUI", "js"), ContentJsDir);
        var ContentDir = Path.Combine(DeployDir, "Content");
        var BundleSource = Path.Combine(DeployDir, "_content", "PrTask.SharedUI");
        if (Directory.Exists(BundleSource))
        {
            foreach (var F in Directory.EnumerateFiles(BundleSource, BundleScopedPattern))
            {
                File.Copy(F, Path.Combine(ContentDir, Path.GetFileName(F)), true);
            }
        }

        var ContentOld = Path.Combine(DeployDir, "_content");
        if (Directory.Exists(ContentOld))
        {
            Directory.Delete(ContentOld, true);
        }
    }

    private static void RenameLowercaseFolders(string DeployDir)
    {
        (string, string)[] Pairs = [("js", "Js"), ("data", "Data"), ("downloads", "Downloads")];
        foreach (var (OldName, NewName) in Pairs)
        {
            var OldPath = Path.Combine(DeployDir, OldName);
            if (!Directory.Exists(OldPath))
            {
                continue;
            }

            var TmpPath = OldPath + "_tmp";
            Directory.Move(OldPath, TmpPath);
            Directory.Move(TmpPath, Path.Combine(DeployDir, NewName));
        }
    }

    private static void RemoveMinified(string DeployDir)
    {
        foreach (var F in Directory.EnumerateFiles(DeployDir, "*.min.js", SearchOption.AllDirectories))
        {
            File.Delete(F);
        }

        foreach (var F in Directory.EnumerateFiles(DeployDir, "*.min.css", SearchOption.AllDirectories))
        {
            File.Delete(F);
        }
    }

    private static void DeleteManifestJson(string DeployDir)
    {
        var P = Path.Combine(DeployDir, "manifest.json");
        if (File.Exists(P))
        {
            File.Delete(P);
        }
    }

    private static void CreateNoJekyll(string DeployDir) =>
        File.WriteAllBytes(Path.Combine(DeployDir, NoJekyllFile), []);

    private static string? DiscoverBlazorJs(string DeployDir)
    {
        var FrameworkDir = Path.Combine(DeployDir, "Framework");
        if (!Directory.Exists(FrameworkDir))
        {
            return null;
        }

        foreach (var F in Directory.EnumerateFiles(FrameworkDir, BlazorJsGlob))
        {
            if (!F.EndsWith(".br") && !F.EndsWith(".gz"))
            {
                return F;
            }
        }

        return null;
    }

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
            File.WriteAllText(HtmlFile, Content);
        }
    }

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
