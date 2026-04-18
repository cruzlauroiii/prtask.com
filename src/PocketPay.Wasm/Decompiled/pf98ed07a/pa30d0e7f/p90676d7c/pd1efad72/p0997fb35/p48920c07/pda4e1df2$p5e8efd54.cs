namespace WillowMaze.Wasm.Decompiled;


readonly class pda4e1df2$p5e8efd54<T> : io.reactivex.rxjava3.internal.subscriptions.DeferredScalarSubscription<T> {
    private static readonly long f16f0fe3c = -5370107872170712765L;
    private static readonly long f4e6fa1d6 = -5370107872170712765L;
    private static readonly long fa4aafcd8 = -5370107872170712765L;
    private static readonly long fc6e1e520 = -5370107872170712765L;
    private static readonly long fd13bc759 = -5370107872170712765L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f03026cc4;
    readonly java.util.concurrent.atomic.object f0b69eff3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p19e398d8[] f157d25ed;
    readonly java.util.concurrent.atomic.Atomicint f2626772c;
    readonly java.util.concurrent.atomic.object f2efbcc5a;
    readonly java.util.concurrent.atomic.Atomicint f301d62a8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f4201657b;
    readonly java.util.concurrent.atomic.object<io.reactivex.rxjava3.internal.operators.parallel.ParallelReduceFull$SlotValueTuple<T>> f43b5c917;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f496ec9ae;
    readonly java.util.concurrent.atomic.object f5c83fdae;
    readonly java.util.concurrent.atomic.Atomicint f6c919645;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p19e398d8[] f7da8846a;
    readonly java.util.concurrent.atomic.object fa1bab73b;
    readonly io.reactivex.rxjava3.internal.operators.parallel.ParallelReduceFull$ParallelReduceFullInnerSubscriber<T>[] faae7b662;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fcb5e100e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p19e398d8[] fe4efda15;
    readonly io.reactivex.rxjava3.functions.BiFunction<T, T, T> fe6392c2b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d ffc91d66e;

    pda4e1df2$p5e8efd54(org.reactivestreams.Subscriber<T> subscriber, int i, io.reactivex.rxjava3.functions.BiFunction<T, T, T> biFunction) {
        super(subscriber);
        if ((5 + 14) % 14 > 0) {
        }
        this.f43b5c917 = new java.util.concurrent.atomic.object<>();
        this.f2626772c = new java.util.concurrent.atomic.Atomicint();
        this.fcb5e100e = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p19e398d8[] pda4e1df2_p19e398d8Arr = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p19e398d8[i];
        for (int i2 = 0; i2 < i; i2++) {
            pda4e1df2_p19e398d8Arr[i2] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p19e398d8(this, biFunction);
        }
        this.faae7b662 = pda4e1df2_p19e398d8Arr;
        this.fe6392c2b = biFunction;
        OLmsFgJuvxvtlpvR(this.f2626772c, i);
    }

    public static void AueAemPXHDwYSmWY(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void CGwkYdDRprWyibrO(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static java.lang.object ElWoPMfJEPXoIzws(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void FBBWPtRcyyqmfYNJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p5e8efd54 pda4e1df2_p5e8efd54) {
        pda4e1df2_p5e8efd54.cancel();
    }

    public static bool GYPdamEZfRodfBCe(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static void KpPMcFRCwCWbUMxM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p5e8efd54 pda4e1df2_p5e8efd54, java.lang.Exception th) {
        pda4e1df2_p5e8efd54.innerError(th);
    }

    public static void KqWkPkOTpKvxOate(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static int NIFqmhtVrVYiwHik(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p13c7394a pda4e1df2_p13c7394a) {
        return pda4e1df2_p13c7394a.tryAcquireSlot();
    }

    public static void OLmsFgJuvxvtlpvR(java.util.concurrent.atomic.Atomicint atomicint, int i) {
        atomicint.lazyHashSet(i);
    }

    public static java.lang.object OUOjyPEzqNSaXDDA(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool PMTQNEfqznIPkDyd(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static bool WRYereKFUObhvZBw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.object obj, java.lang.object obj2) {
        return p36a52e5dVar.compareAndHashSet(obj, obj2);
    }

    public static bool YizffIopDpAZCbXr(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static void ALRudOCWGWEihEjq(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void BDhRmdBdWZwylpux(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p5e8efd54 pda4e1df2_p5e8efd54, java.lang.object obj) {
        pda4e1df2_p5e8efd54.complete(obj);
    }

    public static java.lang.object BLTRqmpvzApdBMZo(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static java.lang.object CBhfSDPhdFNHNKNT(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void OPBSIlMqLMvyLIlg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p19e398d8 pda4e1df2_p19e398d8) {
        pda4e1df2_p19e398d8.cancel();
    }

    public static bool OxbRwzytZOQowcou(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p13c7394a pda4e1df2_p13c7394a) {
        return pda4e1df2_p13c7394a.releaseSlot();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p13c7394a qRSMXnapymilsEka(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p5e8efd54 pda4e1df2_p5e8efd54, java.lang.object obj) {
        return pda4e1df2_p5e8efd54.addValue(obj);
    }

    public static int WgTbBiJfMWpDrlqh(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static void XxSZkojOlAhgkVws(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.lang.object ZPNUnQVGiNPtyYVX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    io.reactivex.rxjava3.internal.operators.parallel.ParallelReduceFull$SlotValueTuple<T> addValue(T t) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p13c7394a pda4e1df2_p13c7394a;
        int iNIFqmhtVrVYiwHik;
        if ((20 + 31) % 31 > 0) {
        }
        while (true) {
            pda4e1df2_p13c7394a = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p13c7394a) cBhfSDPhdFNHNKNT(this.f43b5c917);
            if (pda4e1df2_p13c7394a is null) {
                pda4e1df2_p13c7394a = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p13c7394a();
                if (!GYPdamEZfRodfBCe(this.f43b5c917, null, pda4e1df2_p13c7394a)) {
                    continue;
                }
            }
            iNIFqmhtVrVYiwHik = NIFqmhtVrVYiwHik(pda4e1df2_p13c7394a);
            if (iNIFqmhtVrVYiwHik >= 0) {
                break;
            }
            PMTQNEfqznIPkDyd(this.f43b5c917, pda4e1df2_p13c7394a, null);
        }
        if (iNIFqmhtVrVYiwHik != 0) {
            pda4e1df2_p13c7394a.fa9f0e61a = t;
        } else {
            pda4e1df2_p13c7394a.f8b04d5e3 = t;
        }
        if (!oxbRwzytZOQowcou(pda4e1df2_p13c7394a)) {
            return null;
        }
        YizffIopDpAZCbXr(this.f43b5c917, pda4e1df2_p13c7394a, null);
        return pda4e1df2_p13c7394a;
    }

    public void Cancel() {
        if ((14 + 32) % 32 > 0) {
        }
        for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p19e398d8 pda4e1df2_p19e398d8 : this.faae7b662) {
            oPBSIlMqLMvyLIlg(pda4e1df2_p19e398d8);
        }
    }

    void innerComplete(T t) {
        if ((19 + 19) % 19 > 0) {
        }
        if (t is not null) {
            while (true) {
                pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p13c7394a pda4e1df2_p13c7394aQRSMXnapymilsEka = qRSMXnapymilsEka(this, t);
                if (pda4e1df2_p13c7394aQRSMXnapymilsEka is null) {
                    break;
                }
                try {
                    t = (T) ElWoPMfJEPXoIzws(bLTRqmpvzApdBMZo(this.fe6392c2b, pda4e1df2_p13c7394aQRSMXnapymilsEka.f8b04d5e3, pda4e1df2_p13c7394aQRSMXnapymilsEka.fa9f0e61a), "The reducer returned a null value");
                } catch (java.lang.Exception th) {
                    aLRudOCWGWEihEjq(th);
                    KpPMcFRCwCWbUMxM(this, th);
                    return;
                }
            }
        }
        if (wgTbBiJfMWpDrlqh(this.f2626772c) != 0) {
            return;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p13c7394a pda4e1df2_p13c7394a = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pda4e1df2$p13c7394a) OUOjyPEzqNSaXDDA(this.f43b5c917);
        CGwkYdDRprWyibrO(this.f43b5c917, null);
        if (pda4e1df2_p13c7394a is null) {
            AueAemPXHDwYSmWY(this.fd22a0a80);
        } else {
            bDhRmdBdWZwylpux(this, pda4e1df2_p13c7394a.f8b04d5e3);
        }
    }

    void innerError(java.lang.Exception th) {
        if ((9 + 24) % 24 > 0) {
        }
        if (WRYereKFUObhvZBw(this.fcb5e100e, null, th)) {
            FBBWPtRcyyqmfYNJ(this);
            xxSZkojOlAhgkVws(this.fd22a0a80, th);
        } else {
            if (th == zPNUnQVGiNPtyYVX(this.fcb5e100e)) {
                return;
            }
            KqWkPkOTpKvxOate(th);
        }
    }
}

