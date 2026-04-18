namespace WillowMaze.Wasm.Decompiled;


public readonly class pd348981e : io.reactivex.rxjava3.core.Observable<java.lang.long> {
    readonly long f050dd9ce;
    readonly java.util.concurrent.TimeUnit f189d360e;
    readonly long f1ed9e817;
    readonly long f27321768;
    readonly long f2dfe783e;
    readonly long f3b5c3d88;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.Scheduler f54280e7f;
    readonly java.util.concurrent.TimeUnit f6c553c27;
    readonly long fa0acfa46;
    readonly long fab868313;
    readonly long fad76a1c3;
    readonly io.reactivex.rxjava3.core.Scheduler fbf511a45;
    readonly long ffcc1e2f0;

    public pd348981e(long j, long j2, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler) {
        this.ffcc1e2f0 = j;
        this.fa0acfa46 = j2;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
    }

    public static void MrXGQhqtlkHMrFKm(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 OVZwsLxDfUHEiAYI(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler.schedulePeriodicallyDirect(runnable, j, j2, timeUnit);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 AfqnUhtdxBWFqAen(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedulePeriodically(runnable, j, j2, timeUnit);
    }

    public static void BXpMBKAqGKmlmShu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd348981e$p7004006b pd348981e_p7004006b, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        pd348981e_p7004006b.setResource(p7beea252Var);
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker cNCkUwOJSkbcXYQN(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static void DaLTHVcPdMjwBUMX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd348981e$p7004006b pd348981e_p7004006b, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        pd348981e_p7004006b.setResource(p7beea252Var);
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.Observer<java.lang.long> observer) {
        if ((30 + 25) % 25 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd348981e$p7004006b pd348981e_p7004006b = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd348981e$p7004006b(observer);
        MrXGQhqtlkHMrFKm(observer, pd348981e_p7004006b);
        io.reactivex.rxjava3.core.Scheduler scheduler = this.f499f31e7;
        if (!(scheduler is pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e)) {
            daLTHVcPdMjwBUMX(pd348981e_p7004006b, OVZwsLxDfUHEiAYI(scheduler, pd348981e_p7004006b, this.ffcc1e2f0, this.fa0acfa46, this.f3e34bdeb));
            return;
        }
        io.reactivex.rxjava3.core.Scheduler$Worker scheduler$WorkerCNCkUwOJSkbcXYQN = cNCkUwOJSkbcXYQN(scheduler);
        bXpMBKAqGKmlmShu(pd348981e_p7004006b, scheduler$WorkerCNCkUwOJSkbcXYQN);
        afqnUhtdxBWFqAen(scheduler$WorkerCNCkUwOJSkbcXYQN, pd348981e_p7004006b, this.ffcc1e2f0, this.fa0acfa46, this.f3e34bdeb);
    }
}

