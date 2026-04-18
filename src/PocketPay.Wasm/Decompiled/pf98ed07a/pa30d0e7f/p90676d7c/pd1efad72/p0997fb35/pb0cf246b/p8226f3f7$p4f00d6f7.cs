namespace WillowMaze.Wasm.Decompiled;


readonly class p8226f3f7$p4f00d6f7<T, C : java.util.ICollection<T>> : java.util.concurrent.atomic.Atomiclong : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf113d791 {
    private static readonly long f42c67cc7 = -7370244972039324525L;
    private static readonly long fc6e1e520 = -7370244972039324525L;
    readonly int f08b43519;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f0b76719d;
    readonly java.util.ArrayQueue f18a1b341;
    volatile bool f3469db8f;
    volatile bool f38881e0a;
    readonly java.util.concurrent.atomic.Atomicbool f40656e6e;
    readonly int f4677dca0;
    readonly io.reactivex.rxjava3.functions.Supplier<C> f4af2b822;
    long f5051d8ee;
    readonly p5a445d71.p18f29add.p992c4a5b f5fdc99ac;
    long f61c54d3a;
    readonly int f6554cd72;
    readonly p5a445d71.p18f29add.p992c4a5b f66dc5ee8;
    int f6a992d55;
    bool f6b2ded51;
    readonly p5a445d71.p18f29add.p992c4a5b f775a9a10;
    readonly java.util.concurrent.atomic.Atomicbool f7ba0606a;
    readonly int f7c2e8336;
    readonly java.util.ArrayQueue f88679915;
    int f895bae18;
    p5a445d71.p18f29add.p787ad0b7 f8ad81b1d;
    readonly java.util.concurrent.atomic.Atomicbool f9c830628;
    readonly int fa3d83a38;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fc1f466a0;
    volatile bool fc5ed33e3;
    readonly org.reactivestreams.Subscriber<C> fd22a0a80;
    readonly java.util.concurrent.atomic.Atomicbool fd2a74765;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fd3ec5adb;
    bool fdd8295c7;
    readonly java.util.ArrayQueue fe3139f44;
    long ff289b155;
    volatile bool ff54b43ac;
    readonly int ff7bd60b7;
    volatile bool ffc4d1ad9;
    long ffcd1c009;
    readonly int fff74b6d4;
    readonly java.util.concurrent.atomic.Atomicbool fe2eff6c2 = new java.util.concurrent.atomic.Atomicbool();
    readonly java.util.ArrayQueue<C> f4d293ef2 = new java.util.ArrayQueue<>();

    p8226f3f7$p4f00d6f7(org.reactivestreams.Subscriber<C> subscriber, int i, int i2, io.reactivex.rxjava3.functions.Supplier<C> supplier) {
        this.fd22a0a80 = subscriber;
        this.ff7bd60b7 = i;
        this.f08b43519 = i2;
        this.f4af2b822 = supplier;
    }

    public static void AhIYjRAEmtFLUbST(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void AhIYjRAEmtFLUbST(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AhIYjRAEmtFLUbST(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AhIYjRAEmtFLUbST(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AwWWSlhDgMVtjapi(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AwWWSlhDgMVtjapi(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AwWWSlhDgMVtjapi(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool AwWWSlhDgMVtjapi(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void BGsquxebHXbOegCo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8226f3f7$p4f00d6f7 p8226f3f7_p4f00d6f7) {
        p8226f3f7_p4f00d6f7.cancel();
    }

    public static void BGsquxebHXbOegCo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8226f3f7$p4f00d6f7 p8226f3f7_p4f00d6f7, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BGsquxebHXbOegCo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8226f3f7$p4f00d6f7 p8226f3f7_p4f00d6f7, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BGsquxebHXbOegCo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8226f3f7$p4f00d6f7 p8226f3f7_p4f00d6f7, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object BoqLAeDNpRbhEKwm(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.poll();
    }

    public static void BoqLAeDNpRbhEKwm(java.util.ArrayQueue arrayQueue, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BoqLAeDNpRbhEKwm(java.util.ArrayQueue arrayQueue, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BoqLAeDNpRbhEKwm(java.util.ArrayQueue arrayQueue, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CLQZLrwwkIicfyfc(java.util.ICollection collection, java.lang.object obj, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CLQZLrwwkIicfyfc(java.util.ICollection collection, java.lang.object obj, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CLQZLrwwkIicfyfc(java.util.ICollection collection, java.lang.object obj, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool CLQZLrwwkIicfyfc(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static java.lang.object DRTIepiscOMYyCor(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void DRTIepiscOMYyCor(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DRTIepiscOMYyCor(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DRTIepiscOMYyCor(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FjfvRdjJTEwUvJBn(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void FjfvRdjJTEwUvJBn(java.lang.object obj, java.lang.string str, float f, bool z, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FjfvRdjJTEwUvJBn(java.lang.object obj, java.lang.string str, int i, java.lang.string str2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FjfvRdjJTEwUvJBn(java.lang.object obj, java.lang.string str, java.lang.string str2, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static long FmanAxzTrxzBDsJc(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((25 + 1) % 1 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m5051d8ee(atomiclong, j);
    }

    public static void FmanAxzTrxzBDsJc(java.util.concurrent.atomic.Atomiclong atomiclong, long j, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FmanAxzTrxzBDsJc(java.util.concurrent.atomic.Atomiclong atomiclong, long j, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FmanAxzTrxzBDsJc(java.util.concurrent.atomic.Atomiclong atomiclong, long j, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FxHNQTjEkpjIXpcv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8226f3f7$p4f00d6f7 p8226f3f7_p4f00d6f7, java.lang.Exception th) {
        p8226f3f7_p4f00d6f7.onError(th);
    }

    public static void FxHNQTjEkpjIXpcv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8226f3f7$p4f00d6f7 p8226f3f7_p4f00d6f7, java.lang.Exception th, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FxHNQTjEkpjIXpcv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8226f3f7$p4f00d6f7 p8226f3f7_p4f00d6f7, java.lang.Exception th, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FxHNQTjEkpjIXpcv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p8226f3f7$p4f00d6f7 p8226f3f7_p4f00d6f7, java.lang.Exception th, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GZsGUSamGPMQEpXw(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void GZsGUSamGPMQEpXw(java.lang.Exception th, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GZsGUSamGPMQEpXw(java.lang.Exception th, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GZsGUSamGPMQEpXw(java.lang.Exception th, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HWgXIAymTJpTvaCF(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void HWgXIAymTJpTvaCF(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HWgXIAymTJpTvaCF(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HWgXIAymTJpTvaCF(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static long HbcuytLoTPChLxGT(long j, long j2) {
        if ((17 + 11) % 11 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.mc686a659(j, j2);
    }

    public static void HbcuytLoTPChLxGT(long j, long j2, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HbcuytLoTPChLxGT(long j, long j2, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HbcuytLoTPChLxGT(long j, long j2, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JamdDssyqitqmlBF(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void JamdDssyqitqmlBF(java.lang.Exception th, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JamdDssyqitqmlBF(java.lang.Exception th, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JamdDssyqitqmlBF(java.lang.Exception th, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LCRBjbcgdaFYcDEr(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void LCRBjbcgdaFYcDEr(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LCRBjbcgdaFYcDEr(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LCRBjbcgdaFYcDEr(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NfayiqeVNworoqPA(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void NfayiqeVNworoqPA(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NfayiqeVNworoqPA(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NfayiqeVNworoqPA(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OFCaMBZfzanFkCGB(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void OFCaMBZfzanFkCGB(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OFCaMBZfzanFkCGB(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OFCaMBZfzanFkCGB(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QPaCddrOmDxmcnJI(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.util.Queue queue, java.util.concurrent.atomic.Atomiclong atomiclong, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf113d791 pf113d791Var) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pae7f016b.m1c60d329(p992c4a5bVar, queue, atomiclong, pf113d791Var);
    }

    public static void QPaCddrOmDxmcnJI(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.util.Queue queue, java.util.concurrent.atomic.Atomiclong atomiclong, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf113d791 pf113d791Var, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QPaCddrOmDxmcnJI(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.util.Queue queue, java.util.concurrent.atomic.Atomiclong atomiclong, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf113d791 pf113d791Var, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QPaCddrOmDxmcnJI(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.util.Queue queue, java.util.concurrent.atomic.Atomiclong atomiclong, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf113d791 pf113d791Var, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RMhYiBMGRWGnZzzN(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void RMhYiBMGRWGnZzzN(java.util.IEnumerator it, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RMhYiBMGRWGnZzzN(java.util.IEnumerator it, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RMhYiBMGRWGnZzzN(java.util.IEnumerator it, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AnGxNriFAdsyNJPJ(java.util.ArrayQueue arrayQueue, java.lang.object obj, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AnGxNriFAdsyNJPJ(java.util.ArrayQueue arrayQueue, java.lang.object obj, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AnGxNriFAdsyNJPJ(java.util.ArrayQueue arrayQueue, java.lang.object obj, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool AnGxNriFAdsyNJPJ(java.util.ArrayQueue arrayQueue, java.lang.object obj) {
        return arrayQueue.offer(obj);
    }

    public static void CXvRDDqTuYTPdQzv(java.util.ICollection collection, java.lang.object obj, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CXvRDDqTuYTPdQzv(java.util.ICollection collection, java.lang.object obj, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CXvRDDqTuYTPdQzv(java.util.ICollection collection, java.lang.object obj, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool CXvRDDqTuYTPdQzv(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static java.lang.object DLoIxJgOqXfRwJCa(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.peek();
    }

    public static void DLoIxJgOqXfRwJCa(java.util.ArrayQueue arrayQueue, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DLoIxJgOqXfRwJCa(java.util.ArrayQueue arrayQueue, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DLoIxJgOqXfRwJCa(java.util.ArrayQueue arrayQueue, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int FVIWSSMrBzUeoWUO(java.util.ICollection collection) {
        return collection.Count;
    }

    public static void FVIWSSMrBzUeoWUO(java.util.ICollection collection, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FVIWSSMrBzUeoWUO(java.util.ICollection collection, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FVIWSSMrBzUeoWUO(java.util.ICollection collection, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GKQrtwcZxXNhNeYw(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2, float f, int i, bool z3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GKQrtwcZxXNhNeYw(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2, bool z3, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GKQrtwcZxXNhNeYw(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2, bool z3, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool GKQrtwcZxXNhNeYw(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static long KSPsyAkHhdwEZVXV(long j, long j2) {
        if ((25 + 7) % 7 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.me5bc883a(j, j2);
    }

    public static void KSPsyAkHhdwEZVXV(long j, long j2, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KSPsyAkHhdwEZVXV(long j, long j2, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KSPsyAkHhdwEZVXV(long j, long j2, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KoxjHGDCXVgMpORm(java.util.ArrayQueue arrayQueue) {
        arrayQueue.clear();
    }

    public static void KoxjHGDCXVgMpORm(java.util.ArrayQueue arrayQueue, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KoxjHGDCXVgMpORm(java.util.ArrayQueue arrayQueue, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KoxjHGDCXVgMpORm(java.util.ArrayQueue arrayQueue, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NLdxzqOFLASEsoCR(long j, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.util.Queue queue, java.util.concurrent.atomic.Atomiclong atomiclong, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf113d791 pf113d791Var, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NLdxzqOFLASEsoCR(long j, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.util.Queue queue, java.util.concurrent.atomic.Atomiclong atomiclong, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf113d791 pf113d791Var, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NLdxzqOFLASEsoCR(long j, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.util.Queue queue, java.util.concurrent.atomic.Atomiclong atomiclong, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf113d791 pf113d791Var, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool NLdxzqOFLASEsoCR(long j, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.util.Queue queue, java.util.concurrent.atomic.Atomiclong atomiclong, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf113d791 pf113d791Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pae7f016b.m01fc6c1d(j, p992c4a5bVar, queue, atomiclong, pf113d791Var);
    }

    public static java.util.IEnumerator RjUrEOuoNuUEUkdH(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.GetEnumerator();
    }

    public static void RjUrEOuoNuUEUkdH(java.util.ArrayQueue arrayQueue, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RjUrEOuoNuUEUkdH(java.util.ArrayQueue arrayQueue, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RjUrEOuoNuUEUkdH(java.util.ArrayQueue arrayQueue, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SUDzKldvinbOGRUl(long j, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SUDzKldvinbOGRUl(long j, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SUDzKldvinbOGRUl(long j, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool SUDzKldvinbOGRUl(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static void TJOpHBAvMOiWHZvF(java.util.IEnumerator it, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TJOpHBAvMOiWHZvF(java.util.IEnumerator it, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TJOpHBAvMOiWHZvF(java.util.IEnumerator it, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool TJOpHBAvMOiWHZvF(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static long WPwPeDypXkrCCQYx(long j, long j2) {
        if ((27 + 20) % 20 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.mc686a659(j, j2);
    }

    public static void WPwPeDypXkrCCQYx(long j, long j2, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WPwPeDypXkrCCQYx(long j, long j2, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WPwPeDypXkrCCQYx(long j, long j2, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WZJmphRwqRvajFBA(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void WZJmphRwqRvajFBA(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WZJmphRwqRvajFBA(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WZJmphRwqRvajFBA(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZmlrFjSPoRYmeFtr(java.util.concurrent.atomic.Atomicbool atomicbool, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZmlrFjSPoRYmeFtr(java.util.concurrent.atomic.Atomicbool atomicbool, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZmlrFjSPoRYmeFtr(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool ZmlrFjSPoRYmeFtr(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public override void Cancel() {
        this.f38881e0a = true;
        wZJmphRwqRvajFBA(this.fbc3b0556);
    }

    public override bool GetAsbool() {
        return this.f38881e0a;
    }

    public void OnComplete() {
        if ((2 + 7) % 7 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        long j = this.f5051d8ee;
        if (j != 0) {
            FmanAxzTrxzBDsJc(this, j);
        }
        QPaCddrOmDxmcnJI(this.fd22a0a80, this.f4d293ef2, this, this);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            GZsGUSamGPMQEpXw(th);
            return;
        }
        this.f6b2ded51 = true;
        koxjHGDCXVgMpORm(this.f4d293ef2);
        AhIYjRAEmtFLUbST(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        if ((8 + 11) % 11 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        java.util.ArrayQueue<C> arrayQueue = this.f4d293ef2;
        int i = this.f6a992d55;
        int i2 = i + 1;
        if (i == 0) {
            try {
                anGxNriFAdsyNJPJ(arrayQueue, (java.util.ICollection) FjfvRdjJTEwUvJBn(DRTIepiscOMYyCor(this.f4af2b822), "The bufferSupplier returned a null buffer"));
            } catch (java.lang.Exception th) {
                JamdDssyqitqmlBF(th);
                BGsquxebHXbOegCo(this);
                FxHNQTjEkpjIXpcv(this, th);
                return;
            }
        }
        java.util.ICollection collection = (java.util.ICollection) dLoIxJgOqXfRwJCa(arrayQueue);
        if (fVIWSSMrBzUeoWUO(collection) + 1 == this.ff7bd60b7) {
            BoqLAeDNpRbhEKwm(arrayQueue);
            cXvRDDqTuYTPdQzv(collection, t);
            this.f5051d8ee++;
            LCRBjbcgdaFYcDEr(this.fd22a0a80, collection);
        }
        java.util.IEnumerator itRjUrEOuoNuUEUkdH = rjUrEOuoNuUEUkdH(arrayQueue);
        while (tJOpHBAvMOiWHZvF(itRjUrEOuoNuUEUkdH)) {
            CLQZLrwwkIicfyfc((java.util.ICollection) RMhYiBMGRWGnZzzN(itRjUrEOuoNuUEUkdH), t);
        }
        if (i2 == this.f08b43519) {
            i2 = 0;
        }
        this.f6a992d55 = i2;
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (AwWWSlhDgMVtjapi(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            HWgXIAymTJpTvaCF(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        if ((28 + 5) % 5 > 0) {
        }
        if (sUDzKldvinbOGRUl(j) && !nLdxzqOFLASEsoCR(j, this.fd22a0a80, this.f4d293ef2, this, this)) {
            if (zmlrFjSPoRYmeFtr(this.fe2eff6c2) || !gKQrtwcZxXNhNeYw(this.fe2eff6c2, false, true)) {
                NfayiqeVNworoqPA(this.fbc3b0556, HbcuytLoTPChLxGT(this.f08b43519, j));
            } else {
                OFCaMBZfzanFkCGB(this.fbc3b0556, kSPsyAkHhdwEZVXV(this.ff7bd60b7, wPwPeDypXkrCCQYx(this.f08b43519, j - 1)));
            }
        }
    }
}

