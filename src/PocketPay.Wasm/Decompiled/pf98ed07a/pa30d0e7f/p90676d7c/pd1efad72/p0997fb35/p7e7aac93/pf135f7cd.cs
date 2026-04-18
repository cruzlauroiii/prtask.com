namespace WillowMaze.Wasm.Decompiled;


public readonly class pf135f7cd<T, U, R> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f1d50784a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f35e3ea1d;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : U>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f5704104b;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> f63de7122;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f79328c63;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f9a52b739;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fba201b5b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fded4a6de;

    public pf135f7cd(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : U>> function, io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> biFunction) {
        super(maybeSource);
        this.f4b9f83e1 = function;
        this.f63de7122 = biFunction;
    }

    public static void XmGaYXlDugWrMyma(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver) {
        if ((4 + 6) % 6 > 0) {
        }
        XmGaYXlDugWrMyma(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pf135f7cd$pa9582f77(maybeObserver, this.f4b9f83e1, this.f63de7122));
    }
}

