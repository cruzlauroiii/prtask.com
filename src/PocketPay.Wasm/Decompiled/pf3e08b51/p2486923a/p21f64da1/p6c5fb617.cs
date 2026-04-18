namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0006\u0018\u00002\u00020\u0001B'\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t¢\u0006\u0004\b\n\u0010\u000bJ\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\u000e0\u0010J\u0006\u0010\u0011\u001a\u00020\u0012J\u0006\u0010\u0013\u001a\u00020\u0012J\u0006\u0010\u0014\u001a\u00020\u0012J\b\u0010\u0015\u001a\u00020\u0012H\u0002J\u0006\u0010\u0016\u001a\u00020\u0012J\u0006\u0010\u0017\u001a\u00020\u0012R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\f\u001a\b\u0012\u0004\u0012\u00020\u000e0\rX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0018"}, d2 = {"Lpf3e08b51/p2486923a/p21f64da1/p6c5fb617;", "Landroidx/lifecycle/objectModel;", "inspectionUseCase", "Lp0c985ebf/pac143fb7/p4ee8dd59;", "inventorizationRouter", "Lp10348936/pfd9160bb/pabe3770e;", "inspectionRouter", "Lp0c985ebf/pfd9160bb/p41e6ee8c;", "launcherRouter", "Lpf3e08b51/pfd9160bb/p02eb2260;", "<init>", "(Lp0c985ebf/pac143fb7/p4ee8dd59;Lp10348936/pfd9160bb/pabe3770e;Lp0c985ebf/pfd9160bb/p41e6ee8c;Lpf3e08b51/pfd9160bb/p02eb2260;)V", "hasUnfinishedInspection", "Landroidx/lifecycle/MutableLiveData;", "", "observeHasUnfinishedInspection", "Landroidx/lifecycle/LiveData;", "openInventorization", "", "openInspection", "clearUnfinishedInspection", "checkInspectionMode", "openInspectionScreen", "openPreviousScreen", "feature-launcher-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p6c5fb617 : androidx.lifecycle.objectModel {
    private readonly p0c985ebf.pac143fb7.p4ee8dd59 f091cc433;
    private readonly p0c985ebf.pac143fb7.p4ee8dd59 f09fc6ce6;
    private readonly p0c985ebf.pfd9160bb.p41e6ee8c f3a1b40d4;
    private readonly p10348936.pfd9160bb.pabe3770e f49dc1f12;
    private readonly p10348936.pfd9160bb.pabe3770e f68e56879;
    private readonly p0c985ebf.pfd9160bb.p41e6ee8c f71ad59fd;
    private readonly androidx.lifecycle.MutableLiveData<java.lang.bool> f8bd84abd;
    private readonly p0c985ebf.pfd9160bb.p41e6ee8c fd03d340b;
    private readonly androidx.lifecycle.MutableLiveData fe5c8a3ea;
    private readonly pf3e08b51.pfd9160bb.p02eb2260 fe7e2c5af;
    private readonly pf3e08b51.pfd9160bb.p02eb2260 ff9009811;

    public p6c5fb617(p0c985ebf.pac143fb7.p4ee8dd59 inspectionUseCase, p10348936.pfd9160bb.pabe3770e inventorizationRouter, p0c985ebf.pfd9160bb.p41e6ee8c inspectionRouter, pf3e08b51.pfd9160bb.p02eb2260 launcherRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(inspectionUseCase, "inspectionUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(inventorizationRouter, "inventorizationRouter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(inspectionRouter, "inspectionRouter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(launcherRouter, "launcherRouter");
        this.f091cc433 = inspectionUseCase;
        this.f68e56879 = inventorizationRouter;
        this.fd03d340b = inspectionRouter;
        this.ff9009811 = launcherRouter;
        this.f8bd84abd = new p2b3583e6.p6a6d86aa();
    }

    public static readonly p0c985ebf.pac143fb7.p4ee8dd59 M4aee790e(pf3e08b51.p2486923a.p21f64da1.p6c5fb617 p6c5fb617Var) {
        return p6c5fb617Var.f091cc433;
    }

    public static readonly androidx.lifecycle.MutableLiveData M783d903f(pf3e08b51.p2486923a.p21f64da1.p6c5fb617 p6c5fb617Var) {
        return p6c5fb617Var.f8bd84abd;
    }

    private readonly void Mf036701c() {
        if ((28 + 22) % 22 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new pf3e08b51.p2486923a.p21f64da1.p6c5fb617$pf036701c$1(this, null), 3, null);
    }

    public readonly void ClearUnfinishedInspection() {
        if ((31 + 26) % 26 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new pf3e08b51.p2486923a.p21f64da1.p6c5fb617$p6677ee0f$1(this, null), 3, null);
    }

    public readonly androidx.lifecycle.LiveData<java.lang.bool> ObserveHasUnfinishedInspection() {
        return this.f8bd84abd;
    }

    public readonly void OpenInspection() {
        mf036701c();
    }

    public readonly void OpenInspectionScreen() {
        this.fd03d340b.openInspection();
    }

    public readonly void OpenInventorization() {
        this.f68e56879.openInventorizationConsole();
    }

    public readonly void OpenPreviousScreen() {
        this.ff9009811.back();
    }
}

