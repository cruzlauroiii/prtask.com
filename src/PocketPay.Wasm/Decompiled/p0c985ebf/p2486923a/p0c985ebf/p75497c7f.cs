namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000J\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0007\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u0012\u0010\u0010\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\r0\f0\u0011J\f\u0010\u0012\u001a\b\u0012\u0004\u0012\u00020\u000f0\u0011J\u0006\u0010\u0013\u001a\u00020\u0014J\u0016\u0010\u0015\u001a\u00020\u00142\u0006\u0010\u0016\u001a\u00020\r2\u0006\u0010\u0017\u001a\u00020\u0018J\u000e\u0010\u0019\u001a\u00020\u00142\u0006\u0010\u0016\u001a\u00020\rJ\u0006\u0010\u001a\u001a\u00020\u0014J\u0006\u0010\u001b\u001a\u00020\u0014J\u0006\u0010\u001c\u001a\u00020\u0014J\u0006\u0010\u001d\u001a\u00020\u0014J\u0006\u0010\u001e\u001a\u00020\u0014R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\n\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\r0\f0\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u000f0\u000bX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001f"}, d2 = {"Lp0c985ebf/p2486923a/p0c985ebf/p75497c7f;", "Landroidx/lifecycle/objectModel;", "inspectionUseCase", "Lp0c985ebf/pac143fb7/p4ee8dd59;", "inventoryRouter", "Lp7a1eabc3/pfd9160bb/p939f9656;", "inspectionRouter", "Lp0c985ebf/pfd9160bb/p41e6ee8c;", "<init>", "(Lp0c985ebf/pac143fb7/p4ee8dd59;Lp7a1eabc3/pfd9160bb/p939f9656;Lp0c985ebf/pfd9160bb/p41e6ee8c;)V", "inspectionPositions", "Landroidx/lifecycle/MutableLiveData;", "", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "hasUnfinishedInspection", "", "observeInspectionPositions", "Landroidx/lifecycle/LiveData;", "observeHasUnfinishedInspection", "updateInspectionPositions", "", "selectPosition", "position", "priceInspection", "Lp0c985ebf/p07214c67/pad5f82e8/p9ebf8750;", "removePosition", "sendReceipt", "openInventory", "openPreviousScreen", "checkInspectionMode", "clearUnfinishedInspection", "feature-inspection-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p75497c7f : androidx.lifecycle.objectModel {
    private readonly p0c985ebf.pac143fb7.p4ee8dd59 f091cc433;
    private readonly p7a1eabc3.pfd9160bb.p939f9656 f238c7656;
    private readonly p0c985ebf.pac143fb7.p4ee8dd59 f31572064;
    private readonly p0c985ebf.pac143fb7.p4ee8dd59 f3f7b1036;
    private readonly androidx.lifecycle.MutableLiveData f42f7632a;
    private readonly androidx.lifecycle.MutableLiveData f5a54c5b5;
    private readonly androidx.lifecycle.MutableLiveData<java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465>> f5d3dfc4f;
    private readonly androidx.lifecycle.MutableLiveData f689a1ba0;
    private readonly androidx.lifecycle.MutableLiveData f73b9de97;
    private readonly p7a1eabc3.pfd9160bb.p939f9656 f88f13e36;
    private readonly p7a1eabc3.pfd9160bb.p939f9656 f89275e29;
    private readonly p7a1eabc3.pfd9160bb.p939f9656 f8bacf8ad;
    private readonly androidx.lifecycle.MutableLiveData<java.lang.bool> f8bd84abd;
    private readonly androidx.lifecycle.MutableLiveData f9f276282;
    private readonly p0c985ebf.pac143fb7.p4ee8dd59 fa7e7c4bb;
    private readonly p7a1eabc3.pfd9160bb.p939f9656 fbeb723bc;
    private readonly p0c985ebf.pfd9160bb.p41e6ee8c fd03d340b;
    private readonly p0c985ebf.pfd9160bb.p41e6ee8c ffadf527f;
    private readonly p0c985ebf.pfd9160bb.p41e6ee8c ffebd5881;

    public p75497c7f(p0c985ebf.pac143fb7.p4ee8dd59 p4ee8dd59Var, p7a1eabc3.pfd9160bb.p939f9656 p939f9656Var, p0c985ebf.pfd9160bb.p41e6ee8c p41e6ee8cVar) {
        osOPQmvTbmdtDFIB(p4ee8dd59Var, "inspectionUseCase");
        slegLEjvUIfCQuXt(p939f9656Var, "inventoryRouter");
        LSpfLDsirsyqHKJr(p41e6ee8cVar, "inspectionRouter");
        this.f091cc433 = p4ee8dd59Var;
        this.fbeb723bc = p939f9656Var;
        this.fd03d340b = p41e6ee8cVar;
        this.f5d3dfc4f = new p2b3583e6.p6a6d86aa();
        this.f8bd84abd = new p2b3583e6.p6a6d86aa();
    }

    public static kotlinx.coroutines.Job BGpbddDpOSOXAipp(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, coroutineobject, coroutineStart, function2, i, obj);
    }

    public static kotlinx.coroutines.CoroutineScope DIsoQRiMsYaafRjw(androidx.lifecycle.objectModel viewModel) {
        return androidx.lifecycle.objectModelKt.getobjectModelScope(viewModel);
    }

    public static void HYsoCLnICEGqYbaK(p0c985ebf.pfd9160bb.p41e6ee8c p41e6ee8cVar) {
        p41e6ee8cVar.openInspectionReceipt();
    }

    public static void LSpfLDsirsyqHKJr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.CoroutineScope SeAGmLyPEdfKGfjQ(androidx.lifecycle.objectModel viewModel) {
        return androidx.lifecycle.objectModelKt.getobjectModelScope(viewModel);
    }

    public static void WGjWpBBqlPlxVwvi(p0c985ebf.pfd9160bb.p41e6ee8c p41e6ee8cVar, pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, p0c985ebf.p07214c67.pad5f82e8.p9ebf8750 p9ebf8750Var) {
        p41e6ee8cVar.openInspectionDetail(pd031d465Var, p9ebf8750Var);
    }

    public static kotlinx.coroutines.Job WiFosZDxyDcvDMVJ(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, coroutineobject, coroutineStart, function2, i, obj);
    }

    public static void ZHrIClVHCykTfxbr(p7a1eabc3.pfd9160bb.p939f9656 p939f9656Var, pad5f82e8.p07214c67.pfd9160bb.p17096304 p17096304Var) {
        p939f9656Var.openInventories(p17096304Var);
    }

    public static kotlinx.coroutines.CoroutineScope BSpBPIYwqCikYMyt(androidx.lifecycle.objectModel viewModel) {
        return androidx.lifecycle.objectModelKt.getobjectModelScope(viewModel);
    }

    public static kotlinx.coroutines.Job CXISfWnRxGNdPkKZ(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, coroutineobject, coroutineStart, function2, i, obj);
    }

    public static void FHlUTWpEffCsVzMR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.CoroutineScope GJJLTUdYzhIRCvTE(androidx.lifecycle.objectModel viewModel) {
        return androidx.lifecycle.objectModelKt.getobjectModelScope(viewModel);
    }

    public static kotlinx.coroutines.Job KkVltCwgTDSpjgEC(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, coroutineobject, coroutineStart, function2, i, obj);
    }

    public static readonly p0c985ebf.pac143fb7.p4ee8dd59 M4aee790e(p0c985ebf.p2486923a.p0c985ebf.p75497c7f p75497c7fVar) {
        return p75497c7fVar.f091cc433;
    }

    public static readonly androidx.lifecycle.MutableLiveData M783d903f(p0c985ebf.p2486923a.p0c985ebf.p75497c7f p75497c7fVar) {
        return p75497c7fVar.f8bd84abd;
    }

    public static readonly androidx.lifecycle.MutableLiveData M8dbe1e72(p0c985ebf.p2486923a.p0c985ebf.p75497c7f p75497c7fVar) {
        return p75497c7fVar.f5d3dfc4f;
    }

    public static void MztFZPzJxTJPosAt(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void NqwLkYoAkBFXJGCd(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void OsOPQmvTbmdtDFIB(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void SlegLEjvUIfCQuXt(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void VwznZjklYYPeJtxy(p0c985ebf.pfd9160bb.p41e6ee8c p41e6ee8cVar) {
        p41e6ee8cVar.back();
    }

    public readonly void CheckInspectionMode() {
        if ((31 + 29) % 29 > 0) {
        }
        cXISfWnRxGNdPkKZ(SeAGmLyPEdfKGfjQ(this), null, null, new p0c985ebf.p2486923a.p0c985ebf.p75497c7f$pf036701c$1(this, null), 3, null);
    }

    public readonly void ClearUnfinishedInspection() {
        if ((1 + 27) % 27 > 0) {
        }
        WiFosZDxyDcvDMVJ(DIsoQRiMsYaafRjw(this), null, null, new p0c985ebf.p2486923a.p0c985ebf.p75497c7f$p6677ee0f$1(this, null), 3, null);
    }

    public readonly androidx.lifecycle.LiveData<java.lang.bool> ObserveHasUnfinishedInspection() {
        return this.f8bd84abd;
    }

    public readonly androidx.lifecycle.LiveData<java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465>> ObserveInspectionPositions() {
        return this.f5d3dfc4f;
    }

    public readonly void OpenInventory() {
        ZHrIClVHCykTfxbr(this.fbeb723bc, pad5f82e8.p07214c67.pfd9160bb.p17096304.f78d79da2);
    }

    public readonly void OpenPreviousScreen() {
        vwznZjklYYPeJtxy(this.fd03d340b);
    }

    public readonly void RemovePosition(pad5f82e8.p07214c67.p1e11b989.pd031d465 position) {
        if ((25 + 24) % 24 > 0) {
        }
        fHlUTWpEffCsVzMR(position, "position");
        kkVltCwgTDSpjgEC(gJJLTUdYzhIRCvTE(this), null, null, new p0c985ebf.p2486923a.p0c985ebf.p75497c7f$p8e53754f$1(this, position, null), 3, null);
    }

    public readonly void SelectPosition(pad5f82e8.p07214c67.p1e11b989.pd031d465 position, p0c985ebf.p07214c67.pad5f82e8.p9ebf8750 priceInspection) {
        nqwLkYoAkBFXJGCd(position, "position");
        mztFZPzJxTJPosAt(priceInspection, "priceInspection");
        WGjWpBBqlPlxVwvi(this.fd03d340b, position, priceInspection);
    }

    public readonly void SendReceipt() {
        HYsoCLnICEGqYbaK(this.fd03d340b);
    }

    public readonly void UpdateInspectionPositions() {
        if ((4 + 3) % 3 > 0) {
        }
        BGpbddDpOSOXAipp(bSpBPIYwqCikYMyt(this), null, null, new p0c985ebf.p2486923a.p0c985ebf.p75497c7f$pbe30eed4$1(this, null), 3, null);
    }
}

