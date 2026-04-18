using System.Diagnostics;
using System.Text.RegularExpressions;
namespace PrTask.E2E;
public partial class RulesTests
{
    [GeneratedRegex(@"pid:\s+(\d+)")]
    private static partial Regex HandlePidPattern();
    [TestMethod, TestCategory("Utility")]
    [DisplayName("Kill processes locking files in publish-output and output directories")]
    public void Task84KillLockedFileProcesses()
    {
        var Dirs = new[]
        {
            Path.Combine(SolutionRoot, "publish-output"),
            Path.Combine(SolutionRoot, "output"),
            Path.Combine(SolutionRoot, "tests", "PrTask.E2E", "bin"),
            Path.Combine(SolutionRoot, "tests", "PrTask.E2E", "obj"),
        };
        var ExistingDirs = Dirs.Where(Directory.Exists).ToList();
        if (ExistingDirs.Count == 0)
        {
            Console.WriteLine("No target directories found.");
            return;
        }
        var Killed = new List<string>();
        foreach (var Dir in ExistingDirs)
        {
            var Psi = new ProcessStartInfo
            {
                FileName = "handle.exe",
                Arguments = $"\"{Dir}\" /accepteula",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            try
            {
                var Proc = Process.Start(Psi)!;
                var Output = Proc.StandardOutput.ReadToEnd();
                Proc.WaitForExit(15000);
                foreach (var Line in Output.Split('\n'))
                {
                    if (!Line.Contains("pid:"))
                    {
                        continue;
                    }
                    var Match = HandlePidPattern().Match(Line);
                    if (!Match.Success)
                    {
                        continue;
                    }
                    var Pid = int.Parse(Match.Groups[1].Value);
                    try
                    {
                        var Target = Process.GetProcessById(Pid);
                        Killed.Add($"{Target.ProcessName} (PID {Pid}) in {Dir}");
                        Target.Kill();
                        Target.WaitForExit(5000);
                    }
                    catch
                    {
                    }
                }
            }
            catch
            {
            }
        }
        if (Killed.Count > 0)
        {
            Console.WriteLine($"Killed {Killed.Count} locking process(es):\n  " + string.Join("\n  ", Killed));
        }
        else
        {
            Console.WriteLine("No locked files found.");
        }
    }
}
