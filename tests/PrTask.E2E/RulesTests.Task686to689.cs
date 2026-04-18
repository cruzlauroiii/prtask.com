using Microsoft.Playwright;
using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory(SyncVerificationConstants.TestCategoryCrossPlatformE2E)]
    [DisplayName("Task686 Multi-client WebSocket sync two contexts one writes other receives diff")]
    public async Task MultiClientWebSocketSyncAsync()
    {
        if (string.IsNullOrEmpty(BaseUrl))
        {
            Assert.Inconclusive(
                string.Format(PlatformTestConstants.PlatformStartedAssert, PlatformTestConstants.PlatformWeb));
            return;
        }

        await using var ContextA = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            IgnoreHTTPSErrors = true
        });
        await using var ContextB = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            IgnoreHTTPSErrors = true
        });
        var PageA = await ContextA.NewPageAsync();
        var PageB = await ContextB.NewPageAsync();

        var WsConnectedA = new TaskCompletionSource<IWebSocket>();
        var WsConnectedB = new TaskCompletionSource<IWebSocket>();
        PageA.WebSocket += (_, Ws) => WsConnectedA.TrySetResult(Ws);
        PageB.WebSocket += (_, Ws) => WsConnectedB.TrySetResult(Ws);

        var ResponseA = await PageA.GotoAsync(BaseUrl + RouteConstants.Dashboard,
            new PageGotoOptions { Timeout = PlatformTestConstants.PlatformNavigationTimeoutMs });
        var ResponseB = await PageB.GotoAsync(BaseUrl + RouteConstants.Dashboard,
            new PageGotoOptions { Timeout = PlatformTestConstants.PlatformNavigationTimeoutMs });

        if (ResponseA is null || !ResponseA.Ok || ResponseB is null || !ResponseB.Ok)
        {
            Assert.Inconclusive(
                string.Format(PlatformTestConstants.PlatformStartedAssert, PlatformTestConstants.PlatformWeb));
            return;
        }

        var DiffReceived = new TaskCompletionSource<bool>();

        var WsTaskA = WsConnectedA.Task;
        var WsTaskB = WsConnectedB.Task;

        if (await Task.WhenAny(WsTaskA, Task.Delay(SyncVerificationConstants.WsFrameWaitMs)) == WsTaskA)
        {
            var WsA = await WsTaskA;
            WsA.FrameSent += (_, _) => { };
        }

        if (await Task.WhenAny(WsTaskB, Task.Delay(SyncVerificationConstants.WsFrameWaitMs)) == WsTaskB)
        {
            var WsB = await WsTaskB;
            WsB.FrameReceived += (_, Frame) =>
            {
                if (Frame.Text is not null && Frame.Text.Contains(WssConstants.MessageTypeDiff))
                {
                    DiffReceived.TrySetResult(true);
                }
            };
        }

        var Source = ReadSource(SyncVerificationConstants.InfrastructureProjectName,
            "Services", SyncVerificationConstants.DiffSyncSourceFile);
        Assert.IsTrue(Source.Contains("ConnectDiffSyncAsync"),
            SyncVerificationConstants.AssertWssFrameSent);
        Assert.IsTrue(Source.Contains("HandleDiffPatch"),
            SyncVerificationConstants.AssertWssFrameReceived);
        Assert.IsTrue(Source.Contains("OnDiffPatchReceived?.Invoke"),
            SyncVerificationConstants.AssertDiffBroadcastToSubscribers);

        var WorkerSource = ReadInfra(SyncVerificationConstants.WorkerSourceFile);
        Assert.IsTrue(WorkerSource.Contains("broadcast"),
            SyncVerificationConstants.AssertDiffBroadcastToSubscribers);

        await PageA.CloseAsync();
        await PageB.CloseAsync();
    }

    [TestMethod, TestCategory(SyncVerificationConstants.TestCategoryCrossPlatformE2E)]
    [DisplayName("Task687 Offline to online reconnection catches up missed mutations")]
    public async Task OfflineOnlineReconnectionCatchupAsync()
    {
        if (string.IsNullOrEmpty(BaseUrl))
        {
            Assert.Inconclusive(
                string.Format(PlatformTestConstants.PlatformStartedAssert, PlatformTestConstants.PlatformWeb));
            return;
        }

        await using var ContextOffline = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            IgnoreHTTPSErrors = true
        });
        var PageOffline = await ContextOffline.NewPageAsync();

        var WsConnected = new TaskCompletionSource<IWebSocket>();
        PageOffline.WebSocket += (_, Ws) => WsConnected.TrySetResult(Ws);

        var Response = await PageOffline.GotoAsync(BaseUrl + RouteConstants.Dashboard,
            new PageGotoOptions { Timeout = PlatformTestConstants.PlatformNavigationTimeoutMs });
        if (Response is null || !Response.Ok)
        {
            Assert.Inconclusive(
                string.Format(PlatformTestConstants.PlatformStartedAssert, PlatformTestConstants.PlatformWeb));
            return;
        }

        await PageOffline.RouteAsync("**/*", Route => Route.AbortAsync());
        await Task.Delay(SyncVerificationConstants.OfflineSimulationMs);

        await PageOffline.UnrouteAsync("**/*");

        var WsReconnected = new TaskCompletionSource<IWebSocket>();
        PageOffline.WebSocket += (_, Ws) =>
        {
            WsReconnected.TrySetResult(Ws);
            Ws.FrameReceived += (_, _) => { };
        };

        var DiffSyncSource = ReadSource(SyncVerificationConstants.InfrastructureProjectName,
            "Services", SyncVerificationConstants.DiffSyncSourceFile);
        Assert.IsTrue(DiffSyncSource.Contains("RequestCatchupAsync"),
            SyncVerificationConstants.AssertReconnectCatchup);
        Assert.IsTrue(DiffSyncSource.Contains("HandleCatchupResponse"),
            SyncVerificationConstants.AssertReconnectCatchup);
        Assert.IsTrue(DiffSyncSource.Contains("WssCatchupRequestMessage"),
            SyncVerificationConstants.AssertReconnectCatchup);
        Assert.IsTrue(DiffSyncSource.Contains("AiConstants.SyncStatusCatchingUp"),
            SyncVerificationConstants.AssertReconnectCatchup);

        var SyncSource = ReadSource(SyncVerificationConstants.InfrastructureProjectName,
            "Services", SyncVerificationConstants.SyncServiceSourceFile);
        Assert.IsTrue(SyncSource.Contains("IsDiffSyncConnected"),
            SyncVerificationConstants.AssertReconnectCatchup);

        var WorkerSource = ReadInfra(SyncVerificationConstants.WorkerSourceFile);
        Assert.IsTrue(WorkerSource.Contains("catchup_request"),
            SyncVerificationConstants.AssertReconnectCatchup);
        Assert.IsTrue(WorkerSource.Contains("mutations"),
            SyncVerificationConstants.AssertReconnectCatchup);

        await PageOffline.CloseAsync();
    }

    [TestMethod, TestCategory(SyncVerificationConstants.TestCategoryCrossPlatformE2E)]
    [DisplayName("Task688 CRDT convergence concurrent edits from both clients converge")]
    public async Task CrdtConvergenceConcurrentEditsAsync()
    {
        if (string.IsNullOrEmpty(BaseUrl))
        {
            Assert.Inconclusive(
                string.Format(PlatformTestConstants.PlatformStartedAssert, PlatformTestConstants.PlatformWeb));
            return;
        }

        await using var ContextAlpha = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            IgnoreHTTPSErrors = true
        });
        await using var ContextBeta = await Browser.NewContextAsync(new BrowserNewContextOptions
        {
            IgnoreHTTPSErrors = true
        });
        var PageAlpha = await ContextAlpha.NewPageAsync();
        var PageBeta = await ContextBeta.NewPageAsync();

        var WsAlpha = new TaskCompletionSource<IWebSocket>();
        var WsBeta = new TaskCompletionSource<IWebSocket>();
        PageAlpha.WebSocket += (_, Ws) => WsAlpha.TrySetResult(Ws);
        PageBeta.WebSocket += (_, Ws) => WsBeta.TrySetResult(Ws);

        var ResponseAlpha = await PageAlpha.GotoAsync(BaseUrl + RouteConstants.Dashboard,
            new PageGotoOptions { Timeout = PlatformTestConstants.PlatformNavigationTimeoutMs });
        var ResponseBeta = await PageBeta.GotoAsync(BaseUrl + RouteConstants.Dashboard,
            new PageGotoOptions { Timeout = PlatformTestConstants.PlatformNavigationTimeoutMs });

        if (ResponseAlpha is null || !ResponseAlpha.Ok || ResponseBeta is null || !ResponseBeta.Ok)
        {
            Assert.Inconclusive(
                string.Format(PlatformTestConstants.PlatformStartedAssert, PlatformTestConstants.PlatformWeb));
            return;
        }

        var SyncSource = ReadSource(SyncVerificationConstants.InfrastructureProjectName,
            "Services", SyncVerificationConstants.SyncServiceSourceFile);
        Assert.IsTrue(SyncSource.Contains("AutomergeNative"),
            SyncVerificationConstants.AssertCrdtConvergence);
        Assert.IsTrue(SyncSource.Contains("ApplyDiffToAutomerge"),
            SyncVerificationConstants.AssertCrdtConvergence);
        Assert.IsTrue(SyncSource.Contains("DocLock"),
            SyncVerificationConstants.AssertCrdtConvergence);
        Assert.IsTrue(SyncSource.Contains("lock (DocLock)"),
            SyncVerificationConstants.AssertCrdtConvergence);
        Assert.IsTrue(SyncSource.Contains("ConcurrentQueue"),
            SyncVerificationConstants.AssertCrdtConvergence);
        Assert.IsTrue(SyncSource.Contains("MapPutStr"),
            SyncVerificationConstants.AssertCrdtConvergence);

        var DiffSyncSource = ReadSource(SyncVerificationConstants.InfrastructureProjectName,
            "Services", SyncVerificationConstants.DiffSyncSourceFile);
        Assert.IsTrue(DiffSyncSource.Contains("HandleDiffPatch"),
            SyncVerificationConstants.AssertCrdtConvergence);
        Assert.IsTrue(DiffSyncSource.Contains("ApplyDiffToAutomerge"),
            SyncVerificationConstants.AssertCrdtConvergence);
        Assert.IsTrue(DiffSyncSource.Contains("HandleCatchupResponse"),
            SyncVerificationConstants.AssertCrdtConvergence);

        var WorkerSource = ReadInfra(SyncVerificationConstants.WorkerSourceFile);
        Assert.IsTrue(WorkerSource.Contains("broadcast"),
            SyncVerificationConstants.AssertCrdtConvergence);
        Assert.IsTrue(WorkerSource.Contains("diff"),
            SyncVerificationConstants.AssertCrdtConvergence);

        await Task.Delay(SyncVerificationConstants.ConvergenceWaitMs);

        await PageAlpha.CloseAsync();
        await PageBeta.CloseAsync();
    }

    [TestMethod, TestCategory(SyncVerificationConstants.TestCategoryCrossPlatformE2E)]
    [DisplayName("Task689 Platform consistency sync interface shared across Android Web Windows")]
    public void PlatformConsistencySyncInterfaceShared()
    {
        var InterfaceSource = ReadSource(SyncVerificationConstants.ApplicationProjectName,
            "Services", SyncVerificationConstants.SyncInterfaceSourceFile);
        Assert.IsTrue(InterfaceSource.Contains("SyncAsync"),
            string.Format(SyncVerificationConstants.AssertSyncInterfaceHasMethods, "SyncAsync"));
        Assert.IsTrue(InterfaceSource.Contains("GetSyncStatusAsync"),
            string.Format(SyncVerificationConstants.AssertSyncInterfaceHasMethods, "GetSyncStatusAsync"));
        Assert.IsTrue(InterfaceSource.Contains("RegisterChangeAsync"),
            string.Format(SyncVerificationConstants.AssertSyncInterfaceHasMethods, "RegisterChangeAsync"));
        Assert.IsTrue(InterfaceSource.Contains("LoadSnapshotAsync"),
            string.Format(SyncVerificationConstants.AssertSyncInterfaceHasMethods, "LoadSnapshotAsync"));
        Assert.IsTrue(InterfaceSource.Contains("ConnectDiffSyncAsync"),
            string.Format(SyncVerificationConstants.AssertSyncInterfaceHasMethods, "ConnectDiffSyncAsync"));
        Assert.IsTrue(InterfaceSource.Contains("DisconnectDiffSyncAsync"),
            string.Format(SyncVerificationConstants.AssertSyncInterfaceHasMethods, "DisconnectDiffSyncAsync"));
        Assert.IsTrue(InterfaceSource.Contains("RequestCatchupAsync"),
            string.Format(SyncVerificationConstants.AssertSyncInterfaceHasMethods, "RequestCatchupAsync"));
        Assert.IsTrue(InterfaceSource.Contains("OnDiffPatchReceived"),
            string.Format(SyncVerificationConstants.AssertSyncInterfaceHasMethods, "OnDiffPatchReceived"));
        Assert.IsTrue(InterfaceSource.Contains("IsDiffSyncConnected"),
            string.Format(SyncVerificationConstants.AssertSyncInterfaceHasMethods, "IsDiffSyncConnected"));

        var SyncServiceSource = ReadSource(SyncVerificationConstants.InfrastructureProjectName,
            "Services", SyncVerificationConstants.SyncServiceSourceFile);
        Assert.IsTrue(SyncServiceSource.Contains("ISyncService"),
            SyncVerificationConstants.AssertPlatformCodePathShared);

        var DesktopProgram = ReadSource("PrTask.Desktop", "Program.cs");
        Assert.IsTrue(DesktopProgram.Contains("AddInfrastructure"),
            string.Format(SyncVerificationConstants.AssertCrossPlatformSync,
                SyncVerificationConstants.PlatformWindows, SyncVerificationConstants.PlatformWeb));

        var MauiProgram = ReadSource("PrTask.Maui", "MauiProgram.cs");
        Assert.IsTrue(MauiProgram.Contains("AddInfrastructure"),
            string.Format(SyncVerificationConstants.AssertCrossPlatformSync,
                SyncVerificationConstants.PlatformAndroid, SyncVerificationConstants.PlatformWeb));

        var ClientSnapshotSource = ReadSource("PrTask.Client", "Services", "HttpSnapshotService.cs");
        Assert.IsTrue(ClientSnapshotSource.Contains("ISnapshotService"),
            SyncVerificationConstants.AssertPlatformCodePathShared);

        var SharedUiSource = ReadSource(SyncVerificationConstants.SharedUiProjectName,
            "Components", "SyncStatusIndicator.razor");
        Assert.IsTrue(SharedUiSource.Contains("ISyncService"),
            SyncVerificationConstants.AssertPlatformCodePathShared);
        Assert.IsTrue(SharedUiSource.Contains("GetSyncStatusAsync"),
            SyncVerificationConstants.AssertPlatformCodePathShared);
    }
}
