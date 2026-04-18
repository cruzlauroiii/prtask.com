using System.Text.Json;
using System.Text.Json.Nodes;
using PrTask.Git;
namespace PrTask.E2E;
public static partial class DeployHelper
{
    private static readonly string[] LegalPages =
    [
        "Terms", "Privacy", "CookiePolicy", "AcceptableUse",
        "Refund", "Licenses", "Accessibility", "Dmca",
    ];

    private static readonly string[] SpaFallbackDirs = ["Tasks", "Users"];

    private static void CreateSeoPages(string DeployDir)
    {
        var IdxFingerprinted = FindFingerprintedIndex(DeployDir);
        if (IdxFingerprinted is null)
        {
            return;
        }

        File.Copy(IdxFingerprinted, Path.Combine(DeployDir, "404.html"), true);
        foreach (var DirName in SpaFallbackDirs)
        {
            var Dir = Path.Combine(DeployDir, DirName);
            Directory.CreateDirectory(Dir);
            var IndexPath = Path.Combine(Dir, "index.html");
            if (!File.Exists(IndexPath))
            {
                File.Copy(IdxFingerprinted, IndexPath, true);
            }
        }

        var LegalDir = Path.Combine(DeployDir, "Legal");
        Directory.CreateDirectory(LegalDir);
        foreach (var Page in LegalPages)
        {
            var HasStub = File.Exists(Path.Combine(LegalDir, $"{Page}.html"));
            var HasFingerprinted = Directory
                .EnumerateFiles(LegalDir, $"{Page}.*.html").Any();
            if (!HasStub && !HasFingerprinted)
            {
                File.Copy(IdxFingerprinted, Path.Combine(LegalDir, $"{Page}.html"), true);
            }
        }
    }

    private static string? FindFingerprintedIndex(string DeployDir)
    {
        foreach (var F in Directory.EnumerateFiles(DeployDir, "index.*.html"))
        {
            if (FingerprintedIndexRegex().IsMatch(Path.GetFileName(F)))
            {
                return F;
            }
        }

        return null;
    }

    private static void ReFingerprintNewHtml(string DeployDir)
    {
        var ManifestPath = Path.Combine(DeployDir, HtmlManifestFile);
        var FpManifest = new Dictionary<string, string>();
        if (File.Exists(ManifestPath))
        {
            var Existing = JsonSerializer.Deserialize<Dictionary<string, string>>(
                File.ReadAllText(ManifestPath));
            if (Existing is not null)
            {
                foreach (var Kv in Existing)
                {
                    FpManifest[Kv.Key] = Kv.Value;
                }
            }
        }

        foreach (var HtmlFile in Directory.EnumerateFiles(
            DeployDir, "*.html", SearchOption.AllDirectories))
        {
            var FileName = Path.GetFileName(HtmlFile);
            if (AlreadyFingerprintedRegex().IsMatch(FileName))
            {
                continue;
            }

            var Content = File.ReadAllText(HtmlFile);
            if (Content.Contains("http-equiv=\"refresh\""))
            {
                continue;
            }

            var Bytes = File.ReadAllBytes(HtmlFile);
            var Hex = ComputeShortHash(Bytes);
            var BaseName = Path.GetFileNameWithoutExtension(HtmlFile);
            var RelDir = GetRelativeDir(HtmlFile, DeployDir);
            var FpName = $"{BaseName}.{Hex}.html";
            var FpPath = Path.Combine(Path.GetDirectoryName(HtmlFile)!, FpName);
            File.Copy(HtmlFile, FpPath, true);
            var RedirectHtml = $"<!DOCTYPE html><html><head><meta charset=\"utf-8\"/><meta http-equiv=\"refresh\" content=\"0;url={FpName}\"/><link rel=\"canonical\" href=\"{FpName}\"/></head><body><a href=\"{FpName}\">{FpName}</a></body></html>";
            File.WriteAllText(HtmlFile, RedirectHtml);
            var RouteKey = string.IsNullOrEmpty(RelDir) ? BaseName : $"{RelDir}/{BaseName}";
            var RouteValue = string.IsNullOrEmpty(RelDir) ? FpName : $"{RelDir}/{FpName}";
            FpManifest[RouteKey] = RouteValue;
        }

        File.WriteAllText(ManifestPath, JsonSerializer.Serialize(FpManifest));
    }

