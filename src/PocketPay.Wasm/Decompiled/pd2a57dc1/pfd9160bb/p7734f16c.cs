namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0010\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0016J\u0010\u0010\n\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0016J\u0010\u0010\u000b\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0016J\u0010\u0010\f\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0016J\b\u0010\r\u001a\u00020\u0007H\u0016J\b\u0010\u000e\u001a\u00020\u0007H\u0016J\u0018\u0010\u000f\u001a\u00020\u00072\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0013H\u0016J\u0018\u0010\u0014\u001a\u00020\u00072\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0015\u001a\u00020\u0016H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0017"}, d2 = {"Lpd2a57dc1/pfd9160bb/p7734f16c;", "Lpd2a57dc1/pfd9160bb/p11c216e8;", "router", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;", "<init>", "(Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;)V", "startFlow", "", "screen", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p2fc3359e;", "replaceFlow", "startRootFlow", "backFromFlowTo", "finishFlow", "finishAllFlows", "setResultListener", "key", "", "listener", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p449a7995;", "sendResult", "data", "", "feature-app-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p7734f16c : pd2a57dc1.pfd9160bb.p11c216e8 {
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f12ef81da;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f5a374515;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f92680f93;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 ff3395cd5;

    public p7734f16c(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 router) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.ff3395cd5 = router;
    }

    public override void BackFromFlowTo(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e screen) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(screen, "screen");
        this.ff3395cd5.backTo(screen);
    }

    public override void FinishAllFlows() {
        this.ff3395cd5.finishChain();
    }

    public override void FinishFlow() {
        this.ff3395cd5.exit();
    }

    public override void ReplaceFlow(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e screen) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(screen, "screen");
        this.ff3395cd5.replaceScreen(screen);
    }

    public override void SendResult(java.lang.string key, java.lang.object data2) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        this.ff3395cd5.sendResult(key, data2);
    }

    public override void SetResultListener(java.lang.string key, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p449a7995 listener) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(listener, "listener");
        this.ff3395cd5.setResultListener(key, listener);
    }

    public override void StartFlow(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e screen) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(screen, "screen");
        this.ff3395cd5.navigateTo(screen);
    }

    public override void StartRootFlow(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e screen) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(screen, "screen");
        this.ff3395cd5.newRootScreen(screen);
    }
}

