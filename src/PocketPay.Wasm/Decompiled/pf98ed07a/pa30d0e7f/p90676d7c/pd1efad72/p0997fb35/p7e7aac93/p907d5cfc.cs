namespace WillowMaze.Wasm.Decompiled;


public readonly class p907d5cfc<T, R> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, R> {
    readonly io.reactivex.rxjava3.core.MaybeOperator f10d08e3c;
    readonly io.reactivex.rxjava3.core.MaybeOperator f427e0c8f;
    readonly io.reactivex.rxjava3.core.MaybeOperator<? : R, ? super T> f4b583376;
    readonly io.reactivex.rxjava3.core.MaybeOperator f9d39d6ae;
    readonly io.reactivex.rxjava3.core.MaybeOperator fba9031c8;

    public p907d5cfc(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.core.MaybeOperator<? : R, ? super T> maybeOperator) {
        super(maybeSource);
        this.f4b583376 = maybeOperator;
    }

    public static void DEdQvOWPhaOyuocN(java.lang.Exception th, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.MaybeObserver<object>) maybeObserver);
    }

    public static io.reactivex.rxjava3.core.MaybeObserver JUXvbQCJGrGZaQLH(io.reactivex.rxjava3.core.MaybeOperator maybeOperator, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        return maybeOperator.apply(maybeObserver);
    }

    public static void XpXJdSvfDnarmIvT(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void KNDYAgsMQhPBlmtd(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object QJYwBUmGvzVznkYV(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver) {
        if ((2 + 20) % 20 > 0) {
        }
        try {
            XpXJdSvfDnarmIvT(this.f36cd38f4, (io.reactivex.rxjava3.core.MaybeObserver) qJYwBUmGvzVznkYV(JUXvbQCJGrGZaQLH(this.f4b583376, maybeObserver), "The operator returned a null MaybeObserver"));
        } catch (java.lang.Exception th) {
            kNDYAgsMQhPBlmtd(th);
            DEdQvOWPhaOyuocN(th, maybeObserver);
        }
    }
}

