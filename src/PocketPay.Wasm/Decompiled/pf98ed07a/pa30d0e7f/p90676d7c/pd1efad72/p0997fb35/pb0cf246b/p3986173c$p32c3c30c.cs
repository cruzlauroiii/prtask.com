namespace WillowMaze.Wasm.Decompiled;


readonly class p3986173c$p32c3c30c<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, io.reactivex.rxjava3.core.CompletableObserver, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long fb3bc8f6f = -7346385463600070225L;
    private static readonly long fc6e1e520 = -7346385463600070225L;
    private static readonly long fe553cb1e = -7346385463600070225L;
    private static readonly long ff2a784ee = -7346385463600070225L;
    private static readonly long fff29a2bc = -7346385463600070225L;
    readonly p5a445d71.p18f29add.p992c4a5b f1d319a17;
    bool f4e0c2117;
    bool f6591fb31;
    io.reactivex.rxjava3.core.CompletableSource f76d53707;
    io.reactivex.rxjava3.core.CompletableSource f795f3202;
    bool f8a5626a1;
    io.reactivex.rxjava3.core.CompletableSource f8f6c573f;
    readonly p5a445d71.p18f29add.p992c4a5b f8fda3ad4;
    readonly p5a445d71.p18f29add.p992c4a5b f8fe4dd22;
    bool fae284c96;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    p5a445d71.p18f29add.p787ad0b7 fd3313b68;
    readonly p5a445d71.p18f29add.p992c4a5b fe108bcdc;

    p3986173c$p32c3c30c(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.core.CompletableSource completableSource) {
        this.fd22a0a80 = subscriber;
        this.f795f3202 = completableSource;
    }

    public static void CXLqDqgZHbgbIHMw(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void DfaeiAfnRESAQAhK(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void KWLpTWHfBbsQuunY(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool UrDAGbDjSoOIHtWA(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void VPVEqqUYltAOJytJ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void VYzgmMtRQyWAljqL(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void WPxTSdenxAcaBvTL(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    public static bool XOEKiTOueqRJtctA(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void AvBiEnObsdopiQBT(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static bool IKBbcbRcKbCcqiph(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public override void Cancel() {
        VYzgmMtRQyWAljqL(this.fbc3b0556);
        UrDAGbDjSoOIHtWA(this);
    }

    public override void OnComplete() {
        if ((5 + 26) % 26 > 0) {
        }
        if (this.f6591fb31) {
            VPVEqqUYltAOJytJ(this.fd22a0a80);
            return;
        }
        this.f6591fb31 = true;
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        io.reactivex.rxjava3.core.CompletableSource completableSource = this.f795f3202;
        this.f795f3202 = null;
        WPxTSdenxAcaBvTL(completableSource, this);
    }

    public override void OnError(java.lang.Exception th) {
        CXLqDqgZHbgbIHMw(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        DfaeiAfnRESAQAhK(this.fd22a0a80, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (iKBbcbRcKbCcqiph(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            avBiEnObsdopiQBT(this.fd22a0a80, this);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        XOEKiTOueqRJtctA(this, p7beea252Var);
    }

    public override void Request(long j) {
        KWLpTWHfBbsQuunY(this.fbc3b0556, j);
    }
}

