namespace WillowMaze.Wasm.Decompiled;


public readonly class pfb40c779<T, U : java.util.ICollection<T>, Open, Close> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, U> {
    readonly io.reactivex.rxjava3.core.ObservableSource f0a2b9b87;
    readonly io.reactivex.rxjava3.core.ObservableSource f12efa69a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f271354ce;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f27194176;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f2d74913e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f33540140;
    readonly io.reactivex.rxjava3.functions.Supplier<U> f4af2b822;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f6ece9efa;
    readonly io.reactivex.rxjava3.core.ObservableSource f7b179e46;
    readonly io.reactivex.rxjava3.functions.Function<? super Open, ? : io.reactivex.rxjava3.core.ObservableSource<? : Close>> fa4291b1f;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : Open> fb823a5eb;
    readonly io.reactivex.rxjava3.core.ObservableSource fc2defb4b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd8002f14;

    public pfb40c779(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.core.ObservableSource<? : Open> observableSource2, io.reactivex.rxjava3.functions.Function<? super Open, ? : io.reactivex.rxjava3.core.ObservableSource<? : Close>> function, io.reactivex.rxjava3.functions.Supplier<U> supplier) {
        super(observableSource);
        this.fb823a5eb = observableSource2;
        this.fa4291b1f = function;
        this.f4af2b822 = supplier;
    }

    public static void AqIlYXUuoLRjTViI(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void SudNUQJqNXQxtOvE(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<U> observer) {
        if ((20 + 26) % 26 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d pfb40c779_pfb7b3a3d = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d(observer, this.fb823a5eb, this.fa4291b1f, this.f4af2b822);
        sudNUQJqNXQxtOvE(observer, pfb40c779_pfb7b3a3d);
        AqIlYXUuoLRjTViI(this.f36cd38f4, pfb40c779_pfb7b3a3d);
    }
}

