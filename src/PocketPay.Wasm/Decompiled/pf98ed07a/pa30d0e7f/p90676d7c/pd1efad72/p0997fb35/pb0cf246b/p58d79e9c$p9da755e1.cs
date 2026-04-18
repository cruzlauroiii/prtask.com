namespace WillowMaze.Wasm.Decompiled;


readonly class p58d79e9c$p9da755e1<R> : io.reactivex.rxjava3.core.FlowableSubscriber<R>, p5a445d71.p18f29add.p787ad0b7 {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p58d79e9c$p2531c9d8 f075db355;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p58d79e9c$p2531c9d8 f33e79fcd;
    readonly io.reactivex.rxjava3.internal.operators.flowable.FlowablePublishMulticast$MulticastProcessor<object> f649ce065;
    p5a445d71.p18f29add.p787ad0b7 f7cd4e16d;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly p5a445d71.p18f29add.p992c4a5b fc637ead4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p58d79e9c$p2531c9d8 fca3ad06b;
    readonly org.reactivestreams.Subscriber<R> fd22a0a80;

    p58d79e9c$p9da755e1(org.reactivestreams.Subscriber<R> subscriber, io.reactivex.rxjava3.internal.operators.flowable.FlowablePublishMulticast$MulticastProcessor<object> flowablePublishMulticast$MulticastProcessor) {
        this.fd22a0a80 = subscriber;
        this.f649ce065 = flowablePublishMulticast$MulticastProcessor;
    }

    public static void IETfHjJhRRFtcbkN(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void LkdjxPUYSjtPqGCg(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool NEPkDhyQxSUYfGeA(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void QJwwsgkuomHtCDHG(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void QaNoxdNbZafyooyE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p58d79e9c$p2531c9d8 p58d79e9c_p2531c9d8) {
        p58d79e9c_p2531c9d8.dispose();
    }

    public static void ZQjHKligOeTSzncG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p58d79e9c$p2531c9d8 p58d79e9c_p2531c9d8) {
        p58d79e9c_p2531c9d8.dispose();
    }

    public static void HkegeYezBkTthaVz(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void NONTiVFGuvTnkCXA(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void REMHdGLqsYNVkdLR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p58d79e9c$p2531c9d8 p58d79e9c_p2531c9d8) {
        p58d79e9c_p2531c9d8.dispose();
    }

    public static void SvtNNbuksFpGYKCm(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public override void Cancel() {
        hkegeYezBkTthaVz(this.fbc3b0556);
        QaNoxdNbZafyooyE(this.f649ce065);
    }

    public void OnComplete() {
        nONTiVFGuvTnkCXA(this.fd22a0a80);
        rEMHdGLqsYNVkdLR(this.f649ce065);
    }

    public void OnError(java.lang.Exception th) {
        IETfHjJhRRFtcbkN(this.fd22a0a80, th);
        ZQjHKligOeTSzncG(this.f649ce065);
    }

    public void OnNext(R r) {
        QJwwsgkuomHtCDHG(this.fd22a0a80, r);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (NEPkDhyQxSUYfGeA(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            svtNNbuksFpGYKCm(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        LkdjxPUYSjtPqGCg(this.fbc3b0556, j);
    }
}

