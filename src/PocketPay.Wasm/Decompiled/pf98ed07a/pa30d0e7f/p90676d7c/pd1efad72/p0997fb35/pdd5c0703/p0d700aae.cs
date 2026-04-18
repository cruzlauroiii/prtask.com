namespace WillowMaze.Wasm.Decompiled;


public readonly class p0d700aae<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly io.reactivex.rxjava3.core.Scheduler f044acc0b;
    readonly io.reactivex.rxjava3.core.Scheduler f0c1fd440;
    readonly io.reactivex.rxjava3.core.SingleSource f19db1a0c;
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.Scheduler f4b5e2f4f;
    readonly io.reactivex.rxjava3.core.SingleSource f4f87b698;
    readonly long f6cba3b7e;
    readonly long f7473f1b1;
    readonly long f76c6f998;
    readonly io.reactivex.rxjava3.core.SingleSource<? : T> f795f3202;
    readonly long f90272dda;
    readonly io.reactivex.rxjava3.core.SingleSource f98df5a26;
    readonly java.util.concurrent.TimeUnit fb4a42151;
    readonly io.reactivex.rxjava3.core.SingleSource fc0067569;
    readonly io.reactivex.rxjava3.core.Scheduler fc360ce4b;
    readonly io.reactivex.rxjava3.core.SingleSource fc3d17133;
    readonly java.util.concurrent.TimeUnit fe613ad31;

    public p0d700aae(io.reactivex.rxjava3.core.SingleSource<T> singleSource, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, io.reactivex.rxjava3.core.SingleSource<? : T> singleSource2) {
        this.f36cd38f4 = singleSource;
        this.f90272dda = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.f795f3202 = singleSource2;
    }

    public static void EHUyUXsqXGxYgLzC(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 GHVbygxNIRwpoiLh(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler.scheduleDirect(runnable, j, timeUnit);
    }

    public static void NAWWeWxbltxuwNBs(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static bool WLORskKVwSMglnVV(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((26 + 32) % 32 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p0d700aae$p41a8c32e p0d700aae_p41a8c32e = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p0d700aae$p41a8c32e(singleObserver, this.f795f3202, this.f90272dda, this.f3e34bdeb);
        EHUyUXsqXGxYgLzC(singleObserver, p0d700aae_p41a8c32e);
        WLORskKVwSMglnVV(p0d700aae_p41a8c32e.f478f3a4c, GHVbygxNIRwpoiLh(this.f499f31e7, p0d700aae_p41a8c32e, this.f90272dda, this.f3e34bdeb));
        NAWWeWxbltxuwNBs(this.f36cd38f4, p0d700aae_p41a8c32e);
    }
}

