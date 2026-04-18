namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u001a\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\b\u0010\n\u001a\u0004\u0018\u00010\u000bH\u0016J\b\u0010\f\u001a\u00020\u0007H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Lp8a6f5038/pfd9160bb/pe01d414e;", "Lp8a6f5038/pfd9160bb/pd5a8ad07;", "router", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;", "<init>", "(Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;)V", "openPinInput", "", "showPinRoute", "Lpad5f82e8/p07214c67/pfd9160bb/p8ab1a15b;", "deviceId", "", "back", "feature-pin-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pe01d414e : p8a6f5038.pfd9160bb.pd5a8ad07 {
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f06bbb108;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f8b02d2db;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 f9dba57cb;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 ff3395cd5;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 ffef183fd;

    public pe01d414e(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 router) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.ff3395cd5 = router;
    }

    public override void Back() {
        this.ff3395cd5.exit();
    }

    public override void OpenPinInput(pad5f82e8.p07214c67.pfd9160bb.p8ab1a15b showPinRoute, java.lang.string deviceId) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(showPinRoute, "showPinRoute");
        this.ff3395cd5.navigateTo(p8a6f5038.pfd9160bb.p3034f06b.f76425f17.PinInputScreen(showPinRoute, deviceId));
    }
}

