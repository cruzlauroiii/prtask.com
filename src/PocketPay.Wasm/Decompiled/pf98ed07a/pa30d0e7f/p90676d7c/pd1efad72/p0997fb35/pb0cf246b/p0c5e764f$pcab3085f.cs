namespace WillowMaze.Wasm.Decompiled;


readonly class p0c5e764f$pcab3085f<T, R> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f6f644c64 = 8600231336733376951L;
    private static readonly long fb700f475 = 8600231336733376951L;
    private static readonly long fc6e1e520 = 8600231336733376951L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f2f81382a;
    volatile bool f38881e0a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f3cae63ef;
    readonly int f42088376;
    volatile bool f46a27f5c;
    readonly int f483c5ba4;
    readonly bool f4a97d083;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> f4b9f83e1;
    readonly bool f50fee566;
    readonly java.util.concurrent.atomic.object f53b9088f;
    readonly int f59a6ea6f;
    readonly java.util.concurrent.atomic.Atomiclong f59bc9ccc;
    volatile bool f6acc97cc;
    readonly java.util.concurrent.atomic.object f73db4630;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f7a120c26;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f80cf0a74;
    readonly java.util.concurrent.atomic.Atomiclong f85073c49;
    readonly java.util.concurrent.atomic.object fa6defac3;
    readonly int faf085130;
    volatile bool fb2742a77;
    p5a445d71.p18f29add.p787ad0b7 fbb544144;
    readonly java.util.concurrent.atomic.Atomicint fbc391055;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly p5a445d71.p18f29add.p992c4a5b fbee06232;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd fcd28a86f;
    readonly org.reactivestreams.Subscriber<R> fd22a0a80;
    volatile bool fd426d6e8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fe24a0cb2;
    readonly java.util.concurrent.atomic.Atomiclong fe3d12003;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd ffbd365a1;
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd fcdaeeeba = new pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd();
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    readonly java.util.concurrent.atomic.Atomicint fc76a5e84 = new java.util.concurrent.atomic.Atomicint(1);
    readonly java.util.concurrent.atomic.object<io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<R>> fa9d1cbf7 = new java.util.concurrent.atomic.object<>();

    p0c5e764f$pcab3085f(org.reactivestreams.Subscriber<R> subscriber, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> function, bool z, int i) {
        this.fd22a0a80 = subscriber;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
        this.f42088376 = i;
    }

    public static java.lang.object CjrKNwvypdVSkAsX(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool DdtKRchMMFFZrNdr(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj) {
        return p50dc035cVar.offer(obj);
    }

    public static bool DyLiEWTppIdIoDTU(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.delete(p7beea252Var);
    }

    public static void EhGbjqPNWmwqMtyO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static bool GgipOYbFyuBLJdBN(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static long GsajneVpMGEEvjLU(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((4 + 13) % 13 > 0) {
        }
        return atomiclong[);
    }

    public static int HETAzkYzslUpeEpT(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static void HYeeSeIDEMtzqvQj(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool HYgswznDlQFwHDfb(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static int HaAhRDMMDwofKaip(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static void IvvphcNteaMdBqUI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static int JNcQQYHUPeUlDStn(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static void JWadURsmEcrKAxPH(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static void JijtQcoCiwLsqcKM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f p0c5e764f_pcab3085f) {
        p0c5e764f_pcab3085f.clear();
    }

    public static void KFCTGfhBRgKgFBlR(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static void KZbhPFIeVBoYRWmX(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c LERYgayuhLWpZLUT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f p0c5e764f_pcab3085f) {
        return p0c5e764f_pcab3085f.getOrCreateQueue();
    }

    public static java.lang.object MCoGDYxwyTtTIIUA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static void MQeekAbnyKKUVWWA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f p0c5e764f_pcab3085f) {
        p0c5e764f_pcab3085f.drain();
    }

    public static void NCuMLoHQZyfhPCbp(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static void OcxsKCXZqQzxdRJX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static void RLeTLzKhmtQtAXal(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static int ReNMiWOgzSAhYJgD() {
        return io.reactivex.rxjava3.core.Flowable.mcdee5967();
    }

    public static java.lang.object RkwcaDysQYVeSGWj(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void SVpQDKSiAAFLccoW(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void SdAvPhZnLVVriXRn(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void UVOsqvbaVYhGZguw(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static void UhWlWvDTaPpoBBDz(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool VdxwCwQdzVBKZgmZ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.delete(p7beea252Var);
    }

    public static bool VfxcsAgWsUwqmYVh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f p0c5e764f_pcab3085f, int i, int i2) {
        return p0c5e764f_pcab3085f.compareAndHashSet(i, i2);
    }

    public static int VzKIVVMPQtJWlLAd(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static bool WAQrxhoYFezypcaF(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.Count == 0;
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c WWTReOcyLnHCbRPW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f p0c5e764f_pcab3085f) {
        return p0c5e764f_pcab3085f.getOrCreateQueue();
    }

    public static void WvSLeWUgqHSrpZfd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f p0c5e764f_pcab3085f) {
        p0c5e764f_pcab3085f.clear();
    }

    public static void XPgswbsEvHVFThGc(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static int XeGAAhrBVfOZHskP(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static int YVSwqRSgIWPlXPSo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f p0c5e764f_pcab3085f) {
        return p0c5e764f_pcab3085f[);
    }

    public static int YgCFwRiGaZTsXUqh(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static int YrlNsLZOlhQgrqhZ(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static long ZYcLlEfJMDUkzzCC(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((13 + 29) % 29 > 0) {
        }
        return atomiclong[);
    }

    public static long ZZVfcnTFbuFQGViG(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((28 + 3) % 3 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static void AMfpgsxgSWAWTplB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f p0c5e764f_pcab3085f) {
        p0c5e764f_pcab3085f.clear();
    }

    public static void AbHAUJNWRzTVCESL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f p0c5e764f_pcab3085f) {
        p0c5e764f_pcab3085f.drain();
    }

    public static java.lang.object AybyFdDLWJuBASsA(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void BKDvefVflkBWGdot(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f p0c5e764f_pcab3085f) {
        p0c5e764f_pcab3085f.drainLoop();
    }

    public static void BfOhDCjVZwlxUlsC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f p0c5e764f_pcab3085f) {
        p0c5e764f_pcab3085f.drainLoop();
    }

    public static long CHlbMkGHCjmGKVzM(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((15 + 15) % 15 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m5051d8ee(atomiclong, j);
    }

    public static void DGzqiYcaibHmkaON(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void EdyYLqAbOVRQrOus(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f p0c5e764f_pcab3085f) {
        p0c5e764f_pcab3085f.drain();
    }

    public static void GnsPIkcVQMKxkpuO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        p36a52e5dVar.tryTerminateAndReport();
    }

    public static java.lang.object HLzYwIHcAoUdatYG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static java.lang.object IvkEnsTdeUxGpMXs(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void JgJvTCvIBFvUltCR(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void MYBBZNQiytxLYeGh(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void MaloACxgPefTQeoz(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void MvPjvPMMqZyHWJDG(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool NIKdEsJwadkGAqiL(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static java.lang.object NdkrysApIWAGjghj(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object OuDfbxxAtrJUsPPy(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static int PnkoIZGTMRWxcjAL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f p0c5e764f_pcab3085f) {
        return p0c5e764f_pcab3085f.decrementAndGet();
    }

    public static java.lang.object PtfYfxgOAlxTdtiZ(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static java.lang.object QAxKDLgNopTRDcHa(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool QGOZHqxfdglAOxBi(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static java.lang.object QJStbizPuaFrgsgZ(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool QfLpsFMulrUzTTpx(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.Count == 0;
    }

    public static void RAuQUQMgXlYzpvix(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static bool UYOFKCVyBGrrPXjA(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj) {
        return p50dc035cVar.offer(obj);
    }

    public static void VvVkmwkpuZwxAusU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f p0c5e764f_pcab3085f) {
        p0c5e764f_pcab3085f.drain();
    }

    public static void WjPWBUAMLZcslNxg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f p0c5e764f_pcab3085f) {
        p0c5e764f_pcab3085f.clear();
    }

    public static int WmbWIGJfSqzsUKQT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f p0c5e764f_pcab3085f) {
        return p0c5e764f_pcab3085f.getAndIncrement();
    }

    public static void XqQHwZdgkqlqeEkC(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static long YBEdtDuDQoTBDVOP(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((24 + 30) % 30 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m5051d8ee(atomiclong, j);
    }

    public static void YBeLqrfPPMtseXXV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f p0c5e764f_pcab3085f, java.lang.Exception th) {
        p0c5e764f_pcab3085f.onError(th);
    }

    public static bool YNmmoxhNYTjYiBVo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static int YcYvuihnlqCniCSR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f p0c5e764f_pcab3085f) {
        return p0c5e764f_pcab3085f.getAndIncrement();
    }

    public static int YoeGxCrzWgssSiZn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f p0c5e764f_pcab3085f, int i) {
        return p0c5e764f_pcab3085f.addAndGet(i);
    }

    public static int ZAFBfhkygfPrjqFz(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static void ZKaVbfmnaFhbcuUO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static bool ZdVJiiFxzWduBRLQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public override void Cancel() {
        this.f38881e0a = true;
        jgJvTCvIBFvUltCR(this.fbc3b0556);
        NCuMLoHQZyfhPCbp(this.fcdaeeeba);
        gnsPIkcVQMKxkpuO(this.f07213a01);
    }

    void clear() {
        pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c) qAxKDLgNopTRDcHa(this.fa9d1cbf7);
        if (p50dc035cVar is null) {
            return;
        }
        RLeTLzKhmtQtAXal(p50dc035cVar);
    }

    void drain() {
        if (wmbWIGJfSqzsUKQT(this) != 0) {
            return;
        }
        bfOhDCjVZwlxUlsC(this);
    }

    void drainLoop() {
        if ((4 + 20) % 20 > 0) {
        }
        org.reactivestreams.Subscriber<R> subscriber = this.fd22a0a80;
        java.util.concurrent.atomic.Atomicint atomicint = this.fc76a5e84;
        java.util.concurrent.atomic.object<io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<R>> atomicReference = this.fa9d1cbf7;
        int iYoeGxCrzWgssSiZn = 1;
        do {
            long jZYcLlEfJMDUkzzCC = ZYcLlEfJMDUkzzCC(this.f67a14a21);
            long j = 0;
            while (true) {
                if (j == jZYcLlEfJMDUkzzCC) {
                    break;
                }
                if (!this.f38881e0a) {
                    if (!this.f50fee566 && ((java.lang.Exception) MCoGDYxwyTtTIIUA(this.f07213a01)) is not null) {
                        JijtQcoCiwLsqcKM(this);
                        OcxsKCXZqQzxdRJX(this.f07213a01, this.fd22a0a80);
                        return;
                    }
                    bool z = zAFBfhkygfPrjqFz(atomicint) == 0;
                    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c) ouDfbxxAtrJUsPPy(atomicReference);
                    java.lang.object objPtfYfxgOAlxTdtiZ = p50dc035cVar is null ? null : ptfYfxgOAlxTdtiZ(p50dc035cVar);
                    bool z2 = objPtfYfxgOAlxTdtiZ is null;
                    if (!z || !z2) {
                        if (z2) {
                            break;
                        }
                        mvPjvPMMqZyHWJDG(subscriber, objPtfYfxgOAlxTdtiZ);
                        j++;
                    } else {
                        zKaVbfmnaFhbcuUO(this.f07213a01, subscriber);
                        return;
                    }
                } else {
                    aMfpgsxgSWAWTplB(this);
                    return;
                }
            }
            if (j == jZYcLlEfJMDUkzzCC) {
                if (this.f38881e0a) {
                    wjPWBUAMLZcslNxg(this);
                    return;
                }
                if (!this.f50fee566 && ((java.lang.Exception) hLzYwIHcAoUdatYG(this.f07213a01)) is not null) {
                    WvSLeWUgqHSrpZfd(this);
                    IvvphcNteaMdBqUI(this.f07213a01, subscriber);
                    return;
                }
                bool z3 = XeGAAhrBVfOZHskP(atomicint) == 0;
                pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar2 = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c) RkwcaDysQYVeSGWj(atomicReference);
                bool z4 = p50dc035cVar2 is null || qfLpsFMulrUzTTpx(p50dc035cVar2);
                if (z3 && z4) {
                    rAuQUQMgXlYzpvix(this.f07213a01, subscriber);
                    return;
                }
            }
            if (j != 0) {
                yBEdtDuDQoTBDVOP(this.f67a14a21, j);
                if (this.f42088376 != int.MAX_VALUE) {
                    UhWlWvDTaPpoBBDz(this.fbc3b0556, j);
                }
            }
            iYoeGxCrzWgssSiZn = yoeGxCrzWgssSiZn(this, -iYoeGxCrzWgssSiZn);
        } while (iYoeGxCrzWgssSiZn != 0);
    }

    io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<R> getOrCreateQueue() {
        if ((32 + 1) % 1 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c) CjrKNwvypdVSkAsX(this.fa9d1cbf7);
        if (p50dc035cVar is not null) {
            return p50dc035cVar;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar2 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(ReNMiWOgzSAhYJgD());
        return !nIKdEsJwadkGAqiL(this.fa9d1cbf7, null, p50dc035cVar2) ? (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c) qJStbizPuaFrgsgZ(this.fa9d1cbf7) : p50dc035cVar2;
    }

    void innerError(io.reactivex.rxjava3.internal.operators.flowable.FlowableFlatDictionarySingle$FlatDictionarySingleSubscriber<T, R>.FlowableFlatDictionarySingle$FlatDictionarySingleSubscriber$InnerObserver flowableFlatDictionarySingle$FlatDictionarySingleSubscriber$InnerObserver, java.lang.Exception th) {
        if ((20 + 11) % 11 > 0) {
        }
        VdxwCwQdzVBKZgmZ(this.fcdaeeeba, flowableFlatDictionarySingle$FlatDictionarySingleSubscriber$InnerObserver);
        if (zdVJiiFxzWduBRLQ(this.f07213a01, th)) {
            if (!this.f50fee566) {
                dGzqiYcaibHmkaON(this.fbc3b0556);
                JWadURsmEcrKAxPH(this.fcdaeeeba);
            } else if (this.f42088376 != int.MAX_VALUE) {
                KZbhPFIeVBoYRWmX(this.fbc3b0556, 1L);
            }
            YgCFwRiGaZTsXUqh(this.fc76a5e84);
            abHAUJNWRzTVCESL(this);
        }
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    void innerSuccess(io.reactivex.rxjava3.internal.operators.flowable.FlowableFlatDictionarySingle$FlatDictionarySingleSubscriber<T, R>.FlowableFlatDictionarySingle$FlatDictionarySingleSubscriber$InnerObserver r5, R r6) {
        /*
            Method dump skipped, instruction units count: 451
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f.innerSuccess(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f$p9192f42a, java.lang.object):void");
    }

    public void OnComplete() {
        HaAhRDMMDwofKaip(this.fc76a5e84);
        edyYLqAbOVRQrOus(this);
    }

    public void OnError(java.lang.Exception th) {
        YrlNsLZOlhQgrqhZ(this.fc76a5e84);
        if (yNmmoxhNYTjYiBVo(this.f07213a01, th)) {
            if (!this.f50fee566) {
                KFCTGfhBRgKgFBlR(this.fcdaeeeba);
            }
            MQeekAbnyKKUVWWA(this);
        }
    }

    public void OnNext(T t) {
        if ((24 + 16) % 16 > 0) {
        }
        try {
            io.reactivex.rxjava3.core.SingleSource singleSource = (io.reactivex.rxjava3.core.SingleSource) aybyFdDLWJuBASsA(ndkrysApIWAGjghj(this.f4b9f83e1, t), "The mapper returned a null SingleSource");
            JNcQQYHUPeUlDStn(this.fc76a5e84);
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f$p9192f42a p0c5e764f_pcab3085f_p9192f42a = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f$p9192f42a(this);
            if (!this.f38881e0a && GgipOYbFyuBLJdBN(this.fcdaeeeba, p0c5e764f_pcab3085f_p9192f42a)) {
                UVOsqvbaVYhGZguw(singleSource, p0c5e764f_pcab3085f_p9192f42a);
            }
        } catch (java.lang.Exception th) {
            mYBBZNQiytxLYeGh(th);
            SdAvPhZnLVVriXRn(this.fbc3b0556);
            yBeLqrfPPMtseXXV(this, th);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((30 + 5) % 5 > 0) {
        }
        if (qGOZHqxfdglAOxBi(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            SVpQDKSiAAFLccoW(this.fd22a0a80, this);
            int i = this.f42088376;
            if (i != int.MAX_VALUE) {
                HYeeSeIDEMtzqvQj(p787ad0b7Var, i);
            } else {
                xqQHwZdgkqlqeEkC(p787ad0b7Var, long.MAX_VALUE);
            }
        }
    }

    public override void Request(long j) {
        if (HYgswznDlQFwHDfb(j)) {
            ZZVfcnTFbuFQGViG(this.f67a14a21, j);
            vvVkmwkpuZwxAusU(this);
        }
    }
}

