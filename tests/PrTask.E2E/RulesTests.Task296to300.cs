namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Client HTTP service proxies registered in Program.cs")]
    public void ClientHttpServiceProxiesRegistered()
    {
        var Source = ReadSource("PrTask.Client", "Program.cs");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Application.Services.IBoardService)), "IBoardService registered");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Application.Services.ISprintService)), "ISprintService registered");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Application.Services.IRepositoryService)), "IRepositoryService registered");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Application.Services.ILeaderboardService)), "ILeaderboardService registered");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Application.Services.ISubscriptionService)), "ISubscriptionService registered");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Application.Services.IInvoiceService)), "IInvoiceService registered");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("FormatStrings has OwnerPath, ColumnPath, ColumnItemPath")]
    public void FormatStringsUrlBuilders()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "FormatStrings.cs");
        Assert.IsTrue(Source.Contains("OwnerPath"), "OwnerPath exists");
        Assert.IsTrue(Source.Contains("ColumnPath"), "ColumnPath exists");
        Assert.IsTrue(Source.Contains("ColumnItemPath"), "ColumnItemPath exists");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("SettingsPage injects ISubscriptionService and IInvoiceService")]
    public void SettingsPageSubscriptionAndInvoiceInjection()
    {
        var Source = ReadSource("PrTask.SharedUI", "Pages", "SettingsPage.razor.cs");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Application.Services.ISubscriptionService)), "ISubscriptionService injected");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Application.Services.IInvoiceService)), "IInvoiceService injected");
        Assert.IsTrue(Source.Contains("ListSubscriptionsAsync"), "Loads subscriptions");
        Assert.IsTrue(Source.Contains("ListInvoicesAsync"), "Loads invoices");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("HttpSubscriptionService implements ISubscriptionService")]
    public void HttpSubscriptionServiceStructure()
    {
        var Source = ReadSource("PrTask.Client", "Services", "HttpSubscriptionService.cs");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Application.Services.ISubscriptionService)), "Implements ISubscriptionService");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Domain.Constants.RouteConstants.ApiSubscriptions)), "Uses ApiSubscriptions route");
        Assert.IsTrue(Source.Contains("CreateSubscriptionAsync"), "Has CreateSubscriptionAsync");
        Assert.IsTrue(Source.Contains("ListSubscriptionsAsync"), "Has ListSubscriptionsAsync");
        Assert.IsTrue(Source.Contains("CancelSubscriptionAsync"), "Has CancelSubscriptionAsync");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("HttpInvoiceService implements IInvoiceService")]
    public void HttpInvoiceServiceStructure()
    {
        var Source = ReadSource("PrTask.Client", "Services", "HttpInvoiceService.cs");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Application.Services.IInvoiceService)), "Implements IInvoiceService");
        Assert.IsTrue(Source.Contains(nameof(PrTask.Domain.Constants.RouteConstants.ApiInvoices)), "Uses ApiInvoices route");
        Assert.IsTrue(Source.Contains("CreateInvoiceAsync"), "Has CreateInvoiceAsync");
        Assert.IsTrue(Source.Contains("ListInvoicesAsync"), "Has ListInvoicesAsync");
        Assert.IsTrue(Source.Contains("DeleteInvoiceAsync"), "Has DeleteInvoiceAsync");
    }
}
