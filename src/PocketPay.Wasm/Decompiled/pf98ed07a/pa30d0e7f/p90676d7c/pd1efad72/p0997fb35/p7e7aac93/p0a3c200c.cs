namespace WillowMaze.Wasm.Decompiled;


public readonly class p0a3c200c<T, R> : io.reactivex.rxjava3.core.Observable<R> {
    readonly io.reactivex.rxjava3.core.MaybeSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f7049ea42;
    readonly io.reactivex.rxjava3.core.MaybeSource fb39b1200;
    readonly io.reactivex.rxjava3.core.MaybeSource fb3b0eafe;
    readonly io.reactivex.rxjava3.core.MaybeSource fb89bd5fe;

    public p0a3c200c(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> function) {
        this.f36cd38f4 = maybeSource;
        this.f4b9f83e1 = function;
    }

    public static void PcTXqxFLsvQPcZlf(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((20 + 7) % 7 > 0) {
        }
        pcTXqxFLsvQPcZlf(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p0a3c200c$p2e293412(observer, this.f4b9f83e1));
    }
}

