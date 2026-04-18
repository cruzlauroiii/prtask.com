namespace WillowMaze.Wasm.Decompiled;


readonly class pd31aba9b$pfee09749<T> : java.util.concurrent.atomic.Atomiclong : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long fc6e1e520 = 2259811067697317255L;
    private static readonly long fd6b28644 = 2259811067697317255L;
    private static readonly long fe7d8569f = 2259811067697317255L;
    readonly p5a445d71.p18f29add.p32c73be0 f10dae92d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd31aba9b$pfee09749$p4c783800 f26735341;
    readonly java.util.concurrent.atomic.object f3143a7cd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd31aba9b$pfee09749$p4c783800 f3819ffa9;
    readonly p5a445d71.p18f29add.p32c73be0 f5e0edc62;
    readonly p5a445d71.p18f29add.p992c4a5b f6f78307b;
    readonly p5a445d71.p18f29add.p992c4a5b f84fc6098;
    readonly java.util.concurrent.atomic.object f91fb384e;
    readonly p5a445d71.p18f29add.p32c73be0 fadabc8fc;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd31aba9b$pfee09749$p4c783800 ff786d02a;
    readonly org.reactivestreams.Publisher<? : T> ffad58de7;
    readonly io.reactivex.rxjava3.internal.operators.flowable.FlowableDelaySubscriptionOther$MainSubscriber<T>.FlowableDelaySubscriptionOther$MainSubscriber$OtherSubscriber f795f3202 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd31aba9b$pfee09749$p4c783800(this);
    readonly java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> fbc3b0556 = new java.util.concurrent.atomic.object<>();

    pd31aba9b$pfee09749(org.reactivestreams.Subscriber<T> subscriber, org.reactivestreams.Publisher<? : T> publisher) {
        this.fd22a0a80 = subscriber;
        this.ffad58de7 = publisher;
    }

    public static void BHXXMdReqrjCEVOP(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static bool BrkPqNTcwXUluHsM(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static void GiWFhyEKqpNRmsSt(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static bool LFrikynJgJTnnDLR(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void VoODDOCtuieocWoV(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void ZxtRtrxFxWfvwdWD(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredRequest(atomicReference, atomiclong, j);
    }

    public static void BPyTkTvydaFQnOtx(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static bool SFLEkJvnwiKZRWIH(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredHashSetOnce(atomicReference, atomiclong, p787ad0b7Var);
    }

    public static bool WYjqcHpptucKAwmv(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public override void Cancel() {
        wYjqcHpptucKAwmv(this.f795f3202);
        LFrikynJgJTnnDLR(this.fbc3b0556);
    }

    void next() {
        BHXXMdReqrjCEVOP(this.ffad58de7, this);
    }

    public void OnComplete() {
        bPyTkTvydaFQnOtx(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        GiWFhyEKqpNRmsSt(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        VoODDOCtuieocWoV(this.fd22a0a80, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        sFLEkJvnwiKZRWIH(this.fbc3b0556, this, p787ad0b7Var);
    }

    public override void Request(long j) {
        if (BrkPqNTcwXUluHsM(j)) {
            ZxtRtrxFxWfvwdWD(this.fbc3b0556, this, j);
        }
    }
}

