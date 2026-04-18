using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task239 Worker.js has WebSocket and Durable Object support")]
    public async Task WorkerJsWebSocketSupportAsync()
    {
        var Source = ReadInfra("worker.js");
        Assert.IsTrue(Source.Contains("TaskDurableObject"), "worker.js defines TaskDurableObject class");
        Assert.IsTrue(Source.Contains("webSocketMessage"), "worker.js handles webSocketMessage events");
        Assert.IsTrue(Source.Contains("acceptWebSocket"), "worker.js calls acceptWebSocket for upgrades");
        Assert.IsTrue(Source.Contains("/ws"), "worker.js routes /ws path");
        await Task.CompletedTask;
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task240 Workers.tf has Durable Object binding for TaskDurableObject")]
    public async Task WorkersTfDurableObjectBindingAsync()
    {
        var Source = ReadInfra("workers.tf");
        Assert.IsTrue(
            Source.Contains("durable_object_binding") || Source.Contains("DURABLE_OBJECT_CLASS"),
            "workers.tf has durable_object_binding or DURABLE_OBJECT_CLASS");
        Assert.IsTrue(Source.Contains("TaskDurableObject"), "workers.tf references TaskDurableObject");
        await Task.CompletedTask;
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task241 CloudflareD1Endpoints uses SubQuery and SubStatus routes")]
    public async Task CloudflareD1EndpointsUsesSubRoutesAsync()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "CloudflareD1Endpoints.cs");
        Assert.IsTrue(Source.Contains(nameof(RouteConstants) + ".SubQuery"), "CloudflareD1Endpoints uses RouteConstants.SubQuery");
        Assert.IsTrue(Source.Contains(nameof(RouteConstants) + ".SubStatus"), "CloudflareD1Endpoints uses RouteConstants.SubStatus");
        await Task.CompletedTask;
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task242 ServiceRegistration registers all required services")]
    public async Task ServiceRegistrationHasAllServicesAsync()
    {
        var Source = ReadSource("PrTask.Infrastructure", "ServiceRegistration.cs");
        Assert.IsTrue(Source.Contains("ICloudflareD1Service"), "ServiceRegistration registers ICloudflareD1Service");
        Assert.IsTrue(Source.Contains(nameof(CloudflareConstants) + ".HttpClientName"), "ServiceRegistration registers CloudflareConstants.HttpClientName");
        Assert.IsTrue(Source.Contains("IWssConnectionService"), "ServiceRegistration registers IWssConnectionService");
        Assert.IsTrue(Source.Contains("IInferenceService"), "ServiceRegistration registers IInferenceService");
        Assert.IsTrue(Source.Contains("IVectorSearchService"), "ServiceRegistration registers IVectorSearchService");
        Assert.IsTrue(Source.Contains("ITranscriptionService"), "ServiceRegistration registers ITranscriptionService");
        Assert.IsTrue(Source.Contains("ISyncService"), "ServiceRegistration registers ISyncService");
        await Task.CompletedTask;
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task243 Program.cs maps all endpoint groups and enables WebSockets")]
    public async Task ProgramCsMapsAllEndpointsAsync()
    {
        var Source = ReadSource("PrTask.Server", "Program.cs");
        Assert.IsTrue(Source.Contains("MapWebSocketEndpoint"), "Program.cs maps MapWebSocketEndpoint");
        Assert.IsTrue(Source.Contains("MapCloudflareD1Endpoints"), "Program.cs maps MapCloudflareD1Endpoints");
        Assert.IsTrue(Source.Contains("MapInferenceEndpoints"), "Program.cs maps MapInferenceEndpoints");
        Assert.IsTrue(Source.Contains("MapVectorSearchEndpoints"), "Program.cs maps MapVectorSearchEndpoints");
        Assert.IsTrue(Source.Contains("MapTranscriptionEndpoints"), "Program.cs maps MapTranscriptionEndpoints");
        Assert.IsTrue(Source.Contains("MapSyncEndpoints"), "Program.cs maps MapSyncEndpoints");
        Assert.IsTrue(Source.Contains("UseWebSockets"), "Program.cs calls UseWebSockets");
        await Task.CompletedTask;
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("Task244 RouteConstants defines all D1, WSS, and API route prefixes")]
    public async Task RouteConstantsHasAllRoutesAsync()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "RouteConstants.cs");
        Assert.IsTrue(Source.Contains("ApiCloudflareD1"), "RouteConstants has ApiCloudflareD1");
        Assert.IsTrue(Source.Contains("ApiWebSocket"), "RouteConstants has ApiWebSocket");
        Assert.IsTrue(Source.Contains("ApiInference"), "RouteConstants has ApiInference");
        Assert.IsTrue(Source.Contains("ApiVectorSearch"), "RouteConstants has ApiVectorSearch");
        Assert.IsTrue(Source.Contains("ApiTranscription"), "RouteConstants has ApiTranscription");
        Assert.IsTrue(Source.Contains("ApiSync"), "RouteConstants has ApiSync");
        await Task.CompletedTask;
    }
}
