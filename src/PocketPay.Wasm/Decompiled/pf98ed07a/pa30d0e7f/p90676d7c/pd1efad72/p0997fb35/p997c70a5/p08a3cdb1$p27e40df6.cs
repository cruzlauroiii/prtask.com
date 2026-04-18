namespace WillowMaze.Wasm.Decompiled;


readonly class p08a3cdb1$p27e40df6 : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<java.lang.object>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f37ae1c03 = 1883890389173668373L;
    private static readonly long f984f0e8e = 1883890389173668373L;
    private static readonly long fc6e1e520 = 1883890389173668373L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$pebedbfbf f0bea7baf;
    readonly bool f32f6a211;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$pebedbfbf f495ac707;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$pebedbfbf f8266adb3;
    readonly bool f9ae03ae4;
    readonly bool fcfbccb48;
    readonly bool fcfc3b8b8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$pebedbfbf fd0e45878;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$pebedbfbf ff0025692;

    p08a3cdb1$p27e40df6(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$pebedbfbf p08a3cdb1_pebedbfbf, bool z) {
        this.fd0e45878 = p08a3cdb1_pebedbfbf;
        this.fcfbccb48 = z;
    }

    public static void NqxZMzygkLEFkdjc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$pebedbfbf p08a3cdb1_pebedbfbf, java.lang.Exception th) {
        p08a3cdb1_pebedbfbf.innerError(th);
    }

    public static bool NymtNFFqsNgTNFsU(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void XHzlYqQGCoFHvZFD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$pebedbfbf p08a3cdb1_pebedbfbf, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p27e40df6 p08a3cdb1_p27e40df6) {
        p08a3cdb1_pebedbfbf.innerComplete(p08a3cdb1_p27e40df6);
    }

    public static java.lang.object YTfJRverQbnRZJFH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p27e40df6 p08a3cdb1_p27e40df6) {
        return p08a3cdb1_p27e40df6[);
    }

    public static void YbqHHIYESJsncMSa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$pebedbfbf p08a3cdb1_pebedbfbf, bool z, java.lang.object obj) {
        p08a3cdb1_pebedbfbf.innerValue(z, obj);
    }

    public static bool FRiCrYHpMYFCNfJE(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool IXSUxyffOeTPnyGv(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public override void Dispose() {
        fRiCrYHpMYFCNfJE(this);
    }

    public override bool IsDisposed() {
        return NymtNFFqsNgTNFsU((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) YTfJRverQbnRZJFH(this));
    }

    public override void OnComplete() {
        XHzlYqQGCoFHvZFD(this.fd0e45878, this);
    }

    public override void OnError(java.lang.Exception th) {
        NqxZMzygkLEFkdjc(this.fd0e45878, th);
    }

    public override void OnNext(java.lang.object obj) {
        YbqHHIYESJsncMSa(this.fd0e45878, this.fcfbccb48, obj);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        iXSUxyffOeTPnyGv(this, p7beea252Var);
    }
}

