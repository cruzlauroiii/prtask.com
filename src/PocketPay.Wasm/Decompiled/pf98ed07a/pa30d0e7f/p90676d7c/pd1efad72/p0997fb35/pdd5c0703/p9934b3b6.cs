namespace WillowMaze.Wasm.Decompiled;


public readonly class p9934b3b6<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly io.reactivex.rxjava3.core.SingleSource f10a608a4;
    readonly io.reactivex.rxjava3.functions.Consumer<T> f22a1f716;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f3d7d691b;
    readonly io.reactivex.rxjava3.core.SingleSource f45dca7b2;
    readonly io.reactivex.rxjava3.core.SingleSource f584f08b2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f935904ec;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fcd69bf96;
    readonly io.reactivex.rxjava3.core.SingleSource fe972fe40;

    public p9934b3b6(io.reactivex.rxjava3.core.SingleSource<T> singleSource, io.reactivex.rxjava3.functions.Consumer<T> consumer) {
        this.f36cd38f4 = singleSource;
        this.f22a1f716 = consumer;
    }

    public static void ACtuKyNJLawsqRLs(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((22 + 9) % 9 > 0) {
        }
        aCtuKyNJLawsqRLs(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p9934b3b6$p1fc0aadb(singleObserver, this.f22a1f716));
    }
}

