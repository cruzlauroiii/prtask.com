namespace WillowMaze.Wasm.Decompiled;


public readonly class p0de4c479<T> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.functions.Consumer<T> f22a1f716;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fb7dfcff6;

    public p0de4c479(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.functions.Consumer<T> consumer) {
        super(maybeSource);
        this.f22a1f716 = consumer;
    }

    public static void RanKHYgfWcSMHsPk(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((22 + 14) % 14 > 0) {
        }
        RanKHYgfWcSMHsPk(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p0de4c479$p1fc0aadb(maybeObserver, this.f22a1f716));
    }
}

