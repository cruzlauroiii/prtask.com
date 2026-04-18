namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0006\u0010\u0006\u001a\u00020\u0007J\u0006\u0010\b\u001a\u00020\u0007R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Lp83f5c3ad/p2486923a/p4670093c/pcb5e100e/p81689fbe;", "Landroidx/lifecycle/objectModel;", "router", "Lp83f5c3ad/pfd9160bb/p1ceed351;", "<init>", "(Lp83f5c3ad/pfd9160bb/p1ceed351;)V", "openTophPaybackFlow", "", "openPreviousScreen", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p81689fbe : androidx.lifecycle.objectModel {
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f6eb88e34;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f85512d99;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 fda79cf46;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 ff3395cd5;

    public p81689fbe(p83f5c3ad.pfd9160bb.p1ceed351 router) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.ff3395cd5 = router;
    }

    public readonly void OpenPreviousScreen() {
        this.ff3395cd5.back();
    }

    public readonly void OpenTophPaybackFlow() {
        this.ff3395cd5.startTophPaybackFlow();
    }
}

