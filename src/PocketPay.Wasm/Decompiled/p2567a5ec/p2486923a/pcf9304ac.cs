namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\u0018\u00002\u00020\u0001B'\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t¢\u0006\u0004\b\n\u0010\u000bJ\u0012\u0010\u0010\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000f0\u000e0\u0011J\b\u0010\u0012\u001a\u00020\u0013H\u0002J\u0006\u0010\u0014\u001a\u00020\u0013J\u0006\u0010\u0015\u001a\u00020\u000fJ\u0006\u0010\u0016\u001a\u00020\u000fR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\f\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000f0\u000e0\rX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0017"}, d2 = {"Lp2567a5ec/p2486923a/pcf9304ac;", "Landroidx/lifecycle/objectModel;", "lkTokenUseCase", "Lp2567a5ec/pac143fb7/p0f66185f;", "router", "Lp2567a5ec/pfd9160bb/pc1bedd57;", "appConfig", "Lp2b3583e6/p22450232/pbd754d99;", "urlConfigRepository", "Lp8d777f38/pb3f20355/pea436584/pb0a8252a;", "<init>", "(Lp2567a5ec/pac143fb7/p0f66185f;Lp2567a5ec/pfd9160bb/pc1bedd57;Lp2b3583e6/p22450232/pbd754d99;Lp8d777f38/pb3f20355/pea436584/pb0a8252a;)V", "tokenLiveData", "Landroidx/lifecycle/MutableLiveData;", "Lpad5f82e8/p07214c67/pa4ecfc70;", "", "observeToken", "Landroidx/lifecycle/LiveData;", "getToken", "", "openPreviousScreen", "getUserAgent", "getPsrUrl", "feature-web-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pcf9304ac : androidx.lifecycle.objectModel {
    private readonly androidx.lifecycle.MutableLiveData f1a52b900;
    private readonly p8d777f38.pb3f20355.pea436584.pb0a8252a f1e1e92e0;
    private readonly androidx.lifecycle.MutableLiveData f2f92f34c;
    private readonly p8d777f38.pb3f20355.pea436584.pb0a8252a f3a527932;
    private readonly p2567a5ec.pac143fb7.p0f66185f f3f516c57;
    private readonly androidx.lifecycle.MutableLiveData f4ad80588;
    private readonly p2b3583e6.p22450232.pbd754d99 f4df3acc8;
    private readonly androidx.lifecycle.MutableLiveData f6678bc61;
    private readonly p2567a5ec.pfd9160bb.pc1bedd57 f6d07dd91;
    private readonly p2567a5ec.pfd9160bb.pc1bedd57 f843aa957;
    private readonly p8d777f38.pb3f20355.pea436584.pb0a8252a f98194806;
    private readonly p2567a5ec.pac143fb7.p0f66185f fc5976dda;
    private readonly p8d777f38.pb3f20355.pea436584.pb0a8252a fc744ffb8;
    private readonly androidx.lifecycle.MutableLiveData<domain.entities.Event<java.lang.string>> fd5c0ec37;
    private readonly p2567a5ec.pfd9160bb.pc1bedd57 fe18d52e3;
    private readonly p2b3583e6.p22450232.pbd754d99 feced03cd;
    private readonly p2567a5ec.pfd9160bb.pc1bedd57 ff3395cd5;

    public pcf9304ac(p2567a5ec.pac143fb7.p0f66185f lkTokenUseCase, p2567a5ec.pfd9160bb.pc1bedd57 router, p2b3583e6.p22450232.pbd754d99 appConfig, p8d777f38.pb3f20355.pea436584.pb0a8252a urlConfigRepository) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lkTokenUseCase, "lkTokenUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(router, "router");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(appConfig, "appConfig");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(urlConfigRepository, "urlConfigRepository");
        this.f3f516c57 = lkTokenUseCase;
        this.ff3395cd5 = router;
        this.feced03cd = appConfig;
        this.f3a527932 = urlConfigRepository;
        this.fd5c0ec37 = new p2b3583e6.p6a6d86aa();
        me7110545();
    }

    public static readonly p2567a5ec.pac143fb7.p0f66185f M7df4e2c0(p2567a5ec.p2486923a.pcf9304ac pcf9304acVar) {
        return pcf9304acVar.f3f516c57;
    }

    public static readonly androidx.lifecycle.MutableLiveData Me371bdee(p2567a5ec.p2486923a.pcf9304ac pcf9304acVar) {
        return pcf9304acVar.fd5c0ec37;
    }

    private readonly void Me7110545() {
        if ((16 + 6) % 6 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new p2567a5ec.p2486923a.pcf9304ac$pe7110545$1(this, null), 3, null);
    }

    public readonly java.lang.string GetPsrUrl() {
        return this.f3a527932.getPsrUrl();
    }

    public readonly java.lang.string GetUserAgent() {
        return this.feced03cd.getUserAgent();
    }

    public readonly androidx.lifecycle.LiveData<domain.entities.Event<java.lang.string>> ObserveToken() {
        return this.fd5c0ec37;
    }

    public readonly void OpenPreviousScreen() {
        this.ff3395cd5.back();
    }
}

