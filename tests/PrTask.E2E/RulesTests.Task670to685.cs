namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("CrossPlatformSync")]
    [DisplayName("Task670 SyncService disconnect cleans up WebSocket and CTS")]
    public void SyncServiceDisconnectCleansUp()
    {
        var Source = ReadSource("PrTask.Infrastructure", "Services", "SyncService.DiffSync.cs");
        Assert.IsTrue(Source.Contains("DisconnectDiffSyncAsync"),
            "SyncService must implement DisconnectDiffSyncAsync");
        Assert.IsTrue(Source.Contains("CloseAsync"),
            "DisconnectDiffSyncAsync must close WebSocket with CloseAsync");
        Assert.IsTrue(Source.Contains("NormalClosure"),
            "DisconnectDiffSyncAsync must use NormalClosure status");
        Assert.IsTrue(Source.Contains("CancelAsync") || Source.Contains("Cancel()"),
            "DisconnectDiffSyncAsync must cancel the CancellationTokenSource");
    }

    [TestMethod, TestCategory("CrossPlatformSync")]
    [DisplayName("Task671 SyncService Dispose frees automerge document and WebSocket")]
    public void SyncServiceDisposeFreesResources()
    {
        var Source = ReadSource("PrTask.Infrastructure", "Services", "SyncService.cs");
        Assert.IsTrue(Source.Contains("IDisposable"),
            "SyncService must implement IDisposable");
        Assert.IsTrue(Source.Contains("AutomergeNative.Free"),
            "Dispose must free automerge document via AutomergeNative.Free");
        Assert.IsTrue(Source.Contains("DiffSocket?.Dispose"),
            "Dispose must dispose DiffSocket");
        Assert.IsTrue(Source.Contains("DiffCts?.Dispose"),
            "Dispose must dispose DiffCts");
    }

    [TestMethod, TestCategory("CrossPlatformSync")]
    [DisplayName("Task672 SyncService receive loop handles close and cancellation gracefully")]
    public void SyncServiceReceiveLoopHandlesCloseAndCancel()
    {
        var Source = ReadSource("PrTask.Infrastructure", "Services", "SyncService.DiffSync.cs");
        Assert.IsTrue(Source.Contains("WebSocketMessageType.Close"),
            "Receive loop must handle Close message type");
        Assert.IsTrue(Source.Contains("OperationCanceledException"),
            "Receive loop must catch OperationCanceledException");
        Assert.IsTrue(Source.Contains("WebSocketException"),
            "Receive loop must catch WebSocketException");
        Assert.IsTrue(Source.Contains("SyncStatusDisconnected") || Source.Contains("AiConstants.SyncStatusDisconnected"),
            "Receive loop must set status to Disconnected in finally block");
    }

    [TestMethod, TestCategory("CrossPlatformSync")]
    [DisplayName("Task673 SyncService catchup response applies mutations and fires events")]
    public void SyncServiceCatchupAppliesMutationsAndFiresEvents()
    {
        var Source = ReadSource("PrTask.Infrastructure", "Services", "SyncService.DiffSync.cs");
        Assert.IsTrue(Source.Contains("HandleCatchupResponse"),
            "SyncService must implement HandleCatchupResponse");
        Assert.IsTrue(Source.Contains("EnumerateArray"),
            "HandleCatchupResponse must enumerate mutations array");
        Assert.IsTrue(Source.Contains("ApplyDiffToAutomerge"),
            "HandleCatchupResponse must apply each mutation to automerge");
        Assert.IsTrue(Source.Contains("OnDiffPatchReceived?.Invoke"),
            "HandleCatchupResponse must fire OnDiffPatchReceived for each mutation");
    }

    [TestMethod, TestCategory("CrossPlatformSync")]
    [DisplayName("Task674 SyncService message dispatch routes to correct handler")]
    public void SyncServiceMessageDispatchRoutesCorrectly()
    {
        var Source = ReadSource("PrTask.Infrastructure", "Services", "SyncService.DiffSync.cs");
        Assert.IsTrue(Source.Contains("WssConstants.MessageTypeDiff"),
            "ProcessMessage must route diff messages");
        Assert.IsTrue(Source.Contains("WssConstants.MessageTypeCatchup"),
            "ProcessMessage must route catchup messages");
        Assert.IsTrue(Source.Contains("WssConstants.MessageTypeSnapshotInfo"),
            "ProcessMessage must route snapshot_info messages");
        Assert.IsTrue(Source.Contains("switch"),
            "ProcessMessage must use switch for message type routing");
    }

    [TestMethod, TestCategory("CrossPlatformSync")]
    [DisplayName("Task675 SyncEndpoints maps sync execute status and register routes")]
    public void SyncEndpointsMapsAllRoutes()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "SyncEndpoints.cs");
        Assert.IsTrue(Source.Contains("MapPost") && Source.Contains("SyncExecute"),
            "SyncEndpoints must map POST execute route");
        Assert.IsTrue(Source.Contains("MapGet") && Source.Contains("SubStatus"),
            "SyncEndpoints must map GET status route");
        Assert.IsTrue(Source.Contains("MapPost") && Source.Contains("SyncRegister"),
            "SyncEndpoints must map POST register route");
        Assert.IsTrue(Source.Contains("RequireAuthorization"),
            "SyncEndpoints must require authorization");
    }

    [TestMethod, TestCategory("CrossPlatformSync")]
    [DisplayName("Task676 HttpSnapshotService uses snake_case JSON for snapshot")]
    public void HttpSnapshotServiceUsesSnakeCaseJson()
    {
        var Source = ReadSource("PrTask.Client", "Services", "HttpSnapshotService.cs");
        Assert.IsTrue(Source.Contains("SnakeCaseLower"),
            "HttpSnapshotService must use SnakeCaseLower naming policy");
        Assert.IsTrue(Source.Contains("PropertyNameCaseInsensitive"),
            "HttpSnapshotService must set PropertyNameCaseInsensitive");
    }

    [TestMethod, TestCategory("CrossPlatformSync")]
    [DisplayName("Task677 DataSnapshot model has all required collections")]
    public void DataSnapshotModelHasAllCollections()
    {
        var Source = ReadSource("PrTask.Domain", "Models", "DataSnapshot.cs");
        Assert.IsTrue(Source.Contains("Tasks"),
            "DataSnapshot must have Tasks collection");
        Assert.IsTrue(Source.Contains("PullRequests"),
            "DataSnapshot must have PullRequests collection");
        Assert.IsTrue(Source.Contains("Payments"),
            "DataSnapshot must have Payments collection");
        Assert.IsTrue(Source.Contains("GeneratedAt"),
            "DataSnapshot must have GeneratedAt timestamp");
    }

    [TestMethod, TestCategory("CrossPlatformSync")]
    [DisplayName("Task678 SyncStatusIndicator component uses ISyncService")]
    public void SyncStatusIndicatorUsesISyncService()
    {
        var Source = ReadSource("PrTask.SharedUI", "Components", "SyncStatusIndicator.razor");
        Assert.IsTrue(Source.Contains("ISyncService"),
            "SyncStatusIndicator must inject ISyncService");
        Assert.IsTrue(Source.Contains("GetSyncStatusAsync"),
            "SyncStatusIndicator must call GetSyncStatusAsync");
        Assert.IsTrue(Source.Contains("SyncVerificationConstants"),
            "SyncStatusIndicator must use SyncVerificationConstants for CSS classes");
    }

    [TestMethod, TestCategory("CrossPlatformSync")]
    [DisplayName("Task679 SyncStatusIndicator maps status to CSS classes")]
    public void SyncStatusIndicatorMapsCssClasses()
    {
        var Source = ReadSource("PrTask.SharedUI", "Components", "SyncStatusIndicator.razor");
        Assert.IsTrue(Source.Contains("SyncIndicatorConnectedClass"),
            "SyncStatusIndicator must use SyncIndicatorConnectedClass");
        Assert.IsTrue(Source.Contains("SyncIndicatorDisconnectedClass"),
            "SyncStatusIndicator must use SyncIndicatorDisconnectedClass");
        Assert.IsTrue(Source.Contains("SyncIndicatorCatchingUpClass"),
            "SyncStatusIndicator must use SyncIndicatorCatchingUpClass");
        Assert.IsTrue(Source.Contains("SyncIndicatorConnectingClass"),
            "SyncStatusIndicator must use SyncIndicatorConnectingClass");
    }

    [TestMethod, TestCategory("CrossPlatformSync")]
    [DisplayName("Task680 SyncStatusIndicator uses AiConstants for status values")]
    public void SyncStatusIndicatorUsesAiConstantsForStatus()
    {
        var Source = ReadSource("PrTask.SharedUI", "Components", "SyncStatusIndicator.razor");
        Assert.IsTrue(Source.Contains("AiConstants.SyncStatusConnected"),
            "SyncStatusIndicator must use AiConstants.SyncStatusConnected");
        Assert.IsTrue(Source.Contains("AiConstants.SyncStatusConnecting"),
            "SyncStatusIndicator must use AiConstants.SyncStatusConnecting");
        Assert.IsTrue(Source.Contains("AiConstants.SyncStatusCatchingUp"),
            "SyncStatusIndicator must use AiConstants.SyncStatusCatchingUp");
        Assert.IsTrue(Source.Contains("AiConstants.SyncStatusDisconnected"),
            "SyncStatusIndicator must use AiConstants.SyncStatusDisconnected");
    }

    [TestMethod, TestCategory("CrossPlatformSync")]
    [DisplayName("Task681 FormatStrings defines WssCatchupRequestMessage")]
    public void FormatStringsDefinesWssCatchupRequestMessage()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "FormatStrings.cs");
        Assert.IsTrue(Source.Contains("WssCatchupRequestMessage"),
            "FormatStrings must define WssCatchupRequestMessage");
        Assert.IsTrue(Source.Contains("SnapshotEndpoint"),
            "FormatStrings must define SnapshotEndpoint");
        Assert.IsTrue(Source.Contains("SyncChangeKey"),
            "FormatStrings must define SyncChangeKey");
    }

    [TestMethod, TestCategory("CrossPlatformSync")]
    [DisplayName("Task682 SyncService uses DocLock for thread-safe automerge access")]
    public void SyncServiceUsesDocLockForThreadSafety()
    {
        var Source = ReadSource("PrTask.Infrastructure", "Services", "SyncService.cs");
        Assert.IsTrue(Source.Contains("DocLock"),
            "SyncService must use DocLock for thread safety");
        Assert.IsTrue(Source.Contains("lock (DocLock)"),
            "SyncService must lock DocLock when accessing automerge document");
    }

    [TestMethod, TestCategory("CrossPlatformSync")]
    [DisplayName("Task683 SyncService sets auth token header on WSS connection")]
    public void SyncServiceSetsAuthTokenOnWss()
    {
        var Source = ReadSource("PrTask.Infrastructure", "Services", "SyncService.DiffSync.cs");
        Assert.IsTrue(Source.Contains("SetRequestHeader"),
            "ConnectDiffSyncAsync must set auth token request header");
        Assert.IsTrue(Source.Contains("WssConstants.JsonId"),
            "ConnectDiffSyncAsync must use WssConstants.JsonId for header name");
        Assert.IsTrue(Source.Contains("AuthToken"),
            "ConnectDiffSyncAsync must accept AuthToken parameter");
    }

    [TestMethod, TestCategory("CrossPlatformSync")]
    [DisplayName("Task684 SyncService status transitions follow connected lifecycle")]
    public void SyncServiceStatusTransitionsFollowLifecycle()
    {
        var Source = ReadSource("PrTask.Infrastructure", "Services", "SyncService.DiffSync.cs");
        Assert.IsTrue(Source.Contains("AiConstants.SyncStatusConnecting"),
            "ConnectDiffSyncAsync must transition to Connecting status");
        Assert.IsTrue(Source.Contains("AiConstants.SyncStatusConnected"),
            "ConnectDiffSyncAsync must transition to Connected after successful connect");
        Assert.IsTrue(Source.Contains("AiConstants.SyncStatusCatchingUp"),
            "RequestCatchupAsync must transition to CatchingUp status");
        Assert.IsTrue(Source.Contains("AiConstants.SyncStatusDisconnected"),
            "Disconnect and receive loop must transition to Disconnected");
    }

    [TestMethod, TestCategory("CrossPlatformSync")]
    [DisplayName("Task685 SyncService receive loop uses MemoryStream for multi-frame messages")]
    public void SyncServiceReceiveLoopUsesMemoryStream()
    {
        var Source = ReadSource("PrTask.Infrastructure", "Services", "SyncService.DiffSync.cs");
        Assert.IsTrue(Source.Contains("MemoryStream"),
            "Receive loop must use MemoryStream for message buffering");
        Assert.IsTrue(Source.Contains("EndOfMessage"),
            "Receive loop must check EndOfMessage for multi-frame WebSocket messages");
        Assert.IsTrue(Source.Contains("SetLength(0)"),
            "Receive loop must reset MemoryStream between messages");
    }
}
