using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsPage all form fields are bound with @bind")]
    public void SettingsPageAllFieldsBound()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Source.Contains("@bind=\"NotificationPreference\""), "Notification preference bound");
        Assert.IsTrue(Source.Contains("@bind=\"NotificationEmail\""), "Notification email bound");
        Assert.IsTrue(Source.Contains("@bind=\"PayoutMethod\""), "Payout method bound");
        Assert.IsTrue(Source.Contains("@bind=\"PayoutDetails\""), "Payout details bound");
        Assert.IsTrue(Source.Contains("@bind=\"PaymentMethod\""), "Payment method bound");
        Assert.IsTrue(Source.Contains("@bind=\"TwoFactorMethod\""), "2FA method bound");
        Assert.IsTrue(Source.Contains("@bind=\"ProfileVisibility\""), "Profile visibility bound");
        Assert.IsTrue(Source.Contains("@bind=\"ActivityVisibility\""), "Activity visibility bound");
        Assert.IsTrue(Source.Contains("@bind=\"Timezone\""), "Timezone bound");
        Assert.IsTrue(Source.Contains("@bind=\"InvoiceSetting\""), "Invoice setting bound");
        Assert.IsTrue(Source.Contains("@bind=\"QrPaymentSetting\""), "QR payment setting bound");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsPage persists all settings via SaveSettingsAsync")]
    public void SettingsPagePersistsAllSettings()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SettingsPage.razor.cs");
        Assert.IsTrue(Source.Contains("CurrentUser.NotificationPreference"), "Saves notification preference");
        Assert.IsTrue(Source.Contains("CurrentUser.NotificationEmail"), "Saves notification email");
        Assert.IsTrue(Source.Contains("CurrentUser.PayoutMethod"), "Saves payout method");
        Assert.IsTrue(Source.Contains("CurrentUser.PayoutDetails"), "Saves payout details");
        Assert.IsTrue(Source.Contains("CurrentUser.PaymentMethod"), "Saves payment method");
        Assert.IsTrue(Source.Contains("CurrentUser.TwoFactorMethod"), "Saves 2FA method");
        Assert.IsTrue(Source.Contains("CurrentUser.ProfileVisibility"), "Saves profile visibility");
        Assert.IsTrue(Source.Contains("CurrentUser.ActivityVisibility"), "Saves activity visibility");
        Assert.IsTrue(Source.Contains("CurrentUser.Timezone"), "Saves timezone");
        Assert.IsTrue(Source.Contains("CurrentUser.InvoiceSetting"), "Saves invoice setting");
        Assert.IsTrue(Source.Contains("CurrentUser.QrPaymentSetting"), "Saves QR payment setting");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("EditTaskPage has WorkItemType, Deadline, and Visibility fields")]
    public void EditTaskPageHasAllFields()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "Client", "EditTaskPage.razor");
        Assert.IsTrue(Source.Contains("WorkItemType"), "Has WorkItemType selector");
        Assert.IsTrue(Source.Contains("DeadlineInput"), "Has Deadline input");
        Assert.IsTrue(Source.Contains("SelectedVisibility"), "Has Visibility selector");
        Assert.IsTrue(Source.Contains("CurrentTask.Deadline = DeadlineInput"), "Persists deadline on save");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("UserEntity has all settings properties")]
    public void UserEntityHasSettingsProperties()
    {
        var Source = ReadSource("PrTask.Domain", "Models", "UserEntity.cs");
        Assert.IsTrue(Source.Contains("NotificationPreference"), "Has NotificationPreference");
        Assert.IsTrue(Source.Contains("NotificationEmail"), "Has NotificationEmail");
        Assert.IsTrue(Source.Contains("PayoutMethod"), "Has PayoutMethod");
        Assert.IsTrue(Source.Contains("PayoutDetails"), "Has PayoutDetails");
        Assert.IsTrue(Source.Contains("PaymentMethod"), "Has PaymentMethod");
        Assert.IsTrue(Source.Contains("TwoFactorMethod"), "Has TwoFactorMethod");
        Assert.IsTrue(Source.Contains("ProfileVisibility"), "Has ProfileVisibility");
        Assert.IsTrue(Source.Contains("ActivityVisibility"), "Has ActivityVisibility");
        Assert.IsTrue(Source.Contains("Timezone"), "Has Timezone");
        Assert.IsTrue(Source.Contains("InvoiceSetting"), "Has InvoiceSetting");
        Assert.IsTrue(Source.Contains("QrPaymentSetting"), "Has QrPaymentSetting");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsConstants has default value constants")]
    public void SettingsConstantsHasDefaults()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "SettingsConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.DefaultNotificationPreference)), "Has DefaultNotificationPreference");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.DefaultPayoutMethod)), "Has DefaultPayoutMethod");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.DefaultPaymentMethod)), "Has DefaultPaymentMethod");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.DefaultTwoFactor)), "Has DefaultTwoFactor");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.DefaultVisibilityPublic)), "Has DefaultVisibilityPublic");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.DefaultTimezone)), "Has DefaultTimezone");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.DefaultEnabled)), "Has DefaultEnabled");
    }
}
