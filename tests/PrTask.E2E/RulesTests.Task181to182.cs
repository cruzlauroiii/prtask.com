namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("MayaConnectEndpoints exists with authorize token refresh userinfo jwk routes and RouteConstants has ApiMayaConnect")]
    public void Rule181MayaConnectEndpoints()
    {
        var EndpointsPath = Path.Combine(SourceRoot, "PrTask.Server", "Endpoints", "MayaConnectEndpoints.cs");
        Assert.IsTrue(File.Exists(EndpointsPath), "MayaConnectEndpoints.cs must exist in Server/Endpoints");
        var Endpoints = File.ReadAllText(EndpointsPath);
        Assert.IsTrue(Endpoints.Contains("MapMayaConnectEndpoints"),
            "MayaConnectEndpoints must define MapMayaConnectEndpoints extension method");
        var Routes = ReadSource("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Routes.Contains("ApiMayaConnect"),
            "RouteConstants must define ApiMayaConnect");
        var Registration = ReadSource("PrTask.Infrastructure", "ServiceRegistration.cs");
        Assert.IsTrue(Registration.Contains("IMayaConnectService"),
            "ServiceRegistration must register IMayaConnectService");
        Assert.IsTrue(Registration.Contains("ConnectHttpClientName"),
            "ServiceRegistration must register MayaConnect HttpClient");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("MayaConnectService exists and MayaConstants has Connect constants and FormatStrings has Connect helpers")]
    public void Rule182MayaConnectE2E()
    {
        var ServicePath = Path.Combine(SourceRoot, "PrTask.Infrastructure", "Services", "MayaConnectService.cs");
        Assert.IsTrue(File.Exists(ServicePath), "MayaConnectService.cs must exist in Infrastructure/Services");
        var Service = File.ReadAllText(ServicePath);
        Assert.IsTrue(Service.Contains("IMayaConnectService"),
            "MayaConnectService must implement IMayaConnectService");
        var MayaConst = ReadSource("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(MayaConst.Contains("ConnectSandboxBaseUrl"),
            "MayaConstants must define ConnectSandboxBaseUrl");
        Assert.IsTrue(MayaConst.Contains("ConnectTokenPath"),
            "MayaConstants must define ConnectTokenPath");
        Assert.IsTrue(MayaConst.Contains("ConnectUserInfoPath"),
            "MayaConstants must define ConnectUserInfoPath");
        Assert.IsTrue(MayaConst.Contains("ConnectJwkPath"),
            "MayaConstants must define ConnectJwkPath");
        Assert.IsTrue(MayaConst.Contains("ConfigConnectClientId"),
            "MayaConstants must define ConfigConnectClientId");
        Assert.IsTrue(MayaConst.Contains("ConfigConnectClientSecret"),
            "MayaConstants must define ConfigConnectClientSecret");
        var FormatStr = ReadSource("PrTask.Domain", "Constants", "FormatStrings.cs");
        Assert.IsTrue(FormatStr.Contains("MayaConnectAuthorizeRedirect"),
            "FormatStrings must have MayaConnectAuthorizeRedirect helper");
        Assert.IsTrue(FormatStr.Contains("MayaConnectTokenBody"),
            "FormatStrings must have MayaConnectTokenBody helper");
    }
}
