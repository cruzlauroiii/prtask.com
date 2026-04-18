using System.Diagnostics;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    private const string GhRepo = "cruzlauroiii/prtask.com";
    private const string WorkerSubDir = "infra\\cloudflare-worker";
    private const string PublishArgs = "publish src/PrTask.Client/PrTask.Client.csproj -c Release -o publish/web /nodeReuse:false";
    private const string WranglerDeployArgs = "wrangler deploy";
    private const string GhPagesBuiltStatus = "built";
    private const int DeployTimeoutMs = 600000;
    private const int ProcessTimeoutMs = 120000;
    private const int PollIntervalMs = 10000;
    private const int MaxPollAttempts = 30;
    private static async Task<(int ExitCode, string Output, string Error)> RunDeployProcessAsync(
        string FileName, string Arguments, string? WorkingDir = null, int TimeoutMs = 120000)
    {
        var Psi = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            Arguments = $"/c {FileName} {Arguments}",
            WorkingDirectory = WorkingDir ?? SolutionRoot,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };
        Psi.Environment["DOTNET_CLI_DO_NOT_USE_MSBUILD_SERVER"] = "1";
        Psi.Environment["MSBUILDDISABLENODEREUSE"] = "1";
        using var Proc = Process.Start(Psi)!;
        var OutTask = Proc.StandardOutput.ReadToEndAsync();
        var ErrTask = Proc.StandardError.ReadToEndAsync();
        using var Cts = new CancellationTokenSource(TimeoutMs);
        try
        {
            await Proc.WaitForExitAsync(Cts.Token);
        }
        catch (OperationCanceledException)
        {
            Proc.Kill(true);
            Assert.Fail($"Process '{FileName} {Arguments}' timed out after {TimeoutMs}ms");
        }
        return (Proc.ExitCode, await OutTask, await ErrTask);
    }
    private static async Task WaitForGitHubPagesDeployAsync()
    {
        for (var I = 0; I < MaxPollAttempts; I++)
        {
            var (Exit, Out, _) = await RunDeployProcessAsync(
                "gh",
                $"api \"repos/{GhRepo}/pages/builds/latest\" --jq .status",
                SolutionRoot,
                15000);
            if (Exit == 0 && Out.Trim().Equals(GhPagesBuiltStatus, StringComparison.OrdinalIgnoreCase))
            {
                return;
            }
            await Task.Delay(PollIntervalMs);
        }
        Assert.Fail($"GitHub Pages build did not complete within {MaxPollAttempts * PollIntervalMs / 1000}s");
    }
    [TestMethod]
    [Timeout(1800000)]
    [DisplayName("Deploy: publish + restructure + push + worker to prtask.com")]
    public async Task DeployToPrtaskComAsync()
    {
        var (PubExit, PubOut, PubErr) = await RunDeployProcessAsync(
            "dotnet", PublishArgs, SolutionRoot, DeployTimeoutMs);
        Assert.AreEqual(0, PubExit, $"dotnet publish failed:\n{PubOut}\n{PubErr}");
        await DeployHelper.RestructureAndPushAsync(
            DeployHelper.DefaultDeployDir,
            DeployHelper.DefaultPublishDir,
            SolutionRoot);
        var WorkerFullDir = Path.Combine(SolutionRoot, WorkerSubDir);
        var (WrkExit, WrkOut, WrkErr) = await RunDeployProcessAsync(
            "npx", WranglerDeployArgs, WorkerFullDir, ProcessTimeoutMs);
        Assert.AreEqual(0, WrkExit, $"wrangler deploy failed:\n{WrkOut}\n{WrkErr}");
        await WaitForGitHubPagesDeployAsync();
        await VerifyDeployedSiteAsync();
    }
    private static async Task VerifyDeployedSiteAsync()
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
        var SiteUrl = $"https://{AppConstants.AppDomain}/?_cb={DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";
        for (var Attempt = 0; Attempt < 6; Attempt++)
        {
            if (Attempt > 0)
            {
                await Task.Delay(10000);
            }
            var (Response, Html) = await GetFollowingMetaRefreshAsync(Client, SiteUrl);
            if (!Response.IsSuccessStatusCode)
            {
                continue;
            }
            if (Html.Contains("base href=\"/\""))
            {
                return;
            }
        }
        var (FinalResponse, FinalHtml) = await GetFollowingMetaRefreshAsync(Client, SiteUrl);
        Assert.IsTrue(FinalHtml.Contains("base href=\"/\""),
            "Deployed site must have base href=\"/\" (worker rewrite active)");
    }
    private static async Task VerifyDeployedSiteAsync()
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
        var SiteUrl = $"https://{AppConstants.AppDomain}/?_cb={DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";
        for (var Attempt = 0; Attempt < 6; Attempt++)
        {
            if (Attempt > 0)
            {
                await Task.Delay(10000);
            }
            var Response = await Client.GetAsync(SiteUrl);
            if (!Response.IsSuccessStatusCode)
            {
                continue;
            }
            var Html = await Response.Content.ReadAsStringAsync();
            if (Html.Contains("base href=\"/\""))
            {
                return;
            }
        }
        var FinalResponse = await Client.GetAsync(SiteUrl);
        var FinalHtml = await FinalResponse.Content.ReadAsStringAsync();
        Assert.IsTrue(FinalHtml.Contains("base href=\"/\""),
            "Deployed site must have base href=\"/\" (worker rewrite active)");
    }
    private static async Task VerifyDeployedSiteAsync()
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
        var SiteUrl = $"https://{AppConstants.AppDomain}/?_cb={DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";
        for (var Attempt = 0; Attempt < 6; Attempt++)
        {
            if (Attempt > 0)
            {
                await Task.Delay(10000);
            }
            var Response = await Client.GetAsync(SiteUrl);
            if (!Response.IsSuccessStatusCode)
            {
                continue;
            }
            var Html = await Response.Content.ReadAsStringAsync();
            if (Html.Contains("base href=\"/\""))
            {
                return;
            }
        }
        var FinalResponse = await Client.GetAsync(SiteUrl);
        var FinalHtml = await FinalResponse.Content.ReadAsStringAsync();
        Assert.IsTrue(FinalHtml.Contains("base href=\"/\""),
            "Deployed site must have base href=\"/\" (worker rewrite active)");
    }
    private static async Task VerifyDeployedSiteAsync()
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
        var SiteUrl = $"https://{AppConstants.AppDomain}/?_cb={DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";
        for (var Attempt = 0; Attempt < 6; Attempt++)
        {
            if (Attempt > 0)
            {
                await Task.Delay(10000);
            }
            var Response = await Client.GetAsync(SiteUrl);
            if (!Response.IsSuccessStatusCode)
            {
                continue;
            }
            var Html = await Response.Content.ReadAsStringAsync();
            if (Html.Contains("base href=\"/\""))
            {
                return;
            }
        }
        var FinalResponse = await Client.GetAsync(SiteUrl);
        var FinalHtml = await FinalResponse.Content.ReadAsStringAsync();
        Assert.IsTrue(FinalHtml.Contains("base href=\"/\""),
            "Deployed site must have base href=\"/\" (worker rewrite active)");
    }
    private static async Task VerifyDeployedSiteAsync()
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
        var SiteUrl = $"https://{AppConstants.AppDomain}/?_cb={DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";
        for (var Attempt = 0; Attempt < 6; Attempt++)
        {
            if (Attempt > 0)
            {
                await Task.Delay(10000);
            }
            var Response = await Client.GetAsync(SiteUrl);
            if (!Response.IsSuccessStatusCode)
            {
                continue;
            }
            var Html = await Response.Content.ReadAsStringAsync();
            if (Html.Contains("base href=\"/\""))
            {
                return;
            }
        }
        var FinalResponse = await Client.GetAsync(SiteUrl);
        var FinalHtml = await FinalResponse.Content.ReadAsStringAsync();
        Assert.IsTrue(FinalHtml.Contains("base href=\"/\""),
            "Deployed site must have base href=\"/\" (worker rewrite active)");
    }
    private static async Task VerifyDeployedSiteAsync()
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
        var SiteUrl = $"https://{AppConstants.AppDomain}/?_cb={DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";
        for (var Attempt = 0; Attempt < 6; Attempt++)
        {
            if (Attempt > 0)
            {
                await Task.Delay(10000);
            }
            var Response = await Client.GetAsync(SiteUrl);
            if (!Response.IsSuccessStatusCode)
            {
                continue;
            }
            var Html = await Response.Content.ReadAsStringAsync();
            if (Html.Contains("base href=\"/\""))
            {
                return;
            }
        }
        var FinalResponse = await Client.GetAsync(SiteUrl);
        var FinalHtml = await FinalResponse.Content.ReadAsStringAsync();
        Assert.IsTrue(FinalHtml.Contains("base href=\"/\""),
            "Deployed site must have base href=\"/\" (worker rewrite active)");
    }
    [TestMethod]
    [Timeout(600000)]
    [DisplayName("Deploy: delete all GitHub Actions workflow runs")]
    public async Task DeleteAllGitHubActionsRunsAsync()
    {
        var AllDeleted = 0;
        for (var Page = 1; Page <= 50; Page++)
        {
            var (Exit, Out, _) = await RunDeployProcessAsync(
                "gh",
                $"api \"repos/{GhRepo}/actions/runs?per_page=100&page={Page}\" --jq \".workflow_runs[].id\"",
                SolutionRoot,
                30000);
            if (Exit != 0 || string.IsNullOrWhiteSpace(Out))
            {
                break;
            }
            var RunIds = Out.Trim().Split('\n', StringSplitOptions.RemoveEmptyEntries);
            if (RunIds.Length == 0)
            {
                break;
            }
            foreach (var RunId in RunIds)
            {
                var Id = RunId.Trim();
                await RunDeployProcessAsync(
                    "gh",
                    $"api -X DELETE \"repos/{GhRepo}/actions/runs/{Id}\"",
                    SolutionRoot,
                    15000);
                AllDeleted++;
            }
        }
        var (VerifyExit, VerifyOut, _) = await RunDeployProcessAsync(
            "gh",
            $"api \"repos/{GhRepo}/actions/runs\" --jq .total_count",
            SolutionRoot,
            15000);
        if (VerifyExit == 0)
        {
            var Remaining = VerifyOut.Trim();
            Assert.AreEqual("0", Remaining,
                $"Expected 0 workflow runs remaining, got {Remaining} (deleted {AllDeleted})");
        }
    }
}
