namespace WillowMaze.Wasm.Decompiled;


readonly class p40fc764b$pe37abc16<TLeft, TRight, TLeftEnd, TRightEnd, R> : java.util.concurrent.atomic.Atomicint : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$pebedbfbf {
    static readonly java.lang.int f1302e61c = null;
    static readonly java.lang.int f13cff62b = null;
    static readonly java.lang.int f3e66c6d2 = null;
    static readonly java.lang.int f43c9b515 = null;
    static readonly java.lang.int f4e70c71d = null;
    private static readonly long f615727ef = -6071216598687999801L;
    static readonly java.lang.int f623e6442 = null;
    private static readonly long f62587c65 = -6071216598687999801L;
    static readonly java.lang.int f6fed6e13 = null;
    static readonly java.lang.int f71132c1f = null;
    private static readonly long f8dd2cd25 = -6071216598687999801L;
    static readonly java.lang.int fb610c382 = null;
    static readonly java.lang.int fc483deed = null;
    private static readonly long fc6e1e520 = -6071216598687999801L;
    static readonly java.lang.int fe27236e9 = null;
    readonly java.util.Dictionary f0000e168;
    int f0eb631ac;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f16d21e7d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f1d740e7d;
    int f25563427;
    readonly java.util.concurrent.atomic.object f258efd2e;
    int f26726d27;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f2d1472f0;
    readonly io.reactivex.rxjava3.functions.Function<? super TRight, ? : io.reactivex.rxjava3.core.ObservableSource<TRightEnd>> f2fbf087c;
    readonly java.util.concurrent.atomic.Atomicint f2ff2c336;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f3323ad94;
    readonly java.util.concurrent.atomic.Atomicint f3612b4d3;
    volatile bool f38881e0a;
    int f3eb34125;
    readonly io.reactivex.rxjava3.functions.Function<? super TLeft, ? : io.reactivex.rxjava3.core.ObservableSource<TLeftEnd>> f412d0c77;
    int f415e97ed;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4907039c;
    readonly java.util.concurrent.atomic.object f5501774b;
    readonly io.reactivex.rxjava3.core.Observer f61b93370;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super TLeft, ? super TRight, ? : R> f63de7122;
    int f64020157;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f77f5dd9f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f7cd04421;
    readonly java.util.concurrent.atomic.Atomicint f7e411ca0;
    volatile bool f7eb9697d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f80b2f55f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f9234062c;
    int f96c3341b;
    volatile bool fa00544c8;
    int fa7b852a8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fb81a2c8b;
    readonly io.reactivex.rxjava3.core.Observer<R> fd22a0a80;
    volatile bool fd5366e42;
    volatile bool fe5013351;
    int fedc10311;
    readonly java.util.Dictionary ffc0256cc;
    static readonly java.lang.int f323b32a7 = tIcrErFhUiPDchtk(1);
    static readonly java.lang.int f651af744 = ByewpUOfVgMUsvpH(2);
    static readonly java.lang.int f65f10819 = kiKRSsBhWriRxJkA(3);
    static readonly java.lang.int fd902d608 = rYwSWVkPOcHwLELA(4);
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f52905679 = new pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd();
    readonly io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(qGiwqwutzOtLEHvl());
    readonly java.util.Dictionary<java.lang.int, TLeft> f42c5db7a = new java.util.LinkedHashDictionary();
    readonly java.util.Dictionary<java.lang.int, TRight> f27b37152 = new java.util.LinkedHashDictionary();
    readonly java.util.concurrent.atomic.object<java.lang.Exception> fcb5e100e = new java.util.concurrent.atomic.object<>();
    readonly java.util.concurrent.atomic.Atomicint fc76a5e84 = new java.util.concurrent.atomic.Atomicint(2);

    p40fc764b$pe37abc16(io.reactivex.rxjava3.core.Observer<R> observer, io.reactivex.rxjava3.functions.Function<? super TLeft, ? : io.reactivex.rxjava3.core.ObservableSource<TLeftEnd>> function, io.reactivex.rxjava3.functions.Function<? super TRight, ? : io.reactivex.rxjava3.core.ObservableSource<TRightEnd>> function2, io.reactivex.rxjava3.functions.BiFunction<? super TLeft, ? super TRight, ? : R> biFunction) {
        this.fd22a0a80 = observer;
        this.f412d0c77 = function;
        this.f2fbf087c = function2;
        this.f63de7122 = biFunction;
    }

    public static void ABuBQgGfdmLReqkj(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static java.lang.object AEVSHWEuzpqhLcww(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void AvxgeiMZFNSzoQEA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16 p40fc764b_pe37abc16, java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p40fc764b_pe37abc16.fail(th, observer, p50dc035cVar);
    }

    public static void BxGHjicLZgSFVRCC(java.util.Dictionary map) {
        map.clear();
    }

    public static java.lang.int ByewpUOfVgMUsvpH(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object CJqnbuiIoMCmWUbT(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static void CMyWKCKCXctvSfQC(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static java.lang.object CfLSDuliqgICbuzY(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object CmEzWOMUoRbLjbGa(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static void CvFWPESVYawUMkLP(java.util.Dictionary map) {
        map.clear();
    }

    public static int DCSmKMRUfeIDMVxi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16 p40fc764b_pe37abc16, int i) {
        return p40fc764b_pe37abc16.addAndGet(i);
    }

    public static void DNLDPYVpFuKEvttm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16 p40fc764b_pe37abc16) {
        p40fc764b_pe37abc16.drain();
    }

    public static java.lang.object DNZAmpVvlmJvxVWn(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.Exception DfQDYxBnpQJjPkCj(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m1459e53d(atomicReference);
    }

    public static java.lang.int FUuhbmgVqMeynUBy(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void FYaRERaUJDqlgcZP(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void FaLcGMiaybbcLJtj(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool FvpqvujbjoIFnNuU(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Remove(p7beea252Var);
    }

    public static void GKospsumPdpRvOTJ(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void GlUIEeuvFQtgdeQx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16 p40fc764b_pe37abc16) {
        p40fc764b_pe37abc16.cancelAll();
    }

    public static void HHdggUoRpYlknrcW(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void HZROTtdjOlEwKpqK(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void IqecWyvTqjoFhdxs(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16 p40fc764b_pe37abc16) {
        p40fc764b_pe37abc16.drain();
    }

    public static void OhSSGoXobWlZkEUW(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static java.lang.object OjsTksEHCEGBZQbz(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static bool QXuhSTdxrKkydTon(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj, java.lang.object obj2) {
        return p50dc035cVar.offer(obj, obj2);
    }

    public static java.lang.object QvVwdWwOlENWRZVc(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool SjqDJMmpQsBMVjuM(java.util.concurrent.atomic.object atomicReference, java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m9373b63a(atomicReference, th);
    }

    public static void TfhiIazdLdjYPvCc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16 p40fc764b_pe37abc16, java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p40fc764b_pe37abc16.fail(th, observer, p50dc035cVar);
    }

    public static void USCBDjgrDZtCeBku(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16 p40fc764b_pe37abc16) {
        p40fc764b_pe37abc16.cancelAll();
    }

    public static java.util.IEnumerator VGKAFflmUyBSMWzi(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static java.lang.object VtoPiUEUKEJpLNeK(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static void WeMYvuxdQNWxVpwb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16 p40fc764b_pe37abc16) {
        p40fc764b_pe37abc16.cancelAll();
    }

    public static int XLfygRzrUJfREJWh(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static void XPrFLsCcnafGYiXd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16 p40fc764b_pe37abc16) {
        p40fc764b_pe37abc16.drain();
    }

    public static java.util.ICollection ZXlArnGSxCOMDWPn(java.util.Dictionary map) {
        return map.Values;
    }

    public static void ZpgIzxYKaWmrcMkC(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.util.ICollection ZvZHoaiGvQcEJTtt(java.util.Dictionary map) {
        return map.Values;
    }

    public static bool AMYMMNkMfqcrnRCY(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.delete(p7beea252Var);
    }

    public static java.lang.object AOPremqiVrpbhTpV(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static int AoyhYHWXrExxYGnH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16 p40fc764b_pe37abc16) {
        return p40fc764b_pe37abc16.getAndIncrement();
    }

    public static bool BAilQlcmBCbfbmON(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj, java.lang.object obj2) {
        return p50dc035cVar.offer(obj, obj2);
    }

    public static int BKHWqQqddSuwOnpS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16 p40fc764b_pe37abc16) {
        return p40fc764b_pe37abc16.getAndIncrement();
    }

    public static void BMXGanNTMpcIUtzk(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static bool BfadGCeCuAGALeSx(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool BolezMxHjAWaxHWG(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Remove(p7beea252Var);
    }

    public static void ByMtQDFurDYhIaEn(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static bool CLCstCGBZxTXjLBa(java.util.concurrent.atomic.object atomicReference, java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m9373b63a(atomicReference, th);
    }

    public static java.util.IEnumerator CSbRGXGtypTnzitp(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static java.lang.int EBmQxZauciJLaPWR(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int ERcbcfphQbPKBpMR(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static void EvHPoyFDUrdJDIbc(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static java.lang.object FONygNQKPNNqYHJm(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object FVvgyVSBhyxFiODd(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object FXCmIUctRjDSZiSw(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void FbVoZCUMDgbwGdAu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16 p40fc764b_pe37abc16, io.reactivex.rxjava3.core.Observer observer) {
        p40fc764b_pe37abc16.errorAll(observer);
    }

    public static void GJIPcVoxkfkuEsXp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16 p40fc764b_pe37abc16, java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p40fc764b_pe37abc16.fail(th, observer, p50dc035cVar);
    }

    public static void GmsLzUMsGctUvEVf(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void GtLufBaWcPTTXVZr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16 p40fc764b_pe37abc16) {
        p40fc764b_pe37abc16.cancelAll();
    }

    public static void HBMUHioHserAEiJt(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static int HLctiKkyvHDuybKT(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static java.lang.int IRylKEHEWfHHmoEo(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void IwjpvPyUxZRvivIg(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void JRQKUljbmSICzsbR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16 p40fc764b_pe37abc16, io.reactivex.rxjava3.core.Observer observer) {
        p40fc764b_pe37abc16.errorAll(observer);
    }

    public static void JjjlYEqscfsjmwCz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16 p40fc764b_pe37abc16, io.reactivex.rxjava3.core.Observer observer) {
        p40fc764b_pe37abc16.errorAll(observer);
    }

    public static java.lang.object JpQRSEPRFqLdamLc(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void KAnAJrpBgWHFJEac(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16 p40fc764b_pe37abc16, io.reactivex.rxjava3.core.Observer observer) {
        p40fc764b_pe37abc16.errorAll(observer);
    }

    public static bool KVLDSbjPJhtSsCDC(java.util.concurrent.atomic.object atomicReference, java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m9373b63a(atomicReference, th);
    }

    public static java.lang.int KiKRSsBhWriRxJkA(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void KvYKyhisQRbKkToy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16 p40fc764b_pe37abc16, java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p40fc764b_pe37abc16.fail(th, observer, p50dc035cVar);
    }

    public static void LjTUgurOdwEtRyYn(java.util.Dictionary map) {
        map.clear();
    }

    public static void LoRBOGKANvyFiwFO(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void MJBFNPDBKvtXHxlq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16 p40fc764b_pe37abc16) {
        p40fc764b_pe37abc16.cancelAll();
    }

    public static java.lang.object NBFRfoPNoRdqSgJM(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void NCUqUDJkDpYbiObb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16 p40fc764b_pe37abc16) {
        p40fc764b_pe37abc16.drain();
    }

    public static bool OGSrEcgHSaRCkMIN(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int QGiwqwutzOtLEHvl() {
        return io.reactivex.rxjava3.core.Observable.mcdee5967();
    }

    public static void QbPdxzWiVvujXjSI(java.util.Dictionary map) {
        map.clear();
    }

    public static void QtPvXXTRbARqjIev(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static java.lang.int RYwSWVkPOcHwLELA(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object SzJGjSzNSAfvVVgw(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static java.lang.int TIcrErFhUiPDchtk(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void TJSfeekpcvlcOvex(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16 p40fc764b_pe37abc16) {
        p40fc764b_pe37abc16.drain();
    }

    public static bool UoqgXqhsQFMsbRkX(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static java.lang.object VbblgVEKpfcyzAMf(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.int XFZKijzOSBYeSjOM(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object XqVxTGHMtyNVofNm(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static bool YRbzvFeYwlFVFfHp(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static java.lang.object YeAUWXUbEPRoumNQ(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static java.lang.object ZSNRdWlinTWDUirc(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    void cancelAll() {
        OhSSGoXobWlZkEUW(this.f52905679);
    }

    public override void Dispose() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        mJBFNPDBKvtXHxlq(this);
        if (aoyhYHWXrExxYGnH(this) != 0) {
            return;
        }
        HHdggUoRpYlknrcW(this.fa9d1cbf7);
    }

    void drain() {
        if ((29 + 17) % 17 > 0) {
        }
        if (bKHWqQqddSuwOnpS(this) == 0) {
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> spscLinkedArrayQueue = this.fa9d1cbf7;
            io.reactivex.rxjava3.core.Observer<R> observer = this.fd22a0a80;
            int iDCSmKMRUfeIDMVxi = 1;
            while (!this.f38881e0a) {
                if (((java.lang.Exception) jpQRSEPRFqLdamLc(this.fcb5e100e)) is not null) {
                    hBMUHioHserAEiJt(spscLinkedArrayQueue);
                    USCBDjgrDZtCeBku(this);
                    fbVoZCUMDgbwGdAu(this, observer);
                    return;
                }
                bool z = eRcbcfphQbPKBpMR(this.fc76a5e84) == 0;
                java.lang.int num = (java.lang.int) yeAUWXUbEPRoumNQ(spscLinkedArrayQueue);
                bool z2 = num is null;
                if (z && z2) {
                    ljTUgurOdwEtRyYn(this.f42c5db7a);
                    qbPdxzWiVvujXjSI(this.f27b37152);
                    CMyWKCKCXctvSfQC(this.f52905679);
                    FaLcGMiaybbcLJtj(observer);
                    return;
                }
                if (z2) {
                    iDCSmKMRUfeIDMVxi = DCSmKMRUfeIDMVxi(this, -iDCSmKMRUfeIDMVxi);
                    if (iDCSmKMRUfeIDMVxi == 0) {
                        return;
                    }
                } else {
                    java.lang.object objOjsTksEHCEGBZQbz = OjsTksEHCEGBZQbz(spscLinkedArrayQueue);
                    if (num == f323b32a7) {
                        int i = this.fedc10311;
                        this.fedc10311 = i + 1;
                        QvVwdWwOlENWRZVc(this.f42c5db7a, iRylKEHEWfHHmoEo(i), objOjsTksEHCEGBZQbz);
                        try {
                            io.reactivex.rxjava3.core.ObservableSource observableSource = (io.reactivex.rxjava3.core.ObservableSource) fXCmIUctRjDSZiSw(xqVxTGHMtyNVofNm(this.f412d0c77, objOjsTksEHCEGBZQbz), "The leftEnd returned a null ObservableSource");
                            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$ped70e0fb p08a3cdb1_ped70e0fb = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$ped70e0fb(this, true, i);
                            yRbzvFeYwlFVFfHp(this.f52905679, p08a3cdb1_ped70e0fb);
                            byMtQDFurDYhIaEn(observableSource, p08a3cdb1_ped70e0fb);
                            if (((java.lang.Exception) DNZAmpVvlmJvxVWn(this.fcb5e100e)) is not null) {
                                evHPoyFDUrdJDIbc(spscLinkedArrayQueue);
                                WeMYvuxdQNWxVpwb(this);
                                jRQKUljbmSICzsbR(this, observer);
                                return;
                            } else {
                                java.util.IEnumerator itCSbRGXGtypTnzitp = cSbRGXGtypTnzitp(ZvZHoaiGvQcEJTtt(this.f27b37152));
                                while (bfadGCeCuAGALeSx(itCSbRGXGtypTnzitp)) {
                                    try {
                                        ABuBQgGfdmLReqkj(observer, CfLSDuliqgICbuzY(szJGjSzNSAfvVVgw(this.f63de7122, objOjsTksEHCEGBZQbz, AEVSHWEuzpqhLcww(itCSbRGXGtypTnzitp)), "The resultSelector returned a null value"));
                                    } catch (java.lang.Exception th) {
                                        AvxgeiMZFNSzoQEA(this, th, observer, spscLinkedArrayQueue);
                                        return;
                                    }
                                }
                            }
                        } catch (java.lang.Exception th2) {
                            kvYKyhisQRbKkToy(this, th2, observer, spscLinkedArrayQueue);
                            return;
                        }
                    } else if (num == f651af744) {
                        int i2 = this.f415e97ed;
                        this.f415e97ed = i2 + 1;
                        nBFRfoPNoRdqSgJM(this.f27b37152, xFZKijzOSBYeSjOM(i2), objOjsTksEHCEGBZQbz);
                        try {
                            io.reactivex.rxjava3.core.ObservableSource observableSource2 = (io.reactivex.rxjava3.core.ObservableSource) zSNRdWlinTWDUirc(aOPremqiVrpbhTpV(this.f2fbf087c, objOjsTksEHCEGBZQbz), "The rightEnd returned a null ObservableSource");
                            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$ped70e0fb p08a3cdb1_ped70e0fb2 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$ped70e0fb(this, false, i2);
                            uoqgXqhsQFMsbRkX(this.f52905679, p08a3cdb1_ped70e0fb2);
                            qtPvXXTRbARqjIev(observableSource2, p08a3cdb1_ped70e0fb2);
                            if (((java.lang.Exception) fONygNQKPNNqYHJm(this.fcb5e100e)) is not null) {
                                iwjpvPyUxZRvivIg(spscLinkedArrayQueue);
                                GlUIEeuvFQtgdeQx(this);
                                jjjlYEqscfsjmwCz(this, observer);
                                return;
                            } else {
                                java.util.IEnumerator itVGKAFflmUyBSMWzi = VGKAFflmUyBSMWzi(ZXlArnGSxCOMDWPn(this.f42c5db7a));
                                while (oGSrEcgHSaRCkMIN(itVGKAFflmUyBSMWzi)) {
                                    try {
                                        HZROTtdjOlEwKpqK(observer, fVvgyVSBhyxFiODd(CJqnbuiIoMCmWUbT(this.f63de7122, vbblgVEKpfcyzAMf(itVGKAFflmUyBSMWzi), objOjsTksEHCEGBZQbz), "The resultSelector returned a null value"));
                                    } catch (java.lang.Exception th3) {
                                        gJIPcVoxkfkuEsXp(this, th3, observer, spscLinkedArrayQueue);
                                        return;
                                    }
                                }
                            }
                        } catch (java.lang.Exception th4) {
                            TfhiIazdLdjYPvCc(this, th4, observer, spscLinkedArrayQueue);
                            return;
                        }
                    } else if (num != f65f10819) {
                        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$ped70e0fb p08a3cdb1_ped70e0fb3 = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$ped70e0fb) objOjsTksEHCEGBZQbz;
                        VtoPiUEUKEJpLNeK(this.f27b37152, FUuhbmgVqMeynUBy(p08a3cdb1_ped70e0fb3.f6a992d55));
                        bolezMxHjAWaxHWG(this.f52905679, p08a3cdb1_ped70e0fb3);
                    } else {
                        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$ped70e0fb p08a3cdb1_ped70e0fb4 = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$ped70e0fb) objOjsTksEHCEGBZQbz;
                        CmEzWOMUoRbLjbGa(this.f42c5db7a, eBmQxZauciJLaPWR(p08a3cdb1_ped70e0fb4.f6a992d55));
                        FvpqvujbjoIFnNuU(this.f52905679, p08a3cdb1_ped70e0fb4);
                    }
                }
            }
            loRBOGKANvyFiwFO(spscLinkedArrayQueue);
        }
    }

    void errorAll(io.reactivex.rxjava3.core.Observer<object> observer) {
        if ((25 + 1) % 1 > 0) {
        }
        java.lang.Exception thDfQDYxBnpQJjPkCj = DfQDYxBnpQJjPkCj(this.fcb5e100e);
        CvFWPESVYawUMkLP(this.f42c5db7a);
        BxGHjicLZgSFVRCC(this.f27b37152);
        gmsLzUMsGctUvEVf(observer, thDfQDYxBnpQJjPkCj);
    }

    void fail(java.lang.Exception th, io.reactivex.rxjava3.core.Observer<object> observer, io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<object> spscLinkedArrayQueue) {
        ZpgIzxYKaWmrcMkC(th);
        SjqDJMmpQsBMVjuM(this.fcb5e100e, th);
        bMXGanNTMpcIUtzk(spscLinkedArrayQueue);
        gtLufBaWcPTTXVZr(this);
        kAnAJrpBgWHFJEac(this, observer);
    }

    public override void InnerClose(bool z, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$ped70e0fb p08a3cdb1_ped70e0fb) {
        lock (this) {
            try {
                bAilQlcmBCbfbmON(this.fa9d1cbf7, z ? f65f10819 : fd902d608, p08a3cdb1_ped70e0fb);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        tJSfeekpcvlcOvex(this);
    }

    public override void InnerCloseError(java.lang.Exception th) {
        if (cLCstCGBZxTXjLBa(this.fcb5e100e, th)) {
            IqecWyvTqjoFhdxs(this);
        } else {
            GKospsumPdpRvOTJ(th);
        }
    }

    public override void InnerComplete(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p27e40df6 p08a3cdb1_p27e40df6) {
        aMYMMNkMfqcrnRCY(this.f52905679, p08a3cdb1_p27e40df6);
        XLfygRzrUJfREJWh(this.fc76a5e84);
        DNLDPYVpFuKEvttm(this);
    }

    public override void InnerError(java.lang.Exception th) {
        if (!kVLDSbjPJhtSsCDC(this.fcb5e100e, th)) {
            FYaRERaUJDqlgcZP(th);
        } else {
            hLctiKkyvHDuybKT(this.fc76a5e84);
            XPrFLsCcnafGYiXd(this);
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
            goto L4
        L4:
            goto L28
        L7:
            goto L15
        Lb:
            goto L7
        Le:
            return
        Lf:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> Lf
            goto L27
        L15:
            monitor-enter(r1)
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> r0 = r1.fa9d1cbf7     // Catch: java.lang.Exception -> Lf
            if (r2 == 0) goto L1d
            java.lang.int r2 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16.f323b32a7     // Catch: java.lang.Exception -> Lf
            goto L1f
        L1d:
            java.lang.int r2 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16.f651af744     // Catch: java.lang.Exception -> Lf
        L1f:
            QXuhSTdxrKkydTon(r0, r2, r3)     // Catch: java.lang.Exception -> Lf
            monitor-exit(r1)     // Catch: java.lang.Exception -> Lf
            goto L2c
        L27:
            throw r2
        L28:
            goto Lb
        L2c:
            nCUqUDJkDpYbiObb(r1)
            goto Le
        */
        throw new UnsupportedOperationException("Method not decompiled: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40fc764b$pe37abc16.innerValue(bool, java.lang.object):void");
    }

    public override bool IsDisposed() {
        return this.f38881e0a;
    }
}

