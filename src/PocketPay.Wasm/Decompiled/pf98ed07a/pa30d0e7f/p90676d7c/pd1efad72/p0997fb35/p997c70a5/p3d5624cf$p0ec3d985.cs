namespace WillowMaze.Wasm.Decompiled;


readonly class p3d5624cf$p0ec3d985<T, R> : io.reactivex.rxjava3.core.Observer<T> {
    java.lang.Exception f0eeca75d;
    java.lang.Exception f33fc5976;
    java.lang.Exception f6140b39e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f687a3ddd;
    volatile bool f6b2ded51;
    readonly java.util.concurrent.atomic.object f6c30c478;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f73470de7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f8e5db443;
    readonly java.util.concurrent.atomic.object f909f49d1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$pcbceec22 f98635835;
    readonly io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> fa9d1cbf7;
    volatile bool fb5cc8ba0;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fbc3b0556 = new java.util.concurrent.atomic.object<>();
    java.lang.Exception fcb5e100e;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableZip$ZipCoordinator<T, R> fd0e45878;
    readonly java.util.concurrent.atomic.object fdb054b49;
    volatile bool fe5313b88;
    java.lang.Exception fe659fa94;
    readonly java.util.concurrent.atomic.object ff6be11e2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$pcbceec22 ff81f712c;

    p3d5624cf$p0ec3d985(io.reactivex.rxjava3.internal.operators.observable.ObservableZip$ZipCoordinator<T, R> observableZip$ZipCoordinator, int i) {
        this.fd0e45878 = observableZip$ZipCoordinator;
        this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(i);
    }

    public static void UlLAKKHdDvjqysGQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$pcbceec22 p3d5624cf_pcbceec22) {
        p3d5624cf_pcbceec22.drain();
    }

    public static bool YdJznNGtlUWZEidu(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void CrLYuBqHCKrlNRhE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$pcbceec22 p3d5624cf_pcbceec22) {
        p3d5624cf_pcbceec22.drain();
    }

    public static bool RrUORJriNSuwZXSY(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj) {
        return p50dc035cVar.offer(obj);
    }

    public static void UJzlhkySMlDDrmNY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$pcbceec22 p3d5624cf_pcbceec22) {
        p3d5624cf_pcbceec22.drain();
    }

    public static bool UPMHazlwsNlLdTmf(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public void Dispose() {
        uPMHazlwsNlLdTmf(this.fbc3b0556);
    }

    public override void OnComplete() {
        this.f6b2ded51 = true;
        crLYuBqHCKrlNRhE(this.fd0e45878);
    }

    public override void OnError(java.lang.Exception th) {
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        UlLAKKHdDvjqysGQ(this.fd0e45878);
    }

    public override void OnNext(T t) {
        rrUORJriNSuwZXSY(this.fa9d1cbf7, t);
        uJzlhkySMlDDrmNY(this.fd0e45878);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        YdJznNGtlUWZEidu(this.fbc3b0556, p7beea252Var);
    }
}

