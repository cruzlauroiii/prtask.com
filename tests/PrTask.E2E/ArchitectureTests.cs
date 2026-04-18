using System.Diagnostics;
using System.Reflection;
namespace PrTask.E2E;
[TestClass]
public partial class ArchitectureTests
{
    private static readonly Assembly DomainAssembly = typeof(Domain.Constants.AppConstants).Assembly;
    private static readonly Assembly ApplicationAssembly = typeof(Application.Services.ITaskService).Assembly;
    private static readonly Assembly InfrastructureAssembly = typeof(Infrastructure.Services.TaskService).Assembly;
    private static readonly string SolutionRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", ".."));
    private static readonly string SourceRoot = Path.Combine(SolutionRoot, "src");
    private static readonly string TestRoot = Path.Combine(SolutionRoot, "tests");
    private const int MaxFileLines = 300;
    private const string DomainProject = "PrTask.Domain";
    private const string ApplicationProject = "PrTask.Application";
    private const string InfrastructureProject = "PrTask.Infrastructure";
    private const string ServerProject = "PrTask.Server";
    private const string SharedUiProject = "PrTask.SharedUI";
    private const string ClientProject = "PrTask.Client";
    private const string MauiProject = "PrTask.Maui";
    private const string E2EProject = "PrTask.E2E";
    private static IEnumerable<string> GetSourceFiles(string Extension) =>
        Directory.EnumerateFiles(SourceRoot, $"*{Extension}", SearchOption.AllDirectories)
            .Where(IsSourceFile);
    private static IEnumerable<string> GetAllSourceFiles() =>
        GetSourceFiles(".cs")
            .Concat(GetSourceFiles(".razor"))
            .Concat(GetSourceFiles(".scss"));
    private static IEnumerable<string> GetAllProjectFiles() =>
        Directory.EnumerateFiles(SolutionRoot, "*.csproj", SearchOption.AllDirectories);
    private static bool IsSourceFile(string FilePath)
    {
        var Normalized = FilePath.Replace('\\', '/');
        return !Normalized.Contains("/bin/")
            && !Normalized.Contains("/obj/")
            && !Normalized.Contains("/node_modules/")
            && !Normalized.EndsWith(".Designer.cs")
            && !Normalized.EndsWith(".generated.cs")
            && !Normalized.EndsWith(".g.cs")
            && !Normalized.Contains("GlobalUsings")
            && !Normalized.Contains("AssemblyInfo");
    }
    private static string Truncate(string Value, int MaxLength) =>
        Value.Length <= MaxLength ? Value : $"{Value[..MaxLength]}...";
    private static (int ExitCode, string Output) RunProcess(string FileName, string Arguments, int TimeoutMs = 120000)
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
        using var Process = System.Diagnostics.Process.Start(Psi)!;
        var StdOut = Process.StandardOutput.ReadToEnd();
        var StdErr = Process.StandardError.ReadToEnd();
        Process.WaitForExit(TimeoutMs);
        return (Process.ExitCode, $"{StdOut}\n{StdErr}".Trim());
    }
}
