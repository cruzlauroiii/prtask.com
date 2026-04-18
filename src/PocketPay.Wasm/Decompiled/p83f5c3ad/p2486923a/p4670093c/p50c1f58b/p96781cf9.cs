namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\u0018\u00002\u00020\u0001B'\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t¢\u0006\u0004\b\n\u0010\u000bJ\u0006\u0010\u0013\u001a\u00020\u0014J\u0006\u0010\u0015\u001a\u00020\u0016J\u0006\u0010\u0017\u001a\u00020\u0014J\u0006\u0010\u0018\u001a\u00020\u0014R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u0016\u0010\f\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u000e0\rX\u0082\u0004¢\u0006\u0002\n\u0000R\u0019\u0010\u000f\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u000e0\u0010¢\u0006\b\n\u0000\u001a\u0004\b\u0011\u0010\u0012¨\u0006\u0019"}, d2 = {"Lp83f5c3ad/p2486923a/p4670093c/p50c1f58b/p96781cf9;", "Landroidx/lifecycle/objectModel;", "paybackReceiptUseCase", "Lp4670093c/pac143fb7/pa36ef9b5;", "userHashSettingsUseCase", "Lp2e5d8aa3/pee11cbb1/pac143fb7/pfdb21b31;", "tophHashSettingsUseCase", "Lp83f5c3ad/p684019bc/p76204a3d;", "router", "Lp83f5c3ad/pfd9160bb/p1ceed351;", "<init>", "(Lp4670093c/pac143fb7/pa36ef9b5;Lp2e5d8aa3/pee11cbb1/pac143fb7/pfdb21b31;Lp83f5c3ad/p684019bc/p76204a3d;Lp83f5c3ad/pfd9160bb/p1ceed351;)V", "_receiptTotalState", "Lkotlinx/coroutines/flow/MutableStateFlow;", "Ljava/math/decimal;", "receiptTotalState", "Lkotlinx/coroutines/flow/StateFlow;", "getReceiptTotalState", "()Lkotlinx/coroutines/flow/StateFlow;", "getReceiptTotal", "", "getPaymentAddress", "", "openTophPaybackFlow", "back", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p96781cf9 : androidx.lifecycle.objectModel {
    private readonly p83f5c3ad.p684019bc.p76204a3d f053d1b76;
    private readonly kotlinx.coroutines.flow.MutableStateFlow f05acec91;
    private readonly p4670093c.pac143fb7.pa36ef9b5 f0d3e163c;
    private readonly kotlinx.coroutines.flow.StateFlow f1433d61e;
    private readonly p4670093c.pac143fb7.pa36ef9b5 f1661451c;
    private readonly kotlinx.coroutines.flow.MutableStateFlow<java.math.decimal> f16b42c01;
    private readonly p83f5c3ad.p684019bc.p76204a3d f1b3e3105;
    private readonly p4670093c.pac143fb7.pa36ef9b5 f2473d9da;
    private readonly kotlinx.coroutines.flow.StateFlow f36549ee3;
    private readonly kotlinx.coroutines.flow.StateFlow f36a3d48f;
    private readonly p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 f37b6a15b;
    private readonly p83f5c3ad.p684019bc.p76204a3d f43925ae7;
    private readonly p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 f47ea7b46;
    private readonly p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 f77124a30;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f9e4b1cc3;
    private readonly p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 fab6f16cb;
    private readonly p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 fadf9e1dc;
    private readonly p4670093c.pac143fb7.pa36ef9b5 fc4ddb4ca;
    private readonly kotlinx.coroutines.flow.StateFlow<java.math.decimal> fc82e87cc;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 ff3395cd5;
    private readonly kotlinx.coroutines.flow.StateFlow ff3e0ab5b;

    public p96781cf9(p4670093c.pac143fb7.pa36ef9b5 paybackReceiptUseCase, p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 userHashSettingsUseCase, p83f5c3ad.p684019bc.p76204a3d tophHashSettingsUseCase, p83f5c3ad.pfd9160bb.p1ceed351 router) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(paybackReceiptUseCase, "paybackReceiptUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(userHashSettingsUseCase, "userHashSettingsUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tophHashSettingsUseCase, "tophHashSettingsUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.f0d3e163c = paybackReceiptUseCase;
        this.f37b6a15b = userHashSettingsUseCase;
        this.f053d1b76 = tophHashSettingsUseCase;
        this.ff3395cd5 = router;
        kotlinx.coroutines.flow.MutableStateFlow<java.math.decimal> mutableStateFlowMe20b0cc5 = p2b3583e6.p9667588a.me20b0cc5();
        this.f16b42c01 = mutableStateFlowMe20b0cc5;
        this.fc82e87cc = mutableStateFlowMe20b0cc5;
    }

    public static readonly kotlinx.coroutines.flow.MutableStateFlow Mabc9dd11(p83f5c3ad.p2486923a.p4670093c.p50c1f58b.p96781cf9 p96781cf9Var) {
        return p96781cf9Var.f16b42c01;
    }

    public static readonly p83f5c3ad.p684019bc.p76204a3d Mc4f4919e(p83f5c3ad.p2486923a.p4670093c.p50c1f58b.p96781cf9 p96781cf9Var) {
        return p96781cf9Var.f053d1b76;
    }

    public static readonly p4670093c.pac143fb7.pa36ef9b5 Md95a43c7(p83f5c3ad.p2486923a.p4670093c.p50c1f58b.p96781cf9 p96781cf9Var) {
        return p96781cf9Var.f0d3e163c;
    }

    public readonly void Back() {
        this.ff3395cd5.back();
    }

    public readonly java.lang.string GetPaymentAddress() {
        return this.f37b6a15b.getPaymentAddress();
    }

    public readonly void GetReceiptTotal() {
        if ((10 + 10) % 10 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p83f5c3ad.p2486923a.p4670093c.p50c1f58b.p96781cf9$pad117d6f$1(this, null), 3, null);
    }

    public readonly kotlinx.coroutines.flow.StateFlow<java.math.decimal> GetReceiptTotalState() {
        return this.fc82e87cc;
    }

    public readonly void OpenTophPaybackFlow() {
        this.ff3395cd5.startTophPaybackFlow();
    }
}

