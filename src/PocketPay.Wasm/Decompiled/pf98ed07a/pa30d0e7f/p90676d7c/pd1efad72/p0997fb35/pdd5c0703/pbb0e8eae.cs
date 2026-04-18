namespace WillowMaze.Wasm.Decompiled;


public readonly class pbb0e8eae<T, U> : io.reactivex.rxjava3.core.Single<T> {
    readonly io.reactivex.rxjava3.core.SingleSource f31f4fe42;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.ObservableSource<U> f795f3202;
    readonly io.reactivex.rxjava3.core.ObservableSource f8b25bc52;
    readonly io.reactivex.rxjava3.core.SingleSource fd7d9aaa4;

    public pbb0e8eae(io.reactivex.rxjava3.core.SingleSource<T> singleSource, io.reactivex.rxjava3.core.ObservableSource<U> observableSource) {
        this.f36cd38f4 = singleSource;
        this.f795f3202 = observableSource;
    }

    public static void ZkvRgwYnsyKornKA(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((12 + 10) % 10 > 0) {
        }
        zkvRgwYnsyKornKA(this.f795f3202, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pbb0e8eae$p4c783800(singleObserver, this.f36cd38f4));
    }
}

