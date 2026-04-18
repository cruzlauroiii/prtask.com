using System.Net;
using System.Net.Http;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
[TestClass]
public class NavMenuTests
{
    private static readonly string SourceRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "..", "src"));
    private static readonly string SharedUiProject = "PrTask.SharedUI";
    private static readonly string ClientProject = "PrTask.Client";
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Hamburger menu CSS must use primary theme color border for visible themed styling")]
    public void HamburgerMenuCssMustUsePrimaryThemeColorBorderForVisibleThemedStyling()
    {
        var ScssPath = Path.Combine(SourceRoot, SharedUiProject, "Styles", "app.scss");
        var Content = File.ReadAllText(ScssPath);
        Assert.IsTrue(Content.Contains(".nav-toggle"), "SCSS must contain .nav-toggle class for hamburger button");
        var ToggleStart = Content.IndexOf(".nav-toggle", StringComparison.Ordinal);
        var ToggleEnd = Content.IndexOf('}', ToggleStart);
        var ToggleRule = Content[ToggleStart..ToggleEnd];
        Assert.IsTrue(ToggleRule.Contains("var(--color-primary)"), "Hamburger must use --color-primary for themed color");
        Assert.IsTrue(ToggleRule.Contains("2px solid"), "Hamburger must use 2px border for visibility");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Hamburger menu must toggle nav-open class via inline onclick JavaScript not Blazor event")]
    public void HamburgerMenuMustToggleNavOpenClassViaInlineOnclickJavaScriptNotBlazorEvent()
    {
        var ClientLayoutPath = Path.Combine(SourceRoot, ClientProject, "Components", "ClientLayout.razor");
        var Content = File.ReadAllText(ClientLayoutPath);
        Assert.IsTrue(Content.Contains("nav-toggle"), "Layout must contain nav-toggle hamburger button");
        Assert.IsTrue(
            Content.Contains("onclick=") && Content.Contains("nav-open"),
            "Hamburger must use inline onclick JavaScript to toggle nav-open class");
        Assert.IsFalse(
            Content.Contains("@onclick=\"ToggleMenu\""),
            "Hamburger must not use Blazor @onclick which fails on mobile");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Sign out element must use anchor tag with href for reliable navigation not Blazor onclick")]
    public void SignOutElementMustUseAnchorTagWithHrefForReliableNavigationNotBlazorOnclick()
    {
        var ClientLayoutPath = Path.Combine(SourceRoot, ClientProject, "Components", "ClientLayout.razor");
        var Content = File.ReadAllText(ClientLayoutPath);
        Assert.IsTrue(
            Content.Contains("nav-logout") && Content.Contains("Sign Out"),
            "Layout must contain nav-logout Sign Out element");
        Assert.IsTrue(
            Content.Contains("<a") && Content.Contains("nav-logout"),
            "Sign out must be an <a> anchor tag not a <button>");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Sign out button CSS must use primary color border for visible themed styling")]
    public void SignOutButtonCssMustUsePrimaryColorBorderForVisibleThemedStyling()
    {
        var ScssPath = Path.Combine(SourceRoot, SharedUiProject, "Styles", "app.scss");
        var Content = File.ReadAllText(ScssPath);
        Assert.IsTrue(Content.Contains(".nav-logout"), "SCSS must contain .nav-logout class for sign out button");
        var LogoutStart = Content.IndexOf(".nav-logout", StringComparison.Ordinal);
        var LogoutEnd = Content.IndexOf('}', LogoutStart);
        var LogoutRule = Content[LogoutStart..LogoutEnd];
        Assert.IsTrue(LogoutRule.Contains("var(--color-primary)"), "Sign out must use --color-primary for themed color");
        Assert.IsTrue(LogoutRule.Contains("2px solid"), "Sign out must use 2px border for visibility");
        Assert.IsTrue(LogoutRule.Contains("font-size: 1rem"), "Sign out must use 1rem font size not 0.875rem");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Username in nav must be a link to dashboard not a span for clickable navigation")]
    public void UserNameInNavMustBeALinkToDashboardNotASpanForClickableNavigation()
    {
        var ClientLayoutPath = Path.Combine(SourceRoot, ClientProject, "Components", "ClientLayout.razor");
        var Content = File.ReadAllText(ClientLayoutPath);
        Assert.IsTrue(Content.Contains("nav-user"), "Layout must contain nav-user class for username");
        Assert.IsTrue(
            Content.Contains("<a") && Content.Contains("nav-user") && Content.Contains("Dashboard"),
            "Username must be an <a> link to Dashboard route");
        Assert.IsFalse(
            Content.Contains("<span") && Content.Contains("nav-user"),
            "Username must not be a <span> — it must be a clickable link");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Login page must not auto redirect to API endpoint to prevent loading screen on pure WASM")]
    public void LoginPageMustNotAutoRedirectToApiEndpointToPreventLoadingScreenOnPureWasm()
    {
        var ClientLoginPath = Path.Combine(SourceRoot, ClientProject, "Pages", "ClientLoginPage.razor");
        var SharedLoginPath = Path.Combine(SourceRoot, SharedUiProject, "Pages", "LoginPage.razor");
        var ClientContent = File.ReadAllText(ClientLoginPath);
        var SharedContent = File.ReadAllText(SharedLoginPath);
        Assert.IsFalse(ClientContent.Contains("forceLoad"), "Client login page must not use forceLoad");
        Assert.IsFalse(SharedContent.Contains("forceLoad"), "SharedUI login page must not use forceLoad");
        Assert.IsFalse(ClientContent.Contains("NavigateTo"), "Client login page must not auto-redirect via NavigateTo");
        Assert.IsFalse(SharedContent.Contains("NavigateTo"), "SharedUI login page must not auto-redirect via NavigateTo");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("MAUI project must use SharedUI layout via MauiLayout for clean architecture reuse")]
    public void MauiProjectMustUseSharedUiLayoutViaMauiLayoutForCleanArchitectureReuse()
    {
        var MauiLayoutPath = Path.Combine(SourceRoot, "PrTask.Maui", "Components", "MauiLayout.razor");
        var Content = File.ReadAllText(MauiLayoutPath);
        Assert.IsTrue(Content.Contains("PrTask.SharedUI.Components.NavMenu"), "MAUI layout must use SharedUI NavMenu component");
        Assert.IsTrue(Content.Contains("@Body"), "MAUI layout must render @Body for page content");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("MAUI pages must wrap SharedUI page components for clean architecture single source of truth")]
    public void MauiPagesMustWrapSharedUiPageComponentsForCleanArchitectureSingleSourceOfTruth()
    {
        var MauiPagesDir = Path.Combine(SourceRoot, "PrTask.Maui", "Pages");
        var RazorFiles = Directory.GetFiles(MauiPagesDir, "*.razor", SearchOption.AllDirectories);
        Assert.IsTrue(RazorFiles.Length >= 10, $"MAUI must have at least 10 page wrappers, found {RazorFiles.Length}");
        foreach (var FilePath in RazorFiles)
        {
            var FileName = Path.GetFileName(FilePath);
            if (FileName == "MauiLoginPage.razor")
            {
                continue;
            }
            var Content = File.ReadAllText(FilePath);
            Assert.IsTrue(
                Content.Contains("PrTask.SharedUI.Pages."),
                $"MAUI page {FileName} must reference a SharedUI page component");
        }
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("MAUI project must have Android platform files for proper native app deployment")]
    public void MauiProjectMustHaveAndroidPlatformFilesForProperNativeAppDeployment()
    {
        var PlatformsDir = Path.Combine(SourceRoot, "PrTask.Maui", "Platforms", "Android");
        Assert.IsTrue(Directory.Exists(PlatformsDir), "MAUI must have Platforms/Android directory");
        Assert.IsTrue(File.Exists(Path.Combine(PlatformsDir, "MainActivity.cs")), "MAUI must have MainActivity.cs");
        Assert.IsTrue(File.Exists(Path.Combine(PlatformsDir, "MainApplication.cs")), "MAUI must have MainApplication.cs");
        Assert.IsTrue(File.Exists(Path.Combine(PlatformsDir, "AndroidManifest.xml")), "MAUI must have AndroidManifest.xml");
    }
    [TestMethod, TestCategory("Architecture")]
    [DisplayName("Nav menu CSS must contain nav-open toggle rule for hamburger menu responsive behavior")]
    public void NavMenuCssMustContainNavOpenToggleRuleForHamburgerMenuResponsiveBehavior()
    {
        var ScssPath = Path.Combine(SourceRoot, SharedUiProject, "Styles", "app.scss");
        var Content = File.ReadAllText(ScssPath);
        Assert.IsTrue(Content.Contains("nav-open"), "SCSS must contain nav-open class for mobile menu toggle");
        Assert.IsTrue(Content.Contains("display: flex") || Content.Contains("display:flex"), "SCSS must show nav-links as flex when nav-open");
        Assert.IsTrue(Content.Contains("display: none") || Content.Contains("display:none"), "SCSS must hide nav-links by default on mobile");
        Assert.IsTrue(Content.Contains("@media"), "SCSS must contain media query for responsive behavior");
    }
}
