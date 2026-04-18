namespace WillowMaze.Wasm.Decompiled;


public readonly class p243b0bc5<T, R> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, R> {
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f6264cdb9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f6280493d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f71d2a8bd;

    public p243b0bc5(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> function) {
        super(observableSource);
        this.f4b9f83e1 = function;
    }

    public static void WbBqCKXmUdNLLySO(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((21 + 22) % 22 > 0) {
        }
        WbBqCKXmUdNLLySO(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p243b0bc5$paceaa260(observer, this.f4b9f83e1));
    }
}

