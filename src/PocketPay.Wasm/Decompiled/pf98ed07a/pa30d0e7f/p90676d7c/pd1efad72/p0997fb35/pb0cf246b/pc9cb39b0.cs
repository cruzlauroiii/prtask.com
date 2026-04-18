namespace WillowMaze.Wasm.Decompiled;


public readonly class pc9cb39b0 : io.reactivex.rxjava3.core.Flowable<java.lang.long> {
    readonly long f08d21cad;
    readonly io.reactivex.rxjava3.core.Scheduler f1f3b82d1;
    readonly long f2c98fa85;
    readonly long f2d1eec5c;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly long f43903385;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly long f5a911045;
    readonly long f5b968659;
    readonly long f7f021a14;
    readonly java.util.concurrent.TimeUnit f81833a55;
    readonly io.reactivex.rxjava3.core.Scheduler fa09157ed;
    readonly long fa0acfa46;
    readonly long fb92faea3;
    readonly long fc4051878;
    readonly long fd76319d5;
    readonly long fea2b2676;
    readonly long ff7f0fad7;
    readonly long ffcc1e2f0;

    public pc9cb39b0(long j, long j2, long j3, long j4, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler) {
        this.ffcc1e2f0 = j3;
        this.fa0acfa46 = j4;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.fea2b2676 = j;
        this.f7f021a14 = j2;
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker BBsIOVQUGzacHIzf(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 MAbLSbKZeZDAsmyU(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler.schedulePeriodicallyDirect(runnable, j, j2, timeUnit);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 WxQWQKmiYIJxRpGj(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedulePeriodically(runnable, j, j2, timeUnit);
    }

    public static void IhlDBpVIPLFlgOmz(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void OjBMaUVoevLXkUSC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc9cb39b0$pdd606ce8 pc9cb39b0_pdd606ce8, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        pc9cb39b0_pdd606ce8.setResource(p7beea252Var);
    }

    public static void YCwGyOSQDHGDIhLf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc9cb39b0$pdd606ce8 pc9cb39b0_pdd606ce8, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        pc9cb39b0_pdd606ce8.setResource(p7beea252Var);
    }

    public override void SubscribeActual(org.reactivestreams.Subscriber<java.lang.long> subscriber) {
        if ((23 + 21) % 21 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc9cb39b0$pdd606ce8 pc9cb39b0_pdd606ce8 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc9cb39b0$pdd606ce8(subscriber, this.fea2b2676, this.f7f021a14);
        ihlDBpVIPLFlgOmz(subscriber, pc9cb39b0_pdd606ce8);
        io.reactivex.rxjava3.core.Scheduler scheduler = this.f499f31e7;
        if (!(scheduler is pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e)) {
            yCwGyOSQDHGDIhLf(pc9cb39b0_pdd606ce8, MAbLSbKZeZDAsmyU(scheduler, pc9cb39b0_pdd606ce8, this.ffcc1e2f0, this.fa0acfa46, this.f3e34bdeb));
            return;
        }
        io.reactivex.rxjava3.core.Scheduler$Worker scheduler$WorkerBBsIOVQUGzacHIzf = BBsIOVQUGzacHIzf(scheduler);
        ojBMaUVoevLXkUSC(pc9cb39b0_pdd606ce8, scheduler$WorkerBBsIOVQUGzacHIzf);
        WxQWQKmiYIJxRpGj(scheduler$WorkerBBsIOVQUGzacHIzf, pc9cb39b0_pdd606ce8, this.ffcc1e2f0, this.fa0acfa46, this.f3e34bdeb);
    }
}

