namespace WillowMaze.Wasm.Decompiled;


public readonly class p8b8ee0e0<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.CompletableSource f1d57eca1;
    readonly io.reactivex.rxjava3.core.CompletableSource f200e165b;
    readonly io.reactivex.rxjava3.core.CompletableSource f6df865e3;
    readonly io.reactivex.rxjava3.core.CompletableSource f70fae512;
    readonly io.reactivex.rxjava3.core.CompletableSource f795f3202;

    public p8b8ee0e0(io.reactivex.rxjava3.core.Observable<T> observable, io.reactivex.rxjava3.core.CompletableSource completableSource) {
        super(observable);
        this.f795f3202 = completableSource;
    }

    public static void SQWyMFaWYozxWzTy(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((22 + 7) % 7 > 0) {
        }
        sQWyMFaWYozxWzTy(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8b8ee0e0$pcb07d71d(observer, this.f795f3202));
    }
}

