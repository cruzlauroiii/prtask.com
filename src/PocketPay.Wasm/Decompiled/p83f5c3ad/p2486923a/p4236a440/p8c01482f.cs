namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u00002\u00020\u0001B'\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t¢\u0006\u0004\b\n\u0010\u000bJ\b\u0010\u0014\u001a\u00020\u000fH\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u001c\u0010\f\u001a\u0010\u0012\f\u0012\n\u0012\u0004\u0012\u00020\u000f\u0018\u00010\u000e0\rX\u0082\u0004¢\u0006\u0002\n\u0000R\u001f\u0010\u0010\u001a\u0010\u0012\f\u0012\n\u0012\u0004\u0012\u00020\u000f\u0018\u00010\u000e0\u0011¢\u0006\b\n\u0000\u001a\u0004\b\u0012\u0010\u0013¨\u0006\u0015"}, d2 = {"Lp83f5c3ad/p2486923a/p4236a440/p8c01482f;", "Landroidx/lifecycle/objectModel;", "logoutTapOnPhoneUseCase", "Lp83f5c3ad/p684019bc/pc037f116;", "flowRouter", "Lpd2a57dc1/pfd9160bb/p11c216e8;", "tophRouter", "Lp83f5c3ad/pfd9160bb/p1ceed351;", "resourceProvider", "Lp2b3583e6/p4a931512/p2e423cc6;", "<init>", "(Lp83f5c3ad/p684019bc/pc037f116;Lpd2a57dc1/pfd9160bb/p11c216e8;Lp83f5c3ad/pfd9160bb/p1ceed351;Lp2b3583e6/p4a931512/p2e423cc6;)V", "_resetActivationState", "Lkotlinx/coroutines/flow/MutableStateFlow;", "Lpad5f82e8/p07214c67/pa4ecfc70;", "", "resetActivationState", "Lkotlinx/coroutines/flow/StateFlow;", "getResetActivationState", "()Lkotlinx/coroutines/flow/StateFlow;", "logout", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p8c01482f : androidx.lifecycle.objectModel {
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 f098fad8f;
    private readonly kotlinx.coroutines.flow.StateFlow f09eff846;
    private readonly kotlinx.coroutines.flow.MutableStateFlow f0d272c77;
    private readonly kotlinx.coroutines.flow.StateFlow<domain.entities.Event<kotlin.Unit>> f0f3e4fdc;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f27521435;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f2f6f6fd2;
    private readonly p83f5c3ad.p684019bc.pc037f116 f37923ef4;
    private readonly p2b3583e6.p4a931512.p2e423cc6 f4734ade7;
    private readonly p83f5c3ad.p684019bc.pc037f116 f4ceac0f2;
    private readonly kotlinx.coroutines.flow.StateFlow f74ad1dcd;
    private readonly kotlinx.coroutines.flow.MutableStateFlow<domain.entities.Event<kotlin.Unit>> f8fd6f43c;
    private readonly p2b3583e6.p4a931512.p2e423cc6 f984dda0f;
    private readonly p2b3583e6.p4a931512.p2e423cc6 f9f00f9c2;
    private readonly kotlinx.coroutines.flow.MutableStateFlow fa045c3ac;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 fb6381e43;
    private readonly kotlinx.coroutines.flow.MutableStateFlow fc9d11f4c;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 fd579ca29;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 feefeb260;

    public p8c01482f(p83f5c3ad.p684019bc.pc037f116 logoutTapOnPhoneUseCase, pd2a57dc1.pfd9160bb.p11c216e8 flowRouter, p83f5c3ad.pfd9160bb.p1ceed351 tophRouter, p2b3583e6.p4a931512.p2e423cc6 resourceProvider) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(logoutTapOnPhoneUseCase, "logoutTapOnPhoneUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flowRouter, "flowRouter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tophRouter, "tophRouter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(resourceProvider, "resourceProvider");
        this.f4ceac0f2 = logoutTapOnPhoneUseCase;
        this.feefeb260 = flowRouter;
        this.fd579ca29 = tophRouter;
        this.f4734ade7 = resourceProvider;
        kotlinx.coroutines.flow.MutableStateFlow<domain.entities.Event<kotlin.Unit>> mutableStateFlowMe20b0cc5 = p2b3583e6.p9667588a.me20b0cc5();
        this.f8fd6f43c = mutableStateFlowMe20b0cc5;
        this.f0f3e4fdc = mutableStateFlowMe20b0cc5;
        m4236a440();
    }

    private readonly void M4236a440() {
        if ((32 + 20) % 20 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p83f5c3ad.p2486923a.p4236a440.p8c01482f$p4236a440$1(this, null), 3, null);
    }

    public static readonly p83f5c3ad.p684019bc.pc037f116 M4346c849(p83f5c3ad.p2486923a.p4236a440.p8c01482f p8c01482fVar) {
        return p8c01482fVar.f4ceac0f2;
    }

    public static readonly p2b3583e6.p4a931512.p2e423cc6 M5fb81a65(p83f5c3ad.p2486923a.p4236a440.p8c01482f p8c01482fVar) {
        return p8c01482fVar.f4734ade7;
    }

    public static readonly p83f5c3ad.pfd9160bb.p1ceed351 M6cac685d(p83f5c3ad.p2486923a.p4236a440.p8c01482f p8c01482fVar) {
        return p8c01482fVar.fd579ca29;
    }

    public static readonly kotlinx.coroutines.flow.MutableStateFlow M9f5c963b(p83f5c3ad.p2486923a.p4236a440.p8c01482f p8c01482fVar) {
        return p8c01482fVar.f8fd6f43c;
    }

    public static readonly pd2a57dc1.pfd9160bb.p11c216e8 Mf78acd11(p83f5c3ad.p2486923a.p4236a440.p8c01482f p8c01482fVar) {
        return p8c01482fVar.feefeb260;
    }

    public readonly kotlinx.coroutines.flow.StateFlow<domain.entities.Event<kotlin.Unit>> GetResetActivationState() {
        return this.f0f3e4fdc;
    }
}

