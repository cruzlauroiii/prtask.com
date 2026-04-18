namespace WillowMaze.Wasm.Decompiled;


public readonly class p29550156<T, R> : io.reactivex.rxjava3.core.Single<R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f04d8368c;
    readonly io.reactivex.rxjava3.core.SingleSource<? : T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : R> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fae973852;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ffcc31df4;
    readonly io.reactivex.rxjava3.core.SingleSource ffd157195;

    public p29550156(io.reactivex.rxjava3.core.SingleSource<? : T> singleSource, io.reactivex.rxjava3.functions.Function<? super T, ? : R> function) {
        this.f36cd38f4 = singleSource;
        this.f4b9f83e1 = function;
    }

    public static void RVxEcYCBpVCjOqwj(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<R> singleObserver) {
        if ((29 + 24) % 24 > 0) {
        }
        rVxEcYCBpVCjOqwj(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p29550156$p52cf00b3(singleObserver, this.f4b9f83e1));
    }
}

