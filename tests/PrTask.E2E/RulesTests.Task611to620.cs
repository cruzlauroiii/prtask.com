namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PullRequestEndpoints PATCH uses UpdatePullRequestRequest DTO")]
    public void PullRequestEndpointsPatchUsesUpdatePullRequestRequest()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "PullRequestEndpoints.cs");
        Assert.IsTrue(Source.Contains("UpdatePullRequestRequest"),
            "PullRequestEndpoints PATCH must accept UpdatePullRequestRequest DTO");
        Assert.IsTrue(Source.Contains("MapPatch"),
            "PullRequestEndpoints must have a PATCH route");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("ReviewCommentEndpoints POST uses CreateReviewCommentRequest DTO with auto-generated Id")]
    public void ReviewCommentEndpointsPostUsesCreateReviewCommentRequest()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "ReviewCommentEndpoints.cs");
        Assert.IsTrue(Source.Contains("CreateReviewCommentRequest"),
            "ReviewCommentEndpoints POST must accept CreateReviewCommentRequest DTO");
        Assert.IsTrue(Source.Contains("Guid.NewGuid()"),
            "ReviewCommentEndpoints POST must auto-generate Id");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("InvoiceEndpoints returns InvoiceDto not raw entity")]
    public void InvoiceEndpointsReturnsInvoiceDto()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "InvoiceEndpoints.cs");
        Assert.IsTrue(Source.Contains("InvoiceDto.FromEntity"),
            "InvoiceEndpoints must use InvoiceDto.FromEntity to map entities");
        Assert.IsTrue(Source.Contains("InvoiceDto"),
            "InvoiceEndpoints must reference InvoiceDto");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("SubscriptionEndpoints returns SubscriptionDto not raw entity")]
    public void SubscriptionEndpointsReturnsSubscriptionDto()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "SubscriptionEndpoints.cs");
        Assert.IsTrue(Source.Contains("SubscriptionDto.FromEntity"),
            "SubscriptionEndpoints must use SubscriptionDto.FromEntity to map entities");
        Assert.IsTrue(Source.Contains("SubscriptionDto"),
            "SubscriptionEndpoints must reference SubscriptionDto");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("VoidEndpoints returns VoidDto not raw entity")]
    public void VoidEndpointsReturnsVoidDto()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "VoidEndpoints.cs");
        Assert.IsTrue(Source.Contains("VoidDto.FromEntity"),
            "VoidEndpoints must use VoidDto.FromEntity to map entities");
        Assert.IsTrue(Source.Contains("VoidDto"),
            "VoidEndpoints must reference VoidDto");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("DemoSeedHelper.cs exists as partial static class with SeedAsync")]
    public void DemoSeedHelperExistsAsPartialStaticClassWithSeedMethod()
    {
        var Source = ReadSource("PrTask.Server", "DemoSeedHelper.cs");
        Assert.IsTrue(Source.Contains("public static partial class DemoSeedHelper"),
            "DemoSeedHelper must be declared as public static partial class");
        Assert.IsTrue(Source.Contains("SeedAsync"),
            "DemoSeedHelper must contain SeedAsync method");
        Assert.IsTrue(Source.Contains("AppDbContext"),
            "SeedAsync must accept AppDbContext parameter");
        Assert.IsTrue(Source.Contains("IServiceProvider"),
            "SeedAsync must accept IServiceProvider parameter");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("DemoSeedHelper.Payments.cs seeds Subscription Invoice Disbursement P3RecurringPayment Repository")]
    public void DemoSeedHelperPaymentsSeedsAllPaymentEntities()
    {
        var Source = ReadSource("PrTask.Server", "DemoSeedHelper.Payments.cs");
        Assert.IsTrue(Source.Contains("SeedSubscriptionAsync"),
            "Must contain SeedSubscriptionAsync method");
        Assert.IsTrue(Source.Contains("SeedInvoiceAsync"),
            "Must contain SeedInvoiceAsync method");
        Assert.IsTrue(Source.Contains("SeedDisbursementAsync"),
            "Must contain SeedDisbursementAsync method");
        Assert.IsTrue(Source.Contains("SeedP3RecurringPaymentAsync"),
            "Must contain SeedP3RecurringPaymentAsync method");
        Assert.IsTrue(Source.Contains("SeedRepositoryAsync"),
            "Must contain SeedRepositoryAsync method");
        Assert.IsTrue(Source.Contains("public static partial class DemoSeedHelper"),
            "DemoSeedHelper.Payments.cs must be partial class");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("DemoSeedConstants defines seed data for all 5 payment entities")]
    public void DemoSeedConstantsDefinesAllPaymentEntitySeedData()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "DemoSeedConstants.cs");
        Assert.IsTrue(Source.Contains("SubscriptionId"), "Must define SubscriptionId");
        Assert.IsTrue(Source.Contains("SubscriptionCardTokenId"), "Must define SubscriptionCardTokenId");
        Assert.IsTrue(Source.Contains("SubscriptionDescription"), "Must define SubscriptionDescription");
        Assert.IsTrue(Source.Contains("SubscriptionAmountCents"), "Must define SubscriptionAmountCents");
        Assert.IsTrue(Source.Contains("SubscriptionCurrency"), "Must define SubscriptionCurrency");
        Assert.IsTrue(Source.Contains("InvoiceId"), "Must define InvoiceId");
        Assert.IsTrue(Source.Contains("InvoiceAmountCents"), "Must define InvoiceAmountCents");
        Assert.IsTrue(Source.Contains("InvoiceCurrency"), "Must define InvoiceCurrency");
        Assert.IsTrue(Source.Contains("InvoiceDescription"), "Must define InvoiceDescription");
        Assert.IsTrue(Source.Contains("DisbursementId"), "Must define DisbursementId");
        Assert.IsTrue(Source.Contains("DisbursementBeneficiaryCount"), "Must define DisbursementBeneficiaryCount");
        Assert.IsTrue(Source.Contains("DisbursementTotalAmountCents"), "Must define DisbursementTotalAmountCents");
        Assert.IsTrue(Source.Contains("P3RecurringPaymentId"), "Must define P3RecurringPaymentId");
        Assert.IsTrue(Source.Contains("P3OriginalTransactionRefNo"), "Must define P3OriginalTransactionRefNo");
        Assert.IsTrue(Source.Contains("P3FrequencyIndicator"), "Must define P3FrequencyIndicator");
        Assert.IsTrue(Source.Contains("P3RecurringAmountCents"), "Must define P3RecurringAmountCents");
        Assert.IsTrue(Source.Contains("P3RecurringCurrency"), "Must define P3RecurringCurrency");
        Assert.IsTrue(Source.Contains("RepositoryId"), "Must define RepositoryId");
        Assert.IsTrue(Source.Contains("RepositoryUrl"), "Must define RepositoryUrl");
        Assert.IsTrue(Source.Contains("RepositoryName"), "Must define RepositoryName");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Program.cs delegates seeding to DemoSeedHelper.SeedAsync")]
    public void ProgramCsDelegatesToDemoSeedHelperSeed()
    {
        var Source = ReadSource("PrTask.Server", "Program.cs");
        Assert.IsTrue(Source.Contains("DemoSeedHelper.SeedAsync"),
            "Program.cs must call DemoSeedHelper.SeedAsync");
        Assert.IsTrue(Source.Contains("Scope.ServiceProvider"),
            "Program.cs must pass ServiceProvider to SeedAsync");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Program.cs is under 150 lines after seed extraction")]
    public void ProgramCsIsUnder150Lines()
    {
        var Source = ReadSource("PrTask.Server", "Program.cs");
        var LineCount = Source.Split('\n').Length;
        Assert.IsTrue(LineCount < 150,
            "Program.cs must be under 150 lines but has " + LineCount.ToString() + " lines");
    }
}
