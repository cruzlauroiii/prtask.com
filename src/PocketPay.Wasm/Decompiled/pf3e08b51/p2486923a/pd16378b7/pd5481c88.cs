namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u0012\u0010\u000e\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\r0\f0\u000fJ\u000e\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0013J\u0006\u0010\u0014\u001a\u00020\u0011J\b\u0010\u0015\u001a\u00020\u0011H\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\n\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\r0\f0\u000bX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0016"}, d2 = {"Lpf3e08b51/p2486923a/pd16378b7/pd5481c88;", "Landroidx/lifecycle/objectModel;", "feedbackUseCase", "Lp2e5d8aa3/p39652074/p1d2e04a5;", "applicationStateRepository", "Lp8d777f38/pb3f20355/pd2a57dc1/p6d29e2ef;", "router", "Lpf3e08b51/pfd9160bb/p02eb2260;", "<init>", "(Lp2e5d8aa3/p39652074/p1d2e04a5;Lp8d777f38/pb3f20355/pd2a57dc1/p6d29e2ef;Lpf3e08b51/pfd9160bb/p02eb2260;)V", "appReviewStatus", "Landroidx/lifecycle/MutableLiveData;", "Lpad5f82e8/p07214c67/pa4ecfc70;", "", "getAppReviewStatus", "Landroidx/lifecycle/LiveData;", "sendFeedback", "", "feedback", "", "openPreviousScreen", "onAppReviewFinished", "feature-launcher-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pd5481c88 : androidx.lifecycle.objectModel {
    private readonly pf3e08b51.pfd9160bb.p02eb2260 f025e085c;
    private readonly p2e5d8aa3.p39652074.p1d2e04a5 f03027159;
    private readonly pf3e08b51.pfd9160bb.p02eb2260 f1c31aa7a;
    private readonly androidx.lifecycle.MutableLiveData f3c6274db;
    private readonly p2e5d8aa3.p39652074.p1d2e04a5 f5ea3d4c7;
    private readonly p8d777f38.pb3f20355.pd2a57dc1.p6d29e2ef f86711c1e;
    private readonly androidx.lifecycle.MutableLiveData<domain.entities.Event<java.lang.bool>> f8fb5165c;
    private readonly p2e5d8aa3.p39652074.p1d2e04a5 f91b5683e;
    private readonly p8d777f38.pb3f20355.pd2a57dc1.p6d29e2ef f9248a45f;
    private readonly p8d777f38.pb3f20355.pd2a57dc1.p6d29e2ef f97e1f910;
    private readonly androidx.lifecycle.MutableLiveData fd853272a;
    private readonly pf3e08b51.pfd9160bb.p02eb2260 fe235c617;
    private readonly androidx.lifecycle.MutableLiveData fe778bfbd;
    private readonly pf3e08b51.pfd9160bb.p02eb2260 fe92a2050;
    private readonly p8d777f38.pb3f20355.pd2a57dc1.p6d29e2ef ff09a12a8;
    private readonly pf3e08b51.pfd9160bb.p02eb2260 ff3395cd5;
    private readonly p2e5d8aa3.p39652074.p1d2e04a5 ff525f739;
    private readonly androidx.lifecycle.MutableLiveData ff88540f3;

    public pd5481c88(p2e5d8aa3.p39652074.p1d2e04a5 feedbackUseCase, p8d777f38.pb3f20355.pd2a57dc1.p6d29e2ef applicationStateRepository, pf3e08b51.pfd9160bb.p02eb2260 router) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(feedbackUseCase, "feedbackUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(applicationStateRepository, "applicationStateRepository");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.ff525f739 = feedbackUseCase;
        this.f97e1f910 = applicationStateRepository;
        this.ff3395cd5 = router;
        this.f8fb5165c = new p2b3583e6.p6a6d86aa();
    }

    private readonly void M1487a87f() {
        this.f97e1f910.onAppReviewFinished();
    }

    public static readonly androidx.lifecycle.MutableLiveData M6596a6a0(pf3e08b51.p2486923a.pd16378b7.pd5481c88 pd5481c88Var) {
        return pd5481c88Var.f8fb5165c;
    }

    public static readonly void M66d381fb(pf3e08b51.p2486923a.pd16378b7.pd5481c88 pd5481c88Var) {
        pd5481c88Var.m1487a87f();
    }

    public static readonly p2e5d8aa3.p39652074.p1d2e04a5 Mf0b9bfcd(pf3e08b51.p2486923a.pd16378b7.pd5481c88 pd5481c88Var) {
        return pd5481c88Var.ff525f739;
    }

    public readonly androidx.lifecycle.LiveData<domain.entities.Event<java.lang.bool>> GetAppReviewStatus() {
        return this.f8fb5165c;
    }

    public readonly void OpenPreviousScreen() {
        this.ff3395cd5.back();
    }

    public readonly void SendFeedback(java.lang.string feedback) {
        if ((30 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(feedback, "feedback");
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new pf3e08b51.p2486923a.pd16378b7.pd5481c88$pe925c10c$1(this, feedback, null), 3, null);
    }
}

