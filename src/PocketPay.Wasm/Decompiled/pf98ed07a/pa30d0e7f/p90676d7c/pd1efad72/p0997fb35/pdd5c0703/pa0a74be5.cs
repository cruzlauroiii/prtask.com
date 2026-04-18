namespace WillowMaze.Wasm.Decompiled;


public readonly class pa0a74be5<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 f00f6c0a1;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 f7562914b;
    readonly io.reactivex.rxjava3.core.SingleSource f9561fd6f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 fa0ab81bb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 fa7cfede6;
    readonly io.reactivex.rxjava3.functions.BiConsumer<T, java.lang.Exception> fab428135;

    public pa0a74be5(io.reactivex.rxjava3.core.SingleSource<T> singleSource, io.reactivex.rxjava3.functions.BiConsumer<T, java.lang.Exception> biConsumer) {
        this.f36cd38f4 = singleSource;
        this.fab428135 = biConsumer;
    }

    public static void STgCajfobevQNoKV(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((22 + 32) % 32 > 0) {
        }
        sTgCajfobevQNoKV(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pa0a74be5$p1e048b84(this, singleObserver));
    }
}

