namespace WillowMaze.Wasm.Decompiled;


readonly class pb37214dd$p299f366f<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.SingleObserver<T> {
    private static readonly long f2e85cf49 = 3323743579927613702L;
    private static readonly long f6279c63b = 3323743579927613702L;
    private static readonly long f7476fa6c = 3323743579927613702L;
    private static readonly long fc6e1e520 = 3323743579927613702L;
    readonly int f1816be17;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$pcbceec22 f57b63762;
    readonly int f6a992d55;
    readonly int f86c9bd0f;
    readonly int fc20bec2f;
    readonly io.reactivex.rxjava3.internal.operators.single.SingleZipArray$ZipCoordinator<T, object> fd0e45878;
    readonly int fffa29270;

    pb37214dd$p299f366f(io.reactivex.rxjava3.internal.operators.single.SingleZipArray$ZipCoordinator<T, object> singleZipArray$ZipCoordinator, int i) {
        this.fd0e45878 = singleZipArray$ZipCoordinator;
        this.f6a992d55 = i;
    }

    public static void VldczpqdwaaFEoiF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$pcbceec22 pb37214dd_pcbceec22, java.lang.object obj, int i) {
        pb37214dd_pcbceec22.innerSuccess(obj, i);
    }

    public static bool ZnjGKTYrvblbhNvC(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void GESJSxRoGPEBDjdV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$pcbceec22 pb37214dd_pcbceec22, java.lang.Exception th, int i) {
        pb37214dd_pcbceec22.innerError(th, i);
    }

    public static bool RJLPWHGLIkBrBIRd(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public void Dispose() {
        rJLPWHGLIkBrBIRd(this);
    }

    public override void OnError(java.lang.Exception th) {
        gESJSxRoGPEBDjdV(this.fd0e45878, th, this.f6a992d55);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        ZnjGKTYrvblbhNvC(this, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        VldczpqdwaaFEoiF(this.fd0e45878, t, this.f6a992d55);
    }
}

