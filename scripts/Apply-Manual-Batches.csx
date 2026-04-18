#!/usr/bin/env dotnet-script
#nullable enable
using System.Diagnostics;

var repoRoot = @"C:\work\prtask.com";
var scriptsDir = Path.Combine(repoRoot, "scripts");
var applyScript = Path.Combine(scriptsDir, "apply-translation-json.csx");

var batchFiles = Directory.EnumerateFiles(scriptsDir, "manual-batch-*.json", SearchOption.TopDirectoryOnly)
    .OrderBy(path => Path.GetFileName(path), StringComparer.OrdinalIgnoreCase)
    .ToList();

if (batchFiles.Count == 0)
{
    Console.WriteLine("No manual batch files found.");
    return;
}

foreach (var batchFile in batchFiles)
{
    Console.WriteLine($"Applying {Path.GetFileName(batchFile)}");
    Run("dotnet-script", $"\"{applyScript}\" \"{batchFile}\"", repoRoot);
}

Console.WriteLine($"Applied {batchFiles.Count} manual batch file(s).");

static void Run(string fileName, string arguments, string workingDirectory)
{
    var startInfo = new ProcessStartInfo(fileName, arguments)
    {
        WorkingDirectory = workingDirectory,
        RedirectStandardOutput = true,
        RedirectStandardError = true,
        UseShellExecute = false
    };

    using var process = Process.Start(startInfo) ?? throw new InvalidOperationException($"Failed to start {fileName}");
    process.OutputDataReceived += (_, eventArgs) =>
    {
        if (eventArgs.Data is { Length: > 0 } line)
        {
            Console.WriteLine(line);
        }
    };
    process.ErrorDataReceived += (_, eventArgs) =>
    {
        if (eventArgs.Data is { Length: > 0 } line)
        {
            Console.Error.WriteLine(line);
        }
    };
    process.BeginOutputReadLine();
    process.BeginErrorReadLine();
    process.WaitForExit();

    if (process.ExitCode != 0)
    {
        throw new Exception($"{fileName} {arguments} failed with exit code {process.ExitCode}");
    }
}
