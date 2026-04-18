using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
namespace PrTask.E2E;
public static partial class DeployHelper
{
    private static readonly (string Dir, string Filter)[] AssetDirFilters =
    [
        ("Js", "*.js"),
        ("Css", "*.css"),
        (Path.Combine("Content", "Js"), "*.js"),
        ("Content", "*.css"),
        (".", "appsettings*.json"),
        (".", "*.png"),
        (".", "*.ico"),
        (".", "*.svg"),
    ];

    private static Dictionary<string, string> FingerprintCustomAssets(string DeployDir)
    {
        var AssetMap = new Dictionary<string, string>();
        foreach (var (SubDir, Filter) in AssetDirFilters)
        {
            var FullDir = SubDir == "." ? DeployDir : Path.Combine(DeployDir, SubDir);
            if (!Directory.Exists(FullDir))
            {
                continue;
            }

            foreach (var FilePath in Directory.EnumerateFiles(FullDir, Filter))
            {
                var FileName = Path.GetFileName(FilePath);
                if (AlreadyFingerprintedRegex().IsMatch(FileName))
                {
                    continue;
                }

                var Hex = ComputeFileHash(FilePath);
                var Ext = Path.GetExtension(FileName);
                var Base = Path.GetFileNameWithoutExtension(FileName);
                var FpName = $"{Base}.{Hex}{Ext}";
                var FpPath = Path.Combine(Path.GetDirectoryName(FilePath)!, FpName);
                File.Copy(FilePath, FpPath, true);
                AssetMap[FileName] = FpName;
            }
        }

        return AssetMap;
    }

    private static void UpdateHtmlWithFingerprints(
        string DeployDir, Dictionary<string, string> AssetMap)
    {
        foreach (var HtmlFile in GetAllHtml(DeployDir))
        {
            var Content = File.ReadAllText(HtmlFile);
            foreach (var (OldName, NewName) in AssetMap)
            {
                Content = Content.Replace(OldName, NewName);
            }

            File.WriteAllText(HtmlFile, Content);
        }
    }

    private static void UpdateSwPublishedWithFingerprints(
        string DeployDir, Dictionary<string, string> AssetMap, ref string SwPubContent)
    {
        foreach (var (OldName, NewName) in AssetMap)
        {
            SwPubContent = SwPubContent.Replace(OldName, NewName);
        }
    }

    private static void UpdateSwAssetsWithFingerprints(
        string DeployDir, Dictionary<string, string> AssetMap)
    {
        var SwaPath = Path.Combine(DeployDir, ServiceWorkerAssets);
        if (!File.Exists(SwaPath))
        {
            return;
        }

        var SwaText = File.ReadAllText(SwaPath);
        foreach (var (OldName, NewName) in AssetMap)
        {
            SwaText = SwaText.Replace(OldName, NewName);
        }

        foreach (var Entry in AssetMap)
        {
            var FpFile = FindFileRecursive(DeployDir, Entry.Value);
            if (FpFile is null)
            {
                continue;
            }

            var FpBytes = File.ReadAllBytes(FpFile);
            var FpHash = Convert.ToBase64String(SHA256.HashData(FpBytes));
            var EscapedName = Regex.Escape(Entry.Value);
            var Pattern = $"(\"{EscapedName}\",\\s*\"hash\":\\s*\"sha256-)[^\"]+\"";
            SwaText = Regex.Replace(SwaText, Pattern, $"${{1}}{FpHash}\"");
        }

        File.WriteAllText(SwaPath, SwaText);
    }

    private static void InlineServiceWorker(
        string DeployDir, Dictionary<string, string> AssetMap, string SwPubContent)
    {
        var SwaPath = Path.Combine(DeployDir, ServiceWorkerAssets);
        var SwaContent = File.ReadAllText(SwaPath);
        var SwCombined = SwaContent + "\n" + SwPubContent;
        var SwPath = Path.Combine(DeployDir, ServiceWorkerName);
        File.WriteAllText(SwPath, SwCombined);
        File.Delete(Path.Combine(DeployDir, ServiceWorkerPublished));
        File.Delete(SwaPath);
        var SwHex = ComputeShortHash(Encoding.UTF8.GetBytes(SwCombined));
        var SwFpName = $"service-worker.{SwHex}.js";
        File.Copy(SwPath, Path.Combine(DeployDir, SwFpName), true);
        File.Delete(SwPath);
        foreach (var HtmlFile in GetAllHtml(DeployDir))
        {
            var Content = File.ReadAllText(HtmlFile).Replace(ServiceWorkerName, SwFpName);
            File.WriteAllText(HtmlFile, Content);
        }
    }

