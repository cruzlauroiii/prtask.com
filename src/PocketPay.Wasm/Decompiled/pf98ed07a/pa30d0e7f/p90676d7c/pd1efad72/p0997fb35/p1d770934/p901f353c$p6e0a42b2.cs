namespace WillowMaze.Wasm.Decompiled;


readonly class p901f353c$p6e0a42b2<R> : java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> : io.reactivex.rxjava3.core.FlowableSubscriber<R>, io.reactivex.rxjava3.core.CompletableObserver, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f03c3456b = -8948264376121066672L;
    private static readonly long fc6e1e520 = -8948264376121066672L;
    private static readonly long fcacbfb84 = -8948264376121066672L;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f27e455eb;
    readonly java.util.concurrent.atomic.Atomiclong f456ce5b9;
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    org.reactivestreams.Publisher<? : R> f795f3202;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f86d54e6a;
    readonly java.util.concurrent.atomic.Atomiclong f9e5c1cec;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly java.util.concurrent.atomic.Atomiclong fc4b973ba;
    p5a445d71.p18f29add.p32c73be0 fc7c95a43;
    readonly p5a445d71.p18f29add.p992c4a5b fd11410cb;
    readonly org.reactivestreams.Subscriber<R> fd22a0a80;
    readonly java.util.concurrent.atomic.Atomiclong fdd7c435f;
    p5a445d71.p18f29add.p32c73be0 fea8f186f;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ffbf881b9;

    p901f353c$p6e0a42b2(org.reactivestreams.Subscriber<R> subscriber, org.reactivestreams.Publisher<? : R> publisher) {
        this.fd22a0a80 = subscriber;
        this.f795f3202 = publisher;
    }

    public static void BjLcrCjbKUbWHUMn(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static bool HqXJULPJhGPXslGw(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void MBBiUUvLvDPLsWjC(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredRequest(atomicReference, atomiclong, j);
    }

    public static void OXHdITPcpXKRIJVE(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static void UbIUveDfIjHKhHBi(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void WvfgbAHxaiCUTVfM(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool ZZDTyXPXcOWCcYHk(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void PdrvnYxsnMKJaEbM(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static bool RPbByqjsAxejMNNN(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredHashSetOnce(atomicReference, atomiclong, p787ad0b7Var);
    }

    public static void RfAPXjsGqClVQnSo(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public override void Cancel() {
        WvfgbAHxaiCUTVfM(this.fbc3b0556);
        ZZDTyXPXcOWCcYHk(this);
    }

    public override void OnComplete() {
        if ((21 + 17) % 17 > 0) {
        }
        org.reactivestreams.Publisher<? : R> publisher = this.f795f3202;
        if (publisher is null) {
            pdrvnYxsnMKJaEbM(this.fd22a0a80);
        } else {
            this.f795f3202 = null;
            OXHdITPcpXKRIJVE(publisher, this);
        }
    }

    public override void OnError(java.lang.Exception th) {
        rfAPXjsGqClVQnSo(this.fd22a0a80, th);
    }

    public void OnNext(R r) {
        UbIUveDfIjHKhHBi(this.fd22a0a80, r);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        rPbByqjsAxejMNNN(this, this.f67a14a21, p787ad0b7Var);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (HqXJULPJhGPXslGw(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            BjLcrCjbKUbWHUMn(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        MBBiUUvLvDPLsWjC(this, this.f67a14a21, j);
    }
}

