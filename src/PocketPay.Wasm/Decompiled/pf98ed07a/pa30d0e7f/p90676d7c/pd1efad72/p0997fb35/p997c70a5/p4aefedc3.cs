namespace WillowMaze.Wasm.Decompiled;


public readonly class p4aefedc3<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f16ae60b0;
    readonly io.reactivex.rxjava3.functions.Consumer<T> f3964f381;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fd9bab5bf;

    public p4aefedc3(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Consumer<T> consumer) {
        super(observableSource);
        this.f3964f381 = consumer;
    }

    public static void EGKTERRRaVZhFsdJ(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((29 + 4) % 4 > 0) {
        }
        eGKTERRRaVZhFsdJ(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p4aefedc3$p1fc0aadb(observer, this.f3964f381));
    }
}

