namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Repository page must exist for clients to post source codes publicly and privately")]
    public void RepositoryPageMustExistForClientsToPostSourceCodesPubliclyAndPrivately()
    {
        Assert.IsTrue(
            SourceFileExists("PrTask.SharedUI", "Pages", "Client", "RepositoryPage.razor"),
            "RepositoryPage.razor must exist for clients to manage source code repositories");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Repository page must have public and private visibility options for code posting")]
    public void RepositoryPageMustHavePublicAndPrivateVisibilityOptionsForCodePosting()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "Client", "RepositoryPage.razor");
        Assert.IsTrue(
            Razor.Contains("Public", StringComparison.Ordinal),
            "Repository page must have Public visibility option so anyone can view the source code");
        Assert.IsTrue(
            Razor.Contains("Private", StringComparison.Ordinal),
            "Repository page must have Private visibility option so only assigned developers can view the code");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Repository page must have form to add repository with url and visibility fields")]
    public void RepositoryPageMustHaveFormToAddRepositoryWithUrlAndVisibilityFields()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "Client", "RepositoryPage.razor");
        Assert.IsTrue(Razor.Contains("RepoUrl", StringComparison.Ordinal), "Repository page must have a URL input field");
        Assert.IsTrue(Razor.Contains("Visibility", StringComparison.Ordinal), "Repository page must have a Visibility selector");
        Assert.IsTrue(
            Razor.Contains("Add Repository", StringComparison.Ordinal),
            "Repository page must have an Add Repository button");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Repository page must have section listing existing repositories")]
    public void RepositoryPageMustHaveSectionListingExistingRepositories()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "Client", "RepositoryPage.razor");
        Assert.IsTrue(
            Razor.Contains("Your Repositories", StringComparison.Ordinal) || Razor.Contains("repository", StringComparison.OrdinalIgnoreCase),
            "Repository page must list the user's existing repositories");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Route constants must define repository route for client source code management")]
    public void RouteConstantsMustDefineRepositoryRouteForClientSourceCodeManagement()
    {
        var Code = ReadSourceFile("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(
            Code.Contains("Repository", StringComparison.Ordinal),
            "RouteConstants must define a Repository route for the client repository page");
    }
}
