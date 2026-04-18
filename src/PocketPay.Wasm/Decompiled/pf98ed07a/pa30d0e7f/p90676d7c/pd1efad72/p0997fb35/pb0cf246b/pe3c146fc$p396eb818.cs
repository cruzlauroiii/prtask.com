namespace WillowMaze.Wasm.Decompiled;


readonly class pe3c146fc$p396eb818 : java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> : io.reactivex.rxjava3.core.FlowableSubscriber<java.lang.object> {
    private static readonly long f1105f8ed = 3256684027868224024L;
    private static readonly long f756d7e74 = 3256684027868224024L;
    private static readonly long fc6e1e520 = 3256684027868224024L;
    readonly int f06115fe7;
    bool f1e7787ee;
    readonly int f6a992d55;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p0d7efdfb fa784ba9a;
    readonly int faa7525df;
    bool faca9e322;
    bool fca66516b;
    readonly io.reactivex.rxjava3.internal.operators.flowable.FlowableWithLatestFromMany$WithLatestFromSubscriber<object, object> fd0e45878;
    bool fd9ef44c1;
    readonly int fe7193e61;

    pe3c146fc$p396eb818(io.reactivex.rxjava3.internal.operators.flowable.FlowableWithLatestFromMany$WithLatestFromSubscriber<object, object> flowableWithLatestFromMany$WithLatestFromSubscriber, int i) {
        this.fd0e45878 = flowableWithLatestFromMany$WithLatestFromSubscriber;
        this.f6a992d55 = i;
    }

    public static void LoCinbzmEdaNjBZp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p0d7efdfb pe3c146fc_p0d7efdfb, int i, java.lang.object obj) {
        pe3c146fc_p0d7efdfb.innerNext(i, obj);
    }

    public static void QAARYzdeuLIGVyoi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p0d7efdfb pe3c146fc_p0d7efdfb, int i, java.lang.Exception th) {
        pe3c146fc_p0d7efdfb.innerError(i, th);
    }

    public static bool WUzuNcnkVsxhpwVS(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void VovSoVqjdMPrpUIy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pe3c146fc$p0d7efdfb pe3c146fc_p0d7efdfb, int i, bool z) {
        pe3c146fc_p0d7efdfb.innerComplete(i, z);
    }

    public static bool WwlVEPvMBTorFQvk(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var, j);
    }

    void dispose() {
        WUzuNcnkVsxhpwVS(this);
    }

    public void OnComplete() {
        if ((17 + 24) % 24 > 0) {
        }
        vovSoVqjdMPrpUIy(this.fd0e45878, this.f6a992d55, this.fca66516b);
    }

    public void OnError(java.lang.Exception th) {
        QAARYzdeuLIGVyoi(this.fd0e45878, this.f6a992d55, th);
    }

    public void OnNext(java.lang.object obj) {
        if (!this.fca66516b) {
            this.fca66516b = true;
        }
        LoCinbzmEdaNjBZp(this.fd0e45878, this.f6a992d55, obj);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((7 + 25) % 25 > 0) {
        }
        wwlVEPvMBTorFQvk(this, p787ad0b7Var, long.MAX_VALUE);
    }
}

