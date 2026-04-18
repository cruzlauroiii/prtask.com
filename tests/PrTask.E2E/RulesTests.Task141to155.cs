namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("MayaSandboxCredentials class exists with Party1-Party5 key pairs, P3 secret key, and merchant IDs")]
    public void Rule141MayaSandboxCredentials()
    {
        var CredentialsPath = Path.Combine(SourceRoot, "PrTask.Domain", "Constants", "MayaSandboxCredentials.cs");
        Assert.IsTrue(File.Exists(CredentialsPath), "MayaSandboxCredentials.cs must exist in PrTask.Domain/Constants");
        var Content = File.ReadAllText(CredentialsPath);
        Assert.IsTrue(Content.Contains("MayaSandboxCredentials"), "File must define MayaSandboxCredentials class");
        Assert.IsTrue(Content.Contains("Party1") && Content.Contains("Party2") && Content.Contains("Party3") &&
            Content.Contains("Party4") && Content.Contains("Party5"),
            "MayaSandboxCredentials must define Party1 through Party5 key pairs");
        Assert.IsTrue(Content.Contains("PublicKey") && Content.Contains("SecretKey"),
            "MayaSandboxCredentials must define PublicKey and SecretKey for each party");
        Assert.IsTrue(Content.Contains("P3") || Content.Contains("p3"),
            "MayaSandboxCredentials must define P3 sandbox secret key");
        Assert.IsTrue(Content.Contains("EFS100000126") || Content.Contains("EFS100001149") || Content.Contains("EFS100001033"),
            "MayaSandboxCredentials must define P3 merchant IDs");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("SubscriptionStatus has Active/Cancelled/Expired/Paused and SubscriptionInterval has Day/Month/Year")]
    public void Rule142SubscriptionEnums()
    {
        var SubscriptionStatusPath = Path.Combine(SourceRoot, "PrTask.Domain", "Models", "SubscriptionStatus.cs");
        Assert.IsTrue(File.Exists(SubscriptionStatusPath), "SubscriptionStatus.cs must exist in PrTask.Domain/Models");
        var StatusContent = File.ReadAllText(SubscriptionStatusPath);
        Assert.IsTrue(StatusContent.Contains("Active"), "SubscriptionStatus must include Active");
        Assert.IsTrue(StatusContent.Contains("Cancelled"), "SubscriptionStatus must include Cancelled");
        Assert.IsTrue(StatusContent.Contains("Expired"), "SubscriptionStatus must include Expired");
        Assert.IsTrue(StatusContent.Contains("Paused"), "SubscriptionStatus must include Paused");
        var SubscriptionIntervalPath = Path.Combine(SourceRoot, "PrTask.Domain", "Models", "SubscriptionInterval.cs");
        Assert.IsTrue(File.Exists(SubscriptionIntervalPath), "SubscriptionInterval.cs must exist in PrTask.Domain/Models");
        var IntervalContent = File.ReadAllText(SubscriptionIntervalPath);
        Assert.IsTrue(IntervalContent.Contains("Day"), "SubscriptionInterval must include Day");
        Assert.IsTrue(IntervalContent.Contains("Month"), "SubscriptionInterval must include Month");
        Assert.IsTrue(IntervalContent.Contains("Year"), "SubscriptionInterval must include Year");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("PaymentType enum includes Subscription, WalletPayment, QrPayment, Invoice, Disbursement, and BillPayment")]
    public void Rule143PaymentTypeExtensions()
    {
        var Content = ReadSource("PrTask.Domain", "Models", "PaymentType.cs");
        Assert.IsTrue(Content.Contains("Subscription"), "PaymentType must include Subscription");
        Assert.IsTrue(Content.Contains("WalletPayment"), "PaymentType must include WalletPayment");
        Assert.IsTrue(Content.Contains("QrPayment"), "PaymentType must include QrPayment");
        Assert.IsTrue(Content.Contains("Invoice"), "PaymentType must include Invoice");
        Assert.IsTrue(Content.Contains("Disbursement"), "PaymentType must include Disbursement");
        Assert.IsTrue(Content.Contains("BillPayment"), "PaymentType must include BillPayment");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("AppDbContext has DbSet for SubscriptionEntity, InvoiceEntity, DisbursementEntity, VoidEntity, and RefundEntity")]
    public void Rule144AllMayaEntitiesInAppDbContext()
    {
        var Content = ReadSource("PrTask.Infrastructure", "Data", "AppDbContext.cs");
        Assert.IsTrue(Content.Contains("SubscriptionEntity"), "AppDbContext must have DbSet for SubscriptionEntity");
        Assert.IsTrue(Content.Contains("InvoiceEntity"), "AppDbContext must have DbSet for InvoiceEntity");
        Assert.IsTrue(Content.Contains("DisbursementEntity"), "AppDbContext must have DbSet for DisbursementEntity");
        Assert.IsTrue(Content.Contains("VoidEntity"), "AppDbContext must have DbSet for VoidEntity");
        Assert.IsTrue(Content.Contains("RefundEntity"), "AppDbContext must have DbSet for RefundEntity");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("RouteConstants defines API routes for subscriptions, invoices, disbursements, qr-payments, wallet-payments, and bills-payments")]
    public void Rule145MayaApiRouteConstants()
    {
        var Content = ReadSource("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Content.Contains("/Api/Subscriptions") || Content.Contains("ApiSubscriptions"),
            "RouteConstants must define /Api/Subscriptions route");
        Assert.IsTrue(Content.Contains("/Api/Invoices") || Content.Contains("ApiInvoices"),
            "RouteConstants must define /Api/Invoices route");
        Assert.IsTrue(Content.Contains("/Api/Disbursements") || Content.Contains("ApiDisbursements"),
            "RouteConstants must define /Api/Disbursements route");
        Assert.IsTrue(Content.Contains("/Api/QrPayments") || Content.Contains("ApiQrPayments"),
            "RouteConstants must define /Api/QrPayments route");
        Assert.IsTrue(Content.Contains("/Api/WalletPayments") || Content.Contains("ApiWalletPayments"),
            "RouteConstants must define /Api/WalletPayments route");
        Assert.IsTrue(Content.Contains("/Api/BillsPayments") || Content.Contains("ApiBillsPayments"),
            "RouteConstants must define /Api/BillsPayments route");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("SubscriptionEndpoints file exists with CRUD route registration")]
    public void Rule146SubscriptionCrudEndpoints()
    {
        var EndpointPath = Path.Combine(SourceRoot, "PrTask.Server", "Endpoints", "SubscriptionEndpoints.cs");
        Assert.IsTrue(File.Exists(EndpointPath), "SubscriptionEndpoints.cs must exist in PrTask.Server/Endpoints");
        var Content = File.ReadAllText(EndpointPath);
        Assert.IsTrue(Content.Contains("MapGet") || Content.Contains("GET"),
            "SubscriptionEndpoints must register GET routes");
        Assert.IsTrue(Content.Contains("MapPost") || Content.Contains("POST"),
            "SubscriptionEndpoints must register POST routes");
        Assert.IsTrue(Content.Contains("MapDelete") || Content.Contains("DELETE"),
            "SubscriptionEndpoints must register DELETE routes");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("InvoiceEndpoints file exists with CRUD route registration")]
    public void Rule147InvoiceCrudEndpoints()
    {
        var EndpointPath = Path.Combine(SourceRoot, "PrTask.Server", "Endpoints", "InvoiceEndpoints.cs");
        Assert.IsTrue(File.Exists(EndpointPath), "InvoiceEndpoints.cs must exist in PrTask.Server/Endpoints");
        var Content = File.ReadAllText(EndpointPath);
        Assert.IsTrue(Content.Contains("MapGet") || Content.Contains("GET"),
            "InvoiceEndpoints must register GET routes");
        Assert.IsTrue(Content.Contains("MapPost") || Content.Contains("POST"),
            "InvoiceEndpoints must register POST routes");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("DisbursementEndpoints file exists with CRUD route registration")]
    public void Rule148DisbursementCrudEndpoints()
    {
        var EndpointPath = Path.Combine(SourceRoot, "PrTask.Server", "Endpoints", "DisbursementEndpoints.cs");
        Assert.IsTrue(File.Exists(EndpointPath), "DisbursementEndpoints.cs must exist in PrTask.Server/Endpoints");
        var Content = File.ReadAllText(EndpointPath);
        Assert.IsTrue(Content.Contains("MapGet") || Content.Contains("GET"),
            "DisbursementEndpoints must register GET routes");
        Assert.IsTrue(Content.Contains("MapPost") || Content.Contains("POST"),
            "DisbursementEndpoints must register POST routes");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("QrPaymentEndpoints file exists with dynamic QR, static QR, execute, and status routes")]
    public void Rule149QrPaymentEndpoints()
    {
        var EndpointPath = Path.Combine(SourceRoot, "PrTask.Server", "Endpoints", "QrPaymentEndpoints.cs");
        Assert.IsTrue(File.Exists(EndpointPath), "QrPaymentEndpoints.cs must exist in PrTask.Server/Endpoints");
        var Content = File.ReadAllText(EndpointPath);
        Assert.IsTrue(Content.Contains("MapPost") || Content.Contains("POST"),
            "QrPaymentEndpoints must register POST routes for QR creation");
        Assert.IsTrue(Content.Contains("MapGet") || Content.Contains("MapPut") || Content.Contains("GET") || Content.Contains("PUT"),
            "QrPaymentEndpoints must register GET or PUT routes for status or execution");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("WalletPaymentEndpoints file exists with payment, link, execute, and delete routes")]
    public void Rule150WalletPaymentEndpoints()
    {
        var EndpointPath = Path.Combine(SourceRoot, "PrTask.Server", "Endpoints", "WalletPaymentEndpoints.cs");
        Assert.IsTrue(File.Exists(EndpointPath), "WalletPaymentEndpoints.cs must exist in PrTask.Server/Endpoints");
        var Content = File.ReadAllText(EndpointPath);
        Assert.IsTrue(Content.Contains("MapPost") || Content.Contains("POST"),
            "WalletPaymentEndpoints must register POST routes");
        Assert.IsTrue(Content.Contains("MapGet") || Content.Contains("MapDelete") || Content.Contains("GET") || Content.Contains("DELETE"),
            "WalletPaymentEndpoints must register GET or DELETE routes for link management");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Settings page has sections for subscriptions, wallet links, payment history, disbursement, invoice, and QR payments")]
    public void Rule151SettingsPageMayaSections()
    {
        var Content = ReadSource("PrTask.SharedUI", "Pages", "SettingsPage.razor");
        Assert.IsTrue(Content.Contains("subscription") || Content.Contains("Subscription"),
            "Settings page must have subscriptions section");
        Assert.IsTrue(Content.Contains("wallet") || Content.Contains("Wallet") || Content.Contains("wallet-link") || Content.Contains("WalletLink"),
            "Settings page must have wallet links section");
        Assert.IsTrue(Content.Contains("payment-history") || Content.Contains("Payment History") || Content.Contains("PaymentHistory"),
            "Settings page must have payment history section");
        Assert.IsTrue(Content.Contains("disbursement") || Content.Contains("Disbursement"),
            "Settings page must have disbursement section");
        Assert.IsTrue(Content.Contains("invoice") || Content.Contains("Invoice"),
            "Settings page must have invoice section");
        Assert.IsTrue(Content.Contains("qr") || Content.Contains("QR") || Content.Contains("qr-payment") || Content.Contains("QrPayment"),
            "Settings page must have QR payments section");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("PaymentService enforces void/refund cutoff times referencing Philippine Standard Time")]
    public void Rule152MayaVoidRefundBusinessRules()
    {
        var PaymentServiceFiles = GetSourceFiles(".cs")
            .Where(F => F.Contains("PaymentService"))
            .ToList();
        Assert.IsTrue(PaymentServiceFiles.Count > 0, "PaymentService files must exist");
        var AllContent = string.Join("\n", PaymentServiceFiles.Select(File.ReadAllText));
        Assert.IsTrue(
            AllContent.Contains("cutoff", StringComparison.OrdinalIgnoreCase) ||
            AllContent.Contains("11:59") ||
            AllContent.Contains("Philippine", StringComparison.OrdinalIgnoreCase) ||
            AllContent.Contains("PST") ||
            AllContent.Contains("Asia/Manila"),
            "PaymentService must enforce void/refund cutoff times referencing Philippine Standard Time");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("MayaConstants defines HoldPeriodDays or hold period constants per card network")]
    public void Rule153MayaAuthHoldPeriods()
    {
        var Content = ReadSource("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(
            Content.Contains("HoldPeriodDays") || Content.Contains("HoldPeriod") ||
            Content.Contains("hold", StringComparison.OrdinalIgnoreCase),
            "MayaConstants must define HoldPeriodDays or hold period constants per card network");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("MayaConstants defines SandboxDataRetentionDays (90) and ProductionDataRetentionDays (390)")]
    public void Rule154MayaDataRetention()
    {
        var Content = ReadSource("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(Content.Contains("SandboxDataRetentionDays"),
            "MayaConstants must define SandboxDataRetentionDays");
        Assert.IsTrue(Content.Contains("ProductionDataRetentionDays"),
            "MayaConstants must define ProductionDataRetentionDays");
        Assert.IsTrue(Content.Contains("90"), "SandboxDataRetentionDays must be 90");
        Assert.IsTrue(Content.Contains("390"), "ProductionDataRetentionDays must be 390");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Terms page references AMLA or Anti-Money Laundering Act or RA 9160 for AML compliance")]
    public void Rule155AntiMoneyLaundering()
    {
        var Content = ReadSource("PrTask.SharedUI", "Pages", "Legal", "TermsPage.razor");
        Assert.IsTrue(
            Content.Contains("AMLA") ||
            Content.Contains("Anti-Money Laundering") ||
            Content.Contains("anti-money laundering") ||
            Content.Contains("RA 9160") ||
            Content.Contains("money laundering", StringComparison.OrdinalIgnoreCase) ||
            Content.Contains("AntiMoneyLaundering"),
            "Terms page must reference AMLA, Anti-Money Laundering Act, or RA 9160 for AML compliance");
    }
}
