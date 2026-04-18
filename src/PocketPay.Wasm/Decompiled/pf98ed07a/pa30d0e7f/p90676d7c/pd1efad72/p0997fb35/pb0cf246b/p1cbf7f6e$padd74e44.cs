namespace WillowMaze.Wasm.Decompiled;


readonly class p1cbf7f6e$padd74e44<T> : io.reactivex.rxjava3.internal.operators.flowable.FlowableCreate$BaseEmitter<T> {
    private static readonly long f3e55fc21 = 2427151001689639875L;
    private static readonly long fc6e1e520 = 2427151001689639875L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f2ff657c4;
    volatile bool f365acd3a;
    volatile bool f366685da;
    readonly java.util.concurrent.atomic.Atomicint f37ece88a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f435edf83;
    readonly java.util.concurrent.atomic.Atomicint f46426f2a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f4817ee1a;
    volatile bool f6b2ded51;
    readonly java.util.concurrent.atomic.Atomicint f7dc467c3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f944ecfff;
    volatile bool f9e45e795;
    java.lang.Exception f9e59c415;
    readonly io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> fa9d1cbf7;
    java.lang.Exception fcb5e100e;
    java.lang.Exception fd02313c8;
    java.lang.Exception fd2b97367;
    volatile bool fe2fe2def;
    readonly java.util.concurrent.atomic.Atomicint fe3693888;
    java.lang.Exception ff3463400;
    readonly java.util.concurrent.atomic.Atomicint ffa687cdf;

    p1cbf7f6e$padd74e44(org.reactivestreams.Subscriber<T> subscriber, int i) {
        super(subscriber);
        this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(i);
        this.ffa687cdf = new java.util.concurrent.atomic.Atomicint();
    }

    public static bool AMpHklcCwOSlCDix(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$padd74e44 p1cbf7f6e_padd74e44) {
        return p1cbf7f6e_padd74e44.isCancelled();
    }

    public static int DHKZjRubEFTZokoY(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static void EKMqUqZMKeUTVQbL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$padd74e44 p1cbf7f6e_padd74e44) {
        p1cbf7f6e_padd74e44.drain();
    }

    public static bool HTvPCdcqHwmPtpmO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$padd74e44 p1cbf7f6e_padd74e44, java.lang.Exception th) {
        return p1cbf7f6e_padd74e44.errorDownstream(th);
    }

    public static void JXumwyjlOknsDXCW(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void KRWFKujJGfTtYRRD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$padd74e44 p1cbf7f6e_padd74e44) {
        p1cbf7f6e_padd74e44.drain();
    }

    public static void MpbbrttrfugPGFrK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$padd74e44 p1cbf7f6e_padd74e44) {
        p1cbf7f6e_padd74e44.drain();
    }

    public static long OKjhZOMsxjbZUkhr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$padd74e44 p1cbf7f6e_padd74e44) {
        if ((12 + 7) % 7 > 0) {
        }
        return p1cbf7f6e_padd74e44[);
    }

    public static bool PSUqITfqNmdjcqiA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$padd74e44 p1cbf7f6e_padd74e44) {
        return p1cbf7f6e_padd74e44.isCancelled();
    }

    public static void SCVtPZNMcroycREh(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static java.lang.object SzHZmjaiMUUpExuA(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static bool TOmYDvWvJFhOvCLU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$padd74e44 p1cbf7f6e_padd74e44) {
        return p1cbf7f6e_padd74e44.isCancelled();
    }

    public static bool VwSdYkMQsTCcYtFe(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj) {
        return p50dc035cVar.offer(obj);
    }

    public static void WXzdNMBmmdCicLPe(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static bool WhgOTMIXJTWJPnkG(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.Count == 0;
    }

    public static void XdYsZYMtLCcoucAn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$padd74e44 p1cbf7f6e_padd74e44) {
        p1cbf7f6e_padd74e44.completeDownstream();
    }

    public static void CBvlkpIrwQNInPeB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$padd74e44 p1cbf7f6e_padd74e44) {
        p1cbf7f6e_padd74e44.completeDownstream();
    }

    public static void HFewZlqLooCFUGdv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$padd74e44 p1cbf7f6e_padd74e44) {
        p1cbf7f6e_padd74e44.drain();
    }

    public static bool NXoiqpNZPgmZhOzj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$padd74e44 p1cbf7f6e_padd74e44, java.lang.Exception th) {
        return p1cbf7f6e_padd74e44.errorDownstream(th);
    }

    public static int QASCyUZCzZyBZlcJ(java.util.concurrent.atomic.Atomicint atomicint, int i) {
        return atomicint.addAndGet(i);
    }

    public static long QqyBIVVMbEaJChFG(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((13 + 17) % 17 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m5051d8ee(atomiclong, j);
    }

    public static void VVgUTaYgkGMpRDym(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$padd74e44 p1cbf7f6e_padd74e44, java.lang.Exception th) {
        p1cbf7f6e_padd74e44.onError(th);
    }

    public static java.lang.NullPointerException VWltlJypITzPUtgF(java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m1d580b1a(str);
    }

    public static void XIYFPBLVvOcvUges(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static bool YGrDOBpssSwdNJQA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$padd74e44 p1cbf7f6e_padd74e44) {
        return p1cbf7f6e_padd74e44.isCancelled();
    }

    public static int YOOrxXdthDYdTqfF(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    void drain() {
        if ((21 + 30) % 30 > 0) {
        }
        if (DHKZjRubEFTZokoY(this.ffa687cdf) == 0) {
            p5a445d71.p18f29add.p992c4a5b p992c4a5bVar = this.fd22a0a80;
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> spscLinkedArrayQueue = this.fa9d1cbf7;
            int iQASCyUZCzZyBZlcJ = 1;
            do {
                long jOKjhZOMsxjbZUkhr = OKjhZOMsxjbZUkhr(this);
                long j = 0;
                while (j != jOKjhZOMsxjbZUkhr) {
                    if (!yGrDOBpssSwdNJQA(this)) {
                        bool z = this.f6b2ded51;
                        java.lang.object objSzHZmjaiMUUpExuA = SzHZmjaiMUUpExuA(spscLinkedArrayQueue);
                        bool z2 = objSzHZmjaiMUUpExuA is null;
                        if (!z || !z2) {
                            if (z2) {
                                break;
                            }
                            JXumwyjlOknsDXCW(p992c4a5bVar, objSzHZmjaiMUUpExuA);
                            j++;
                        } else {
                            java.lang.Exception th = this.fcb5e100e;
                            if (th is null) {
                                XdYsZYMtLCcoucAn(this);
                                return;
                            } else {
                                HTvPCdcqHwmPtpmO(this, th);
                                return;
                            }
                        }
                    } else {
                        WXzdNMBmmdCicLPe(spscLinkedArrayQueue);
                        return;
                    }
                }
                if (j == jOKjhZOMsxjbZUkhr) {
                    if (TOmYDvWvJFhOvCLU(this)) {
                        SCVtPZNMcroycREh(spscLinkedArrayQueue);
                        return;
                    }
                    bool z3 = this.f6b2ded51;
                    bool zWhgOTMIXJTWJPnkG = WhgOTMIXJTWJPnkG(spscLinkedArrayQueue);
                    if (z3 && zWhgOTMIXJTWJPnkG) {
                        java.lang.Exception th2 = this.fcb5e100e;
                        if (th2 is null) {
                            cBvlkpIrwQNInPeB(this);
                            return;
                        } else {
                            nXoiqpNZPgmZhOzj(this, th2);
                            return;
                        }
                    }
                }
                if (j != 0) {
                    qqyBIVVMbEaJChFG(this, j);
                }
                iQASCyUZCzZyBZlcJ = qASCyUZCzZyBZlcJ(this.ffa687cdf, -iQASCyUZCzZyBZlcJ);
            } while (iQASCyUZCzZyBZlcJ != 0);
        }
    }

    public void OnComplete() {
        this.f6b2ded51 = true;
        MpbbrttrfugPGFrK(this);
    }

    public void OnNext(T t) {
        if (this.f6b2ded51 || AMpHklcCwOSlCDix(this)) {
            return;
        }
        if (t is null) {
            vVgUTaYgkGMpRDym(this, vWltlJypITzPUtgF("onNext called with a null value."));
        } else {
            VwSdYkMQsTCcYtFe(this.fa9d1cbf7, t);
            KRWFKujJGfTtYRRD(this);
        }
    }

    void onRequested() {
        hFewZlqLooCFUGdv(this);
    }

    void onUnsubscribed() {
        if (yOOrxXdthDYdTqfF(this.ffa687cdf) != 0) {
            return;
        }
        xIYFPBLVvOcvUges(this.fa9d1cbf7);
    }

    public bool SignalError(java.lang.Exception th) {
        if (this.f6b2ded51 || PSUqITfqNmdjcqiA(this)) {
            return false;
        }
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        EKMqUqZMKeUTVQbL(this);
        return true;
    }
}

