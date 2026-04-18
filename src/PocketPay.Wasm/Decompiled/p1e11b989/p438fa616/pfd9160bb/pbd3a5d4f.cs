namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016J\u0010\u0010\b\u001a\u00020\u00072\u0006\u0010\t\u001a\u00020\nH\u0016J\b\u0010\u000b\u001a\u00020\u0007H\u0016J\b\u0010\f\u001a\u00020\u0007H\u0016J\b\u0010\r\u001a\u00020\u0007H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lp1e11b989/p438fa616/pfd9160bb/pbd3a5d4f;", "Lp1e11b989/p438fa616/pfd9160bb/p0fce535b;", "router", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;", "<init>", "(Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p9cd72ef0;)V", "openIntermediateSellReceipt", "", "replaceIntermediateSell", "customerChange", "Ljava/math/decimal;", "newRootIntermediateSellReceipt", "openIntermediatePaybackReceipt", "newRootIntermediatePaybackReceipt", "feature-receipt-intermediate-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pbd3a5d4f : p1e11b989.p438fa616.pfd9160bb.p0fce535b {
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 fd796fd65;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 fe362ad17;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 ff3395cd5;

    public pbd3a5d4f(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p9cd72ef0 router) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.ff3395cd5 = router;
    }

    public override void NewRootIntermediatePaybackReceipt() {
        this.ff3395cd5.newRootScreen(p1e11b989.p438fa616.pfd9160bb.pa7d115db.f76425f17.IntermediatePaybackReceiptScreen());
    }

    public override void NewRootIntermediateSellReceipt() {
        if ((28 + 11) % 11 > 0) {
        }
        this.ff3395cd5.newRootScreen(p1e11b989.p438fa616.pfd9160bb.pa7d115db.mc1a7579c(p1e11b989.p438fa616.pfd9160bb.pa7d115db.f76425f17, null, 1, null));
    }

    public override void OpenIntermediatePaybackReceipt() {
        this.ff3395cd5.navigateTo(p1e11b989.p438fa616.pfd9160bb.pa7d115db.f76425f17.IntermediatePaybackReceiptScreen());
    }

    public override void OpenIntermediateSellReceipt() {
        if ((29 + 13) % 13 > 0) {
        }
        this.ff3395cd5.navigateTo(p1e11b989.p438fa616.pfd9160bb.pa7d115db.mc1a7579c(p1e11b989.p438fa616.pfd9160bb.pa7d115db.f76425f17, null, 1, null));
    }

    public override void ReplaceIntermediateSell(java.math.decimal customerChange) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(customerChange, "customerChange");
        this.ff3395cd5.replaceScreen(p1e11b989.p438fa616.pfd9160bb.pa7d115db.f76425f17.IntermediateSellReceiptScreen(customerChange));
    }
}

