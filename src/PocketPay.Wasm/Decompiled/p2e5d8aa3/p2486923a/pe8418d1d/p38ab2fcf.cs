namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0012\u0010\f\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000b0\n0\rJ\u0006\u0010\u000e\u001a\u00020\u000fJ\u0006\u0010\u0010\u001a\u00020\u000fR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\b\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000b0\n0\tX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Lp2e5d8aa3/p2486923a/pe8418d1d/p38ab2fcf;", "Landroidx/lifecycle/objectModel;", "verifyUseCase", "Lp2e5d8aa3/pe8418d1d/pac143fb7/pbdabceb1;", "router", "Lp2e5d8aa3/pfd9160bb/pee785de8;", "<init>", "(Lp2e5d8aa3/pe8418d1d/pac143fb7/pbdabceb1;Lp2e5d8aa3/pfd9160bb/pee785de8;)V", "verifyCode", "Landroidx/lifecycle/MutableLiveData;", "Lpad5f82e8/p07214c67/pa4ecfc70;", "", "observeVerifyCode", "Landroidx/lifecycle/LiveData;", "getVerifyCode", "", "openPreviousScreen", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p38ab2fcf : androidx.lifecycle.objectModel {
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 f1b96db48;
    private readonly p2e5d8aa3.pe8418d1d.pac143fb7.pbdabceb1 f4711fa58;
    private readonly p2e5d8aa3.pe8418d1d.pac143fb7.pbdabceb1 f653f33df;
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 f744cc247;
    private readonly androidx.lifecycle.MutableLiveData<domain.entities.Event<java.lang.string>> f7fc340a3;
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 f87b1f066;
    private readonly p2e5d8aa3.pe8418d1d.pac143fb7.pbdabceb1 fa0105d84;
    private readonly androidx.lifecycle.MutableLiveData fb9cc50ac;
    private readonly p2e5d8aa3.pe8418d1d.pac143fb7.pbdabceb1 fec3ea0e0;
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 ff3395cd5;

    public p38ab2fcf(p2e5d8aa3.pe8418d1d.pac143fb7.pbdabceb1 verifyUseCase, p2e5d8aa3.pfd9160bb.pee785de8 router) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(verifyUseCase, "verifyUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        this.fa0105d84 = verifyUseCase;
        this.ff3395cd5 = router;
        this.f7fc340a3 = new p2b3583e6.p6a6d86aa();
    }

    public static readonly androidx.lifecycle.MutableLiveData M67b98dd3(p2e5d8aa3.p2486923a.pe8418d1d.p38ab2fcf p38ab2fcfVar) {
        return p38ab2fcfVar.f7fc340a3;
    }

    public static readonly p2e5d8aa3.pe8418d1d.pac143fb7.pbdabceb1 Med27d92d(p2e5d8aa3.p2486923a.pe8418d1d.p38ab2fcf p38ab2fcfVar) {
        return p38ab2fcfVar.fa0105d84;
    }

    public readonly void GetVerifyCode() {
        if ((19 + 24) % 24 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p2e5d8aa3.p2486923a.pe8418d1d.p38ab2fcf$p789cc582$1(this, null), 3, null);
    }

    public readonly androidx.lifecycle.LiveData<domain.entities.Event<java.lang.string>> ObserveVerifyCode() {
        return this.f7fc340a3;
    }

    public readonly void OpenPreviousScreen() {
        this.ff3395cd5.back();
    }
}

