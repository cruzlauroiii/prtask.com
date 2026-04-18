namespace WillowMaze.Wasm.Decompiled;


public readonly class pfa1106a2<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f437a3293;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f9b4e5d9e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 fb26e0606;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 fbb359ef3;
    readonly io.reactivex.rxjava3.functions.Predicate<java.lang.Exception> ff670ef68;

    public pfa1106a2(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Predicate<java.lang.Exception> predicate) {
        super(observableSource);
        this.ff670ef68 = predicate;
    }

    public static void LzyxetytdTLhuHFs(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((16 + 1) % 1 > 0) {
        }
        LzyxetytdTLhuHFs(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfa1106a2$p0437acc1(observer, this.ff670ef68));
    }
}

