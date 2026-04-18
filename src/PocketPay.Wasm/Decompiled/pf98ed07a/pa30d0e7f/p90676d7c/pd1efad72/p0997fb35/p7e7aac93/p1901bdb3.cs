namespace WillowMaze.Wasm.Decompiled;


public readonly class p1901bdb3<T> : io.reactivex.rxjava3.core.Maybe<T> {
    readonly io.reactivex.rxjava3.core.MaybeSource f21c68103;
    readonly io.reactivex.rxjava3.core.MaybeSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.CompletableSource f472f2125;
    readonly io.reactivex.rxjava3.core.CompletableSource f795f3202;
    readonly io.reactivex.rxjava3.core.CompletableSource f8a1663c1;

    public p1901bdb3(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.core.CompletableSource completableSource) {
        this.f36cd38f4 = maybeSource;
        this.f795f3202 = completableSource;
    }

    public static void FDzPLEFmBfhUHCnC(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((4 + 19) % 19 > 0) {
        }
        FDzPLEFmBfhUHCnC(this.f795f3202, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p1901bdb3$pe0acc004(maybeObserver, this.f36cd38f4));
    }
}

