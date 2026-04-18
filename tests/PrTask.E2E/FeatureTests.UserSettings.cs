namespace PrTask.E2E;
public partial class FeatureTests
{
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Settings page must have profile section with display name avatar and bio fields")]
    public void SettingsPageMustHaveProfileSectionWithDisplayNameAvatarAndBioFields()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Razor.Contains("DisplayName", StringComparison.Ordinal), "Settings must have Display Name field");
        Assert.IsTrue(Razor.Contains("AvatarUrl", StringComparison.Ordinal), "Settings must have Avatar URL field");
        Assert.IsTrue(Razor.Contains("Bio", StringComparison.Ordinal), "Settings must have Bio field");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Settings page must have withdrawal section with multiple payout methods")]
    public void SettingsPageMustHaveWithdrawalSectionWithMultiplePayoutMethods()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Razor.Contains("Withdrawal", StringComparison.OrdinalIgnoreCase), "Settings must have Withdrawal section");
        Assert.IsTrue(Razor.Contains("Bank", StringComparison.Ordinal), "Settings must offer Bank Transfer payout");
        Assert.IsTrue(Razor.Contains("PayPal", StringComparison.Ordinal), "Settings must offer PayPal payout");
        Assert.IsTrue(Razor.Contains("Crypto", StringComparison.OrdinalIgnoreCase), "Settings must offer Cryptocurrency payout");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Settings page must have deposit and payment methods section for client bounty funding")]
    public void SettingsPageMustHaveDepositAndPaymentMethodsSectionForClientBountyFunding()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(
            Razor.Contains("Deposit", StringComparison.OrdinalIgnoreCase) || Razor.Contains("Payment Method", StringComparison.OrdinalIgnoreCase),
            "Settings must have Deposit or Payment Methods section for client funding");
        Assert.IsTrue(
            Razor.Contains("Credit", StringComparison.OrdinalIgnoreCase) || Razor.Contains("Card", StringComparison.OrdinalIgnoreCase),
            "Settings must offer credit or debit card payment option");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Settings page must have notification preferences section with email options")]
    public void SettingsPageMustHaveNotificationPreferencesSection()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Razor.Contains("Notification", StringComparison.Ordinal), "Settings must have Notification Preferences section");
        Assert.IsTrue(Razor.Contains("Email", StringComparison.Ordinal), "Settings must have email notification option");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Settings page must have timezone selection in account section")]
    public void SettingsPageMustHaveTimezoneSelectionInAccountSection()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Razor.Contains("Timezone", StringComparison.Ordinal), "Settings must have Timezone selector");
        Assert.IsTrue(Razor.Contains("UTC", StringComparison.Ordinal), "Settings must include UTC timezone option");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Settings page must have security section with two factor authentication option")]
    public void SettingsPageMustHaveSecuritySectionWithTwoFactorAuthenticationOption()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(
            Razor.Contains("Security", StringComparison.Ordinal) || Razor.Contains("2FA", StringComparison.Ordinal)
            || Razor.Contains("Two-Factor", StringComparison.OrdinalIgnoreCase),
            "Settings must have a Security section with two-factor authentication option per industry standard (Upwork, Fiverr, Freelancer.com)");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Settings page must have connected accounts section showing linked sso providers")]
    public void SettingsPageMustHaveConnectedAccountsSectionShowingLinkedSsoProviders()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(
            Razor.Contains("Connected", StringComparison.OrdinalIgnoreCase) || Razor.Contains("Linked Account", StringComparison.OrdinalIgnoreCase),
            "Settings must have a Connected Accounts section showing which SSO providers are linked (Google, GitHub, Microsoft, Okta)");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Settings page must have privacy or profile visibility settings")]
    public void SettingsPageMustHavePrivacyOrProfileVisibilitySettings()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(
            Razor.Contains("Privacy", StringComparison.OrdinalIgnoreCase) || Razor.Contains("Visibility", StringComparison.OrdinalIgnoreCase),
            "Settings must have Privacy or Profile Visibility settings for controlling what others can see");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Settings page must have save button to persist changes")]
    public void SettingsPageMustHaveSaveButtonToPersistChanges()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Razor.Contains("Save", StringComparison.Ordinal), "Settings must have a Save button");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("Profile page must exist with user stats and earned amount display")]
    public void ProfilePageMustExistWithUserStatsAndEarnedAmountDisplay()
    {
        var Razor = ReadSourceFile("PrTask.SharedUI", "Pages", "ProfilePage.razor");
        Assert.IsTrue(Razor.Contains("Total Earned", StringComparison.Ordinal), "Profile page must show total earned amount");
        Assert.IsTrue(Razor.Contains("Leaderboard Rank", StringComparison.Ordinal), "Profile page must show leaderboard rank");
        Assert.IsTrue(Razor.Contains("Level", StringComparison.Ordinal), "Profile page must show user level");
        Assert.IsTrue(Razor.Contains("XP", StringComparison.Ordinal), "Profile page must show user XP");
    }
    [TestMethod, TestCategory("Feature")]
    [DisplayName("User service interface must exist with get by id for user page functionality")]
    public void UserServiceInterfaceMustExistWithGetByIdForUserPageFunctionality()
    {
        var Code = ReadSourceFile("PrTask.Application", "Services", "IUserService.cs");
        Assert.IsTrue(Code.Contains("GetByIdAsync", StringComparison.Ordinal), "IUserService must have GetByIdAsync for user page");
    }
}
