namespace WillowMaze.Wasm.Decompiled;


public readonly class p99fd4336<T, U, R> : io.reactivex.rxjava3.core.Single<R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f28301531;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f3e4ab603;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : U>> f4b9f83e1;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> f63de7122;
    readonly io.reactivex.rxjava3.core.SingleSource f67c83fa5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f6e2a6a4a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f732c7080;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fabfb8915;
    readonly io.reactivex.rxjava3.core.SingleSource fe9cf009a;

    public p99fd4336(io.reactivex.rxjava3.core.SingleSource<T> singleSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : U>> function, io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : R> biFunction) {
        this.f36cd38f4 = singleSource;
        this.f4b9f83e1 = function;
        this.f63de7122 = biFunction;
    }

    public static void QZHvjAPLJEjyiMYW(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<R> singleObserver) {
        if ((4 + 28) % 28 > 0) {
        }
        QZHvjAPLJEjyiMYW(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p99fd4336$pa9582f77(singleObserver, this.f4b9f83e1, this.f63de7122));
    }
}

