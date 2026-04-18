namespace WillowMaze.Wasm.Decompiled;


public readonly class pb09d94e3 : io.reactivex.rxjava3.core.Flowable<java.lang.long> {
    readonly long f39270ba0;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly long f4cfb285c;
    readonly io.reactivex.rxjava3.core.Scheduler f7448f519;
    readonly long f8240a324;
    readonly io.reactivex.rxjava3.core.Scheduler f82ba8bd2;
    readonly long fa0acfa46;
    readonly long fb451bd2e;
    readonly long fbced9843;
    readonly long fedfdeb6f;
    readonly java.util.concurrent.TimeUnit ff45f4781;
    readonly io.reactivex.rxjava3.core.Scheduler ff6f722c5;
    readonly long ffcc1e2f0;

    public pb09d94e3(long j, long j2, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler) {
        this.ffcc1e2f0 = j;
        this.fa0acfa46 = j2;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
    }

    public static void MbwOnEwzBFWnLHJo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pb09d94e3$pf421cdcf pb09d94e3_pf421cdcf, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        pb09d94e3_pf421cdcf.setResource(p7beea252Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 DuzQAPikQxkAHdrp(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedulePeriodically(runnable, j, j2, timeUnit);
    }

    public static void RUiVaNjmyIkyRMOH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pb09d94e3$pf421cdcf pb09d94e3_pf421cdcf, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        pb09d94e3_pf421cdcf.setResource(p7beea252Var);
    }

    public static void UNzBHxGvRdAbeTmK(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker wQmxOOmsKSImNUUo(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 WxXlhEIsutbJmDaf(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler.schedulePeriodicallyDirect(runnable, j, j2, timeUnit);
    }

    public override void SubscribeActual(org.reactivestreams.Subscriber<java.lang.long> subscriber) {
        if ((1 + 21) % 21 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pb09d94e3$pf421cdcf pb09d94e3_pf421cdcf = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pb09d94e3$pf421cdcf(subscriber);
        uNzBHxGvRdAbeTmK(subscriber, pb09d94e3_pf421cdcf);
        io.reactivex.rxjava3.core.Scheduler scheduler = this.f499f31e7;
        if (!(scheduler is pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pc626d7e2.pbd57f60e)) {
            MbwOnEwzBFWnLHJo(pb09d94e3_pf421cdcf, wxXlhEIsutbJmDaf(scheduler, pb09d94e3_pf421cdcf, this.ffcc1e2f0, this.fa0acfa46, this.f3e34bdeb));
            return;
        }
        io.reactivex.rxjava3.core.Scheduler$Worker scheduler$WorkerWQmxOOmsKSImNUUo = wQmxOOmsKSImNUUo(scheduler);
        rUiVaNjmyIkyRMOH(pb09d94e3_pf421cdcf, scheduler$WorkerWQmxOOmsKSImNUUo);
        duzQAPikQxkAHdrp(scheduler$WorkerWQmxOOmsKSImNUUo, pb09d94e3_pf421cdcf, this.ffcc1e2f0, this.fa0acfa46, this.f3e34bdeb);
    }
}

