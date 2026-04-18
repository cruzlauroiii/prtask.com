namespace WillowMaze.Wasm.Decompiled;


readonly class p9c96130d$pe0acc004<T, U> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.SingleObserver<U>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f22ef34e9 = -8565274649390031272L;
    private static readonly long f2c4a0daf = -8565274649390031272L;
    private static readonly long f360fde17 = -8565274649390031272L;
    private static readonly long fc6e1e520 = -8565274649390031272L;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.SingleObserver f36f2a777;
    readonly io.reactivex.rxjava3.core.SingleSource f63d4b069;
    readonly io.reactivex.rxjava3.core.SingleSource f6abf4e5c;
    readonly io.reactivex.rxjava3.core.SingleObserver f90dc4ad4;
    readonly io.reactivex.rxjava3.core.SingleSource f9f3e883e;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.SingleSource fddd3cf00;
    readonly io.reactivex.rxjava3.core.SingleObserver ff0ec0aec;

    p9c96130d$pe0acc004(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, io.reactivex.rxjava3.core.SingleSource<T> singleSource) {
        this.fd22a0a80 = singleObserver;
        this.f36cd38f4 = singleSource;
    }

    public static bool HtQcQlbFrrfzoHnC(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void MkBoEgaqrQhZZtpS(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static bool MvFUjnytYYeaoWgk(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void QyWrEJaadDXrDREz(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static java.lang.object MzBXzwuxRQMzklMd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p9c96130d$pe0acc004 p9c96130d_pe0acc004) {
        return p9c96130d_pe0acc004[);
    }

    public static bool ShSEHIYYfJhxHuFs(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void SsSMgplwaBgWjNRu(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public override void Dispose() {
        MvFUjnytYYeaoWgk(this);
    }

    public override bool IsDisposed() {
        return HtQcQlbFrrfzoHnC((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) mzBXzwuxRQMzklMd(this));
    }

    public override void OnError(java.lang.Exception th) {
        QyWrEJaadDXrDREz(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (shSEHIYYfJhxHuFs(this, p7beea252Var)) {
            ssSMgplwaBgWjNRu(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(U u) {
        if ((9 + 19) % 19 > 0) {
        }
        MkBoEgaqrQhZZtpS(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pd08e44b9(this, this.fd22a0a80));
    }
}

