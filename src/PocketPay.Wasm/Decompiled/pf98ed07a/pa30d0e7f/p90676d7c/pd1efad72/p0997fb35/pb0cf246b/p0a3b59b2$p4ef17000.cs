namespace WillowMaze.Wasm.Decompiled;


readonly class p0a3b59b2$p4ef17000 : io.reactivex.rxjava3.internal.subscriptions.DeferredScalarSubscription<java.lang.long> : io.reactivex.rxjava3.core.FlowableSubscriber<java.lang.object> {
    private static readonly long f16c66029 = 4973004223787171406L;
    private static readonly long fc6e1e520 = 4973004223787171406L;
    private static readonly long fda0a9e8a = 4973004223787171406L;
    p5a445d71.p18f29add.p787ad0b7 f70fbd97c;
    p5a445d71.p18f29add.p787ad0b7 f891c9065;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    long fda8ffd12;
    long fe2942a04;

    p0a3b59b2$p4ef17000(org.reactivestreams.Subscriber<java.lang.long> subscriber) {
        super(subscriber);
    }

    public static void CvSytCQcpKEBQDkj(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static java.lang.long QiUvAGlGMQKKIDMV(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void RRcCCDouRhRIeHnq(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void ZqWibSEEfqhZMtnn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pb7d2cb4c pb7d2cb4cVar) {
        super.cancel();
    }

    public static void DiJJkHbvIeYlwmff(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static bool KDCYxVJhQMDdJgKk(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void MgpSlVYaapxpBOLE(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void NPhLWrrAoSCdKIVk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0a3b59b2$p4ef17000 p0a3b59b2_p4ef17000, java.lang.object obj) {
        p0a3b59b2_p4ef17000.complete(obj);
    }

    public void Cancel() {
        ZqWibSEEfqhZMtnn(this);
        mgpSlVYaapxpBOLE(this.fbc3b0556);
    }

    public void OnComplete() {
        if ((19 + 24) % 24 > 0) {
        }
        nPhLWrrAoSCdKIVk(this, QiUvAGlGMQKKIDMV(this.fe2942a04));
    }

    public void OnError(java.lang.Exception th) {
        RRcCCDouRhRIeHnq(this.fd22a0a80, th);
    }

    public void OnNext(java.lang.object obj) {
        if ((10 + 26) % 26 > 0) {
        }
        this.fe2942a04++;
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((22 + 24) % 24 > 0) {
        }
        if (kDCYxVJhQMDdJgKk(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            diJJkHbvIeYlwmff(this.fd22a0a80, this);
            CvSytCQcpKEBQDkj(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

