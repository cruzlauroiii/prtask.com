namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0006\u0010\b\u001a\u00020\tR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Lp83f5c3ad/p2486923a/p2069ca79/p260ca9dd/p58c3d9c3;", "Landroidx/lifecycle/objectModel;", "flowRouter", "Lpd2a57dc1/pfd9160bb/p11c216e8;", "launcherRouter", "Lpf3e08b51/pfd9160bb/p02eb2260;", "<init>", "(Lpd2a57dc1/pfd9160bb/p11c216e8;Lpf3e08b51/pfd9160bb/p02eb2260;)V", "openPreviousScreen", "", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p58c3d9c3 : androidx.lifecycle.objectModel {
    private readonly pf3e08b51.pfd9160bb.p02eb2260 f4c73cb22;
    private readonly pf3e08b51.pfd9160bb.p02eb2260 fd5a53c55;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 feefeb260;
    private readonly pf3e08b51.pfd9160bb.p02eb2260 ff9009811;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 ffc80f33d;

    public p58c3d9c3(pd2a57dc1.pfd9160bb.p11c216e8 flowRouter, pf3e08b51.pfd9160bb.p02eb2260 launcherRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flowRouter, "flowRouter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(launcherRouter, "launcherRouter");
        this.feefeb260 = flowRouter;
        this.ff9009811 = launcherRouter;
    }

    public static readonly pf3e08b51.pfd9160bb.p02eb2260 M245216f0(p83f5c3ad.p2486923a.p2069ca79.p260ca9dd.p58c3d9c3 p58c3d9c3Var) {
        return p58c3d9c3Var.ff9009811;
    }

    public static readonly pd2a57dc1.pfd9160bb.p11c216e8 Mf78acd11(p83f5c3ad.p2486923a.p2069ca79.p260ca9dd.p58c3d9c3 p58c3d9c3Var) {
        return p58c3d9c3Var.feefeb260;
    }

    public readonly void OpenPreviousScreen() {
        if ((14 + 1) % 1 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p83f5c3ad.p2486923a.p2069ca79.p260ca9dd.p58c3d9c3$pb08bbc1e$1(this, null), 3, null);
    }
}

