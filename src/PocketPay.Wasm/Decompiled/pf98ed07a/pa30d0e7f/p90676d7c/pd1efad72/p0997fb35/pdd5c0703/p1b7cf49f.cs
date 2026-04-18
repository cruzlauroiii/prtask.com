namespace WillowMaze.Wasm.Decompiled;


public readonly class p1b7cf49f<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly io.reactivex.rxjava3.core.SingleSource<? : T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f39074f15;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f98b7d528;
    readonly io.reactivex.rxjava3.core.SingleSource fbbd271ed;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fcac92083;
    readonly io.reactivex.rxjava3.core.SingleSource fcf4e47e3;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : io.reactivex.rxjava3.core.SingleSource<? : T>> fd6a2995c;

    public p1b7cf49f(io.reactivex.rxjava3.core.SingleSource<? : T> singleSource, io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : io.reactivex.rxjava3.core.SingleSource<? : T>> function) {
        this.f36cd38f4 = singleSource;
        this.fd6a2995c = function;
    }

    public static void MZErIbNxLwyIuptS(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((2 + 23) % 23 > 0) {
        }
        MZErIbNxLwyIuptS(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p1b7cf49f$p7b712958(singleObserver, this.fd6a2995c));
    }
}

