namespace WillowMaze.Wasm.Decompiled;


public readonly class p55037f0e<T, R> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f12981fbb;
    readonly bool f23beb3f7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f36b734fb;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> f4b9f83e1;
    readonly bool f50fee566;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f6c83586f;
    readonly bool f8e222685;
    readonly bool fd2f3ddd5;

    public p55037f0e(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> function, bool z) {
        super(observableSource);
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
    }

    public static void AgiAbrnWeNrbvyst(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((18 + 8) % 8 > 0) {
        }
        agiAbrnWeNrbvyst(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e(observer, this.f4b9f83e1, this.f50fee566));
    }
}

