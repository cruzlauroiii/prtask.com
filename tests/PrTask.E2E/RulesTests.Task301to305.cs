namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SubscriptionEndpoints source structure")]
    public void SubscriptionEndpointsStructure()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "SubscriptionEndpoints.cs");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Domain.Constants.RouteConstants.ApiSubscriptions)), "Uses ApiSubscriptions");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Application.Services.ISubscriptionService)), "Injects ISubscriptionService");
        Assert.IsTrue(Source.Contains("RequireAuthorization"), "Requires auth");
        Assert.IsTrue(Source.Contains("CreateSubscriptionAsync"), "Calls CreateSubscriptionAsync");
        Assert.IsTrue(Source.Contains("ListSubscriptionsAsync"), "Calls ListSubscriptionsAsync");
        Assert.IsTrue(Source.Contains("CancelSubscriptionAsync"), "Calls CancelSubscriptionAsync");
        Assert.IsTrue(Source.Contains("GetSubscriptionPaymentsAsync"), "Calls GetSubscriptionPaymentsAsync");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("InvoiceEndpoints source structure")]
    public void InvoiceEndpointsStructure()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "InvoiceEndpoints.cs");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Domain.Constants.RouteConstants.ApiInvoices)), "Uses ApiInvoices");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Application.Services.IInvoiceService)), "Injects IInvoiceService");
        Assert.IsTrue(Source.Contains("RequireAuthorization"), "Requires auth");
        Assert.IsTrue(Source.Contains("CreateInvoiceAsync"), "Calls CreateInvoiceAsync");
        Assert.IsTrue(Source.Contains("ListInvoicesAsync"), "Calls ListInvoicesAsync");
        Assert.IsTrue(Source.Contains("DeleteInvoiceAsync"), "Calls DeleteInvoiceAsync");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("AchievementEndpoints source structure")]
    public void AchievementEndpointsStructure()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "AchievementEndpoints.cs");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Domain.Constants.RouteConstants.ApiAchievements)), "Uses ApiAchievements");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Application.Services.IAchievementService)), "Injects IAchievementService");
        Assert.IsTrue(Source.Contains("GetByUserAsync"), "Calls GetByUserAsync");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("HttpBoardService uses FormatStrings column helpers")]
    public void HttpBoardServiceColumnHelpers()
    {
        var Source = ReadSource("PrTask.Client", "Services", "HttpBoardService.cs");
        Assert.IsTrue(Source.Contains("ColumnPath"), "Uses FormatStrings.ColumnPath");
        Assert.IsTrue(Source.Contains("ColumnItemPath"), "Uses FormatStrings.ColumnItemPath");
        Assert.IsTrue(Source.Contains("OwnerPath"), "Uses FormatStrings.OwnerPath");
        Assert.IsTrue(Source.Contains("ListColumnsAsync"), "Has ListColumnsAsync");
        Assert.IsTrue(Source.Contains("CreateColumnAsync"), "Has CreateColumnAsync");
        Assert.IsTrue(Source.Contains("UpdateColumnAsync"), "Has UpdateColumnAsync");
        Assert.IsTrue(Source.Contains("DeleteColumnAsync"), "Has DeleteColumnAsync");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("HttpSprintService uses correct routes")]
    public void HttpSprintServiceRoutes()
    {
        var Source = ReadSource("PrTask.Client", "Services", "HttpSprintService.cs");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Application.Services.ISprintService)), "Implements ISprintService");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Domain.Constants.RouteConstants.ApiSprints)), "Uses ApiSprints route");
        Assert.IsTrue(Source.Contains("OwnerPath"), "Uses FormatStrings.OwnerPath for ListByOwnerAsync");
        Assert.IsTrue(Source.Contains("ListActiveAsync"), "Has ListActiveAsync");
        Assert.IsTrue(Source.Contains("CreateAsync"), "Has CreateAsync");
        Assert.IsTrue(Source.Contains("UpdateAsync"), "Has UpdateAsync");
        Assert.IsTrue(Source.Contains("DeleteAsync"), "Has DeleteAsync");
    }
}
