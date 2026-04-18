using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsPage code-behind has async methods with Inject attributes")]
    public void SettingsPageCodeBehindAsyncMethods()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SettingsPage.razor.cs");
        Assert.IsTrue(Source.Contains("partial class"),
            "SettingsPage.razor.cs must be a partial class");
        Assert.IsTrue(Source.Contains("LoadProfileAsync"),
            "SettingsPage must have LoadProfileAsync method");
        Assert.IsTrue(Source.Contains("SaveSettingsAsync"),
            "SettingsPage must have SaveSettingsAsync method");
        Assert.IsTrue(Source.Contains("[Inject]"),
            "SettingsPage must use [Inject] attribute for DI");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants)),
            "SettingsPage code-behind must reference SettingsConstants");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsConstants has user-facing message constants for PT005")]
    public void SettingsConstantsHasMessageConstants()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "SettingsConstants.cs");
        Assert.IsTrue(Source.Contains("UserNotFound"),
            "SettingsConstants must have UserNotFound message");
        Assert.IsTrue(Source.Contains("LoadProfileFirst"),
            "SettingsConstants must have LoadProfileFirst message");
        Assert.IsTrue(Source.Contains("SettingsSaved"),
            "SettingsConstants must have SettingsSaved message");
        Assert.IsTrue(Source.Contains("KycSubmitted"),
            "SettingsConstants must have KycSubmitted message");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsPage has subscription and wallet link sections")]
    public void SettingsPageSubscriptionAndWalletSections()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants)),
            "SettingsPage must reference SettingsConstants");
        Assert.IsTrue(
            Source.Contains("SubscriptionSettingsHeading") || Source.Contains("Subscription"),
            "SettingsPage must have subscription settings section");
        Assert.IsTrue(
            Source.Contains("WalletLinkHeading") || Source.Contains("Wallet"),
            "SettingsPage must have wallet link section");
    }
}
