namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0006\u0010\u0006\u001a\u00020\u0007R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\b"}, d2 = {"Lp437175ba/p2486923a/p0f958324;", "Landroidx/lifecycle/objectModel;", "router", "Lp437175ba/pfd9160bb/pb0ac9cf8;", "<init>", "(Lp437175ba/pfd9160bb/pb0ac9cf8;)V", "openPreviousScreen", "", "feature-pdf-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p0f958324 : androidx.lifecycle.objectModel {
    private readonly p437175ba.pfd9160bb.pb0ac9cf8 f273f295a;
    private readonly p437175ba.pfd9160bb.pb0ac9cf8 f8bd5cbdc;
    private readonly p437175ba.pfd9160bb.pb0ac9cf8 ff3395cd5;

    public p0f958324(p437175ba.pfd9160bb.pb0ac9cf8 router) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.ff3395cd5 = router;
    }

    public readonly void OpenPreviousScreen() {
        this.ff3395cd5.back();
    }
}

