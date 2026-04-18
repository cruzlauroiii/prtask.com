namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("IPaymentV2Service exists with CreatePaymentV2Async and MayaConstants has PaymentV2Endpoint")]
    public void Rule183MayaPaymentV2ConnectToken()
    {
        var InterfacePath = Path.Combine(SourceRoot, "PrTask.Application", "Services", "IPaymentV2Service.cs");
        Assert.IsTrue(File.Exists(InterfacePath), "IPaymentV2Service.cs must exist in Application/Services");
        var Interface = File.ReadAllText(InterfacePath);
        Assert.IsTrue(Interface.Contains("CreatePaymentV2Async"),
            "IPaymentV2Service must have CreatePaymentV2Async method");
        Assert.IsTrue(Interface.Contains("GetPaymentV2Async"),
            "IPaymentV2Service must have GetPaymentV2Async method");
        var ServicePath = Path.Combine(SourceRoot, "PrTask.Infrastructure", "Services", "PaymentV2Service.cs");
        Assert.IsTrue(File.Exists(ServicePath), "PaymentV2Service.cs must exist in Infrastructure/Services");
        var Service = File.ReadAllText(ServicePath);
        Assert.IsTrue(Service.Contains("IPaymentV2Service"),
            "PaymentV2Service must implement IPaymentV2Service");
        var MayaConst = ReadSource("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(MayaConst.Contains("PaymentV2Endpoint"),
            "MayaConstants must define PaymentV2Endpoint");
        Assert.IsTrue(MayaConst.Contains("PaymentV2ConnectTokenProperty"),
            "MayaConstants must define PaymentV2ConnectTokenProperty");
        var FormatStr = ReadSource("PrTask.Domain", "Constants", "FormatStrings.cs");
        Assert.IsTrue(FormatStr.Contains("MayaPaymentV2Path"),
            "FormatStrings must have MayaPaymentV2Path helper");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("PaymentV2Endpoints exists with routes and ServiceRegistration has IPaymentV2Service")]
    public void Rule184MayaPaymentV2EndpointsAndTests()
    {
        var EndpointsPath = Path.Combine(SourceRoot, "PrTask.Server", "Endpoints", "PaymentV2Endpoints.cs");
        Assert.IsTrue(File.Exists(EndpointsPath), "PaymentV2Endpoints.cs must exist in Server/Endpoints");
        var Endpoints = File.ReadAllText(EndpointsPath);
        Assert.IsTrue(Endpoints.Contains("MapPaymentV2Endpoints"),
            "PaymentV2Endpoints must define MapPaymentV2Endpoints extension method");
        var Routes = ReadSource("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Routes.Contains("ApiPaymentsV2"),
            "RouteConstants must define ApiPaymentsV2");
        var Registration = ReadSource("PrTask.Infrastructure", "ServiceRegistration.cs");
        Assert.IsTrue(Registration.Contains("IPaymentV2Service"),
            "ServiceRegistration must register IPaymentV2Service");
    }
}
