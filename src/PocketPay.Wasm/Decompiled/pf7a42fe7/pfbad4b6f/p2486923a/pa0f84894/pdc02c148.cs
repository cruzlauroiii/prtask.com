namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0006\u0010\u000f\u001a\u00020\u0010J\u0006\u0010\r\u001a\u00020\u0010J\u0006\u0010\u0011\u001a\u00020\u0010R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\b\u001a\b\u0012\u0004\u0012\u00020\n0\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u0017\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\n0\f¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000e¨\u0006\u0012"}, d2 = {"Lpf7a42fe7/pfbad4b6f/p2486923a/pa0f84894/pdc02c148;", "Landroidx/lifecycle/objectModel;", "router", "Lpf7a42fe7/pfbad4b6f/pfd9160bb/p48cb2d85;", "urlConfigRepository", "Lp8d777f38/pb3f20355/pea436584/pb0a8252a;", "<init>", "(Lpf7a42fe7/pfbad4b6f/pfd9160bb/p48cb2d85;Lp8d777f38/pb3f20355/pea436584/pb0a8252a;)V", "_gCashUrl", "Landroidx/lifecycle/MutableLiveData;", "", "gCashUrl", "Landroidx/lifecycle/LiveData;", "getGCashUrl", "()Landroidx/lifecycle/LiveData;", "openPhoneVerification", "", "finishChain", "feature-phone-verification-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pdc02c148 : androidx.lifecycle.objectModel {
    private readonly androidx.lifecycle.MutableLiveData f161cbd50;
    private readonly p8d777f38.pb3f20355.pea436584.pb0a8252a f3a527932;
    private readonly p8d777f38.pb3f20355.pea436584.pb0a8252a f3ef4c39c;
    private readonly androidx.lifecycle.MutableLiveData<java.lang.string> f5cf48355;
    private readonly pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85 f660a2d60;
    private readonly androidx.lifecycle.MutableLiveData f7c76c05b;
    private readonly androidx.lifecycle.LiveData f7f18b53d;
    private readonly androidx.lifecycle.LiveData f816721b6;
    private readonly androidx.lifecycle.LiveData<java.lang.string> f844a0c00;
    private readonly androidx.lifecycle.LiveData f9c1bc990;
    private readonly androidx.lifecycle.MutableLiveData fa378e089;
    private readonly androidx.lifecycle.LiveData fd5bcc2d8;
    private readonly pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85 ff3395cd5;
    private readonly androidx.lifecycle.MutableLiveData ffe134197;

    public pdc02c148(pf7a42fe7.pfbad4b6f.pfd9160bb.p48cb2d85 router, p8d777f38.pb3f20355.pea436584.pb0a8252a urlConfigRepository) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(urlConfigRepository, "urlConfigRepository");
        this.ff3395cd5 = router;
        this.f3a527932 = urlConfigRepository;
        p2b3583e6.p6a6d86aa p6a6d86aaVar = new p2b3583e6.p6a6d86aa();
        this.f5cf48355 = p6a6d86aaVar;
        this.f844a0c00 = p6a6d86aaVar;
    }

    public static readonly p8d777f38.pb3f20355.pea436584.pb0a8252a M0d4818a9(pf7a42fe7.pfbad4b6f.p2486923a.pa0f84894.pdc02c148 pdc02c148Var) {
        return pdc02c148Var.f3a527932;
    }

    public static readonly androidx.lifecycle.MutableLiveData Mc1803245(pf7a42fe7.pfbad4b6f.p2486923a.pa0f84894.pdc02c148 pdc02c148Var) {
        return pdc02c148Var.f5cf48355;
    }

    public readonly void FinishChain() {
        this.ff3395cd5.finishChain();
    }

    public readonly androidx.lifecycle.LiveData<java.lang.string> GetGCashUrl() {
        return this.f844a0c00;
    }

    public readonly void M3905getGCashUrl() {
        if ((16 + 21) % 21 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new pf7a42fe7.pfbad4b6f.p2486923a.pa0f84894.pdc02c148$p1524ab87$1(this, null), 3, null);
    }

    public readonly void OpenPhoneVerification() {
        this.ff3395cd5.openPhoneVerification();
    }
}

