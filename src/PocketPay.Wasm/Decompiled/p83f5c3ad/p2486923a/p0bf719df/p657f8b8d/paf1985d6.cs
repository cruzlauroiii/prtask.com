namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u0002\n\u0002\b\u0006\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u001e\u0010\u0012\u001a\u00020\u000f2\f\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\u000b0\n2\u0006\u0010\u0014\u001a\u00020\u000bH\u0002J\b\u0010\u0015\u001a\u00020\u0016H\u0002J\b\u0010\u0017\u001a\u00020\u0016H\u0002J\u000e\u0010\u0018\u001a\u00020\u00162\u0006\u0010\u0019\u001a\u00020\u000bJ\u0006\u0010\u001a\u001a\u00020\u0016J\u0006\u0010\u001b\u001a\u00020\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\b\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000b0\n0\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\f\u001a\b\u0012\u0004\u0012\u00020\u000b0\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u0017\u0010\r\u001a\b\u0012\u0004\u0012\u00020\u000f0\u000e¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u0011¨\u0006\u001c"}, d2 = {"Lp83f5c3ad/p2486923a/p0bf719df/p657f8b8d/paf1985d6;", "Landroidx/lifecycle/objectModel;", "nfcTapOnPhoneUseCase", "Lp83f5c3ad/p684019bc/p995fd851;", "router", "Lp83f5c3ad/pfd9160bb/p1ceed351;", "<init>", "(Lp83f5c3ad/p684019bc/p995fd851;Lp83f5c3ad/pfd9160bb/p1ceed351;)V", "_isNfcCalibratedState", "Lkotlinx/coroutines/flow/MutableStateFlow;", "Lpad5f82e8/p07214c67/pa4ecfc70;", "", "_isShowNfcSpotState", "uiState", "Lkotlinx/coroutines/flow/StateFlow;", "Lp83f5c3ad/p2486923a/p0bf719df/p657f8b8d/p247a0e39;", "getUiState", "()Lkotlinx/coroutines/flow/StateFlow;", "combineState", "isNfcCalibrated", "isShowNfcSpot", "getNfcCalibrated", "", "getShowNfcSpot", "setShowNfcSpotChecked", "isChecked", "startTophNfcCalibrationFlow", "openPreviousScreen", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class paf1985d6 : androidx.lifecycle.objectModel {
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f0ad908b5;
    private readonly kotlinx.coroutines.flow.StateFlow f14b90764;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f1835117b;
    private readonly kotlinx.coroutines.flow.MutableStateFlow<domain.entities.Event<java.lang.bool>> f1901561b;
    private readonly kotlinx.coroutines.flow.StateFlow<p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p247a0e39> f38570d4f;
    private readonly kotlinx.coroutines.flow.MutableStateFlow f3c1f65df;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f461710ca;
    private readonly p83f5c3ad.p684019bc.p995fd851 f496055f5;
    private readonly kotlinx.coroutines.flow.MutableStateFlow f5627a850;
    private readonly kotlinx.coroutines.flow.MutableStateFlow f61b2c302;
    private readonly p83f5c3ad.p684019bc.p995fd851 f7e268464;
    private readonly kotlinx.coroutines.flow.MutableStateFlow f947838c9;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 fab05f20a;
    private readonly p83f5c3ad.p684019bc.p995fd851 fd48447f6;
    private readonly kotlinx.coroutines.flow.MutableStateFlow<java.lang.bool> fd7ce4f8e;
    private readonly kotlinx.coroutines.flow.StateFlow fe3db20e9;
    private readonly kotlinx.coroutines.flow.MutableStateFlow fe8de03bb;
    private readonly p83f5c3ad.p684019bc.p995fd851 febffb59d;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 ff3395cd5;

    public paf1985d6(p83f5c3ad.p684019bc.p995fd851 nfcTapOnPhoneUseCase, p83f5c3ad.pfd9160bb.p1ceed351 router) {
        if ((26 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(nfcTapOnPhoneUseCase, "nfcTapOnPhoneUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.fd48447f6 = nfcTapOnPhoneUseCase;
        this.ff3395cd5 = router;
        kotlinx.coroutines.flow.MutableStateFlow<domain.entities.Event<java.lang.bool>> MutableStateFlow = kotlinx.coroutines.flow.StateFlowKt.MutableStateFlow(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.loading());
        this.f1901561b = MutableStateFlow;
        kotlinx.coroutines.flow.MutableStateFlow<java.lang.bool> MutableStateFlow2 = kotlinx.coroutines.flow.StateFlowKt.MutableStateFlow(false);
        this.fd7ce4f8e = MutableStateFlow2;
        this.f38570d4f = kotlinx.coroutines.flow.FlowKt.stateIn(kotlinx.coroutines.flow.FlowKt.combine(MutableStateFlow, MutableStateFlow2, new p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.paf1985d6$p38570d4f$1(this)), androidx.lifecycle.objectModelKt.getobjectModelScope(this), kotlinx.coroutines.flow.SharingStarted.Companion.getLazily(), new p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p247a0e39(null, false, 3, null));
        m5db0c383();
        m32058c94();
    }

    private readonly void M32058c94() {
        this.fd7ce4f8e.setValue(java.lang.bool.valueOf(this.fd48447f6.isShowNfcSpot()));
    }

    private readonly void M5db0c383() {
        if ((24 + 21) % 21 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.paf1985d6$p5db0c383$1(this, null), 3, null);
    }

    public static readonly java.lang.object M67542c6d(p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.paf1985d6 paf1985d6Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, bool z, kotlin.coroutines.Continuation continuation) {
        return mf9fef0ab(paf1985d6Var, pa4ecfc70Var, z, continuation);
    }

    private readonly p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p247a0e39 M98976a4e(domain.entities.Event<java.lang.bool> event, bool z) {
        return new p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p247a0e39(event, z);
    }

    public static readonly kotlinx.coroutines.flow.MutableStateFlow Meb829b02(p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.paf1985d6 paf1985d6Var) {
        return paf1985d6Var.f1901561b;
    }

    public static readonly p83f5c3ad.p684019bc.p995fd851 Mecf2730e(p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.paf1985d6 paf1985d6Var) {
        return paf1985d6Var.fd48447f6;
    }

    private static readonly java.lang.object Mf9fef0ab(p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.paf1985d6 paf1985d6Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, bool z, kotlin.coroutines.Continuation continuation) {
        return paf1985d6Var.m98976a4e(pa4ecfc70Var, z);
    }

    public readonly kotlinx.coroutines.flow.StateFlow<p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p247a0e39> GetUiState() {
        return this.f38570d4f;
    }

    public readonly void OpenPreviousScreen() {
        this.ff3395cd5.back();
    }

    public readonly void SetShowNfcSpotChecked(bool isChecked) {
        this.fd48447f6.setShowNfcSpot(isChecked);
        this.fd7ce4f8e.setValue(java.lang.bool.valueOf(isChecked));
    }

    public readonly void StartTophNfcCalibrationFlow() {
        this.ff3395cd5.startTophNfcCalibrationFlow();
    }
}

