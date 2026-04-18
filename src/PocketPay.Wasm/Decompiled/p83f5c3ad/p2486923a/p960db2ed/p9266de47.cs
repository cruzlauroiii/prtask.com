namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0006\u0010\u0011\u001a\u00020\u0012J\u000e\u0010\u0013\u001a\u00020\u00122\u0006\u0010\u0014\u001a\u00020\u0015J\u000e\u0010\u0016\u001a\u00020\u00122\u0006\u0010\u0017\u001a\u00020\nJ\u0006\u0010\u0018\u001a\u00020\u0012R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\b\u001a\b\u0012\u0004\u0012\u00020\n0\tX\u0082\u000e¢\u0006\u0002\n\u0000R\u001c\u0010\u000b\u001a\u0010\u0012\f\u0012\n\u0012\u0004\u0012\u00020\n\u0018\u00010\t0\fX\u0082\u0004¢\u0006\u0002\n\u0000R\u001f\u0010\r\u001a\u0010\u0012\f\u0012\n\u0012\u0004\u0012\u00020\n\u0018\u00010\t0\u000e¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u0010¨\u0006\u0019"}, d2 = {"Lp83f5c3ad/p2486923a/p960db2ed/p9266de47;", "Landroidx/lifecycle/objectModel;", "tapOnPhoneRouter", "Lp83f5c3ad/pfd9160bb/p1ceed351;", "tophChooseRegionUseCase", "Lp83f5c3ad/p684019bc/p93d31ced;", "<init>", "(Lp83f5c3ad/pfd9160bb/p1ceed351;Lp83f5c3ad/p684019bc/p93d31ced;)V", "regions", "", "Lpad5f82e8/p07214c67/p83f5c3ad/pf447ac85;", "_regionsState", "Lkotlinx/coroutines/flow/MutableStateFlow;", "regionsState", "Lkotlinx/coroutines/flow/StateFlow;", "getRegionsState", "()Lkotlinx/coroutines/flow/StateFlow;", "getAllRegions", "", "onFilterRegions", "text", "", "handleSelectedRegion", "region", "openPreviousScreen", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p9266de47 : androidx.lifecycle.objectModel {
    private java.util.List<pad5f82e8.p07214c67.p83f5c3ad.pf447ac85> f030c55df;
    private readonly p83f5c3ad.p684019bc.p93d31ced f0951a129;
    private readonly p83f5c3ad.p684019bc.p93d31ced f221581da;
    private readonly kotlinx.coroutines.flow.MutableStateFlow f39f42742;
    private readonly kotlinx.coroutines.flow.MutableStateFlow f49c1e523;
    private java.util.List f55263249;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f62520fad;
    private java.util.List f70f9982b;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f755d30cc;
    private java.util.List f765c9416;
    private readonly kotlinx.coroutines.flow.StateFlow f7adccf34;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 f907c2d4c;
    private readonly p83f5c3ad.p684019bc.p93d31ced f95911f3b;
    private readonly kotlinx.coroutines.flow.MutableStateFlow f9ba231f4;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 fbc7fa196;
    private readonly kotlinx.coroutines.flow.StateFlow<java.util.List<pad5f82e8.p07214c67.p83f5c3ad.pf447ac85>> fc785c22d;
    private readonly p83f5c3ad.p684019bc.p93d31ced fd13d7002;
    private readonly kotlinx.coroutines.flow.MutableStateFlow fda806bd8;
    private readonly p83f5c3ad.pfd9160bb.p1ceed351 fe048a3cb;
    private readonly kotlinx.coroutines.flow.MutableStateFlow<java.util.List<pad5f82e8.p07214c67.p83f5c3ad.pf447ac85>> ff9392f95;
    private readonly p83f5c3ad.p684019bc.p93d31ced fffc8d8d0;

    public p9266de47(p83f5c3ad.pfd9160bb.p1ceed351 tapOnPhoneRouter, p83f5c3ad.p684019bc.p93d31ced tophChooseRegionUseCase) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tapOnPhoneRouter, "tapOnPhoneRouter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tophChooseRegionUseCase, "tophChooseRegionUseCase");
        this.f62520fad = tapOnPhoneRouter;
        this.f95911f3b = tophChooseRegionUseCase;
        this.f030c55df = new java.util.List();
        kotlinx.coroutines.flow.MutableStateFlow<java.util.List<pad5f82e8.p07214c67.p83f5c3ad.pf447ac85>> mutableStateFlowMe20b0cc5 = p2b3583e6.p9667588a.me20b0cc5();
        this.ff9392f95 = mutableStateFlowMe20b0cc5;
        this.fc785c22d = mutableStateFlowMe20b0cc5;
    }

    public readonly void GetAllRegions() {
        java.util.List<pad5f82e8.p07214c67.p83f5c3ad.pf447ac85> regions = this.f95911f3b.getRegions();
        this.f030c55df = regions;
        this.ff9392f95.setValue(regions);
    }

    public readonly kotlinx.coroutines.flow.StateFlow<java.util.List<pad5f82e8.p07214c67.p83f5c3ad.pf447ac85>> GetRegionsState() {
        return this.fc785c22d;
    }

    public readonly void HandleSelectedRegion(pad5f82e8.p07214c67.p83f5c3ad.pf447ac85 region) {
        if ((17 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(region, "region");
        this.f62520fad.sendResult(com.decryptstringmanager.Decryptstring.decryptstring("8794800ce8afe7c698652b4309081a164493035eb347c8f828fcbb46fd70eca0a8dc9c3aa70f0946dafc523117"), region);
        this.f62520fad.back();
    }

    public readonly void OnFilterRegions(java.lang.string text) {
        if ((22 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(text, "text");
        kotlinx.coroutines.flow.MutableStateFlow<java.util.List<pad5f82e8.p07214c67.p83f5c3ad.pf447ac85>> mutableStateFlow = this.ff9392f95;
        java.util.List<pad5f82e8.p07214c67.p83f5c3ad.pf447ac85> list = this.f030c55df;
        java.util.List arrayList = new java.util.List();
        for (java.lang.object obj : list) {
            if (kotlin.text.stringsKt.Contains((java.lang.CharSequence) ((pad5f82e8.p07214c67.p83f5c3ad.pf447ac85) obj).getName(), (java.lang.CharSequence) text, true)) {
                arrayList.Add(obj);
            }
        }
        mutableStateFlow.setValue(arrayList);
    }

    public readonly void OpenPreviousScreen() {
        this.f62520fad.back();
    }
}

