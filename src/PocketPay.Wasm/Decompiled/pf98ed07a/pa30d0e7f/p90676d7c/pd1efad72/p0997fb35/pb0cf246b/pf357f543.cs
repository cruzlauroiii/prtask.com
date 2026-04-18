namespace WillowMaze.Wasm.Decompiled;


public readonly class pf357f543<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.Scheduler f21fed54c;
    readonly java.util.concurrent.TimeUnit f23c4611f;
    readonly p5a445d71.p18f29add.p32c73be0 f396cc02c;
    readonly p5a445d71.p18f29add.p32c73be0 f3a987800;
    readonly long f3de405a5;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.Scheduler f67c7626a;
    readonly org.reactivestreams.Publisher<? : T> f795f3202;
    readonly java.util.concurrent.TimeUnit f7ec546c3;
    readonly long f7f3e14c1;
    readonly long f90272dda;
    readonly long fcef2a72a;
    readonly p5a445d71.p18f29add.p32c73be0 fd346f814;
    readonly java.util.concurrent.TimeUnit fd74490bc;
    readonly java.util.concurrent.TimeUnit fd97c234c;

    public pf357f543(io.reactivex.rxjava3.core.Flowable<T> flowable, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, org.reactivestreams.Publisher<? : T> publisher) {
        super(flowable);
        this.f90272dda = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.f795f3202 = publisher;
    }

    public static void HFKWURBdUoRNrGcp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf357f543$pce0ce207 pf357f543_pce0ce207, long j) {
        pf357f543_pce0ce207.startTimeout(j);
    }

    public static void MljawYlDvbBmxjGx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf357f543$pd1e8bd20 pf357f543_pd1e8bd20, long j) {
        pf357f543_pd1e8bd20.startTimeout(j);
    }

    public static void QGvSZFZOUMSKRrtb(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void ZoSGYfOzTYEgJOrH(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void DGnksSmxRDlXrUQB(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void JBWtknHJPupSbuNQ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker pgAibeuckWrxNrrp(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker yXaPUnCoynVtcOiN(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((1 + 13) % 13 > 0) {
        }
        if (this.f795f3202 is not null) {
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf357f543$pd1e8bd20 pf357f543_pd1e8bd20 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf357f543$pd1e8bd20(subscriber, this.f90272dda, this.f3e34bdeb, pgAibeuckWrxNrrp(this.f499f31e7), this.f795f3202);
            jBWtknHJPupSbuNQ(subscriber, pf357f543_pd1e8bd20);
            MljawYlDvbBmxjGx(pf357f543_pd1e8bd20, 0L);
            ZoSGYfOzTYEgJOrH(this.f36cd38f4, pf357f543_pd1e8bd20);
            return;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf357f543$pce0ce207 pf357f543_pce0ce207 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf357f543$pce0ce207(subscriber, this.f90272dda, this.f3e34bdeb, yXaPUnCoynVtcOiN(this.f499f31e7));
        QGvSZFZOUMSKRrtb(subscriber, pf357f543_pce0ce207);
        HFKWURBdUoRNrGcp(pf357f543_pce0ce207, 0L);
        dGnksSmxRDlXrUQB(this.f36cd38f4, pf357f543_pce0ce207);
    }
}

