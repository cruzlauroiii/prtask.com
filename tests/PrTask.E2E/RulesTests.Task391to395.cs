using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsPage shows real connected account status from LinkedProviders")]
    public void SettingsPageRealConnectedAccounts()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SettingsPage.razor.cs");
        Assert.IsTrue(Source.Contains("LinkedProviders"), "Reads LinkedProviders from user");
        Assert.IsTrue(Source.Contains("IsProviderLinked"), "Has IsProviderLinked method");
        Assert.IsTrue(Source.Contains("GetProviderStatus"), "Has GetProviderStatus method");
        Assert.IsTrue(Source.Contains(nameof(SsoConstants.StatusConnected)), "Uses StatusConnected");
        Assert.IsTrue(Source.Contains(nameof(SsoConstants.StatusNotConnected)), "Uses StatusNotConnected");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsPage has computed properties for each SSO provider status")]
    public void SettingsPageProviderStatusProperties()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SettingsPage.razor.cs");
        Assert.IsTrue(Source.Contains("GoogleStatus"), "Has GoogleStatus");
        Assert.IsTrue(Source.Contains("GitHubStatus"), "Has GitHubStatus");
        Assert.IsTrue(Source.Contains("AzureStatus"), "Has AzureStatus");
        Assert.IsTrue(Source.Contains("OktaStatus"), "Has OktaStatus");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SsoConstants has provider names and status labels")]
    public void SsoConstantsComplete()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "SsoConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(SsoConstants.ProviderGitHub)), "Has ProviderGitHub");
        Assert.IsTrue(Source.Contains(nameof(SsoConstants.ProviderGoogle)), "Has ProviderGoogle");
        Assert.IsTrue(Source.Contains(nameof(SsoConstants.ProviderAzure)), "Has ProviderAzure");
        Assert.IsTrue(Source.Contains(nameof(SsoConstants.ProviderOkta)), "Has ProviderOkta");
        Assert.IsTrue(Source.Contains(nameof(SsoConstants.StatusConnected)), "Has StatusConnected");
        Assert.IsTrue(Source.Contains(nameof(SsoConstants.StatusNotConnected)), "Has StatusNotConnected");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("UserEntity has LinkedProviders field")]
    public void UserEntityHasLinkedProviders()
    {
        var Source = ReadSource("PrTask.Domain", "Models", "UserEntity.cs");
        Assert.IsTrue(Source.Contains("LinkedProviders"), "Has LinkedProviders property");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("UserService tracks linked providers on SSO login")]
    public void UserServiceTracksLinkedProviders()
    {
        var Source = ReadSource("PrTask.Infrastructure", "Services", "UserService.cs");
        Assert.IsTrue(Source.Contains("AddLinkedProvider"), "Has AddLinkedProvider method");
        Assert.IsTrue(Source.Contains("LinkedProviders"), "Updates LinkedProviders");
        Assert.IsTrue(Source.Contains(nameof(SsoConstants.ProviderGitHub)), "Tracks GitHub provider");
    }
}
