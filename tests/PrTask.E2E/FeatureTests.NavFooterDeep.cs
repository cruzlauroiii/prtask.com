namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu must inject ijs runtime and have brand link to root with prtask text label")]
    public void NavMenuMustInjectIjsRuntimeAndHaveBrandLinkToRootWithPrtaskTextLabel()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Code.Contains("@inject IJSRuntime JsRuntime", StringComparison.Ordinal), "NavMenu must inject IJSRuntime");
        Assert.IsTrue(Code.Contains("nav-brand", StringComparison.Ordinal), "NavMenu must have nav-brand class");
        Assert.IsTrue(Code.Contains(">PrTask</a>", StringComparison.Ordinal), "NavMenu brand must display PrTask text");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu must have toggle button with hamburger character and nav open class toggle onclick")]
    public void NavMenuMustHaveToggleButtonWithHamburgerCharacterAndNavOpenClassToggleOnclick()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Code.Contains("nav-toggle", StringComparison.Ordinal), "NavMenu must have nav-toggle button class");
        Assert.IsTrue(Code.Contains("&#9776;", StringComparison.Ordinal), "NavMenu toggle must use hamburger HTML entity");
        Assert.IsTrue(Code.Contains("classList.toggle('nav-open')", StringComparison.Ordinal), "NavMenu must toggle nav-open class on click");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu links must include tasks leaderboard how it works pricing about dashboard download and settings")]
    public void NavMenuLinksMustIncludeTasksLeaderboardHowItWorksPricingAboutDashboardDownloadAndSettings()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Code.Contains("href=\"/tasks\"", StringComparison.Ordinal), "NavMenu must link to tasks page");
        Assert.IsTrue(Code.Contains("href=\"/leaderboard\"", StringComparison.Ordinal), "NavMenu must link to leaderboard page");
        Assert.IsTrue(Code.Contains("href=\"/how-it-works\"", StringComparison.Ordinal), "NavMenu must link to how it works page");
        Assert.IsTrue(Code.Contains("href=\"/pricing\"", StringComparison.Ordinal), "NavMenu must link to pricing page");
        Assert.IsTrue(Code.Contains("href=\"/dashboard\"", StringComparison.Ordinal), "NavMenu must link to dashboard page");
        Assert.IsTrue(Code.Contains("href=\"/download\"", StringComparison.Ordinal), "NavMenu must link to download page");
        Assert.IsTrue(Code.Contains("href=\"/settings\"", StringComparison.Ordinal), "NavMenu must link to settings page");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu must have all eight legal page links including terms privacy cookie and acceptable use")]
    public void NavMenuMustHaveAllEightLegalPageLinksIncludingTermsPrivacyCookieAndAcceptableUse()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Code.Contains("href=\"/legal/terms\"", StringComparison.Ordinal), "NavMenu must link to terms legal page");
        Assert.IsTrue(Code.Contains("href=\"/legal/privacy\"", StringComparison.Ordinal), "NavMenu must link to privacy legal page");
        Assert.IsTrue(Code.Contains("href=\"/legal/cookie-policy\"", StringComparison.Ordinal), "NavMenu must link to cookie policy page");
        Assert.IsTrue(Code.Contains("href=\"/legal/acceptable-use\"", StringComparison.Ordinal), "NavMenu must link to acceptable use page");
        Assert.IsTrue(Code.Contains("href=\"/legal/refund\"", StringComparison.Ordinal), "NavMenu must link to refund policy page");
        Assert.IsTrue(Code.Contains("href=\"/legal/licenses\"", StringComparison.Ordinal), "NavMenu must link to licenses page");
        Assert.IsTrue(Code.Contains("href=\"/legal/accessibility\"", StringComparison.Ordinal), "NavMenu must link to accessibility page");
        Assert.IsTrue(Code.Contains("href=\"/legal/dmca\"", StringComparison.Ordinal), "NavMenu must link to DMCA page");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu theme toggle must use js interop prtask get theme and prtask toggle theme functions")]
    public void NavMenuThemeToggleMustUseJsInteropPrtaskGetThemeAndPrtaskToggleThemeFunctions()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Code.Contains("prtaskGetTheme", StringComparison.Ordinal), "NavMenu must call prtaskGetTheme JS interop function");
        Assert.IsTrue(Code.Contains("prtaskToggleTheme", StringComparison.Ordinal), "NavMenu must call prtaskToggleTheme JS interop function");
        Assert.IsTrue(Code.Contains("ThemeIcon = Current == \"dark\" ? \"☾\" : \"☀\"", StringComparison.Ordinal), "NavMenu must toggle theme icon between sun and moon");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu auth state must call prtask check auth on first render and show sign in or sign out")]
    public void NavMenuAuthStateMustCallPrtaskCheckAuthOnFirstRenderAndShowSignInOrSignOut()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Code.Contains("prtaskCheckAuth", StringComparison.Ordinal), "NavMenu must call prtaskCheckAuth JS function on first render");
        Assert.IsTrue(Code.Contains("IsAuthenticated = true", StringComparison.Ordinal), "NavMenu must set IsAuthenticated when user exists");
        Assert.IsTrue(Code.Contains("StateHasChanged()", StringComparison.Ordinal), "NavMenu must call StateHasChanged after auth check");
        Assert.IsTrue(Code.Contains("Sign Out", StringComparison.Ordinal), "NavMenu must show Sign Out when authenticated");
        Assert.IsTrue(Code.Contains("Sign In", StringComparison.Ordinal), "NavMenu must show Sign In when not authenticated");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu sign out handler must call prtask sign out js interop and reset authentication state")]
    public void NavMenuSignOutHandlerMustCallPrtaskSignOutJsInteropAndResetAuthenticationState()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Code.Contains("prtaskSignOut", StringComparison.Ordinal), "NavMenu signout must call prtaskSignOut JS function");
        Assert.IsTrue(Code.Contains("IsAuthenticated = false", StringComparison.Ordinal), "NavMenu signout must reset IsAuthenticated to false");
        Assert.IsTrue(Code.Contains("CurrentUser = string.Empty", StringComparison.Ordinal), "NavMenu signout must clear CurrentUser string");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu must show clear cache link and nav user span with authenticated username display")]
    public void NavMenuMustShowClearCacheLinkAndNavUserSpanWithAuthenticatedUsernameDisplay()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Code.Contains("clear-cache.html", StringComparison.Ordinal), "NavMenu must link to clear-cache.html");
        Assert.IsTrue(Code.Contains("&#x21bb;", StringComparison.Ordinal), "NavMenu must use refresh HTML entity for cache clear");
        Assert.IsTrue(Code.Contains("nav-user", StringComparison.Ordinal), "NavMenu must have nav-user class for username display");
        Assert.IsTrue(Code.Contains("@CurrentUser", StringComparison.Ordinal), "NavMenu must display CurrentUser text");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Footer section must have brand with prtask logo text and earn money tagline paragraph")]
    public void FooterSectionMustHaveBrandWithPrtaskLogoTextAndEarnMoneyTaglineParagraph()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "FooterSection.razor");
        Assert.IsTrue(Code.Contains("site-footer", StringComparison.Ordinal), "Footer must use site-footer class");
        Assert.IsTrue(Code.Contains("footer-brand", StringComparison.Ordinal), "Footer must have footer-brand section");
        Assert.IsTrue(Code.Contains("footer-logo", StringComparison.Ordinal), "Footer must have footer-logo class");
        Assert.IsTrue(Code.Contains("Earn money with pull requests", StringComparison.Ordinal), "Footer must have tagline text");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Footer platform column must link to tasks leaderboard how it works and pricing pages")]
    public void FooterPlatformColumnMustLinkToTasksLeaderboardHowItWorksAndPricingPages()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "FooterSection.razor");
        Assert.IsTrue(Code.Contains(">Platform</h4>", StringComparison.Ordinal), "Footer must have Platform column heading");
        Assert.IsTrue(Code.Contains("Browse Tasks", StringComparison.Ordinal), "Footer must link to Browse Tasks");
        Assert.IsTrue(Code.Contains("href=\"/leaderboard\"", StringComparison.Ordinal), "Footer must link to Leaderboard");
        Assert.IsTrue(Code.Contains("href=\"/how-it-works\"", StringComparison.Ordinal), "Footer must link to How It Works");
        Assert.IsTrue(Code.Contains("href=\"/pricing\"", StringComparison.Ordinal), "Footer must link to Pricing");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Footer legal column must link to terms privacy refund licenses acceptable use and cookie policy")]
    public void FooterLegalColumnMustLinkToTermsPrivacyRefundLicensesAcceptableUseAndCookiePolicy()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "FooterSection.razor");
        Assert.IsTrue(Code.Contains(">Legal</h4>", StringComparison.Ordinal), "Footer must have Legal column heading");
        Assert.IsTrue(Code.Contains("href=\"/legal/terms\"", StringComparison.Ordinal), "Footer must link to Terms");
        Assert.IsTrue(Code.Contains("href=\"/legal/privacy\"", StringComparison.Ordinal), "Footer must link to Privacy");
        Assert.IsTrue(Code.Contains("href=\"/legal/refund\"", StringComparison.Ordinal), "Footer must link to Refund Policy");
        Assert.IsTrue(Code.Contains("href=\"/legal/licenses\"", StringComparison.Ordinal), "Footer must link to Licenses");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Footer bottom section must display 2026 copyright notice with all rights reserved text")]
    public void FooterBottomSectionMustDisplay2026CopyrightNoticeWithAllRightsReservedText()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Components", "FooterSection.razor");
        Assert.IsTrue(Code.Contains("footer-bottom", StringComparison.Ordinal), "Footer must have footer-bottom section");
        Assert.IsTrue(Code.Contains("2026 PrTask", StringComparison.Ordinal), "Footer must show 2026 copyright year");
        Assert.IsTrue(Code.Contains("All rights reserved", StringComparison.Ordinal), "Footer must include all rights reserved text");
    }
}
