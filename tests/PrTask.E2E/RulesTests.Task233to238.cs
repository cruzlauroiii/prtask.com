using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("WebSocketEndpoints — server-side WSS handler at /ws")]
    public async Task WebSocketEndpointsMappedAsync()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "WebSocketEndpoints.cs");
        Assert.IsTrue(Source.Contains("MapWebSocketEndpoint"), "MapWebSocketEndpoint extension method exists");
        Assert.IsTrue(Source.Contains(nameof(WssConstants) + ".PathPrefix"), "Uses WssConstants.PathPrefix");
        Assert.IsTrue(Source.Contains(nameof(WssConstants) + ".ProtocolName"), "Uses WssConstants.ProtocolName");
        Assert.IsTrue(Source.Contains("AcceptWebSocketAsync"), "Accepts WebSocket upgrade");
        Assert.IsTrue(Source.Contains(nameof(WssConstants) + ".MessageTypeSubscription"), "Handles subscription messages");
        Assert.IsTrue(Source.Contains(nameof(WssConstants) + ".MessageTypeQuery"), "Handles query messages");
        Assert.IsTrue(Source.Contains(nameof(WssConstants) + ".MessageTypeMutation"), "Handles mutation messages");
        Assert.IsTrue(Source.Contains("BroadcastToChannelAsync"), "Has broadcast capability");
        var Program = ReadSource("PrTask.Server", "Program.cs");
        Assert.IsTrue(Program.Contains("UseWebSockets()"), "WebSocket middleware enabled");
        Assert.IsTrue(Program.Contains("MapWebSocketEndpoint()"), "WebSocket endpoint mapped");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("WssConstants — server-side JSON property constants")]
    public async Task WssConstantsServerPropertiesAsync()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "WssConstants.cs");
        Assert.IsTrue(Source.Contains("JsonType"), "Has JsonType constant");
        Assert.IsTrue(Source.Contains("JsonChannel"), "Has JsonChannel constant");
        Assert.IsTrue(Source.Contains("JsonData"), "Has JsonData constant");
        Assert.IsTrue(Source.Contains("JsonMessage"), "Has JsonMessage constant");
        Assert.IsTrue(Source.Contains("LogWssConnected"), "Has connection log constant");
        Assert.IsTrue(Source.Contains("LogWssDisconnected"), "Has disconnection log constant");
        Assert.IsTrue(Source.Contains("LogWssSubscribed"), "Has subscription log constant");
        Assert.IsTrue(Source.Contains("PathPrefix"), "Has PathPrefix");
        Assert.IsTrue(Source.Contains("ProtocolName"), "Has ProtocolName");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("CloudflareD1 service — ICloudflareD1Service and implementation")]
    public async Task CloudflareD1ServiceExistsAsync()
    {
        var Interface = ReadSource("PrTask.Application", "Services", "ICloudflareD1Service.cs");
        Assert.IsTrue(Interface.Contains("QueryAsync"), "Interface has QueryAsync");
        Assert.IsTrue(Interface.Contains("ExecuteAsync"), "Interface has ExecuteAsync");
        Assert.IsTrue(Interface.Contains("IsConfigured"), "Interface has IsConfigured");
        var Impl = ReadSource("PrTask.Infrastructure", "Services", "CloudflareD1Service.cs");
        Assert.IsTrue(Impl.Contains(": ICloudflareD1Service"), "Implements ICloudflareD1Service");
        Assert.IsTrue(Impl.Contains("IHttpClientFactory"), "Uses IHttpClientFactory");
        Assert.IsTrue(Impl.Contains(nameof(CloudflareConstants) + ".D1QueryPathFormat"), "Uses D1 query path");
        Assert.IsTrue(Impl.Contains(nameof(CloudflareConstants) + ".BearerPrefix"), "Uses Bearer auth");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("CloudflareConstants — D1 API configuration constants")]
    public async Task CloudflareConstantsExistAsync()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "CloudflareConstants.cs");
        Assert.IsTrue(Source.Contains("HttpClientName"), "Has HttpClientName");
        Assert.IsTrue(Source.Contains("ConfigApiToken"), "Has ConfigApiToken");
        Assert.IsTrue(Source.Contains("ConfigD1DatabaseId"), "Has ConfigD1DatabaseId");
        Assert.IsTrue(Source.Contains("D1QueryPathFormat"), "Has D1QueryPathFormat");
        Assert.IsTrue(Source.Contains("BearerPrefix"), "Has BearerPrefix");
        Assert.IsTrue(Source.Contains("JsonResult"), "Has JsonResult");
        Assert.IsTrue(Source.Contains("JsonSuccess"), "Has JsonSuccess");
        Assert.IsTrue(Source.Contains("JsonSql"), "Has JsonSql");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("CloudflareD1 endpoint — query and status routes")]
    public async Task CloudflareD1EndpointsMappedAsync()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "CloudflareD1Endpoints.cs");
        Assert.IsTrue(Source.Contains(nameof(RouteConstants) + ".ApiCloudflareD1"), "D1 endpoints mapped");
        Assert.IsTrue(Source.Contains(nameof(RouteConstants) + ".SubStatus"), "Status endpoint exists");
        Assert.IsTrue(Source.Contains(nameof(RouteConstants) + ".SubQuery"), "Query endpoint exists");
        Assert.IsTrue(Source.Contains("IsConfigured"), "Status returns configured state");
        var Program = ReadSource("PrTask.Server", "Program.cs");
        Assert.IsTrue(Program.Contains("MapCloudflareD1Endpoints()"), "D1 endpoint mapped in Program.cs");
        await Task.CompletedTask;
    }
    [TestMethod, TestCategory("Rules")]
    [DisplayName("D1 WASM client service and registration")]
    public async Task CloudflareD1ClientServiceAsync()
    {
        var ClientProgram = ReadSource("PrTask.Client", "Program.cs");
        Assert.IsTrue(ClientProgram.Contains("HttpCloudflareD1Service") || ClientProgram.Contains("WssCloudflareD1Service"), "D1 client registered");
        var Client = File.Exists(Path.Combine(SourceRoot, "PrTask.Client", "Services", "WssCloudflareD1Service.cs"))
            ? ReadSource("PrTask.Client", "Services", "WssCloudflareD1Service.cs")
            : ReadSource("PrTask.Client", "Services", "HttpCloudflareD1Service.cs");
        Assert.IsTrue(Client.Contains(": ICloudflareD1Service"), "Client implements interface");
        var D1Http = File.Exists(Path.Combine(SourceRoot, "PrTask.Client", "Services", "HttpCloudflareD1Service.cs"))
            ? ReadSource("PrTask.Client", "Services", "HttpCloudflareD1Service.cs") : string.Empty;
        Assert.IsTrue(Client.Contains(nameof(RouteConstants) + ".ApiCloudflareD1") || D1Http.Contains(nameof(RouteConstants) + ".ApiCloudflareD1"), "Uses route constant");
        var Registration = ReadSource("PrTask.Infrastructure", "ServiceRegistration.cs");
        Assert.IsTrue(Registration.Contains("ICloudflareD1Service"), "D1 service registered");
        Assert.IsTrue(Registration.Contains(nameof(CloudflareConstants) + ".HttpClientName"), "D1 HttpClient registered");
        await Task.CompletedTask;
    }
}
