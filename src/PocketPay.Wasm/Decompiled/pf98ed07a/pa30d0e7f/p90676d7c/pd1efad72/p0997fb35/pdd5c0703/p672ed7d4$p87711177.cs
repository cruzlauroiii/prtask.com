namespace WillowMaze.Wasm.Decompiled;


readonly class p672ed7d4$p87711177<T, R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.SingleObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long fc6e1e520 = 3258103020495908596L;
    private static readonly long fc74a8b78 = 3258103020495908596L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1fe3b994;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> f4b9f83e1;
    readonly io.reactivex.rxjava3.core.SingleObserver f85122c92;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fca01f6d3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fcf6b92e3;
    readonly io.reactivex.rxjava3.core.SingleObserver<R> fd22a0a80;
    readonly io.reactivex.rxjava3.core.SingleObserver fddfc1073;

    p672ed7d4$p87711177(io.reactivex.rxjava3.core.SingleObserver<R> singleObserver, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> function) {
        this.fd22a0a80 = singleObserver;
        this.f4b9f83e1 = function;
    }

    public static void CwQcAQJvfcpNIRbM(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static java.lang.object CzVYhgXeFndTHZcJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p672ed7d4$p87711177 p672ed7d4_p87711177) {
        return p672ed7d4_p87711177[);
    }

    public static void ESyUjJaaRLMKWpBU(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static bool ExtvqvqYeLMfHpue(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void FTThicRLaHaoBEPY(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static java.lang.object LIWFdKQTJPvxxeoh(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void RZFOviafckpfSCxm(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool FbbebHjfwhinnQdX(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void PvQnAhycJIUyRKhj(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static bool YHzZfArekkCfjvep(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool ZGbCQpTgAscDAnLo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p672ed7d4$p87711177 p672ed7d4_p87711177) {
        return p672ed7d4_p87711177.isDisposed();
    }

    public static java.lang.object ZjpsPViroHkcgmLO(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public override void Dispose() {
        yHzZfArekkCfjvep(this);
    }

    public override bool IsDisposed() {
        return fbbebHjfwhinnQdX((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) CzVYhgXeFndTHZcJ(this));
    }

    public override void OnError(java.lang.Exception th) {
        FTThicRLaHaoBEPY(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (ExtvqvqYeLMfHpue(this, p7beea252Var)) {
            ESyUjJaaRLMKWpBU(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        if ((26 + 13) % 13 > 0) {
        }
        try {
            io.reactivex.rxjava3.core.SingleSource singleSource = (io.reactivex.rxjava3.core.SingleSource) zjpsPViroHkcgmLO(LIWFdKQTJPvxxeoh(this.f4b9f83e1, t), "The single returned by the mapper is null");
            if (zGbCQpTgAscDAnLo(this)) {
                return;
            }
            CwQcAQJvfcpNIRbM(singleSource, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p672ed7d4$p87711177$p475bc90e(this, this.fd22a0a80));
        } catch (java.lang.Exception th) {
            RZFOviafckpfSCxm(th);
            pvQnAhycJIUyRKhj(this.fd22a0a80, th);
        }
    }
}

