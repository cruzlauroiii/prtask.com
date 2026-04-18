namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task634 ISyncService defines SyncAsync method")]
    public void SyncServiceInterfaceDefinesSyncAsync()
    {
        var Source = ReadSource("PrTask.Application", "Services", "ISyncService.cs");
        Assert.IsTrue(Source.Contains("SyncAsync"),
            "ISyncService must define SyncAsync method");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task635 ISyncService defines GetSyncStatusAsync method")]
    public void SyncServiceInterfaceDefinesGetSyncStatusAsync()
    {
        var Source = ReadSource("PrTask.Application", "Services", "ISyncService.cs");
        Assert.IsTrue(Source.Contains("GetSyncStatusAsync"),
            "ISyncService must define GetSyncStatusAsync method");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task636 ISyncService defines RegisterChangeAsync method")]
    public void SyncServiceInterfaceDefinesRegisterChangeAsync()
    {
        var Source = ReadSource("PrTask.Application", "Services", "ISyncService.cs");
        Assert.IsTrue(Source.Contains("RegisterChangeAsync"),
            "ISyncService must define RegisterChangeAsync method");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task637 ISyncService defines LoadSnapshotAsync method")]
    public void SyncServiceInterfaceDefinesLoadSnapshotAsync()
    {
        var Source = ReadSource("PrTask.Application", "Services", "ISyncService.cs");
        Assert.IsTrue(Source.Contains("LoadSnapshotAsync"),
            "ISyncService must define LoadSnapshotAsync method");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task638 ISyncService defines ConnectDiffSyncAsync method")]
    public void SyncServiceInterfaceDefinesConnectDiffSyncAsync()
    {
        var Source = ReadSource("PrTask.Application", "Services", "ISyncService.cs");
        Assert.IsTrue(Source.Contains("ConnectDiffSyncAsync"),
            "ISyncService must define ConnectDiffSyncAsync method");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task639 ISyncService defines DisconnectDiffSyncAsync method")]
    public void SyncServiceInterfaceDefinesDisconnectDiffSyncAsync()
    {
        var Source = ReadSource("PrTask.Application", "Services", "ISyncService.cs");
        Assert.IsTrue(Source.Contains("DisconnectDiffSyncAsync"),
            "ISyncService must define DisconnectDiffSyncAsync method");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task640 ISyncService defines RequestCatchupAsync method")]
    public void SyncServiceInterfaceDefinesRequestCatchupAsync()
    {
        var Source = ReadSource("PrTask.Application", "Services", "ISyncService.cs");
        Assert.IsTrue(Source.Contains("RequestCatchupAsync"),
            "ISyncService must define RequestCatchupAsync method");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task641 ISyncService defines OnDiffPatchReceived event")]
    public void SyncServiceInterfaceDefinesOnDiffPatchReceived()
    {
        var Source = ReadSource("PrTask.Application", "Services", "ISyncService.cs");
        Assert.IsTrue(Source.Contains("OnDiffPatchReceived"),
            "ISyncService must define OnDiffPatchReceived event");
        Assert.IsTrue(Source.Contains("DiffPatchEventArgs"),
            "OnDiffPatchReceived must use DiffPatchEventArgs");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task642 ISyncService defines IsDiffSyncConnected property")]
    public void SyncServiceInterfaceDefinesIsDiffSyncConnected()
    {
        var Source = ReadSource("PrTask.Application", "Services", "ISyncService.cs");
        Assert.IsTrue(Source.Contains("IsDiffSyncConnected"),
            "ISyncService must define IsDiffSyncConnected property");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task643 IWssConnectionService defines ConnectAsync and IsConnected")]
    public void WssConnectionServiceInterfaceDefinesConnectAndStatus()
    {
        var Source = ReadSource("PrTask.Application", "Services", "IWssConnectionService.cs");
        Assert.IsTrue(Source.Contains("ConnectAsync"),
            "IWssConnectionService must define ConnectAsync");
        Assert.IsTrue(Source.Contains("DisconnectAsync"),
            "IWssConnectionService must define DisconnectAsync");
        Assert.IsTrue(Source.Contains("QueryAsync"),
            "IWssConnectionService must define QueryAsync");
        Assert.IsTrue(Source.Contains("SendAsync"),
            "IWssConnectionService must define SendAsync");
        Assert.IsTrue(Source.Contains("SubscribeAsync"),
            "IWssConnectionService must define SubscribeAsync");
        Assert.IsTrue(Source.Contains("IsConnected"),
            "IWssConnectionService must define IsConnected");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task644 ISnapshotService defines LoadAsync method")]
    public void SnapshotServiceInterfaceDefinesLoadAsync()
    {
        var Source = ReadSource("PrTask.Application", "Services", "ISnapshotService.cs");
        Assert.IsTrue(Source.Contains("LoadAsync"),
            "ISnapshotService must define LoadAsync");
        Assert.IsTrue(Source.Contains("DataSnapshot"),
            "ISnapshotService must return DataSnapshot");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task645 SyncService implementation uses automerge native interop")]
    public void SyncServiceImplementationUsesAutomergeNative()
    {
        var Source = ReadSource("PrTask.Infrastructure", "Services", "SyncService.cs");
        Assert.IsTrue(Source.Contains("AutomergeNative"),
            "SyncService must use AutomergeNative for CRDT sync");
        Assert.IsTrue(Source.Contains("NativeAvailable"),
            "SyncService must check NativeAvailable before automerge operations");
        Assert.IsTrue(Source.Contains("ConcurrentQueue"),
            "SyncService must use ConcurrentQueue for pending changes");
        Assert.IsTrue(Source.Contains("ISyncService"),
            "SyncService must implement ISyncService");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task646 SyncService.DiffSync handles diff patch and catchup messages")]
    public void SyncServiceDiffSyncHandlesMessages()
    {
        var Source = ReadSource("PrTask.Infrastructure", "Services", "SyncService.DiffSync.cs");
        Assert.IsTrue(Source.Contains("HandleDiffPatch"),
            "DiffSync must handle diff patch messages");
        Assert.IsTrue(Source.Contains("HandleCatchupResponse"),
            "DiffSync must handle catchup response messages");
        Assert.IsTrue(Source.Contains("HandleSnapshotInfo"),
            "DiffSync must handle snapshot info messages");
        Assert.IsTrue(Source.Contains("ReceiveLoopAsync"),
            "DiffSync must have a receive loop for WebSocket messages");
        Assert.IsTrue(Source.Contains("ProcessMessage"),
            "DiffSync must have ProcessMessage for message dispatch");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task647 SyncService.DiffSync connects WSS with prtask-db protocol")]
    public void SyncServiceDiffSyncConnectsWithProtocol()
    {
        var Source = ReadSource("PrTask.Infrastructure", "Services", "SyncService.DiffSync.cs");
        Assert.IsTrue(Source.Contains("WssConstants.ProtocolName"),
            "ConnectDiffSyncAsync must use WssConstants.ProtocolName subprotocol");
        Assert.IsTrue(Source.Contains("ClientWebSocket"),
            "ConnectDiffSyncAsync must use ClientWebSocket");
        Assert.IsTrue(Source.Contains("AddSubProtocol"),
            "ConnectDiffSyncAsync must add subprotocol to WebSocket options");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task648 SyncService.DiffSync fires OnDiffPatchReceived event")]
    public void SyncServiceDiffSyncFiresDiffEvent()
    {
        var Source = ReadSource("PrTask.Infrastructure", "Services", "SyncService.DiffSync.cs");
        Assert.IsTrue(Source.Contains("OnDiffPatchReceived?.Invoke"),
            "HandleDiffPatch must fire OnDiffPatchReceived event");
        Assert.IsTrue(Source.Contains("DiffPatchEventArgs"),
            "DiffPatch handler must use DiffPatchEventArgs");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task649 SyncService.DiffSync applies diff to automerge document")]
    public void SyncServiceDiffSyncAppliesAutomerge()
    {
        var Source = ReadSource("PrTask.Infrastructure", "Services", "SyncService.DiffSync.cs");
        Assert.IsTrue(Source.Contains("ApplyDiffToAutomerge"),
            "DiffSync must call ApplyDiffToAutomerge");
        var MainSource = ReadSource("PrTask.Infrastructure", "Services", "SyncService.cs");
        Assert.IsTrue(MainSource.Contains("ApplyDiffToAutomerge"),
            "SyncService must implement ApplyDiffToAutomerge method");
        Assert.IsTrue(MainSource.Contains("MapPutStr"),
            "ApplyDiffToAutomerge must use AutomergeNative.MapPutStr");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task650 SyncService.DiffSync requests catchup with since timestamp")]
    public void SyncServiceDiffSyncRequestsCatchup()
    {
        var Source = ReadSource("PrTask.Infrastructure", "Services", "SyncService.DiffSync.cs");
        Assert.IsTrue(Source.Contains("RequestCatchupAsync"),
            "DiffSync must implement RequestCatchupAsync");
        Assert.IsTrue(Source.Contains("WssCatchupRequestMessage"),
            "RequestCatchupAsync must use FormatStrings.WssCatchupRequestMessage");
        Assert.IsTrue(Source.Contains("SyncStatusCatchingUp") || Source.Contains("AiConstants.SyncStatusCatchingUp"),
            "RequestCatchupAsync must set status to CatchingUp");
    }

    [TestMethod, TestCategory("SyncVerification")]
    [DisplayName("Task651 SyncService.DiffSync loads snapshot via HTTP")]
    public void SyncServiceDiffSyncLoadsSnapshot()
    {
        var Source = ReadSource("PrTask.Infrastructure", "Services", "SyncService.DiffSync.cs");
        Assert.IsTrue(Source.Contains("LoadSnapshotAsync"),
            "DiffSync must implement LoadSnapshotAsync");
        Assert.IsTrue(Source.Contains("SnapshotEndpoint"),
            "LoadSnapshotAsync must use FormatStrings.SnapshotEndpoint");
        Assert.IsTrue(Source.Contains("SnapshotTimestamp"),
            "LoadSnapshotAsync must parse and store SnapshotTimestamp");
    }
}
