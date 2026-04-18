namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RefundEndpoints uses RouteConstants for all routes")]
    public void RefundEndpointsUsesRouteConstantsForAllRoutes()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "RefundEndpoints.cs");
        Assert.IsTrue(Source.Contains("RouteConstants"), "Uses RouteConstants");
        Assert.IsTrue(Source.Contains("MapGet"), "Has MapGet");
        Assert.IsTrue(Source.Contains("MapPost"), "Has MapPost");
        Assert.IsTrue(Source.Contains("MapMethods") || Source.Contains("MapPatch"), "Has MapMethods or MapPatch");
        Assert.IsTrue(Source.Contains("RouteConstants.ApiRefunds"), "References RouteConstants.ApiRefunds");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RefundDto has FromEntity factory method")]
    public void RefundDtoHasFromEntityFactoryMethod()
    {
        var Source = ReadSource("PrTask.Application", "Contracts", "RefundDto.cs");
        Assert.IsTrue(Source.Contains("FromEntity"), "Has FromEntity factory method");
        Assert.IsTrue(Source.Contains("RefundEntity"), "References RefundEntity");
        Assert.IsTrue(Source.Contains("record RefundDto"), "Is a record type");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("VoidEndpoints uses RouteConstants for all routes")]
    public void VoidEndpointsUsesRouteConstantsForAllRoutes()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "VoidEndpoints.cs");
        Assert.IsTrue(Source.Contains("RouteConstants"), "Uses RouteConstants");
        Assert.IsTrue(Source.Contains("MapGet"), "Has MapGet");
        Assert.IsTrue(Source.Contains("MapPost"), "Has MapPost");
        Assert.IsTrue(Source.Contains("MapPatch") || Source.Contains("MapMethods"), "Has MapPatch or MapMethods");
        Assert.IsTrue(Source.Contains("RouteConstants.ApiVoids"), "References RouteConstants.ApiVoids");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RouteConstants has void and refund API routes")]
    public void RouteConstantsHasVoidAndRefundApiRoutes()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Source.Contains("ApiRefunds"), "Has ApiRefunds");
        Assert.IsTrue(Source.Contains("ApiVoids"), "Has ApiVoids");
        Assert.IsTrue(Source.Contains("ApiRefundById"), "Has ApiRefundById");
        Assert.IsTrue(Source.Contains("ApiVoidById"), "Has ApiVoidById");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("RouteConstants has payment sub-routes for customers vault and operations")]
    public void RouteConstantsHasPaymentSubRoutesForCustomersVaultAndOperations()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Source.Contains("SubCustomers"), "Has SubCustomers");
        Assert.IsTrue(Source.Contains("SubVaultPay"), "Has SubVaultPay");
        Assert.IsTrue(Source.Contains("SubPaymentCapture"), "Has SubPaymentCapture");
        Assert.IsTrue(Source.Contains("SubPaymentCancel"), "Has SubPaymentCancel");
        Assert.IsTrue(Source.Contains("SubWebhooks"), "Has SubWebhooks");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("CreateRefundRequest and CreateVoidRequest records exist with required properties")]
    public void CreateRefundRequestAndCreateVoidRequestRecordsExistWithRequiredProperties()
    {
        var RefundSource = ReadSource("PrTask.Application", "Contracts", "CreateRefundRequest.cs");
        Assert.IsTrue(RefundSource.Contains("record CreateRefundRequest"), "CreateRefundRequest is a record");
        Assert.IsTrue(RefundSource.Contains("PaymentId"), "CreateRefundRequest has PaymentId");
        Assert.IsTrue(RefundSource.Contains("AmountCents"), "CreateRefundRequest has AmountCents");
        Assert.IsTrue(RefundSource.Contains("Currency"), "CreateRefundRequest has Currency");
        var VoidSource = ReadSource("PrTask.Application", "Contracts", "CreateVoidRequest.cs");
        Assert.IsTrue(VoidSource.Contains("record CreateVoidRequest"), "CreateVoidRequest is a record");
        Assert.IsTrue(VoidSource.Contains("PaymentId"), "CreateVoidRequest has PaymentId");
        Assert.IsTrue(VoidSource.Contains("Reason"), "CreateVoidRequest has Reason");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("CapturePaymentRequest and CancelPaymentRequest records exist with required properties")]
    public void CapturePaymentRequestAndCancelPaymentRequestRecordsExistWithRequiredProperties()
    {
        var CaptureSource = ReadSource("PrTask.Application", "Contracts", "CapturePaymentRequest.cs");
        Assert.IsTrue(CaptureSource.Contains("record CapturePaymentRequest"), "CapturePaymentRequest is a record");
        Assert.IsTrue(CaptureSource.Contains("AmountCents"), "CapturePaymentRequest has AmountCents");
        var CancelSource = ReadSource("PrTask.Application", "Contracts", "CancelPaymentRequest.cs");
        Assert.IsTrue(CancelSource.Contains("record CancelPaymentRequest"), "CancelPaymentRequest is a record");
        Assert.IsTrue(CancelSource.Contains("Reason"), "CancelPaymentRequest has Reason");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("PaymentEndpoints is partial with customer CRUD operations")]
    public void PaymentEndpointsIsPartialWithCustomerCrudOperations()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "PaymentEndpoints.cs");
        Assert.IsTrue(Source.Contains("partial"), "PaymentEndpoints is partial");
        Assert.IsTrue(Source.Contains("MapPost"), "Has MapPost for customer creation");
        Assert.IsTrue(Source.Contains("MapCustomerEndpoints"), "Calls MapCustomerEndpoints");
        Assert.IsTrue(Source.Contains("RouteConstants.SubCustomers") || Source.Contains("SubCustomers"), "Has customers route");
        Assert.IsTrue(Source.Contains("MapPut"), "Has MapPut for customer update");
        Assert.IsTrue(Source.Contains("MapDelete"), "Has MapDelete for customer deletion");
    }
}
