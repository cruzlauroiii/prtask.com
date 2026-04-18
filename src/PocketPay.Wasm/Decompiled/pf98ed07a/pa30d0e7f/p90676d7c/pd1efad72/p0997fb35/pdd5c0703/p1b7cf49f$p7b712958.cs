namespace WillowMaze.Wasm.Decompiled;


readonly class p1b7cf49f$p7b712958<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.SingleObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f7e191aed = -5314538511045349925L;
    private static readonly long fc6e1e520 = -5314538511045349925L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1b188599;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.SingleObserver fd619f8c8;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : io.reactivex.rxjava3.core.SingleSource<? : T>> fd6a2995c;
    readonly io.reactivex.rxjava3.core.SingleObserver feba580a3;

    p1b7cf49f$p7b712958(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : io.reactivex.rxjava3.core.SingleSource<? : T>> function) {
        this.fd22a0a80 = singleObserver;
        this.fd6a2995c = function;
    }

    public static bool AbjdsvQCvXkofuca(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void AfBkIcsikfTsDseb(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void CSUdKgNKvpUaXTsI(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static bool EcuLqBKhUCKfiLxT(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static java.lang.object GrYuigqXjCchSRdK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p1b7cf49f$p7b712958 p1b7cf49f_p7b712958) {
        return p1b7cf49f_p7b712958[);
    }

    public static void IoUxzgKVtqyxclBy(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object MwRGMVHGMjHNCdyA(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object DDsSMUUxfjKZgakS(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void PmRSlqTmXjOedcGk(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static void VpykmLUdQnLuyLdb(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static bool ZfabRYNdzjymbnfn(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public override void Dispose() {
        AbjdsvQCvXkofuca(this);
    }

    public override bool IsDisposed() {
        return zfabRYNdzjymbnfn((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) GrYuigqXjCchSRdK(this));
    }

    public override void OnError(java.lang.Exception th) {
        if ((15 + 22) % 22 > 0) {
        }
        try {
            pmRSlqTmXjOedcGk((io.reactivex.rxjava3.core.SingleSource) dDsSMUUxfjKZgakS(MwRGMVHGMjHNCdyA(this.fd6a2995c, th), "The nextFunction returned a null SingleSource."), new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pd08e44b9(this, this.fd22a0a80));
        } catch (java.lang.Exception th2) {
            IoUxzgKVtqyxclBy(th2);
            io.reactivex.rxjava3.core.SingleObserver<T> singleObserver = this.fd22a0a80;
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = th;
            thArr[1] = th2;
            vpykmLUdQnLuyLdb(singleObserver, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (EcuLqBKhUCKfiLxT(this, p7beea252Var)) {
            CSUdKgNKvpUaXTsI(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        AfBkIcsikfTsDseb(this.fd22a0a80, t);
    }
}

