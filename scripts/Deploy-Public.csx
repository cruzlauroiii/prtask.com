#!/usr/bin/env dotnet-script
#nullable enable
#load "./Deploy-Public.Helpers.csx"
using System.Text;
using System.Text.Json;

var argsList = Args.ToList();
var sourceTreeRoot = FindSourceTreeRoot(Environment.CurrentDirectory);
var publishSourceDir = GetArgValue(argsList, "--publish-source-dir")
    ?? Path.Combine(sourceTreeRoot, "src", "PrTask.Client", "bin", "Release", "net11.0", "wwwroot");
var skipPush = HasArg(argsList, "--skip-push");
var pingOnly = HasArg(argsList, "--ping-only");
var skipIndexNow = !HasArg(argsList, "--no-skip-indexnow");

const string sourceTreeSentinelFile = "PrTask.sln";
const string sourceTreeSentinelDir = "src";
const string noJekyllFileName = ".nojekyll";
const string cnameFileName = "CNAME";
const string gitAttributesContent = "* -text";
const string deployCommitMessage = "Deploy: restructured paths, SEO route pages, SRI fixed";
const string originUrl = "https://github.com/cruzlauroiii/prtask.com.git";
const string indexNowKey = "1aabd823ab3244959fd9b25f844a0525";
const string indexNowHost = "prtask.com";
const string gitHubRepo = "cruzlauroiii/prtask.com";

var clientProject = Path.Combine(sourceTreeRoot, "src", "PrTask.Client", "PrTask.Client.csproj");
var publicBranchTempDir = Path.Combine(sourceTreeRoot, "deploy-public-tmp");

if (pingOnly)
{
    Console.WriteLine("=== Ping search engines only ===");
    var sitemapDir = Path.Combine(sourceTreeRoot, "src", "PrTask.Client", "wwwroot");
    await DeployPublicHelpers.InvokeIndexNowAsync(sitemapDir, indexNowHost, indexNowKey);
    await DeployPublicHelpers.InvokeGoogleSitemapPingAsync(indexNowHost);
    Console.WriteLine("=== Ping complete ===");
    return;
}

Console.WriteLine("=== Deploy-Public ===");
Console.WriteLine($"Source: {publishSourceDir}");
Console.WriteLine($"Target: {publicBranchTempDir}");

Console.WriteLine("[0] Regenerating client static HTML...");
DeployPublicHelpers.Run("dotnet", $"build \"{clientProject}\" -c Release", sourceTreeRoot);

Console.WriteLine("[1] Initializing temp Public repo...");
DeployPublicHelpers.InitializeTempPublicRepo(publicBranchTempDir, sourceTreeRoot, sourceTreeSentinelFile, sourceTreeSentinelDir, originUrl);

Console.WriteLine("[2] Writing .gitattributes...");
File.WriteAllText(Path.Combine(publicBranchTempDir, ".gitattributes"), gitAttributesContent, new UTF8Encoding(false));

Console.WriteLine("[3] Copying publish output...");
DeployPublicHelpers.CopyPublishOutput(publishSourceDir, publicBranchTempDir);

Console.WriteLine("[3.1] Copying robots.txt");
DeployPublicHelpers.CopyIfExists(Path.Combine(sourceTreeRoot, "robots.txt"), Path.Combine(publicBranchTempDir, "robots.txt"));

Console.WriteLine("[3.2] Copying sitemap.xml");
DeployPublicHelpers.CopyIfExists(Path.Combine(sourceTreeRoot, "src", "PrTask.Client", "wwwroot", "sitemap.xml"), Path.Combine(publicBranchTempDir, "sitemap.xml"));

Console.WriteLine("[4] Removing CNAME...");
var cnamePath = Path.Combine(publicBranchTempDir, cnameFileName);
if (File.Exists(cnamePath))
{
    File.Delete(cnamePath);
}

Console.WriteLine("[5] Creating .nojekyll...");
File.WriteAllText(Path.Combine(publicBranchTempDir, noJekyllFileName), string.Empty, new UTF8Encoding(false));

