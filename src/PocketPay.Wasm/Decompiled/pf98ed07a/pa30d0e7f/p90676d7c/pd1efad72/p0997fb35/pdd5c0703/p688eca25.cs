namespace WillowMaze.Wasm.Decompiled;


public readonly class p688eca25<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly io.reactivex.rxjava3.core.Scheduler f1a58a336;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.SingleSource f3dfb32ba;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.SingleSource f93df9c40;
    readonly io.reactivex.rxjava3.core.SingleSource fb5e14174;

    public p688eca25(io.reactivex.rxjava3.core.SingleSource<T> singleSource, io.reactivex.rxjava3.core.Scheduler scheduler) {
        this.f36cd38f4 = singleSource;
        this.f499f31e7 = scheduler;
    }

    public static void LjfJbyapUoWPGFSY(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((9 + 25) % 25 > 0) {
        }
        LjfJbyapUoWPGFSY(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p688eca25$pfbe13cef(singleObserver, this.f499f31e7));
    }
}

