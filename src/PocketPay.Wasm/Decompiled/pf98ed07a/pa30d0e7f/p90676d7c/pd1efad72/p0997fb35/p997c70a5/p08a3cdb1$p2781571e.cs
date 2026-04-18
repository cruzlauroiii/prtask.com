namespace WillowMaze.Wasm.Decompiled;


readonly class p08a3cdb1$p2781571e<TLeft, TRight, TLeftEnd, TRightEnd, R> : java.util.concurrent.atomic.Atomicint : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$pebedbfbf {
    static readonly java.lang.int f0fd487f4 = null;
    static readonly java.lang.int f1117932a = null;
    static readonly java.lang.int f1222ed37 = null;
    private static readonly long f3acc5e58 = -6071216598687999801L;
    static readonly java.lang.int f42dde342 = null;
    static readonly java.lang.int f6312a100 = null;
    private static readonly long f656b769e = -6071216598687999801L;
    static readonly java.lang.int f7b60283b = null;
    private static readonly long f916e095c = -6071216598687999801L;
    static readonly java.lang.int fb3495dd6 = null;
    static readonly java.lang.int fbe015aff = null;
    private static readonly long fc6e1e520 = -6071216598687999801L;
    static readonly java.lang.int fc7375d36 = null;
    static readonly java.lang.int fdddd64b1 = null;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f0e415b36;
    readonly java.util.concurrent.atomic.Atomicint f11099a5a;
    readonly java.util.Dictionary f170da429;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f1bc9b589;
    volatile bool f1dd2da97;
    readonly io.reactivex.rxjava3.core.Observer f1dff0f0b;
    readonly java.util.concurrent.atomic.object f2a15ee69;
    readonly io.reactivex.rxjava3.functions.Function<? super TRight, ? : io.reactivex.rxjava3.core.ObservableSource<TRightEnd>> f2fbf087c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f330ec14c;
    volatile bool f38881e0a;
    readonly java.util.concurrent.atomic.Atomicint f3a0c1841;
    readonly io.reactivex.rxjava3.functions.Function<? super TLeft, ? : io.reactivex.rxjava3.core.ObservableSource<TLeftEnd>> f412d0c77;
    int f415e97ed;
    readonly java.util.Dictionary f433fa505;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f49b92666;
    int f63136a14;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super TLeft, ? super io.reactivex.rxjava3.core.Observable<TRight>, ? : R> f63de7122;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f67c983fd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f67d8b060;
    readonly java.util.Dictionary f685e0635;
    int f6b3d3480;
    volatile bool f6e6c03c5;
    readonly java.util.concurrent.atomic.object f739c1165;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f937a7bb2;
    volatile bool f961c30e7;
    readonly java.util.concurrent.atomic.Atomicint fa0b59bf1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd fa0d5f47a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c fab9a38a8;
    readonly java.util.Dictionary fae717bd4;
    readonly java.util.Dictionary fbace8b5d;
    volatile bool fbb91ef2d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc8174ca9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd fc86e91f4;
    int fc99c84ac;
    readonly io.reactivex.rxjava3.core.Observer<R> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd53fab09;
    int fedc10311;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ff0c0d62f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd ffcdd0ed3;
    static readonly java.lang.int f323b32a7 = SrpnHRTFpkQaovWM(1);
    static readonly java.lang.int f651af744 = ljJwJXLVNjIfYzke(2);
    static readonly java.lang.int f65f10819 = NRSCCKOiGYFtaENA(3);
    static readonly java.lang.int fd902d608 = hgwPTwDwChTEWXyL(4);
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f52905679 = new pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd();
    readonly io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(UpOTRkuDdmrjFoKB());
    readonly java.util.Dictionary<java.lang.int, io.reactivex.rxjava3.subjects.UnicastSubject<TRight>> f42c5db7a = new java.util.LinkedHashDictionary();
    readonly java.util.Dictionary<java.lang.int, TRight> f27b37152 = new java.util.LinkedHashDictionary();
    readonly java.util.concurrent.atomic.object<java.lang.Exception> fcb5e100e = new java.util.concurrent.atomic.object<>();
    readonly java.util.concurrent.atomic.Atomicint fc76a5e84 = new java.util.concurrent.atomic.Atomicint(2);

    p08a3cdb1$p2781571e(io.reactivex.rxjava3.core.Observer<R> observer, io.reactivex.rxjava3.functions.Function<? super TLeft, ? : io.reactivex.rxjava3.core.ObservableSource<TLeftEnd>> function, io.reactivex.rxjava3.functions.Function<? super TRight, ? : io.reactivex.rxjava3.core.ObservableSource<TRightEnd>> function2, io.reactivex.rxjava3.functions.BiFunction<? super TLeft, ? super io.reactivex.rxjava3.core.Observable<TRight>, ? : R> biFunction) {
        this.fd22a0a80 = observer;
        this.f412d0c77 = function;
        this.f2fbf087c = function2;
        this.f63de7122 = biFunction;
    }

    public static java.util.IEnumerator AchhOqBCFEDcRGQL(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static void AcpgrHZCCpvYfnLV(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar, java.lang.Exception th) {
        peef7828dVar.onError(th);
    }

    public static bool AhdkHBqSMiamtYeQ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void BQOysgIBDjNLDEff(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e p08a3cdb1_p2781571e) {
        p08a3cdb1_p2781571e.cancelAll();
    }

    public static java.util.ICollection BlRGQLZfQWTtRHCQ(java.util.Dictionary map) {
        return map.Values;
    }

    public static void CclMSdejIYEkSVhG(java.util.Dictionary map) {
        map.clear();
    }

    public static java.lang.object CkLSbiYrjsCZHARl(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static bool CxJGDoTElypuXEyu(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Remove(p7beea252Var);
    }

    public static void DFAEcGjVnOimvMeY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e p08a3cdb1_p2781571e) {
        p08a3cdb1_p2781571e.cancelAll();
    }

    public static void DnjbpuGqDUsiiXCe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e p08a3cdb1_p2781571e) {
        p08a3cdb1_p2781571e.drain();
    }

    public static java.util.IEnumerator DwqBqXXeSdapMUQQ(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static void EGeeHCYKybuhFxZP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e p08a3cdb1_p2781571e) {
        p08a3cdb1_p2781571e.cancelAll();
    }

    public static bool EbqqeeoQFSTTENgk(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj, java.lang.object obj2) {
        return p50dc035cVar.offer(obj, obj2);
    }

    public static void EzCoWQxVDyjpmMuI(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar, java.lang.object obj) {
        peef7828dVar.onNext(obj);
    }

    public static java.lang.int GBRgpdngKkDcmQtM(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int GKDDxxZIEGHGuuDz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e p08a3cdb1_p2781571e) {
        return p08a3cdb1_p2781571e.getAndIncrement();
    }

    public static void GNfIMZThnaVPMvRZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e p08a3cdb1_p2781571e, io.reactivex.rxjava3.core.Observer observer) {
        p08a3cdb1_p2781571e.errorAll(observer);
    }

    public static void HEyJykIoWSlOKeDv(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static java.lang.object HHTDEiPKDJretRiC(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static java.lang.object IDDUtBiVZaFxmHAj(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static bool IwmuurFzJFWVvGqw(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static void JGGcOVewPatQIxkF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e p08a3cdb1_p2781571e) {
        p08a3cdb1_p2781571e.cancelAll();
    }

    public static void JRvSpurHtOXJQXIq(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void KCLAKQkJcuoWLmWO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e p08a3cdb1_p2781571e) {
        p08a3cdb1_p2781571e.cancelAll();
    }

    public static bool KjTCcwsmrJRQOdqx(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool KuayQnzOmIfNhibC(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj, java.lang.object obj2) {
        return p50dc035cVar.offer(obj, obj2);
    }

    public static java.lang.object LgNNQwKIcWBNmDoV(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static void LpMTbzTfIpSPXUob(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e p08a3cdb1_p2781571e) {
        p08a3cdb1_p2781571e.drain();
    }

    public static void MDFphZZXHFuYygMU(java.util.Dictionary map) {
        map.clear();
    }

    public static int MKEZjtotIlVPRxok(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static java.lang.int NRSCCKOiGYFtaENA(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object OIwMvCEuvFKFTUqx(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object OWFZKhoYkcSCHwQy(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void OWhyeNtWYLvjxplU(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar, java.lang.object obj) {
        peef7828dVar.onNext(obj);
    }

    public static bool OerISqnSUxjFjKgN(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.int PMNsowOCZCRQyfVW(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool PcuBDomViRGhbrqn(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static void QDejrCGqQNIfqJpV(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static java.lang.Exception QUuDLTnvssSbbXSe(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m1459e53d(atomicReference);
    }

    public static void QWFJXfiQjEOpcWCq(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void QsirkYqfkeHiObOK(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static java.util.IEnumerator RHMbLmBAXPsWifJb(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static java.lang.object RlFxekazzLBQeteL(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.util.IEnumerator RycXPdVUScbUMHzK(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static java.lang.int SrpnHRTFpkQaovWM(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void SsltyUtTLFGKFqjc(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static int UpOTRkuDdmrjFoKB() {
        return io.reactivex.rxjava3.core.Observable.mcdee5967();
    }

    public static void VBkmPqWylYjVAEyl(java.util.Dictionary map) {
        map.clear();
    }

    public static java.lang.object VHTuCsTidZumBLaM(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.int XPWdVrPAiMLZWXQt(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void XcfCfiuIFIepRECm(java.util.Dictionary map) {
        map.clear();
    }

    public static bool YkGTKsmElREVWVXV(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.ICollection AdthMXlwjjPXGLpN(java.util.Dictionary map) {
        return map.Values;
    }

    public static java.lang.object AilwgGukaoXUHGgf(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object AjyjJXrGEnnsIvYU(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void BbQpgWjQJNvVHJkb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e p08a3cdb1_p2781571e) {
        p08a3cdb1_p2781571e.drain();
    }

    public static java.util.ICollection EuxfWZIPHYGpfuzF(java.util.Dictionary map) {
        return map.Values;
    }

    public static void GBaabJCIbpeGPAvF(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void HeToxLuctPyRwglh(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static java.lang.object HgksEKDRdVljSqBx(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static java.lang.int HgwPTwDwChTEWXyL(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool HxgxKbYWKeMOdYrY(java.util.concurrent.atomic.object atomicReference, java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m9373b63a(atomicReference, th);
    }

    public static void HyQeBxMvnVVlpeQX(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void ILPvIfIKeajaeHdc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e p08a3cdb1_p2781571e, java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p08a3cdb1_p2781571e.fail(th, observer, p50dc035cVar);
    }

    public static void IqaQPBfxTgpJBIAV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e p08a3cdb1_p2781571e, io.reactivex.rxjava3.core.Observer observer) {
        p08a3cdb1_p2781571e.errorAll(observer);
    }

    public static java.lang.object JbSWwZXzCChyOnSo(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void JcYzKEQSojDrQCQk(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d JlEhEOmFreRPuAKb() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d.m76ea0beb();
    }

    public static void JmaIMkFabphtdkcs(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e p08a3cdb1_p2781571e, io.reactivex.rxjava3.core.Observer observer) {
        p08a3cdb1_p2781571e.errorAll(observer);
    }

    public static void JpNfJIBMweWCnaWW(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        peef7828dVar.onComplete();
    }

    public static bool KOMqpafoVGeBFvIZ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.delete(p7beea252Var);
    }

    public static void LMIxwhisAEwIEjlX(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static java.lang.int LjJwJXLVNjIfYzke(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int MCpWJRgOnhVVzKIh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e p08a3cdb1_p2781571e) {
        return p08a3cdb1_p2781571e.getAndIncrement();
    }

    public static void MJuIebWJxGuwknbP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e p08a3cdb1_p2781571e, java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p08a3cdb1_p2781571e.fail(th, observer, p50dc035cVar);
    }

    public static bool MKVTXplCbPiuTTSq(java.util.concurrent.atomic.object atomicReference, java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m9373b63a(atomicReference, th);
    }

    public static java.lang.int MqyGBSKrPMdEBEKq(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void MsculWwCCiYlsIhu(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static java.lang.object NmfrLIJyNmdNKcik(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object NvfYOvUFJhiRCZsU(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void PUZeASgWWHbnziJV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e p08a3cdb1_p2781571e) {
        p08a3cdb1_p2781571e.drain();
    }

    public static java.lang.object PhKdLYNLjeZoeDnJ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void PhlcrDpIdfMUeVPe(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool QakuaikGxhxMlALL(java.util.concurrent.atomic.object atomicReference, java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m9373b63a(atomicReference, th);
    }

    public static void QgTjZstoaESqHGom(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static java.lang.object RCsIUvyricHIkgxu(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void REsIOFHIfmZCjnxG(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static void RqdLaaHihNAkVYqo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e p08a3cdb1_p2781571e) {
        p08a3cdb1_p2781571e.drain();
    }

    public static java.lang.object RuEqcbDCpLzceozY(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.util.ICollection SbRPcJEfZYmFNTGs(java.util.Dictionary map) {
        return map.Values;
    }

    public static void SdMOnEoBHfQftcAx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e p08a3cdb1_p2781571e, io.reactivex.rxjava3.core.Observer observer) {
        p08a3cdb1_p2781571e.errorAll(observer);
    }

    public static int UClGRNLtsLAYSMIY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e p08a3cdb1_p2781571e, int i) {
        return p08a3cdb1_p2781571e.addAndGet(i);
    }

    public static void UXUBbsEdgnaHcMct(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        peef7828dVar.onComplete();
    }

    public static bool UjmrnYsJXETatsEW(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Remove(p7beea252Var);
    }

    public static java.lang.object VFULpuVmcTxqZsIq(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object WZoIqgYCvrSweSlt(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static int YHFaXZISKfqusEVd(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static int YnXehBEurYleWxxe(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static void ZfrJUsfoSAztQLZa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e p08a3cdb1_p2781571e, java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p08a3cdb1_p2781571e.fail(th, observer, p50dc035cVar);
    }

    public static void ZuCvXEuFhrOvDciF(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    void cancelAll() {
        SsltyUtTLFGKFqjc(this.f52905679);
    }

    public override void Dispose() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        DFAEcGjVnOimvMeY(this);
        if (mCpWJRgOnhVVzKIh(this) != 0) {
            return;
        }
        QsirkYqfkeHiObOK(this.fa9d1cbf7);
    }

    void drain() {
        if ((13 + 13) % 13 > 0) {
        }
        if (GKDDxxZIEGHGuuDz(this) == 0) {
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> spscLinkedArrayQueue = this.fa9d1cbf7;
            io.reactivex.rxjava3.core.Observer<R> observer = this.fd22a0a80;
            int iUClGRNLtsLAYSMIY = 1;
            while (!this.f38881e0a) {
                if (((java.lang.Exception) RlFxekazzLBQeteL(this.fcb5e100e)) is not null) {
                    QWFJXfiQjEOpcWCq(spscLinkedArrayQueue);
                    JGGcOVewPatQIxkF(this);
                    sdMOnEoBHfQftcAx(this, observer);
                    return;
                }
                bool z = MKEZjtotIlVPRxok(this.fc76a5e84) == 0;
                java.lang.int num = (java.lang.int) HHTDEiPKDJretRiC(spscLinkedArrayQueue);
                bool z2 = num is null;
                if (z && z2) {
                    java.util.IEnumerator itAchhOqBCFEDcRGQL = AchhOqBCFEDcRGQL(sbRPcJEfZYmFNTGs(this.f42c5db7a));
                    while (OerISqnSUxjFjKgN(itAchhOqBCFEDcRGQL)) {
                        uXUBbsEdgnaHcMct((pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d) nvfYOvUFJhiRCZsU(itAchhOqBCFEDcRGQL));
                    }
                    MDFphZZXHFuYygMU(this.f42c5db7a);
                    CclMSdejIYEkSVhG(this.f27b37152);
                    rEsIOFHIfmZCjnxG(this.f52905679);
                    hyQeBxMvnVVlpeQX(observer);
                    return;
                }
                if (z2) {
                    iUClGRNLtsLAYSMIY = uClGRNLtsLAYSMIY(this, -iUClGRNLtsLAYSMIY);
                    if (iUClGRNLtsLAYSMIY == 0) {
                        return;
                    }
                } else {
                    java.lang.object objWZoIqgYCvrSweSlt = wZoIqgYCvrSweSlt(spscLinkedArrayQueue);
                    if (num == f323b32a7) {
                        pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVarJlEhEOmFreRPuAKb = jlEhEOmFreRPuAKb();
                        int i = this.fedc10311;
                        this.fedc10311 = i + 1;
                        jbSWwZXzCChyOnSo(this.f42c5db7a, mqyGBSKrPMdEBEKq(i), peef7828dVarJlEhEOmFreRPuAKb);
                        try {
                            io.reactivex.rxjava3.core.ObservableSource observableSource = (io.reactivex.rxjava3.core.ObservableSource) CkLSbiYrjsCZHARl(ajyjJXrGEnnsIvYU(this.f412d0c77, objWZoIqgYCvrSweSlt), "The leftEnd returned a null ObservableSource");
                            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$ped70e0fb p08a3cdb1_ped70e0fb = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$ped70e0fb(this, true, i);
                            IwmuurFzJFWVvGqw(this.f52905679, p08a3cdb1_ped70e0fb);
                            msculWwCCiYlsIhu(observableSource, p08a3cdb1_ped70e0fb);
                            if (((java.lang.Exception) OWFZKhoYkcSCHwQy(this.fcb5e100e)) is not null) {
                                HEyJykIoWSlOKeDv(spscLinkedArrayQueue);
                                KCLAKQkJcuoWLmWO(this);
                                jmaIMkFabphtdkcs(this, observer);
                                return;
                            } else {
                                try {
                                    lMIxwhisAEwIEjlX(observer, ruEqcbDCpLzceozY(LgNNQwKIcWBNmDoV(this.f63de7122, objWZoIqgYCvrSweSlt, peef7828dVarJlEhEOmFreRPuAKb), "The resultSelector returned a null value"));
                                    java.util.IEnumerator itDwqBqXXeSdapMUQQ = DwqBqXXeSdapMUQQ(adthMXlwjjPXGLpN(this.f27b37152));
                                    while (KjTCcwsmrJRQOdqx(itDwqBqXXeSdapMUQQ)) {
                                        EzCoWQxVDyjpmMuI(peef7828dVarJlEhEOmFreRPuAKb, nmfrLIJyNmdNKcik(itDwqBqXXeSdapMUQQ));
                                    }
                                } catch (java.lang.Exception th) {
                                    mJuIebWJxGuwknbP(this, th, observer, spscLinkedArrayQueue);
                                    return;
                                }
                            }
                        } catch (java.lang.Exception th2) {
                            zfrJUsfoSAztQLZa(this, th2, observer, spscLinkedArrayQueue);
                            return;
                        }
                    } else if (num == f651af744) {
                        int i2 = this.f415e97ed;
                        this.f415e97ed = i2 + 1;
                        phKdLYNLjeZoeDnJ(this.f27b37152, PMNsowOCZCRQyfVW(i2), objWZoIqgYCvrSweSlt);
                        try {
                            io.reactivex.rxjava3.core.ObservableSource observableSource2 = (io.reactivex.rxjava3.core.ObservableSource) OIwMvCEuvFKFTUqx(rCsIUvyricHIkgxu(this.f2fbf087c, objWZoIqgYCvrSweSlt), "The rightEnd returned a null ObservableSource");
                            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$ped70e0fb p08a3cdb1_ped70e0fb2 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$ped70e0fb(this, false, i2);
                            PcuBDomViRGhbrqn(this.f52905679, p08a3cdb1_ped70e0fb2);
                            zuCvXEuFhrOvDciF(observableSource2, p08a3cdb1_ped70e0fb2);
                            if (((java.lang.Exception) VHTuCsTidZumBLaM(this.fcb5e100e)) is not null) {
                                jcYzKEQSojDrQCQk(spscLinkedArrayQueue);
                                BQOysgIBDjNLDEff(this);
                                GNfIMZThnaVPMvRZ(this, observer);
                                return;
                            } else {
                                java.util.IEnumerator itRHMbLmBAXPsWifJb = RHMbLmBAXPsWifJb(BlRGQLZfQWTtRHCQ(this.f42c5db7a));
                                while (YkGTKsmElREVWVXV(itRHMbLmBAXPsWifJb)) {
                                    OWhyeNtWYLvjxplU((pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d) vFULpuVmcTxqZsIq(itRHMbLmBAXPsWifJb), objWZoIqgYCvrSweSlt);
                                }
                            }
                        } catch (java.lang.Exception th3) {
                            iLPvIfIKeajaeHdc(this, th3, observer, spscLinkedArrayQueue);
                            return;
                        }
                    } else if (num != f65f10819) {
                        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$ped70e0fb p08a3cdb1_ped70e0fb3 = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$ped70e0fb) objWZoIqgYCvrSweSlt;
                        IDDUtBiVZaFxmHAj(this.f27b37152, GBRgpdngKkDcmQtM(p08a3cdb1_ped70e0fb3.f6a992d55));
                        CxJGDoTElypuXEyu(this.f52905679, p08a3cdb1_ped70e0fb3);
                    } else {
                        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$ped70e0fb p08a3cdb1_ped70e0fb4 = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$ped70e0fb) objWZoIqgYCvrSweSlt;
                        pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar = (pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d) hgksEKDRdVljSqBx(this.f42c5db7a, XPWdVrPAiMLZWXQt(p08a3cdb1_ped70e0fb4.f6a992d55));
                        ujmrnYsJXETatsEW(this.f52905679, p08a3cdb1_ped70e0fb4);
                        if (peef7828dVar is not null) {
                            jpNfJIBMweWCnaWW(peef7828dVar);
                        }
                    }
                }
            }
            qgTjZstoaESqHGom(spscLinkedArrayQueue);
        }
    }

    void errorAll(io.reactivex.rxjava3.core.Observer<object> observer) {
        if ((13 + 24) % 24 > 0) {
        }
        java.lang.Exception thQUuDLTnvssSbbXSe = QUuDLTnvssSbbXSe(this.fcb5e100e);
        java.util.IEnumerator itRycXPdVUScbUMHzK = RycXPdVUScbUMHzK(euxfWZIPHYGpfuzF(this.f42c5db7a));
        while (AhdkHBqSMiamtYeQ(itRycXPdVUScbUMHzK)) {
            AcpgrHZCCpvYfnLV((pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d) ailwgGukaoXUHGgf(itRycXPdVUScbUMHzK), thQUuDLTnvssSbbXSe);
        }
        VBkmPqWylYjVAEyl(this.f42c5db7a);
        XcfCfiuIFIepRECm(this.f27b37152);
        gBaabJCIbpeGPAvF(observer, thQUuDLTnvssSbbXSe);
    }

    void fail(java.lang.Exception th, io.reactivex.rxjava3.core.Observer<object> observer, io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<object> spscLinkedArrayQueue) {
        JRvSpurHtOXJQXIq(th);
        qakuaikGxhxMlALL(this.fcb5e100e, th);
        heToxLuctPyRwglh(spscLinkedArrayQueue);
        EGeeHCYKybuhFxZP(this);
        iqaQPBfxTgpJBIAV(this, observer);
    }

    public override void InnerClose(bool z, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$ped70e0fb p08a3cdb1_ped70e0fb) {
        lock (this) {
            try {
                EbqqeeoQFSTTENgk(this.fa9d1cbf7, z ? f65f10819 : fd902d608, p08a3cdb1_ped70e0fb);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        DnjbpuGqDUsiiXCe(this);
    }

    public override void InnerCloseError(java.lang.Exception th) {
        if (mKVTXplCbPiuTTSq(this.fcb5e100e, th)) {
            pUZeASgWWHbnziJV(this);
        } else {
            phlcrDpIdfMUeVPe(th);
        }
    }

    public override void InnerComplete(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p27e40df6 p08a3cdb1_p27e40df6) {
        kOMqpafoVGeBFvIZ(this.f52905679, p08a3cdb1_p27e40df6);
        yHFaXZISKfqusEVd(this.fc76a5e84);
        rqdLaaHihNAkVYqo(this);
    }

    public override void InnerError(java.lang.Exception th) {
        if (!hxgxKbYWKeMOdYrY(this.fcb5e100e, th)) {
            QDejrCGqQNIfqJpV(th);
        } else {
            ynXehBEurYleWxxe(this.fc76a5e84);
            LpMTbzTfIpSPXUob(this);
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
            goto L22
        L4:
            throw r2
        L5:
            goto L30
        L9:
            return
        La:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> La
            goto L4
        L10:
            monitor-enter(r1)
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object> r0 = r1.fa9d1cbf7     // Catch: java.lang.Exception -> La
            if (r2 == 0) goto L18
            java.lang.int r2 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e.f323b32a7     // Catch: java.lang.Exception -> La
            goto L1a
        L18:
            java.lang.int r2 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e.f651af744     // Catch: java.lang.Exception -> La
        L1a:
            KuayQnzOmIfNhibC(r0, r2, r3)     // Catch: java.lang.Exception -> La
            monitor-exit(r1)     // Catch: java.lang.Exception -> La
            goto L29
        L22:
            goto L5
        L25:
            goto L10
        L29:
            bbQpgWjQJNvVHJkb(r1)
            goto L9
        L30:
            goto L25
        */
        throw new UnsupportedOperationException("Method not decompiled: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p08a3cdb1$p2781571e.innerValue(bool, java.lang.object):void");
    }

    public override bool IsDisposed() {
        return this.f38881e0a;
    }
}

