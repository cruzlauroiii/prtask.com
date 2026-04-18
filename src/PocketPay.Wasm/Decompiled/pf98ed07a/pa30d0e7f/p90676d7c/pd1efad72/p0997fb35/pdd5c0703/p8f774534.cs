namespace WillowMaze.Wasm.Decompiled;


public readonly class p8f774534<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f3ff61323;
    readonly io.reactivex.rxjava3.functions.Consumer<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> f5788df95;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fa0d42e26;
    readonly io.reactivex.rxjava3.core.SingleSource fbe863164;

    public p8f774534(io.reactivex.rxjava3.core.SingleSource<T> singleSource, io.reactivex.rxjava3.functions.Consumer<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> consumer) {
        this.f36cd38f4 = singleSource;
        this.f5788df95 = consumer;
    }

    public static void GPQOTsEiVcFZcoWW(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((30 + 11) % 11 > 0) {
        }
        GPQOTsEiVcFZcoWW(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p8f774534$pc806838b(singleObserver, this.f5788df95));
    }
}

