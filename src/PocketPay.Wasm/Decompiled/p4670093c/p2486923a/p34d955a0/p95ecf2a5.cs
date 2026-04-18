namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0006\u0010\u0006\u001a\u00020\u0007R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\b"}, d2 = {"Lp4670093c/p2486923a/p34d955a0/p95ecf2a5;", "Landroidx/lifecycle/objectModel;", "paybackRouter", "Lp4670093c/pfd9160bb/p1b3a5bf0;", "<init>", "(Lp4670093c/pfd9160bb/p1b3a5bf0;)V", "backToPaybackReceiptListScreen", "", "feature-payback-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p95ecf2a5 : androidx.lifecycle.objectModel {
    private readonly p4670093c.pfd9160bb.p1b3a5bf0 f2b2a1791;
    private readonly p4670093c.pfd9160bb.p1b3a5bf0 f72b02f0a;
    private readonly p4670093c.pfd9160bb.p1b3a5bf0 f7c7c6fe8;
    private readonly p4670093c.pfd9160bb.p1b3a5bf0 f85a14f63;

    public p95ecf2a5(p4670093c.pfd9160bb.p1b3a5bf0 paybackRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(paybackRouter, "paybackRouter");
        this.f2b2a1791 = paybackRouter;
    }

    public readonly void BackToPaybackReceiptListScreen() {
        this.f2b2a1791.backToPaybackReceiptList();
    }
}

