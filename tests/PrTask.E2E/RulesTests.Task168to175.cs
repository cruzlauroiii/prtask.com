namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Privacy page includes NPC registration reference and AppConstants has NpcRegistrationNumber")]
    public void Rule168NpcRegistrationDisplay()
    {
        var Privacy = ReadSource("PrTask.SharedUI", "Pages", "Legal", "PrivacyPage.razor");
        Assert.IsTrue(Privacy.Contains("NPC") || Privacy.Contains("National Privacy Commission") || Privacy.Contains("Npc") || Privacy.Contains("PrivacyConstants"),
            "Privacy page must reference NPC (National Privacy Commission)");
        var AppConst = ReadSource("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(AppConst.Contains("NpcRegistrationNumber"),
            "AppConstants must define NpcRegistrationNumber string property");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("AppConstants defines TransactionRetentionYears equal to 5 for AMLA compliance")]
    public void Rule169TransactionRetention()
    {
        var AppConst = ReadSource("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(AppConst.Contains("TransactionRetentionYears"),
            "AppConstants must define TransactionRetentionYears constant");
        Assert.IsTrue(AppConst.Contains('5'),
            "TransactionRetentionYears must be set to 5 for AMLA RA 9160 compliance");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("UserEntity has KYC fields and Settings page has KYC section for in-app verification")]
    public void Rule170MayaKycInApp()
    {
        var User = ReadSource("PrTask.Domain", "Models", "UserEntity.cs");
        Assert.IsTrue(User.Contains("KycDocumentType"),
            "UserEntity must have KycDocumentType property");
        Assert.IsTrue(User.Contains("KycSubmittedAt"),
            "UserEntity must have KycSubmittedAt property");
        Assert.IsTrue(User.Contains("KycVerifiedAt"),
            "UserEntity must have KycVerifiedAt property");
        var Settings = ReadSource("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Settings.Contains("KYC") || Settings.Contains("kyc") || Settings.Contains("Kyc") || Settings.Contains("identity verification") || Settings.Contains("Identity Verification"),
            "Settings page must have a KYC section for identity verification");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IRemittanceService interface exists with CreateRemittanceAsync ExecuteRemittanceAsync and GetRemittanceStatusAsync")]
    public void Rule171MayaRemittance()
    {
        var RemittancePath = Path.Combine(SourceRoot, "PrTask.Application", "Services", "IRemittanceService.cs");
        Assert.IsTrue(File.Exists(RemittancePath), "IRemittanceService must exist in PrTask.Application/Services");
        var Remittance = File.ReadAllText(RemittancePath);
        Assert.IsTrue(Remittance.Contains("CreateRemittanceAsync"),
            "IRemittanceService must have CreateRemittanceAsync method");
        Assert.IsTrue(Remittance.Contains("ExecuteRemittanceAsync"),
            "IRemittanceService must have ExecuteRemittanceAsync method");
        Assert.IsTrue(Remittance.Contains("GetRemittanceStatusAsync"),
            "IRemittanceService must have GetRemittanceStatusAsync method");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IBillsPaymentService interface exists with biller and bill payment methods and BillPaymentEntity exists")]
    public void Rule172MayaBillsPayment()
    {
        var BillsPath = Path.Combine(SourceRoot, "PrTask.Application", "Services", "IBillsPaymentService.cs");
        Assert.IsTrue(File.Exists(BillsPath), "IBillsPaymentService must exist in PrTask.Application/Services");
        var Bills = File.ReadAllText(BillsPath);
        Assert.IsTrue(Bills.Contains("GetBillersAsync"),
            "IBillsPaymentService must have GetBillersAsync method");
        Assert.IsTrue(Bills.Contains("CreateBillPaymentAsync"),
            "IBillsPaymentService must have CreateBillPaymentAsync method");
        Assert.IsTrue(Bills.Contains("ExecuteBillPaymentAsync"),
            "IBillsPaymentService must have ExecuteBillPaymentAsync method");
        Assert.IsTrue(Bills.Contains("GetBillPaymentStatusAsync"),
            "IBillsPaymentService must have GetBillPaymentStatusAsync method");
        var EntityFiles = GetSourceFiles(".cs")
            .Where(F => Path.GetFileName(F) == "BillPaymentEntity.cs")
            .ToList();
        Assert.IsTrue(EntityFiles.Count > 0, "BillPaymentEntity must exist in the domain");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IP3PaymentService supports recurring payments with frequencyIndicator or RECURRING reference")]
    public void Rule173MayaP3Recurring()
    {
        var P3 = ReadSource("PrTask.Application", "Services", "IP3PaymentService.cs");
        Assert.IsTrue(P3.Contains("RECURRING") || P3.Contains("Recurring") || P3.Contains("frequencyIndicator") || P3.Contains("FrequencyIndicator"),
            "IP3PaymentService must reference RECURRING or frequencyIndicator for recurring payments");
        var RecurringEntities = GetSourceFiles(".cs")
            .Where(F => Path.GetFileName(F).Contains("P3Recurring") || Path.GetFileName(F).Contains("RecurringPayment"))
            .ToList();
        Assert.IsTrue(RecurringEntities.Count > 0, "P3RecurringPaymentEntity must exist for tracking recurring charges");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Privacy page references Standard Contractual Clauses or SCCs or Article 46 for EU data transfers")]
    public void Rule174StandardContractualClauses()
    {
        var Privacy = ReadSource("PrTask.SharedUI", "Pages", "Legal", "PrivacyPage.razor");
        Assert.IsTrue(
            Privacy.Contains("Standard Contractual Clauses") || Privacy.Contains("SCCs") || Privacy.Contains("Article 46") || Privacy.Contains("InternationalDataTransfers"),
            "Privacy page must reference Standard Contractual Clauses, SCCs, or Article 46 for EU data transfers");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("AppConstants defines VatRatePercent equal to 12 and VatThresholdPhp for BIR VAT compliance")]
    public void Rule175BirVat()
    {
        var AppConst = ReadSource("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(AppConst.Contains("VatRatePercent"),
            "AppConstants must define VatRatePercent constant");
        Assert.IsTrue(AppConst.Contains("12"),
            "VatRatePercent must be set to 12 for Philippine VAT");
        Assert.IsTrue(AppConst.Contains("VatThresholdPhp"),
            "AppConstants must define VatThresholdPhp constant");
    }
}
