namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("BillPaymentDto record with FromEntity exists")]
    public void BillPaymentDtoExists()
    {
        var Source = ReadSource("PrTask.Application", "Contracts", "BillPaymentDto.cs");
        Assert.IsTrue(Source.Contains("BillPaymentDto"), "Must define BillPaymentDto record");
        Assert.IsTrue(Source.Contains("FromEntity"), "Must have FromEntity method");
        Assert.IsTrue(Source.Contains("BillPaymentEntity"), "Must reference BillPaymentEntity");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("DisbursementDto record with FromEntity exists")]
    public void DisbursementDtoExists()
    {
        var Source = ReadSource("PrTask.Application", "Contracts", "DisbursementDto.cs");
        Assert.IsTrue(Source.Contains("DisbursementDto"), "Must define DisbursementDto record");
        Assert.IsTrue(Source.Contains("FromEntity"), "Must have FromEntity method");
        Assert.IsTrue(Source.Contains("DisbursementEntity"), "Must reference DisbursementEntity");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("P3RecurringPaymentDto record with FromEntity exists")]
    public void P3RecurringPaymentDtoExists()
    {
        var Source = ReadSource("PrTask.Application", "Contracts", "P3RecurringPaymentDto.cs");
        Assert.IsTrue(Source.Contains("P3RecurringPaymentDto"), "Must define P3RecurringPaymentDto record");
        Assert.IsTrue(Source.Contains("FromEntity"), "Must have FromEntity method");
        Assert.IsTrue(Source.Contains("P3RecurringPaymentEntity"), "Must reference P3RecurringPaymentEntity");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsPage wallet section shows MayaCustomerId dynamically")]
    public void SettingsPageWalletDynamic()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Source.Contains("MayaCustomerId"),
            "Wallet section must reference CurrentUser.MayaCustomerId");
        Assert.IsTrue(Source.Contains("WalletLinkedFormat"),
            "Wallet section must use WalletLinkedFormat constant");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsPage disbursement section shows PayoutMethod dynamically")]
    public void SettingsPageDisbursementDynamic()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Source.Contains("PayoutDetails"),
            "Disbursement section must reference CurrentUser.PayoutDetails");
        Assert.IsTrue(Source.Contains("DisbursementConfiguredFormat"),
            "Disbursement section must use DisbursementConfiguredFormat constant");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsConstants defines WalletLinkedFormat and DisbursementConfiguredFormat")]
    public void SettingsConstantsFormatConstants()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "SettingsConstants.cs");
        Assert.IsTrue(Source.Contains("WalletLinkedFormat"),
            "Must define WalletLinkedFormat constant");
        Assert.IsTrue(Source.Contains("DisbursementConfiguredFormat"),
            "Must define DisbursementConfiguredFormat constant");
    }
}
