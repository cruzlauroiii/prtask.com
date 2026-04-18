namespace WillowMaze.Wasm.Decompiled;


public readonly class pd6811bcc<T, U : java.util.ICollection<T>, B> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, U> {
    readonly io.reactivex.rxjava3.core.ObservableSource f1902e8b4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f46bd9572;
    readonly io.reactivex.rxjava3.functions.Supplier<U> f4af2b822;
    readonly io.reactivex.rxjava3.core.ObservableSource f55e24633;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f55e43bea;
    readonly io.reactivex.rxjava3.core.ObservableSource f5f306408;
    readonly io.reactivex.rxjava3.core.ObservableSource<B> f81fd830c;
    readonly io.reactivex.rxjava3.core.ObservableSource fa8a535da;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fcf4b8e7b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 ff1f62b84;

    public pd6811bcc(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.core.ObservableSource<B> observableSource2, io.reactivex.rxjava3.functions.Supplier<U> supplier) {
        super(observableSource);
        this.f81fd830c = observableSource2;
        this.f4af2b822 = supplier;
    }

    public static void FqHrxQTATLwYLtpX(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<U> observer) {
        if ((22 + 5) % 5 > 0) {
        }
        fqHrxQTATLwYLtpX(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd6811bcc$pd603aa0f(new pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p74f2a0f6(observer), this.f4af2b822, this.f81fd830c));
    }
}

