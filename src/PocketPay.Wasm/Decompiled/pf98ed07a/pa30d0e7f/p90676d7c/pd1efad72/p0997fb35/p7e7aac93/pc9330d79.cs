namespace WillowMaze.Wasm.Decompiled;


public readonly class pc9330d79<T, U> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.MaybeSource f032592d9;
    readonly io.reactivex.rxjava3.core.MaybeSource f19a8e33f;
    readonly io.reactivex.rxjava3.core.MaybeSource<? : T> f4ccb1142;
    readonly io.reactivex.rxjava3.core.MaybeSource f5bdbe5ae;
    readonly io.reactivex.rxjava3.core.MaybeSource<U> f795f3202;
    readonly io.reactivex.rxjava3.core.MaybeSource f83a24f05;
    readonly io.reactivex.rxjava3.core.MaybeSource f90d6de00;
    readonly io.reactivex.rxjava3.core.MaybeSource fa64d3c46;
    readonly io.reactivex.rxjava3.core.MaybeSource fd6480c35;
    readonly io.reactivex.rxjava3.core.MaybeSource fdb83bcdd;

    public pc9330d79(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.core.MaybeSource<U> maybeSource2, io.reactivex.rxjava3.core.MaybeSource<? : T> maybeSource3) {
        super(maybeSource);
        this.f795f3202 = maybeSource2;
        this.f4ccb1142 = maybeSource3;
    }

    public static void KwzEhaRjXiSRQARu(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void LyqLUnbdwePUITvK(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void WzTxiDXmvzzDkqyu(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((23 + 29) % 29 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pc9330d79$p94450938 pc9330d79_p94450938 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pc9330d79$p94450938(maybeObserver, this.f4ccb1142);
        wzTxiDXmvzzDkqyu(maybeObserver, pc9330d79_p94450938);
        KwzEhaRjXiSRQARu(this.f795f3202, pc9330d79_p94450938.f795f3202);
        LyqLUnbdwePUITvK(this.f36cd38f4, pc9330d79_p94450938);
    }
}

