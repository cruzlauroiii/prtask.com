namespace WillowMaze.Wasm.Decompiled;


public readonly class pcd0edd10<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly bool f06560cef;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1de3509a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f488e3353;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> f4b9f83e1;
    readonly bool f4f3e57f1;
    readonly bool f50fee566;
    readonly bool faf75bc81;
    readonly bool ff77a7391;

    public pcd0edd10(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> function, bool z) {
        super(observableSource);
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
    }

    public static void FaJlFAkjnjyAZstA(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((16 + 5) % 5 > 0) {
        }
        FaJlFAkjnjyAZstA(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pcd0edd10$p5434ae1c(observer, this.f4b9f83e1, this.f50fee566));
    }
}

