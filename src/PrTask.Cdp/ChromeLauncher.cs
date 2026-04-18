using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace PrTask.Cdp;

#pragma warning disable SA1600
public sealed class ChromeLauncher : IDisposable
{
    private const int StartupWaitMs = 2000;
    private Process? ChromeProcess;
    public int DebuggerPort { get; private set; }
    public string UserDataDir { get; private set; } = string.Empty;

    public static string FindChromePath()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            var Paths = new[]
            {
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Google", "Chrome", "Application", "chrome.exe"),
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Google", "Chrome", "Application", "chrome.exe"),
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Google", "Chrome", "Application", "chrome.exe"),
            };

            foreach (var P in Paths)
            {
                if (File.Exists(P))
                {
                    return P;
                }
            }
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            var MacPath = "/Applications/Google Chrome.app/Contents/MacOS/Google Chrome";
            if (File.Exists(MacPath))
            {
                return MacPath;
            }
        }
        else
        {
            var LinuxPaths = new[] { "/usr/bin/google-chrome", "/usr/bin/google-chrome-stable", "/usr/bin/chromium", "/usr/bin/chromium-browser" };
            foreach (var P in LinuxPaths)
            {
                if (File.Exists(P))
                {
                    return P;
                }
            }
        }

        throw new CdpException("Chrome executable not found. Install Google Chrome or set the path manually.");
    }

    public async Task<CdpBrowser> LaunchAsync(ChromeLaunchOptions? Options = null, CancellationToken Cancel = default)
    {
        Options ??= new ChromeLaunchOptions();
        var ChromePath = Options.ChromePath ?? FindChromePath();
        DebuggerPort = Options.DebuggerPort > 0 ? Options.DebuggerPort : FindFreePort();
        UserDataDir = Options.UserDataDir ?? Path.Combine(Path.GetTempPath(), string.Format(CultureInfo.InvariantCulture, "prtask-cdp-{0}", Guid.NewGuid().ToString("N", CultureInfo.InvariantCulture)[..8]));

        var Args = new List<string>
        {
            string.Format(CultureInfo.InvariantCulture, "--remote-debugging-port={0}", DebuggerPort),
            string.Format(CultureInfo.InvariantCulture, "--user-data-dir={0}", UserDataDir),
            "--no-first-run",
            "--no-default-browser-check",
            "--disable-background-networking",
            "--disable-default-apps",
            "--disable-extensions",
            "--disable-sync",
            "--disable-translate",
            "--metrics-recording-only",
            "--mute-audio",
            "--safebrowsing-disable-auto-update",
        };

        if (Options.Headless)
        {
            Args.Add("--headless=new");
        }

        if (Options.WindowWidth > 0 && Options.WindowHeight > 0)
        {
            Args.Add(string.Format(CultureInfo.InvariantCulture, "--window-size={0},{1}", Options.WindowWidth, Options.WindowHeight));
        }

        if (Options.ExtraArgs is not null)
        {
            Args.AddRange(Options.ExtraArgs);
        }

        var StartInfo = new ProcessStartInfo
        {
            FileName = ChromePath,
            Arguments = string.Join(' ', Args),
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            CreateNoWindow = true,
        };

        ChromeProcess = Process.Start(StartInfo)
            ?? throw new CdpException("Failed to start Chrome process");

        // Wait for Chrome's debugger to be ready
        await Task.Delay(StartupWaitMs, Cancel).ConfigureAwait(false);

        var Browser = new CdpBrowser();
        await Browser.ConnectAsync("127.0.0.1", DebuggerPort, Cancel).ConfigureAwait(false);
        return Browser;
    }

    private static int FindFreePort()
    {
        using var Listener = new System.Net.Sockets.TcpListener(System.Net.IPAddress.Loopback, 0);
        Listener.Start();
        var Port = ((System.Net.IPEndPoint)Listener.LocalEndpoint).Port;
        Listener.Stop();
        return Port;
    }

    public void Dispose()
    {
        if (ChromeProcess is not null && !ChromeProcess.HasExited)
        {
            try
            {
                ChromeProcess.Kill(true);
            }
            catch
            {
                // Best effort kill
            }

            ChromeProcess.Dispose();
            ChromeProcess = null;
        }

        if (!string.IsNullOrEmpty(UserDataDir) && Directory.Exists(UserDataDir))
        {
            try
            {
                Directory.Delete(UserDataDir, true);
            }
            catch
            {
                // Best effort cleanup
            }
        }
    }
}

public sealed class ChromeLaunchOptions
{
    public string? ChromePath { get; set; }
    public int DebuggerPort { get; set; }
    public string? UserDataDir { get; set; }
    public bool Headless { get; set; } = true;
    public int WindowWidth { get; set; } = 1280;
    public int WindowHeight { get; set; } = 720;
    public string[]? ExtraArgs { get; set; }
}
#pragma warning restore SA1600
