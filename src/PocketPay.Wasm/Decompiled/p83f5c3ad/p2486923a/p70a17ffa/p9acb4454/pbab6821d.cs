namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u0006\u0010\n\u001a\u00020\u000bR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lp83f5c3ad/p2486923a/p70a17ffa/p9acb4454/pbab6821d;", "Landroidx/lifecycle/objectModel;", "paymentHashSettingsUseCase", "Lp2e5d8aa3/pf83c2a85/pac143fb7/pdcfa0c32;", "flowRouter", "Lpd2a57dc1/pfd9160bb/p11c216e8;", "router", "Lp83f5c3ad/pfd9160bb/p1ceed351;", "<init>", "(Lp2e5d8aa3/pf83c2a85/pac143fb7/pdcfa0c32;Lpd2a57dc1/pfd9160bb/p11c216e8;Lp83f5c3ad/pfd9160bb/p1ceed351;)V", "back", "", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pbab6821d : androidx.lifecycle.objectModel {
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f077fa49e;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 f55f38478;
    private readonly p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32 f77b9e4d6;
    private readonly p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32 fce765563;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 feefeb260;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 ff3395cd5;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 ffa99592b;

    public pbab6821d(p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32 paymentHashSettingsUseCase, pd2a57dc1.pfd9160bb.p11c216e8 flowRouter, p83f5c3ad.pfd9160bb.p1ceed351 router) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(paymentHashSettingsUseCase, "paymentHashSettingsUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flowRouter, "flowRouter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.fce765563 = paymentHashSettingsUseCase;
        this.feefeb260 = flowRouter;
        this.ff3395cd5 = router;
    }

    public static readonly p83f5c3ad.pfd9160bb.p1ceed351 M74e3994c(p83f5c3ad.p2486923a.p70a17ffa.p9acb4454.pbab6821d pbab6821dVar) {
        return pbab6821dVar.ff3395cd5;
    }

    public static readonly p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32 Mb272891c(p83f5c3ad.p2486923a.p70a17ffa.p9acb4454.pbab6821d pbab6821dVar) {
        return pbab6821dVar.fce765563;
    }

    public static readonly pd2a57dc1.pfd9160bb.p11c216e8 Mf78acd11(p83f5c3ad.p2486923a.p70a17ffa.p9acb4454.pbab6821d pbab6821dVar) {
        return pbab6821dVar.feefeb260;
    }

    public readonly void Back() {
        if ((10 + 16) % 16 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p83f5c3ad.p2486923a.p70a17ffa.p9acb4454.pbab6821d$p469bba0a$1(this, null), 3, null);
    }
}