    private static void InlineStylesCss(string DeployDir)
    {
        var StylesPath = Path.Combine(DeployDir, StylesCssName);
        if (!File.Exists(StylesPath))
        {
            return;
        }

        var StylesContent = File.ReadAllText(StylesPath);
        var ImportMatch = CssImportRegex().Match(StylesContent);
        if (ImportMatch.Success)
        {
            var ImportRelPath = ImportMatch.Groups[1].Value
                .Replace("_content/PrTask.SharedUI/", "Content/");
            var ImportedFile = Path.Combine(
                DeployDir, ImportRelPath.Replace('/', Path.DirectorySeparatorChar));
            if (File.Exists(ImportedFile))
            {
                StylesContent = File.ReadAllText(ImportedFile);
            }

            File.WriteAllText(StylesPath, StylesContent);
        }

        var ContentDir = Path.Combine(DeployDir, "Content");
        if (Directory.Exists(ContentDir))
        {
            foreach (var F in Directory.EnumerateFiles(ContentDir, "*bundle.scp*"))
            {
                File.Delete(F);
            }
        }

        var StHex = ComputeFileHash(StylesPath);
        var StFpName = $"PrTask.Client.styles.{StHex}.css";
        File.Copy(StylesPath, Path.Combine(DeployDir, StFpName), true);
        File.Delete(StylesPath);
        foreach (var HtmlFile in GetAllHtml(DeployDir))
        {
            var Content = File.ReadAllText(HtmlFile).Replace(StylesCssName, StFpName);
            File.WriteAllText(HtmlFile, Content);
        }
    }

