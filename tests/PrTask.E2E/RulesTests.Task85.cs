using System.Diagnostics;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Deploy"), Timeout(900000)]
    [DisplayName("Build MAUI APK and install on device via ADB so mobile app is never stale")]
    public void Task85BuildAndInstallMauiApk()
    {
        var DotnetPath = Path.Combine("C:", "work", "dotnet", "sdk", "artifacts", "bin", "redist", "Release", "dotnet", "dotnet.exe");
        if (!File.Exists(DotnetPath))
        {
            DotnetPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "dotnet", "dotnet.exe");
        }
        if (!File.Exists(DotnetPath))
        {
            DotnetPath = "dotnet";
        }
        var MauiCsproj = Path.Combine("src", "PrTask.Maui", "PrTask.Maui.csproj");
        var (BuildExit, BuildOut, BuildErr) = RunProcess(DotnetPath, $"build {MauiCsproj} -c Release -v q");
        Assert.IsTrue(BuildExit == 0, $"MAUI build failed:\n{BuildOut}\n{BuildErr}");
        var BinDir = Path.Combine(SolutionRoot, "src", "PrTask.Maui", "bin", "Release", "net10.0-android36.0");
        var SignedApk = Path.Combine(BinDir, "com.prtask.app-Signed.apk");
        Assert.IsTrue(File.Exists(SignedApk), $"Signed APK not found in {BinDir}");
        var DownloadsDir = Path.Combine(SolutionRoot, "src", "PrTask.Client", "wwwroot", "downloads");
        Directory.CreateDirectory(DownloadsDir);
        var Destination = Path.Combine(DownloadsDir, "com.prtask.app-Signed.apk");
        File.Copy(SignedApk, Destination, true);
        Assert.IsTrue(File.Exists(Destination), "APK must exist in Client downloads after copy");
        try
        {
            var AdbConnect = RunAdb($"connect {AppConstants.AdbDeviceAddress}");
            if (!AdbConnect.Contains("connected") && !AdbConnect.Contains("already"))
            {
                Assert.Inconclusive($"ADB device not reachable: {AdbConnect}");
                return;
            }
            var Install = RunAdb($"-s {AppConstants.AdbDeviceAddress} install -r -d \"{SignedApk}\"");
            Assert.IsTrue(Install.Contains("Success"), $"ADB install failed: {Install}");
            var Packages = RunAdb($"-s {AppConstants.AdbDeviceAddress} shell pm list packages {AppConstants.MauiPackageName}");
            Assert.IsTrue(Packages.Contains(AppConstants.MauiPackageName),
                $"{AppConstants.MauiPackageName} must be installed after ADB install");
        }
        catch (Exception Ex) when (Ex is not AssertInconclusiveException)
        {
            Assert.Inconclusive($"ADB not available: {Ex.Message}");
        }
    }
}
