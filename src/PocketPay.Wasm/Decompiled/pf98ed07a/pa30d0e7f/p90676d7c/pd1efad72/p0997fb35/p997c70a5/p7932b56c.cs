namespace WillowMaze.Wasm.Decompiled;


public readonly class p7932b56c<T, R> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, io.reactivex.rxjava3.core.ObservableSource<? : R>> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f29a252e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4e6d2bb7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f583c8eba;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f6a4b1bbd;
    readonly io.reactivex.rxjava3.functions.Supplier<? : io.reactivex.rxjava3.core.ObservableSource<? : R>> f6c1d5d4f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f72a3ca13;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> f81778e72;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> fa1b38de8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc5d818bd;

    public p7932b56c(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> function, io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> function2, io.reactivex.rxjava3.functions.Supplier<? : io.reactivex.rxjava3.core.ObservableSource<? : R>> supplier) {
        super(observableSource);
        this.f81778e72 = function;
        this.fa1b38de8 = function2;
        this.f6c1d5d4f = supplier;
    }

    public static void MPtOfNTsArjknXRB(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<? super io.reactivex.rxjava3.core.ObservableSource<? : R>> observer) {
        if ((6 + 17) % 17 > 0) {
        }
        mPtOfNTsArjknXRB(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p7932b56c$p0ddf130d(observer, this.f81778e72, this.fa1b38de8, this.f6c1d5d4f));
    }
}