    private static void RecomputeAllSriHashes(string DeployDir)
    {
        var SwaPath = Path.Combine(DeployDir, ServiceWorkerAssets);
        if (!File.Exists(SwaPath))
        {
            return;
        }

        var SwaContent = File.ReadAllText(SwaPath);
        var StartIdx = SwaContent.IndexOf('{');
        if (StartIdx < 0)
        {
            return;
        }

        var JsonText = SwaContent[StartIdx..].TrimEnd(';', ' ', '\r', '\n');
        var Root = JsonNode.Parse(JsonText)!.AsObject();
        var Assets = Root["assets"]?.AsArray();
        if (Assets is null)
        {
            return;
        }

        foreach (var Asset in Assets)
        {
            if (Asset is null)
            {
                continue;
            }

            var Url = Asset["url"]?.GetValue<string>();
            if (Url is null)
            {
                continue;
            }

            var FilePath = Path.Combine(DeployDir, Url.Replace('/', Path.DirectorySeparatorChar));
            if (!File.Exists(FilePath))
            {
                continue;
            }

            var FileBytes = File.ReadAllBytes(FilePath);
            var Actual = ComputeSriHash(FileBytes);
            var Current = Asset["hash"]?.GetValue<string>();
            if (Actual != Current)
            {
                Asset["hash"] = Actual;
            }
        }

        var NewJson = Root.ToJsonString(new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(SwaPath, SwaPrefix + NewJson + ";");
    }

    private static void VerifyNoStaleRefs(string DeployDir)
    {
        var Problems = new List<string>();
        foreach (var F in GetAllHtml(DeployDir))
        {
            var Content = File.ReadAllText(F);
            if (Content.Contains(FrameworkOld))
            {
                Problems.Add($"STALE _framework/ in {Path.GetFileName(F)}");
            }

            if (Content.Contains(ContentOldSw))
            {
                Problems.Add($"STALE _content/ in {Path.GetFileName(F)}");
            }
        }

        foreach (var F in Directory.EnumerateFiles(DeployDir, "*.js", SearchOption.AllDirectories))
        {
            var FileName = Path.GetFileName(F);
            if (FileName == ServiceWorkerAssets)
            {
                continue;
            }

            if (F.Contains("Framework", StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            var Content = File.ReadAllText(F);
            if (Content.Contains(FrameworkOld))
            {
                Problems.Add($"STALE _framework/ in {FileName}");
            }

            if (Content.Contains(ContentOldSw))
            {
                Problems.Add($"STALE _content/ in {FileName}");
            }
        }

        if (Problems.Count > 0)
        {
            throw new InvalidOperationException(
                "Stale references found:\n" + string.Join("\n", Problems));
        }
    }

    private static void GitAddAll(string DeployDir)
    {
        var Psi = new ProcessStartInfo("git")
        {
            WorkingDirectory = DeployDir,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        };
        Psi.ArgumentList.Add("add");
        Psi.ArgumentList.Add("-A");
        using var Proc = Process.Start(Psi)!;
        Proc.StandardOutput.ReadToEnd();
        Proc.StandardError.ReadToEnd();
        Proc.WaitForExit();
    }

    private static void GitAddAll(string DeployDir)
    {
        var Psi = new ProcessStartInfo("git")
        {
            WorkingDirectory = DeployDir,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        };
        Psi.ArgumentList.Add("add");
        Psi.ArgumentList.Add("-A");
        using var Proc = Process.Start(Psi)!;
        Proc.StandardOutput.ReadToEnd();
        Proc.StandardError.ReadToEnd();
        Proc.WaitForExit();
    }

    private static void GitAddAll(string DeployDir)
    {
        var Psi = new ProcessStartInfo("git")
        {
            WorkingDirectory = DeployDir,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        };
        Psi.ArgumentList.Add("add");
        Psi.ArgumentList.Add("-A");
        using var Proc = Process.Start(Psi)!;
        Proc.StandardOutput.ReadToEnd();
        Proc.StandardError.ReadToEnd();
        Proc.WaitForExit();
    }

    private static void GitAddAll(string DeployDir)
    {
        var Psi = new ProcessStartInfo("git")
        {
            WorkingDirectory = DeployDir,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        };
        Psi.ArgumentList.Add("add");
        Psi.ArgumentList.Add("-A");
        using var Proc = Process.Start(Psi)!;
        Proc.StandardOutput.ReadToEnd();
        Proc.StandardError.ReadToEnd();
        Proc.WaitForExit();
    }

    private static async Task GitCommitAndPushAsync(string DeployDir)
    {
        AssertNotSourceTree(DeployDir);
        var GitDir = Path.Combine(DeployDir, ".git");
        GitRepository Repo;
        if (Directory.Exists(GitDir))
        {
            Repo = GitRepository.Open(DeployDir);
        }
        else
        {
            Repo = GitRepository.Init(DeployDir);
            var Remote = new GitRemote(Repo);
            Remote.AddRemote("origin", "https://github.com/cruzlauroiii/prtask.com.git");
        }

        var Branch = new GitBranch(Repo);

        var Index = new GitIndex(Repo);
        Index.Clear();
        Index.StageAll();

        const string OrphanBranch = "fresh-deploy";
        Repo.SetHead(OrphanBranch);

        var OrphanRefPath = Path.Combine(Repo.GitDir, "refs", "heads", OrphanBranch);
        if (File.Exists(OrphanRefPath))
        {
            File.Delete(OrphanRefPath);
        }

        var Committer = new GitCommit(Repo);
        Committer.CreateCommit(CommitMessage, DeployAuthorName, DeployAuthorEmail);

        try
        {
            Branch.DeleteBranch("Public");
        }
        catch (InvalidOperationException)
        {
        }

        Branch.RenameBranch(OrphanBranch, "Public");

        var PushRemote = new GitRemote(Repo);
        await PushRemote.PushAsync("origin", "Public");
    }
}
