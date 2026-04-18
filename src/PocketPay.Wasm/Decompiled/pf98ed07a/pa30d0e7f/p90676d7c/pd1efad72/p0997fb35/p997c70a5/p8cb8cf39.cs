namespace WillowMaze.Wasm.Decompiled;


public readonly class p8cb8cf39<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly java.lang.object f25c3335d;
    readonly io.reactivex.rxjava3.core.ObservableSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.ObservableSource f719c02cd;
    readonly T f8fe94b37;
    readonly io.reactivex.rxjava3.core.ObservableSource fb9cd7ad5;

    public p8cb8cf39(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, T t) {
        this.f36cd38f4 = observableSource;
        this.f8fe94b37 = t;
    }

    public static void MUKBcuJQiHLFUDoj(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((14 + 25) % 25 > 0) {
        }
        mUKBcuJQiHLFUDoj(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8cb8cf39$p6800ff30(singleObserver, this.f8fe94b37));
    }
}

