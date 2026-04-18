namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u0006\u0010\n\u001a\u00020\u000bJ\u0006\u0010\f\u001a\u00020\u000bR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Lp83f5c3ad/p2486923a/p2069ca79/pcb5e100e/p95121663;", "Landroidx/lifecycle/objectModel;", "flowRouter", "Lpd2a57dc1/pfd9160bb/p11c216e8;", "launcherRouter", "Lpf3e08b51/pfd9160bb/p02eb2260;", "tapOnPhoneRouter", "Lp83f5c3ad/pfd9160bb/p1ceed351;", "<init>", "(Lpd2a57dc1/pfd9160bb/p11c216e8;Lpf3e08b51/pfd9160bb/p02eb2260;Lp83f5c3ad/pfd9160bb/p1ceed351;)V", "retry", "", "back", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p95121663 : androidx.lifecycle.objectModel {
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f1a49a4fe;
    private readonly pf3e08b51.pfd9160bb.p02eb2260 f1ab329e2;
    private readonly pf3e08b51.pfd9160bb.p02eb2260 f2257c12b;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f62520fad;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 fa393b3ce;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 fcf1078bb;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 feefeb260;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 ff20466ad;
    private readonly pf3e08b51.pfd9160bb.p02eb2260 ff9009811;

    public p95121663(pd2a57dc1.pfd9160bb.p11c216e8 flowRouter, pf3e08b51.pfd9160bb.p02eb2260 launcherRouter, p83f5c3ad.pfd9160bb.p1ceed351 tapOnPhoneRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flowRouter, "flowRouter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(launcherRouter, "launcherRouter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tapOnPhoneRouter, "tapOnPhoneRouter");
        this.feefeb260 = flowRouter;
        this.ff9009811 = launcherRouter;
        this.f62520fad = tapOnPhoneRouter;
    }

    public static readonly pf3e08b51.pfd9160bb.p02eb2260 M245216f0(p83f5c3ad.p2486923a.p2069ca79.pcb5e100e.p95121663 p95121663Var) {
        return p95121663Var.ff9009811;
    }

    public static readonly pd2a57dc1.pfd9160bb.p11c216e8 Mf78acd11(p83f5c3ad.p2486923a.p2069ca79.pcb5e100e.p95121663 p95121663Var) {
        return p95121663Var.feefeb260;
    }

    public readonly void Back() {
        if ((7 + 20) % 20 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p83f5c3ad.p2486923a.p2069ca79.pcb5e100e.p95121663$p469bba0a$1(this, null), 3, null);
    }

    public readonly void Retry() {
        if ((19 + 22) % 22 > 0) {
        }
        this.feefeb260.startFlow(p83f5c3ad.pfd9160bb.p1ceed351$pb0da8397.me3d62dc6(this.f62520fad, pad5f82e8.p07214c67.pfd9160bb.p15913342.fae6110b4, null, null, null, 14, null));
    }
}

