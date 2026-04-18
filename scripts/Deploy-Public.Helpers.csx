#nullable enable
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Xml;

static class DeployPublicHelpers
{
    public static void AssertNotSourceTree(string targetDir, string sentinelFile, string sentinelDir)
    {
        if (File.Exists(Path.Combine(targetDir, sentinelFile)))
        {
            throw new InvalidOperationException($"SAFETY: refusing to delete source tree (found {sentinelFile} in {targetDir})");
        }
        if (Directory.Exists(Path.Combine(targetDir, sentinelDir)))
        {
            throw new InvalidOperationException($"SAFETY: refusing to delete source tree (found {sentinelDir} in {targetDir})");
        }
    }

    public static void AssertIsPublicWorktree(string targetDir, string sourceTreeRoot)
    {
        var normalizedTarget = Path.GetFullPath(targetDir);
        var normalizedSourceRoot = Path.GetFullPath(sourceTreeRoot);
        if (string.Equals(normalizedTarget, normalizedSourceRoot, StringComparison.OrdinalIgnoreCase))
        {
            throw new InvalidOperationException($"SAFETY: refusing to operate on source tree root ({normalizedTarget})");
        }
    }

    public static void ClearDirectory(string targetDir, string sourceTreeRoot, string sentinelFile, string sentinelDir)
    {
        AssertNotSourceTree(targetDir, sentinelFile, sentinelDir);
        AssertIsPublicWorktree(targetDir, sourceTreeRoot);
        if (!Directory.Exists(targetDir))
        {
            return;
        }
        foreach (var entry in Directory.EnumerateFileSystemEntries(targetDir))
        {
            DeleteEntryRecursive(entry);
        }
    }

    public static void InitializeTempPublicRepo(string tempDir, string sourceTreeRoot, string sentinelFile, string sentinelDir, string originUrl)
    {
        if (Directory.Exists(tempDir))
        {
            ClearDirectory(tempDir, sourceTreeRoot, sentinelFile, sentinelDir);
        }
        else
        {
            Directory.CreateDirectory(tempDir);
        }
        Run("git", "init", tempDir);
        Run("git", "checkout --orphan Public", tempDir);
        Run("git", $"remote add origin {originUrl}", tempDir);
    }

    public static void CopyPublishOutput(string source, string destination)
    {
        if (!Directory.Exists(source))
        {
            throw new DirectoryNotFoundException($"Publish source directory not found: {source}");
        }
        foreach (var entry in Directory.EnumerateFileSystemEntries(source, "*", SearchOption.AllDirectories))
        {
            var relative = Path.GetRelativePath(source, entry);
            var destinationPath = Path.Combine(destination, relative);
            var attributes = File.GetAttributes(entry);
            if ((attributes & FileAttributes.Directory) != 0)
            {
                Directory.CreateDirectory(destinationPath);
            }
            else
            {
                Directory.CreateDirectory(Path.GetDirectoryName(destinationPath)!);
                File.Copy(entry, destinationPath, overwrite: true);
            }
        }
    }

    public static void CopyIfExists(string sourcePath, string destinationPath)
    {
        if (!File.Exists(sourcePath))
        {
            return;
        }
        Directory.CreateDirectory(Path.GetDirectoryName(destinationPath)!);
        File.Copy(sourcePath, destinationPath, overwrite: true);
    }

    public static void CommitAndPush(string targetDir, bool skipPush, string deployCommitMessage)
    {
        Run("git", "add -A", targetDir);
        var status = RunCapture("git", "status --short", targetDir, allowFailure: false);
        if (string.IsNullOrWhiteSpace(status))
        {
            Console.WriteLine("No changes to commit");
            return;
        }
        Run("git", $"commit -m \"{deployCommitMessage}\"", targetDir);
        if (!skipPush)
        {
            Run("git", "push --force origin HEAD:Public", targetDir);
        }
    }

