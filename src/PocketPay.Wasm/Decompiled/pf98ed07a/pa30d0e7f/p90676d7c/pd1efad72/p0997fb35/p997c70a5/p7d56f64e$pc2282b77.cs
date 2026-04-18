namespace WillowMaze.Wasm.Decompiled;


readonly class p7d56f64e$pc2282b77<T> : java.util.concurrent.atomic.Atomicbool : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f92ebc458 = -5677354903406201275L;
    private static readonly long fc0e881ed = -5677354903406201275L;
    private static readonly long fc6e1e520 = -5677354903406201275L;
    readonly long f07cc694b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f0d959fa8;
    readonly io.reactivex.rxjava3.core.Scheduler f0e654640;
    readonly bool f11d3ce15;
    readonly bool f184e367f;
    volatile bool f20c951d2;
    java.lang.Exception f2e465fc5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f338dadb3;
    volatile bool f33d8165b;
    volatile bool f38881e0a;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly bool f825ea879;
    readonly java.util.concurrent.TimeUnit fa52db987;
    readonly io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> fa9d1cbf7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c fada0e467;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fb0f0f76c;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly long fbe1db69f;
    java.lang.Exception fcb5e100e;
    readonly io.reactivex.rxjava3.core.Observer fcf9ba0ed;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly long fd3e16e17;
    readonly long fdc339bab;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c fdc617717;
    readonly long fe2942a04;
    readonly io.reactivex.rxjava3.core.Observer fe59a6ce9;
    readonly long fe68f9fdd;
    java.lang.Exception fe9b8a357;
    java.lang.Exception ff6896d8f;

    p7d56f64e$pc2282b77(io.reactivex.rxjava3.core.Observer<T> observer, long j, long j2, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, int i, bool z) {
        this.fd22a0a80 = observer;
        this.fe2942a04 = j;
        this.f07cc694b = j2;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(i);
        this.f825ea879 = z;
    }

    public static bool DGIJeBSwBGQnmwsh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p7d56f64e$pc2282b77 p7d56f64e_pc2282b77, bool z, bool z2) {
        return p7d56f64e_pc2282b77.compareAndHashSet(z, z2);
    }

    public static void DhLYuovNsgVNwUVw(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static long DqThqosztPbygmvI(java.lang.long l) {
        if ((27 + 11) % 11 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.object EATyIaRbEEVeryBK(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static bool EPWaYQJkVnDgMIaN(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static java.lang.object FCuECwJMRCgzWnhq(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.peek();
    }

    public static long FSXhUDlkoRvMHprk(java.lang.long l) {
        if ((3 + 20) % 20 > 0) {
        }
        return l.longValue();
    }

    public static void GHLwDMBBmwqTaWki(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool JUGrDOGelIhvkOVM(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.Count == 0;
    }

    public static java.lang.long JcXRzAgskwjdjVkZ(long j) {
        return java.lang.long.valueOf(j);
    }

    public static long KKMetzREBOrOFPVO(io.reactivex.rxjava3.core.Scheduler scheduler, java.util.concurrent.TimeUnit timeUnit) {
        if ((15 + 12) % 12 > 0) {
        }
        return scheduler.now(timeUnit);
    }

    public static void OLprcfWwocoRKsxH(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void QrkMMHqMOHyrWxxl(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void SRCEflufVjRAckHI(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static bool SsqiwBHCLjGtCJPH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p7d56f64e$pc2282b77 p7d56f64e_pc2282b77, bool z, bool z2) {
        return p7d56f64e_pc2282b77.compareAndHashSet(z, z2);
    }

    public static void TKQKOJsyaCDalvXm(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void ToyzKDGCEQwjvqfr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p7d56f64e$pc2282b77 p7d56f64e_pc2282b77) {
        p7d56f64e_pc2282b77.drain();
    }

    public static java.lang.object DsGSEMarYUBHhNUL(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static bool EhKMQjwCPPRbwJZg(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj, java.lang.object obj2) {
        return p50dc035cVar.offer(obj, obj2);
    }

    public static java.lang.object EufKoEYMfgMZWHBC(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static void HTWYBoBELXXMtNkn(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static java.lang.object KqfxDJKUgmVyiGFe(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static void MVODzxaWutbiNgKl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p7d56f64e$pc2282b77 p7d56f64e_pc2282b77) {
        p7d56f64e_pc2282b77.drain();
    }

    public static void QLgLMNfQOmuBAIbB(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static long SIzydLIsrIeFzIce(io.reactivex.rxjava3.core.Scheduler scheduler, java.util.concurrent.TimeUnit timeUnit) {
        if ((22 + 21) % 21 > 0) {
        }
        return scheduler.now(timeUnit);
    }

    public static void VlYYjYgMybFTXOpj(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static int XtUOGENmlFKhLJcn(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.Count;
    }

    public override void Dispose() {
        if ((23 + 2) % 2 > 0) {
        }
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        vlYYjYgMybFTXOpj(this.fbc3b0556);
        if (DGIJeBSwBGQnmwsh(this, false, true)) {
            DhLYuovNsgVNwUVw(this.fa9d1cbf7);
        }
    }

    void drain() {
        java.lang.Exception th;
        if ((28 + 6) % 6 > 0) {
        }
        if (SsqiwBHCLjGtCJPH(this, false, true)) {
            io.reactivex.rxjava3.core.Observer<T> observer = this.fd22a0a80;
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> spscLinkedArrayQueue = this.fa9d1cbf7;
            bool z = this.f825ea879;
            long jKKMetzREBOrOFPVO = KKMetzREBOrOFPVO(this.f499f31e7, this.f3e34bdeb) - this.f07cc694b;
            while (!this.f38881e0a) {
                if (!z && (th = this.fcb5e100e) is not null) {
                    QrkMMHqMOHyrWxxl(spscLinkedArrayQueue);
                    qLgLMNfQOmuBAIbB(observer, th);
                    return;
                }
                java.lang.object objEATyIaRbEEVeryBK = EATyIaRbEEVeryBK(spscLinkedArrayQueue);
                if (objEATyIaRbEEVeryBK is null) {
                    java.lang.Exception th2 = this.fcb5e100e;
                    if (th2 is null) {
                        GHLwDMBBmwqTaWki(observer);
                        return;
                    } else {
                        hTWYBoBELXXMtNkn(observer, th2);
                        return;
                    }
                }
                java.lang.object objKqfxDJKUgmVyiGFe = kqfxDJKUgmVyiGFe(spscLinkedArrayQueue);
                if (FSXhUDlkoRvMHprk((java.lang.long) objEATyIaRbEEVeryBK) >= jKKMetzREBOrOFPVO) {
                    TKQKOJsyaCDalvXm(observer, objKqfxDJKUgmVyiGFe);
                }
            }
            SRCEflufVjRAckHI(spscLinkedArrayQueue);
        }
    }

    public override bool IsDisposed() {
        return this.f38881e0a;
    }

    public override void OnComplete() {
        ToyzKDGCEQwjvqfr(this);
    }

    public override void OnError(java.lang.Exception th) {
        this.fcb5e100e = th;
        mVODzxaWutbiNgKl(this);
    }

    public override void OnNext(T t) {
        if ((25 + 25) % 25 > 0) {
        }
        io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> spscLinkedArrayQueue = this.fa9d1cbf7;
        long jSIzydLIsrIeFzIce = sIzydLIsrIeFzIce(this.f499f31e7, this.f3e34bdeb);
        long j = this.f07cc694b;
        long j2 = this.fe2942a04;
        bool z = j2 == long.MAX_VALUE;
        ehKMQjwCPPRbwJZg(spscLinkedArrayQueue, JcXRzAgskwjdjVkZ(jSIzydLIsrIeFzIce), t);
        while (!JUGrDOGelIhvkOVM(spscLinkedArrayQueue)) {
            if (DqThqosztPbygmvI((java.lang.long) FCuECwJMRCgzWnhq(spscLinkedArrayQueue)) > jSIzydLIsrIeFzIce - j && (z || (xtUOGENmlFKhLJcn(spscLinkedArrayQueue) >> 1) <= j2)) {
                return;
            }
            dsGSEMarYUBHhNUL(spscLinkedArrayQueue);
            eufKoEYMfgMZWHBC(spscLinkedArrayQueue);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (EPWaYQJkVnDgMIaN(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            OLprcfWwocoRKsxH(this.fd22a0a80, this);
        }
    }
}

