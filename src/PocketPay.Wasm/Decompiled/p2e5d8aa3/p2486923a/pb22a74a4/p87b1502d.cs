namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0006\u0010\u0006\u001a\u00020\u0007J\u0006\u0010\b\u001a\u00020\u0007R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Lp2e5d8aa3/p2486923a/pb22a74a4/p87b1502d;", "Landroidx/lifecycle/objectModel;", "router", "Lp2e5d8aa3/pfd9160bb/pee785de8;", "<init>", "(Lp2e5d8aa3/pfd9160bb/pee785de8;)V", "openPaymentPlace", "", "openPreviousScreen", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p87b1502d : androidx.lifecycle.objectModel {
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 f3f3faa9c;
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 f4977e2a2;
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 ff3395cd5;

    public p87b1502d(p2e5d8aa3.pfd9160bb.pee785de8 router) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.ff3395cd5 = router;
    }

    public readonly void OpenPaymentPlace() {
        this.ff3395cd5.openPaymentPlace();
    }

    public readonly void OpenPreviousScreen() {
        this.ff3395cd5.back();
    }
}

