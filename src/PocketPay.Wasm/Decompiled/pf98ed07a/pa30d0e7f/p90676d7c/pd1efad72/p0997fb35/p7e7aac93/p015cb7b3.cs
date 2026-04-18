namespace WillowMaze.Wasm.Decompiled;


public readonly class p015cb7b3<T, R> : io.reactivex.rxjava3.core.Flowable<R> {
    readonly io.reactivex.rxjava3.core.MaybeSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.MaybeSource f38761663;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> f4b9f83e1;
    readonly io.reactivex.rxjava3.core.MaybeSource f69887498;
    readonly io.reactivex.rxjava3.core.MaybeSource fe2d71fc3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fff87d5ef;

    public p015cb7b3(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> function) {
        this.f36cd38f4 = maybeSource;
        this.f4b9f83e1 = function;
    }

    public static void KPzkwtCegIbBWGnV(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((30 + 3) % 3 > 0) {
        }
        KPzkwtCegIbBWGnV(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p015cb7b3$p2e293412(subscriber, this.f4b9f83e1));
    }
}