    public static async Task InvokeIndexNowAsync(string targetDir, string indexNowHost, string indexNowKey)
    {
        var sitemapPath = Path.Combine(targetDir, "sitemap.xml");
        if (!File.Exists(sitemapPath))
        {
            Console.WriteLine("IndexNow: no URLs found in sitemap");
            return;
        }
        var xml = new XmlDocument();
        xml.Load(sitemapPath);
        var namespaceManager = new XmlNamespaceManager(xml.NameTable);
        namespaceManager.AddNamespace("s", "http://www.sitemaps.org/schemas/sitemap/0.9");
        var urls = xml.SelectNodes("//s:loc", namespaceManager)?.Cast<XmlNode>().Select(node => node.InnerText).Where(value => !string.IsNullOrWhiteSpace(value)).ToArray() ?? [];
        if (urls.Length == 0)
        {
            Console.WriteLine("IndexNow: no URLs found in sitemap");
            return;
        }
        Console.WriteLine($"IndexNow: submitting {urls.Length} URLs...");
        using var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("PrTask/1.0");
        var body = new
        {
            host = indexNowHost,
            key = indexNowKey,
            keyLocation = $"https://{indexNowHost}/{indexNowKey}.txt",
            urlList = urls
        };
        var jsonBody = JsonSerializer.Serialize(body);
        foreach (var endpoint in new[] { "https://api.indexnow.org/indexnow", "https://www.bing.com/indexnow", "https://yandex.com/indexnow", "https://searchadvisor.naver.com/indexnow" })
        {
            try
            {
                using var request = new HttpRequestMessage(HttpMethod.Post, endpoint)
                {
                    Version = new Version(1, 1),
                    VersionPolicy = HttpVersionPolicy.RequestVersionOrLower,
                    Content = new StringContent(jsonBody, new UTF8Encoding(false), "application/json")
                };
                request.Headers.ExpectContinue = false;
                using var response = await httpClient.SendAsync(request);
                Console.WriteLine(response.IsSuccessStatusCode ? $"  {endpoint} -> OK" : $"  {endpoint} -> FAILED ({(int)response.StatusCode} {response.ReasonPhrase})");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  {endpoint} -> FAILED ({ex.Message})");
            }
        }
    }

    public static async Task InvokeGoogleSitemapPingAsync(string indexNowHost)
    {
        await Task.CompletedTask;
        Console.WriteLine("Google: sitemap ping endpoint is deprecated; use Google Search Console for submission.");
    }

    public static void Run(string fileName, string arguments, string workingDirectory, bool allowFailure = false)
    {
        using var process = StartProcess(fileName, arguments, workingDirectory);
        process.WaitForExit();
        if (process.ExitCode != 0 && !allowFailure)
        {
            throw new Exception($"{fileName} {arguments} failed with exit code {process.ExitCode}");
        }
    }

    public static string RunCapture(string fileName, string arguments, string workingDirectory, bool allowFailure)
    {
        using var process = StartProcess(fileName, arguments, workingDirectory, captureOutput: true);
        var stdout = process.StandardOutput.ReadToEnd();
        var stderr = process.StandardError.ReadToEnd();
        process.WaitForExit();
        if (process.ExitCode != 0 && !allowFailure)
        {
            throw new Exception($"{fileName} {arguments} failed with exit code {process.ExitCode}: {stderr}");
        }
        return stdout;
    }

    private static Process StartProcess(string fileName, string arguments, string workingDirectory, bool captureOutput = false)
    {
        var startInfo = new ProcessStartInfo(fileName, arguments)
        {
            WorkingDirectory = workingDirectory,
            RedirectStandardOutput = captureOutput,
            RedirectStandardError = captureOutput,
            UseShellExecute = false
        };
        return Process.Start(startInfo) ?? throw new Exception($"Failed to start {fileName}");
    }

    private static void DeleteEntryRecursive(string path)
    {
        var attributes = File.GetAttributes(path);
        var isDirectory = (attributes & FileAttributes.Directory) != 0;
        var isReparsePoint = (attributes & FileAttributes.ReparsePoint) != 0;

        if (!isDirectory || isReparsePoint)
        {
            File.SetAttributes(path, FileAttributes.Normal);
            File.Delete(path);
            return;
        }

        foreach (var child in Directory.EnumerateFileSystemEntries(path))
        {
            DeleteEntryRecursive(child);
        }

        File.SetAttributes(path, FileAttributes.Directory);
        Directory.Delete(path, recursive: false);
    }
}

sealed class RunInfo
{
    public long databaseId { get; set; }
    public string? status { get; set; }
}
