namespace WillowMaze.Wasm.Decompiled;


@javax.inject.Singleton
@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\b\u0001\u0018\u00002\u00020\u0001B\u0019\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u000e\u0010\b\u001a\b\u0012\u0004\u0012\u00020\n0\tH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/pcff54971/pf4d5b76a/p06299358/p25b3e52f;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/pcff54971/pf4d5b76a/p06299358/pc52f9114;", "nfcCalibrationReader", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b36d337/p593616de/p06299358/p0bf719df/pf0af16f9;", "nfcCardCommunicationManager", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b3583e6/pc2c30812/pcaf97d07/p4c6bf409;", "<init>", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b36d337/p593616de/p06299358/p0bf719df/pf0af16f9;Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b3583e6/pc2c30812/pcaf97d07/p4c6bf409;)V", "calibrate", "Lio/reactivex/rxjava3/core/Single;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/pcff54971/pf4d5b76a/p06299358/p98364e7f;", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p25b3e52f : p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.pc52f9114 {
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 f0183b80e;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 f1083f536;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 f807e48b0;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 f9fb78a72;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 fb62f1efe;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 fdd030d0c;

    @javax.inject.Inject
    public p25b3e52f(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 pf0af16f9Var, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 p4c6bf409Var) {
        IBiJbPZrSYgbjYrS(pf0af16f9Var, "nfcCalibrationReader");
        kKlSFbGvFouffXTF(p4c6bf409Var, "nfcCardCommunicationManager");
        this.f0183b80e = pf0af16f9Var;
        this.f9fb78a72 = p4c6bf409Var;
    }

    public static void EQxTadSYXzJjqtnl(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) throws p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p4ea5a370 {
        m9abce873(p25b3e52fVar, singleEmitter);
    }

    public static void EQxTadSYXzJjqtnl(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EQxTadSYXzJjqtnl(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EQxTadSYXzJjqtnl(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GCLQlpbuOOeJXQgW(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 pf0af16f9Var, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GCLQlpbuOOeJXQgW(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 pf0af16f9Var, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GCLQlpbuOOeJXQgW(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 pf0af16f9Var, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool GCLQlpbuOOeJXQgW(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 pf0af16f9Var) {
        return pf0af16f9Var.connectReader();
    }

    public static void IBiJbPZrSYgbjYrS(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void IBiJbPZrSYgbjYrS(java.lang.object obj, java.lang.string str, char c, java.lang.string str2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IBiJbPZrSYgbjYrS(java.lang.object obj, java.lang.string str, java.lang.string str2, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IBiJbPZrSYgbjYrS(java.lang.object obj, java.lang.string str, short s, java.lang.string str2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static io.reactivex.rxjava3.core.Single IEjIlYbYninFaxfJ(io.reactivex.rxjava3.core.Single single, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var) {
        return single.onErrorResumeNext(p86408593Var);
    }

    public static void IEjIlYbYninFaxfJ(io.reactivex.rxjava3.core.Single single, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IEjIlYbYninFaxfJ(io.reactivex.rxjava3.core.Single single, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IEjIlYbYninFaxfJ(io.reactivex.rxjava3.core.Single single, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IKcMcxNnSKobPGpX(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 pf0af16f9Var, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IKcMcxNnSKobPGpX(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 pf0af16f9Var, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IKcMcxNnSKobPGpX(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 pf0af16f9Var, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool IKcMcxNnSKobPGpX(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 pf0af16f9Var) {
        return pf0af16f9Var.disconnectReader();
    }

    public static io.reactivex.rxjava3.core.Single IpdgFiKMzCarwxUb(io.reactivex.rxjava3.core.SingleOnSubscribe singleOnSubscribe) {
        return io.reactivex.rxjava3.core.Single.m76ea0beb(singleOnSubscribe);
    }

    public static void IpdgFiKMzCarwxUb(io.reactivex.rxjava3.core.SingleOnSubscribe singleOnSubscribe, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IpdgFiKMzCarwxUb(io.reactivex.rxjava3.core.SingleOnSubscribe singleOnSubscribe, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IpdgFiKMzCarwxUb(io.reactivex.rxjava3.core.SingleOnSubscribe singleOnSubscribe, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IwAlOAGXVxBzPqNE(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.pa73d862b pa73d862bVar, int i, java.lang.object obj) {
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pd932307a.m7bc63c4e(p37a01c41_p910eef8c, str, str2, str3, str4, str5, pa73d862bVar, i, obj);
    }

    public static void IwAlOAGXVxBzPqNE(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.pa73d862b pa73d862bVar, int i, java.lang.object obj, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IwAlOAGXVxBzPqNE(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.pa73d862b pa73d862bVar, int i, java.lang.object obj, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IwAlOAGXVxBzPqNE(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.pa73d862b pa73d862bVar, int i, java.lang.object obj, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.pa73d862b KMWxjUgkzobeAAVD(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p4ea5a370 p4ea5a370Var) {
        return p4ea5a370Var.getCode();
    }

    public static void KMWxjUgkzobeAAVD(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p4ea5a370 p4ea5a370Var, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KMWxjUgkzobeAAVD(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p4ea5a370 p4ea5a370Var, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KMWxjUgkzobeAAVD(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p4ea5a370 p4ea5a370Var, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LwwICBfSYTVmJtJd(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 p4c6bf409Var, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164 p2484c164Var) {
        p4c6bf409Var.updateNfcStatus(p2484c164Var);
    }

    public static void LwwICBfSYTVmJtJd(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 p4c6bf409Var, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164 p2484c164Var, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LwwICBfSYTVmJtJd(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 p4c6bf409Var, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164 p2484c164Var, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LwwICBfSYTVmJtJd(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 p4c6bf409Var, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164 p2484c164Var, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MxdaXHhrBwHddpIJ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p4ea5a370 p4ea5a370Var) {
        return p4ea5a370Var.getMessage();
    }

    public static void MxdaXHhrBwHddpIJ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p4ea5a370 p4ea5a370Var, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MxdaXHhrBwHddpIJ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p4ea5a370 p4ea5a370Var, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MxdaXHhrBwHddpIJ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p4ea5a370 p4ea5a370Var, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PyGqAXKixWsvhzTX(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 pf0af16f9Var, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 p4c6bf409Var) {
        pf0af16f9Var.setNfcCardCommunicationManager(p4c6bf409Var);
    }

    public static void PyGqAXKixWsvhzTX(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 pf0af16f9Var, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 p4c6bf409Var, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PyGqAXKixWsvhzTX(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 pf0af16f9Var, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 p4c6bf409Var, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PyGqAXKixWsvhzTX(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 pf0af16f9Var, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 p4c6bf409Var, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VcrVHeSblqBcLKvO(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 pf0af16f9Var, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VcrVHeSblqBcLKvO(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 pf0af16f9Var, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VcrVHeSblqBcLKvO(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 pf0af16f9Var, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool VcrVHeSblqBcLKvO(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 pf0af16f9Var) {
        return pf0af16f9Var.disconnectReader();
    }

    public static io.reactivex.rxjava3.core.Single XPojoClLiGPwNVLQ(io.reactivex.rxjava3.core.Single single, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var) {
        return single.doOnError(pf8afcf86Var);
    }

    public static void XPojoClLiGPwNVLQ(io.reactivex.rxjava3.core.Single single, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XPojoClLiGPwNVLQ(io.reactivex.rxjava3.core.Single single, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XPojoClLiGPwNVLQ(io.reactivex.rxjava3.core.Single single, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static io.reactivex.rxjava3.core.Single XZdDNvRjnTVljzhY(io.reactivex.rxjava3.core.Single single, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) {
        return single.doOnDispose(p004bf6c9Var);
    }

    public static void XZdDNvRjnTVljzhY(io.reactivex.rxjava3.core.Single single, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XZdDNvRjnTVljzhY(io.reactivex.rxjava3.core.Single single, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XZdDNvRjnTVljzhY(io.reactivex.rxjava3.core.Single single, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XuCMCPxLWUoqJhSc(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar) {
        m0bb36735(p25b3e52fVar);
    }

    public static void XuCMCPxLWUoqJhSc(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XuCMCPxLWUoqJhSc(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XuCMCPxLWUoqJhSc(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static long XvUmrYiPfJFogDEI() {
        if ((23 + 2) % 2 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static void XvUmrYiPfJFogDEI(char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XvUmrYiPfJFogDEI(char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XvUmrYiPfJFogDEI(java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZIipoRcWFBDJkPMo(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ZIipoRcWFBDJkPMo(java.lang.object obj, java.lang.string str, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZIipoRcWFBDJkPMo(java.lang.object obj, java.lang.string str, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZIipoRcWFBDJkPMo(java.lang.object obj, java.lang.string str, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EqoAvCAadlPTumdp(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void EqoAvCAadlPTumdp(java.lang.object obj, java.lang.string str, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EqoAvCAadlPTumdp(java.lang.object obj, java.lang.string str, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EqoAvCAadlPTumdp(java.lang.object obj, java.lang.string str, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KKlSFbGvFouffXTF(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void KKlSFbGvFouffXTF(java.lang.object obj, java.lang.string str, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KKlSFbGvFouffXTF(java.lang.object obj, java.lang.string str, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KKlSFbGvFouffXTF(java.lang.object obj, java.lang.string str, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private static readonly void M0bb36735(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar) {
        VcrVHeSblqBcLKvO(p25b3e52fVar.f0183b80e);
    }

    private static readonly void M0bb36735(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private static readonly void M0bb36735(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private static readonly void M0bb36735(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void M1ccfc0b4(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        EQxTadSYXzJjqtnl(p25b3e52fVar, singleEmitter);
    }

    public static void M1ccfc0b4(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void M1ccfc0b4(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void M1ccfc0b4(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 M8fce6219(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar) {
        return p25b3e52fVar.f0183b80e;
    }

    public static readonly void M8fce6219(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static readonly void M8fce6219(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static readonly void M8fce6219(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private static readonly void M9abce873(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) throws p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p4ea5a370 {
        if ((23 + 2) % 2 > 0) {
        }
        ZIipoRcWFBDJkPMo(singleEmitter, "emitter");
        PyGqAXKixWsvhzTX(p25b3e52fVar.f0183b80e, p25b3e52fVar.f9fb78a72);
        LwwICBfSYTVmJtJd(p25b3e52fVar.f9fb78a72, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164.f4b90437c);
        long jXvUmrYiPfJFogDEI = XvUmrYiPfJFogDEI();
        IKcMcxNnSKobPGpX(p25b3e52fVar.f0183b80e);
        if (!GCLQlpbuOOeJXQgW(p25b3e52fVar.f0183b80e)) {
            p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p4ea5a370 p4ea5a370Var = new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p4ea5a370(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.pa73d862b.f1792db20);
            IwAlOAGXVxBzPqNE(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c, "NfcCalibrationManagerImpl", "calibrate()", "27", null, MxdaXHhrBwHddpIJ(p4ea5a370Var), KMWxjUgkzobeAAVD(p4ea5a370Var), 8, null);
            throw p4ea5a370Var;
        }
        if (uLEellGHlmbRBugg(p25b3e52fVar.f0183b80e)) {
            yDMNpqbDNMqLbjhJ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c, "NfcCalibrationManagerImpl", "calibrate()", "37", yksHCeTMbjfrLqOO("af988ed0d2acee7d088320490fe8ea2345a7798a05835d5e5a8c4b4506644f8f"), "success calibrate");
            whxHGpeHOiCmnIpg(singleEmitter, new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p98364e7f(yLlgwoRkkqpObsXc() - jXvUmrYiPfJFogDEI));
        }
    }

    private static readonly void M9abce873(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private static readonly void M9abce873(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private static readonly void M9abce873(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Md33c6393(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar) {
        XuCMCPxLWUoqJhSc(p25b3e52fVar);
    }

    public static void Md33c6393(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void Md33c6393(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void Md33c6393(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f p25b3e52fVar, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ULEellGHlmbRBugg(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 pf0af16f9Var, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ULEellGHlmbRBugg(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 pf0af16f9Var, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ULEellGHlmbRBugg(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 pf0af16f9Var, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool ULEellGHlmbRBugg(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p593616de.p06299358.p0bf719df.pf0af16f9 pf0af16f9Var) {
        return pf0af16f9Var.connectCard();
    }

    public static void WhxHGpeHOiCmnIpg(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.object obj) {
        singleEmitter.onSuccess(obj);
    }

    public static void WhxHGpeHOiCmnIpg(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.object obj, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WhxHGpeHOiCmnIpg(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.object obj, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WhxHGpeHOiCmnIpg(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.object obj, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YDMNpqbDNMqLbjhJ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5) {
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pd932307a.m865c0c0b(p37a01c41_p910eef8c, str, str2, str3, str4, str5);
    }

    public static void YDMNpqbDNMqLbjhJ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, char c, bool z, java.lang.string str6, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YDMNpqbDNMqLbjhJ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, int i, bool z, char c, java.lang.string str6) {
        double d = (42 * 210) + 210;
    }

    public static void YDMNpqbDNMqLbjhJ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, bool z, java.lang.string str6, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static long YLlgwoRkkqpObsXc() {
        if ((2 + 15) % 15 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static void YLlgwoRkkqpObsXc(int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YLlgwoRkkqpObsXc(java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YLlgwoRkkqpObsXc(short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string YksHCeTMbjfrLqOO(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void YksHCeTMbjfrLqOO(java.lang.string str, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YksHCeTMbjfrLqOO(java.lang.string str, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YksHCeTMbjfrLqOO(java.lang.string str, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public override io.reactivex.rxjava3.core.Single<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p98364e7f> Calibrate() {
        if ((16 + 18) % 18 > 0) {
        }
        io.reactivex.rxjava3.core.Single<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p98364e7f> singleXZdDNvRjnTVljzhY = XZdDNvRjnTVljzhY(XPojoClLiGPwNVLQ(IEjIlYbYninFaxfJ(IpdgFiKMzCarwxUb(new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f$pd41d8cd9$p95263d50(this)), p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f$p1002c0e1$2.f76425f17), new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f$p1002c0e1$3(this)), new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pcff54971.pf4d5b76a.p06299358.p25b3e52f$pd41d8cd9$pcca4ef0e(this));
        eqoAvCAadlPTumdp(singleXZdDNvRjnTVljzhY, "doOnDispose(...)");
        return singleXZdDNvRjnTVljzhY;
    }
}

