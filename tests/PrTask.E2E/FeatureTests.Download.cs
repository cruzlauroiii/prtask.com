namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Download page must have windows platform placeholder section")]
    public void DownloadPageMustHaveWindowsPlatformPlaceholderSection()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "DownloadPage.razor");
        Assert.IsTrue(
            Razor.Contains("Windows", StringComparison.Ordinal),
            "Download page must have a Windows section as a placeholder for future desktop app");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Download page must have ios platform placeholder section")]
    public void DownloadPageMustHaveIosPlatformPlaceholderSection()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "DownloadPage.razor");
        Assert.IsTrue(
            Razor.Contains("iOS", StringComparison.Ordinal),
            "Download page must have an iOS section as a placeholder for future iPhone app");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Download page must have macos platform placeholder section")]
    public void DownloadPageMustHaveMacosPlatformPlaceholderSection()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "DownloadPage.razor");
        Assert.IsTrue(
            Razor.Contains("macOS", StringComparison.Ordinal) || Razor.Contains("Mac", StringComparison.Ordinal),
            "Download page must have a macOS section as a placeholder for future Mac app");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Download page must have linux platform placeholder section")]
    public void DownloadPageMustHaveLinuxPlatformPlaceholderSection()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "DownloadPage.razor");
        Assert.IsTrue(
            Razor.Contains("Linux", StringComparison.Ordinal),
            "Download page must have a Linux section as a placeholder for future Linux app");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Download page must have coming soon indicators for unreleased platforms")]
    public void DownloadPageMustHaveComingSoonIndicatorsForUnreleasedPlatforms()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "DownloadPage.razor");
        Assert.IsTrue(
            Razor.Contains("Coming Soon", StringComparison.Ordinal),
            "Download page must show Coming Soon for platforms that are not yet available");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Download page must have android apk download link")]
    public void DownloadPageMustHaveAndroidApkDownloadLink()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "DownloadPage.razor");
        Assert.IsTrue(
            Razor.Contains("Android", StringComparison.Ordinal),
            "Download page must have an Android download section");
        Assert.IsTrue(
            Razor.Contains(".apk", StringComparison.OrdinalIgnoreCase),
            "Download page must provide an APK download link for Android");
    }
}
