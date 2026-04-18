namespace WillowMaze.Wasm.Decompiled;


public readonly class pa4690a5a<T, U> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.MaybeSource f3dd1afa9;
    readonly io.reactivex.rxjava3.core.MaybeSource f47cafa2e;
    readonly io.reactivex.rxjava3.core.MaybeSource<U> f795f3202;
    readonly io.reactivex.rxjava3.core.MaybeSource fde2341d9;
    readonly io.reactivex.rxjava3.core.MaybeSource fea847b5b;

    public pa4690a5a(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.core.MaybeSource<U> maybeSource2) {
        super(maybeSource);
        this.f795f3202 = maybeSource2;
    }

    public static void PPnLUzQECVaTjtTW(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void VKRemDnXkCVQvhri(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void FETZqIwaqeVHZDvz(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((12 + 7) % 7 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa4690a5a$p03fceb00 pa4690a5a_p03fceb00 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pa4690a5a$p03fceb00(maybeObserver);
        fETZqIwaqeVHZDvz(maybeObserver, pa4690a5a_p03fceb00);
        VKRemDnXkCVQvhri(this.f795f3202, pa4690a5a_p03fceb00.f795f3202);
        PPnLUzQECVaTjtTW(this.f36cd38f4, pa4690a5a_p03fceb00);
    }
}

