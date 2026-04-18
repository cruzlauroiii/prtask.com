namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B'\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t¢\u0006\u0004\b\n\u0010\u000bJ\u0012\u0010\u0010\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000f0\u000e0\u0011J\u0006\u0010\u0012\u001a\u00020\u0013J\u0006\u0010\u0014\u001a\u00020\u0015J\u0006\u0010\u0016\u001a\u00020\u0015R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\f\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000f0\u000e0\rX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0017"}, d2 = {"Lp2e5d8aa3/p2486923a/p39652074/pf41f8ab3;", "Landroidx/lifecycle/objectModel;", "feedbackUseCase", "Lp2e5d8aa3/p39652074/p1d2e04a5;", "appConfig", "Lp2b3583e6/p22450232/pbd754d99;", "router", "Lp2e5d8aa3/pfd9160bb/pee785de8;", "resourceProvider", "Lp2b3583e6/p4a931512/p2e423cc6;", "<init>", "(Lp2e5d8aa3/p39652074/p1d2e04a5;Lp2b3583e6/p22450232/pbd754d99;Lp2e5d8aa3/pfd9160bb/pee785de8;Lp2b3583e6/p4a931512/p2e423cc6;)V", "requestCallStatus", "Landroidx/lifecycle/MutableLiveData;", "Lpad5f82e8/p07214c67/pa4ecfc70;", "", "observeRequestCallStatus", "Landroidx/lifecycle/LiveData;", "createEmailUri", "Landroid/net/Uri;", "requestCall", "", "onPreviousScreen", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf41f8ab3 : androidx.lifecycle.objectModel {
    private readonly p2b3583e6.p22450232.pbd754d99 f08705768;
    private readonly p2b3583e6.p4a931512.p2e423cc6 f19bc40b3;
    private readonly p2b3583e6.p4a931512.p2e423cc6 f2fbc2cf0;
    private readonly androidx.lifecycle.MutableLiveData f3dc6c90a;
    private readonly p2e5d8aa3.p39652074.p1d2e04a5 f44ad2a43;
    private readonly p2b3583e6.p4a931512.p2e423cc6 f4734ade7;
    private readonly p2b3583e6.p22450232.pbd754d99 f4bdeb460;
    private readonly androidx.lifecycle.MutableLiveData<domain.entities.Event<java.lang.object>> f5fe95aa0;
    private readonly p2b3583e6.p22450232.pbd754d99 f61bda0f8;
    private readonly androidx.lifecycle.MutableLiveData f8bdb7ab7;
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 fa5b917bf;
    private readonly p2b3583e6.p22450232.pbd754d99 fad495ecd;
    private readonly p2b3583e6.p4a931512.p2e423cc6 fad5bf141;
    private readonly p2b3583e6.p4a931512.p2e423cc6 fcd07fbbe;
    private readonly p2b3583e6.p22450232.pbd754d99 feced03cd;
    private readonly p2e5d8aa3.pfd9160bb.pee785de8 ff3395cd5;
    private readonly p2e5d8aa3.p39652074.p1d2e04a5 ff525f739;

    public pf41f8ab3(p2e5d8aa3.p39652074.p1d2e04a5 feedbackUseCase, p2b3583e6.p22450232.pbd754d99 appConfig, p2e5d8aa3.pfd9160bb.pee785de8 router, p2b3583e6.p4a931512.p2e423cc6 resourceProvider) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(feedbackUseCase, "feedbackUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(appConfig, "appConfig");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(resourceProvider, "resourceProvider");
        this.ff525f739 = feedbackUseCase;
        this.feced03cd = appConfig;
        this.ff3395cd5 = router;
        this.f4734ade7 = resourceProvider;
        this.f5fe95aa0 = new p2b3583e6.p6a6d86aa();
    }

    public static readonly androidx.lifecycle.MutableLiveData M86f0f95f(p2e5d8aa3.p2486923a.p39652074.pf41f8ab3 pf41f8ab3Var) {
        return pf41f8ab3Var.f5fe95aa0;
    }

    public static readonly p2e5d8aa3.p39652074.p1d2e04a5 Mf0b9bfcd(p2e5d8aa3.p2486923a.p39652074.pf41f8ab3 pf41f8ab3Var) {
        return pf41f8ab3Var.ff525f739;
    }

    public readonly android.net.Uri CreateEmailUri() {
        if ((17 + 11) % 11 > 0) {
        }
        return this.ff525f739.createEmailUri(this.f4734ade7.getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$string.settings_support_email), this.f4734ade7.getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$string.settings_email_title, this.feced03cd.getVersionName(), this.feced03cd.getOSVersion()));
    }

    public readonly androidx.lifecycle.LiveData<domain.entities.Event<java.lang.object>> ObserveRequestCallStatus() {
        return this.f5fe95aa0;
    }

    public readonly void OnPreviousScreen() {
        this.ff3395cd5.back();
    }

    public readonly void RequestCall() {
        if ((29 + 25) % 25 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p2e5d8aa3.p2486923a.p39652074.pf41f8ab3$pdac696d2$1(this, null), 3, null);
    }
}

