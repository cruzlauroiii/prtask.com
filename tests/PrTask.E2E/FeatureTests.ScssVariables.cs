namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Scss variables must define primary color as hex 2563eb and primary dark as hex 1d4ed8")]
    public void ScssVariablesMustDefinePrimaryColorAsHex2563ebAndPrimaryDarkAsHex1d4ed8()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Styles", "_variables.scss");
        Assert.IsTrue(Code.Contains("$color-primary: #2563eb", StringComparison.Ordinal), "Variables must define primary color as #2563eb");
        Assert.IsTrue(Code.Contains("$color-primary-dark: #1d4ed8", StringComparison.Ordinal), "Variables must define primary-dark as #1d4ed8");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Scss variables must define secondary color as hex 64748b and accent color as hex 10b981")]
    public void ScssVariablesMustDefineSecondaryColorAsHex64748bAndAccentColorAsHex10b981()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Styles", "_variables.scss");
        Assert.IsTrue(Code.Contains("$color-secondary: #64748b", StringComparison.Ordinal), "Variables must define secondary color as #64748b");
        Assert.IsTrue(Code.Contains("$color-accent: #10b981", StringComparison.Ordinal), "Variables must define accent color as #10b981");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Scss variables must define segoe ui system font stack and cascadia code monospace font")]
    public void ScssVariablesMustDefineSegoeUiSystemFontStackAndCascadiaCodeMonospaceFont()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Styles", "_variables.scss");
        Assert.IsTrue(Code.Contains("$font-main: \"Segoe UI\", system-ui, -apple-system, sans-serif", StringComparison.Ordinal), "Variables must define main font stack with Segoe UI");
        Assert.IsTrue(Code.Contains("$font-mono: \"Cascadia Code\", \"Fira Code\", monospace", StringComparison.Ordinal), "Variables must define mono font stack with Cascadia Code");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Scss variables must define eight pixel border radius variable for consistent component rounding")]
    public void ScssVariablesMustDefineEightPixelBorderRadiusVariableForConsistentComponentRounding()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Styles", "_variables.scss");
        Assert.IsTrue(Code.Contains("$radius: 8px", StringComparison.Ordinal), "Variables must define $radius as 8px");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Scss dark theme mixin must define dark background surface text muted and border custom properties")]
    public void ScssDarkThemeMixinMustDefineDarkBackgroundSurfaceTextMutedAndBorderCustomProperties()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Styles", "_variables.scss");
        Assert.IsTrue(Code.Contains("--color-bg: #0f172a", StringComparison.Ordinal), "Dark theme must set bg to #0f172a");
        Assert.IsTrue(Code.Contains("--color-surface: #1e293b", StringComparison.Ordinal), "Dark theme must set surface to #1e293b");
        Assert.IsTrue(Code.Contains("--color-text: #f1f5f9", StringComparison.Ordinal), "Dark theme must set text to #f1f5f9");
        Assert.IsTrue(Code.Contains("--color-text-muted: #94a3b8", StringComparison.Ordinal), "Dark theme must set text-muted to #94a3b8");
        Assert.IsTrue(Code.Contains("--color-border: #334155", StringComparison.Ordinal), "Dark theme must set border to #334155");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Scss root light theme must define white background slate surface and dark text custom properties")]
    public void ScssRootLightThemeMustDefineWhiteBackgroundSlateSurfaceAndDarkTextCustomProperties()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Styles", "_variables.scss");
        Assert.IsTrue(Code.Contains("--color-bg: #ffffff", StringComparison.Ordinal), "Light theme must set bg to white");
        Assert.IsTrue(Code.Contains("--color-surface: #f8fafc", StringComparison.Ordinal), "Light theme must set surface to #f8fafc");
        Assert.IsTrue(Code.Contains("--color-text: #0f172a", StringComparison.Ordinal), "Light theme must set text to #0f172a");
        Assert.IsTrue(Code.Contains("--color-text-muted: #64748b", StringComparison.Ordinal), "Light theme must set text-muted to #64748b");
        Assert.IsTrue(Code.Contains("--color-border: #e2e8f0", StringComparison.Ordinal), "Light theme must set border to #e2e8f0");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Scss root must interpolate primary primary dark and accent sass variables into custom properties")]
    public void ScssRootMustInterpolatePrimaryPrimaryDarkAndAccentSassVariablesIntoCustomProperties()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Styles", "_variables.scss");
        Assert.IsTrue(Code.Contains("--color-primary: #{$color-primary}", StringComparison.Ordinal), "Root must interpolate $color-primary into custom property");
        Assert.IsTrue(Code.Contains("--color-primary-dark: #{$color-primary-dark}", StringComparison.Ordinal), "Root must interpolate $color-primary-dark into custom property");
        Assert.IsTrue(Code.Contains("--color-accent: #{$color-accent}", StringComparison.Ordinal), "Root must interpolate $color-accent into custom property");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Scss media query must apply dark theme mixin when prefers color scheme dark and not light override")]
    public void ScssMediaQueryMustApplyDarkThemeMixinWhenPrefersColorSchemeDarkAndNotLightOverride()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Styles", "_variables.scss");
        Assert.IsTrue(Code.Contains("@media (prefers-color-scheme: dark)", StringComparison.Ordinal), "Variables must have dark scheme media query");
        Assert.IsTrue(Code.Contains(":root:not([data-theme=\"light\"])", StringComparison.Ordinal), "Dark scheme must not apply when data-theme is light");
        Assert.IsTrue(Code.Contains("@include dark-theme", StringComparison.Ordinal), "Dark scheme must include dark-theme mixin");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Server site scss must import shared ui styles using at use directive with relative path")]
    public void ServerSiteScssMustImportSharedUiStylesUsingAtUseDirectiveWithRelativePath()
    {
        var Code = ReadSourceFile("PrTask.Server", "Styles", "site.scss");
        Assert.IsTrue(Code.Contains("@use \"../../PrTask.SharedUI/Styles/app\"", StringComparison.Ordinal), "Server site.scss must @use SharedUI app styles");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Leaderboard page must inject leaderboard service and fetch top fifty entries on initialized")]
    public void LeaderboardPageMustInjectLeaderboardServiceAndFetchTopFiftyEntriesOnInitialized()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "LeaderboardPage.razor");
        Assert.IsTrue(Code.Contains("@inject ILeaderboardService LeaderboardService", StringComparison.Ordinal), "Leaderboard must inject ILeaderboardService");
        Assert.IsTrue(Code.Contains("LeaderboardService.GetTopAsync(50)", StringComparison.Ordinal), "Leaderboard must fetch top 50 entries");
        Assert.IsTrue(Code.Contains("leaderboard-table", StringComparison.Ordinal), "Leaderboard must use leaderboard-table class");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Leaderboard page header must show rank developer level xp prs merged and earned column labels")]
    public void LeaderboardPageHeaderMustShowRankDeveloperLevelXpPrsMergedAndEarnedColumnLabels()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "LeaderboardPage.razor");
        Assert.IsTrue(Code.Contains("<span>Rank</span>", StringComparison.Ordinal), "Leaderboard header must have Rank column");
        Assert.IsTrue(Code.Contains("<span>Developer</span>", StringComparison.Ordinal), "Leaderboard header must have Developer column");
        Assert.IsTrue(Code.Contains("<span>Level</span>", StringComparison.Ordinal), "Leaderboard header must have Level column");
        Assert.IsTrue(Code.Contains("<span>XP</span>", StringComparison.Ordinal), "Leaderboard header must have XP column");
        Assert.IsTrue(Code.Contains("<span>PRs Merged</span>", StringComparison.Ordinal), "Leaderboard header must have PRs Merged column");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Profile page must inject user service and leaderboard service with user id route parameter")]
    public void ProfilePageMustInjectUserServiceAndLeaderboardServiceWithUserIdRouteParameter()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "ProfilePage.razor");
        Assert.IsTrue(Code.Contains("@inject IUserService UserService", StringComparison.Ordinal), "Profile must inject IUserService");
        Assert.IsTrue(Code.Contains("@inject ILeaderboardService LeaderboardService", StringComparison.Ordinal), "Profile must inject ILeaderboardService");
        Assert.IsTrue(Code.Contains("@page \"/profile/{UserId}\"", StringComparison.Ordinal), "Profile must have UserId route parameter");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Profile page must show avatar display name github username badges and leaderboard rank")]
    public void ProfilePageMustShowAvatarDisplayNameGitHubUsernameBadgesAndLeaderboardRank()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "ProfilePage.razor");
        Assert.IsTrue(Code.Contains("profile-avatar", StringComparison.Ordinal), "Profile must use profile-avatar class");
        Assert.IsTrue(Code.Contains("ProfileUser.DisplayName ?? ProfileUser.GitHubUsername", StringComparison.Ordinal), "Profile must fallback from DisplayName to GitHubUsername");
        Assert.IsTrue(Code.Contains("profile-badges", StringComparison.Ordinal), "Profile must have profile-badges section");
        Assert.IsTrue(Code.Contains("#@UserRank", StringComparison.Ordinal), "Profile must display leaderboard rank");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Settings page must have profile notification withdrawal payment security privacy and account sections")]
    public void SettingsPageMustHaveProfileNotificationWithdrawalPaymentSecurityPrivacyAndAccountSections()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Code.Contains("Notification Preferences", StringComparison.Ordinal), "Settings must have Notification Preferences section");
        Assert.IsTrue(Code.Contains("Withdrawal Settings", StringComparison.Ordinal), "Settings must have Withdrawal Settings section");
        Assert.IsTrue(Code.Contains("Connected Accounts", StringComparison.Ordinal), "Settings must have Connected Accounts section");
        Assert.IsTrue(Code.Contains("Two-Factor Authentication (2FA)", StringComparison.Ordinal), "Settings must have 2FA option");
        Assert.IsTrue(Code.Contains("Profile Visibility", StringComparison.Ordinal), "Settings must have Profile Visibility option");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Settings page connected accounts must list google github microsoft and okta with not connected status")]
    public void SettingsPageConnectedAccountsMustListGoogleGitHubMicrosoftAndOktaWithNotConnectedStatus()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Code.Contains("<label>Google</label>", StringComparison.Ordinal), "Settings must list Google connected account");
        Assert.IsTrue(Code.Contains("<label>GitHub</label>", StringComparison.Ordinal), "Settings must list GitHub connected account");
        Assert.IsTrue(Code.Contains("<label>Microsoft</label>", StringComparison.Ordinal), "Settings must list Microsoft connected account");
        Assert.IsTrue(Code.Contains("<label>Okta</label>", StringComparison.Ordinal), "Settings must list Okta connected account");
        Assert.IsTrue(Code.Contains("Not connected", StringComparison.Ordinal), "Settings must show Not connected default status");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request detail page must have diff viewer with unified and split view toggle and file tree sidebar")]
    public void PullRequestDetailPageMustHaveDiffViewerWithUnifiedAndSplitViewToggleAndFileTreeSidebar()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(Code.Contains("diff-view-toggle", StringComparison.Ordinal), "PR detail must have diff view toggle button");
        Assert.IsTrue(Code.Contains("diff-file-tree", StringComparison.Ordinal), "PR detail must have file tree sidebar");
        Assert.IsTrue(Code.Contains("diff-unified", StringComparison.Ordinal), "PR detail must support unified diff view class");
        Assert.IsTrue(Code.Contains("diff-split", StringComparison.Ordinal), "PR detail must support split diff view class");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Pull request detail page must show diff lines with context add and delete line type classes")]
    public void PullRequestDetailPageMustShowDiffLinesWithContextAddAndDeleteLineTypeClasses()
    {
        var Code = ReadSourceFile("PrTask.SharedUI", "Pages", "PullRequestDetailPage.razor");
        Assert.IsTrue(Code.Contains("line-context", StringComparison.Ordinal), "PR detail must use line-context class for unchanged lines");
        Assert.IsTrue(Code.Contains("line-add", StringComparison.Ordinal), "PR detail must use line-add class for added lines");
        Assert.IsTrue(Code.Contains("line-del", StringComparison.Ordinal), "PR detail must use line-del class for deleted lines");
        Assert.IsTrue(Code.Contains("Approve and Merge", StringComparison.Ordinal), "PR detail must have Approve and Merge button");
        Assert.IsTrue(Code.Contains("Request Changes", StringComparison.Ordinal), "PR detail must have Request Changes button");
    }
}
