namespace WillowMaze.Wasm.Decompiled;


public readonly class pd8863bd2<T> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f0a0866f7;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;

    public pd8863bd2(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        super(maybeSource);
        this.ff670ef68 = predicate;
    }

    public static void ZSIcVhMlaCkTnKaf(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((12 + 32) % 32 > 0) {
        }
        zSIcVhMlaCkTnKaf(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd8863bd2$pd32950e0(maybeObserver, this.ff670ef68));
    }
}

