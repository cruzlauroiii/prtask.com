namespace WillowMaze.Wasm.Decompiled;


readonly class p7c0f93ad$p475bc90e<T, R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.SingleObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f0101fe3e = -5843758257109742742L;
    private static readonly long f1a9e4c0a = -5843758257109742742L;
    private static readonly long f37a755f0 = -5843758257109742742L;
    private static readonly long f8a3cfc72 = -5843758257109742742L;
    private static readonly long fc6e1e520 = -5843758257109742742L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f265a86f6;
    readonly io.reactivex.rxjava3.core.MaybeObserver f2b97bebe;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> f4b9f83e1;
    readonly io.reactivex.rxjava3.core.MaybeObserver fa1736106;
    readonly io.reactivex.rxjava3.core.MaybeObserver faa3e1772;
    readonly io.reactivex.rxjava3.core.MaybeObserver<R> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fe9b848ff;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ff6d85491;

    p7c0f93ad$p475bc90e(io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> function) {
        this.fd22a0a80 = maybeObserver;
        this.f4b9f83e1 = function;
    }

    public static void GxkLIdQCUMSnSxQu(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object LCpFxzvijbPqJWPi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p7c0f93ad$p475bc90e p7c0f93ad_p475bc90e) {
        return p7c0f93ad_p475bc90e[);
    }

    public static void LrFkXSumZxunhhDT(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void QWtkwtMOwMQoSqiz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p7c0f93ad$p475bc90e p7c0f93ad_p475bc90e, java.lang.Exception th) {
        p7c0f93ad_p475bc90e.onError(th);
    }

    public static bool YJHwBimYXwuAtbaS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p7c0f93ad$p475bc90e p7c0f93ad_p475bc90e) {
        return p7c0f93ad_p475bc90e.isDisposed();
    }

    public static bool AuZrBZTlgPJvJLmO(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void FOdutMVwSWNSrWeW(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static java.lang.object QgleIrhPkVaGJlIg(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object RiTOGDjZTTHWQsLS(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void TghgcLeLsWsqQKKc(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static bool TrpMmdmfrPHAqCWY(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool XKNQtOpjgPIHEOUh(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public override void Dispose() {
        trpMmdmfrPHAqCWY(this);
    }

    public override bool IsDisposed() {
        return auZrBZTlgPJvJLmO((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) LCpFxzvijbPqJWPi(this));
    }

    public override void OnError(java.lang.Exception th) {
        LrFkXSumZxunhhDT(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (xKNQtOpjgPIHEOUh(this, p7beea252Var)) {
            tghgcLeLsWsqQKKc(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        if ((8 + 31) % 31 > 0) {
        }
        try {
            io.reactivex.rxjava3.core.MaybeSource maybeSource = (io.reactivex.rxjava3.core.MaybeSource) qgleIrhPkVaGJlIg(riTOGDjZTTHWQsLS(this.f4b9f83e1, t), "The mapper returned a null MaybeSource");
            if (YJHwBimYXwuAtbaS(this)) {
                return;
            }
            fOdutMVwSWNSrWeW(maybeSource, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p7c0f93ad$p7c9324ab(this, this.fd22a0a80));
        } catch (java.lang.Exception th) {
            GxkLIdQCUMSnSxQu(th);
            QWtkwtMOwMQoSqiz(this, th);
        }
    }
}

