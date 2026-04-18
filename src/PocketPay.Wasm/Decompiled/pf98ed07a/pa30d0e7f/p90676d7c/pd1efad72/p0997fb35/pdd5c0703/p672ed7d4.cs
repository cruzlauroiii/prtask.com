namespace WillowMaze.Wasm.Decompiled;


public readonly class p672ed7d4<T, R> : io.reactivex.rxjava3.core.Single<R> {
    readonly io.reactivex.rxjava3.core.SingleSource<? : T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4f17fd9a;
    readonly io.reactivex.rxjava3.core.SingleSource fae497742;
    readonly io.reactivex.rxjava3.core.SingleSource fc4c416b3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fcd1592e7;

    public p672ed7d4(io.reactivex.rxjava3.core.SingleSource<? : T> singleSource, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> function) {
        this.f4b9f83e1 = function;
        this.f36cd38f4 = singleSource;
    }

    public static void EMpYrRQOiGgmcCPe(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<R> singleObserver) {
        if ((32 + 24) % 24 > 0) {
        }
        eMpYrRQOiGgmcCPe(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p672ed7d4$p87711177(singleObserver, this.f4b9f83e1));
    }
}

