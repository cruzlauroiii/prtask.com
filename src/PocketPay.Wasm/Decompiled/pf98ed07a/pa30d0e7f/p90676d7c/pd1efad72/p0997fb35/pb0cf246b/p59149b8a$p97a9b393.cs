namespace WillowMaze.Wasm.Decompiled;


readonly class p59149b8a$p97a9b393<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.operators.ConditionalSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f3a7aa41c = -6270983465606289181L;
    private static readonly long fc6e1e520 = -6270983465606289181L;
    readonly p5a445d71.p18f29add.p992c4a5b f08df7258;
    volatile bool f0e5cf0a8;
    readonly java.util.concurrent.atomic.object f1711aa95;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f1d09f5ce;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p59149b8a$p97a9b393$p4c783800 f23284f20;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f27e3bde7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f2c6c1425;
    readonly java.util.concurrent.atomic.object f3a7b11f0;
    readonly java.util.concurrent.atomic.Atomiclong f4b8e101c;
    readonly p5a445d71.p18f29add.p992c4a5b f4fc4385d;
    readonly java.util.concurrent.atomic.object f520e8d5d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f61d6a360;
    volatile bool f63d721d2;
    readonly java.util.concurrent.atomic.object f67462250;
    readonly p5a445d71.p18f29add.p992c4a5b f6bd81c28;
    volatile bool f9779165c;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly p5a445d71.p18f29add.p992c4a5b fdac5c43f;
    readonly java.util.concurrent.atomic.Atomiclong ff02b525f;
    volatile bool ffc0903c2;
    readonly java.util.concurrent.atomic.Atomiclong fff6018bf;
    readonly java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> fbc3b0556 = new java.util.concurrent.atomic.object<>();
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    readonly io.reactivex.rxjava3.internal.operators.flowable.FlowableSkipUntil$SkipUntilMainSubscriber<T>.FlowableSkipUntil$SkipUntilMainSubscriber$OtherSubscriber f795f3202 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p59149b8a$p97a9b393$p4c783800(this);
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fcb5e100e = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();

    p59149b8a$p97a9b393(org.reactivestreams.Subscriber<T> subscriber) {
        this.fd22a0a80 = subscriber;
    }

    public static void AvpYAhCnPTGxrYEM(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.util.concurrent.atomic.Atomicint atomicint, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc584ea14.m6ae9fbb6((org.reactivestreams.Subscriber<object>) p992c4a5bVar, atomicint, p36a52e5dVar);
    }

    public static void KyNTqQFdeHtmThFD(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th, java.util.concurrent.atomic.Atomicint atomicint, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc584ea14.mdcce2ff2((org.reactivestreams.Subscriber<object>) p992c4a5bVar, th, atomicint, p36a52e5dVar);
    }

    public static void MHaaBTNWcnYoGqUn(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredRequest(atomicReference, atomiclong, j);
    }

    public static bool UVnLmMhjCECpQeUV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p59149b8a$p97a9b393 p59149b8a_p97a9b393, java.lang.object obj) {
        return p59149b8a_p97a9b393.tryOnNext(obj);
    }

    public static void LGpDQcQHuzIGrBxZ(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool LxTKaaAuRXEvAXBu(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredHashSetOnce(atomicReference, atomiclong, p787ad0b7Var);
    }

    public static bool MMRGDiIqZuPixVTM(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static java.lang.object NiTEplTRYAiEuDPR(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool SWCxirddyvIUuAOC(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static bool UNiKoYrfSjxYxvXT(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static bool XwPqJpQNtLgXfsLq(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static bool ZpcFHxPVBoQAhJBP(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj, java.util.concurrent.atomic.Atomicint atomicint, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc584ea14.mf51350c3((org.reactivestreams.Subscriber<java.lang.object>) p992c4a5bVar, obj, atomicint, p36a52e5dVar);
    }

    public override void Cancel() {
        mMRGDiIqZuPixVTM(this.fbc3b0556);
        sWCxirddyvIUuAOC(this.f795f3202);
    }

    public void OnComplete() {
        if ((19 + 2) % 2 > 0) {
        }
        xwPqJpQNtLgXfsLq(this.f795f3202);
        AvpYAhCnPTGxrYEM(this.fd22a0a80, this, this.fcb5e100e);
    }

    public void OnError(java.lang.Exception th) {
        if ((2 + 20) % 20 > 0) {
        }
        uNiKoYrfSjxYxvXT(this.f795f3202);
        KyNTqQFdeHtmThFD(this.fd22a0a80, th, this, this.fcb5e100e);
    }

    public void OnNext(T t) {
        if ((21 + 8) % 8 > 0) {
        }
        if (UVnLmMhjCECpQeUV(this, t)) {
            return;
        }
        lGpDQcQHuzIGrBxZ((p5a445d71.p18f29add.p787ad0b7) niTEplTRYAiEuDPR(this.fbc3b0556), 1L);
    }

    public void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        lxTKaaAuRXEvAXBu(this.fbc3b0556, this.f67a14a21, p787ad0b7Var);
    }

    public override void Request(long j) {
        MHaaBTNWcnYoGqUn(this.fbc3b0556, this.f67a14a21, j);
    }

    public bool TryOnNext(T t) {
        if ((17 + 3) % 3 > 0) {
        }
        if (!this.f63d721d2) {
            return false;
        }
        zpcFHxPVBoQAhJBP(this.fd22a0a80, t, this, this.fcb5e100e);
        return true;
    }
}

