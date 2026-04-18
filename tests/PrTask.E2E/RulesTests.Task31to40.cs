namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task31 Infrastructure must include DiffSanitization ComplexityScoring Leaderboard Achievement Payment and User services")]
    public void Task31InfrastructureServices()
    {
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.Infrastructure", "Services", "DiffSanitizationService.cs")), "Must have DiffSanitizationService");
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.Infrastructure", "Services", "ComplexityScoringService.cs")), "Must have ComplexityScoringService");
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.Infrastructure", "Services", "LeaderboardService.cs")), "Must have LeaderboardService");
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.Infrastructure", "Services", "AchievementService.cs")), "Must have AchievementService");
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.Infrastructure", "Services", "PaymentService.cs")), "Must have PaymentService");
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.Infrastructure", "Services", "UserService.cs")), "Must have UserService");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task32 Application must define ITaskService IPullRequestService with payment contracts")]
    public void Task32ApplicationInterfaces()
    {
        var TaskSvc = ReadSource("PrTask.Application", "Services", "ITaskService.cs");
        Assert.IsTrue(TaskSvc.Contains("CreateAsync"), "ITaskService must have CreateAsync");
        Assert.IsTrue(TaskSvc.Contains("ListOpenAsync"), "ITaskService must have ListOpenAsync");
        var PrSvc = ReadSource("PrTask.Application", "Services", "IPullRequestService.cs");
        Assert.IsTrue(PrSvc.Contains("SubmitAsync"), "IPullRequestService must have SubmitAsync");
        Assert.IsTrue(PrSvc.Contains("ApproveAsync"), "IPullRequestService must have ApproveAsync");
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.Application", "Contracts", "PaymentCheckoutRequest.cs")), "Must have PaymentCheckoutRequest");
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.Application", "Contracts", "PaymentCheckoutResponse.cs")), "Must have PaymentCheckoutResponse");
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.Application", "Contracts", "PaymentWebhookRequest.cs")), "Must have PaymentWebhookRequest");
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.Application", "Contracts", "PaymentStatusResponse.cs")), "Must have PaymentStatusResponse");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task33 IUserService must define CreateOrUpdateFromOidcAsync with OidcUserResponse and GitHubUserResponse")]
    public void Task33IUserServiceWithOidcMethods()
    {
        var UserSvc = ReadSource("PrTask.Application", "Services", "IUserService.cs");
        Assert.IsTrue(UserSvc.Contains("CreateOrUpdateFromOidcAsync"), "Must have CreateOrUpdateFromOidcAsync");
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.Application", "Contracts", "OidcUserResponse.cs")), "Must have OidcUserResponse");
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.Application", "Contracts", "GitHubUserResponse.cs")), "Must have GitHubUserResponse");
        var Oidc = ReadSource("PrTask.Application", "Contracts", "OidcUserResponse.cs");
        Assert.IsTrue(Oidc.Contains("SubjectId"), "OidcUserResponse must have SubjectId");
        var Gh = ReadSource("PrTask.Application", "Contracts", "GitHubUserResponse.cs");
        Assert.IsTrue(Gh.Contains("long Id"), "GitHubUserResponse must have long Id");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task34 SharedUI must have pages for Home TaskList Leaderboard Dashboard Login HowItWorks Pricing About Download Profile TaskDetail Settings PullRequestDetail")]
    public void Task34SharedUiPages()
    {
        var PagesDir = Path.Combine(SourceRoot, "PrTask.SharedUI", "Pages");
        var Required = new[] { "Home.razor", "TaskList.razor", "LeaderboardPage.razor", "DashboardPage.razor",
            "LoginPage.razor", "HowItWorks.razor", "PricingPage.razor", "AboutPage.razor", "DownloadPage.razor",
            "ProfilePage.razor", "TaskDetailPage.razor", "SettingsPage.razor", "PullRequestDetailPage.razor" };
        foreach (var Page in Required)
        {
            Assert.IsTrue(File.Exists(Path.Combine(PagesDir, Page)), $"SharedUI must have {Page}");
        }
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task35 SharedUI must have all legal pages under /legal/ prefix Terms Privacy Refund AcceptableUse CookiePolicy Licenses Accessibility DMCA")]
    public void Task35LegalPages()
    {
        var LegalDir = Path.Combine(SourceRoot, "PrTask.SharedUI", "Pages", "Legal");
        var Required = new[] { "TermsPage.razor", "PrivacyPage.razor", "RefundPage.razor", "AcceptableUsePage.razor",
            "CookiePolicyPage.razor", "LicensesPage.razor", "AccessibilityPage.razor", "DmcaPage.razor" };
        foreach (var Page in Required)
        {
            Assert.IsTrue(File.Exists(Path.Combine(LegalDir, Page)), $"Must have legal page {Page}");
        }
        var Routes = ReadSource("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Routes.Contains("Terms = \"/Legal/Terms\""), "Must have Terms route under /Legal/");
        Assert.IsTrue(Routes.Contains("Privacy = \"/Legal/Privacy\""), "Must have Privacy route under /Legal/");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task36 Client must have wrapper pages including CreateTaskPage and duplicate content pages")]
    public void Task36ClientWrapperPages()
    {
        var ClientPagesDir = Path.Combine(SourceRoot, "PrTask.Client", "Pages");
        Assert.IsTrue(Directory.Exists(ClientPagesDir), "Client must have Pages directory");
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.SharedUI", "Pages", "Client", "CreateTaskPage.razor"))
            || File.Exists(Path.Combine(ClientPagesDir, "CreateTaskPage.razor")), "Must have CreateTaskPage");
        var ClientDir = Path.Combine(SourceRoot, "PrTask.Client", "Pages");
        var RazorFiles = Directory.GetFiles(ClientDir, "*.razor", SearchOption.AllDirectories);
        Assert.IsTrue(RazorFiles.Any(F => Path.GetFileName(F).Contains("Pricing")), "Must have ClientPricingPage");
        Assert.IsTrue(RazorFiles.Any(F => Path.GetFileName(F).Contains("Home")), "Must have ClientHomePage");
        Assert.IsTrue(RazorFiles.Any(F => Path.GetFileName(F).Contains("HowItWorks")), "Must have ClientHowItWorksPage");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task37 SharedUI must have NavMenu FooterSection MainLayout App Routes and _Imports.razor")]
    public void Task37SharedUiComponents()
    {
        var SharedDir = Path.Combine(SourceRoot, "PrTask.SharedUI");
        Assert.IsTrue(File.Exists(Path.Combine(SharedDir, "Components", "NavMenu.razor")), "Must have NavMenu");
        Assert.IsTrue(File.Exists(Path.Combine(SharedDir, "Components", "FooterSection.razor")), "Must have FooterSection");
        Assert.IsTrue(File.Exists(Path.Combine(SharedDir, "Components", "MainLayout.razor")), "Must have MainLayout");
        Assert.IsTrue(File.Exists(Path.Combine(SharedDir, "Components", "App.razor")), "Must have App.razor");
        Assert.IsTrue(File.Exists(Path.Combine(SharedDir, "Components", "Routes.razor")), "Must have Routes.razor");
        var Imports = File.ReadAllText(Path.Combine(SharedDir, "_Imports.razor"));
        Assert.IsTrue(Imports.Contains("Microsoft.AspNetCore.Components"), "Must import AspNetCore.Components");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task38 Nav must use flexbox hamburger with nav-collapsed class and prtaskCheckNavWrap JS no media queries")]
    public void Task38FlexboxHamburgerNavCollapsed()
    {
        var Scss = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.SharedUI", "Styles", "app.scss"));
        Assert.IsTrue(Scss.Contains("nav-collapsed"), "SCSS must have nav-collapsed class");
        Assert.IsTrue(Scss.Contains("nav-open"), "SCSS must have nav-open class");
        Assert.IsTrue(Scss.Contains("flex-wrap"), "SCSS must use flex-wrap");
        Assert.IsTrue(Scss.Contains("nav-legal"), "SCSS must have nav-legal class");
        Assert.IsTrue(Scss.Contains(".nav-toggle") && Scss.Contains("display: none"), "nav-toggle default must be display none");
        Assert.IsTrue(Scss.Contains(".nav-links") && Scss.Contains("flex-direction: row"), "nav-links default must be flex-direction row");
        Assert.IsTrue(Scss.Contains(".nav-menu.nav-collapsed"), "Must have .nav-menu.nav-collapsed selector");
        var Lines = Scss.Split('\n');
        var NavMediaQuery = false;
        foreach (var Line in Lines)
        {
            var Tr = Line.Trim();
            if (Tr.StartsWith("@media") && Tr.Contains("nav"))
            {
                NavMediaQuery = true;
            }
        }
        Assert.IsFalse(NavMediaQuery, "Must not have media queries targeting nav elements");
        var Nav = ReadSource("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Nav.Contains("nav-collapsed"), "NavMenu must have nav-collapsed class");
        Assert.IsTrue(Nav.Contains("nav-legal"), "NavMenu must have nav-legal class on legal links");
        var IndexHtml = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.Client", "wwwroot", "index.html"));
        var CoreJs = File.Exists(Path.Combine(SourceRoot, "PrTask.Client", "wwwroot", "Js", "prtask-core.js"))
            ? File.ReadAllText(Path.Combine(SourceRoot, "PrTask.Client", "wwwroot", "Js", "prtask-core.js"))
            : string.Empty;
        Assert.IsTrue(IndexHtml.Contains("prtaskCheckNavWrap") || CoreJs.Contains("prtaskCheckNavWrap"), "index.html or prtask-core.js must have prtaskCheckNavWrap function");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task39 NavMenu must have theme switcher with prtaskToggleTheme prtaskGetTheme JS interop and clear-cache link")]
    public void Task39ThemeSwitcherAndClearCache()
    {
        var Nav = ReadSource("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Nav.Contains("JsInteropConstants.ToggleTheme"), "Must have ToggleTheme JS interop");
        Assert.IsTrue(Nav.Contains("JsInteropConstants.GetTheme"), "Must have GetTheme JS interop");
        Assert.IsTrue(Nav.Contains("clear-cache") || Nav.Contains("ClearCache"), "Must have clear-cache link");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task40 FooterSection must link to all legal pages including Terms Privacy Refund Licenses")]
    public void Task40FooterLinksToLegalPages()
    {
        var Footer = ReadSource("PrTask.SharedUI", "Components", "FooterSection.razor");
        Assert.IsTrue(Footer.Contains("RouteConstants.Terms") || Footer.Contains("/legal/terms"), "Must link to Terms");
        Assert.IsTrue(Footer.Contains("RouteConstants.Privacy") || Footer.Contains("/legal/privacy"), "Must link to Privacy");
        Assert.IsTrue(Footer.Contains("RouteConstants.Refund") || Footer.Contains("/legal/refund"), "Must link to Refund");
        Assert.IsTrue(Footer.Contains("RouteConstants.Licenses") || Footer.Contains("/legal/licenses"), "Must link to Licenses");
        Assert.IsTrue(Footer.Contains("RouteConstants.AcceptableUse") || Footer.Contains("/legal/acceptable-use"), "Must link to AcceptableUse");
        Assert.IsTrue(Footer.Contains("RouteConstants.CookiePolicy") || Footer.Contains("/legal/cookie-policy"), "Must link to CookiePolicy");
        Assert.IsTrue(Footer.Contains("accessibility") || Footer.Contains("Accessibility"), "Must link to Accessibility");
        Assert.IsTrue(Footer.Contains("RouteConstants.Dmca") || Footer.Contains("dmca") || Footer.Contains("DMCA"), "Must link to DMCA");
    }
}
