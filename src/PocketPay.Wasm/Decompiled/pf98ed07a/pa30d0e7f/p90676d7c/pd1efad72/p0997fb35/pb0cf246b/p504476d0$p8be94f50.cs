namespace WillowMaze.Wasm.Decompiled;


readonly class p504476d0$p8be94f50<TLeft, TRight, TLeftEnd, TRightEnd, R> : java.util.concurrent.atomic.Atomicint : p5a445d71.p18f29add.p787ad0b7, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pebedbfbf {
    static readonly java.lang.int f0e1626b3 = null;
    static readonly java.lang.int f2bd6d144 = null;
    private static readonly long f2c476a0a = -6071216598687999801L;
    static readonly java.lang.int f323865ba = null;
    static readonly java.lang.int f3246f53d = null;
    static readonly java.lang.int f5675fbd2 = null;
    static readonly java.lang.int f5fdb90e9 = null;
    static readonly java.lang.int f655b4470 = null;
    static readonly java.lang.int f79d693aa = null;
    static readonly java.lang.int f81a4076b = null;
    private static readonly long fb55cccef = -6071216598687999801L;
    static readonly java.lang.int fb99914d0 = null;
    static readonly java.lang.int fbe0d4174 = null;
    static readonly java.lang.int fc62d7181 = null;
    private static readonly long fc6e1e520 = -6071216598687999801L;
    static readonly java.lang.int fd82e1142 = null;
    int f0b99258f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f19754092;
    readonly p5a445d71.p18f29add.p992c4a5b f1eead99f;
    readonly java.util.Dictionary f1fdb06a4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f2781b13c;
    readonly io.reactivex.rxjava3.functions.Function<? super TRight, ? : org.reactivestreams.Publisher<TRightEnd>> f2fbf087c;
    readonly java.util.concurrent.atomic.object f34ff7cf2;
    volatile bool f38881e0a;
    readonly io.reactivex.rxjava3.functions.Function<? super TLeft, ? : org.reactivestreams.Publisher<TLeftEnd>> f412d0c77;
    int f415e97ed;
    volatile bool f45d497cd;
    readonly java.util.Dictionary f4668ee4c;
    readonly java.util.Dictionary f4f02f8db;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f5321d57f;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super TLeft, ? super TRight, ? : R> f63de7122;
    int f7be3eaf5;
    int f852bb169;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f8a066bf4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f9304583f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f9f678c5c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f9f8eeaeb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c fa87cb1bc;
    readonly java.util.concurrent.atomic.Atomicint fbb8527dc;
    volatile bool fc396b4de;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc41830af;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fc44d0fce;
    readonly java.util.concurrent.atomic.Atomicint fc54f90da;
    readonly java.util.Dictionary fc9a654a3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc9cfecce;
    int fd0aa9e46;
    readonly org.reactivestreams.Subscriber<R> fd22a0a80;
    readonly java.util.concurrent.atomic.Atomiclong fd4dd9a81;
    readonly p5a445d71.p18f29add.p992c4a5b fdcb51f30;
    readonly java.util.concurrent.atomic.object fe1221f85;
    volatile bool fe208dedf;
    int fedc10311;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba ff76c3a6c;
    readonly java.util.Dictionary ff9d088de;
    readonly java.util.concurrent.atomic.Atomiclong ffc2d510f;
    static readonly java.lang.int f323b32a7 = WLqjyeTUxmANvBzh(1);
    static readonly java.lang.int f651af744 = VbglHRYqMDFpcBaM(2);
    static readonly java.lang.int f65f10819 = bNyUdeNcVsSzwiQs(3);
    static readonly java.lang.int fd902d608 = vFFqVyhTvroXpWQu(4);
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f52905679 = new pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd();
    readonly io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(WipLXtsKIEHbVWeJ());
    readonly java.util.Dictionary<java.lang.int, TLeft> f42c5db7a = new java.util.LinkedHashDictionary();
    readonly java.util.Dictionary<java.lang.int, TRight> f27b37152 = new java.util.LinkedHashDictionary();
    readonly java.util.concurrent.atomic.object<java.lang.Exception> fcb5e100e = new java.util.concurrent.atomic.object<>();
    readonly java.util.concurrent.atomic.Atomicint fc76a5e84 = new java.util.concurrent.atomic.Atomicint(2);

    p504476d0$p8be94f50(org.reactivestreams.Subscriber<R> subscriber, io.reactivex.rxjava3.functions.Function<? super TLeft, ? : org.reactivestreams.Publisher<TLeftEnd>> function, io.reactivex.rxjava3.functions.Function<? super TRight, ? : org.reactivestreams.Publisher<TRightEnd>> function2, io.reactivex.rxjava3.functions.BiFunction<? super TLeft, ? super TRight, ? : R> biFunction) {
        this.fd22a0a80 = subscriber;
        this.f412d0c77 = function;
        this.f2fbf087c = function2;
        this.f63de7122 = biFunction;
    }

    public static java.lang.object AgKpKXYIbhbWKKdH(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object AtilSBDNiCBFEtPG(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void AuMnxWePantOisFb(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void BAvMJrdtbiXnhrOO(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static bool BKTDuhicMsXQFkHA(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static long BrOiFrmytICyvKMy(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((20 + 18) % 18 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m5051d8ee(atomiclong, j);
    }

    public static bool BtLFGZjXviCLBaef(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Remove(p7beea252Var);
    }

    public static void CABfodNteOtcydCG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50) {
        p504476d0_p8be94f50.drain();
    }

    public static void CTJSyoqbCZfqRZDS(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void CeQuAuFQaytTiaCj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50) {
        p504476d0_p8be94f50.drain();
    }

    public static void CoWeMNjJSjRrBvkq(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static bool CsuztXogpEElbLeU(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.delete(p7beea252Var);
    }

    public static void FWvrVSAYAvBLFeqX(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static java.lang.object GNnCQqHCSBmdiBbz(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object GNwOHGuoPVqCXLIj(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static bool GUwKyTiQgRjgCZbP(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static void GbTTVcGsOWvaFllI(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static bool GdQAEqpYUrvUdkKC(java.util.concurrent.atomic.object atomicReference, java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m9373b63a(atomicReference, th);
    }

    public static int GnDdpuFWbAmGfvGF(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static void GsJMNCoZJYXdndPQ(java.util.Dictionary map) {
        map.clear();
    }

    public static void HOQkeVJoZffJmUtI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p504476d0_p8be94f50.errorAll(p992c4a5bVar);
    }

    public static java.util.IEnumerator HRHTGjBnDfRnKAQD(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static void HRmwVnPTiCbGymmT(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static java.lang.object ISTyepozDnQqlvwf(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static java.lang.object IkJkfENTCtxJTUTb(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object JkCdGfpKcSAjAZcc(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static void JxhCFWrAjfEDVVDA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50) {
        p504476d0_p8be94f50.cancelAll();
    }

    public static int MHrgEyDMsqOpHGJb(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static void MrZCUpztFPMibSiF(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void NJjuQkqQNZGgvSeY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50, java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        p504476d0_p8be94f50.fail(th, p992c4a5bVar, pe1601823Var);
    }

    public static java.lang.object OefgkIxcEMlnZIvq(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void OkpWHIrAvQRCVqiU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50) {
        p504476d0_p8be94f50.drain();
    }

    public static java.lang.object RvGKuKtdBrxEncyT(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static bool SMJHtcWubeQPoiMZ(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj, java.lang.object obj2) {
        return p50dc035cVar.offer(obj, obj2);
    }

    public static void SXCztBzqHteWGNfz(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void TExdpNINoGYpwqXa(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void TPkifOZJwjOlhziM(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static int TUHzLppWElxRuPkt(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static bool TXcGlGCxhLPxexTl(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static void UXTDGwWjdjJZdVfs(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void UlDSFopTaxtyvcFw(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static java.lang.int VbglHRYqMDFpcBaM(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void VjAkWbNHKsXkRDtO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50) {
        p504476d0_p8be94f50.cancelAll();
    }

    public static java.lang.object VqWLoPvgSQoRezgc(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.int WLqjyeTUxmANvBzh(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object WZrjfXmBGfgZuNxC(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static int WipLXtsKIEHbVWeJ() {
        return io.reactivex.rxjava3.core.Flowable.mcdee5967();
    }

    public static bool XHncCcMFVfBwsYGX(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void XSEkzMlyRIGIZhGb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50) {
        p504476d0_p8be94f50.cancelAll();
    }

    public static java.lang.int XXyZAFJUPXXwslWE(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.util.ICollection XiECvwqzmoLcNQdJ(java.util.Dictionary map) {
        return map.Values;
    }

    public static bool YNECSxYjzfSHdGVs(java.util.concurrent.atomic.object atomicReference, java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m9373b63a(atomicReference, th);
    }

    public static void YUDSCkZcUYnvUymU(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static java.lang.object YjVdCEjNbDrDewUH(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.int ZMLcVSDxWGFDUlNB(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void ALhNuBspqNCdhnQC(java.util.Dictionary map) {
        map.clear();
    }

    public static java.lang.int BNyUdeNcVsSzwiQs(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void BPSyyQjXlGMaaeYA(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static void CqNfQjyBnUkyczPh(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void DKXlChrlmWruPCZf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50) {
        p504476d0_p8be94f50.drain();
    }

    public static bool EFhlxxDZapQMcemd(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj, java.lang.object obj2) {
        return p50dc035cVar.offer(obj, obj2);
    }

    public static long ElNzPUNqrolOPgnk(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((7 + 17) % 17 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static void GRjgUJXrFAntEmCJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50) {
        p504476d0_p8be94f50.cancelAll();
    }

    public static void GVDXZLGCcQPLBgKM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p504476d0_p8be94f50.errorAll(p992c4a5bVar);
    }

    public static java.lang.object GpkmiJhNneNexoUn(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool GsDYgdmskQnhNqxm(java.util.concurrent.atomic.object atomicReference, java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m9373b63a(atomicReference, th);
    }

    public static java.lang.object GzuumstEpOVMDSjh(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static int HkmnlJSszHQzxVXs(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50) {
        return p504476d0_p8be94f50.getAndIncrement();
    }

    public static bool HouGeUgCzceoBDwf(java.util.concurrent.atomic.object atomicReference, java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m9373b63a(atomicReference, th);
    }

    public static long HyuTNnHxlTUZuuTN(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((14 + 1) % 1 > 0) {
        }
        return atomiclong[);
    }

    public static bool JOAtYuEKianRMXHQ(java.util.concurrent.atomic.object atomicReference, java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m9373b63a(atomicReference, th);
    }

    public static void JgGdjqSctGbsgwEj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50, java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        p504476d0_p8be94f50.fail(th, p992c4a5bVar, pe1601823Var);
    }

    public static void KFDdEdbTPJzspNWt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50, java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        p504476d0_p8be94f50.fail(th, p992c4a5bVar, pe1601823Var);
    }

    public static void KINUoOBaYfDJeGiK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50) {
        p504476d0_p8be94f50.drain();
    }

    public static java.lang.int LRjICsedLfViNsSH(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object LbeoYSockivdzaIS(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void OewogZLEOvOCVZbu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p504476d0_p8be94f50.errorAll(p992c4a5bVar);
    }

    public static void PbTKVNxzCOPrcBaO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50) {
        p504476d0_p8be94f50.cancelAll();
    }

    public static void QTWZPqxwbXFilkSh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p504476d0_p8be94f50.errorAll(p992c4a5bVar);
    }

    public static long QwUGDJaQhASrmLwD(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((32 + 19) % 19 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m5051d8ee(atomiclong, j);
    }

    public static java.lang.int RpvalVumdoHebMsl(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void RzyFrloUAioKOtEy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50) {
        p504476d0_p8be94f50.cancelAll();
    }

    public static void SjSWBaSuTPBjYNan(java.util.Dictionary map) {
        map.clear();
    }

    public static java.lang.object SxzBtsvUrHqHxotV(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void TEwScLwDlXQxIMNM(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.util.IEnumerator TOahqwSIXoUXXGYV(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static void TSahXwAPwWtnyHnO(java.util.Dictionary map) {
        map.clear();
    }

    public static bool TbBMwyuTMJDbXYCC(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static java.util.ICollection TtrzVcVFYHUlHsfj(java.util.Dictionary map) {
        return map.Values;
    }

    public static java.lang.Exception UAnSPzqFJwzIDHGT(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m1459e53d(atomicReference);
    }

    public static java.lang.object UOmjDfQutAZuqIJK(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.int VFFqVyhTvroXpWQu(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool VgxuuufggUxwtywR(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Remove(p7beea252Var);
    }

    public static void VvyrkDgtRSNyjGEX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50, java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        p504476d0_p8be94f50.fail(th, p992c4a5bVar, pe1601823Var);
    }

    public static void WGGegFkDxXWocgzM(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static int WeJxtBvOyTZkERUo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50) {
        return p504476d0_p8be94f50.getAndIncrement();
    }

    public static void WujGTgtfcaiMHGon(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void WzReBcftxuyXzTOf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50) {
        p504476d0_p8be94f50.cancelAll();
    }

    public static java.lang.object XYTdUZAhqxUDSxeO(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static void XfSltjTPrOAiXFTG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p504476d0_p8be94f50.errorAll(p992c4a5bVar);
    }

    public static int YChfSukxeppCfykz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50, int i) {
        return p504476d0_p8be94f50.addAndGet(i);
    }

    public static java.lang.object YZAYurgqSMSVpNxf(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void ZKpHodoubAqfFvbS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50 p504476d0_p8be94f50, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p504476d0_p8be94f50.errorAll(p992c4a5bVar);
    }

    public static long ZugkeZUJpTqAReEK(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((2 + 32) % 32 > 0) {
        }
        return atomiclong[);
    }

    public override void Cancel() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        gRjgUJXrFAntEmCJ(this);
        if (weJxtBvOyTZkERUo(this) != 0) {
            return;
        }
        YUDSCkZcUYnvUymU(this.fa9d1cbf7);
    }

    void cancelAll() {
        wGGegFkDxXWocgzM(this.f52905679);
    }

    void drain() {
        if ((29 + 28) % 28 > 0) {
        }
        if (hkmnlJSszHQzxVXs(this) == 0) {
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> spscLinkedArrayQueue = this.fa9d1cbf7;
            org.reactivestreams.Subscriber<R> subscriber = this.fd22a0a80;
            bool z = true;
            int iYChfSukxeppCfykz = 1;
            while (!this.f38881e0a) {
                if (((java.lang.Exception) OefgkIxcEMlnZIvq(this.fcb5e100e)) is not null) {
                    CoWeMNjJSjRrBvkq(spscLinkedArrayQueue);
                    rzyFrloUAioKOtEy(this);
                    oewogZLEOvOCVZbu(this, subscriber);
                    return;
                }
                bool z2 = TUHzLppWElxRuPkt(this.fc76a5e84) != 0 ? false : z;
                java.lang.int num = (java.lang.int) JkCdGfpKcSAjAZcc(spscLinkedArrayQueue);
                bool z3 = num is not null ? false : z;
                if (z2 && z3) {
                    aLhNuBspqNCdhnQC(this.f42c5db7a);
                    GsJMNCoZJYXdndPQ(this.f27b37152);
                    bPSyyQjXlGMaaeYA(this.f52905679);
                    cqNfQjyBnUkyczPh(subscriber);
                    return;
                }
                if (z3) {
                    iYChfSukxeppCfykz = yChfSukxeppCfykz(this, -iYChfSukxeppCfykz);
                    if (iYChfSukxeppCfykz == 0) {
                        return;
                    }
                } else {
                    java.lang.object objGzuumstEpOVMDSjh = gzuumstEpOVMDSjh(spscLinkedArrayQueue);
                    if (num == f323b32a7) {
                        int i = this.fedc10311;
                        this.fedc10311 = i + 1;
                        AtilSBDNiCBFEtPG(this.f42c5db7a, XXyZAFJUPXXwslWE(i), objGzuumstEpOVMDSjh);
                        try {
                            p5a445d71.p18f29add.p32c73be0 p32c73be0Var = (p5a445d71.p18f29add.p32c73be0) yZAYurgqSMSVpNxf(lbeoYSockivdzaIS(this.f412d0c77, objGzuumstEpOVMDSjh), "The leftEnd returned a null Publisher");
                            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110 pafdeb810_pf62ac110 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110(this, z, i);
                            GUwKyTiQgRjgCZbP(this.f52905679, pafdeb810_pf62ac110);
                            HRmwVnPTiCbGymmT(p32c73be0Var, pafdeb810_pf62ac110);
                            if (((java.lang.Exception) VqWLoPvgSQoRezgc(this.fcb5e100e)) is not null) {
                                UlDSFopTaxtyvcFw(spscLinkedArrayQueue);
                                VjAkWbNHKsXkRDtO(this);
                                qTWZPqxwbXFilkSh(this, subscriber);
                                return;
                            }
                            long jHyuTNnHxlTUZuuTN = hyuTNnHxlTUZuuTN(this.f67a14a21);
                            java.util.IEnumerator itTOahqwSIXoUXXGYV = tOahqwSIXoUXXGYV(XiECvwqzmoLcNQdJ(this.f27b37152));
                            long j = 0;
                            while (XHncCcMFVfBwsYGX(itTOahqwSIXoUXXGYV)) {
                                try {
                                    java.lang.object objIkJkfENTCtxJTUTb = IkJkfENTCtxJTUTb(ISTyepozDnQqlvwf(this.f63de7122, objGzuumstEpOVMDSjh, gpkmiJhNneNexoUn(itTOahqwSIXoUXXGYV)), "The resultSelector returned a null value");
                                    if (j == jHyuTNnHxlTUZuuTN) {
                                        houGeUgCzceoBDwf(this.fcb5e100e, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1("Could not emit value due to lack of requests"));
                                        TExdpNINoGYpwqXa(spscLinkedArrayQueue);
                                        wzReBcftxuyXzTOf(this);
                                        gVDXZLGCcQPLBgKM(this, subscriber);
                                        return;
                                    }
                                    UXTDGwWjdjJZdVfs(subscriber, objIkJkfENTCtxJTUTb);
                                    j++;
                                } catch (java.lang.Exception th) {
                                    jgGdjqSctGbsgwEj(this, th, subscriber, spscLinkedArrayQueue);
                                    return;
                                }
                            }
                            if (j != 0) {
                                BrOiFrmytICyvKMy(this.f67a14a21, j);
                            }
                        } catch (java.lang.Exception th2) {
                            NJjuQkqQNZGgvSeY(this, th2, subscriber, spscLinkedArrayQueue);
                            return;
                        }
                    } else if (num == f651af744) {
                        int i2 = this.f415e97ed;
                        this.f415e97ed = i2 + 1;
                        sxzBtsvUrHqHxotV(this.f27b37152, rpvalVumdoHebMsl(i2), objGzuumstEpOVMDSjh);
                        try {
                            p5a445d71.p18f29add.p32c73be0 p32c73be0Var2 = (p5a445d71.p18f29add.p32c73be0) YjVdCEjNbDrDewUH(GNnCQqHCSBmdiBbz(this.f2fbf087c, objGzuumstEpOVMDSjh), "The rightEnd returned a null Publisher");
                            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110 pafdeb810_pf62ac1102 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110(this, false, i2);
                            tbBMwyuTMJDbXYCC(this.f52905679, pafdeb810_pf62ac1102);
                            BAvMJrdtbiXnhrOO(p32c73be0Var2, pafdeb810_pf62ac1102);
                            if (((java.lang.Exception) AgKpKXYIbhbWKKdH(this.fcb5e100e)) is not null) {
                                SXCztBzqHteWGNfz(spscLinkedArrayQueue);
                                XSEkzMlyRIGIZhGb(this);
                                xfSltjTPrOAiXFTG(this, subscriber);
                                return;
                            }
                            long jZugkeZUJpTqAReEK = zugkeZUJpTqAReEK(this.f67a14a21);
                            java.util.IEnumerator itHRHTGjBnDfRnKAQD = HRHTGjBnDfRnKAQD(ttrzVcVFYHUlHsfj(this.f42c5db7a));
                            long j2 = 0;
                            while (BKTDuhicMsXQFkHA(itHRHTGjBnDfRnKAQD)) {
                                try {
                                    java.lang.object objGNwOHGuoPVqCXLIj = GNwOHGuoPVqCXLIj(xYTdUZAhqxUDSxeO(this.f63de7122, uOmjDfQutAZuqIJK(itHRHTGjBnDfRnKAQD), objGzuumstEpOVMDSjh), "The resultSelector returned a null value");
                                    if (j2 == jZugkeZUJpTqAReEK) {
                                        YNECSxYjzfSHdGVs(this.fcb5e100e, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1("Could not emit value due to lack of requests"));
                                        GbTTVcGsOWvaFllI(spscLinkedArrayQueue);
                                        JxhCFWrAjfEDVVDA(this);
                                        HOQkeVJoZffJmUtI(this, subscriber);
                                        return;
                                    }
                                    TPkifOZJwjOlhziM(subscriber, objGNwOHGuoPVqCXLIj);
                                    j2++;
                                } catch (java.lang.Exception th3) {
                                    vvyrkDgtRSNyjGEX(this, th3, subscriber, spscLinkedArrayQueue);
                                    return;
                                }
                            }
                            if (j2 != 0) {
                                qwUGDJaQhASrmLwD(this.f67a14a21, j2);
                            }
                        } catch (java.lang.Exception th4) {
                            kFDdEdbTPJzspNWt(this, th4, subscriber, spscLinkedArrayQueue);
                            return;
                        }
                    } else if (num != f65f10819) {
                        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110 pafdeb810_pf62ac1103 = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110) objGzuumstEpOVMDSjh;
                        WZrjfXmBGfgZuNxC(this.f27b37152, ZMLcVSDxWGFDUlNB(pafdeb810_pf62ac1103.f6a992d55));
                        vgxuuufggUxwtywR(this.f52905679, pafdeb810_pf62ac1103);
                    } else {
                        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110 pafdeb810_pf62ac1104 = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110) objGzuumstEpOVMDSjh;
                        RvGKuKtdBrxEncyT(this.f42c5db7a, lRjICsedLfViNsSH(pafdeb810_pf62ac1104.f6a992d55));
                        BtLFGZjXviCLBaef(this.f52905679, pafdeb810_pf62ac1104);
                    }
                    z = true;
                }
            }
            wujGTgtfcaiMHGon(spscLinkedArrayQueue);
        }
    }

    void errorAll(org.reactivestreams.Subscriber<object> subscriber) {
        if ((3 + 23) % 23 > 0) {
        }
        java.lang.Exception thUAnSPzqFJwzIDHGT = uAnSPzqFJwzIDHGT(this.fcb5e100e);
        sjSWBaSuTPBjYNan(this.f42c5db7a);
        tSahXwAPwWtnyHnO(this.f27b37152);
        tEwScLwDlXQxIMNM(subscriber, thUAnSPzqFJwzIDHGT);
    }

    void fail(java.lang.Exception th, org.reactivestreams.Subscriber<object> subscriber, io.reactivex.rxjava3.operators.SimpleQueue<object> simpleQueue) {
        CTJSyoqbCZfqRZDS(th);
        jOAtYuEKianRMXHQ(this.fcb5e100e, th);
        FWvrVSAYAvBLFeqX(simpleQueue);
        pbTKVNxzCOPrcBaO(this);
        zKpHodoubAqfFvbS(this, subscriber);
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    public override void InnerClose(bool r2, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110 r3) {
        /*
            r1 = this;
            goto L4
        L4:
            goto L13
        L7:
            goto L21
        Lb:
            OkpWHIrAvQRCVqiU(r1)
            goto L1a
        L12:
            throw r2
        L13:
            goto L17
        L17:
            goto L7
        L1a:
            return
        L1b:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1b
            goto L12
        L21:
            monitor-enter(r1)
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> r0 = r1.fa9d1cbf7     // Catch: java.lang.Exception -> L1b
            if (r2 == 0) goto L29
            java.lang.int r2 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50.f65f10819     // Catch: java.lang.Exception -> L1b
            goto L2b
        L29:
            java.lang.int r2 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50.fd902d608     // Catch: java.lang.Exception -> L1b
        L2b:
            eFhlxxDZapQMcemd(r0, r2, r3)     // Catch: java.lang.Exception -> L1b
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1b
            goto Lb
        */
        throw new UnsupportedOperationException("Method not decompiled: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50.innerClose(bool, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$pf62ac110):void");
    }

    public override void InnerCloseError(java.lang.Exception th) {
        if (GdQAEqpYUrvUdkKC(this.fcb5e100e, th)) {
            CeQuAuFQaytTiaCj(this);
        } else {
            MrZCUpztFPMibSiF(th);
        }
    }

    public override void InnerComplete(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pafdeb810$p4c9f5644 pafdeb810_p4c9f5644) {
        CsuztXogpEElbLeU(this.f52905679, pafdeb810_p4c9f5644);
        MHrgEyDMsqOpHGJb(this.fc76a5e84);
        CABfodNteOtcydCG(this);
    }

    public override void InnerError(java.lang.Exception th) {
        if (!gsDYgdmskQnhNqxm(this.fcb5e100e, th)) {
            AuMnxWePantOisFb(th);
        } else {
            GnDdpuFWbAmGfvGF(this.fc76a5e84);
            dKXlChrlmWruPCZf(this);
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
    public override void InnerValue(bool r2, java.lang.object r3) {
        /*
            r1 = this;
            goto L20
        L4:
            return
        L5:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto L27
        Lb:
            goto L23
        Le:
            monitor-enter(r1)
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> r0 = r1.fa9d1cbf7     // Catch: java.lang.Exception -> L5
            if (r2 == 0) goto L16
            java.lang.int r2 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50.f323b32a7     // Catch: java.lang.Exception -> L5
            goto L18
        L16:
            java.lang.int r2 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50.f651af744     // Catch: java.lang.Exception -> L5
        L18:
            SMJHtcWubeQPoiMZ(r0, r2, r3)     // Catch: java.lang.Exception -> L5
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto L2c
        L20:
            goto L28
        L23:
            goto Le
        L27:
            throw r2
        L28:
            goto Lb
        L2c:
            kINUoOBaYfDJeGiK(r1)
            goto L4
        */
        throw new UnsupportedOperationException("Method not decompiled: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p504476d0$p8be94f50.innerValue(bool, java.lang.object):void");
    }

    public override void Request(long j) {
        if (TXcGlGCxhLPxexTl(j)) {
            elNzPUNqrolOPgnk(this.f67a14a21, j);
        }
    }
}

