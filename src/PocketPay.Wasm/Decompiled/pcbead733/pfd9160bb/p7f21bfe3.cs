namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016J\b\u0010\b\u001a\u00020\tH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Lpcbead733/pfd9160bb/p7f21bfe3;", "Lpcbead733/pfd9160bb/p6280b697;", "router", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;", "<init>", "(Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;)V", "startSplashFlow", "", "getSplashFlow", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p2fc3359e;", "feature-splash-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p7f21bfe3 : pcbead733.pfd9160bb.p6280b697 {
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f656b8f53;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f829e004f;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 ff3395cd5;

    public p7f21bfe3(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 router) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.ff3395cd5 = router;
    }

    public override p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e GetSplashFlow() {
        return pcbead733.pfd9160bb.p04a27024.f76425f17.SplashScreen();
    }

    public override void StartSplashFlow() {
        this.ff3395cd5.newRootScreen(pcbead733.pfd9160bb.p04a27024.f76425f17.SplashScreen());
    }
}

