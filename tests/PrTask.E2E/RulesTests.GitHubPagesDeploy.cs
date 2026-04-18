using System.Diagnostics;
using System.Text.RegularExpressions;
namespace PrTask.E2E;
public partial class RulesTests
{
    private const string GitHubPagesRepo = "cruzlauroiii/prtask.com";
    private const string GitHubPagesBranch = "Public";
    private const string GitHubPagesUrl = "https://cruzlauroiii.github.io/prtask.com/";
    private const string GitHubPagesWorkDir = @"C:\work\prtask-deploy";
    private const string GeneratedWwwRoot = @"C:\work\prtask.com\src\PrTask.Client\bin\Release\net10.0\wwwroot";
    private const string GitHubSecretsProject = @"C:\work\prtask.com\src\PrTask.Server\PrTask.Server.csproj";

    [GeneratedRegex("content=\"0;url=([^\"]+)\"")]
    private static partial Regex MetaRefreshRegex();

    [TestMethod, TestCategory("Deploy")]
    [Timeout(1800000)]
    [DisplayName("GitHubPages deploy exact generated wwwroot to Public branch and remove stale files")]
    public async Task DeployGeneratedWwwRootToGitHubPagesAsync()
    {
        Assert.IsTrue(Directory.Exists(GeneratedWwwRoot), $"Generated wwwroot not found: {GeneratedWwwRoot}");
        var Pat = GetGitHubPatFromUserSecrets();
        Assert.IsFalse(string.IsNullOrWhiteSpace(Pat), "GitHub PAT not found in dotnet user-secrets");

        ResetDirectory(GitHubPagesWorkDir);
        var RepoUrl = $"https://x-access-token:{Pat}@github.com/{GitHubPagesRepo}.git";

        var (CloneExit, CloneOut, CloneErr) = await RunShellProcessAsync(
            "git",
            $"clone --branch {GitHubPagesBranch} --single-branch {RepoUrl} \"{GitHubPagesWorkDir}\"",
            SolutionRoot,
            300000);
        Assert.AreEqual(0, CloneExit, $"git clone failed:\n{CloneOut}\n{CloneErr}");

        ClearWorkingTreeExceptGit(GitHubPagesWorkDir);
        CopyDirectoryContents(GeneratedWwwRoot, GitHubPagesWorkDir);
        File.WriteAllBytes(Path.Combine(GitHubPagesWorkDir, ".nojekyll"), []);

        var (StatusExit, StatusOut, StatusErr) = await RunShellProcessAsync(
            "git",
            "status --short",
            GitHubPagesWorkDir,
            30000);
        Assert.AreEqual(0, StatusExit, $"git status failed:\n{StatusOut}\n{StatusErr}");

        if (string.IsNullOrWhiteSpace(StatusOut))
        {
            await AssertGitHubPagesServesCurrentOutputAsync();
            return;
        }

        await RunRequiredGitCommandAsync("config user.name \"PrTask Deploy Test\"", GitHubPagesWorkDir);
        await RunRequiredGitCommandAsync("config user.email \"deploy-test@prtask.com\"", GitHubPagesWorkDir);
        await RunRequiredGitCommandAsync("add -A", GitHubPagesWorkDir, 120000);
        await RunRequiredGitCommandAsync("commit -m \"Deploy generated wwwroot to GitHub Pages\"", GitHubPagesWorkDir, 120000);
        await RunRequiredGitCommandAsync($"push origin HEAD:{GitHubPagesBranch}", GitHubPagesWorkDir, 300000);

        await AssertGitHubPagesServesCurrentOutputAsync();
    }

    private static string GetGitHubPatFromUserSecrets()
    {
        var StartInfo = new ProcessStartInfo
        {
            FileName = "dotnet",
            Arguments = $"user-secrets list --project \"{GitHubSecretsProject}\"",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
            WorkingDirectory = SolutionRoot
        };
        using var Process = Process.Start(StartInfo)!;
        var Output = Process.StandardOutput.ReadToEnd();
        Process.WaitForExit(30000);
        foreach (var Line in Output.Split(['\r', '\n'], StringSplitOptions.RemoveEmptyEntries))
        {
            if (Line.StartsWith("GitHub:Pat = ", StringComparison.Ordinal))
            {
                return Line["GitHub:Pat = ".Length..].Trim();
            }
        }

        return string.Empty;
    }

