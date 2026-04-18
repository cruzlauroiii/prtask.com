namespace WillowMaze.Wasm.Decompiled;


public readonly class p15e7cb94<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.functions.BiFunction<T, T, T> fbdc1d413;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fd9873bd1;

    public p15e7cb94(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.BiFunction<T, T, T> biFunction) {
        super(observableSource);
        this.fbdc1d413 = biFunction;
    }

    public static void CjzNlAxXwKsKZyUu(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((12 + 24) % 24 > 0) {
        }
        CjzNlAxXwKsKZyUu(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p15e7cb94$pc160cad9(observer, this.fbdc1d413));
    }
}

