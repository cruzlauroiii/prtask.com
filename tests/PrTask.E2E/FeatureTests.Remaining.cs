namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Diff sanitization service interface must define sanitize diff and extract file extensions methods")]
    public void DiffSanitizationServiceInterfaceMustDefineSanitizeDiffAndExtractFileExtensionsMethods()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IDiffSanitizationService.cs");
        Assert.IsTrue(Code.Contains("SanitizeDiffForPublicDisplay", StringComparison.Ordinal), "IDiffSanitizationService must have SanitizeDiffForPublicDisplay");
        Assert.IsTrue(Code.Contains("ExtractFileExtensions", StringComparison.Ordinal), "IDiffSanitizationService must have ExtractFileExtensions");
        Assert.IsTrue(Code.Contains("string RawDiff", StringComparison.Ordinal), "Both methods must accept raw diff string parameter");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Leaderboard rank response record must have single rank integer property for api return")]
    public void LeaderboardRankResponseRecordMustHaveSingleRankIntegerPropertyForApiReturn()
    {
        var Code = ReadSourceFile("PrTask.Application", "Contracts", "LeaderboardRankResponse.cs");
        Assert.IsTrue(Code.Contains("record", StringComparison.Ordinal), "LeaderboardRankResponse must be a record type");
        Assert.IsTrue(Code.Contains("int Rank", StringComparison.Ordinal), "LeaderboardRankResponse must have int Rank property");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui layout must inherit layout component base and render shared ui nav menu component")]
    public void MauiLayoutMustInheritLayoutComponentBaseAndRenderSharedUiNavMenuComponent()
    {
        var Razor = ReadSourceFile("PrTask.Maui", "Components", "MauiLayout.razor");
        Assert.IsTrue(Razor.Contains("LayoutComponentBase", StringComparison.Ordinal), "MauiLayout must inherit LayoutComponentBase");
        Assert.IsTrue(Razor.Contains("PrTask.SharedUI.Components.NavMenu", StringComparison.Ordinal), "MauiLayout must use SharedUI NavMenu");
        Assert.IsTrue(Razor.Contains("@Body", StringComparison.Ordinal), "MauiLayout must render page body content");
        Assert.IsTrue(Razor.Contains("page-content", StringComparison.Ordinal), "MauiLayout must wrap body in page-content class");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui layout must check session preferences for login state and display username")]
    public void MauiLayoutMustCheckSessionPreferencesForLoginStateAndDisplayUsername()
    {
        var Razor = ReadSourceFile("PrTask.Maui", "Components", "MauiLayout.razor");
        Assert.IsTrue(Razor.Contains("Preferences.Default.Get", StringComparison.Ordinal), "MauiLayout must read preferences for session");
        Assert.IsTrue(Razor.Contains("IsLoggedIn", StringComparison.Ordinal), "MauiLayout must track login state");
        Assert.IsTrue(Razor.Contains("Username", StringComparison.Ordinal), "MauiLayout must display username when logged in");
        Assert.IsTrue(Razor.Contains("maui-auth-bar", StringComparison.Ordinal), "MauiLayout must have auth bar section");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui layout must implement sign out by removing session and username from preferences")]
    public void MauiLayoutMustImplementSignOutByRemovingSessionAndUsernameFromPreferences()
    {
        var Razor = ReadSourceFile("PrTask.Maui", "Components", "MauiLayout.razor");
        Assert.IsTrue(Razor.Contains("Preferences.Default.Remove", StringComparison.Ordinal), "MauiLayout must clear preferences on sign out");
        Assert.IsTrue(Razor.Contains("SignOutAsync", StringComparison.Ordinal), "MauiLayout must have SignOutAsync method");
        Assert.IsTrue(Razor.Contains("NavigateTo(\"/login\")", StringComparison.Ordinal), "MauiLayout must navigate to login after sign out");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui routes must use router with maui layout as default layout for page rendering")]
    public void MauiRoutesMustUseRouterWithMauiLayoutAsDefaultLayoutForPageRendering()
    {
        var Razor = ReadSourceFile("PrTask.Maui", "Routes.razor");
        Assert.IsTrue(Razor.Contains("Router", StringComparison.Ordinal), "Maui Routes must use Router component");
        Assert.IsTrue(Razor.Contains("MauiLayout", StringComparison.Ordinal), "Maui Routes must use MauiLayout as default layout");
        Assert.IsTrue(Razor.Contains("RouteView", StringComparison.Ordinal), "Maui Routes must use RouteView for page rendering");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Shared ui imports must reference components routing web and jsinterop namespaces")]
    public void SharedUiImportsMustReferenceComponentsRoutingWebAndJsInteropNamespaces()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "_Imports.razor");
        Assert.IsTrue(Razor.Contains("Microsoft.AspNetCore.Components", StringComparison.Ordinal), "SharedUI imports must use Components namespace");
        Assert.IsTrue(Razor.Contains("Components.Routing", StringComparison.Ordinal), "SharedUI imports must use Routing namespace");
        Assert.IsTrue(Razor.Contains("Components.Web", StringComparison.Ordinal), "SharedUI imports must use Web namespace");
        Assert.IsTrue(Razor.Contains("Microsoft.JSInterop", StringComparison.Ordinal), "SharedUI imports must use JSInterop namespace");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client imports must reference domain constants and http json namespaces for api calls")]
    public void ClientImportsMustReferenceDomainConstantsAndHttpJsonNamespacesForApiCalls()
    {
        var Razor = ReadSourceFile("PrTask.Client", "_Imports.razor");
        Assert.IsTrue(Razor.Contains("PrTask.Domain.Constants", StringComparison.Ordinal), "Client imports must use Domain Constants namespace");
        Assert.IsTrue(Razor.Contains("System.Net.Http.Json", StringComparison.Ordinal), "Client imports must use Http.Json for API calls");
        Assert.IsTrue(Razor.Contains("PrTask.Client.Components", StringComparison.Ordinal), "Client imports must use Client Components namespace");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui imports must reference maui components and domain constants namespaces")]
    public void MauiImportsMustReferenceMauiComponentsAndDomainConstantsNamespaces()
    {
        var Razor = ReadSourceFile("PrTask.Maui", "_Imports.razor");
        Assert.IsTrue(Razor.Contains("PrTask.Maui.Components", StringComparison.Ordinal), "Maui imports must use Maui Components namespace");
        Assert.IsTrue(Razor.Contains("PrTask.Domain.Constants", StringComparison.Ordinal), "Maui imports must use Domain Constants namespace");
        Assert.IsTrue(Razor.Contains("Microsoft.AspNetCore.Components", StringComparison.Ordinal), "Maui imports must use Components namespace");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client delegate pages must use shared ui components for settings download and pr detail")]
    public void ClientDelegatePagesMustUseSharedUiComponentsForSettingsDownloadAndPrDetail()
    {
        var Settings = ReadSourceFile("PrTask.Client", "Pages", "ClientSettingsPage.razor");
        var Download = ReadSourceFile("PrTask.Client", "Pages", "ClientDownloadPage.razor");
        var PrDetail = ReadSourceFile("PrTask.Client", "Pages", "ClientPullRequestDetailPage.razor");
        Assert.IsTrue(Settings.Contains("PrTask.SharedUI.Pages.SettingsPage", StringComparison.Ordinal), "Client settings must delegate to SharedUI SettingsPage");
        Assert.IsTrue(Download.Contains("PrTask.SharedUI.Pages.DownloadPage", StringComparison.Ordinal), "Client download must delegate to SharedUI DownloadPage");
        Assert.IsTrue(PrDetail.Contains("PrTask.SharedUI.Pages.PullRequestDetailPage", StringComparison.Ordinal), "Client PR detail must delegate to SharedUI PullRequestDetailPage");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client home page must have hero section with browse tasks and how it works action buttons")]
    public void ClientHomePageMustHaveHeroSectionWithBrowseTasksAndHowItWorksActionButtons()
    {
        var Home = ReadSourceFile("PrTask.Client", "Pages", "ClientHomePage.razor");
        Assert.IsTrue(Home.Contains("hero", StringComparison.Ordinal), "Client home page must have hero section");
        Assert.IsTrue(Home.Contains("Browse Tasks", StringComparison.Ordinal), "Client home page must have Browse Tasks CTA");
        Assert.IsTrue(Home.Contains("How It Works", StringComparison.Ordinal), "Client home page must link to How It Works");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client leaderboard page must fetch entries via http client and format earned amounts")]
    public void ClientLeaderboardPageMustFetchEntriesViaHttpClientAndFormatEarnedAmounts()
    {
        var Leaderboard = ReadSourceFile("PrTask.Client", "Pages", "ClientLeaderboardPage.razor");
        Assert.IsTrue(Leaderboard.Contains("HttpClient", StringComparison.Ordinal), "Client leaderboard must inject HttpClient");
        Assert.IsTrue(Leaderboard.Contains("GetFromJsonAsync", StringComparison.Ordinal), "Client leaderboard must call GetFromJsonAsync for API data");
        Assert.IsTrue(Leaderboard.Contains("FormatEarnedAmount", StringComparison.Ordinal), "Client leaderboard must format earned amounts");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client dashboard page must check auth me endpoint and show login prompt for unauthenticated users")]
    public void ClientDashboardPageMustCheckAuthMeEndpointAndShowLoginPromptForUnauthenticatedUsers()
    {
        var Dashboard = ReadSourceFile("PrTask.Client", "Pages", "ClientDashboardPage.razor");
        Assert.IsTrue(Dashboard.Contains("ApiAuthMe", StringComparison.Ordinal), "Client dashboard must call auth/me endpoint");
        Assert.IsTrue(Dashboard.Contains("IsLoggedIn", StringComparison.Ordinal), "Client dashboard must track login state");
        Assert.IsTrue(Dashboard.Contains("sign in", StringComparison.Ordinal), "Client dashboard must prompt sign in for unauthenticated");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui wrapper pages must reference their matching shared ui page components for rendering")]
    public void MauiWrapperPagesMustReferenceTheirMatchingSharedUiPageComponentsForRendering()
    {
        var Home = ReadSourceFile("PrTask.Maui", "Pages", "MauiHomePage.razor");
        var Dashboard = ReadSourceFile("PrTask.Maui", "Pages", "MauiDashboardPage.razor");
        var Settings = ReadSourceFile("PrTask.Maui", "Pages", "MauiSettingsPage.razor");
        Assert.IsTrue(Home.Contains("PrTask.SharedUI.Pages.Home", StringComparison.Ordinal), "Maui home wrapper must reference SharedUI Home page");
        Assert.IsTrue(Dashboard.Contains("PrTask.SharedUI.Pages.DashboardPage", StringComparison.Ordinal), "Maui dashboard wrapper must reference SharedUI DashboardPage");
        Assert.IsTrue(Settings.Contains("PrTask.SharedUI.Pages.SettingsPage", StringComparison.Ordinal), "Maui settings wrapper must reference SharedUI SettingsPage");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui wrapper pages must reference task list task detail and pull request detail shared pages")]
    public void MauiWrapperPagesMustReferenceTaskListTaskDetailAndPullRequestDetailSharedPages()
    {
        var TaskList = ReadSourceFile("PrTask.Maui", "Pages", "MauiTaskListPage.razor");
        var TaskDetail = ReadSourceFile("PrTask.Maui", "Pages", "MauiTaskDetailPage.razor");
        var PrDetail = ReadSourceFile("PrTask.Maui", "Pages", "MauiPullRequestDetailPage.razor");
        Assert.IsTrue(TaskList.Contains("PrTask.SharedUI.Pages.TaskList", StringComparison.Ordinal), "Maui task list wrapper must reference SharedUI TaskList");
        Assert.IsTrue(TaskDetail.Contains("PrTask.SharedUI.Pages.TaskDetailPage", StringComparison.Ordinal), "Maui task detail wrapper must reference SharedUI TaskDetailPage");
        Assert.IsTrue(PrDetail.Contains("PrTask.SharedUI.Pages.PullRequestDetailPage", StringComparison.Ordinal), "Maui PR detail wrapper must reference SharedUI PullRequestDetailPage");
    }
}
