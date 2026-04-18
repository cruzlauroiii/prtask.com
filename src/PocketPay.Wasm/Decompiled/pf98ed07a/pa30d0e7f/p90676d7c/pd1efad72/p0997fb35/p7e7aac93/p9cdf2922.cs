namespace WillowMaze.Wasm.Decompiled;


public readonly class p9cdf2922<T> : io.reactivex.rxjava3.core.Maybe<T> {
    readonly io.reactivex.rxjava3.core.MaybeSource f16924673;
    readonly io.reactivex.rxjava3.core.MaybeSource f214e9156;
    readonly io.reactivex.rxjava3.core.MaybeSource<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f3c3c9527;
    readonly io.reactivex.rxjava3.core.MaybeSource f3d6471c6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f7d966d6d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f8259e143;

    public p9cdf2922(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) {
        this.f36cd38f4 = maybeSource;
        this.f3c3c9527 = p004bf6c9Var;
    }

    public static void AtvJOStaBWXGpNoE(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((24 + 10) % 10 > 0) {
        }
        atvJOStaBWXGpNoE(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p9cdf2922$p41dbb004(this, maybeObserver));
    }
}

