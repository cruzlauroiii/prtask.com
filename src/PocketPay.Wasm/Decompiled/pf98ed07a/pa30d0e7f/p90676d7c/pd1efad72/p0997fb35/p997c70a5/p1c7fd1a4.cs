namespace WillowMaze.Wasm.Decompiled;


public readonly class p1c7fd1a4<T> : io.reactivex.rxjava3.core.Maybe<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f1b8b31f6;
    readonly io.reactivex.rxjava3.core.ObservableSource<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f4890321e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f5518832d;
    readonly io.reactivex.rxjava3.core.ObservableSource f7396c64f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f79218a35;
    readonly io.reactivex.rxjava3.functions.BiFunction<T, T, T> fe6392c2b;

    public p1c7fd1a4(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.BiFunction<T, T, T> biFunction) {
        this.f36cd38f4 = observableSource;
        this.fe6392c2b = biFunction;
    }

    public static void YchKNduYImQRtgjB(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((14 + 2) % 2 > 0) {
        }
        YchKNduYImQRtgjB(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1c7fd1a4$p248e673c(maybeObserver, this.fe6392c2b));
    }
}

