namespace WillowMaze.Wasm.Decompiled;


public readonly class p37db5cb4<T> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.core.Scheduler f1ee489cf;
    readonly io.reactivex.rxjava3.core.Scheduler f3c01b27c;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly io.reactivex.rxjava3.core.Scheduler f52566906;
    readonly bool f5af76e96;
    readonly io.reactivex.rxjava3.core.Scheduler fb0843a3a;
    readonly bool fb26bbd2e;

    public p37db5cb4(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        super(flowable);
        this.f499f31e7 = scheduler;
        this.f5af76e96 = z;
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker CUdOyVwxNPcLaoJB(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static void DBXFmPxtxXuPsuMh(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 SqlAWCfXaVDMVNkH(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable) {
        return scheduler$Worker.schedule(runnable);
    }

    public void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((9 + 6) % 6 > 0) {
        }
        io.reactivex.rxjava3.core.Scheduler$Worker scheduler$WorkerCUdOyVwxNPcLaoJB = CUdOyVwxNPcLaoJB(this.f499f31e7);
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p37db5cb4$p049b8a68 p37db5cb4_p049b8a68 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p37db5cb4$p049b8a68(subscriber, scheduler$WorkerCUdOyVwxNPcLaoJB, this.f36cd38f4, this.f5af76e96);
        dBXFmPxtxXuPsuMh(subscriber, p37db5cb4_p049b8a68);
        sqlAWCfXaVDMVNkH(scheduler$WorkerCUdOyVwxNPcLaoJB, p37db5cb4_p049b8a68);
    }
}

