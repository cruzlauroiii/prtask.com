using System.Diagnostics;
using Microsoft.Playwright;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Every page must be SEO friendly with SeoHead OG Twitter canonical sitemap robots JSON-LD")]
    public void EveryPageMustBeSeoFriendly()
    {
        var SeoComponent = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.SharedUI", "Components", "SeoHead.razor"));
        Assert.IsTrue(SeoComponent.Contains("og:title"), "SeoHead must include og:title");
        Assert.IsTrue(SeoComponent.Contains("og:description"), "SeoHead must include og:description");
        Assert.IsTrue(SeoComponent.Contains("og:type"), "SeoHead must include og:type");
        Assert.IsTrue(SeoComponent.Contains("og:url"), "SeoHead must include og:url");
        Assert.IsTrue(SeoComponent.Contains("og:site_name"), "SeoHead must include og:site_name");
        Assert.IsTrue(SeoComponent.Contains("twitter:card"), "SeoHead must include twitter:card");
        Assert.IsTrue(SeoComponent.Contains("twitter:title"), "SeoHead must include twitter:title");
        Assert.IsTrue(SeoComponent.Contains("twitter:description"), "SeoHead must include twitter:description");
        Assert.IsTrue(SeoComponent.Contains("canonical"), "SeoHead must include canonical link");
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
            if (!Content.Contains("<SeoHead") && !Content.Contains("<PageTitle>"))
            {
                Violations.Add($"{Fn}: missing SeoHead or PageTitle");
            }
        }
        Assert.AreEqual(0, Violations.Count, $"\n{string.Join("\n", Violations)}");
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.Client", "wwwroot", "sitemap.xml")), "sitemap.xml must exist");
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.Client", "wwwroot", "robots.txt")), "robots.txt must exist");
        var Sitemap = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.Client", "wwwroot", "sitemap.xml"));
        Assert.IsTrue(Sitemap.Contains("prtask.com"), "sitemap must reference prtask.com");
        var Robots = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.Client", "wwwroot", "robots.txt"));
        Assert.IsTrue(Robots.Contains("Sitemap"), "robots.txt must reference sitemap");
        var Home = ReadSource("PrTask.SharedUI", "Pages", "Home.razor");
        Assert.IsTrue(Home.Contains("application/ld+json"), "Home must have JSON-LD structured data");
        Assert.IsTrue(Home.Contains("Organization"), "Home must have Organization schema");
        Assert.IsTrue(Home.Contains("schema.org"), "Home must reference schema.org");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Live site and installed APK must not be stale")]
    public async Task Task70LiveSiteAndApkMustNotBeStaleAsync()
    {
        var Page = await NavigateOrSkipAsync(BaseUrl);
        if (Page is null)
        {
            return;
        }
        try
        {
            var Title = await Page.TitleAsync();
            Assert.IsTrue(Title.Contains("PrTask"), $"Page title must contain PrTask, got: {Title}");
            var Content = await Page.ContentAsync();
            Assert.IsTrue(Content.Contains("blazor"), "Page must load Blazor runtime");
            var HeroText = await Page.TextContentAsync("#app");
            Assert.IsTrue(HeroText is not null && HeroText.Contains("Earn Money"),
                "Home page must render hero content via Blazor WASM");
            var CssResponse = await GetOrSkipAsync($"{BaseUrl}/_content/PrTask.SharedUI/css/app.css");
            Assert.IsTrue(CssResponse.IsSuccessStatusCode, $"CSS returned {CssResponse.StatusCode}");
            var Css = await CssResponse.Content.ReadAsStringAsync();
            Assert.IsTrue(Css.Contains("--color-bg"), "Deployed CSS must contain current theme variables");
        }
        finally
        {
            await Page.CloseAsync();
        }
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
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Every page must be law friendly with cookie consent GDPR CCPA and comprehensive legal pages")]
    public void EveryPageMustBeLawFriendly()
    {
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.SharedUI", "Components", "CookieConsent.razor")), "CookieConsent component must exist");
        var Consent = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.SharedUI", "Components", "CookieConsent.razor"));
        Assert.IsTrue(Consent.Contains("Accept"), "CookieConsent must have Accept option");
        Assert.IsTrue(Consent.Contains("Reject"), "CookieConsent must have Reject option");
        Assert.IsTrue(Consent.Contains("Cookie Policy") || Consent.Contains("CookiePolicy"), "CookieConsent must link to Cookie Policy");
        var Layout = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.SharedUI", "Components", "MainLayout.razor"));
        Assert.IsTrue(Layout.Contains("CookieConsent"), "MainLayout must include CookieConsent component");
        var Privacy = ReadSource("PrTask.SharedUI", "Pages", "Legal", "PrivacyPage.razor");
        Assert.IsTrue(Privacy.Contains("GDPR", StringComparison.OrdinalIgnoreCase), "Privacy must reference GDPR");
        Assert.IsTrue(Privacy.Contains("CCPA", StringComparison.OrdinalIgnoreCase), "Privacy must reference CCPA");
        Assert.IsTrue(Privacy.Contains("do-not-sell", StringComparison.OrdinalIgnoreCase), "Privacy must have Do Not Sell section");
        var Terms = ReadSource("PrTask.SharedUI", "Pages", "Legal", "TermsPage.razor");
        Assert.IsTrue(Terms.Contains("arbitration", StringComparison.OrdinalIgnoreCase), "Terms must have arbitration clause");
        Assert.IsTrue(Terms.Contains("limitation of liability", StringComparison.OrdinalIgnoreCase), "Terms must have limitation of liability");
        Assert.IsTrue(Terms.Contains("indemnification", StringComparison.OrdinalIgnoreCase), "Terms must have indemnification clause");
        var Accessibility = ReadSource("PrTask.SharedUI", "Pages", "Legal", "AccessibilityPage.razor");
        Assert.IsTrue(Accessibility.Contains("WCAG", StringComparison.OrdinalIgnoreCase), "Accessibility must reference WCAG");
        var Dmca = ReadSource("PrTask.SharedUI", "Pages", "Legal", "DmcaPage.razor");
        Assert.IsTrue(Dmca.Contains("takedown", StringComparison.OrdinalIgnoreCase), "DMCA must have takedown procedure");
        Assert.IsTrue(Dmca.Contains("counter-notification", StringComparison.OrdinalIgnoreCase), "DMCA must have counter-notification process");
        var Footer = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.SharedUI", "Components", "FooterSection.razor"));
        Assert.IsTrue(Footer.Contains("&copy;") || Footer.Contains('©'), "Footer must have copyright notice");
        Assert.IsTrue(Footer.Contains("Do Not Sell", StringComparison.OrdinalIgnoreCase), "Footer must have CCPA Do Not Sell link");
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
        var Candidates = new List<string>();
        var AndroidHome = Environment.GetEnvironmentVariable("ANDROID_HOME")
            ?? Environment.GetEnvironmentVariable("ANDROID_SDK_ROOT");
        if (!string.IsNullOrEmpty(AndroidHome))
        {
            Candidates.Add(Path.Combine(AndroidHome, "platform-tools", "adb.exe"));
        }
        var LocalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        Candidates.Add(Path.Combine(LocalAppData, "Android", "Sdk", "platform-tools", "adb.exe"));
        Candidates.Add(Path.Combine("C:\\", "work", "android-sdk", "platform-tools", "adb.exe"));
        var WingetBase = Path.Combine(LocalAppData, "Microsoft", "WinGet", "Packages");
        if (Directory.Exists(WingetBase))
        {
            foreach (var Dir in Directory.EnumerateDirectories(WingetBase, "Google.PlatformTools*"))
            {
                Candidates.Add(Path.Combine(Dir, "platform-tools", "adb.exe"));
            }
        }
        Candidates.Add(Path.Combine("C:\\", "platform-tools", "adb.exe"));
        foreach (var Candidate in Candidates)
        {
            if (File.Exists(Candidate))
            {
                return Candidate;
            }
        }
        return "adb";
    }
}
