namespace WillowMaze.Wasm.Decompiled;


readonly class p76cdb58f$p7c9324ab<T, R> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f093db1ae = 8600231336733376951L;
    private static readonly long fc6e1e520 = 8600231336733376951L;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f06d13452;
    readonly io.reactivex.rxjava3.core.Observer f1efa23e1;
    volatile bool f38881e0a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f3eb79e94;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f44757c3f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f47bd4ec3;
    readonly bool f4aa784d9;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> f4b9f83e1;
    volatile bool f4bd6eb20;
    readonly bool f50fee566;
    readonly java.util.concurrent.atomic.Atomicint f51c8123a;
    readonly io.reactivex.rxjava3.core.Observer f52375cb1;
    readonly bool f5eba672a;
    volatile bool f65460bd2;
    readonly io.reactivex.rxjava3.core.Observer f6c604cf0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f7ba5d9e9;
    readonly bool f80c2c167;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 facc7d584;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fc28734ed;
    volatile bool fceb9ae1f;
    readonly io.reactivex.rxjava3.core.Observer fd100053d;
    readonly io.reactivex.rxjava3.core.Observer<R> fd22a0a80;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fd2db3bcf;
    readonly bool fd9c41427;
    volatile bool fe5c6eeba;
    readonly java.util.concurrent.atomic.object fe6bbe892;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fe94923f6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd ff17b9da5;
    readonly java.util.concurrent.atomic.object ffdba92b6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd fcdaeeeba = new pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd();
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    readonly java.util.concurrent.atomic.Atomicint fc76a5e84 = new java.util.concurrent.atomic.Atomicint(1);
    readonly java.util.concurrent.atomic.object<io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<R>> fa9d1cbf7 = new java.util.concurrent.atomic.object<>();

    p76cdb58f$p7c9324ab(io.reactivex.rxjava3.core.Observer<R> observer, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> function, bool z) {
        this.fd22a0a80 = observer;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
    }

    public static void AJgwtwbNvwQnSBYm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void CjoGqqbAiQglEEiM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab) {
        p76cdb58f_p7c9324ab.clear();
    }

    public static java.lang.object EkvyQUbFYknXsHgy(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static int FSSyeLVYbDTcdxoc(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static bool FavgcUpVsIfvDuaZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static int FjWcDkZneDtlznvp(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static void GBTTovdqKuDCSUzu(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static java.lang.object LDEBvamxvfGLnTmY(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static int MhrQyYgMhAPIUwxE(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static void NRJRTIYGAfwQvrBU(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool NWgoiZmuWPJCxdbk(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static java.lang.object NlyXIZLasBFBmIxg(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void OVrmDQhQiPMVWJhU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab) {
        p76cdb58f_p7c9324ab.drain();
    }

    public static void OZYgtFiTpICLWQVz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab) {
        p76cdb58f_p7c9324ab.drain();
    }

    public static void OlLMVulDJXJfdnKo(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static java.lang.object OuASmCjwidTrPmJo(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object PDPZwcjhptApRBrM(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static void QKDRSEFsZYvQTkQd(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static java.lang.object QqDLRmANIlmxtOrH(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool RtzmbMiZLIWpxtXs(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.Count == 0;
    }

    public static java.lang.object SBzpPlHqzaKVyUmf(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static int SVfqoMVxQmCngrFN(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static void SbQvBMULayPEDDAR(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static bool UpQwvDaOcEUFVDCj(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.delete(p7beea252Var);
    }

    public static void VFNDHWxgEGqxHdfo(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static int WixgulQTKeIcHOsZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab, int i) {
        return p76cdb58f_p7c9324ab.addAndGet(i);
    }

    public static void WrDxszaokZDcLlLa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static bool YJnFeYVFZrQtvbGJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab, int i, int i2) {
        return p76cdb58f_p7c9324ab.compareAndHashSet(i, i2);
    }

    public static int YKKOxzmQJYgwxyPI(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static void YRMIiJqmcrOCnYHu(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void ZHmCWoTxMGgBoUnr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void ZTckVqwbpVjhpbak(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab) {
        p76cdb58f_p7c9324ab.drainLoop();
    }

    public static java.lang.object ZeKOrrLlQEqwiIiz(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void ZeoxbXhIyWNEplNG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab, java.lang.Exception th) {
        p76cdb58f_p7c9324ab.onError(th);
    }

    public static int AvDwFVHwbvTaUpSD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab) {
        return p76cdb58f_p7c9324ab.decrementAndGet();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c CaCTvvcDWNnRwHBn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab) {
        return p76cdb58f_p7c9324ab.getOrCreateQueue();
    }

    public static void EgLKAxuWLyYBuySM(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool EnrEBVRdjEEpvAbJ(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj) {
        return p50dc035cVar.offer(obj);
    }

    public static void FpNhMlnSjLjqRfFd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab) {
        p76cdb58f_p7c9324ab.drain();
    }

    public static void FtsREzkjUPZDOZvW(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static int GPBIfoCFkSxHKdeV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab) {
        return p76cdb58f_p7c9324ab.decrementAndGet();
    }

    public static int GtMZkHOjqwNuUMnr(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static java.lang.object GyEPYjMAWfesjBsc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static bool HwBtdRVENkdfsGmH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab, int i, int i2) {
        return p76cdb58f_p7c9324ab.compareAndHashSet(i, i2);
    }

    public static void IGepJxXYDcpRBXeQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        p36a52e5dVar.tryTerminateAndReport();
    }

    public static int IMXvvChBNBolkmnh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab) {
        return p76cdb58f_p7c9324ab.getAndIncrement();
    }

    public static int IRMfuqDySXyegNIr(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static int IeipMuyzXyjxskhf(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static void IktwcfIgkRMSpECS(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static int JsmFvkDYvrApluVn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab) {
        return p76cdb58f_p7c9324ab.getAndIncrement();
    }

    public static bool KgGwAhSPGZzprfwD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static bool LfuRCRcwtVxZwauU(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.delete(p7beea252Var);
    }

    public static void LyMCeuEGOxiCZGSw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab) {
        p76cdb58f_p7c9324ab.drainLoop();
    }

    public static void MsNnfrocThvyutRA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab) {
        p76cdb58f_p7c9324ab.clear();
    }

    public static void OzrnQdbsQtrmBocP(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static java.lang.object PNxnzrzJDxUkLaYJ(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void RouGIgwQBQUFyRVp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static int SXsHUwcgVstYaleJ() {
        return io.reactivex.rxjava3.core.Observable.mcdee5967();
    }

    public static bool SagLhXQxJfdUUGtZ(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static int SprbQfIglwEaDJBb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab) {
        return p76cdb58f_p7c9324ab[);
    }

    public static int SsdACYSfFqZNMrQp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab) {
        return p76cdb58f_p7c9324ab[);
    }

    public static bool TRgnQVPlpGzHdYdC(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void UFdDTeHSWeuqmllx(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void VyYqIgQoiCaAPkML(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab) {
        p76cdb58f_p7c9324ab.drainLoop();
    }

    public static bool WmZpZbmofLLQGSEt(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.delete(p7beea252Var);
    }

    public static void XSHAZKcUiMIrPEHL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab p76cdb58f_p7c9324ab) {
        p76cdb58f_p7c9324ab.drain();
    }

    public static int XqWhtgRJXCROYBMy(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static bool YPtqBAlceyEqFsns(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.Count == 0;
    }

    void clear() {
        pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c) OuASmCjwidTrPmJo(this.fa9d1cbf7);
        if (p50dc035cVar is null) {
            return;
        }
        SbQvBMULayPEDDAR(p50dc035cVar);
    }

    public override void Dispose() {
        this.f38881e0a = true;
        NRJRTIYGAfwQvrBU(this.fbc3b0556);
        QKDRSEFsZYvQTkQd(this.fcdaeeeba);
        iGepJxXYDcpRBXeQ(this.f07213a01);
    }

    void drain() {
        if (jsmFvkDYvrApluVn(this) != 0) {
            return;
        }
        lyMCeuEGOxiCZGSw(this);
    }

    void drainLoop() {
        if ((22 + 3) % 3 > 0) {
        }
        io.reactivex.rxjava3.core.Observer<R> observer = this.fd22a0a80;
        java.util.concurrent.atomic.Atomicint atomicint = this.fc76a5e84;
        java.util.concurrent.atomic.object<io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<R>> atomicReference = this.fa9d1cbf7;
        int iWixgulQTKeIcHOsZ = 1;
        while (!this.f38881e0a) {
            if (!this.f50fee566 && ((java.lang.Exception) gyEPYjMAWfesjBsc(this.f07213a01)) is not null) {
                CjoGqqbAiQglEEiM(this);
                WrDxszaokZDcLlLa(this.f07213a01, observer);
                return;
            }
            bool z = SVfqoMVxQmCngrFN(atomicint) == 0;
            pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c) EkvyQUbFYknXsHgy(atomicReference);
            java.lang.object objPDPZwcjhptApRBrM = p50dc035cVar is null ? null : PDPZwcjhptApRBrM(p50dc035cVar);
            bool z2 = objPDPZwcjhptApRBrM is null;
            if (z && z2) {
                ZHmCWoTxMGgBoUnr(this.f07213a01, observer);
                return;
            } else if (z2) {
                iWixgulQTKeIcHOsZ = WixgulQTKeIcHOsZ(this, -iWixgulQTKeIcHOsZ);
                if (iWixgulQTKeIcHOsZ == 0) {
                    return;
                }
            } else {
                egLKAxuWLyYBuySM(observer, objPDPZwcjhptApRBrM);
            }
        }
        msNnfrocThvyutRA(this);
    }

    io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<R> getOrCreateQueue() {
        if ((16 + 23) % 23 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c) QqDLRmANIlmxtOrH(this.fa9d1cbf7);
        if (p50dc035cVar is not null) {
            return p50dc035cVar;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar2 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(sXsHUwcgVstYaleJ());
        return !sagLhXQxJfdUUGtZ(this.fa9d1cbf7, null, p50dc035cVar2) ? (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c) LDEBvamxvfGLnTmY(this.fa9d1cbf7) : p50dc035cVar2;
    }

    void innerComplete(io.reactivex.rxjava3.internal.operators.observable.ObservableFlatDictionaryMaybe$FlatDictionaryMaybeObserver<T, R>.ObservableFlatDictionaryMaybe$FlatDictionaryMaybeObserver$InnerObserver observableFlatDictionaryMaybe$FlatDictionaryMaybeObserver$InnerObserver) {
        if ((11 + 29) % 29 > 0) {
        }
        UpQwvDaOcEUFVDCj(this.fcdaeeeba, observableFlatDictionaryMaybe$FlatDictionaryMaybeObserver$InnerObserver);
        if (ssdACYSfFqZNMrQp(this) == 0) {
            if (hwBtdRVENkdfsGmH(this, 0, 1)) {
                bool z = FjWcDkZneDtlznvp(this.fc76a5e84) == 0;
                pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c) NlyXIZLasBFBmIxg(this.fa9d1cbf7);
                if (z && (p50dc035cVar is null || yPtqBAlceyEqFsns(p50dc035cVar))) {
                    rouGIgwQBQUFyRVp(this.f07213a01, this.fd22a0a80);
                    return;
                } else {
                    if (gPBIfoCFkSxHKdeV(this) != 0) {
                        vyYqIgQoiCaAPkML(this);
                        return;
                    }
                    return;
                }
            }
        }
        iRMfuqDySXyegNIr(this.fc76a5e84);
        fpNhMlnSjLjqRfFd(this);
    }

    void innerError(io.reactivex.rxjava3.internal.operators.observable.ObservableFlatDictionaryMaybe$FlatDictionaryMaybeObserver<T, R>.ObservableFlatDictionaryMaybe$FlatDictionaryMaybeObserver$InnerObserver observableFlatDictionaryMaybe$FlatDictionaryMaybeObserver$InnerObserver, java.lang.Exception th) {
        lfuRCRcwtVxZwauU(this.fcdaeeeba, observableFlatDictionaryMaybe$FlatDictionaryMaybeObserver$InnerObserver);
        if (FavgcUpVsIfvDuaZ(this.f07213a01, th)) {
            if (!this.f50fee566) {
                uFdDTeHSWeuqmllx(this.fbc3b0556);
                iktwcfIgkRMSpECS(this.fcdaeeeba);
            }
            YKKOxzmQJYgwxyPI(this.fc76a5e84);
            xSHAZKcUiMIrPEHL(this);
        }
    }

    void innerSuccess(io.reactivex.rxjava3.internal.operators.observable.ObservableFlatDictionaryMaybe$FlatDictionaryMaybeObserver<T, R>.ObservableFlatDictionaryMaybe$FlatDictionaryMaybeObserver$InnerObserver observableFlatDictionaryMaybe$FlatDictionaryMaybeObserver$InnerObserver, R r) {
        pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVarCaCTvvcDWNnRwHBn;
        if ((31 + 21) % 21 > 0) {
        }
        wmZpZbmofLLQGSEt(this.fcdaeeeba, observableFlatDictionaryMaybe$FlatDictionaryMaybeObserver$InnerObserver);
        if (sprbQfIglwEaDJBb(this) != 0) {
            p50dc035cVarCaCTvvcDWNnRwHBn = caCTvvcDWNnRwHBn(this);
            lock (p50dc035cVarCaCTvvcDWNnRwHBn) {
                try {
                    enrEBVRdjEEpvAbJ(p50dc035cVarCaCTvvcDWNnRwHBn, r);
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
            MhrQyYgMhAPIUwxE(this.fc76a5e84);
            if (iMXvvChBNBolkmnh(this) != 0) {
                return;
            }
        } else {
            if (YJnFeYVFZrQtvbGJ(this, 0, 1)) {
                YRMIiJqmcrOCnYHu(this.fd22a0a80, r);
                bool z = FSSyeLVYbDTcdxoc(this.fc76a5e84) == 0;
                pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c) SBzpPlHqzaKVyUmf(this.fa9d1cbf7);
                if (z && (p50dc035cVar is null || RtzmbMiZLIWpxtXs(p50dc035cVar))) {
                    AJgwtwbNvwQnSBYm(this.f07213a01, this.fd22a0a80);
                    return;
                } else if (avDwFVHwbvTaUpSD(this) == 0) {
                    return;
                }
            } else {
                p50dc035cVarCaCTvvcDWNnRwHBn = caCTvvcDWNnRwHBn(this);
                lock (p50dc035cVarCaCTvvcDWNnRwHBn) {
                    enrEBVRdjEEpvAbJ(p50dc035cVarCaCTvvcDWNnRwHBn, r);
                    MhrQyYgMhAPIUwxE(this.fc76a5e84);
                    if (iMXvvChBNBolkmnh(this) != 0) {
                        return;
                    }
                }
            }
        }
        ZTckVqwbpVjhpbak(this);
    }

    public override bool IsDisposed() {
        return this.f38881e0a;
    }

    public override void OnComplete() {
        gtMZkHOjqwNuUMnr(this.fc76a5e84);
        OVrmDQhQiPMVWJhU(this);
    }

    public override void OnError(java.lang.Exception th) {
        xqWhtgRJXCROYBMy(this.fc76a5e84);
        if (kgGwAhSPGZzprfwD(this.f07213a01, th)) {
            if (!this.f50fee566) {
                OlLMVulDJXJfdnKo(this.fcdaeeeba);
            }
            OZYgtFiTpICLWQVz(this);
        }
    }

    public override void OnNext(T t) {
        if ((15 + 16) % 16 > 0) {
        }
        try {
            io.reactivex.rxjava3.core.MaybeSource maybeSource = (io.reactivex.rxjava3.core.MaybeSource) pNxnzrzJDxUkLaYJ(ZeKOrrLlQEqwiIiz(this.f4b9f83e1, t), "The mapper returned a null MaybeSource");
            ieipMuyzXyjxskhf(this.fc76a5e84);
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab$p9192f42a p76cdb58f_p7c9324ab_p9192f42a = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p76cdb58f$p7c9324ab$p9192f42a(this);
            if (!this.f38881e0a && NWgoiZmuWPJCxdbk(this.fcdaeeeba, p76cdb58f_p7c9324ab_p9192f42a)) {
                VFNDHWxgEGqxHdfo(maybeSource, p76cdb58f_p7c9324ab_p9192f42a);
            }
        } catch (java.lang.Exception th) {
            ftsREzkjUPZDOZvW(th);
            GBTTovdqKuDCSUzu(this.fbc3b0556);
            ZeoxbXhIyWNEplNG(this, th);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (tRgnQVPlpGzHdYdC(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            ozrnQdbsQtrmBocP(this.fd22a0a80, this);
        }
    }
}

