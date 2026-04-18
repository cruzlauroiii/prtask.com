namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000e\u0010\u0006\u001a\u00020\u0007H\u0096@¢\u0006\u0002\u0010\bR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Lp83f5c3ad/pb3f20355/pf53c099d;", "Lp83f5c3ad/pb3f20355/pa11ea85a;", "tophLibrary", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pff5fedb1;", "<init>", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/pff5fedb1;)V", "initTapOnPhone", "", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf53c099d : p83f5c3ad.pb3f20355.pa11ea85a {
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pff5fedb1 f1823d8ab;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pff5fedb1 f52f00285;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pff5fedb1 f5a1976db;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pff5fedb1 fd88d4cee;

    public pf53c099d(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pff5fedb1 tophLibrary) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tophLibrary, "tophLibrary");
        this.fd88d4cee = tophLibrary;
    }

    public override java.lang.object InitTapOnPhone(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if (this.fd88d4cee.getSecurityProvider().getActivationManager().isReady()) {
            return kotlin.Unit.INSTANCE;
        }
        java.lang.object objAwait = kotlinx.coroutines.rx3.RxAwaitKt.await(this.fd88d4cee.getSecurityProvider().performLibraryVerification(), continuation);
        return objAwait != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objAwait;
    }
}

