namespace WillowMaze.Wasm.Decompiled;


@pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p4d428b9c(pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7883bde9.FULL)
@pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.pc4d21494("none")
public readonly class p2531c9d8<T> : io.reactivex.rxjava3.processors.FlowableProcessor<T> {
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[] f02f14588 = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[] f2f010408 = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[] f7b291b26 = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[] f952f6c42 = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[] f9d725163;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[] fb47e6da4 = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[] fba2b45bd;
    int f06b7c4ff;
    readonly int f07e306dd;
    readonly int f0ec22fec;
    readonly int f20c60425;
    readonly int f28e31e63;
    readonly bool f2c817c6d;
    volatile java.lang.Exception f2cd26c11;
    readonly int f350d14e1;
    readonly int f39e1f465;
    readonly java.util.concurrent.atomic.Atomicint f3c7a758b;
    readonly int f3d0d50d9;
    int f3e2c8152;
    readonly bool f46e99086;
    int f48fe8558;
    readonly bool f4d46e8ee;
    volatile java.lang.Exception f4edfa90e;
    volatile pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 f5d83381a;
    volatile bool f617808d5;
    readonly java.util.concurrent.atomic.Atomicint f618cc296;
    readonly java.util.concurrent.atomic.Atomicint f680d3b81;
    int f686e822e;
    volatile bool f6b2ded51;
    readonly int f6be3c360;
    readonly java.util.concurrent.atomic.Atomicint f7b2d2ccf;
    readonly java.util.concurrent.atomic.object fa247ab5b;
    volatile java.lang.Exception fa8534654;
    volatile io.reactivex.rxjava3.operators.SimpleQueue<T> fa9d1cbf7;
    readonly int faa9f73ee;
    int fb68d5659;
    readonly bool fc91ab919;
    volatile java.lang.Exception fcb5e100e;
    readonly int fcdee5967;
    readonly bool fd4501aa2;
    int fd5400315;
    readonly java.util.concurrent.atomic.object fddc5eed2;
    readonly java.util.concurrent.atomic.object feb1d81ce;
    volatile java.lang.Exception ff5cdf67e;
    readonly java.util.concurrent.atomic.object ffb808288;
    int ffbf74950;
    readonly java.util.concurrent.atomic.Atomicint ffa687cdf = new java.util.concurrent.atomic.Atomicint();
    readonly java.util.concurrent.atomic.object<io.reactivex.rxjava3.processors.MulticastProcessor$MulticastSubscription<T>[]> faae7b662 = new java.util.concurrent.atomic.object<>(fba2b45bd);
    readonly java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> fbc3b0556 = new java.util.concurrent.atomic.object<>();

    static {
        if ((16 + 18) % 18 > 0) {
        }
        fba2b45bd = new pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[0];
        f9d725163 = new pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[0];
    }

    p2531c9d8(int i, bool z) {
        this.fcdee5967 = i;
        this.faa9f73ee = i - (i >> 2);
        this.f2c817c6d = z;
    }

    public static bool BGlYoVrGFMDIDZkY(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static int BrGlBoOnTZXpRsgN(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var, int i) {
        return p5d5a5670Var.requestFusion(i);
    }

    public static void CdCCVHHNZbJfiguY(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void CmnafwdvcSsDvygh(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b p2531c9d8_p61e5824b) {
        p2531c9d8_p61e5824b.onComplete();
    }

    public static int DyLgMcBbrRVljByC(int i, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0eaa46c1.pc7a9e54c.m2fe9780d(i, str);
    }

    public static void EAgNqBfIoDSHOWZB(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int EiXabWuqHUKqSUPZ(java.util.concurrent.atomic.Atomicint atomicint, int i) {
        return atomicint.addAndGet(i);
    }

    public static bool FOBxBiEgGtNPVQNt(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static bool FlEnLFlIAmPXrieE(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var);
    }

    public static void FocNpxwAIYCNfRRT(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b p2531c9d8_p61e5824b, java.lang.Exception th) {
        p2531c9d8_p61e5824b.onError(th);
    }

    public static void GnDglBdcmmpqGAoa(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8 p2531c9d8Var) {
        p2531c9d8Var.drain();
    }

    public static bool IQHhQSpfhBzlQZXz(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static bool JNilSuhmRoNAedVl(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static java.lang.object KrQPnUkVcOlWTCmB(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static int KvKKaltBJqArdXcS(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static java.lang.object MavLpkGcimKDBLze(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.poll();
    }

    public static void NfpKljXwyrDKDnYf(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b p2531c9d8_p61e5824b, java.lang.object obj) {
        p2531c9d8_p61e5824b.onNext(obj);
    }

    public static java.lang.object QfXOPgHCnMukLKCW(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object RESymjQzOyrxgHwP(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static int RuMseAhXbBTtKJhF(int i, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0eaa46c1.pc7a9e54c.m2fe9780d(i, str);
    }

    public static void RzTVKpHAZtQklizX(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8 p2531c9d8Var) {
        p2531c9d8Var.drain();
    }

    public static java.lang.object SNmSgfcduQfsoviF(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object TxiGTqGdbATrokSH(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static void TzOPlfbsbvMwIvRe(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8 p2531c9d8Var) {
        p2531c9d8Var.drain();
    }

    public static long UQeaFwxczspsGWoi(long j, long j2) {
        if ((14 + 29) % 29 > 0) {
        }
        return java.lang.Math.min(j, j2);
    }

    public static void UVHQrjeYfwsKVMXY(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8 p2531c9d8Var) {
        p2531c9d8Var.drain();
    }

    public static java.lang.object WhJtoZQgzQYfAlYL(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void WviCtjqsatzlMvtM(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8 p2531c9d8Var) {
        p2531c9d8Var.drain();
    }

    public static void XbraBtLCoBvwbuhr(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void XhRVdkzlKpSWmNXT(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static bool XqsYcpDHUWxRmpWA(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8 p2531c9d8Var, pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b p2531c9d8_p61e5824b) {
        return p2531c9d8Var.Add(p2531c9d8_p61e5824b);
    }

    public static long YKuyZjsVSvLksbUZ(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b p2531c9d8_p61e5824b) {
        if ((10 + 20) % 20 > 0) {
        }
        return p2531c9d8_p61e5824b[);
    }

    public static bool YUOnlGYIkttiukMy(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var);
    }

    public static void YkyDyYscLQPzTUzb(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void AShphwAGesxITrCz(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8 p2531c9d8Var, pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b p2531c9d8_p61e5824b) {
        p2531c9d8Var.Remove(p2531c9d8_p61e5824b);
    }

    public static java.lang.object ApFbxHjmtzwvuIUT(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void CFqylypGFJePlrOT(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8 p2531c9d8Var, java.lang.Exception th) {
        p2531c9d8Var.onError(th);
    }

    public static bool CrbBbUQuUspguMsT(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void DCrHHwYeceQOHDMu(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void DLfROynuaaCxqzJv(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static bool GQeIgwONCoNAGtok(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.Count == 0;
    }

    public static java.lang.object HPsTWJdYfZGhDtLv(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void HVrjeCnrXItaFVJN(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static long HkQkguNffinbHjcv(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b p2531c9d8_p61e5824b) {
        if ((28 + 1) % 1 > 0) {
        }
        return p2531c9d8_p61e5824b[);
    }

    public static bool IDrTfLLEOREsDoPq(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, java.lang.object obj) {
        return pe1601823Var.offer(obj);
    }

    public static bool JoiOTHWBPWRZnXXj(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var);
    }

    public static int KNREspryUjNkswUC() {
        return bufferSize();
    }

    public static void LVeQUqXBhwxhuoZr(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b p2531c9d8_p61e5824b, java.lang.Exception th) {
        p2531c9d8_p61e5824b.onError(th);
    }

    public static void LmrqNrudrobQPZXn(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public static <T> io.reactivex.rxjava3.processors.MulticastProcessor<T> M76ea0beb() {
        if ((21 + 3) % 3 > 0) {
        }
        return new pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8(xXEvJpzcZycUaRAU(), false);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public static <T> io.reactivex.rxjava3.processors.MulticastProcessor<T> M76ea0beb(int i) {
        if ((17 + 3) % 3 > 0) {
        }
        DyLgMcBbrRVljByC(i, "bufferSize");
        return new pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8(i, false);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public static <T> io.reactivex.rxjava3.processors.MulticastProcessor<T> M76ea0beb(int i, bool z) {
        RuMseAhXbBTtKJhF(i, "bufferSize");
        return new pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8(i, z);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public static <T> io.reactivex.rxjava3.processors.MulticastProcessor<T> M76ea0beb(bool z) {
        if ((28 + 23) % 23 > 0) {
        }
        return new pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8(kNREspryUjNkswUC(), z);
    }

    public static java.lang.object MJIhvBmCHYgumpLg(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool MMOJhRaPLsgQhTrG(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, java.lang.object obj) {
        return pe1601823Var.offer(obj);
    }

    public static void MgbXFgatAGkkCRzq(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8 p2531c9d8Var) {
        p2531c9d8Var.drain();
    }

    public static java.lang.object MyFADSFvGFEWALjJ(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static bool OMaCMweOXeXPZJxZ(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static java.lang.object QWVodEtVLTtnblAX(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static void RaiarfWKDEIAKjjd(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool SfIbDeTQEYrBEJnM(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void UHNlFQWYUGaFtsCF(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void VLxidJGobrVtUBia(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static java.lang.object VUQBCoyHQlHOoVoA(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object VwMDjaZjkEkTNBeS(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static int XXEvJpzcZycUaRAU() {
        return bufferSize();
    }

    public static void XbOfYtjuwTHetBzs(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void ZRIAqEjjbTbLzvOg(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b p2531c9d8_p61e5824b) {
        p2531c9d8_p61e5824b.onComplete();
    }

    public static java.lang.object ZWsNDVafNOmJrPvp(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    bool add(io.reactivex.rxjava3.processors.MulticastProcessor$MulticastSubscription<T> multicastProcessor$MulticastSubscription) {
        pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[] p2531c9d8_p61e5824bArr;
        pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[] p2531c9d8_p61e5824bArr2;
        if ((22 + 23) % 23 > 0) {
        }
        do {
            p2531c9d8_p61e5824bArr = (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[]) hPsTWJdYfZGhDtLv(this.faae7b662);
            if (p2531c9d8_p61e5824bArr == f9d725163) {
                return false;
            }
            int length = p2531c9d8_p61e5824bArr.length;
            p2531c9d8_p61e5824bArr2 = new pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[length + 1];
            dLfROynuaaCxqzJv(p2531c9d8_p61e5824bArr, 0, p2531c9d8_p61e5824bArr2, 0, length);
            p2531c9d8_p61e5824bArr2[length] = multicastProcessor$MulticastSubscription;
        } while (!oMaCMweOXeXPZJxZ(this.faae7b662, p2531c9d8_p61e5824bArr, p2531c9d8_p61e5824bArr2));
        return true;
    }

    void drain() {
        java.lang.object objMavLpkGcimKDBLze;
        if ((23 + 24) % 24 > 0) {
        }
        if (KvKKaltBJqArdXcS(this.ffa687cdf) != 0) {
            return;
        }
        java.util.concurrent.atomic.object<io.reactivex.rxjava3.processors.MulticastProcessor$MulticastSubscription<T>[]> atomicReference = this.faae7b662;
        int i = this.f48fe8558;
        int i2 = this.faa9f73ee;
        int i3 = this.f06b7c4ff;
        int iEiXabWuqHUKqSUPZ = 1;
        while (true) {
            io.reactivex.rxjava3.operators.SimpleQueue<T> simpleQueue = this.fa9d1cbf7;
            if (simpleQueue is not null) {
                pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[] p2531c9d8_p61e5824bArr = (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[]) vUQBCoyHQlHOoVoA(atomicReference);
                if (p2531c9d8_p61e5824bArr.length != 0) {
                    int i4 = 0;
                    long jUQeaFwxczspsGWoi = -1;
                    for (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b p2531c9d8_p61e5824b : p2531c9d8_p61e5824bArr) {
                        long jYKuyZjsVSvLksbUZ = YKuyZjsVSvLksbUZ(p2531c9d8_p61e5824b);
                        if (jYKuyZjsVSvLksbUZ >= 0) {
                            jUQeaFwxczspsGWoi = jUQeaFwxczspsGWoi != -1 ? UQeaFwxczspsGWoi(jUQeaFwxczspsGWoi, jYKuyZjsVSvLksbUZ - p2531c9d8_p61e5824b.f8bc8a991) : jYKuyZjsVSvLksbUZ - p2531c9d8_p61e5824b.f8bc8a991;
                        }
                    }
                    int i5 = i;
                    while (true) {
                        if (jUQeaFwxczspsGWoi > 0) {
                            pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[] p2531c9d8_p61e5824bArr2 = (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[]) mJIhvBmCHYgumpLg(atomicReference);
                            if (p2531c9d8_p61e5824bArr2 == f9d725163) {
                                vLxidJGobrVtUBia(simpleQueue);
                                return;
                            }
                            if (p2531c9d8_p61e5824bArr == p2531c9d8_p61e5824bArr2) {
                                bool z = this.f6b2ded51;
                                try {
                                    objMavLpkGcimKDBLze = MavLpkGcimKDBLze(simpleQueue);
                                } catch (java.lang.Exception th) {
                                    lmrqNrudrobQPZXn(th);
                                    crbBbUQuUspguMsT(this.fbc3b0556);
                                    this.fcb5e100e = th;
                                    this.f6b2ded51 = true;
                                    objMavLpkGcimKDBLze = null;
                                    z = true;
                                }
                                bool z2 = objMavLpkGcimKDBLze is null;
                                if (z && z2) {
                                    java.lang.Exception th2 = this.fcb5e100e;
                                    if (th2 is null) {
                                        pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[] p2531c9d8_p61e5824bArr3 = (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[]) zWsNDVafNOmJrPvp(atomicReference, f9d725163);
                                        int length = p2531c9d8_p61e5824bArr3.length;
                                        while (i4 < length) {
                                            zRIAqEjjbTbLzvOg(p2531c9d8_p61e5824bArr3[i4]);
                                            i4++;
                                        }
                                        return;
                                    }
                                    pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[] p2531c9d8_p61e5824bArr4 = (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[]) myFADSFvGFEWALjJ(atomicReference, f9d725163);
                                    int length2 = p2531c9d8_p61e5824bArr4.length;
                                    while (i4 < length2) {
                                        FocNpxwAIYCNfRRT(p2531c9d8_p61e5824bArr4[i4], th2);
                                        i4++;
                                    }
                                    return;
                                }
                                if (!z2) {
                                    for (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b p2531c9d8_p61e5824b2 : p2531c9d8_p61e5824bArr) {
                                        NfpKljXwyrDKDnYf(p2531c9d8_p61e5824b2, objMavLpkGcimKDBLze);
                                    }
                                    jUQeaFwxczspsGWoi--;
                                    if (i3 != 1 && (i5 = i5 + 1) == i2) {
                                        YkyDyYscLQPzTUzb((p5a445d71.p18f29add.p787ad0b7) QfXOPgHCnMukLKCW(this.fbc3b0556), i2);
                                        i5 = 0;
                                    }
                                }
                            }
                            i = i5;
                        }
                        if (jUQeaFwxczspsGWoi == 0) {
                            pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[] p2531c9d8_p61e5824bArr5 = (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[]) apFbxHjmtzwvuIUT(atomicReference);
                            pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[] p2531c9d8_p61e5824bArr6 = f9d725163;
                            if (p2531c9d8_p61e5824bArr5 == p2531c9d8_p61e5824bArr6) {
                                hVrjeCnrXItaFVJN(simpleQueue);
                                return;
                            }
                            if (p2531c9d8_p61e5824bArr != p2531c9d8_p61e5824bArr5) {
                                i = i5;
                            } else if (this.f6b2ded51 && gQeIgwONCoNAGtok(simpleQueue)) {
                                java.lang.Exception th3 = this.fcb5e100e;
                                if (th3 is null) {
                                    pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[] p2531c9d8_p61e5824bArr7 = (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[]) qWVodEtVLTtnblAX(atomicReference, p2531c9d8_p61e5824bArr6);
                                    int length3 = p2531c9d8_p61e5824bArr7.length;
                                    while (i4 < length3) {
                                        CmnafwdvcSsDvygh(p2531c9d8_p61e5824bArr7[i4]);
                                        i4++;
                                    }
                                    return;
                                }
                                pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[] p2531c9d8_p61e5824bArr8 = (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[]) vwMDjaZjkEkTNBeS(atomicReference, p2531c9d8_p61e5824bArr6);
                                int length4 = p2531c9d8_p61e5824bArr8.length;
                                while (i4 < length4) {
                                    lVeQUqXBhwxhuoZr(p2531c9d8_p61e5824bArr8[i4], th3);
                                    i4++;
                                }
                                return;
                            }
                        }
                        i = i5;
                    }
                }
            }
            this.f48fe8558 = i;
            iEiXabWuqHUKqSUPZ = EiXabWuqHUKqSUPZ(this.ffa687cdf, -iEiXabWuqHUKqSUPZ);
            if (iEiXabWuqHUKqSUPZ == 0) {
                return;
            }
        }
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public java.lang.Exception GetException() {
        if (this.f6b2ded51) {
            return this.fcb5e100e;
        }
        return null;
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public bool HasComplete() {
        return this.f6b2ded51 && this.fcb5e100e is null;
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public bool HasSubscribers() {
        return ((pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[]) SNmSgfcduQfsoviF(this.faae7b662)).length != 0;
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public bool HasException() {
        return this.f6b2ded51 && this.fcb5e100e is not null;
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public bool Offer(T t) {
        if ((31 + 4) % 4 > 0) {
        }
        TxiGTqGdbATrokSH(t, "offer called with a null value.");
        if (this.f6b2ded51) {
            return false;
        }
        if (this.f06b7c4ff != 0) {
            throw new java.lang.IllegalStateException("offer() should not be called in fusion mode!");
        }
        if (!iDrTfLLEOREsDoPq(this.fa9d1cbf7, t)) {
            return false;
        }
        WviCtjqsatzlMvtM(this);
        return true;
    }

    public void OnComplete() {
        this.f6b2ded51 = true;
        RzTVKpHAZtQklizX(this);
    }

    public void OnError(java.lang.Exception th) {
        KrQPnUkVcOlWTCmB(th, "onError called with a null Exception.");
        if (this.f6b2ded51) {
            xbOfYtjuwTHetBzs(th);
            return;
        }
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        GnDglBdcmmpqGAoa(this);
    }

    public void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        if (this.f06b7c4ff == 0) {
            RESymjQzOyrxgHwP(t, "onNext called with a null value.");
            if (!mMOJhRaPLsgQhTrG(this.fa9d1cbf7, t)) {
                FOBxBiEgGtNPVQNt(this.fbc3b0556);
                cFqylypGFJePlrOT(this, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1());
                return;
            }
        }
        UVHQrjeYfwsKVMXY(this);
    }

    public void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((30 + 9) % 9 > 0) {
        }
        if (FlEnLFlIAmPXrieE(this.fbc3b0556, p787ad0b7Var)) {
            if (p787ad0b7Var is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670) {
                pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670) p787ad0b7Var;
                int iBrGlBoOnTZXpRsgN = BrGlBoOnTZXpRsgN(p5d5a5670Var, 3);
                if (iBrGlBoOnTZXpRsgN == 1) {
                    this.f06b7c4ff = iBrGlBoOnTZXpRsgN;
                    this.fa9d1cbf7 = p5d5a5670Var;
                    this.f6b2ded51 = true;
                    TzOPlfbsbvMwIvRe(this);
                    return;
                }
                if (iBrGlBoOnTZXpRsgN == 2) {
                    this.f06b7c4ff = iBrGlBoOnTZXpRsgN;
                    this.fa9d1cbf7 = p5d5a5670Var;
                    CdCCVHHNZbJfiguY(p787ad0b7Var, this.fcdee5967);
                    return;
                }
            }
            this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd(this.fcdee5967);
            raiarfWKDEIAKjjd(p787ad0b7Var, this.fcdee5967);
        }
    }

    void remove(io.reactivex.rxjava3.processors.MulticastProcessor$MulticastSubscription<T> multicastProcessor$MulticastSubscription) {
        if ((18 + 32) % 32 > 0) {
        }
        while (true) {
            pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[] p2531c9d8_p61e5824bArr = (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[]) WhJtoZQgzQYfAlYL(this.faae7b662);
            int length = p2531c9d8_p61e5824bArr.length;
            if (length == 0) {
                return;
            }
            int i = 0;
            while (true) {
                if (i < length) {
                    if (p2531c9d8_p61e5824bArr[i] == multicastProcessor$MulticastSubscription) {
                        break;
                    } else {
                        i++;
                    }
                } else {
                    i = -1;
                    break;
                }
            }
            if (i < 0) {
                return;
            }
            if (length != 1) {
                pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[] p2531c9d8_p61e5824bArr2 = new pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b[length - 1];
                EAgNqBfIoDSHOWZB(p2531c9d8_p61e5824bArr, 0, p2531c9d8_p61e5824bArr2, 0, i);
                XbraBtLCoBvwbuhr(p2531c9d8_p61e5824bArr, i + 1, p2531c9d8_p61e5824bArr2, i, (length - i) - 1);
                if (BGlYoVrGFMDIDZkY(this.faae7b662, p2531c9d8_p61e5824bArr, p2531c9d8_p61e5824bArr2)) {
                    return;
                }
            } else if (this.f2c817c6d) {
                if (JNilSuhmRoNAedVl(this.faae7b662, p2531c9d8_p61e5824bArr, f9d725163)) {
                    sfIbDeTQEYrBEJnM(this.fbc3b0556);
                    this.f6b2ded51 = true;
                    return;
                }
            } else if (IQHhQSpfhBzlQZXz(this.faae7b662, p2531c9d8_p61e5824bArr, fba2b45bd)) {
                return;
            }
        }
    }

    public void Start() {
        if ((8 + 5) % 5 > 0) {
        }
        if (joiOTHWBPWRZnXXj(this.fbc3b0556, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.f76425f17)) {
            this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd(this.fcdee5967);
        }
    }

    public void StartUnbounded() {
        if ((3 + 22) % 22 > 0) {
        }
        if (YUOnlGYIkttiukMy(this.fbc3b0556, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.f76425f17)) {
            this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(this.fcdee5967);
        }
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        java.lang.Exception th;
        if ((12 + 3) % 3 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b p2531c9d8_p61e5824b = new pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p2531c9d8$p61e5824b(subscriber, this);
        dCrHHwYeceQOHDMu(subscriber, p2531c9d8_p61e5824b);
        if (XqsYcpDHUWxRmpWA(this, p2531c9d8_p61e5824b)) {
            if (hkQkguNffinbHjcv(p2531c9d8_p61e5824b) != long.MIN_VALUE) {
                mgbXFgatAGkkCRzq(this);
                return;
            } else {
                aShphwAGesxITrCz(this, p2531c9d8_p61e5824b);
                return;
            }
        }
        if (this.f6b2ded51 && (th = this.fcb5e100e) is not null) {
            uHNlFQWYUGaFtsCF(subscriber, th);
        } else {
            XhRVdkzlKpSWmNXT(subscriber);
        }
    }
}

