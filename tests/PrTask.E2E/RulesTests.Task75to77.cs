using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task75 Local dev must use HTTPS with random port via launchSettings and AppConstants DevHttpsUrl")]
    public void Task75HttpsRandomPort()
    {
        var LaunchSettings = File.ReadAllText(Path.Combine(SourceRoot, "PrTask.Client", "Properties", "launchSettings.json"));
        Assert.IsTrue(LaunchSettings.Contains("https"), "launchSettings must have HTTPS profile");
        Assert.IsTrue(LaunchSettings.Contains("https://127.0.0.1:0") || LaunchSettings.Contains("https://localhost:0"), "HTTPS profile must use loopback with random port");
        Assert.IsFalse(LaunchSettings.Contains("http://"), "launchSettings must not have HTTP-only URLs");
        var Constants = ReadSource("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(Constants.Contains("DevHttpsUrl"), "AppConstants must define DevHttpsUrl");
        Assert.IsTrue(Constants.Contains("https://127.0.0.1:0") || Constants.Contains("https://localhost:0"), "DevHttpsUrl must use HTTPS with dynamic port");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task76 Localhost must work like production with SSO and WSS realtime via configurable CallbackRedirect")]
    public void Task76LocalhostWorksLikeProduction()
    {
        var FormatStr = ReadSource("PrTask.Domain", "Constants", "FormatStrings.cs");
        Assert.IsTrue(FormatStr.Contains("CallbackRedirect(string BaseUrl, string CallbackRoute)"), "FormatStrings must have CallbackRedirect overload accepting BaseUrl");
        Assert.IsTrue(FormatStr.Contains("CallbackRedirect(string CallbackRoute)"), "FormatStrings must keep default CallbackRedirect for production");
        var Constants = ReadSource("PrTask.Domain", "Constants", "AppConstants.cs");
        Assert.IsTrue(Constants.Contains("WssEndpoint"), "AppConstants must define WssEndpoint for production WSS");
        Assert.IsTrue(Constants.Contains("LocalWssEndpoint"), "AppConstants must define LocalWssEndpoint for local WSS");
        Assert.IsTrue(Constants.Contains("wss://"), "WSS endpoints must use wss:// protocol");
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task77 Static CDN with WSS DB — WssConstants IWssConnectionService and WssConnectionService must exist")]
    public void Task77StaticCdnWithWssDatabase()
    {
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.Domain", "Constants", "WssConstants.cs")), "WssConstants must exist");
        var WssConst = ReadSource("PrTask.Domain", "Constants", "WssConstants.cs");
        Assert.IsTrue(WssConst.Contains("ProductionEndpoint"), "WssConstants must define ProductionEndpoint");
        Assert.IsTrue(WssConst.Contains("LocalEndpoint"), "WssConstants must define LocalEndpoint");
        Assert.IsTrue(WssConst.Contains("wss://"), "WssConstants must use wss:// protocol");
        Assert.IsTrue(WssConst.Contains("ReconnectDelayMs"), "WssConstants must define ReconnectDelayMs");
        Assert.IsTrue(WssConst.Contains("ProtocolName"), "WssConstants must define ProtocolName");
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.Application", "Services", "IWssConnectionService.cs")), "IWssConnectionService must exist in Application");
        var WssInterface = ReadSource("PrTask.Application", "Services", "IWssConnectionService.cs");
        Assert.IsTrue(WssInterface.Contains("ConnectAsync"), "IWssConnectionService must have ConnectAsync");
        Assert.IsTrue(WssInterface.Contains("QueryAsync"), "IWssConnectionService must have QueryAsync");
        Assert.IsTrue(WssInterface.Contains("SubscribeAsync"), "IWssConnectionService must have SubscribeAsync");
        Assert.IsTrue(WssInterface.Contains("IsConnected"), "IWssConnectionService must have IsConnected property");
        Assert.IsTrue(File.Exists(Path.Combine(SourceRoot, "PrTask.Infrastructure", "Services", "WssConnectionService.cs")), "WssConnectionService must exist in Infrastructure");
        var WssImpl = ReadSource("PrTask.Infrastructure", "Services", "WssConnectionService.cs");
        Assert.IsTrue(WssImpl.Contains("ClientWebSocket"), "WssConnectionService must use ClientWebSocket");
        Assert.IsTrue(WssImpl.Contains("WssConstants"), "WssConnectionService must reference WssConstants");
        var Registration = ReadSource("PrTask.Infrastructure", "ServiceRegistration.cs");
        Assert.IsTrue(Registration.Contains("IWssConnectionService") && Registration.Contains("WssConnectionService"), "ServiceRegistration must register IWssConnectionService");
    }
}
