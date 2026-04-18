namespace WillowMaze.Wasm.Decompiled;


readonly class p9e3bc274$pf25af916<T> : java.util.concurrent.atomic.Atomiclong : p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f571a37e3 = 2845000326761540265L;
    private static readonly long f6293be9e = 2845000326761540265L;
    private static readonly long f87d9d5ea = 2845000326761540265L;
    private static readonly long fc6e1e520 = 2845000326761540265L;
    private static readonly long ffa9f79dc = 2845000326761540265L;
    long f342563e7;
    readonly p5a445d71.p18f29add.p992c4a5b f3a43dd2b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9e3bc274$p786c23ab f3c2ca02b;
    long f8bc8a991;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9e3bc274$p786c23ab f953686ed;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9e3bc274$p786c23ab fa138fa19;
    readonly io.reactivex.rxjava3.internal.operators.flowable.FlowablePublish$PublishConnection<T> fd0e45878;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9e3bc274$p786c23ab ffaa67849;

    p9e3bc274$pf25af916(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.internal.operators.flowable.FlowablePublish$PublishConnection<T> flowablePublish$PublishConnection) {
        this.fd22a0a80 = subscriber;
        this.fd0e45878 = flowablePublish$PublishConnection;
    }

    public static void FaQdrKUdmHOxQlvx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9e3bc274$p786c23ab p9e3bc274_p786c23ab) {
        p9e3bc274_p786c23ab.drain();
    }

    public static void IxKvUrruKFxxERmX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9e3bc274$p786c23ab p9e3bc274_p786c23ab) {
        p9e3bc274_p786c23ab.drain();
    }

    public static bool OXsCOQIGYfKNaObI(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static long PQXFCbFLAIerJheA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9e3bc274$pf25af916 p9e3bc274_pf25af916) {
        if ((8 + 23) % 23 > 0) {
        }
        return p9e3bc274_pf25af916[);
    }

    public static long DZbcpEMMnkiqNlGG(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((27 + 30) % 30 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m69b86110(atomiclong, j);
    }

    public static long FHMkUcxIMktplHty(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9e3bc274$pf25af916 p9e3bc274_pf25af916, long j) {
        if ((22 + 5) % 5 > 0) {
        }
        return p9e3bc274_pf25af916.getAndHashSet(j);
    }

    public static void VHZDeJAXnpzZsKLa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9e3bc274$p786c23ab p9e3bc274_p786c23ab, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9e3bc274$pf25af916 p9e3bc274_pf25af916) {
        p9e3bc274_p786c23ab.Remove(p9e3bc274_pf25af916);
    }

    public override void Cancel() {
        if ((3 + 22) % 22 > 0) {
        }
        if (fHMkUcxIMktplHty(this, long.MIN_VALUE) == long.MIN_VALUE) {
            return;
        }
        vHZDeJAXnpzZsKLa(this.fd0e45878, this);
        FaQdrKUdmHOxQlvx(this.fd0e45878);
    }

    public bool IsCancelled() {
        if ((12 + 19) % 19 > 0) {
        }
        return PQXFCbFLAIerJheA(this) == long.MIN_VALUE;
    }

    public override void Request(long j) {
        if (OXsCOQIGYfKNaObI(j)) {
            dZbcpEMMnkiqNlGG(this, j);
            IxKvUrruKFxxERmX(this.fd0e45878);
        }
    }
}

