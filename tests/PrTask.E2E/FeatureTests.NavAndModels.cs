namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu must have links to all main pages including tasks leaderboard pricing and about")]
    public void NavMenuMustHaveLinksToAllMainPagesIncludingTasksLeaderboardPricingAndAbout()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Razor.Contains("href=\"/tasks\"", StringComparison.Ordinal), "NavMenu must link to tasks page");
        Assert.IsTrue(Razor.Contains("href=\"/leaderboard\"", StringComparison.Ordinal), "NavMenu must link to leaderboard page");
        Assert.IsTrue(Razor.Contains("href=\"/pricing\"", StringComparison.Ordinal), "NavMenu must link to pricing page");
        Assert.IsTrue(Razor.Contains("href=\"/about\"", StringComparison.Ordinal), "NavMenu must link to about page");
        Assert.IsTrue(Razor.Contains("href=\"/how-it-works\"", StringComparison.Ordinal), "NavMenu must link to how it works page");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu must have links to dashboard download settings and login pages")]
    public void NavMenuMustHaveLinksToDownloadDashboardSettingsAndLoginPages()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Razor.Contains("href=\"/dashboard\"", StringComparison.Ordinal), "NavMenu must link to dashboard page");
        Assert.IsTrue(Razor.Contains("href=\"/download\"", StringComparison.Ordinal), "NavMenu must link to download page");
        Assert.IsTrue(Razor.Contains("href=\"/settings\"", StringComparison.Ordinal), "NavMenu must link to settings page");
        Assert.IsTrue(Razor.Contains("href=\"/login\"", StringComparison.Ordinal), "NavMenu must link to login page");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu must have links to all eight legal pages for compliance navigation")]
    public void NavMenuMustHaveLinksToAllEightLegalPagesForComplianceNavigation()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Razor.Contains("href=\"/legal/terms\"", StringComparison.Ordinal), "NavMenu must link to terms page");
        Assert.IsTrue(Razor.Contains("href=\"/legal/privacy\"", StringComparison.Ordinal), "NavMenu must link to privacy page");
        Assert.IsTrue(Razor.Contains("href=\"/legal/cookie-policy\"", StringComparison.Ordinal), "NavMenu must link to cookie policy page");
        Assert.IsTrue(Razor.Contains("href=\"/legal/acceptable-use\"", StringComparison.Ordinal), "NavMenu must link to acceptable use page");
        Assert.IsTrue(Razor.Contains("href=\"/legal/refund\"", StringComparison.Ordinal), "NavMenu must link to refund page");
        Assert.IsTrue(Razor.Contains("href=\"/legal/licenses\"", StringComparison.Ordinal), "NavMenu must link to licenses page");
        Assert.IsTrue(Razor.Contains("href=\"/legal/accessibility\"", StringComparison.Ordinal), "NavMenu must link to accessibility page");
        Assert.IsTrue(Razor.Contains("href=\"/legal/dmca\"", StringComparison.Ordinal), "NavMenu must link to dmca page");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu must use js interop for theme toggle auth check and sign out functions")]
    public void NavMenuMustUseJsInteropForThemeToggleAuthCheckAndSignOutFunctions()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Razor.Contains("prtaskGetTheme", StringComparison.Ordinal), "NavMenu must call prtaskGetTheme for initial theme");
        Assert.IsTrue(Razor.Contains("prtaskToggleTheme", StringComparison.Ordinal), "NavMenu must call prtaskToggleTheme on toggle");
        Assert.IsTrue(Razor.Contains("prtaskCheckAuth", StringComparison.Ordinal), "NavMenu must call prtaskCheckAuth for login state");
        Assert.IsTrue(Razor.Contains("prtaskSignOut", StringComparison.Ordinal), "NavMenu must call prtaskSignOut for logout");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu must show authenticated user name and sign out button when logged in")]
    public void NavMenuMustShowAuthenticatedUserNameAndSignOutButtonWhenLoggedIn()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Razor.Contains("IsAuthenticated", StringComparison.Ordinal), "NavMenu must track authentication state");
        Assert.IsTrue(Razor.Contains("CurrentUser", StringComparison.Ordinal), "NavMenu must display current username");
        Assert.IsTrue(Razor.Contains("nav-user", StringComparison.Ordinal), "NavMenu must use nav-user class for username display");
        Assert.IsTrue(Razor.Contains("Sign Out", StringComparison.Ordinal), "NavMenu must have sign out button");
        Assert.IsTrue(Razor.Contains("Sign In", StringComparison.Ordinal), "NavMenu must show sign in when not authenticated");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu must have clear cache link and hamburger toggle with nav brand link")]
    public void NavMenuMustHaveClearCacheLinkAndHamburgerToggleWithNavBrandLink()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Razor.Contains("clear-cache.html", StringComparison.Ordinal), "NavMenu must link to clear-cache.html");
        Assert.IsTrue(Razor.Contains("nav-toggle", StringComparison.Ordinal), "NavMenu must have hamburger toggle button");
        Assert.IsTrue(Razor.Contains("nav-brand", StringComparison.Ordinal), "NavMenu must have PrTask brand link");
        Assert.IsTrue(Razor.Contains("theme-toggle", StringComparison.Ordinal), "NavMenu must have theme toggle button");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Nav menu must close mobile menu by removing nav open class on any link click")]
    public void NavMenuMustCloseMobileMenuByRemovingNavOpenClassOnAnyLinkClick()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "NavMenu.razor");
        Assert.IsTrue(Razor.Contains("classList.remove('nav-open')", StringComparison.Ordinal), "NavMenu links must remove nav-open class on click");
        Assert.IsTrue(Razor.Contains("classList.toggle('nav-open')", StringComparison.Ordinal), "NavMenu hamburger must toggle nav-open class");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request entity must have github pr url diff storage key and all timestamp fields")]
    public void PullRequestEntityMustHaveGitHubPrUrlDiffStorageKeyAndAllTimestampFields()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "PullRequestEntity.cs");
        Assert.IsTrue(Code.Contains("GitHubPrUrl", StringComparison.Ordinal), "PullRequestEntity must have GitHub PR URL");
        Assert.IsTrue(Code.Contains("DiffStorageKey", StringComparison.Ordinal), "PullRequestEntity must have diff storage key");
        Assert.IsTrue(Code.Contains("MergedAt", StringComparison.Ordinal), "PullRequestEntity must have merge timestamp");
        Assert.IsTrue(Code.Contains("PaidAt", StringComparison.Ordinal), "PullRequestEntity must have payment timestamp");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request status enum must define five lifecycle states from submitted through paid")]
    public void PullRequestStatusEnumMustDefineFiveLifecycleStatesFromSubmittedThroughPaid()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "PullRequestStatus.cs");
        Assert.IsTrue(Code.Contains("Submitted = 0", StringComparison.Ordinal), "PullRequestStatus must start with Submitted=0");
        Assert.IsTrue(Code.Contains("Approved = 1", StringComparison.Ordinal), "PullRequestStatus must have Approved=1");
        Assert.IsTrue(Code.Contains("Rejected = 2", StringComparison.Ordinal), "PullRequestStatus must have Rejected=2");
        Assert.IsTrue(Code.Contains("Merged = 3", StringComparison.Ordinal), "PullRequestStatus must have Merged=3");
        Assert.IsTrue(Code.Contains("Paid = 4", StringComparison.Ordinal), "PullRequestStatus must have Paid=4");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("User entity must have display name avatar url email xp level and streak days fields")]
    public void UserEntityMustHaveDisplayNameAvatarUrlEmailXpLevelAndStreakDaysFields()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "UserEntity.cs");
        Assert.IsTrue(Code.Contains("DisplayName", StringComparison.Ordinal), "UserEntity must have DisplayName for profile display");
        Assert.IsTrue(Code.Contains("AvatarUrl", StringComparison.Ordinal), "UserEntity must have AvatarUrl for profile image");
        Assert.IsTrue(Code.Contains("Email", StringComparison.Ordinal), "UserEntity must have Email for contact");
        Assert.IsTrue(Code.Contains("Xp", StringComparison.Ordinal), "UserEntity must have Xp for gamification");
        Assert.IsTrue(Code.Contains("Level", StringComparison.Ordinal), "UserEntity must have Level for progression");
        Assert.IsTrue(Code.Contains("StreakDays", StringComparison.Ordinal), "UserEntity must have StreakDays for activity tracking");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("User entity must default to developer role level one and utc now timestamps")]
    public void UserEntityMustDefaultToDeveloperRoleLevelOneAndUtcNowTimestamps()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Models", "UserEntity.cs");
        Assert.IsTrue(Code.Contains("UserRole.Developer", StringComparison.Ordinal), "UserEntity must default role to Developer");
        Assert.IsTrue(Code.Contains("Level { get; set; } = 1", StringComparison.Ordinal), "UserEntity must default Level to 1");
        Assert.IsTrue(Code.Contains("CreatedAt", StringComparison.Ordinal), "UserEntity must have CreatedAt timestamp");
        Assert.IsTrue(Code.Contains("UpdatedAt", StringComparison.Ordinal), "UserEntity must have UpdatedAt timestamp");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("User service interface must define get by id github id and create update methods")]
    public void UserServiceInterfaceMustDefineGetByIdGitHubIdAndCreateUpdateMethods()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IUserService.cs");
        Assert.IsTrue(Code.Contains("GetByIdAsync", StringComparison.Ordinal), "IUserService must have GetByIdAsync");
        Assert.IsTrue(Code.Contains("GetByGitHubIdAsync", StringComparison.Ordinal), "IUserService must have GetByGitHubIdAsync");
        Assert.IsTrue(Code.Contains("CreateOrUpdateFromGitHubAsync", StringComparison.Ordinal), "IUserService must have GitHub auth method");
        Assert.IsTrue(Code.Contains("CreateOrUpdateFromOidcAsync", StringComparison.Ordinal), "IUserService must have OIDC auth method");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Achievement service interface must define get by user and evaluate award badges methods")]
    public void AchievementServiceInterfaceMustDefineGetByUserAndEvaluateAwardBadgesMethods()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IAchievementService.cs");
        Assert.IsTrue(Code.Contains("GetByUserAsync", StringComparison.Ordinal), "IAchievementService must have GetByUserAsync");
        Assert.IsTrue(Code.Contains("EvaluateAndAwardBadgesAsync", StringComparison.Ordinal), "IAchievementService must have badge evaluation");
        Assert.IsTrue(Code.Contains("AchievementEntity", StringComparison.Ordinal), "IAchievementService must return AchievementEntity");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Footer section must have platform links legal links brand name and copyright notice")]
    public void FooterSectionMustHavePlatformLinksLegalLinksBrandNameAndCopyrightNotice()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "FooterSection.razor");
        Assert.IsTrue(Razor.Contains("Browse Tasks", StringComparison.Ordinal), "Footer must link to browse tasks");
        Assert.IsTrue(Razor.Contains("Leaderboard", StringComparison.Ordinal), "Footer must link to leaderboard");
        Assert.IsTrue(Razor.Contains("How It Works", StringComparison.Ordinal), "Footer must link to how it works");
        Assert.IsTrue(Razor.Contains("Terms", StringComparison.Ordinal), "Footer must link to terms page");
        Assert.IsTrue(Razor.Contains("Privacy", StringComparison.Ordinal), "Footer must link to privacy page");
        Assert.IsTrue(Razor.Contains("2026 PrTask", StringComparison.Ordinal), "Footer must have 2026 copyright");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Main layout must inherit layout component base and render nav menu with body content")]
    public void MainLayoutMustInheritLayoutComponentBaseAndRenderNavMenuWithBodyContent()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Components", "MainLayout.razor");
        Assert.IsTrue(Razor.Contains("LayoutComponentBase", StringComparison.Ordinal), "MainLayout must inherit LayoutComponentBase");
        Assert.IsTrue(Razor.Contains("NavMenu", StringComparison.Ordinal), "MainLayout must render NavMenu component");
        Assert.IsTrue(Razor.Contains("@Body", StringComparison.Ordinal), "MainLayout must render page body content");
        Assert.IsTrue(Razor.Contains("page-content", StringComparison.Ordinal), "MainLayout must wrap body in page-content class");
    }
}
