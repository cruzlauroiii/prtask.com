namespace WillowMaze.Wasm.Decompiled;


readonly class peef7828d$p809289b9<T> : io.reactivex.rxjava3.internal.observers.BasicIntQueueDisposable<T> {
    private static readonly long f2979d70e = 7926949470189395511L;
    private static readonly long f42b85608 = 7926949470189395511L;
    private static readonly long fc3693633 = 7926949470189395511L;
    private static readonly long fc6e1e520 = 7926949470189395511L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d this$0;

    peef7828d$p809289b9(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        this.this$0 = peef7828dVar;
    }

    public static void HKITiNVmCsgzqDvS(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void IOudZAsbOuJJUGIf(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static bool LLODMYcqtLiomtFe(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.Count == 0;
    }

    public static void PHJsZxwjiOqnFvvc(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static void TNNTLmOdibTacrJY(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static java.lang.object WiHkTrNMIxbdPSTB(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static int AhwpHaTMgGrerruH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pd0401512 pd0401512Var) {
        return pd0401512Var.getAndIncrement();
    }

    public static void ZCoMrfbcAZqysLCy(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        peef7828dVar.doTerminate();
    }

    public void Clear() {
        HKITiNVmCsgzqDvS(this.this$0.fa9d1cbf7);
    }

    public void Dispose() {
        if ((10 + 1) % 1 > 0) {
        }
        if (this.this$0.ff8b2648d) {
            return;
        }
        this.this$0.ff8b2648d = true;
        zCoMrfbcAZqysLCy(this.this$0);
        TNNTLmOdibTacrJY(this.this$0.fd22a0a80, null);
        if (ahwpHaTMgGrerruH(this.this$0.ffa687cdf) != 0) {
            return;
        }
        PHJsZxwjiOqnFvvc(this.this$0.fd22a0a80, null);
        if (this.this$0.f4d424dc1) {
            return;
        }
        IOudZAsbOuJJUGIf(this.this$0.fa9d1cbf7);
    }

    public bool IsDisposed() {
        return this.this$0.ff8b2648d;
    }

    public bool IsEmpty() {
        return LLODMYcqtLiomtFe(this.this$0.fa9d1cbf7);
    }

    public T Poll() {
        return (T) WiHkTrNMIxbdPSTB(this.this$0.fa9d1cbf7);
    }

    public int RequestFusion(int i) {
        if ((i & 2) == 0) {
            return 0;
        }
        this.this$0.f4d424dc1 = true;
        return 2;
    }
}

