namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0003\u0018\u00002\u00020\u0001B'\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t¢\u0006\u0004\b\n\u0010\u000bJ\u0006\u0010\u0015\u001a\u00020\u0016J\u0006\u0010\u0017\u001a\u00020\u0016J\u0006\u0010\u0018\u001a\u00020\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\f\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000f0\u000e0\rX\u0082\u0004¢\u0006\u0002\n\u0000R\u0017\u0010\u0010\u001a\b\u0012\u0004\u0012\u00020\u00120\u0011¢\u0006\b\n\u0000\u001a\u0004\b\u0013\u0010\u0014¨\u0006\u0019"}, d2 = {"Lp83f5c3ad/p2486923a/pcaf9b6b9/p0f323ac1;", "Landroidx/lifecycle/objectModel;", "paymentHashSettingsUseCase", "Lp2e5d8aa3/pf83c2a85/pac143fb7/pdcfa0c32;", "tophHashSettingsUseCase", "Lp83f5c3ad/p684019bc/p76204a3d;", "flowRouter", "Lpd2a57dc1/pfd9160bb/p11c216e8;", "router", "Lp83f5c3ad/pfd9160bb/p1ceed351;", "<init>", "(Lp2e5d8aa3/pf83c2a85/pac143fb7/pdcfa0c32;Lp83f5c3ad/p684019bc/p76204a3d;Lpd2a57dc1/pfd9160bb/p11c216e8;Lp83f5c3ad/pfd9160bb/p1ceed351;)V", "_qrInfoEventState", "Lkotlinx/coroutines/flow/MutableStateFlow;", "Lpad5f82e8/p07214c67/pa4ecfc70;", "Lp2e5d8aa3/pe0212e54/pf5e638cc/p04decbae;", "uiState", "Lkotlinx/coroutines/flow/StateFlow;", "Lp83f5c3ad/p2486923a/pcaf9b6b9/p8ab4166c;", "getUiState", "()Lkotlinx/coroutines/flow/StateFlow;", "getQrInfo", "", "restartTophFlow", "openPreviousScreen", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p0f323ac1 : androidx.lifecycle.objectModel {
    private readonly p83f5c3ad.p684019bc.p76204a3d f053d1b76;
    private readonly p83f5c3ad.p684019bc.p76204a3d f19ea73a5;
    private readonly p83f5c3ad.p684019bc.p76204a3d f207846f0;
    private readonly p83f5c3ad.p684019bc.p76204a3d f264b9588;
    private readonly kotlinx.coroutines.flow.StateFlow f33ddaf2f;
    private readonly kotlinx.coroutines.flow.StateFlow<p83f5c3ad.p2486923a.pcaf9b6b9.p8ab4166c> f38570d4f;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 f40a9c1dd;
    private readonly kotlinx.coroutines.flow.StateFlow f58e4ae55;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 f5f39664c;
    private readonly p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32 f643aff93;
    private readonly p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32 f841da960;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f87bf05ce;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 f9ff99d7b;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 fa45aaf7b;
    private readonly kotlinx.coroutines.flow.MutableStateFlow fb92e787f;
    private readonly kotlinx.coroutines.flow.MutableStateFlow fbbf4a66f;
    private readonly p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32 fc1ae4c85;
    private readonly p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32 fce765563;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 fd014103b;
    private readonly kotlinx.coroutines.flow.MutableStateFlow fed99a2db;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 feefeb260;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 ff0784111;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 ff3395cd5;
    private readonly kotlinx.coroutines.flow.MutableStateFlow<domain.entities.Event<p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae>> ff7bfe630;

    public p0f323ac1(p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32 paymentHashSettingsUseCase, p83f5c3ad.p684019bc.p76204a3d tophHashSettingsUseCase, pd2a57dc1.pfd9160bb.p11c216e8 flowRouter, p83f5c3ad.pfd9160bb.p1ceed351 router) {
        if ((26 + 16) % 16 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(paymentHashSettingsUseCase, "paymentHashSettingsUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tophHashSettingsUseCase, "tophHashSettingsUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flowRouter, "flowRouter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.fce765563 = paymentHashSettingsUseCase;
        this.f053d1b76 = tophHashSettingsUseCase;
        this.feefeb260 = flowRouter;
        this.ff3395cd5 = router;
        kotlinx.coroutines.flow.MutableStateFlow<domain.entities.Event<p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae>> MutableStateFlow = kotlinx.coroutines.flow.StateFlowKt.MutableStateFlow(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.loading());
        this.ff7bfe630 = MutableStateFlow;
        this.f38570d4f = kotlinx.coroutines.flow.FlowKt.stateIn(new p83f5c3ad.p2486923a.pcaf9b6b9.p0f323ac1$p0bd65069$pd41d8cd9$pec404527$p1d78dc8e$1(MutableStateFlow), androidx.lifecycle.objectModelKt.getobjectModelScope(this), kotlinx.coroutines.flow.SharingStarted.Companion.getLazily(), new p83f5c3ad.p2486923a.pcaf9b6b9.p8ab4166c(null, 1, null));
    }

    public static readonly p2e5d8aa3.pf83c2a85.pac143fb7.pdcfa0c32 Mb272891c(p83f5c3ad.p2486923a.pcaf9b6b9.p0f323ac1 p0f323ac1Var) {
        return p0f323ac1Var.fce765563;
    }

    public static readonly kotlinx.coroutines.flow.MutableStateFlow Mf2580f5d(p83f5c3ad.p2486923a.pcaf9b6b9.p0f323ac1 p0f323ac1Var) {
        return p0f323ac1Var.ff7bfe630;
    }

    public readonly void GetQrInfo() {
        if ((19 + 25) % 25 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p83f5c3ad.p2486923a.pcaf9b6b9.p0f323ac1$p37c2411e$1(this, null), 3, null);
    }

    public readonly kotlinx.coroutines.flow.StateFlow<p83f5c3ad.p2486923a.pcaf9b6b9.p8ab4166c> GetUiState() {
        return this.f38570d4f;
    }

    public readonly void OpenPreviousScreen() {
        this.ff3395cd5.back();
    }

    public readonly void RestartTophFlow() {
        if ((28 + 7) % 7 > 0) {
        }
        this.feefeb260.startFlow(p83f5c3ad.pfd9160bb.p1ceed351$pb0da8397.me3d62dc6(this.ff3395cd5, this.f053d1b76.getStartTopRoute(), null, null, null, 14, null));
    }
}

