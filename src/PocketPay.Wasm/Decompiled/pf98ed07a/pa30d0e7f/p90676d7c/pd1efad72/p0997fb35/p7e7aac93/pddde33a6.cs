namespace WillowMaze.Wasm.Decompiled;


public readonly class pddde33a6<T> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.MaybeSource f2fa31121;
    readonly io.reactivex.rxjava3.core.MaybeSource<? : T> f795f3202;

    public pddde33a6(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.core.MaybeSource<? : T> maybeSource2) {
        super(maybeSource);
        this.f795f3202 = maybeSource2;
    }

    public static void CTUCoNNJqXWzzLUb(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((28 + 27) % 27 > 0) {
        }
        cTUCoNNJqXWzzLUb(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pddde33a6$p14a4df76(maybeObserver, this.f795f3202));
    }
}