Console.WriteLine("[5.1] Creating IndexNow key file...");
File.WriteAllText(Path.Combine(publicBranchTempDir, $"{indexNowKey}.txt"), indexNowKey, new UTF8Encoding(false));

Console.WriteLine("[6] Committing and pushing...");
DeployPublicHelpers.CommitAndPush(publicBranchTempDir, skipPush, deployCommitMessage);

if (!skipPush)
{
    Console.WriteLine("[6.1] Waiting for GitHub Actions deployment to complete...");
    await Task.Delay(TimeSpan.FromSeconds(5));
    var deadline = DateTimeOffset.UtcNow.AddMinutes(10);
    RunInfo? activeRun = null;
    while (DateTimeOffset.UtcNow < deadline)
    {
        var runsJson = DeployPublicHelpers.RunCapture("gh", $"run list --repo {gitHubRepo} --limit 5 --json databaseId,status", sourceTreeRoot, allowFailure: true);
        if (!string.IsNullOrWhiteSpace(runsJson))
        {
            var runs = JsonSerializer.Deserialize<List<RunInfo>>(runsJson) ?? [];
            activeRun = runs.FirstOrDefault(run => !string.Equals(run.status, "completed", StringComparison.OrdinalIgnoreCase));
            if (activeRun == null)
            {
                break;
            }

            Console.WriteLine($"  Workflow status: {activeRun.status} - waiting...");
        }

        await Task.Delay(TimeSpan.FromSeconds(5));
    }

    Console.WriteLine(activeRun != null
        ? "  WARNING: workflow did not complete within timeout"
        : "  Workflow completed.");

    Console.WriteLine("[6.2] Deleting all GitHub Actions workflow runs...");
    var allRunsJson = DeployPublicHelpers.RunCapture("gh", $"run list --repo {gitHubRepo} --limit 100 --json databaseId", sourceTreeRoot, allowFailure: true);
    if (!string.IsNullOrWhiteSpace(allRunsJson))
    {
        var allIds = JsonSerializer.Deserialize<List<RunInfo>>(allRunsJson)?
            .Select(run => run.databaseId)
            .Where(id => id != 0)
            .ToList() ?? [];
        foreach (var runId in allIds)
        {
            DeployPublicHelpers.Run("gh", $"run delete {runId} --repo {gitHubRepo}", sourceTreeRoot, allowFailure: true);
        }

        Console.WriteLine($"  Deleted {allIds.Count} workflow run(s).");
    }
}

if (!skipPush && !skipIndexNow)
{
    Console.WriteLine("[7] Pinging search engines...");
    await DeployPublicHelpers.InvokeIndexNowAsync(publicBranchTempDir, indexNowHost, indexNowKey);
    await DeployPublicHelpers.InvokeGoogleSitemapPingAsync(indexNowHost);
}

Console.WriteLine("=== Deploy-Public complete ===");

static string? GetArgValue(IReadOnlyList<string> args, string name)
{
    for (var i = 0; i < args.Count - 1; i++)
    {
        if (string.Equals(args[i], name, StringComparison.OrdinalIgnoreCase))
        {
            return args[i + 1];
        }
    }

    return null;
}
static bool HasArg(IReadOnlyList<string> args, string name) => args.Any(arg => string.Equals(arg, name, StringComparison.OrdinalIgnoreCase));
static string FindSourceTreeRoot(string startDirectory)
{
    var current = Path.GetFullPath(startDirectory);
    while (!string.IsNullOrEmpty(current))
    {
        if (File.Exists(Path.Combine(current, "PrTask.sln")) &&
            Directory.Exists(Path.Combine(current, "src")))
        {
            return current;
        }

        var parent = Directory.GetParent(current);
        if (parent == null)
        {
            break;
        }

        current = parent.FullName;
    }

    throw new DirectoryNotFoundException($"Could not find repo root from '{startDirectory}'.");
}