    private static void ResetDirectory(string PathValue)
    {
        if (Directory.Exists(PathValue))
        {
            Directory.Delete(PathValue, true);
        }
    }

    private static void ClearWorkingTreeExceptGit(string Root)
    {
        foreach (var Entry in Directory.EnumerateFileSystemEntries(Root))
        {
            if (string.Equals(Path.GetFileName(Entry), ".git", StringComparison.OrdinalIgnoreCase))
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

    private static void CopyDirectoryContents(string SourceDir, string DestDir)
    {
        Directory.CreateDirectory(DestDir);
        foreach (var Dir in Directory.EnumerateDirectories(SourceDir, "*", SearchOption.AllDirectories))
        {
            var Relative = Path.GetRelativePath(SourceDir, Dir);
            Directory.CreateDirectory(Path.Combine(DestDir, Relative));
        }

        foreach (var FilePath in Directory.EnumerateFiles(SourceDir, "*", SearchOption.AllDirectories))
        {
            var Relative = Path.GetRelativePath(SourceDir, FilePath);
            var DestPath = Path.Combine(DestDir, Relative);
            Directory.CreateDirectory(Path.GetDirectoryName(DestPath)!);
            File.Copy(FilePath, DestPath, true);
        }
    }

    private static async Task RunRequiredGitCommandAsync(string Arguments, string WorkingDir, int TimeoutMs = 30000)
    {
        var (ExitCode, Output, Error) = await RunShellProcessAsync("git", Arguments, WorkingDir, TimeoutMs);
        Assert.AreEqual(0, ExitCode, $"git {Arguments} failed:\n{Output}\n{Error}");
    }

    private static async Task<(int ExitCode, string Output, string Error)> RunShellProcessAsync(
        string FileName,
        string Arguments,
        string WorkingDir,
        int TimeoutMs)
    {
        var StartInfo = new ProcessStartInfo
        {
            FileName = FileName,
            Arguments = Arguments,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
            WorkingDirectory = WorkingDir
        };
        using var Process = Process.Start(StartInfo)!;
        var OutputTask = Process.StandardOutput.ReadToEndAsync();
        var ErrorTask = Process.StandardError.ReadToEndAsync();
        using var Cts = new CancellationTokenSource(TimeoutMs);
        try
        {
            await Process.WaitForExitAsync(Cts.Token);
        }
        catch (OperationCanceledException)
        {
            try
            {
                Process.Kill(true);
            }
            catch
            {
            }

            Assert.Fail($"{FileName} {Arguments} timed out after {TimeoutMs}ms");
        }

        return (Process.ExitCode, await OutputTask, await ErrorTask);
    }

    private static async Task AssertGitHubPagesServesCurrentOutputAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };
        Client.DefaultRequestHeaders.CacheControl = new System.Net.Http.Headers.CacheControlHeaderValue { NoCache = true };

        var RootHtml = await File.ReadAllTextAsync(Path.Combine(GeneratedWwwRoot, "index.html"));
        var Match = MetaRefreshRegex().Match(RootHtml);
        Assert.IsTrue(Match.Success, "Generated root index.html must meta-refresh to a fingerprinted page");
        var FingerprintedIndex = Match.Groups[1].Value;
        Assert.IsTrue(File.Exists(Path.Combine(GeneratedWwwRoot, FingerprintedIndex.Replace('/', Path.DirectorySeparatorChar))),
            $"Generated fingerprinted page not found: {FingerprintedIndex}");

        for (var Attempt = 0; Attempt < 24; Attempt++)
        {
            if (Attempt > 0)
            {
                await Task.Delay(TimeSpan.FromSeconds(10));
            }

            var CacheBust = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            var RootResponse = await Client.GetAsync($"{GitHubPagesUrl}?cb={CacheBust}");
            if (!RootResponse.IsSuccessStatusCode)
            {
                continue;
            }

            var DeployedRootHtml = await RootResponse.Content.ReadAsStringAsync();
            if (!DeployedRootHtml.Contains(FingerprintedIndex, StringComparison.Ordinal))
            {
                continue;
            }

            var FingerprintedResponse = await Client.GetAsync($"{GitHubPagesUrl}{FingerprintedIndex}?cb={CacheBust}");
            if (!FingerprintedResponse.IsSuccessStatusCode)
            {
                continue;
            }

            return;
        }

        Assert.Fail($"GitHub Pages did not serve the current fingerprinted output at {GitHubPagesUrl}");
    }
}
