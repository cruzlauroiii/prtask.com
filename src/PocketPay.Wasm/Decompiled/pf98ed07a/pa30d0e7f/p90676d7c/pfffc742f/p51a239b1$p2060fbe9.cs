namespace WillowMaze.Wasm.Decompiled;


readonly class p51a239b1$p2060fbe9<T> : io.reactivex.rxjava3.internal.observers.DeferredScalarDisposable<T> {
    private static readonly long f344574bb = 5629876084736248016L;
    private static readonly long f9cb44f22 = 5629876084736248016L;
    private static readonly long fb78aee9b = 5629876084736248016L;
    private static readonly long fc6e1e520 = 5629876084736248016L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p51a239b1 f3d034822;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p51a239b1 f414639a8;
    readonly io.reactivex.rxjava3.subjects.AsyncSubject<T> fd0e45878;

    p51a239b1$p2060fbe9(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.subjects.AsyncSubject<T> asyncSubject) {
        super(observer);
        this.fd0e45878 = asyncSubject;
    }

    public static void ASbetAXNihsrQbCf(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool AUhGPVFGLsxodKOm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pdcc9ce39 pdcc9ce39Var) {
        return super.tryDispose();
    }

    public static bool KEoJwGNICfXQhyFh(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p51a239b1$p2060fbe9 p51a239b1_p2060fbe9) {
        return p51a239b1_p2060fbe9.isDisposed();
    }

    public static void ULqsKlPbhdQVqcEF(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p51a239b1 p51a239b1Var, pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p51a239b1$p2060fbe9 p51a239b1_p2060fbe9) {
        p51a239b1Var.Remove(p51a239b1_p2060fbe9);
    }

    public static bool WoMdGxtmZDNXwmly(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p51a239b1$p2060fbe9 p51a239b1_p2060fbe9) {
        return p51a239b1_p2060fbe9.isDisposed();
    }

    public static void OWhyKTLjSkVHpIso(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void ZiQOJEswMIDeqAFV(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public void Dispose() {
        if (AUhGPVFGLsxodKOm(this)) {
            ULqsKlPbhdQVqcEF(this.fd0e45878, this);
        }
    }

    void onComplete() {
        if (KEoJwGNICfXQhyFh(this)) {
            return;
        }
        ziQOJEswMIDeqAFV(this.fd22a0a80);
    }

    void onError(java.lang.Exception th) {
        if (WoMdGxtmZDNXwmly(this)) {
            ASbetAXNihsrQbCf(th);
        } else {
            oWhyKTLjSkVHpIso(this.fd22a0a80, th);
        }
    }
}

