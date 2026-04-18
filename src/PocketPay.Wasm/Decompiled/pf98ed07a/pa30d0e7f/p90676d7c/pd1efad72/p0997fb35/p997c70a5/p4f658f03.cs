namespace WillowMaze.Wasm.Decompiled;


public readonly class p4f658f03 : io.reactivex.rxjava3.core.Observable<java.lang.long> {
    readonly long f028c9352;
    readonly long f1143c0f2;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly long f407e322f;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly long f4a0ed984;
    readonly long f55dd94e7;
    readonly long f65f54a21;
    readonly long f660482e0;
    readonly java.util.concurrent.TimeUnit f6eecef9a;
    readonly long f7a463fbb;
    readonly io.reactivex.rxjava3.core.Scheduler f7a70f8de;
    readonly long f7bd436d3;
    readonly java.util.concurrent.TimeUnit f7d2907e1;
    readonly long f7f021a14;
    readonly long f821444ba;
    readonly long f9406b9ba;
    readonly io.reactivex.rxjava3.core.Scheduler f97caa184;
    readonly long fa0acfa46;
    readonly long fbd8b6466;
    readonly io.reactivex.rxjava3.core.Scheduler fc4029814;
    readonly long fdd8623e2;
    readonly long fea2b2676;
    readonly long ff4b3bc22;
    readonly long ffcc1e2f0;

    public p4f658f03(long j, long j2, long j3, long j4, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler) {
        this.ffcc1e2f0 = j3;
        this.fa0acfa46 = j4;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.fea2b2676 = j;
        this.f7f021a14 = j2;
    }

    public static void DUuZzOAEihKdkPXN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p4f658f03$pb45c90a3 p4f658f03_pb45c90a3, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p4f658f03_pb45c90a3.setResource(p7beea252Var);
    }

    public static void RdBnBZhRzVZfnocC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p4f658f03$pb45c90a3 p4f658f03_pb45c90a3, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p4f658f03_pb45c90a3.setResource(p7beea252Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 JbNWdfOapzuUsHEI(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler.schedulePeriodicallyDirect(runnable, j, j2, timeUnit);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 MjJDiQvbghguVSKM(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedulePeriodically(runnable, j, j2, timeUnit);
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker olYFWAOjdFajUkmh(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static void WJyBexYyXRtdqbUK(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.Observer<java.lang.long> observer) {
        if ((29 + 20) % 20 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p4f658f03$pb45c90a3 p4f658f03_pb45c90a3 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p4f658f03$pb45c90a3(observer, this.fea2b2676, this.f7f021a14);
        wJyBexYyXRtdqbUK(observer, p4f658f03_pb45c90a3);
        io.reactivex.rxjava3.core.Scheduler scheduler = this.f499f31e7;
        if (!(scheduler is pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e)) {
            RdBnBZhRzVZfnocC(p4f658f03_pb45c90a3, jbNWdfOapzuUsHEI(scheduler, p4f658f03_pb45c90a3, this.ffcc1e2f0, this.fa0acfa46, this.f3e34bdeb));
            return;
        }
        io.reactivex.rxjava3.core.Scheduler$Worker scheduler$WorkerOlYFWAOjdFajUkmh = olYFWAOjdFajUkmh(scheduler);
        DUuZzOAEihKdkPXN(p4f658f03_pb45c90a3, scheduler$WorkerOlYFWAOjdFajUkmh);
        mjJDiQvbghguVSKM(scheduler$WorkerOlYFWAOjdFajUkmh, p4f658f03_pb45c90a3, this.ffcc1e2f0, this.fa0acfa46, this.f3e34bdeb);
    }
}

