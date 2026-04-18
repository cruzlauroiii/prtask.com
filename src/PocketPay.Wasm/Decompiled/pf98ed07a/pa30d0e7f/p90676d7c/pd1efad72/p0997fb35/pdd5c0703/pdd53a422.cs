namespace WillowMaze.Wasm.Decompiled;


public readonly class pdd53a422<T> : io.reactivex.rxjava3.core.Single<java.lang.bool> {
    readonly java.lang.object f2063c160;
    readonly io.reactivex.rxjava3.core.SingleSource f2b0fbaae;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.SingleSource f4dc565c8;
    readonly io.reactivex.rxjava3.core.SingleSource f7af27f1f;
    readonly io.reactivex.rxjava3.functions.BiPredicate<java.lang.object, java.lang.object> f9f89a861;
    readonly io.reactivex.rxjava3.core.SingleSource fc09019f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 fcb41fa1e;
    readonly java.lang.object fff09cd21;

    public pdd53a422(io.reactivex.rxjava3.core.SingleSource<T> singleSource, java.lang.object obj, io.reactivex.rxjava3.functions.BiPredicate<java.lang.object, java.lang.object> biPredicate) {
        this.f36cd38f4 = singleSource;
        this.f2063c160 = obj;
        this.f9f89a861 = biPredicate;
    }

    public static void TaTVMnrYuBzRwjWQ(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> singleObserver) {
        if ((25 + 6) % 6 > 0) {
        }
        TaTVMnrYuBzRwjWQ(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pdd53a422$p0fec7980(this, singleObserver));
    }
}

