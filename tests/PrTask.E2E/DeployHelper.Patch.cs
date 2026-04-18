using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public static partial class DeployHelper
{
    private static void PatchFrameworkAppsettings(
        string DeployDir, Dictionary<string, string> AssetMap)
    {
        if (!AssetMap.TryGetValue("appsettings.json", out var FpName))
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

            var Content = File.ReadAllText(JsFile);
            if (!Content.Contains("appsettings.json"))
            {
                continue;
            }

            ApplyByteReplacements(JsFile,
                [("appsettings.json", FpName)]);
        }
    }

    private static void PatchBlazorJsToFingerprintedDotnet(
        string DeployDir, Dictionary<string, string> FrameworkAliasMap)
    {
        var FrameworkDir = Path.Combine(DeployDir, "Framework");
        if (!Directory.Exists(FrameworkDir))
        {
            return;
        }

        var DotnetMap = FrameworkAliasMap;

        foreach (var BlazorJs in Directory.EnumerateFiles(FrameworkDir, BlazorJsGlob))
        {
            if (BlazorJs.EndsWith(".br") || BlazorJs.EndsWith(".gz"))
            {
                continue;
            }

            var Content = Encoding.UTF8.GetString(File.ReadAllBytes(BlazorJs));
            var Pairs = new List<(string Search, string Replace)>();
            foreach (var (Plain, Fingerprinted) in DotnetMap)
            {
                if (!Content.Contains(Plain))
                {
                    continue;
                }

                Pairs.Add(($"\"./{Plain}\"", $"\"./{Fingerprinted}\""));
                Pairs.Add(($"\"{Plain}\"", $"\"{Fingerprinted}\""));
            }

            if (Pairs.Count > 0)
            {
                ApplyByteReplacements(BlazorJs, [.. Pairs]);
            }
        }
    }

    private static void GenerateAndApplyPatch(
        string DeployDir, string TargetFile,
        (string Search, string Replace)[] ByteReplacements, string PatchName)
    {
        var PatchesDir = Path.Combine(DeployDir, PatchDir);
        Directory.CreateDirectory(PatchesDir);
        var FileName = Path.GetFileName(TargetFile);
        var TempOriginal = Path.Combine(PatchesDir, "a_" + FileName);
        var TempModified = Path.Combine(PatchesDir, "b_" + FileName);
        File.Copy(TargetFile, TempOriginal, true);
        var ModBytes = File.ReadAllBytes(TargetFile);
        foreach (var (Search, Replace) in ByteReplacements)
        {
            ModBytes = ByteReplace(ModBytes, Encoding.UTF8.GetBytes(Search), Encoding.UTF8.GetBytes(Replace));
        }

        File.WriteAllBytes(TempModified, ModBytes);
        var RelPath = Path.GetRelativePath(DeployDir, TargetFile).Replace('\\', '/');
        var PatchFile = Path.Combine(PatchesDir, PatchName);
        var RawPatchFile = PatchFile + ".raw";
        var DiffPsi = new ProcessStartInfo("git")
        {
            WorkingDirectory = PatchesDir,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        };
        DiffPsi.ArgumentList.Add("diff");
        DiffPsi.ArgumentList.Add("--no-index");
        DiffPsi.ArgumentList.Add("--binary");
        DiffPsi.ArgumentList.Add($"--output={RawPatchFile}");
        DiffPsi.ArgumentList.Add("--");
        DiffPsi.ArgumentList.Add($"a_{FileName}");
        DiffPsi.ArgumentList.Add($"b_{FileName}");
        using var DiffProc = Process.Start(DiffPsi)!;
        DiffProc.StandardError.ReadToEnd();
        DiffProc.WaitForExit();
        var PatchBytes = File.ReadAllBytes(RawPatchFile);
        PatchBytes = ByteReplace(PatchBytes,
            Encoding.UTF8.GetBytes($"a/a_{FileName}"),
            Encoding.UTF8.GetBytes($"a/{RelPath}"));
        PatchBytes = ByteReplace(PatchBytes,
            Encoding.UTF8.GetBytes($"b/b_{FileName}"),
            Encoding.UTF8.GetBytes($"b/{RelPath}"));
        File.WriteAllBytes(PatchFile, PatchBytes);
        File.Delete(TempOriginal);
        File.Delete(TempModified);
        File.Delete(RawPatchFile);
        var ReAddPsi = new ProcessStartInfo("git")
        {
            WorkingDirectory = DeployDir,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        };
        ReAddPsi.ArgumentList.Add("add");
        ReAddPsi.ArgumentList.Add(RelPath);
        using var ReAddProc = Process.Start(ReAddPsi)!;
        ReAddProc.StandardOutput.ReadToEnd();
        ReAddProc.StandardError.ReadToEnd();
        ReAddProc.WaitForExit();
        var ReAddPsi = new ProcessStartInfo("git")
        {
            WorkingDirectory = DeployDir,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        };
        ReAddPsi.ArgumentList.Add("add");
        ReAddPsi.ArgumentList.Add(RelPath);
        using var ReAddProc = Process.Start(ReAddPsi)!;
        ReAddProc.StandardOutput.ReadToEnd();
        ReAddProc.StandardError.ReadToEnd();
        ReAddProc.WaitForExit();
        var ReAddPsi = new ProcessStartInfo("git")
        {
            WorkingDirectory = DeployDir,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        };
        ReAddPsi.ArgumentList.Add("add");
        ReAddPsi.ArgumentList.Add(RelPath);
        using var ReAddProc = Process.Start(ReAddPsi)!;
        ReAddProc.StandardOutput.ReadToEnd();
        ReAddProc.StandardError.ReadToEnd();
        ReAddProc.WaitForExit();
        var ReAddPsi = new ProcessStartInfo("git")
        {
            WorkingDirectory = DeployDir,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        };
        ReAddPsi.ArgumentList.Add("add");
        ReAddPsi.ArgumentList.Add(RelPath);
        using var ReAddProc = Process.Start(ReAddPsi)!;
        ReAddProc.StandardOutput.ReadToEnd();
        ReAddProc.StandardError.ReadToEnd();
        ReAddProc.WaitForExit();
        var ReAddPsi = new ProcessStartInfo("git")
        {
            WorkingDirectory = DeployDir,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        };
        ReAddPsi.ArgumentList.Add("add");
        ReAddPsi.ArgumentList.Add(RelPath);
        using var ReAddProc = Process.Start(ReAddPsi)!;
        ReAddProc.StandardOutput.ReadToEnd();
        ReAddProc.StandardError.ReadToEnd();
        ReAddProc.WaitForExit();
        var ApplyPsi = new ProcessStartInfo("git")
        {
            WorkingDirectory = DeployDir,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        };
        ApplyPsi.ArgumentList.Add("apply");
        ApplyPsi.ArgumentList.Add("-C0");
        ApplyPsi.ArgumentList.Add("--whitespace=nowarn");
        ApplyPsi.ArgumentList.Add("--binary");
        ApplyPsi.ArgumentList.Add("--ignore-whitespace");
        ApplyPsi.ArgumentList.Add(PatchFile);
        using var ApplyProc = Process.Start(ApplyPsi)!;
        var ApplyOut = ApplyProc.StandardOutput.ReadToEnd();
        var ApplyErr = ApplyProc.StandardError.ReadToEnd();
        ApplyProc.WaitForExit();
        if (ApplyProc.ExitCode != 0)
        {
            throw new InvalidOperationException(
                $"git apply -C0 {PatchName} failed (exit {ApplyProc.ExitCode}): {ApplyErr}");
        }
    }

    private static void FingerprintAllHtml(string DeployDir)
    {
        var Manifest = new Dictionary<string, string>();
        foreach (var HtmlFile in GetAllHtml(DeployDir))
        {
            var FileName = Path.GetFileName(HtmlFile);
            if (FileName.Equals("index.html", StringComparison.OrdinalIgnoreCase)
                && Path.GetDirectoryName(HtmlFile)!.Equals(DeployDir, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            var FileName = Path.GetFileName(HtmlFile);
            if (FileName.Equals("index.html", StringComparison.OrdinalIgnoreCase)
                && Path.GetDirectoryName(HtmlFile)!.Equals(DeployDir, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            var FileName = Path.GetFileName(HtmlFile);
            if (FileName.Equals("index.html", StringComparison.OrdinalIgnoreCase)
                && Path.GetDirectoryName(HtmlFile)!.Equals(DeployDir, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            var FileName = Path.GetFileName(HtmlFile);
            if (FileName.Equals("index.html", StringComparison.OrdinalIgnoreCase)
                && Path.GetDirectoryName(HtmlFile)!.Equals(DeployDir, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            var FileName = Path.GetFileName(HtmlFile);
            if (FileName.Equals("index.html", StringComparison.OrdinalIgnoreCase)
                && Path.GetDirectoryName(HtmlFile)!.Equals(DeployDir, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            var FileName = Path.GetFileName(HtmlFile);
            if (FileName.Equals("index.html", StringComparison.OrdinalIgnoreCase)
                && Path.GetDirectoryName(HtmlFile)!.Equals(DeployDir, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            var Bytes = File.ReadAllBytes(HtmlFile);
            var Hex = ComputeShortHash(Bytes);
            var BaseName = Path.GetFileNameWithoutExtension(HtmlFile);
            var RelDir = GetRelativeDir(HtmlFile, DeployDir);
            var FpName = $"{BaseName}.{Hex}.html";
            var FpPath = Path.Combine(Path.GetDirectoryName(HtmlFile)!, FpName);
            var FullContent = File.ReadAllText(HtmlFile);
#pragma warning disable CS0162, IDE0059
            if (AppConstants.JavaScriptEnabled)
            {
                var RouteSuffix = string.IsNullOrEmpty(RelDir) ? BaseName : $"{RelDir}/{BaseName}";
                if (BaseName == "index")
                {
                    RouteSuffix = string.Empty;
                }

                var RouteScript = $"<script>(function(){{var p=location.hostname==='{CustomDomain}'?'/':'/{CustomDomain}/';history.replaceState(null,'',p+'{RouteSuffix}');}})();</script>";
                FullContent = FullContent.Replace(GitPagesBaseHref, GitPagesBaseHref + RouteScript);
            }
#pragma warning restore CS0162, IDE0059
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
        return Dir.Equals(BaseDir, StringComparison.OrdinalIgnoreCase)
            ? string.Empty
            : Dir[(BaseDir.Length + 1)..].Replace('\\', '/');
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
