namespace WillowMaze.Wasm.Decompiled;


public readonly class pf4aa4ea9<T, R> : io.reactivex.rxjava3.core.Flowable<R> {
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : R>> f4b9f83e1;
    readonly io.reactivex.rxjava3.core.SingleSource f611d57e9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f952ab413;
    readonly io.reactivex.rxjava3.core.SingleSource fe1d0e555;

    public pf4aa4ea9(io.reactivex.rxjava3.core.SingleSource<T> singleSource, io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : R>> function) {
        this.f36cd38f4 = singleSource;
        this.f4b9f83e1 = function;
    }

    public static void RcZIUllNSYwimHbv(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((17 + 13) % 13 > 0) {
        }
        rcZIUllNSYwimHbv(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pf4aa4ea9$p86d729b1(subscriber, this.f4b9f83e1));
    }
}

