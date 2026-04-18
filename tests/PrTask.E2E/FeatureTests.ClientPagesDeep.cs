namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client dashboard must check api auth me endpoint and deserialize auth user sealed class")]
    public void ClientDashboardMustCheckApiAuthMeEndpointAndDeserializeAuthUserSealedClass()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientDashboardPage.razor");
        Assert.IsTrue(Code.Contains("RouteConstants.ApiAuthMe", StringComparison.Ordinal), "Client dashboard must call ApiAuthMe endpoint");
        Assert.IsTrue(Code.Contains("ReadFromJsonAsync<AuthUser>()", StringComparison.Ordinal), "Client dashboard must deserialize AuthUser");
        Assert.IsTrue(Code.Contains("sealed class AuthUser", StringComparison.Ordinal), "AuthUser must be a sealed class");
        Assert.IsTrue(Code.Contains("IsSuccessStatusCode", StringComparison.Ordinal), "Must check response success status code");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client dashboard must show welcome message with username and sign in prompt when not logged in")]
    public void ClientDashboardMustShowWelcomeMessageWithUsernameAndSignInPromptWhenNotLoggedIn()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientDashboardPage.razor");
        Assert.IsTrue(Code.Contains("Welcome, @Username", StringComparison.Ordinal), "Client dashboard must show Welcome with username");
        Assert.IsTrue(Code.Contains("RouteConstants.Login", StringComparison.Ordinal), "Client dashboard must link to login when not authenticated");
        Assert.IsTrue(Code.Contains("RouteConstants.Tasks", StringComparison.Ordinal), "Client dashboard must link to tasks page");
        Assert.IsTrue(Code.Contains("IsLoggedIn", StringComparison.Ordinal), "Client dashboard must track login state");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client dashboard must handle http request exception by setting logged in to false")]
    public void ClientDashboardMustHandleHttpRequestExceptionBySettingLoggedInToFalse()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientDashboardPage.razor");
        Assert.IsTrue(Code.Contains("catch (HttpRequestException)", StringComparison.Ordinal), "Client dashboard must catch HttpRequestException");
        Assert.IsTrue(Code.Contains("IsLoggedIn = false", StringComparison.Ordinal), "Must set IsLoggedIn to false on HTTP error");
        Assert.IsTrue(Code.Contains("User?.Username ?? \"Developer\"", StringComparison.Ordinal), "Must fallback to Developer if username is null");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client task list must inject http client and fetch tasks via get from json method")]
    public void ClientTaskListMustInjectHttpClientAndFetchTasksViaGetFromJsonMethod()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientTaskListPage.razor");
        Assert.IsTrue(Code.Contains("@inject HttpClient HttpClient", StringComparison.Ordinal), "Client task list must inject HttpClient");
        Assert.IsTrue(Code.Contains("GetFromJsonAsync<TaskEntity[]>(RouteConstants.ApiTasks)", StringComparison.Ordinal), "Must fetch tasks from ApiTasks route");
        Assert.IsTrue(Code.Contains("catch (HttpRequestException)", StringComparison.Ordinal), "Must catch HttpRequestException");
        Assert.IsTrue(Code.Contains("OpenTasks = []", StringComparison.Ordinal), "Must set empty array on HTTP error");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client task list must use task entity array type and format bounty with cents to dollars")]
    public void ClientTaskListMustUseTaskEntityArrayTypeAndFormatBountyWithCentsToDollars()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientTaskListPage.razor");
        Assert.IsTrue(Code.Contains("TaskEntity[]?", StringComparison.Ordinal), "Client task list must use nullable TaskEntity array");
        Assert.IsTrue(Code.Contains("FormatBountyAmount", StringComparison.Ordinal), "Must have FormatBountyAmount helper");
        Assert.IsTrue(Code.Contains("TruncateDescription", StringComparison.Ordinal), "Must have TruncateDescription helper");
        Assert.IsTrue(Code.Contains("@using System.Net.Http.Json", StringComparison.Ordinal), "Must import System.Net.Http.Json");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client leaderboard must inject http client and fetch entries via get from json method")]
    public void ClientLeaderboardMustInjectHttpClientAndFetchEntriesViaGetFromJsonMethod()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientLeaderboardPage.razor");
        Assert.IsTrue(Code.Contains("@inject HttpClient HttpClient", StringComparison.Ordinal), "Client leaderboard must inject HttpClient");
        Assert.IsTrue(Code.Contains("GetFromJsonAsync<LeaderboardEntry[]>(RouteConstants.ApiLeaderboard)", StringComparison.Ordinal), "Must fetch leaderboard from ApiLeaderboard route");
        Assert.IsTrue(Code.Contains("LeaderboardEntry[]?", StringComparison.Ordinal), "Must use nullable LeaderboardEntry array");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client leaderboard must display leaderboard rows with rank hash prefix and level format")]
    public void ClientLeaderboardMustDisplayLeaderboardRowsWithRankHashPrefixAndLevelFormat()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientLeaderboardPage.razor");
        Assert.IsTrue(Code.Contains("#@Entry.Rank", StringComparison.Ordinal), "Client leaderboard must show rank with # prefix");
        Assert.IsTrue(Code.Contains("Lv.@Entry.Level", StringComparison.Ordinal), "Client leaderboard must show level format");
        Assert.IsTrue(Code.Contains("@Entry.Xp XP", StringComparison.Ordinal), "Client leaderboard must show XP with suffix");
        Assert.IsTrue(Code.Contains("leaderboard-row", StringComparison.Ordinal), "Client leaderboard must use leaderboard-row class");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client about page must use route constants for all eight legal page links in legal section")]
    public void ClientAboutPageMustUseRouteConstantsForAllEightLegalPageLinksInLegalSection()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientAboutPage.razor");
        Assert.IsTrue(Code.Contains("RouteConstants.Terms", StringComparison.Ordinal), "Client about must use RouteConstants.Terms");
        Assert.IsTrue(Code.Contains("RouteConstants.Privacy", StringComparison.Ordinal), "Client about must use RouteConstants.Privacy");
        Assert.IsTrue(Code.Contains("RouteConstants.Licenses", StringComparison.Ordinal), "Client about must use RouteConstants.Licenses");
        Assert.IsTrue(Code.Contains("RouteConstants.Dmca", StringComparison.Ordinal), "Client about must use RouteConstants.Dmca");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client about page must have five about sections matching shared ui content structure")]
    public void ClientAboutPageMustHaveFiveAboutSectionsMatchingSharedUiContentStructure()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientAboutPage.razor");
        Assert.IsTrue(Code.Contains("What We Do", StringComparison.Ordinal), "Client about must have What We Do section");
        Assert.IsTrue(Code.Contains("Game-Like Experience", StringComparison.Ordinal), "Client about must have Game-Like Experience section");
        Assert.IsTrue(Code.Contains("Secure Payments", StringComparison.Ordinal), "Client about must have Secure Payments section");
        Assert.IsTrue(Code.Contains("support@prtask.com", StringComparison.Ordinal), "Client about must have contact email");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client how it works page must have five numbered steps with step number class spans")]
    public void ClientHowItWorksPageMustHaveFiveNumberedStepsWithStepNumberClassSpans()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientHowItWorksPage.razor");
        Assert.IsTrue(Code.Contains("step-number", StringComparison.Ordinal), "Client how it works must use step-number class");
        Assert.IsTrue(Code.Contains("Browse Open Tasks", StringComparison.Ordinal), "Must have Browse Open Tasks step");
        Assert.IsTrue(Code.Contains("Submit a Pull Request", StringComparison.Ordinal), "Must have Submit a Pull Request step");
        Assert.IsTrue(Code.Contains("Complexity Scoring", StringComparison.Ordinal), "Must have Complexity Scoring step");
        Assert.IsTrue(Code.Contains("Get Paid and Level Up", StringComparison.Ordinal), "Must have Get Paid and Level Up step");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client pricing page must match shared ui with featured client card and three faq items")]
    public void ClientPricingPageMustMatchSharedUiWithFeaturedClientCardAndThreeFaqItems()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientPricingPage.razor");
        Assert.IsTrue(Code.Contains("pricing-card featured", StringComparison.Ordinal), "Client pricing must have featured client card");
        Assert.IsTrue(Code.Contains("faq-item", StringComparison.Ordinal), "Client pricing must have FAQ items");
        Assert.IsTrue(Code.Contains("How are payments processed?", StringComparison.Ordinal), "Must have payment processing FAQ");
        Assert.IsTrue(Code.Contains("When do I get paid?", StringComparison.Ordinal), "Must have payment timing FAQ");
        Assert.IsTrue(Code.Contains("What currencies are supported?", StringComparison.Ordinal), "Must have currencies FAQ");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client login page must use anchor tags with route constants href for sso button links")]
    public void ClientLoginPageMustUseAnchorTagsWithRouteConstantsHrefForSsoButtonLinks()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientLoginPage.razor");
        Assert.IsTrue(Code.Contains("href=\"@RouteConstants.ApiAuthGoogle\"", StringComparison.Ordinal), "Client login Google must use href with RouteConstants");
        Assert.IsTrue(Code.Contains("href=\"@RouteConstants.ApiAuthGitHub\"", StringComparison.Ordinal), "Client login GitHub must use href with RouteConstants");
        Assert.IsTrue(Code.Contains("Sign in with Microsoft", StringComparison.Ordinal), "Client login must have Microsoft button text");
        Assert.IsTrue(Code.Contains("Sign in with Okta", StringComparison.Ordinal), "Client login must have Okta button text");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client home page must have hero section without stats section matching static layout")]
    public void ClientHomePageMustHaveHeroSectionWithoutStatsSectionMatchingStaticLayout()
    {
        var Code = ReadSourceFile("PrTask.Client", "Pages", "ClientHomePage.razor");
        Assert.IsTrue(Code.Contains("Earn Money with Pull Requests", StringComparison.Ordinal), "Client home must have earn money heading");
        Assert.IsTrue(Code.Contains("hero-subtitle", StringComparison.Ordinal), "Client home must have hero subtitle");
        Assert.IsTrue(Code.Contains("feature-card", StringComparison.Ordinal), "Client home must have feature cards");
        Assert.IsTrue(Code.Contains("href=\"/tasks\"", StringComparison.Ordinal), "Client home must link to tasks page");
    }
}
