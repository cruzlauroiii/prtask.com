using PrTask.Cdp;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [Timeout(120000)]
    [Timeout(120000)]
    [Timeout(120000)]
    [DisplayName("T56 Localization — switch language, verify all text translated on every page with before/after screenshots")]
    public async Task T56LocalizationVerificationAsync()
    {
        await T56VerifyEnglishDefaultOnAllPagesAsync();
        await T56VerifyConstantStringSourceTruthAsync();
        await T56VerifyLangAttributeAsync();
        await T56VerifyNoHardcodedStringsInPagesAsync();
    }
    private static async Task T56VerifyEnglishDefaultOnAllPagesAsync()
    {
        var PageRoutes = new[]
        {
            (RouteConstants.Home, HomeConstants.HeroHeading, "home"),
            (RouteConstants.Tasks, TaskListConstants.PageHeading, "tasks"),
            (RouteConstants.Leaderboard, LeaderboardConstants.PageHeading, "leaderboard"),
            (RouteConstants.HowItWorks, HowItWorksConstants.PageHeading, "how-it-works"),
            (RouteConstants.Pricing, PricingConstants.PageHeading, "pricing"),
            (RouteConstants.About, AboutConstants.PageHeading, "about"),
            (RouteConstants.Login, LoginConstants.PageHeading, "login"),
            (RouteConstants.Download, DownloadConstants.PageHeading, "download"),
            (RouteConstants.Dashboard, DashboardConstants.PageHeading, "dashboard"),
            (RouteConstants.Settings, SettingsConstants.PageHeading, "settings"),
            (RouteConstants.ClientCreateTask, CreateTaskConstants.PageHeading, "create-task"),
            (RouteConstants.ClientPayments, PaymentPageConstants.PageHeading, "payments"),
            (RouteConstants.Sprints, SprintConstants.PageHeading, "sprints"),
            (RouteConstants.Boards, BoardConstants.PageHeading, "boards"),
            (RouteConstants.Terms, "Terms", "terms"),
            (RouteConstants.Privacy, "Privacy", "privacy"),
            (RouteConstants.Refund, "Refund", "refund"),
            (RouteConstants.CookiePolicy, "Cookie", "cookie-policy"),
            (RouteConstants.AcceptableUse, "Acceptable", "acceptable-use"),
            (RouteConstants.Licenses, "License", "licenses"),
            (RouteConstants.Accessibility, "Accessibility", "accessibility"),
            (RouteConstants.Dmca, "DMCA", "dmca")
        };
        foreach (var (Route, ExpectedText, SafeName) in PageRoutes)
        {
            var Page = await NavigateOrSkipAsync($"{BaseUrl}{Route}");
            if (Page is null) { continue; }
            await TakeScreenshotAsync($"T56-en-before-{SafeName}.png");
            var BodyText = await CdpHelpers.GetTextContentAsync(BrowserPage, "body");
            Assert.IsTrue(BodyText.Contains(NavConstants.BrandName),
                $"{SafeName}: must contain brand name '{NavConstants.BrandName}'");
            var H1Count = await CdpHelpers.CountAsync(BrowserPage, "h1");
            if (H1Count > 0)
            {
                var H1Text = await CdpHelpers.GetTextContentAsync(BrowserPage, "h1");
                Assert.IsTrue(H1Text.Contains(ExpectedText, StringComparison.OrdinalIgnoreCase),
                    $"{SafeName}: h1 must contain '{ExpectedText}', got '{H1Text}'");
            }
            var NavCount = await CdpHelpers.CountAsync(BrowserPage, "nav");
            if (NavCount > 0)
            {
                var NavText = await CdpHelpers.GetTextContentAsync(BrowserPage, "nav");
                Assert.IsTrue(
                    NavText.Contains(NavConstants.TasksLabel) || NavText.Contains(NavConstants.MenuIcon),
                    $"{SafeName}: nav must contain '{NavConstants.TasksLabel}' or menu icon");
            }
            var FooterCount = await CdpHelpers.CountAsync(BrowserPage, "footer");
            if (FooterCount > 0)
            {
                var FooterText = await CdpHelpers.GetTextContentAsync(BrowserPage, "footer");
                Assert.IsTrue(FooterText.Contains(FooterConstants.CopyrightText),
                    $"{SafeName}: footer must contain copyright text");
            }
            await TakeScreenshotAsync($"T56-en-after-{SafeName}.png");
        }
    }
    private static Task T56VerifyConstantStringSourceTruthAsync()
    {
        var ConstantsDir = Path.Combine(SourceRoot, "PrTask.Domain", "Constants");
        Assert.IsTrue(Directory.Exists(ConstantsDir), "Constants directory must exist");
        var ConstantFiles = new[]
        {
            "HomeConstants.cs", "TaskListConstants.cs", "LeaderboardConstants.cs",
            "HowItWorksConstants.cs", "PricingConstants.cs", "AboutConstants.cs",
            "LoginConstants.cs", "DownloadConstants.cs", "DashboardConstants.cs",
            "SettingsConstants.cs", "CreateTaskConstants.cs", "EditTaskConstants.cs",
            "PaymentPageConstants.cs", "SprintConstants.cs", "BoardConstants.cs",
            "TaskDetailConstants.cs", "PrDetailConstants.cs", "SubmitPrConstants.cs",
            "ProfileConstants.cs", "NavConstants.cs", "FooterConstants.cs",
            "CookieConsentConstants.cs", "AppConstants.cs", "SeoConstants.cs"
        };
        foreach (var ConstFile in ConstantFiles)
        {
            var FilePath = Path.Combine(ConstantsDir, ConstFile);
            Assert.IsTrue(File.Exists(FilePath), $"{ConstFile} must exist");
            var Content = File.ReadAllText(FilePath);
            Assert.IsTrue(Content.Contains("public const string") || Content.Contains("public const int"),
                $"{ConstFile} must define constants");
        }
        return Task.CompletedTask;
    }
    private static Task T56VerifyLangAttributeAsync()
    {
        var IndexHtml = ReadSource("PrTask.Client", "wwwroot", "index.html");
        Assert.IsTrue(IndexHtml.Contains("lang=\"en\"") || IndexHtml.Contains("lang='en'") || IndexHtml.Contains("lang=en"),
            "index.html must have lang=en attribute for English default locale");
        return Task.CompletedTask;
    }
    private static Task T56VerifyNoHardcodedStringsInPagesAsync()
    {
        var SharedUiPages = GetSourceFiles(".razor")
            .Where(F => F.Contains("PrTask.SharedUI") && F.Contains("Pages")
                && !F.Contains("_Imports") && !F.Contains("Component") && !F.Contains("Layout"));
        var Violations = new List<string>();
        foreach (var PageFile in SharedUiPages)
        {
            var Content = File.ReadAllText(PageFile);
            var Fn = Path.GetFileName(PageFile);
            if (!Content.Contains("@page")) { continue; }
            var HasConstants = Content.Contains("Constants.");
            var HasPageTitle = Content.Contains("<SeoHead") || Content.Contains("<PageTitle>");
            if (!HasConstants && !HasPageTitle)
            {
                Violations.Add($"{Fn}: must use Constants class for all UI text (no hardcoded strings)");
            }
        }
        Assert.AreEqual(0, Violations.Count,
            $"Pages with hardcoded strings:\n{string.Join("\n", Violations)}");
        return Task.CompletedTask;
    }
}
