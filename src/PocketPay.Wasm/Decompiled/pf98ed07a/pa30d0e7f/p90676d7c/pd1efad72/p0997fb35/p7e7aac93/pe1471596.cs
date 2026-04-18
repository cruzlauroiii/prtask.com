namespace WillowMaze.Wasm.Decompiled;


public readonly class pe1471596<T, R> : io.reactivex.rxjava3.core.Maybe<R> {
    readonly io.reactivex.rxjava3.core.MaybeSource f3674e903;
    readonly io.reactivex.rxjava3.core.MaybeSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f7c0a9489;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f9af48b76;
    readonly io.reactivex.rxjava3.core.MaybeSource ff1ed8405;

    public pe1471596(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> function) {
        this.f36cd38f4 = maybeSource;
        this.f4b9f83e1 = function;
    }

    public static void SOLRdPHEdgRLBZus(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver) {
        if ((10 + 17) % 17 > 0) {
        }
        SOLRdPHEdgRLBZus(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pe1471596$p7c9324ab(maybeObserver, this.f4b9f83e1));
    }
}

