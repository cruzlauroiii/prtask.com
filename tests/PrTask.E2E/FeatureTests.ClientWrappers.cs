namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client project must have wrapper pages for all shared ui pages with correct route directives")]
    public void ClientProjectMustHaveWrapperPagesForAllSharedUiPagesWithCorrectRouteDirectives()
    {
        Assert.IsTrue(SourceFileExists("PrTask.Client", "Pages", "ClientHomePage.razor"), "Client must have home page wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Client", "Pages", "ClientDashboardPage.razor"), "Client must have dashboard page wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Client", "Pages", "ClientLoginPage.razor"), "Client must have login page wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Client", "Pages", "ClientTaskListPage.razor"), "Client must have task list page wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Client", "Pages", "ClientLeaderboardPage.razor"), "Client must have leaderboard page wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Client", "Pages", "ClientPricingPage.razor"), "Client must have pricing page wrapper");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client project must have wrapper pages for about how it works and download shared pages")]
    public void ClientProjectMustHaveWrapperPagesForAboutHowItWorksAndDownloadSharedPages()
    {
        Assert.IsTrue(SourceFileExists("PrTask.Client", "Pages", "ClientAboutPage.razor"), "Client must have about page wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Client", "Pages", "ClientHowItWorksPage.razor"), "Client must have how it works page wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Client", "Pages", "ClientDownloadPage.razor"), "Client must have download page wrapper");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client project must have wrapper pages for settings pr detail and deployment preview")]
    public void ClientProjectMustHaveWrapperPagesForSettingsPrDetailAndDeploymentPreview()
    {
        Assert.IsTrue(SourceFileExists("PrTask.Client", "Pages", "ClientSettingsPage.razor"), "Client must have settings page wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Client", "Pages", "ClientPullRequestDetailPage.razor"), "Client must have PR detail page wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Client", "Pages", "ClientDeploymentPreviewPage.razor"), "Client must have deployment preview page wrapper");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client project must have wrapper pages for all eight legal pages with matching routes")]
    public void ClientProjectMustHaveWrapperPagesForAllEightLegalPagesWithMatchingRoutes()
    {
        Assert.IsTrue(SourceFileExists("PrTask.Client", "Pages", "Legal", "ClientTermsPage.razor"), "Client must have terms legal wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Client", "Pages", "Legal", "ClientPrivacyPage.razor"), "Client must have privacy legal wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Client", "Pages", "Legal", "ClientRefundPage.razor"), "Client must have refund legal wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Client", "Pages", "Legal", "ClientCookiePolicyPage.razor"), "Client must have cookie policy legal wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Client", "Pages", "Legal", "ClientAcceptableUsePage.razor"), "Client must have acceptable use legal wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Client", "Pages", "Legal", "ClientLicensesPage.razor"), "Client must have licenses legal wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Client", "Pages", "Legal", "ClientAccessibilityPage.razor"), "Client must have accessibility legal wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Client", "Pages", "Legal", "ClientDmcaPage.razor"), "Client must have DMCA legal wrapper");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Client repository page wrapper must exist in client pages directory referencing shared repository")]
    public void ClientRepositoryPageWrapperMustExistInClientPagesDirectoryReferencingSharedRepository()
    {
        Assert.IsTrue(
            SourceFileExists("PrTask.Client", "Pages", "Client", "ClientRepositoryPage.razor"),
            "Client must have repository page wrapper");
        var Razor = ReadSourceFile("PrTask.Client", "Pages", "Client", "ClientRepositoryPage.razor");
        Assert.IsTrue(Razor.Contains("RepositoryPage", StringComparison.Ordinal), "Client repository wrapper must reference SharedUI RepositoryPage");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui project must have wrapper pages for home dashboard leaderboard and profile shared pages")]
    public void MauiProjectMustHaveWrapperPagesForHomeDashboardLeaderboardAndProfileSharedPages()
    {
        Assert.IsTrue(SourceFileExists("PrTask.Maui", "Pages", "MauiHomePage.razor"), "Maui must have home page wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Maui", "Pages", "MauiDashboardPage.razor"), "Maui must have dashboard page wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Maui", "Pages", "MauiLeaderboardPage.razor"), "Maui must have leaderboard page wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Maui", "Pages", "MauiProfilePage.razor"), "Maui must have profile page wrapper");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui project must have wrapper pages for task list task detail and pr detail shared pages")]
    public void MauiProjectMustHaveWrapperPagesForTaskListTaskDetailAndPrDetailSharedPages()
    {
        Assert.IsTrue(SourceFileExists("PrTask.Maui", "Pages", "MauiTaskListPage.razor"), "Maui must have task list page wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Maui", "Pages", "MauiTaskDetailPage.razor"), "Maui must have task detail page wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Maui", "Pages", "MauiPullRequestDetailPage.razor"), "Maui must have PR detail page wrapper");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui project must have wrapper pages for settings login and deployment preview shared pages")]
    public void MauiProjectMustHaveWrapperPagesForSettingsLoginAndDeploymentPreviewSharedPages()
    {
        Assert.IsTrue(SourceFileExists("PrTask.Maui", "Pages", "MauiSettingsPage.razor"), "Maui must have settings page wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Maui", "Pages", "MauiLoginPage.razor"), "Maui must have login page wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Maui", "Pages", "MauiDeploymentPreviewPage.razor"), "Maui must have deployment preview page wrapper");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui project must have wrapper pages for all eight legal pages with matching routes")]
    public void MauiProjectMustHaveWrapperPagesForAllEightLegalPagesWithMatchingRoutes()
    {
        Assert.IsTrue(SourceFileExists("PrTask.Maui", "Pages", "Legal", "MauiTermsPage.razor"), "Maui must have terms legal wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Maui", "Pages", "Legal", "MauiPrivacyPage.razor"), "Maui must have privacy legal wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Maui", "Pages", "Legal", "MauiRefundPage.razor"), "Maui must have refund legal wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Maui", "Pages", "Legal", "MauiCookiePolicyPage.razor"), "Maui must have cookie policy legal wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Maui", "Pages", "Legal", "MauiAcceptableUsePage.razor"), "Maui must have acceptable use legal wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Maui", "Pages", "Legal", "MauiLicensesPage.razor"), "Maui must have licenses legal wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Maui", "Pages", "Legal", "MauiAccessibilityPage.razor"), "Maui must have accessibility legal wrapper");
        Assert.IsTrue(SourceFileExists("PrTask.Maui", "Pages", "Legal", "MauiDmcaPage.razor"), "Maui must have DMCA legal wrapper");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui project must have create task page wrapper in client subdirectory for task posting")]
    public void MauiProjectMustHaveCreateTaskPageWrapperInClientSubdirectoryForTaskPosting()
    {
        Assert.IsTrue(
            SourceFileExists("PrTask.Maui", "Pages", "Client", "MauiCreateTaskPage.razor"),
            "Maui must have create task page wrapper in Client subdirectory");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Maui project must have repository page wrapper in client subdirectory for source management")]
    public void MauiProjectMustHaveRepositoryPageWrapperInClientSubdirectoryForSourceManagement()
    {
        Assert.IsTrue(
            SourceFileExists("PrTask.Maui", "Pages", "Client", "MauiRepositoryPage.razor"),
            "Maui must have repository page wrapper in Client subdirectory");
    }
}
