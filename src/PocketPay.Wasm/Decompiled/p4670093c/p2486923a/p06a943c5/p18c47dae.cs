namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0005\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u000e\u0010\u000f\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\n0\fJ\u0012\u0010\u0010\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000e0\r0\fJ\u0010\u0010\u0011\u001a\u00020\u00122\b\u0010\u0013\u001a\u0004\u0018\u00010\nJ\u000e\u0010\u0014\u001a\u00020\u00122\u0006\u0010\u0015\u001a\u00020\u000eJ\u0006\u0010\u0016\u001a\u00020\u0012R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0016\u0010\b\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\n0\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u000b\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000e0\r0\fX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0017"}, d2 = {"Lp4670093c/p2486923a/p06a943c5/p18c47dae;", "Landroidx/lifecycle/objectModel;", "paybackReceiptUseCase", "Lp4670093c/pac143fb7/pa36ef9b5;", "paybackRouter", "Lp4670093c/pfd9160bb/p1b3a5bf0;", "<init>", "(Lp4670093c/pac143fb7/pa36ef9b5;Lp4670093c/pfd9160bb/p1b3a5bf0;)V", "queryPositionsForPayback", "Landroidx/lifecycle/MutableLiveData;", "", "positionsForPaybackByQueryLiveData", "Landroidx/lifecycle/LiveData;", "", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "observeQueryPositionsForPayback", "observePositionsForPaybackByQuery", "searchByName", "", "query", "addPositionToReceipt", "position", "openPreviousScreen", "feature-payback-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p18c47dae : androidx.lifecycle.objectModel {
    private readonly androidx.lifecycle.LiveData f06886f95;
    private readonly p4670093c.pac143fb7.pa36ef9b5 f0d3e163c;
    private readonly androidx.lifecycle.LiveData f13824812;
    private readonly p4670093c.pfd9160bb.p1b3a5bf0 f13dbf8e2;
    private readonly p4670093c.pfd9160bb.p1b3a5bf0 f2b2a1791;
    private readonly androidx.lifecycle.MutableLiveData f4e7271c7;
    private readonly androidx.lifecycle.MutableLiveData f7fea81ca;
    private readonly p4670093c.pac143fb7.pa36ef9b5 f865f020c;
    private readonly androidx.lifecycle.MutableLiveData<java.lang.string> f9de8ce16;
    private readonly androidx.lifecycle.LiveData<java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465>> fd50d4672;
    private readonly p4670093c.pfd9160bb.p1b3a5bf0 fd996487f;
    private readonly androidx.lifecycle.LiveData fe654f200;

    public p18c47dae(p4670093c.pac143fb7.pa36ef9b5 paybackReceiptUseCase, p4670093c.pfd9160bb.p1b3a5bf0 paybackRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(paybackReceiptUseCase, "paybackReceiptUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(paybackRouter, "paybackRouter");
        this.f0d3e163c = paybackReceiptUseCase;
        this.f2b2a1791 = paybackRouter;
        androidx.lifecycle.MutableLiveData<java.lang.string> mutableLiveData = new androidx.lifecycle.MutableLiveData<>();
        this.f9de8ce16 = mutableLiveData;
        this.fd50d4672 = androidx.lifecycle.Transformations.switchDictionary(mutableLiveData, new p4670093c.p2486923a.p06a943c5.p18c47dae$pd41d8cd9$p95263d50(this));
    }

    public static androidx.lifecycle.LiveData M23cba9e3(p4670093c.p2486923a.p06a943c5.p18c47dae p18c47daeVar, java.lang.string str) {
        return m7b8c7a0f(p18c47daeVar, str);
    }

    private static readonly androidx.lifecycle.LiveData M7b8c7a0f(p4670093c.p2486923a.p06a943c5.p18c47dae p18c47daeVar, java.lang.string str) {
        if ((31 + 24) % 24 > 0) {
        }
        return androidx.lifecycle.CoroutineLiveDataKt.liveData$default(androidx.lifecycle.objectModelKt.getobjectModelScope(p18c47daeVar).getCoroutineobject().plus(kotlinx.coroutines.Dispatchers.getIO()), 0L, new p4670093c.p2486923a.p06a943c5.p18c47dae$pd50d4672$1$1(p18c47daeVar, str, null), 2, (java.lang.object) null);
    }

    public static readonly p4670093c.pfd9160bb.p1b3a5bf0 M89a7f193(p4670093c.p2486923a.p06a943c5.p18c47dae p18c47daeVar) {
        return p18c47daeVar.f2b2a1791;
    }

    public static readonly p4670093c.pac143fb7.pa36ef9b5 Md95a43c7(p4670093c.p2486923a.p06a943c5.p18c47dae p18c47daeVar) {
        return p18c47daeVar.f0d3e163c;
    }

    public readonly void AddPositionToReceipt(pad5f82e8.p07214c67.p1e11b989.pd031d465 position) {
        if ((20 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(position, "position");
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p4670093c.p2486923a.p06a943c5.p18c47dae$p234facb0$1(this, position, null), 3, null);
    }

    public readonly androidx.lifecycle.LiveData<java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465>> ObservePositionsForPaybackByQuery() {
        return this.fd50d4672;
    }

    public readonly androidx.lifecycle.LiveData<java.lang.string> ObserveQueryPositionsForPayback() {
        return this.f9de8ce16;
    }

    public readonly void OpenPreviousScreen() {
        this.f2b2a1791.back();
    }

    public readonly void SearchByName(java.lang.string query) {
        this.f9de8ce16.postValue(query);
    }
}

