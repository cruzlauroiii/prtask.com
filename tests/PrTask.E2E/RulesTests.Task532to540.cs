namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("WssConstants has no string interpolation")]
    public void WssConstantsHasNoStringInterpolation()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "WssConstants.cs");
        Assert.IsFalse(Source.Contains("$\""), "Must not contain string interpolation");
        Assert.IsTrue(Source.Contains("MessageTypeSubscription"), "Has MessageTypeSubscription");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("FormatStrings has WssSubscriptionMessage method")]
    public void FormatStringsHasWssSubscriptionMessageMethod()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "FormatStrings.cs");
        Assert.IsTrue(Source.Contains("WssSubscriptionMessage"), "Has WssSubscriptionMessage");
        Assert.IsTrue(Source.Contains("WssConstants.MessageTypeSubscription"), "Uses WssConstants.MessageTypeSubscription");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("IRefundService interface exists with CRUD methods")]
    public void IRefundServiceInterfaceExistsWithCrudMethods()
    {
        var Source = ReadSource("PrTask.Application", "Services", "IRefundService.cs");
        Assert.IsTrue(Source.Contains("GetByIdAsync"), "Has GetByIdAsync");
        Assert.IsTrue(Source.Contains("ListByPaymentIdAsync"), "Has ListByPaymentIdAsync");
        Assert.IsTrue(Source.Contains("CreateRefundAsync"), "Has CreateRefundAsync");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RefundService implements IRefundService")]
    public void RefundServiceImplementsIRefundService()
    {
        var Source = ReadSource("PrTask.Infrastructure", "Services", "RefundService.cs");
        Assert.IsTrue(Source.Contains("IRefundService"), "Implements IRefundService");
        Assert.IsTrue(Source.Contains("AppDbContext"), "Uses AppDbContext");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RefundEndpoints has CRUD route mappings")]
    public void RefundEndpointsHasCrudRouteMappings()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "RefundEndpoints.cs");
        Assert.IsTrue(Source.Contains("MapGet"), "Has MapGet");
        Assert.IsTrue(Source.Contains("MapPost"), "Has MapPost");
        Assert.IsTrue(Source.Contains("MapMethods") || Source.Contains("MapPatch") || Source.Contains("MapPut"), "Has MapPatch or MapPut or MapMethods");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RouteConstants has refund API routes")]
    public void RouteConstantsHasRefundApiRoutes()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Source.Contains("ApiRefund"), "Has ApiRefund route constants");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("IVoidService interface exists with CRUD methods")]
    public void IVoidServiceInterfaceExistsWithCrudMethods()
    {
        var Source = ReadSource("PrTask.Application", "Services", "IVoidService.cs");
        Assert.IsTrue(Source.Contains("GetByIdAsync"), "Has GetByIdAsync");
        Assert.IsTrue(Source.Contains("ListByPaymentIdAsync"), "Has ListByPaymentIdAsync");
        Assert.IsTrue(Source.Contains("CreateVoidAsync"), "Has CreateVoidAsync");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("VoidService implements IVoidService")]
    public void VoidServiceImplementsIVoidService()
    {
        var Source = ReadSource("PrTask.Infrastructure", "Services", "VoidService.cs");
        Assert.IsTrue(Source.Contains("IVoidService"), "Implements IVoidService");
        Assert.IsTrue(Source.Contains("AppDbContext"), "Uses AppDbContext");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("VoidEndpoints has CRUD route mappings")]
    public void VoidEndpointsHasCrudRouteMappings()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "VoidEndpoints.cs");
        Assert.IsTrue(Source.Contains("MapGet"), "Has MapGet");
        Assert.IsTrue(Source.Contains("MapPost"), "Has MapPost");
        Assert.IsTrue(Source.Contains("MapPatch") || Source.Contains("MapPut") || Source.Contains("MapMethods"), "Has MapPatch or MapPut or MapMethods");
    }
}
