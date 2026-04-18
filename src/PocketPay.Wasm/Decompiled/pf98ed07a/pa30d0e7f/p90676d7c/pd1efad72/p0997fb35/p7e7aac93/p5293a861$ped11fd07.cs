namespace WillowMaze.Wasm.Decompiled;


readonly class p5293a861$ped11fd07<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.MaybeObserver<T> {
    private static readonly long f5a8837ed = 3323743579927613702L;
    private static readonly long fc6e1e520 = 3323743579927613702L;
    private static readonly long fed59cb0f = 3323743579927613702L;
    readonly int f6a992d55;
    readonly int f709a1dc9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$pcbceec22 f81acb36f;
    readonly int fa0496706;
    readonly int fa5f63d27;
    readonly io.reactivex.rxjava3.internal.operators.maybe.MaybeZipArray$ZipCoordinator<T, object> fd0e45878;

    p5293a861$ped11fd07(io.reactivex.rxjava3.internal.operators.maybe.MaybeZipArray$ZipCoordinator<T, object> maybeZipArray$ZipCoordinator, int i) {
        this.fd0e45878 = maybeZipArray$ZipCoordinator;
        this.f6a992d55 = i;
    }

    public static bool QvzDjZXjrwRDtDGq(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool UNqAfklmYjRSHvlK(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void UnJemLKifrWqKqhG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$pcbceec22 p5293a861_pcbceec22, java.lang.Exception th, int i) {
        p5293a861_pcbceec22.innerError(th, i);
    }

    public static void AARVGZXTLIYRctuE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$pcbceec22 p5293a861_pcbceec22, java.lang.object obj, int i) {
        p5293a861_pcbceec22.innerSuccess(obj, i);
    }

    public static void JcgkgCLSmLivsSyY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$pcbceec22 p5293a861_pcbceec22, int i) {
        p5293a861_pcbceec22.innerComplete(i);
    }

    public void Dispose() {
        UNqAfklmYjRSHvlK(this);
    }

    public override void OnComplete() {
        jcgkgCLSmLivsSyY(this.fd0e45878, this.f6a992d55);
    }

    public override void OnError(java.lang.Exception th) {
        UnJemLKifrWqKqhG(this.fd0e45878, th, this.f6a992d55);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        QvzDjZXjrwRDtDGq(this, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        aARVGZXTLIYRctuE(this.fd0e45878, t, this.f6a992d55);
    }
}

