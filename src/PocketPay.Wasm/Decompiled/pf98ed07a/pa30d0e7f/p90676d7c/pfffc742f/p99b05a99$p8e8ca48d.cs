namespace WillowMaze.Wasm.Decompiled;


readonly class p99b05a99$p8e8ca48d<T> : java.util.concurrent.atomic.Atomicbool : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f5da95807 = 3562861878281475070L;
    private static readonly long fc6e1e520 = 3562861878281475070L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99 f1845c8f8;
    readonly io.reactivex.rxjava3.core.Observer f44995b4b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99 f51159b48;
    readonly io.reactivex.rxjava3.core.Observer f80ae23e5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99 f8723b61c;
    readonly io.reactivex.rxjava3.subjects.PublishSubject<T> fd0e45878;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;

    p99b05a99$p8e8ca48d(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.subjects.PublishSubject<T> publishSubject) {
        this.fd22a0a80 = observer;
        this.fd0e45878 = publishSubject;
    }

    public static void FNwHgjboUDJwQPMD(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99 p99b05a99Var, pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99$p8e8ca48d p99b05a99_p8e8ca48d) {
        p99b05a99Var.Remove(p99b05a99_p8e8ca48d);
    }

    public static bool LvkmFbEWMRNvplCi(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99$p8e8ca48d p99b05a99_p8e8ca48d) {
        return p99b05a99_p8e8ca48d[);
    }

    public static bool NDDJPGSCBMSIvrYZ(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99$p8e8ca48d p99b05a99_p8e8ca48d) {
        return p99b05a99_p8e8ca48d[);
    }

    public static bool NObhENaeTMgBcwQT(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99$p8e8ca48d p99b05a99_p8e8ca48d) {
        return p99b05a99_p8e8ca48d[);
    }

    public static bool OclTdtoHMJplkqjf(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99$p8e8ca48d p99b05a99_p8e8ca48d, bool z, bool z2) {
        return p99b05a99_p8e8ca48d.compareAndHashSet(z, z2);
    }

    public static bool PmuGvSmYFMEOTpxb(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99$p8e8ca48d p99b05a99_p8e8ca48d) {
        return p99b05a99_p8e8ca48d[);
    }

    public static void WPQkdHtIzugzNgrh(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void BlmRMLJliTFiLeup(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void LXQaUSlEShSIwyCE(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void MtfQZCLheXjkSsPu(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public override void Dispose() {
        if ((9 + 10) % 10 > 0) {
        }
        if (OclTdtoHMJplkqjf(this, false, true)) {
            FNwHgjboUDJwQPMD(this.fd0e45878, this);
        }
    }

    public override bool IsDisposed() {
        return LvkmFbEWMRNvplCi(this);
    }

    public void OnComplete() {
        if (NDDJPGSCBMSIvrYZ(this)) {
            return;
        }
        blmRMLJliTFiLeup(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if (PmuGvSmYFMEOTpxb(this)) {
            WPQkdHtIzugzNgrh(th);
        } else {
            mtfQZCLheXjkSsPu(this.fd22a0a80, th);
        }
    }

    public void OnNext(T t) {
        if (NObhENaeTMgBcwQT(this)) {
            return;
        }
        lXQaUSlEShSIwyCE(this.fd22a0a80, t);
    }
}

