namespace WillowMaze.Wasm.Decompiled;


public readonly class p664d26dd<T> : io.reactivex.rxjava3.core.Single<io.reactivex.rxjava3.schedulers.Timed<T>> {
    readonly java.util.concurrent.TimeUnit f054fa5ff;
    readonly java.util.concurrent.TimeUnit f291214de;
    readonly io.reactivex.rxjava3.core.Scheduler f2c6f046f;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly bool f3cb4210f;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly java.util.concurrent.TimeUnit f549dc662;
    readonly bool fa8e53d16;
    readonly java.util.concurrent.TimeUnit faa639a73;
    readonly bool fac330028;
    readonly io.reactivex.rxjava3.core.SingleSource fbcb31b3f;
    readonly io.reactivex.rxjava3.core.SingleSource fc04f2b80;
    readonly bool fc270992e;
    readonly io.reactivex.rxjava3.core.Scheduler fc9eb6a3f;
    readonly io.reactivex.rxjava3.core.Scheduler fd4458a8f;
    readonly io.reactivex.rxjava3.core.SingleSource fe7e6d689;
    readonly bool fea2b2676;
    readonly io.reactivex.rxjava3.core.SingleSource fee670ea4;

    public p664d26dd(io.reactivex.rxjava3.core.SingleSource<T> singleSource, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        this.f36cd38f4 = singleSource;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.fea2b2676 = z;
    }

    public static void GQpWxPsmnpawiKXi(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<? super io.reactivex.rxjava3.schedulers.Timed<T>> singleObserver) {
        if ((31 + 25) % 25 > 0) {
        }
        gQpWxPsmnpawiKXi(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p664d26dd$p4f3ad997(singleObserver, this.f3e34bdeb, this.f499f31e7, this.fea2b2676));
    }
}

