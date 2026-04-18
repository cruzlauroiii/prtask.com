using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsConstants has Subscription section text")]
    public void SettingsConstantsHasSubscriptionSectionText()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "SettingsConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.SubscriptionHeading)), "Has SubscriptionHeading");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.SubscriptionDescription)), "Has SubscriptionDescription");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.SubscriptionActiveLabel)), "Has SubscriptionActiveLabel");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.SubscriptionHeaderDescription)), "Has SubscriptionHeaderDescription");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.SubscriptionHeaderAmount)), "Has SubscriptionHeaderAmount");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.SubscriptionHeaderInterval)), "Has SubscriptionHeaderInterval");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.SubscriptionHeaderStatus)), "Has SubscriptionHeaderStatus");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.SubscriptionIntervalFormat)), "Has SubscriptionIntervalFormat");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsConstants has Wallet, PaymentHistory, Disbursement, Invoice, QR section text")]
    public void SettingsConstantsHasRemainingSectionText()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "SettingsConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.WalletHeading)), "Has WalletHeading");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.WalletDescription)), "Has WalletDescription");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.WalletLinkedLabel)), "Has WalletLinkedLabel");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.PaymentHistoryHeading)), "Has PaymentHistoryHeading");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.PaymentHistoryDescription)), "Has PaymentHistoryDescription");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.PaymentHistoryDateFormat)), "Has PaymentHistoryDateFormat");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.DisbursementHeading)), "Has DisbursementHeading");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.DisbursementMethodLabel)), "Has DisbursementMethodLabel");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.InvoiceHeading)), "Has InvoiceHeading");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.InvoiceAutoGenerateLabel)), "Has InvoiceAutoGenerateLabel");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.QrPaymentHeading)), "Has QrPaymentHeading");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.QrPaymentLabel)), "Has QrPaymentLabel");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsConstants has KYC heading and description")]
    public void SettingsConstantsHasKycHeadingAndDescription()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "SettingsConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.KycHeading)), "Has KycHeading");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.KycDescription)), "Has KycDescription");
        Assert.IsTrue(Source.Contains(nameof(SettingsConstants.KycVerificationStatusLabel)), "Has KycVerificationStatusLabel");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsPage uses SettingsConstants for all remaining sections")]
    public void SettingsPageUsesAllRemainingConstants()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Source.Contains("SettingsConstants.SubscriptionHeading"), "Uses SubscriptionHeading");
        Assert.IsTrue(Source.Contains("SettingsConstants.WalletHeading"), "Uses WalletHeading");
        Assert.IsTrue(Source.Contains("SettingsConstants.PaymentHistoryHeading"), "Uses PaymentHistoryHeading");
        Assert.IsTrue(Source.Contains("SettingsConstants.PaymentHistoryDateFormat"), "Uses PaymentHistoryDateFormat");
        Assert.IsTrue(Source.Contains("SettingsConstants.DisbursementHeading"), "Uses DisbursementHeading");
        Assert.IsTrue(Source.Contains("SettingsConstants.InvoiceHeading"), "Uses InvoiceHeading");
        Assert.IsTrue(Source.Contains("SettingsConstants.QrPaymentHeading"), "Uses QrPaymentHeading");
        Assert.IsTrue(Source.Contains("SettingsConstants.KycHeading"), "Uses KycHeading");
        Assert.IsTrue(Source.Contains("SettingsConstants.KycVerificationStatusLabel"), "Uses KycVerificationStatusLabel");
        Assert.IsTrue(Source.Contains("FormatStrings.SubscriptionInterval"), "Uses FormatStrings.SubscriptionInterval");
        Assert.IsFalse(Source.Contains("\"Subscription Settings\""), "No hardcoded Subscription heading");
        Assert.IsFalse(Source.Contains("\"Payment History\""), "No hardcoded Payment History heading");
        Assert.IsFalse(Source.Contains("\"QR Payment Settings\""), "No hardcoded QR Payment heading");
        Assert.IsFalse(Source.Contains("\"yyyy-MM-dd\""), "No hardcoded date format");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PrDetailConstants has UI text")]
    public void PrDetailConstantsHasUiText()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "PrDetailConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(PrDetailConstants.PageHeading)), "Has PageHeading");
        Assert.IsTrue(Source.Contains(nameof(PrDetailConstants.LoadingText)), "Has LoadingText");
        Assert.IsTrue(Source.Contains(nameof(PrDetailConstants.SubmittedByPrefix)), "Has SubmittedByPrefix");
        Assert.IsTrue(Source.Contains(nameof(PrDetailConstants.ViewOnGitHubText)), "Has ViewOnGitHubText");
        Assert.IsTrue(Source.Contains(nameof(PrDetailConstants.ChangedFilesHeading)), "Has ChangedFilesHeading");
        Assert.IsTrue(Source.Contains(nameof(PrDetailConstants.CodeChangesHeading)), "Has CodeChangesHeading");
        Assert.IsTrue(Source.Contains(nameof(PrDetailConstants.ReviewCommentsHeading)), "Has ReviewCommentsHeading");
        Assert.IsTrue(Source.Contains(nameof(PrDetailConstants.ApproveAndMergeButtonText)), "Has ApproveAndMergeButtonText");
        Assert.IsTrue(Source.Contains(nameof(PrDetailConstants.RequestChangesButtonText)), "Has RequestChangesButtonText");
        Assert.IsTrue(Source.Contains(nameof(PrDetailConstants.PaymentHeading)), "Has PaymentHeading");
        Assert.IsTrue(Source.Contains(nameof(PrDetailConstants.CommentLocationFormat)), "Has CommentLocationFormat");
        Assert.IsTrue(Source.Contains(nameof(PrDetailConstants.DiffStatsFormat)), "Has DiffStatsFormat");
    }
}
