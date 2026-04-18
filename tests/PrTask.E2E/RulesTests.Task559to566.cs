namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("P3PaymentEndpoints has core payment operations with pay authorize capture void refund and transactions")]
    public void P3PaymentEndpointsHasCorePaymentOperationsWithPayAuthorizeCaptureVoidRefundAndTransactions()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "P3PaymentEndpoints.cs");
        Assert.IsTrue(Source.Contains("partial class P3PaymentEndpoints"), "Is partial class");
        Assert.IsTrue(Source.Contains("MapPost(RouteConstants.SubP3Pay"), "Has MapPost for pay");
        Assert.IsTrue(Source.Contains("MapPost(RouteConstants.SubP3Authorize"), "Has MapPost for authorize");
        Assert.IsTrue(Source.Contains("MapPost(RouteConstants.SubP3Capture"), "Has MapPost for capture");
        Assert.IsTrue(Source.Contains("MapPost(RouteConstants.SubP3Void"), "Has MapPost for void");
        Assert.IsTrue(Source.Contains("MapPost(RouteConstants.SubP3Refund"), "Has MapPost for refund");
        Assert.IsTrue(Source.Contains("MapGet(RouteConstants.SubP3TransactionById"), "Has MapGet for transaction by id");
        Assert.IsTrue(Source.Contains("MapGet(RouteConstants.SubP3Transactions"), "Has MapGet for transactions");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("P3PaymentEndpoints.Bin has BIN lookup and API key CRUD operations")]
    public void P3PaymentEndpointsBinHasBinLookupAndApiKeyCrudOperations()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "P3PaymentEndpoints.Bin.cs");
        Assert.IsTrue(Source.Contains("partial class P3PaymentEndpoints"), "Is partial class");
        Assert.IsTrue(Source.Contains("MapGet(RouteConstants.SubP3BinByValue"), "Has MapGet for bin lookup");
        Assert.IsTrue(Source.Contains("MapPost(RouteConstants.SubP3BinsQuery"), "Has MapPost for bins query");
        Assert.IsTrue(Source.Contains("MapGet(RouteConstants.SubP3BinPatterns"), "Has MapGet for bin patterns");
        Assert.IsTrue(Source.Contains("MapPost(RouteConstants.SubP3ApiKeys"), "Has MapPost for create API key");
        Assert.IsTrue(Source.Contains("MapGet(RouteConstants.SubP3ApiKeyById"), "Has MapGet for API key by id");
        Assert.IsTrue(Source.Contains("MapGet(RouteConstants.SubP3ApiKeys"), "Has MapGet for list API keys");
        Assert.IsTrue(Source.Contains("MapDelete(RouteConstants.SubP3ApiKeyById"), "Has MapDelete for API key");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("P3PaymentEndpoints.Recurring has recurring payment creation endpoint")]
    public void P3PaymentEndpointsRecurringHasRecurringPaymentCreationEndpoint()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "P3PaymentEndpoints.Recurring.cs");
        Assert.IsTrue(Source.Contains("partial class P3PaymentEndpoints"), "Is partial class");
        Assert.IsTrue(Source.Contains("MapPost(RouteConstants.SubP3Recurring"), "Has MapPost for recurring");
        Assert.IsTrue(Source.Contains("P3RecurringPaymentRequest"), "Uses P3RecurringPaymentRequest contract");
        Assert.IsTrue(Source.Contains("CreateRecurringPaymentAsync"), "Calls CreateRecurringPaymentAsync");
        Assert.IsTrue(Source.Contains("FrequencyIndicator"), "Passes FrequencyIndicator");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RouteConstants has P3 API routes for payments bins and recurring")]
    public void RouteConstantsHasP3ApiRoutesForPaymentsBinsAndRecurring()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Source.Contains("ApiP3"), "Has ApiP3");
        Assert.IsTrue(Source.Contains("SubP3Pay"), "Has SubP3Pay");
        Assert.IsTrue(Source.Contains("SubP3Authorize"), "Has SubP3Authorize");
        Assert.IsTrue(Source.Contains("SubP3Transactions"), "Has SubP3Transactions");
        Assert.IsTrue(Source.Contains("SubP3BinByValue"), "Has SubP3BinByValue");
        Assert.IsTrue(Source.Contains("SubP3ApiKeys"), "Has SubP3ApiKeys");
        Assert.IsTrue(Source.Contains("SubP3Recurring"), "Has SubP3Recurring");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("P3PayRequest is a record with card amount currency and reference fields")]
    public void P3PayRequestIsARecordWithCardAmountCurrencyAndReferenceFields()
    {
        var Source = ReadSource("PrTask.Application", "Contracts", "P3PayRequest.cs");
        Assert.IsTrue(Source.Contains("record P3PayRequest"), "Is a record type");
        Assert.IsTrue(Source.Contains("CardNumber"), "Has CardNumber");
        Assert.IsTrue(Source.Contains("ExpMonth"), "Has ExpMonth");
        Assert.IsTrue(Source.Contains("ExpYear"), "Has ExpYear");
        Assert.IsTrue(Source.Contains("Cvc"), "Has Cvc");
        Assert.IsTrue(Source.Contains("Amount"), "Has Amount");
        Assert.IsTrue(Source.Contains("Currency"), "Has Currency");
        Assert.IsTrue(Source.Contains("RequestReferenceNumber"), "Has RequestReferenceNumber");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SCSS has login page enrichment styles for benefits and why-prtask section")]
    public void ScssHasLoginPageEnrichmentStylesForBenefitsAndWhyPrtaskSection()
    {
        var Source = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.SharedUI", "Styles", "app.scss"));
        Assert.IsTrue(Source.Contains(".benefit-cards"), "Has .benefit-cards");
        Assert.IsTrue(Source.Contains(".benefit-card"), "Has .benefit-card");
        Assert.IsTrue(Source.Contains(".why-prtask-section"), "Has .why-prtask-section");
        Assert.IsTrue(Source.Contains(".btn-outline"), "Has .btn-outline");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SCSS has about page and download page styles for mission values and features")]
    public void ScssHasAboutPageAndDownloadPageStylesForMissionValuesAndFeatures()
    {
        var Source = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.SharedUI", "Styles", "app.scss"));
        Assert.IsTrue(Source.Contains(".mission-section"), "Has .mission-section");
        Assert.IsTrue(Source.Contains(".values-grid"), "Has .values-grid");
        Assert.IsTrue(Source.Contains(".feature-table"), "Has .feature-table");
        Assert.IsTrue(Source.Contains(".coming-soon"), "Has .coming-soon");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SCSS has pricing page enrichment styles for comparison enterprise and CTA")]
    public void ScssHasPricingPageEnrichmentStylesForComparisonEnterpriseAndCta()
    {
        var Source = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.SharedUI", "Styles", "app.scss"));
        Assert.IsTrue(Source.Contains(".comparison-table"), "Has .comparison-table");
        Assert.IsTrue(Source.Contains(".enterprise-section"), "Has .enterprise-section");
        Assert.IsTrue(Source.Contains(".get-started-section"), "Has .get-started-section");
        Assert.IsTrue(Source.Contains(".btn-cta"), "Has .btn-cta");
    }
}
