namespace WillowMaze.Wasm.Decompiled;


public readonly class pd8768b96<T, R> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, R> {
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f7244c8fe;

    public pd8768b96(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> function) {
        super(maybeSource);
        this.f4b9f83e1 = function;
    }

    public static void CAKRlztMYKALxeYr(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver) {
        if ((1 + 8) % 8 > 0) {
        }
        CAKRlztMYKALxeYr(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd8768b96$p7c9324ab(maybeObserver, this.f4b9f83e1));
    }
}

