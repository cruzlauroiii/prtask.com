namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0010\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\u000bH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lp2567a5ec/pfd9160bb/pf2af31f4;", "Lp2567a5ec/pfd9160bb/pc1bedd57;", "router", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;", "<init>", "(Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;)V", "getWebobjectScreen", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p2fc3359e;", "url", "", "back", "", "feature-web-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf2af31f4 : p2567a5ec.pfd9160bb.pc1bedd57 {
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 fccc11528;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 fdee57034;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 ff3395cd5;

    public pf2af31f4(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 router) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.ff3395cd5 = router;
    }

    public override void Back() {
        this.ff3395cd5.exit();
    }

    public override p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e GetWebobjectScreen(java.lang.string url) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(url, "url");
        return p2567a5ec.pfd9160bb.p7b5baa06.f76425f17.WebobjectScreen(url);
    }
}

