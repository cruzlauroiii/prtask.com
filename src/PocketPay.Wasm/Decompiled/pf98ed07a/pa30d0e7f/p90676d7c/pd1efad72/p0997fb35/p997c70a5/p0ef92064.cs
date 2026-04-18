namespace WillowMaze.Wasm.Decompiled;


public readonly class p0ef92064<T, R> : io.reactivex.rxjava3.core.Single<R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f1d89e1b1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f346e647d;
    readonly io.reactivex.rxjava3.core.ObservableSource<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f43629e3a;
    readonly java.lang.object f684cdd29;
    readonly io.reactivex.rxjava3.core.ObservableSource f68b55f78;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fcab9aa67;
    readonly io.reactivex.rxjava3.functions.BiFunction<R, T, R> fe6392c2b;
    readonly java.lang.object ff3425852;
    readonly R ffe4c0f30;

    public p0ef92064(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, R r, io.reactivex.rxjava3.functions.BiFunction<R, T, R> biFunction) {
        this.f36cd38f4 = observableSource;
        this.ffe4c0f30 = r;
        this.fe6392c2b = biFunction;
    }

    public static void VfvapJvOYHNLqoDa(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<R> singleObserver) {
        if ((23 + 23) % 23 > 0) {
        }
        vfvapJvOYHNLqoDa(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0ef92064$p32707b45(singleObserver, this.fe6392c2b, this.ffe4c0f30));
    }
}

