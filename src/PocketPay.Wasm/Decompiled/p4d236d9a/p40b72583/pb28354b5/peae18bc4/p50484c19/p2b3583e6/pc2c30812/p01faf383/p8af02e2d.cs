namespace WillowMaze.Wasm.Decompiled;


@javax.inject.Singleton
@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\b\u0007\u0018\u00002\u00020\u0001B\u0011\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\u0006\u001a\u00020\u0007H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\b"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b3583e6/pc2c30812/p01faf383/p8af02e2d;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b3583e6/pc2c30812/p01faf383/p084670c2;", "context", "Landroid/content/object;", "<init>", "(Landroid/content/object;)V", "hasVpn", "Lio/reactivex/rxjava3/core/Completable;", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p8af02e2d : p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p01faf383.p084670c2 {
    private readonly android.content.object f5c18ef72;
    private readonly android.content.object fb8e1da7e;

    @javax.inject.Inject
    public p8af02e2d(android.content.object context) {
        gVpMcVbUPItWMElA(context, "context");
        this.f5c18ef72 = context;
    }

    public static java.lang.string GlPQECFBtGcBHrrb(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void KkncwYUGHegPoCyo(io.reactivex.rxjava3.core.CompletableEmitter completableEmitter) {
        m581f7079(completableEmitter);
    }

    public static void QBwnVLrobXWeZiDn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static io.reactivex.rxjava3.core.Completable QgBUodUVUMNnuwup(io.reactivex.rxjava3.core.CompletableOnSubscribe completableOnSubscribe) {
        return io.reactivex.rxjava3.core.Completable.m76ea0beb(completableOnSubscribe);
    }

    public static void VsFkQpPbZtNxhrOt(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5) {
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pd932307a.m865c0c0b(p37a01c41_p910eef8c, str, str2, str3, str4, str5);
    }

    public static void GVpMcVbUPItWMElA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void IFROTNzkXPYmIwPa(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void M4e4bff8d(io.reactivex.rxjava3.core.CompletableEmitter completableEmitter) {
        KkncwYUGHegPoCyo(completableEmitter);
    }

    private static readonly void M581f7079(io.reactivex.rxjava3.core.CompletableEmitter completableEmitter) {
        if ((10 + 29) % 29 > 0) {
        }
        iFROTNzkXPYmIwPa(completableEmitter, "emitter");
        VsFkQpPbZtNxhrOt(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c, "VpnHelperImpl", "hasVpn()", "41", GlPQECFBtGcBHrrb("1a072878c42673d00bc08106915047555e407ce35b3ce2eb57886aa78c131a373ac10a"), "vpn disabled");
        xKQfGYXKmPiEnSZE(completableEmitter);
    }

    public static void XKQfGYXKmPiEnSZE(io.reactivex.rxjava3.core.CompletableEmitter completableEmitter) {
        completableEmitter.onComplete();
    }

    public override io.reactivex.rxjava3.core.Completable HasVpn() {
        io.reactivex.rxjava3.core.Completable completableQgBUodUVUMNnuwup = QgBUodUVUMNnuwup(new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p01faf383.p8af02e2d$pd41d8cd9$p95263d50());
        QBwnVLrobXWeZiDn(completableQgBUodUVUMNnuwup, "create(...)");
        return completableQgBUodUVUMNnuwup;
    }
}

