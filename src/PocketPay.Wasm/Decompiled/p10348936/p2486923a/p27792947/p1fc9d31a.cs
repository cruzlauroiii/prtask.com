namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u0012\u0010\u000e\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\r0\f0\u000fJ\u0014\u0010\u0010\u001a\u00020\u00112\f\u0010\u0012\u001a\b\u0012\u0004\u0012\u00020\r0\fJ\u0006\u0010\u0013\u001a\u00020\u0014J\u000e\u0010\u0015\u001a\u00020\u00112\u0006\u0010\u0016\u001a\u00020\u0014J\u0006\u0010\u0017\u001a\u00020\u0011R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\n\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\r0\f0\u000bX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0018"}, d2 = {"Lp10348936/p2486923a/p27792947/p1fc9d31a;", "Landroidx/lifecycle/objectModel;", "inventorizationDetailsUseCase", "Lp10348936/pac143fb7/pd1b06cbc;", "inventorizationDetailsFilterUseCase", "Lp10348936/pac143fb7/p72a4cee5;", "router", "Lp10348936/pfd9160bb/pabe3770e;", "<init>", "(Lp10348936/pac143fb7/pd1b06cbc;Lp10348936/pac143fb7/p72a4cee5;Lp10348936/pfd9160bb/pabe3770e;)V", "positionsLiveData", "Landroidx/lifecycle/MutableLiveData;", "", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "observePositions", "Landroidx/lifecycle/LiveData;", "getFilteredPositions", "", "positions", "getFilter", "Lp10348936/pf5e638cc/p0729f18f;", "updateFilter", "filter", "openPreviousScreen", "feature-inventorization-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p1fc9d31a : androidx.lifecycle.objectModel {
    private readonly p10348936.pac143fb7.p72a4cee5 f036e9cf5;
    private readonly androidx.lifecycle.MutableLiveData<java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465>> f53ab5538;
    private readonly p10348936.pac143fb7.pd1b06cbc f649792e1;
    private readonly p10348936.pac143fb7.p72a4cee5 f753c51c8;
    private readonly p10348936.pac143fb7.p72a4cee5 faf6e2740;
    private readonly p10348936.pfd9160bb.pabe3770e fb1b1e703;
    private readonly p10348936.pac143fb7.pd1b06cbc fd0128296;
    private readonly p10348936.pac143fb7.p72a4cee5 fdf0321f2;
    private readonly p10348936.pac143fb7.p72a4cee5 fe508ff94;
    private readonly p10348936.pfd9160bb.pabe3770e ff3395cd5;
    private readonly androidx.lifecycle.MutableLiveData ff427f476;

    public p1fc9d31a(p10348936.pac143fb7.pd1b06cbc pd1b06cbcVar, p10348936.pac143fb7.p72a4cee5 p72a4cee5Var, p10348936.pfd9160bb.pabe3770e pabe3770eVar) {
        XxiJovHKatMVuxum(pd1b06cbcVar, "inventorizationDetailsUseCase");
        ErtTZFBWbEcCtATC(p72a4cee5Var, "inventorizationDetailsFilterUseCase");
        XeNjzmAavjYwcOEu(pabe3770eVar, "router");
        this.fd0128296 = pd1b06cbcVar;
        this.faf6e2740 = p72a4cee5Var;
        this.ff3395cd5 = pabe3770eVar;
        this.f53ab5538 = new androidx.lifecycle.MutableLiveData<>();
    }

    public static void ErtTZFBWbEcCtATC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void IdZbKSUYmwYbTwrp(p10348936.pac143fb7.p72a4cee5 p72a4cee5Var, p10348936.pf5e638cc.p0729f18f p0729f18fVar) {
        p72a4cee5Var.updateFilter(p0729f18fVar);
    }

    public static p10348936.pf5e638cc.p0729f18f KyZGToQCJjDZfRfk(p10348936.pac143fb7.p72a4cee5 p72a4cee5Var) {
        return p72a4cee5Var.getFilter();
    }

    public static void XeNjzmAavjYwcOEu(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XxiJovHKatMVuxum(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.CoroutineScope CgPyEoKALTrQkEDc(androidx.lifecycle.objectModel viewModel) {
        return androidx.lifecycle.objectModelKt.getobjectModelScope(viewModel);
    }

    public static void GQZBGdDinNambVwt(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void JhHKuwXaJzgIpKLN(p10348936.pfd9160bb.pabe3770e pabe3770eVar) {
        pabe3770eVar.back();
    }

    public static readonly androidx.lifecycle.MutableLiveData M0cb146b5(p10348936.p2486923a.p27792947.p1fc9d31a p1fc9d31aVar) {
        return p1fc9d31aVar.f53ab5538;
    }

    public static readonly p10348936.pac143fb7.p72a4cee5 M4054dac4(p10348936.p2486923a.p27792947.p1fc9d31a p1fc9d31aVar) {
        return p1fc9d31aVar.faf6e2740;
    }

    public static readonly p10348936.pac143fb7.pd1b06cbc Mc2681fb0(p10348936.p2486923a.p27792947.p1fc9d31a p1fc9d31aVar) {
        return p1fc9d31aVar.fd0128296;
    }

    public static kotlinx.coroutines.Job PBAhrWIwMiwQkAmZ(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, coroutineobject, coroutineStart, function2, i, obj);
    }

    public static void VadWWRqbbkmsyOnz(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public readonly p10348936.pf5e638cc.p0729f18f GetFilter() {
        return KyZGToQCJjDZfRfk(this.faf6e2740);
    }

    public readonly void GetFilteredPositions(java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> positions) {
        if ((13 + 27) % 27 > 0) {
        }
        vadWWRqbbkmsyOnz(positions, "positions");
        pBAhrWIwMiwQkAmZ(cgPyEoKALTrQkEDc(this), null, null, new p10348936.p2486923a.p27792947.p1fc9d31a$p8b35e451$1(this, positions, null), 3, null);
    }

    public readonly androidx.lifecycle.LiveData<java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465>> ObservePositions() {
        return this.f53ab5538;
    }

    public readonly void OpenPreviousScreen() {
        jhHKuwXaJzgIpKLN(this.ff3395cd5);
    }

    public readonly void UpdateFilter(p10348936.pf5e638cc.p0729f18f filter) {
        gQZBGdDinNambVwt(filter, "filter");
        IdZbKSUYmwYbTwrp(this.faf6e2740, filter);
    }
}

