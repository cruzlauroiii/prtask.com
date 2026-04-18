namespace WillowMaze.Wasm.Decompiled;


public readonly class p87a59ce6<T, R> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, R> {
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : R> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f67cb8523;

    public p87a59ce6(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.functions.Function<? super T, ? : R> function) {
        super(maybeSource);
        this.f4b9f83e1 = function;
    }

    public static void PsOrhrVuzWQiYrpW(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver) {
        if ((23 + 7) % 7 > 0) {
        }
        psOrhrVuzWQiYrpW(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p87a59ce6$p6bec872e(maybeObserver, this.f4b9f83e1));
    }
}

