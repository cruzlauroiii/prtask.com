namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\n\u0010\u0006\u001a\u0004\u0018\u00010\u0007H\u0016J\b\u0010\b\u001a\u00020\tH\u0016J\u0018\u0010\n\u001a\u00020\t2\b\u0010\u000b\u001a\u0004\u0018\u00010\fH\u0096@¢\u0006\u0002\u0010\rJ\u000e\u0010\u000e\u001a\u00020\tH\u0096@¢\u0006\u0002\u0010\u000fR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lp582ca3f7/pac143fb7/p99ada2d7;", "Lp582ca3f7/pac143fb7/p063acbd2;", "deepLinkQrDataRepository", "Lp582ca3f7/pb3f20355/p415c3100;", "<init>", "(Lp582ca3f7/pb3f20355/p415c3100;)V", "getDeeplinkData", "Lpad5f82e8/p07214c67/p4bd9354d/pf8e36245;", "clearDeeplinkData", "", "updateDeeplinkData", "data", "Landroid/net/Uri;", "(Landroid/net/Uri;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "loadDeeplinkData", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-employees-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p99ada2d7 : p582ca3f7.pac143fb7.p063acbd2 {
    private readonly p582ca3f7.pb3f20355.p415c3100 f631b5378;
    private readonly p582ca3f7.pb3f20355.p415c3100 f7d652776;

    public p99ada2d7(p582ca3f7.pb3f20355.p415c3100 p415c3100Var) {
        vEsyLamxmjlchaQG(p415c3100Var, "deepLinkQrDataRepository");
        this.f7d652776 = p415c3100Var;
    }

    public static void BTzdPSStHqKXnFyI(p582ca3f7.pb3f20355.p415c3100 p415c3100Var) {
        p415c3100Var.clearDeeplinkData();
    }

    public static java.lang.object EWiXcxsyzvVhmPnl(p582ca3f7.pb3f20355.p415c3100 p415c3100Var, kotlin.coroutines.Continuation continuation) {
        return p415c3100Var.loadDeeplinkData(continuation);
    }

    public static void WiaHQnhFnpFhQWmp(p582ca3f7.pb3f20355.p415c3100 p415c3100Var, android.net.Uri uri) {
        p415c3100Var.updateDeeplinkData(uri);
    }

    public static java.lang.object FLlJxlmehuVhPwbc() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static pad5f82e8.p07214c67.p4bd9354d.pf8e36245 QUFhpsIaCdUxkbyB(p582ca3f7.pb3f20355.p415c3100 p415c3100Var) {
        return p415c3100Var.getDeeplinkData();
    }

    public static void VEsyLamxmjlchaQG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override void ClearDeeplinkData() {
        BTzdPSStHqKXnFyI(this.f7d652776);
    }

    public override pad5f82e8.p07214c67.p4bd9354d.pf8e36245 GetDeeplinkData() {
        return qUFhpsIaCdUxkbyB(this.f7d652776);
    }

    public override java.lang.object LoadDeeplinkData(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objEWiXcxsyzvVhmPnl = EWiXcxsyzvVhmPnl(this.f7d652776, continuation);
        return objEWiXcxsyzvVhmPnl != fLlJxlmehuVhPwbc() ? kotlin.Unit.INSTANCE : objEWiXcxsyzvVhmPnl;
    }

    public override java.lang.object UpdateDeeplinkData(android.net.Uri uri, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        WiaHQnhFnpFhQWmp(this.f7d652776, uri);
        return kotlin.Unit.INSTANCE;
    }
}

