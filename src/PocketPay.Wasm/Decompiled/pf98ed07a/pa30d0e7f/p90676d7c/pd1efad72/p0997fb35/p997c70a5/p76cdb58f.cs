namespace WillowMaze.Wasm.Decompiled;


public readonly class p76cdb58f<T, R> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, R> {
    readonly bool f0aa92823;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> f4b9f83e1;
    readonly bool f50fee566;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 faa56ffdb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fbb9ce426;

    public p76cdb58f(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> function, bool z) {
        super(observableSource);
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
    }

    public static void VleJuRZUPlLmIYcs(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((17 + 13) % 13 > 0) {
        }
        VleJuRZUPlLmIYcs(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab(observer, this.f4b9f83e1, this.f50fee566));
    }
}

