using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsConstants has option value constants for all settings")]
    public void SettingsConstantsOptionValues()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "SettingsConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.NotificationImportant)), "Has NotificationImportant");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.NotificationNone)), "Has NotificationNone");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.PayoutPaypal)), "Has PayoutPaypal");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.TwoFactorAuthenticator)), "Has TwoFactorAuthenticator");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.TwoFactorEmail)), "Has TwoFactorEmail");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.VisibilityPrivate)), "Has VisibilityPrivate");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.DefaultDisabled)), "Has DefaultDisabled");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsConstants has option label constants")]
    public void SettingsConstantsOptionLabels()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "SettingsConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.NotificationAllLabel)), "Has NotificationAllLabel");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.PayoutBankLabel)), "Has PayoutBankLabel");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.PaymentCardLabel)), "Has PaymentCardLabel");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.TwoFactorDisabledLabel)), "Has TwoFactorDisabledLabel");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.VisibilityPublicProfileLabel)), "Has VisibilityPublicProfileLabel");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.EnabledLabel)), "Has EnabledLabel");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.DisabledLabel)), "Has DisabledLabel");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsPage uses SettingsConstants for select option values")]
    public void SettingsPageUsesSettingsConstantsForOptions()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Source.Contains("SettingsConstants.DefaultNotificationPreference"), "Uses notification default");
        Assert.IsTrue(Source.Contains("SettingsConstants.NotificationImportant"), "Uses NotificationImportant");
        Assert.IsTrue(Source.Contains("SettingsConstants.DefaultPayoutMethod"), "Uses payout default");
        Assert.IsTrue(Source.Contains("SettingsConstants.PayoutPaypal"), "Uses PayoutPaypal");
        Assert.IsTrue(Source.Contains("SettingsConstants.DefaultPaymentMethod"), "Uses payment default");
        Assert.IsTrue(Source.Contains("SettingsConstants.DefaultTwoFactor"), "Uses two-factor default");
        Assert.IsTrue(Source.Contains("SettingsConstants.TwoFactorAuthenticator"), "Uses TwoFactorAuthenticator");
        Assert.IsFalse(Source.Contains("value=\"all\""), "No hardcoded all value");
        Assert.IsFalse(Source.Contains("value=\"bank\""), "No hardcoded bank value");
        Assert.IsFalse(Source.Contains("value=\"card\""), "No hardcoded card value");
        Assert.IsFalse(Source.Contains("value=\"disabled\""), "No hardcoded disabled value");
        Assert.IsFalse(Source.Contains("value=\"public\""), "No hardcoded public value");
        Assert.IsFalse(Source.Contains("value=\"private\""), "No hardcoded private value");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsConstants has empty state text constants")]
    public void SettingsConstantsEmptyStateTexts()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "SettingsConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.NoWalletLinked)), "Has NoWalletLinked");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.NotConfigured)), "Has NotConfigured");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.NoActiveSubscriptions)), "Has NoActiveSubscriptions");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.NoInvoiceHistory)), "Has NoInvoiceHistory");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsPage uses SettingsConstants for empty state messages")]
    public void SettingsPageUsesSettingsConstantsForEmptyStates()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Source.Contains("SettingsConstants.NoWalletLinked"), "Uses NoWalletLinked");
        Assert.IsTrue(Source.Contains("SettingsConstants.NotConfigured"), "Uses NotConfigured");
        Assert.IsTrue(Source.Contains("SettingsConstants.NoActiveSubscriptions"), "Uses NoActiveSubscriptions");
        Assert.IsTrue(Source.Contains("SettingsConstants.NoInvoiceHistory"), "Uses NoInvoiceHistory");
    }
}
