namespace WillowMaze.Wasm.Decompiled;


public readonly class p9c96130d<T, U> : io.reactivex.rxjava3.core.Single<T> {
    readonly io.reactivex.rxjava3.core.SingleSource f2b2b8a40;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.SingleSource f382808b7;
    readonly io.reactivex.rxjava3.core.SingleSource f3919d2a2;
    readonly io.reactivex.rxjava3.core.SingleSource f407ff45d;
    readonly io.reactivex.rxjava3.core.SingleSource f4b578d40;
    readonly io.reactivex.rxjava3.core.SingleSource<U> f795f3202;
    readonly io.reactivex.rxjava3.core.SingleSource fb310219d;
    readonly io.reactivex.rxjava3.core.SingleSource fbd772bdb;

    public p9c96130d(io.reactivex.rxjava3.core.SingleSource<T> singleSource, io.reactivex.rxjava3.core.SingleSource<U> singleSource2) {
        this.f36cd38f4 = singleSource;
        this.f795f3202 = singleSource2;
    }

    public static void ZHIQTFYmquwYeqIF(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((15 + 9) % 9 > 0) {
        }
        zHIQTFYmquwYeqIF(this.f795f3202, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p9c96130d$pe0acc004(singleObserver, this.f36cd38f4));
    }
}

