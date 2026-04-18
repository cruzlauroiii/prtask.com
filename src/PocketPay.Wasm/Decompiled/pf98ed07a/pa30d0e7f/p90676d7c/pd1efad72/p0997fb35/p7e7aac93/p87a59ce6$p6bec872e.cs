namespace WillowMaze.Wasm.Decompiled;


readonly class p87a59ce6$p6bec872e<T, R> : io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f1271bfcf;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1c0419a7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f48e7e6d4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : R> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f82058014;
    readonly io.reactivex.rxjava3.core.MaybeObserver f92a3e8c6;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.MaybeObserver fbe5461f3;
    readonly io.reactivex.rxjava3.core.MaybeObserver<R> fd22a0a80;

    p87a59ce6$p6bec872e(io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver, io.reactivex.rxjava3.functions.Function<? super T, ? : R> function) {
        this.fd22a0a80 = maybeObserver;
        this.f4b9f83e1 = function;
    }

    public static void BEWJTIQbMMOmCPRH(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void ByoeuTahquUwTwxY(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static java.lang.object EXoUfzYmjINlZsZe(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static bool HHjWPLwDdDNWMGog(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void TVMzbLmrGyRvuVgV(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void BoNPlxMNsjTKxuWF(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void DIgsFZMENAthOIjX(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void DrMSJZjXrzTYAaht(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void TaLuOXzymRvXZRrD(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static bool UZFTKWLeFyIFHnET(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static java.lang.object ZuUIkOciTRnUZJMX(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public override void Dispose() {
        if ((28 + 28) % 28 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = this.fbc3b0556;
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        drMSJZjXrzTYAaht(p7beea252Var);
    }

    public override bool IsDisposed() {
        return uZFTKWLeFyIFHnET(this.fbc3b0556);
    }

    public override void OnComplete() {
        TVMzbLmrGyRvuVgV(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        taLuOXzymRvXZRrD(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (HHjWPLwDdDNWMGog(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            dIgsFZMENAthOIjX(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        try {
            ByoeuTahquUwTwxY(this.fd22a0a80, zuUIkOciTRnUZJMX(EXoUfzYmjINlZsZe(this.f4b9f83e1, t), "The mapper returned a null item"));
        } catch (java.lang.Exception th) {
            boNPlxMNsjTKxuWF(th);
            BEWJTIQbMMOmCPRH(this.fd22a0a80, th);
        }
    }
}

