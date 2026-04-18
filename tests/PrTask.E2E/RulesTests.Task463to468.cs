using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsConstants has KYC UI text")]
    public void SettingsConstantsHasKycUiText()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "SettingsConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.KycDocumentTypeLabel)), "Has KycDocumentTypeLabel");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.KycPassportValue)), "Has KycPassportValue");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.KycNationalIdValue)), "Has KycNationalIdValue");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.KycDriversLicenseValue)), "Has KycDriversLicenseValue");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.KycSubmitButtonText)), "Has KycSubmitButtonText");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsConstants has timezone UI text")]
    public void SettingsConstantsHasTimezoneUiText()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "SettingsConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.TimezoneLabel)), "Has TimezoneLabel");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.TimezoneUtcValue)), "Has TimezoneUtcValue");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.TimezoneManilaValue)), "Has TimezoneManilaValue");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.TimezoneNewYorkValue)), "Has TimezoneNewYorkValue");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.TimezoneLondonValue)), "Has TimezoneLondonValue");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsConstants has section headings and labels")]
    public void SettingsConstantsHasSectionHeadings()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "SettingsConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.PageHeading)), "Has PageHeading");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.ProfileHeading)), "Has ProfileHeading");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.NotificationsHeading)), "Has NotificationsHeading");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.WithdrawalHeading)), "Has WithdrawalHeading");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.SecurityHeading)), "Has SecurityHeading");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.ConnectedAccountsHeading)), "Has ConnectedAccountsHeading");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.PrivacyHeading)), "Has PrivacyHeading");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.AccountHeading)), "Has AccountHeading");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsPage uses SettingsConstants for all UI text")]
    public void SettingsPageUsesAllSettingsConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Source.Contains("SettingsConstants.PageHeading"), "Uses PageHeading");
        Assert.IsTrue(Source.Contains("SettingsConstants.ProfileHeading"), "Uses ProfileHeading");
        Assert.IsTrue(Source.Contains("SettingsConstants.KycDocumentTypeLabel"), "Uses KycDocumentTypeLabel");
        Assert.IsTrue(Source.Contains("SettingsConstants.KycPassportValue"), "Uses KycPassportValue");
        Assert.IsTrue(Source.Contains("SettingsConstants.TimezoneUtcValue"), "Uses TimezoneUtcValue");
        Assert.IsTrue(Source.Contains("SettingsConstants.SaveSettingsButtonText"), "Uses SaveSettingsButtonText");
        Assert.IsFalse(Source.Contains("\"Settings\""), "No hardcoded heading");
        Assert.IsFalse(Source.Contains("\"passport\""), "No hardcoded passport value");
        Assert.IsFalse(Source.Contains("\"UTC\""), "No hardcoded UTC value");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RepositoryConstants has UI text")]
    public void RepositoryConstantsHasUiText()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "RepositoryConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(RepositoryConstants.PageHeading)), "Has PageHeading");
        Assert.IsTrue(Source.Contains(nameof(RepositoryConstants.AddHeading)), "Has AddHeading");
        Assert.IsTrue(Source.Contains(nameof(RepositoryConstants.RepoUrlLabel)), "Has RepoUrlLabel");
        Assert.IsTrue(Source.Contains(nameof(RepositoryConstants.YourReposHeading)), "Has YourReposHeading");
        Assert.IsTrue(Source.Contains(nameof(RepositoryConstants.LoadingText)), "Has LoadingText");
        Assert.IsTrue(Source.Contains(nameof(RepositoryConstants.EmptyStateText)), "Has EmptyStateText");
        Assert.IsTrue(Source.Contains(nameof(RepositoryConstants.HeaderName)), "Has HeaderName");
        Assert.IsTrue(Source.Contains(nameof(RepositoryConstants.DeleteButtonText)), "Has DeleteButtonText");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RepositoryPage uses RepositoryConstants for all UI text")]
    public void RepositoryPageUsesAllRepositoryConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Client", "RepositoryPage.razor");
        Assert.IsTrue(Source.Contains("RepositoryConstants.PageHeading"), "Uses PageHeading");
        Assert.IsTrue(Source.Contains("RepositoryConstants.AddHeading"), "Uses AddHeading");
        Assert.IsTrue(Source.Contains("RepositoryConstants.RepoUrlLabel"), "Uses RepoUrlLabel");
        Assert.IsTrue(Source.Contains("RepositoryConstants.YourReposHeading"), "Uses YourReposHeading");
        Assert.IsTrue(Source.Contains("RepositoryConstants.LoadingText"), "Uses LoadingText");
        Assert.IsTrue(Source.Contains("RepositoryConstants.EmptyStateText"), "Uses EmptyStateText");
        Assert.IsTrue(Source.Contains("RepositoryConstants.HeaderName"), "Uses HeaderName");
        Assert.IsTrue(Source.Contains("RepositoryConstants.DeleteButtonText"), "Uses DeleteButtonText");
        Assert.IsTrue(Source.Contains("RepositoryConstants.DateFormat"), "Uses DateFormat");
        Assert.IsFalse(Source.Contains("\"Loading repositories"), "No hardcoded loading text");
        Assert.IsFalse(Source.Contains("\"yyyy-MM-dd\""), "No hardcoded date format");
    }
}
