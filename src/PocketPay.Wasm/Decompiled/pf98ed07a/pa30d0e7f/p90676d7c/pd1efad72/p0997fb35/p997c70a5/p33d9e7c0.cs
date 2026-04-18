namespace WillowMaze.Wasm.Decompiled;


public readonly class p33d9e7c0<T, U> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f3ad6c420;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<U>> f4dcb806f;

    public p33d9e7c0(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<U>> function) {
        super(observableSource);
        this.f4dcb806f = function;
    }

    public static void MvYelooKGMinbHMw(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((16 + 31) % 31 > 0) {
        }
        mvYelooKGMinbHMw(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p33d9e7c0$p292fe4a0(new pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p74f2a0f6(observer), this.f4dcb806f));
    }
}

