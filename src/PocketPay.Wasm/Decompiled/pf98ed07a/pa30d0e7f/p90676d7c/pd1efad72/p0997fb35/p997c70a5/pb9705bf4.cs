namespace WillowMaze.Wasm.Decompiled;


public readonly class pb9705bf4<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly T f16830a58;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : T> f36cd38f4;
    readonly java.lang.object f43ef67dc;
    readonly java.lang.object f5d8e67ec;
    readonly java.lang.object f74f883bf;
    readonly java.lang.object f9e7d7c29;
    readonly io.reactivex.rxjava3.core.ObservableSource fc66165af;

    public pb9705bf4(io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource, T t) {
        this.f36cd38f4 = observableSource;
        this.f16830a58 = t;
    }

    public static void HaOVVMnDsRGmoOSY(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((4 + 15) % 15 > 0) {
        }
        HaOVVMnDsRGmoOSY(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb9705bf4$p073c7057(singleObserver, this.f16830a58));
    }
}