    private static void DeleteNonFingerprintedOriginals(
        string DeployDir, Dictionary<string, string> AssetMap)
    {
        foreach (var Entry in AssetMap)
        {
            foreach (var F in Directory.EnumerateFiles(
                DeployDir, Entry.Key, SearchOption.AllDirectories))
            {
                var Dir = Path.GetDirectoryName(F)!;
                if (Dir.Contains("Framework", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                if (Path.GetFileName(F).StartsWith("appsettings", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                File.Delete(F);
            }
        }
    }

    private static void DeleteHeaders(string DeployDir)
    {
        var P = Path.Combine(DeployDir, "_headers");
        if (File.Exists(P))
        {
            File.Delete(P);
        }
    }

    private static void PatchFrameworkAppsettings(
        string DeployDir, Dictionary<string, string> AssetMap)
    {
        if (!AssetMap.TryGetValue("appsettings.json", out var FingerprintedName))
        {
            return;
        }

        var FrameworkDir = Path.Combine(DeployDir, "Framework");
        if (!Directory.Exists(FrameworkDir))
        {
            return;
        }

        foreach (var JsFile in Directory.EnumerateFiles(FrameworkDir, "dotnet*.js"))
        {
            if (JsFile.EndsWith(".br") || JsFile.EndsWith(".gz"))
            {
                continue;
            }

            var OrigContent = File.ReadAllText(JsFile);
            if (!OrigContent.Contains("appsettings.json"))
            {
                continue;
            }

            var NewContent = OrigContent.Replace("appsettings.json", FingerprintedName);
            var PatchText = GenerateUnifiedDiff(JsFile, OrigContent, NewContent);
            ApplyGitPatch(DeployDir, PatchText);
        }
    }

    private static string GenerateUnifiedDiff(
        string FilePath, string OldContent, string NewContent)
    {
        var OldLines = OldContent.Split('\n');
        var NewLines = NewContent.Split('\n');
        var Sb = new StringBuilder();
        Sb.AppendLine($"--- a/{Path.GetFileName(FilePath)}");
        Sb.AppendLine($"+++ b/{Path.GetFileName(FilePath)}");
        for (var I = 0; I < OldLines.Length; I++)
        {
            if (I < NewLines.Length && OldLines[I] != NewLines[I])
            {
                var LineNum = I + 1;
                Sb.AppendLine($"@@ -{LineNum},1 +{LineNum},1 @@");
                Sb.AppendLine($"-{OldLines[I]}");
                Sb.AppendLine($"+{NewLines[I]}");
            }
        }

        return Sb.ToString();
    }

    private static void ApplyGitPatch(string WorkDir, string PatchText)
    {
        var Psi = new ProcessStartInfo("git", "apply -C0 --unsafe-paths")
        {
            WorkingDirectory = WorkDir,
            RedirectStandardInput = true,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        };
        using var Proc = Process.Start(Psi)!;
        Proc.StandardInput.Write(PatchText);
        Proc.StandardInput.Close();
        Proc.WaitForExit();
    }

    private static void FingerprintAllHtml(string DeployDir)
    {
        var Manifest = new Dictionary<string, string>();
        foreach (var HtmlFile in GetAllHtml(DeployDir))
        {
            var Bytes = File.ReadAllBytes(HtmlFile);
            var Hex = ComputeShortHash(Bytes);
            var BaseName = Path.GetFileNameWithoutExtension(HtmlFile);
            var RelDir = GetRelativeDir(HtmlFile, DeployDir);
            var FpName = $"{BaseName}.{Hex}.html";
            var FpPath = Path.Combine(Path.GetDirectoryName(HtmlFile)!, FpName);
            var FullContent = File.ReadAllText(HtmlFile);
            var RouteSuffix = string.IsNullOrEmpty(RelDir) ? BaseName : $"{RelDir}/{BaseName}";
            if (BaseName == "index")
            {
                RouteSuffix = string.Empty;
            }

            var RouteScript = $"<script>(function(){{var p=location.hostname==='{CustomDomain}'?'/':'/{CustomDomain}/';history.replaceState(null,'',p+'{RouteSuffix}');}})();</script>";
            FullContent = FullContent.Replace(GitPagesBaseHref, GitPagesBaseHref + RouteScript);
            File.WriteAllText(FpPath, FullContent);
            var RedirectHtml = $"<!DOCTYPE html><html><head><meta charset=\"utf-8\"/><meta http-equiv=\"refresh\" content=\"0;url={FpName}\"/><link rel=\"canonical\" href=\"{FpName}\"/><style>html,body{{margin:0;background:#1a1a2e}}</style></head><body></body></html>";
            File.WriteAllText(HtmlFile, RedirectHtml);
            var RouteKey = string.IsNullOrEmpty(RelDir) ? BaseName : $"{RelDir}/{BaseName}";
            var RouteValue = string.IsNullOrEmpty(RelDir) ? FpName : $"{RelDir}/{FpName}";
            Manifest[RouteKey] = RouteValue;
        }

        File.WriteAllText(
            Path.Combine(DeployDir, HtmlManifestFile), JsonSerializer.Serialize(Manifest));
    }

    private static string? FindFileRecursive(string Dir, string FileName)
    {
        foreach (var F in Directory.EnumerateFiles(Dir, FileName, SearchOption.AllDirectories))
        {
            return F;
        }

        return null;
    }

    private static string GetRelativeDir(string FilePath, string BaseDir)
    {
        var Dir = Path.GetDirectoryName(FilePath)!;
        if (Dir.Equals(BaseDir, StringComparison.OrdinalIgnoreCase))
        {
            return string.Empty;
        }

        return Dir[(BaseDir.Length + 1)..].Replace('\\', '/');
    }

    private static void CopyDirectoryRecursive(string Source, string Dest)
    {
        Directory.CreateDirectory(Dest);
        foreach (var F in Directory.EnumerateFiles(Source))
        {
            File.Copy(F, Path.Combine(Dest, Path.GetFileName(F)), true);
        }

        foreach (var D in Directory.EnumerateDirectories(Source))
        {
            var DirName = Path.GetFileName(D);
            CopyDirectoryRecursive(D, Path.Combine(Dest, DirName));
        }
    }

    private static void CopyFilesFromDir(string Source, string Dest)
    {
        if (!Directory.Exists(Source))
        {
            return;
        }

        foreach (var F in Directory.EnumerateFiles(Source))
        {
            File.Copy(F, Path.Combine(Dest, Path.GetFileName(F)), true);
        }
    }

    private static string[] GetAllHtml(string DeployDir) =>
        Directory.GetFiles(DeployDir, "*.html", SearchOption.AllDirectories);

    internal static string ComputeShortHash(byte[] Bytes)
    {
        var HashBytes = SHA256.HashData(Bytes);
        return Convert.ToHexStringLower(HashBytes)[..HashLength];
    }

    internal static string ComputeFileHash(string FilePath) =>
        ComputeShortHash(File.ReadAllBytes(FilePath));

    internal static string ComputeSriHash(byte[] Bytes)
    {
        var HashBytes = SHA256.HashData(Bytes);
        return "sha256-" + Convert.ToBase64String(HashBytes);
    }
}
