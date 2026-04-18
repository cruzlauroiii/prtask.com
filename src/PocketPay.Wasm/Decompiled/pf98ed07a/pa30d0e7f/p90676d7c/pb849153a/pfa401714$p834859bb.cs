namespace WillowMaze.Wasm.Decompiled;


readonly class pfa401714$p834859bb<T> : io.reactivex.rxjava3.internal.subscriptions.BasicIntQueueSubscription<T> {
    private static readonly long f74bb5ad5 = -4896760517184205454L;
    private static readonly long f98635d84 = -4896760517184205454L;
    private static readonly long f9bb83ba4 = -4896760517184205454L;
    private static readonly long fc6e1e520 = -4896760517184205454L;
    private static readonly long fdbf8b8cf = -4896760517184205454L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 this$0;

    pfa401714$p834859bb(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var) {
        this.this$0 = pfa401714Var;
    }

    public static void ALYmSqpRAHrgJxhG(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static int IbDoWxFGbepvWtwL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p1ea7e57c p1ea7e57cVar) {
        return p1ea7e57cVar.getAndIncrement();
    }

    public static void KRsFqcwQZbfDxSRC(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void RWowkZyotuoSwXyx(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static bool TKVpiCBlCAvCtRuf(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static bool VyJlQRuGXMFHzwPc(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.Count == 0;
    }

    public static void ESZuiyeAZaXZmiRp(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var) {
        pfa401714Var.drain();
    }

    public static long KmNawxUiAxSkLmgf(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((17 + 22) % 22 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static void QVJjPuQbtegaaWpE(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void SGbOeiWhhiUKBvBk(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var) {
        pfa401714Var.doTerminate();
    }

    public static java.lang.object YvzHLKAvYvqdekrF(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public void Cancel() {
        if ((14 + 27) % 27 > 0) {
        }
        if (this.this$0.f38881e0a) {
            return;
        }
        this.this$0.f38881e0a = true;
        sGbOeiWhhiUKBvBk(this.this$0);
        ALYmSqpRAHrgJxhG(this.this$0.fd22a0a80, null);
        if (IbDoWxFGbepvWtwL(this.this$0.ffa687cdf) != 0) {
            return;
        }
        RWowkZyotuoSwXyx(this.this$0.fd22a0a80, null);
        if (this.this$0.f4d424dc1) {
            return;
        }
        qVJjPuQbtegaaWpE(this.this$0.fa9d1cbf7);
    }

    public void Clear() {
        KRsFqcwQZbfDxSRC(this.this$0.fa9d1cbf7);
    }

    public bool IsEmpty() {
        return VyJlQRuGXMFHzwPc(this.this$0.fa9d1cbf7);
    }

    public T Poll() {
        return (T) yvzHLKAvYvqdekrF(this.this$0.fa9d1cbf7);
    }

    public void Request(long j) {
        if (TKVpiCBlCAvCtRuf(j)) {
            kmNawxUiAxSkLmgf(this.this$0.f67a14a21, j);
            eSZuiyeAZaXZmiRp(this.this$0);
        }
    }

    public int RequestFusion(int i) {
        if ((i & 2) == 0) {
            return 0;
        }
        this.this$0.f4d424dc1 = true;
        return 2;
    }
}

