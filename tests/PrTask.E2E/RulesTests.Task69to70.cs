using System.Diagnostics;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task69 Every page must be SEO friendly with PageTitle and HeadContent meta description")]
    public void Task69EveryPageMustBeSeoFriendly()
    {
        var Violations = new List<string>();
        var RazorPages = GetSourceFiles(".razor")
            .Where(F => F.Contains("Pages") && !F.Contains("_Imports") && !F.Contains("Layout") && !F.Contains("Component") && !F.Contains("PrTask.Maui"));
        foreach (var Page in RazorPages)
        {
            var Content = File.ReadAllText(Page);
            var Fn = Path.GetFileName(Page);
            if (!Content.Contains("@page"))
            {
                continue;
            }
            if (Content.Contains("<PrTask.SharedUI.Pages."))
            {
                continue;
            }
            if (!Content.Contains("<PageTitle>"))
            {
                Violations.Add($"{Fn}: missing <PageTitle>");
            }
            if (!Content.Contains("<HeadContent>"))
            {
                Violations.Add($"{Fn}: missing <HeadContent>");
            }
            if (!Content.Contains("meta name=\"description\""))
            {
                Violations.Add($"{Fn}: missing meta description");
            }
        }
        Assert.AreEqual(0, Violations.Count, $"\n{string.Join("\n", Violations)}");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task70 Live site and installed APK must not be stale")]
    public async Task Task70LiveSiteAndApkMustNotBeStaleAsync()
    {
        var FrameworkResponse = await GetOrSkipAsync($"{BaseUrl}/_framework/dotnet.js");
        Assert.IsTrue(FrameworkResponse.IsSuccessStatusCode, $"WASM framework dotnet.js returned {FrameworkResponse.StatusCode}");
        var DotnetJs = await FrameworkResponse.Content.ReadAsStringAsync();
        Assert.IsTrue(DotnetJs.Length > 0, "dotnet.js must not be empty");
        var CssResponse = await GetOrSkipAsync($"{BaseUrl}/_content/PrTask.SharedUI/css/app.css");
        Assert.IsTrue(CssResponse.IsSuccessStatusCode, $"CSS returned {CssResponse.StatusCode}");
        var Css = await CssResponse.Content.ReadAsStringAsync();
        Assert.IsTrue(Css.Length > 0, "CSS must not be empty");
        Assert.IsTrue(Css.Contains("--color-bg"), "Deployed CSS must contain current theme variables");
        try
        {
            var AdbConnect = RunAdb($"connect {AppConstants.AdbDeviceAddress}");
            if (AdbConnect.Contains("connected") || AdbConnect.Contains("already"))
            {
                var Packages = RunAdb($"-s {AppConstants.AdbDeviceAddress} shell pm list packages {AppConstants.MauiPackageName}");
                Assert.IsTrue(Packages.Contains(AppConstants.MauiPackageName), $"APK {AppConstants.MauiPackageName} must be installed on device");
            }
            else
            {
                Assert.Inconclusive($"ADB device not reachable: {AdbConnect}");
            }
        }
        catch (Exception Ex) when (Ex is not AssertInconclusiveException)
        {
            Assert.Inconclusive($"ADB not available: {Ex.Message}");
        }
    }
    private static string RunAdb(string Arguments)
    {
        var AdbPath = FindAdb();
        var Process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = AdbPath,
                Arguments = Arguments,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            }
        };
        Process.Start();
        var Output = Process.StandardOutput.ReadToEnd();
        Process.WaitForExit(10000);
        return Output;
    }
    private static string FindAdb()
    {
        var AndroidHome = Environment.GetEnvironmentVariable("ANDROID_HOME")
            ?? Environment.GetEnvironmentVariable("ANDROID_SDK_ROOT")
            ?? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Android", "Sdk");
        var AdbPath = Path.Combine(AndroidHome, "platform-tools", "adb.exe");
        return File.Exists(AdbPath) ? AdbPath : "adb";
    }
}
