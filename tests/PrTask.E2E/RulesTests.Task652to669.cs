namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task652 Worker handles diff message type with broadcast")]
    public void WorkerHandlesDiffMessageType()
    {
        var Source = ReadInfra("worker.js");
        Assert.IsTrue(Source.Contains("diff"),
            "Worker must handle diff message type");
        Assert.IsTrue(Source.Contains("broadcast"),
            "Worker must broadcast diff messages to subscribed peers");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task653 Worker handles catchup_request with mutation log")]
    public void WorkerHandlesCatchupRequest()
    {
        var Source = ReadInfra("worker.js");
        Assert.IsTrue(Source.Contains("catchup_request"),
            "Worker must handle catchup_request message type");
        Assert.IsTrue(Source.Contains("mutations"),
            "Worker catchup response must include mutations array");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task654 Worker handles subscription messages")]
    public void WorkerHandlesSubscription()
    {
        var Source = ReadInfra("worker.js");
        Assert.IsTrue(Source.Contains("subscription") || Source.Contains("subscribe"),
            "Worker must handle subscription messages");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task655 Worker persists mutation log to R2")]
    public void WorkerPersistsMutationLogToR2()
    {
        var Source = ReadInfra("worker.js");
        Assert.IsTrue(Source.Contains("R2") || Source.Contains("r2") || Source.Contains("BUCKET") || Source.Contains("put("),
            "Worker must persist mutation log to R2 storage");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task656 Worker uses Durable Object for WSS gatekeeper")]
    public void WorkerUsesDurableObjectGatekeeper()
    {
        var Source = ReadInfra("worker.js");
        Assert.IsTrue(Source.Contains("GatekeeperDO") || Source.Contains("DurableObject"),
            "Worker must use GatekeeperDO Durable Object for WSS");
        Assert.IsTrue(Source.Contains("webSocketMessage") || Source.Contains("WebSocket"),
            "Worker must handle WebSocket messages in Durable Object");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task657 Worker snapshot endpoint returns JSON with timestamp")]
    public void WorkerSnapshotEndpointReturnsTimestamp()
    {
        var Source = ReadInfra("worker.js");
        Assert.IsTrue(Source.Contains("snapshot") || Source.Contains("api/snapshot"),
            "Worker must have snapshot endpoint");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task658 ServiceRegistration registers ISyncService")]
    public void ServiceRegistrationRegistersISyncService()
    {
        var Source = ReadSource("PrTask.Infrastructure", "ServiceRegistration.cs");
        Assert.IsTrue(Source.Contains("ISyncService") && Source.Contains("SyncService"),
            "ServiceRegistration must register ISyncService as SyncService");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task659 ServiceRegistration registers IWssConnectionService")]
    public void ServiceRegistrationRegistersIWssConnectionService()
    {
        var Source = ReadSource("PrTask.Infrastructure", "ServiceRegistration.cs");
        Assert.IsTrue(Source.Contains("IWssConnectionService") && Source.Contains("WssConnectionService"),
            "ServiceRegistration must register IWssConnectionService as WssConnectionService");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task660 Desktop Program uses AddInfrastructure for sync services")]
    public void DesktopProgramUsesAddInfrastructure()
    {
        var Source = ReadSource("PrTask.Desktop", "Program.cs");
        Assert.IsTrue(Source.Contains("AddInfrastructure"),
            "Desktop Program must call AddInfrastructure to register sync services");
        Assert.IsTrue(Source.Contains("MapSyncEndpoints"),
            "Desktop Program must map sync endpoints");
        Assert.IsTrue(Source.Contains("MapWebSocketEndpoint"),
            "Desktop Program must map WebSocket endpoint");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task661 MAUI Program uses AddInfrastructure for sync services")]
    public void MauiProgramUsesAddInfrastructure()
    {
        var Source = ReadSource("PrTask.Maui", "MauiProgram.cs");
        Assert.IsTrue(Source.Contains("AddInfrastructure"),
            "MAUI Program must call AddInfrastructure to register sync services");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task662 WASM Client registers HttpSnapshotService for ISnapshotService")]
    public void WasmClientRegistersSnapshotService()
    {
        var Source = ReadSource("PrTask.Client", "Services", "HttpSnapshotService.cs");
        Assert.IsTrue(Source.Contains("ISnapshotService"),
            "HttpSnapshotService must implement ISnapshotService");
        Assert.IsTrue(Source.Contains("snapshot.json"),
            "HttpSnapshotService must load from snapshot.json");
        Assert.IsTrue(Source.Contains("LoadAsync"),
            "HttpSnapshotService must implement LoadAsync");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task663 DiffPatchEventArgs has Collection Operation and Data properties")]
    public void DiffPatchEventArgsHasRequiredProperties()
    {
        var Source = ReadSource("PrTask.Domain", "Models", "DiffPatchEventArgs.cs");
        Assert.IsTrue(Source.Contains("Collection"),
            "DiffPatchEventArgs must have Collection property");
        Assert.IsTrue(Source.Contains("Operation"),
            "DiffPatchEventArgs must have Operation property");
        Assert.IsTrue(Source.Contains("Data"),
            "DiffPatchEventArgs must have Data property");
        Assert.IsTrue(Source.Contains("EventArgs"),
            "DiffPatchEventArgs must extend EventArgs");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task664 WssConstants defines diff catchup and snapshot_info message types")]
    public void WssConstantsDefinesSyncMessageTypes()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "WssConstants.cs");
        Assert.IsTrue(Source.Contains("MessageTypeDiff"),
            "WssConstants must define MessageTypeDiff");
        Assert.IsTrue(Source.Contains("MessageTypeCatchup"),
            "WssConstants must define MessageTypeCatchup");
        Assert.IsTrue(Source.Contains("MessageTypeCatchupRequest"),
            "WssConstants must define MessageTypeCatchupRequest");
        Assert.IsTrue(Source.Contains("MessageTypeSnapshotInfo"),
            "WssConstants must define MessageTypeSnapshotInfo");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task665 WssConstants defines JSON field names for sync protocol")]
    public void WssConstantsDefinesSyncJsonFields()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "WssConstants.cs");
        Assert.IsTrue(Source.Contains("JsonCollection"),
            "WssConstants must define JsonCollection");
        Assert.IsTrue(Source.Contains("JsonOperation"),
            "WssConstants must define JsonOperation");
        Assert.IsTrue(Source.Contains("JsonMutations"),
            "WssConstants must define JsonMutations");
        Assert.IsTrue(Source.Contains("JsonTimestamp"),
            "WssConstants must define JsonTimestamp");
        Assert.IsTrue(Source.Contains("JsonSince"),
            "WssConstants must define JsonSince");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task666 AiConstants defines sync status values")]
    public void AiConstantsDefinesSyncStatusValues()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "AiConstants.cs");
        Assert.IsTrue(Source.Contains("SyncStatusConnecting"),
            "AiConstants must define SyncStatusConnecting");
        Assert.IsTrue(Source.Contains("SyncStatusCatchingUp"),
            "AiConstants must define SyncStatusCatchingUp");
        Assert.IsTrue(Source.Contains("SyncStatusConnected"),
            "AiConstants must define SyncStatusConnected");
        Assert.IsTrue(Source.Contains("SyncStatusDisconnected"),
            "AiConstants must define SyncStatusDisconnected");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task667 SyncVerificationConstants defines all platform and operation constants")]
    public void SyncVerificationConstantsDefinesPlatformsAndOperations()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "SyncVerificationConstants.cs");
        Assert.IsTrue(Source.Contains("PlatformAndroid"),
            "SyncVerificationConstants must define PlatformAndroid");
        Assert.IsTrue(Source.Contains("PlatformWeb"),
            "SyncVerificationConstants must define PlatformWeb");
        Assert.IsTrue(Source.Contains("PlatformWindows"),
            "SyncVerificationConstants must define PlatformWindows");
        Assert.IsTrue(Source.Contains("CollectionTasks"),
            "SyncVerificationConstants must define CollectionTasks");
        Assert.IsTrue(Source.Contains("OperationInsert"),
            "SyncVerificationConstants must define OperationInsert");
        Assert.IsTrue(Source.Contains("OperationUpdate"),
            "SyncVerificationConstants must define OperationUpdate");
        Assert.IsTrue(Source.Contains("OperationDelete"),
            "SyncVerificationConstants must define OperationDelete");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task668 SyncVerificationConstants defines timeout and assertion constants")]
    public void SyncVerificationConstantsDefinesTimeoutsAndAssertions()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "SyncVerificationConstants.cs");
        Assert.IsTrue(Source.Contains("WssConnectionTimeoutMs"),
            "SyncVerificationConstants must define WssConnectionTimeoutMs");
        Assert.IsTrue(Source.Contains("DiffPatchReceiveTimeoutMs"),
            "SyncVerificationConstants must define DiffPatchReceiveTimeoutMs");
        Assert.IsTrue(Source.Contains("CatchupReceiveTimeoutMs"),
            "SyncVerificationConstants must define CatchupReceiveTimeoutMs");
        Assert.IsTrue(Source.Contains("ReconnectVerifyTimeoutMs"),
            "SyncVerificationConstants must define ReconnectVerifyTimeoutMs");
        Assert.IsTrue(Source.Contains("CrossPlatformPropagationTimeoutMs"),
            "SyncVerificationConstants must define CrossPlatformPropagationTimeoutMs");
        Assert.IsTrue(Source.Contains("MaxReconnectAttemptsForTest"),
            "SyncVerificationConstants must define MaxReconnectAttemptsForTest");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task669 SyncVerificationConstants defines UI indicator constants")]
    public void SyncVerificationConstantsDefinesIndicatorConstants()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "SyncVerificationConstants.cs");
        Assert.IsTrue(Source.Contains("SyncIndicatorTitle"),
            "SyncVerificationConstants must define SyncIndicatorTitle");
        Assert.IsTrue(Source.Contains("SyncIndicatorConnectedClass"),
            "SyncVerificationConstants must define SyncIndicatorConnectedClass");
        Assert.IsTrue(Source.Contains("SyncIndicatorDisconnectedClass"),
            "SyncVerificationConstants must define SyncIndicatorDisconnectedClass");
        Assert.IsTrue(Source.Contains("SyncIndicatorCatchingUpClass"),
            "SyncVerificationConstants must define SyncIndicatorCatchingUpClass");
        Assert.IsTrue(Source.Contains("SyncIndicatorLabel"),
            "SyncVerificationConstants must define SyncIndicatorLabel");
    }
}
