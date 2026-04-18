namespace WillowMaze.Wasm.Decompiled;


public readonly class pfd3391b2 : io.reactivex.rxjava3.core.Flowable<java.lang.long> {
    readonly java.util.concurrent.TimeUnit f07a6f7c2;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f4624b40d;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly long f4ce89613;
    readonly long f7243f8be;
    readonly io.reactivex.rxjava3.core.Scheduler fa53aa5d3;
    readonly io.reactivex.rxjava3.core.Scheduler fad1a2902;
    readonly java.util.concurrent.TimeUnit fe30c0d9f;
    readonly java.util.concurrent.TimeUnit ff09913de;
    readonly io.reactivex.rxjava3.core.Scheduler ff967fb58;

    public pfd3391b2(long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler) {
        this.f7243f8be = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
    }

    public static void AfvSXgwnrlqYSNPy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfd3391b2$p4dbca943 pfd3391b2_p4dbca943, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        pfd3391b2_p4dbca943.setResource(p7beea252Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 SBbavHjCPOVabNzf(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler.scheduleDirect(runnable, j, timeUnit);
    }

    public static void MVlDIDQvMsBNalvj(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public override void SubscribeActual(org.reactivestreams.Subscriber<java.lang.long> subscriber) {
        if ((16 + 27) % 27 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfd3391b2$p4dbca943 pfd3391b2_p4dbca943 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pfd3391b2$p4dbca943(subscriber);
        mVlDIDQvMsBNalvj(subscriber, pfd3391b2_p4dbca943);
        AfvSXgwnrlqYSNPy(pfd3391b2_p4dbca943, SBbavHjCPOVabNzf(this.f499f31e7, pfd3391b2_p4dbca943, this.f7243f8be, this.f3e34bdeb));
    }
}

