namespace WillowMaze.Wasm.Decompiled;


public readonly class p8c5cc2a0<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly io.reactivex.rxjava3.core.SingleSource f3559667f;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.SingleSource fdab37cb8;
    readonly io.reactivex.rxjava3.core.SingleSource fdbea95cf;
    readonly io.reactivex.rxjava3.core.SingleSource fe65d31db;

    public p8c5cc2a0(io.reactivex.rxjava3.core.SingleSource<T> singleSource) {
        this.f36cd38f4 = singleSource;
    }

    public static void PhJSlfUfcoqVwiDI(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        phJSlfUfcoqVwiDI(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p8c5cc2a0$pc8c79e0e(singleObserver));
    }
}

