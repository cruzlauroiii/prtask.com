using System.Diagnostics;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task78 DevOps actions must be E2E tests — publish and deploy to Cloudflare Pages via dotnet test filter")]
    public void Task78DevOpsActionsAsE2eTests()
    {
        var ServerCsproj = ReadSource("PrTask.Server", "PrTask.Server.csproj");
        Assert.IsTrue(ServerCsproj.Contains("UserSecretsId"), "Server must have UserSecretsId for storing Cloudflare credentials");
        var SecretsDir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "Microsoft", "UserSecrets", "prtask-server-secrets");
        Assert.IsTrue(Directory.Exists(SecretsDir), "prtask-server-secrets directory must exist");
        var SecretsFile = Path.Combine(SecretsDir, "secrets.json");
        if (File.Exists(SecretsFile))
        {
            var Secrets = File.ReadAllText(SecretsFile);
            Assert.IsTrue(Secrets.Contains("Cloudflare:GlobalApiKey") || Secrets.Contains("Cloudflare:ApiToken"), "Secrets must contain Cloudflare credentials");
            Assert.IsTrue(Secrets.Contains("Cloudflare:Email"), "Secrets must contain Cloudflare:Email");
            Assert.IsTrue(Secrets.Contains("Cloudflare:AccountId"), "Secrets must contain Cloudflare:AccountId");
        }
        var TestFiles = Directory.EnumerateFiles(
            Path.Combine(SolutionRoot, "tests", "PrTask.E2E"),
            "RulesTests.Task*.cs", SearchOption.TopDirectoryOnly).ToList();
        Assert.IsTrue(TestFiles.Any(F => F.Contains("Task78")), "Task78 deploy test file must exist");
        var ThisFile = File.ReadAllText(TestFiles.First(F => F.Contains("Task78")));
        Assert.IsTrue(ThisFile.Contains("DeployToCloudflarePages"), "Task78 must contain DeployToCloudflarePages test method");
        Assert.IsTrue(ThisFile.Contains("wrangler"), "Task78 must invoke wrangler for deployment");
    }
    [TestMethod, TestCategory("Deploy")]
    [DisplayName("Task78Deploy Publish Client and deploy to Cloudflare Pages")]
    public void Task78DeployToCloudflarePages()
    {
        var SecretsFile = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "Microsoft", "UserSecrets", "prtask-server-secrets", "secrets.json");
        if (!File.Exists(SecretsFile))
        {
            Assert.Inconclusive("Cloudflare secrets not configured — run: dotnet user-secrets set Cloudflare:GlobalApiKey <key> --project src/PrTask.Server");
            return;
        }
        var Secrets = File.ReadAllText(SecretsFile);
        var ApiKey = ExtractSecret(Secrets, "Cloudflare:GlobalApiKey");
        var Email = ExtractSecret(Secrets, "Cloudflare:Email");
        var AccountId = ExtractSecret(Secrets, "Cloudflare:AccountId");
        if (string.IsNullOrEmpty(ApiKey) || string.IsNullOrEmpty(Email))
        {
            Assert.Inconclusive("Cloudflare:GlobalApiKey or Cloudflare:Email not set in user-secrets");
            return;
        }
        var PublishDir = Path.Combine(SolutionRoot, "publish-output");
        var DotnetPath = Path.Combine("C:", "work", "dotnet", "sdk", "artifacts", "bin", "redist", "Release", "dotnet", "dotnet.exe");
        if (!File.Exists(DotnetPath))
        {
            DotnetPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "dotnet", "dotnet.exe");
        }
        if (!File.Exists(DotnetPath))
        {
            DotnetPath = "dotnet";
        }
        var (PubExit, _, PubErr) = RunProcess(DotnetPath, $"publish src/PrTask.Client/PrTask.Client.csproj -c Release -o {PublishDir} -v q");
        Assert.IsTrue(PubExit == 0, $"Publish failed: {PubErr}");
        var WwwRoot = Path.Combine(PublishDir, "wwwroot");
        Assert.IsTrue(Directory.Exists(WwwRoot), "Published wwwroot must exist");
        foreach (var LargeFile in Directory.EnumerateFiles(WwwRoot, "*", SearchOption.AllDirectories)
            .Where(F => new FileInfo(F).Length > 25 * 1024 * 1024))
        {
            File.Delete(LargeFile);
        }
        var NpxPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "nodejs", "npx.cmd");
        if (!File.Exists(NpxPath))
        {
            NpxPath = "npx.cmd";
        }
        var (DeployExit, DeployOut, DeployErr) = RunProcess(NpxPath, $"wrangler pages deploy {WwwRoot} --project-name={AppConstants.CloudflarePagesProject} --commit-dirty=true",
            ("CLOUDFLARE_API_KEY", ApiKey), ("CLOUDFLARE_EMAIL", Email), ("CLOUDFLARE_ACCOUNT_ID", AccountId), ("CI", "true"));
        Assert.IsTrue(DeployExit == 0, $"Deploy failed: {DeployOut}\n{DeployErr}");
        Assert.IsTrue(DeployOut.Contains("https://") || DeployErr.Contains("https://"), "Deploy must output a URL");
    }
    private static string ExtractSecret(string Json, string Key)
    {
        var Pattern = $"\"{Key}\"\\s*:\\s*\"([^\"]+)\"";
        var Match = System.Text.RegularExpressions.Regex.Match(Json, Pattern);
        return Match.Success ? Match.Groups[1].Value : string.Empty;
    }
    private static (int ExitCode, string Output, string Error) RunProcess(string FileName, string Arguments, params (string Key, string Value)[] EnvVars)
    {
        var Psi = new ProcessStartInfo
        {
            FileName = FileName,
            Arguments = Arguments,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
            WorkingDirectory = SolutionRoot
        };
        foreach (var (Key, Value) in EnvVars)
        {
            Psi.EnvironmentVariables[Key] = Value;
        }
        var Proc = Process.Start(Psi)!;
        var ErrorTask = Proc.StandardError.ReadToEndAsync();
        var Output = Proc.StandardOutput.ReadToEnd();
        var Error = ErrorTask.GetAwaiter().GetResult();
        Proc.WaitForExit(600000);
        return (Proc.ExitCode, Output, Error);
    }
}
