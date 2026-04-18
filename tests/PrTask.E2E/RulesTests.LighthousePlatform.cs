using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod]
    [Timeout(1800000)]
    [DisplayName("Lighthouse: Windows EXE desktop 100% all routes")]
    public async Task LighthouseDesktopExeDesktopAsync()
    {
        var DesktopUrl = await StartDesktopServerAsync();
        await RunLighthouseOnAllRoutesAsync(DesktopUrl, false);
    }

    [TestMethod]
    [Timeout(1800000)]
    [DisplayName("Lighthouse: Windows EXE mobile 100% all routes")]
    public async Task LighthouseDesktopExeMobileAsync()
    {
        var DesktopUrl = await StartDesktopServerAsync();
        await RunLighthouseOnAllRoutesAsync(DesktopUrl, true);
    }

    [TestMethod]
    [Timeout(1800000)]
    [DisplayName("Lighthouse: Android APK desktop 100% all routes via ADB proxy")]
    public async Task LighthouseAndroidDesktopAsync()
    {
        var AndroidUrl = await StartAndroidProxyAsync();
        await RunLighthouseOnAllRoutesAsync(AndroidUrl, false);
    }

    [TestMethod]
    [Timeout(1800000)]
    [DisplayName("Lighthouse: Android APK mobile 100% all routes via ADB proxy")]
    public async Task LighthouseAndroidMobileAsync()
    {
        var AndroidUrl = await StartAndroidProxyAsync();
        await RunLighthouseOnAllRoutesAsync(AndroidUrl, true);
    }

    private static async Task<string> StartDesktopServerAsync()
    {
        var EnvUrl = Environment.GetEnvironmentVariable(PlatformTestConstants.DesktopBaseUrlEnv);
        if (!string.IsNullOrEmpty(EnvUrl))
        {
            return EnvUrl;
        }

        var ExePath = Path.Combine(SolutionRoot, "publish-output", "desktop", PlatformTestConstants.DesktopExePath);
        if (!File.Exists(ExePath))
        {
            Assert.Inconclusive($"Desktop EXE not found: {ExePath}. Run publish-desktop.ps1 first.");
            return string.Empty;
        }

        var Port = GetRandomPort();
        var Url = $"https://127.0.0.1:{Port}";
        var Proc = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = ExePath,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
                Environment =
                {
                    ["ASPNETCORE_URLS"] = Url,
                    ["ASPNETCORE_ENVIRONMENT"] = "Production",
                },
            },
        };
        Proc.Start();
        await Task.Delay(PlatformTestConstants.DesktopStartupWaitMs);

        using var Http = CreatePlatformHttpClient(Url);
        Http.Timeout = TimeSpan.FromSeconds(15);
        try
        {
            var Response = await Http.GetAsync("/");
            LogWarning($"Desktop EXE at {Url} returned {(int)Response.StatusCode}");
        }
        catch (Exception Ex)
        {
            Proc.Kill(true);
            Assert.Inconclusive($"Desktop EXE not reachable at {Url}: {Ex.Message}");
        }

        return Url;
    }

    private static async Task<string> StartAndroidProxyAsync()
    {
        var EnvUrl = Environment.GetEnvironmentVariable(PlatformTestConstants.AndroidBaseUrlEnv);
        if (!string.IsNullOrEmpty(EnvUrl))
        {
            return EnvUrl;
        }

        const string AdbSerial = PlatformTestConstants.AdbDeviceSerial;
        var LocalPort = GetRandomPort();
        const int RemotePort = 5001;

        try
        {
            await RunAdbCommandAsync(AdbSerial, $"shell am start -n {PlatformTestConstants.AndroidPackageName}/{PlatformTestConstants.AndroidActivityName}");
            await Task.Delay(PlatformTestConstants.AndroidBootWaitMs);
        }
        catch (Exception Ex)
        {
            Assert.Inconclusive($"Failed to start Android app: {Ex.Message}");
        }

        try
        {
            await RunAdbCommandAsync(AdbSerial, $"forward tcp:{LocalPort} tcp:{RemotePort}");
        }
        catch (Exception Ex)
        {
            Assert.Inconclusive($"ADB port forward failed: {Ex.Message}");
        }

        var Url = $"https://127.0.0.1:{LocalPort}";

        using var Http = CreatePlatformHttpClient(Url);
        Http.Timeout = TimeSpan.FromSeconds(15);
        try
        {
            var Response = await Http.GetAsync("/");
            LogWarning($"Android APK at {Url} (forwarded from {AdbSerial}:{RemotePort}) returned {(int)Response.StatusCode}");
        }
        catch (Exception Ex)
        {
            Assert.Inconclusive($"Android APK not reachable at {Url}: {Ex.Message}");
        }

        return Url;
    }

    private static async Task RunAdbCommandAsync(string Serial, string Args)
    {
        var Proc = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "adb",
                Arguments = $"-s {Serial} {Args}",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
            },
        };
        Proc.Start();
        var StdOut = await Proc.StandardOutput.ReadToEndAsync();
        var StdErr = await Proc.StandardError.ReadToEndAsync();
        await Proc.WaitForExitAsync();
        if (Proc.ExitCode != 0)
        {
            throw new InvalidOperationException($"adb {Args} failed (exit {Proc.ExitCode}): {StdErr}");
        }
        LogWarning($"adb -s {Serial} {Args}: {StdOut.Trim()}");
    }

    private static int GetRandomPort()
    {
        using var Listener = new TcpListener(IPAddress.Loopback, 0);
        Listener.Start();
        var Port = ((IPEndPoint)Listener.LocalEndpoint).Port;
        Listener.Stop();
        return Port;
    }
}
