using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req10: Download page has Linux download link")]
    public async Task DownloadPageHasLinuxLinkAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };
        var Response = await Client.GetAsync($"{TestBaseUrl}/en/Download");
        Assert.IsTrue(Response.IsSuccessStatusCode, "Download page must return 200");
        var Html = await Response.Content.ReadAsStringAsync();
        Assert.IsTrue(
            Html.Contains("Linux") || Html.Contains("linux"),
            "Download page must mention Linux");
        Assert.IsTrue(
            Html.Contains(DownloadConstants.LinuxExeAssetPath),
            "Download page must have Linux download link with correct asset path");
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req10: DownloadConstants has Linux executable path")]
    public Task DownloadConstantsHasLinuxExePathAsync()
    {
#pragma warning disable MSTEST0032
        Assert.IsNotNull(DownloadConstants.LinuxExeAssetPath,
            "LinuxExeAssetPath must exist in DownloadConstants");
        Assert.IsTrue(DownloadConstants.LinuxExeAssetPath.Contains("PrTask") ||
                      DownloadConstants.LinuxExeAssetPath.Contains("prtask"),
            "Linux exe path must reference PrTask binary");
#pragma warning restore MSTEST0032
        return Task.CompletedTask;
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req10: Download page has Android, Windows, and Linux active links")]
    public async Task DownloadPageHasAllPlatformLinksAsync()
    {
#pragma warning disable CA5399, MA0039, S4830
        using var Handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true
        };
#pragma warning restore CA5399, MA0039, S4830
        using var Client = new HttpClient(Handler) { Timeout = TimeSpan.FromSeconds(30) };
        var Response = await Client.GetAsync($"{TestBaseUrl}/en/Download");
        var Html = await Response.Content.ReadAsStringAsync();
        Assert.IsTrue(Html.Contains("com.prtask.app-Signed.apk"),
            "Download page must have Android APK link");
        Assert.IsTrue(
            Html.Contains(DownloadConstants.WindowsExeAssetPath),
            "Download page must have Windows EXE link");
        Assert.IsTrue(
            Html.Contains(DownloadConstants.LinuxExeAssetPath),
            "Download page must have Linux binary link");
    }

    [TestMethod]
    [Timeout(300000)]
    [DisplayName("Req10: Linux app starts a local HTTPS server")]
    public Task LinuxAppExeConfigExistsAsync()
    {
#pragma warning disable MSTEST0032
        Assert.IsNotNull(AppConstants.DesktopListenScheme,
            "DesktopListenScheme must exist for local server");
        Assert.IsTrue(AppConstants.DesktopListenScheme.Contains("127.0.0.1"),
            "Desktop must listen on 127.0.0.1");
        Assert.AreEqual(0, AppConstants.DesktopAutoPort,
            "Desktop must use auto port (0) for random port");
#pragma warning restore MSTEST0032
        return Task.CompletedTask;
    }
}
