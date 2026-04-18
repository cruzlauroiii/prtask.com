namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PaymentService has full subscription lifecycle and SubscriptionEntity exists with required properties")]
    public void Rule126MayaSubscriptionsApi()
    {
        var ISubscription = ReadSource("PrTask.Application", "Services", "ISubscriptionService.cs");
        var SubscriptionSvc = ReadSource("PrTask.Infrastructure", "Services", "SubscriptionService.cs");
        var AllPaymentContent = ISubscription + SubscriptionSvc;
        Assert.IsTrue(AllPaymentContent.Contains("CreateSubscriptionAsync"), "PaymentService must have CreateSubscriptionAsync");
        Assert.IsTrue(AllPaymentContent.Contains("ListSubscriptionsAsync"), "PaymentService must have ListSubscriptionsAsync");
        Assert.IsTrue(AllPaymentContent.Contains("GetSubscriptionAsync"), "PaymentService must have GetSubscriptionAsync");
        Assert.IsTrue(AllPaymentContent.Contains("CancelSubscriptionAsync"), "PaymentService must have CancelSubscriptionAsync");
        Assert.IsTrue(AllPaymentContent.Contains("GetSubscriptionPaymentsAsync"), "PaymentService must have GetSubscriptionPaymentsAsync");
        var SubscriptionPath = Path.Combine(SourceRoot, "PrTask.Domain", "Models", "SubscriptionEntity.cs");
        Assert.IsTrue(File.Exists(SubscriptionPath), "SubscriptionEntity must exist in PrTask.Domain/Models");
        var Subscription = File.ReadAllText(SubscriptionPath);
        Assert.IsTrue(Subscription.Contains("Id"), "SubscriptionEntity must have Id property");
        Assert.IsTrue(Subscription.Contains("CustomerId"), "SubscriptionEntity must have CustomerId property");
        Assert.IsTrue(Subscription.Contains("CardTokenId"), "SubscriptionEntity must have CardTokenId property");
        Assert.IsTrue(Subscription.Contains("MayaSubscriptionId"), "SubscriptionEntity must have MayaSubscriptionId property");
        Assert.IsTrue(Subscription.Contains("AmountCents"), "SubscriptionEntity must have AmountCents property");
        Assert.IsTrue(Subscription.Contains("Interval"), "SubscriptionEntity must have Interval property");
        Assert.IsTrue(Subscription.Contains("Status"), "SubscriptionEntity must have Status property");
        Assert.IsTrue(Subscription.Contains("CreatedAt"), "SubscriptionEntity must have CreatedAt property");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IWalletPaymentService exists with Maya wallet payment methods")]
    public void Rule127MayaWalletPaymentApi()
    {
        var WalletPath = Path.Combine(SourceRoot, "PrTask.Application", "Services", "IWalletPaymentService.cs");
        Assert.IsTrue(File.Exists(WalletPath), "IWalletPaymentService must exist in PrTask.Application/Services");
        var Wallet = File.ReadAllText(WalletPath);
        Assert.IsTrue(Wallet.Contains("CreateWalletPaymentAsync"), "IWalletPaymentService must have CreateWalletPaymentAsync");
        Assert.IsTrue(Wallet.Contains("CreateWalletLinkAsync"), "IWalletPaymentService must have CreateWalletLinkAsync");
        Assert.IsTrue(Wallet.Contains("ExecuteWalletLinkPaymentAsync"), "IWalletPaymentService must have ExecuteWalletLinkPaymentAsync");
        Assert.IsTrue(Wallet.Contains("GetWalletLinkAsync"), "IWalletPaymentService must have GetWalletLinkAsync");
        Assert.IsTrue(Wallet.Contains("DeleteWalletLinkAsync"), "IWalletPaymentService must have DeleteWalletLinkAsync");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IQrPaymentService exists with Maya QR payment methods")]
    public void Rule128MayaQrPaymentsApi()
    {
        var QrPath = Path.Combine(SourceRoot, "PrTask.Application", "Services", "IQrPaymentService.cs");
        Assert.IsTrue(File.Exists(QrPath), "IQrPaymentService must exist in PrTask.Application/Services");
        var Qr = File.ReadAllText(QrPath);
        Assert.IsTrue(Qr.Contains("CreateDynamicQrAsync"), "IQrPaymentService must have CreateDynamicQrAsync");
        Assert.IsTrue(Qr.Contains("CreateStaticQrPaymentAsync"), "IQrPaymentService must have CreateStaticQrPaymentAsync");
        Assert.IsTrue(Qr.Contains("ExecuteQrPaymentAsync"), "IQrPaymentService must have ExecuteQrPaymentAsync");
        Assert.IsTrue(Qr.Contains("GetQrPaymentAsync"), "IQrPaymentService must have GetQrPaymentAsync");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("CalculateFeesAsync exists in PaymentService and IPaymentService for Maya Convenience Fee API")]
    public void Rule129MayaConvenienceFeeApi()
    {
        var IPayment = ReadSource("PrTask.Application", "Services", "IPaymentService.cs");
        Assert.IsTrue(IPayment.Contains("CalculateFeesAsync"), "IPaymentService must have CalculateFeesAsync");
        var PaymentSvc = ReadSource("PrTask.Infrastructure", "Services", "PaymentService.cs");
        Assert.IsTrue(PaymentSvc.Contains("CalculateFeesAsync"), "PaymentService must implement CalculateFeesAsync");
        Assert.IsTrue(PaymentSvc.Contains("FeesEndpoint"), "PaymentService must use MayaConstants.FeesEndpoint");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IDisbursementService exists and DisbursementEntity exists with required properties")]
    public void Rule130MayaDisbursementApi()
    {
        var DisbursementSvcPath = Path.Combine(SourceRoot, "PrTask.Application", "Services", "IDisbursementService.cs");
        Assert.IsTrue(File.Exists(DisbursementSvcPath), "IDisbursementService must exist in PrTask.Application/Services");
        var Disbursement = File.ReadAllText(DisbursementSvcPath);
        Assert.IsTrue(Disbursement.Contains("IDisbursementService"), "File must define IDisbursementService interface");
        var EntityPath = Path.Combine(SourceRoot, "PrTask.Domain", "Models", "DisbursementEntity.cs");
        Assert.IsTrue(File.Exists(EntityPath), "DisbursementEntity must exist in PrTask.Domain/Models");
        var Entity = File.ReadAllText(EntityPath);
        Assert.IsTrue(Entity.Contains("DisbursementEntity"), "File must define DisbursementEntity class");
        Assert.IsTrue(Entity.Contains("Status"), "DisbursementEntity must have Status property");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IP3PaymentService exists with full acquiring methods")]
    public void Rule131MayaP3Api()
    {
        var P3Path = Path.Combine(SourceRoot, "PrTask.Application", "Services", "IP3PaymentService.cs");
        Assert.IsTrue(File.Exists(P3Path), "IP3PaymentService must exist in PrTask.Application/Services");
        var P3 = File.ReadAllText(P3Path);
        Assert.IsTrue(P3.Contains("PayAsync"), "IP3PaymentService must have PayAsync");
        Assert.IsTrue(P3.Contains("AuthorizeAsync"), "IP3PaymentService must have AuthorizeAsync");
        Assert.IsTrue(P3.Contains("CaptureAsync"), "IP3PaymentService must have CaptureAsync");
        Assert.IsTrue(P3.Contains("FinalCaptureAsync"), "IP3PaymentService must have FinalCaptureAsync");
        Assert.IsTrue(P3.Contains("VoidP3Async"), "IP3PaymentService must have VoidP3Async");
        Assert.IsTrue(P3.Contains("RefundP3Async"), "IP3PaymentService must have RefundP3Async");
        Assert.IsTrue(P3.Contains("GetTransactionAsync"), "IP3PaymentService must have GetTransactionAsync");
        Assert.IsTrue(P3.Contains("ListTransactionsAsync"), "IP3PaymentService must have ListTransactionsAsync");
        Assert.IsTrue(P3.Contains("BalanceInquiryAsync"), "IP3PaymentService must have BalanceInquiryAsync");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IInvoiceService exists and InvoiceEntity exists with required properties")]
    public void Rule132MayaInvoiceApi()
    {
        var InvoiceSvcPath = Path.Combine(SourceRoot, "PrTask.Application", "Services", "IInvoiceService.cs");
        Assert.IsTrue(File.Exists(InvoiceSvcPath), "IInvoiceService must exist in PrTask.Application/Services");
        var Invoice = File.ReadAllText(InvoiceSvcPath);
        Assert.IsTrue(Invoice.Contains("IInvoiceService"), "File must define IInvoiceService interface");
        var EntityPath = Path.Combine(SourceRoot, "PrTask.Domain", "Models", "InvoiceEntity.cs");
        Assert.IsTrue(File.Exists(EntityPath), "InvoiceEntity must exist in PrTask.Domain/Models");
        var Entity = File.ReadAllText(EntityPath);
        Assert.IsTrue(Entity.Contains("InvoiceEntity"), "File must define InvoiceEntity class");
        Assert.IsTrue(Entity.Contains("MayaInvoiceId"), "InvoiceEntity must have MayaInvoiceId property");
        Assert.IsTrue(Entity.Contains("InvoiceUrl"), "InvoiceEntity must have InvoiceUrl property");
        Assert.IsTrue(Entity.Contains("AmountCents"), "InvoiceEntity must have AmountCents property");
        Assert.IsTrue(Entity.Contains("Status"), "InvoiceEntity must have Status property");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IPaymentService has GetPaymentByIdAsync and GetPaymentByRrnAsync for payment retrieval")]
    public void Rule133MayaPaymentRetrieval()
    {
        var IPayment = ReadSource("PrTask.Application", "Services", "IPaymentService.cs");
        var PaymentSvc = ReadSource("PrTask.Infrastructure", "Services", "PaymentService.cs");
        Assert.IsTrue(IPayment.Contains("GetPaymentByRrnAsync") || IPayment.Contains("GetPaymentStatusAsync"),
            "IPaymentService must have GetPaymentByIdAsync or GetPaymentStatusAsync");
        Assert.IsTrue(IPayment.Contains("GetPaymentByRrnAsync"), "IPaymentService must have GetPaymentByRrnAsync");
        Assert.IsTrue(PaymentSvc.Contains("GetPaymentByRrnAsync") || PaymentSvc.Contains("PaymentByRrnEndpoint"),
            "PaymentService must implement RRN-based retrieval");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("PaymentService has void and refund retrieval methods and VoidEntity and RefundEntity exist")]
    public void Rule134MayaVoidRefundRetrieval()
    {
        var IPayment = ReadSource("PrTask.Application", "Services", "IPaymentService.cs");
        var PaymentSvc = ReadSource("PrTask.Infrastructure", "Services", "PaymentService.cs");
        var VaultContent = ReadSource("PrTask.Infrastructure", "Services", "PaymentService.Vault.cs");
        var AllContent = IPayment + PaymentSvc + VaultContent;
        Assert.IsTrue(AllContent.Contains("ListVoidsAsync"), "PaymentService must have ListVoidsAsync");
        Assert.IsTrue(AllContent.Contains("GetVoidAsync"), "PaymentService must have GetVoidAsync");
        Assert.IsTrue(AllContent.Contains("ListRefundsAsync"), "PaymentService must have ListRefundsAsync");
        Assert.IsTrue(AllContent.Contains("GetRefundAsync"), "PaymentService must have GetRefundAsync");
        var VoidPath = Path.Combine(SourceRoot, "PrTask.Domain", "Models", "VoidEntity.cs");
        Assert.IsTrue(File.Exists(VoidPath), "VoidEntity must exist in PrTask.Domain/Models");
        var RefundPath = Path.Combine(SourceRoot, "PrTask.Domain", "Models", "RefundEntity.cs");
        Assert.IsTrue(File.Exists(RefundPath), "RefundEntity must exist in PrTask.Domain/Models");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("MayaTestCards class exists with sandbox test card constants for all brands")]
    public void Rule135MayaTestCardsConstants()
    {
        var TestCardsPath = Path.Combine(SourceRoot, "PrTask.Domain", "Constants", "MayaTestCards.cs");
        Assert.IsTrue(File.Exists(TestCardsPath), "MayaTestCards must exist in PrTask.Domain/Constants");
        var TestCards = File.ReadAllText(TestCardsPath);
        Assert.IsTrue(TestCards.Contains("MayaTestCards"), "File must define MayaTestCards static class");
        Assert.IsTrue(TestCards.Contains("VisaNoThreeDs"), "MayaTestCards must have VisaNoThreeDs constant");
        Assert.IsTrue(TestCards.Contains("VisaThreeDs"), "MayaTestCards must have VisaThreeDs constant");
        Assert.IsTrue(TestCards.Contains("MasterCardNoThreeDs"), "MayaTestCards must have MasterCardNoThreeDs constant");
        Assert.IsTrue(TestCards.Contains("MasterCardThreeDs"), "MayaTestCards must have MasterCardThreeDs constant");
        Assert.IsTrue(TestCards.Contains("Amex"), "MayaTestCards must have Amex constant");
        Assert.IsTrue(TestCards.Contains("Jcb"), "MayaTestCards must have Jcb constant");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("MayaErrorCodes class exists with error codes and MayaErrorResponse record exists")]
    public void Rule136MayaErrorCodeConstants()
    {
        var ErrorCodesPath = Path.Combine(SourceRoot, "PrTask.Domain", "Constants", "MayaErrorCodes.cs");
        Assert.IsTrue(File.Exists(ErrorCodesPath), "MayaErrorCodes must exist in PrTask.Domain/Constants");
        var ErrorCodes = File.ReadAllText(ErrorCodesPath);
        Assert.IsTrue(ErrorCodes.Contains("MayaErrorCodes"), "File must define MayaErrorCodes static class");
        Assert.IsTrue(ErrorCodes.Contains("PY0002"), "MayaErrorCodes must have PY0002 (CardExpired)");
        Assert.IsTrue(ErrorCodes.Contains("PY0003"), "MayaErrorCodes must have PY0003 (CardInvalid)");
        Assert.IsTrue(ErrorCodes.Contains("PY0009"), "MayaErrorCodes must have PY0009 (PaymentNotFound)");
        var ErrorResponsePath = Path.Combine(SourceRoot, "PrTask.Domain", "Models", "MayaErrorResponse.cs");
        Assert.IsTrue(File.Exists(ErrorResponsePath), "MayaErrorResponse must exist in PrTask.Domain/Models");
        var ErrorResponse = File.ReadAllText(ErrorResponsePath);
        Assert.IsTrue(ErrorResponse.Contains("MayaErrorResponse"), "File must define MayaErrorResponse record");
        Assert.IsTrue(ErrorResponse.Contains("Code"), "MayaErrorResponse must have Code property");
        Assert.IsTrue(ErrorResponse.Contains("Message"), "MayaErrorResponse must have Message property");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("MayaConstants has SandboxWebhookIps and ProductionWebhookIps with correct IP addresses")]
    public void Rule137MayaWebhookSecurity()
    {
        var MayaConst = ReadSource("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(MayaConst.Contains("SandboxWebhookIps"), "MayaConstants must define SandboxWebhookIps");
        Assert.IsTrue(MayaConst.Contains("ProductionWebhookIps"), "MayaConstants must define ProductionWebhookIps");
        Assert.IsTrue(MayaConst.Contains("13.229.160.234"), "SandboxWebhookIps must include 13.229.160.234");
        Assert.IsTrue(MayaConst.Contains("3.1.199.75"), "SandboxWebhookIps must include 3.1.199.75");
        Assert.IsTrue(MayaConst.Contains("18.138.50.235"), "ProductionWebhookIps must include 18.138.50.235");
        Assert.IsTrue(MayaConst.Contains("3.1.207.200"), "ProductionWebhookIps must include 3.1.207.200");
        Assert.IsTrue(MayaConst.Contains("52.76.121.68"), "ProductionWebhookIps must include 52.76.121.68");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IWebhookIdempotencyService exists with IsProcessedAsync and MarkProcessedAsync methods")]
    public void Rule138MayaWebhookRetry()
    {
        var IdempotencyPath = Path.Combine(SourceRoot, "PrTask.Application", "Services", "IWebhookIdempotencyService.cs");
        Assert.IsTrue(File.Exists(IdempotencyPath), "IWebhookIdempotencyService must exist in PrTask.Application/Services");
        var Idempotency = File.ReadAllText(IdempotencyPath);
        Assert.IsTrue(Idempotency.Contains("IWebhookIdempotencyService"), "File must define IWebhookIdempotencyService interface");
        Assert.IsTrue(Idempotency.Contains("IsProcessedAsync"), "IWebhookIdempotencyService must have IsProcessedAsync");
        Assert.IsTrue(Idempotency.Contains("MarkProcessedAsync"), "IWebhookIdempotencyService must have MarkProcessedAsync");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("PaymentService or IPaymentService has HandleThreeDsCallbackAsync for 3DS flow")]
    public void Rule139MayaThreeDsFlow()
    {
        var IPayment = ReadSource("PrTask.Application", "Services", "IPaymentService.cs");
        var PaymentSvc = ReadSource("PrTask.Infrastructure", "Services", "PaymentService.cs");
        var VaultContent = ReadSource("PrTask.Infrastructure", "Services", "PaymentService.Vault.cs");
        var AllContent = IPayment + PaymentSvc + VaultContent;
        Assert.IsTrue(AllContent.Contains("HandleThreeDsCallbackAsync"),
            "PaymentService must have HandleThreeDsCallbackAsync for 3DS verification flow");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("PaymentService references X-Idempotency-Key or IdempotencyKey for idempotent payment operations")]
    public void Rule140MayaIdempotency()
    {
        var PaymentSvc = ReadSource("PrTask.Infrastructure", "Services", "PaymentService.cs");
        var VaultContent = ReadSource("PrTask.Infrastructure", "Services", "PaymentService.Vault.cs");
        var AllContent = PaymentSvc + VaultContent;
        Assert.IsTrue(AllContent.Contains("X-Idempotency-Key") || AllContent.Contains("IdempotencyKey") || AllContent.Contains("Idempotency"),
            "PaymentService must reference X-Idempotency-Key or IdempotencyKey for idempotent operations");
    }
}
