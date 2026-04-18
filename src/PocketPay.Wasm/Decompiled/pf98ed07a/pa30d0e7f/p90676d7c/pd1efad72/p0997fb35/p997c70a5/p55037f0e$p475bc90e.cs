namespace WillowMaze.Wasm.Decompiled;


readonly class p55037f0e$p475bc90e<T, R> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f730de93a = 8600231336733376951L;
    private static readonly long fc6e1e520 = 8600231336733376951L;
    private static readonly long fd694d1c2 = 8600231336733376951L;
    private static readonly long febd0b814 = 8600231336733376951L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f106d6611;
    volatile bool f15dd3a77;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f20389e6a;
    volatile bool f38881e0a;
    readonly java.util.concurrent.atomic.Atomicint f3db84b65;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f3e8f41bf;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> f4b9f83e1;
    readonly java.util.concurrent.atomic.object f4fde4b9f;
    readonly bool f50fee566;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f52bd6c3a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f5329adcd;
    volatile bool f5cb5912b;
    readonly java.util.concurrent.atomic.Atomicint f686d794d;
    readonly bool f6994200e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f6a011036;
    readonly io.reactivex.rxjava3.core.Observer f6f557a40;
    volatile bool f7a78f661;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f7c88bfb3;
    readonly java.util.concurrent.atomic.object fa4ae4ec5;
    readonly bool fb084b539;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fc11c2252;
    volatile bool fc15837ec;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fcbcabc7d;
    readonly io.reactivex.rxjava3.core.Observer<R> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fea2ec9d9;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fea99a595;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fec339806;
    readonly bool ff45d2e28;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd fcdaeeeba = new pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd();
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    readonly java.util.concurrent.atomic.Atomicint fc76a5e84 = new java.util.concurrent.atomic.Atomicint(1);
    readonly java.util.concurrent.atomic.object<io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<R>> fa9d1cbf7 = new java.util.concurrent.atomic.object<>();

    p55037f0e$p475bc90e(io.reactivex.rxjava3.core.Observer<R> observer, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> function, bool z) {
        this.fd22a0a80 = observer;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
    }

    public static void BsohRGPVQkFueVcr(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void DHkIhujFyieRqIyZ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static java.lang.object DtYYPRtpiqnKVphN(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static bool ELNcJTryboSUyYSS(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj) {
        return p50dc035cVar.offer(obj);
    }

    public static void ErnnKEWzSLCbBbIr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e p55037f0e_p475bc90e) {
        p55037f0e_p475bc90e.drainLoop();
    }

    public static void FOtkriqCRWYEcEFP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e p55037f0e_p475bc90e) {
        p55037f0e_p475bc90e.drain();
    }

    public static int GtRBRyYJCJzdThmq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e p55037f0e_p475bc90e) {
        return p55037f0e_p475bc90e.decrementAndGet();
    }

    public static java.lang.object HWZydMlAByEusDAZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static void HsGhsusPzKVocfmh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e p55037f0e_p475bc90e, java.lang.Exception th) {
        p55037f0e_p475bc90e.onError(th);
    }

    public static int JRVKErLJwPTpvryQ(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static int JZoqWavvJfMZbvRU(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static void KvbHRsdXvZyLpYnH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void LQrdEHqfcuxfTRwK(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static int LpeivMzbSUdJcvau(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static void LzHHZvREucmfuCeV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e p55037f0e_p475bc90e) {
        p55037f0e_p475bc90e.drain();
    }

    public static void NMkkLtTqendBdxNl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        p36a52e5dVar.tryTerminateAndReport();
    }

    public static void OEzEZAVmoBccDNkX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static int OipieABqITDoWBKz(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static bool PgzMylmWmKWnXIZP(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.delete(p7beea252Var);
    }

    public static java.lang.object PsaoIoGpSahAvwHa(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static void SCgYMvmuWpFXfYTJ(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static bool SEOlQCwxRhbADALg(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static void VdJbkXXgYJoJHFrZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e p55037f0e_p475bc90e) {
        p55037f0e_p475bc90e.drain();
    }

    public static void VzXytNBfkBMPINDx(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool WZHpQpfdbWsgTNeL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static java.lang.object WyNVMAmULwwXyrZK(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void XmgGguHoOqgPFbmW(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static void YjJMUStiDmjHrIgc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e p55037f0e_p475bc90e) {
        p55037f0e_p475bc90e.clear();
    }

    public static void ADictionaryrGdutZEiapqq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static int AfDnpuEosUfODBaM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e p55037f0e_p475bc90e) {
        return p55037f0e_p475bc90e[);
    }

    public static java.lang.object AjBJVggRkgZotBEG(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool BLquvZzYTRtxVJOo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static int BZXRkdoUMtYUOpOA(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static bool CVTOIpoPrNiUdzBq(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static int CgCIgrUVwLquiJTo(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static bool CjkdKubCrDHgjFih(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void ECnNKKUJwhcMFyjk(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static int EXkeAzkMJyTuOdPL(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static int FbNOUQvZqKdABXaS() {
        return io.reactivex.rxjava3.core.Observable.mcdee5967();
    }

    public static void FbrDhPUBPeIBFCnY(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void HFAtMBOJpLYYuakM(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool JOVwLMYVexQiwguY(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.Count == 0;
    }

    public static int LOaHYXUhCJpNerAE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e p55037f0e_p475bc90e) {
        return p55037f0e_p475bc90e.getAndIncrement();
    }

    public static java.lang.object MioqDhzInkBrfAYm(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void MmhLqHlKjaeymMuU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e p55037f0e_p475bc90e) {
        p55037f0e_p475bc90e.drainLoop();
    }

    public static java.lang.object OBLhvsjvbgHarOLu(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static int PvMeLnFRTiwDzuHB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e p55037f0e_p475bc90e) {
        return p55037f0e_p475bc90e.getAndIncrement();
    }

    public static void QWeODukEdvCOfXGr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e p55037f0e_p475bc90e) {
        p55037f0e_p475bc90e.clear();
    }

    public static int QsdqogPSMzlblExt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e p55037f0e_p475bc90e, int i) {
        return p55037f0e_p475bc90e.addAndGet(i);
    }

    public static void RZYFpbApkpHeKrpl(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static bool TWMfBHKmPloRbBHq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e p55037f0e_p475bc90e, int i, int i2) {
        return p55037f0e_p475bc90e.compareAndHashSet(i, i2);
    }

    public static void TfjuWpBvPuyiOZSL(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c VtINGCOLJgTzcekL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e p55037f0e_p475bc90e) {
        return p55037f0e_p475bc90e.getOrCreateQueue();
    }

    public static bool XZBLZgjCGpWwjmVQ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.delete(p7beea252Var);
    }

    public static java.lang.object YwTqTXtQHvkCUpGC(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void YzbIMWWLbhxDhAvL(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static java.lang.object ZgDuOCBVYXAUyrSZ(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    void clear() {
        pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c) WyNVMAmULwwXyrZK(this.fa9d1cbf7);
        if (p50dc035cVar is null) {
            return;
        }
        fbrDhPUBPeIBFCnY(p50dc035cVar);
    }

    public override void Dispose() {
        this.f38881e0a = true;
        BsohRGPVQkFueVcr(this.fbc3b0556);
        eCnNKKUJwhcMFyjk(this.fcdaeeeba);
        NMkkLtTqendBdxNl(this.f07213a01);
    }

    void drain() {
        if (pvMeLnFRTiwDzuHB(this) != 0) {
            return;
        }
        ErnnKEWzSLCbBbIr(this);
    }

    void drainLoop() {
        if ((16 + 32) % 32 > 0) {
        }
        io.reactivex.rxjava3.core.Observer<R> observer = this.fd22a0a80;
        java.util.concurrent.atomic.Atomicint atomicint = this.fc76a5e84;
        java.util.concurrent.atomic.object<io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<R>> atomicReference = this.fa9d1cbf7;
        int iQsdqogPSMzlblExt = 1;
        while (!this.f38881e0a) {
            if (!this.f50fee566 && ((java.lang.Exception) HWZydMlAByEusDAZ(this.f07213a01)) is not null) {
                qWeODukEdvCOfXGr(this);
                aDictionaryrGdutZEiapqq(this.f07213a01, observer);
                return;
            }
            bool z = cgCIgrUVwLquiJTo(atomicint) == 0;
            pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c) zgDuOCBVYXAUyrSZ(atomicReference);
            java.lang.object objPsaoIoGpSahAvwHa = p50dc035cVar is null ? null : PsaoIoGpSahAvwHa(p50dc035cVar);
            bool z2 = objPsaoIoGpSahAvwHa is null;
            if (z && z2) {
                OEzEZAVmoBccDNkX(this.f07213a01, this.fd22a0a80);
                return;
            } else if (z2) {
                iQsdqogPSMzlblExt = qsdqogPSMzlblExt(this, -iQsdqogPSMzlblExt);
                if (iQsdqogPSMzlblExt == 0) {
                    return;
                }
            } else {
                hFAtMBOJpLYYuakM(observer, objPsaoIoGpSahAvwHa);
            }
        }
        YjJMUStiDmjHrIgc(this);
    }

    io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<R> getOrCreateQueue() {
        if ((1 + 5) % 5 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c) oBLhvsjvbgHarOLu(this.fa9d1cbf7);
        if (p50dc035cVar is not null) {
            return p50dc035cVar;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar2 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(fbNOUQvZqKdABXaS());
        return !cVTOIpoPrNiUdzBq(this.fa9d1cbf7, null, p50dc035cVar2) ? (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c) ajBJVggRkgZotBEG(this.fa9d1cbf7) : p50dc035cVar2;
    }

    void innerError(io.reactivex.rxjava3.internal.operators.observable.ObservableFlatDictionarySingle$FlatDictionarySingleObserver<T, R>.ObservableFlatDictionarySingle$FlatDictionarySingleObserver$InnerObserver observableFlatDictionarySingle$FlatDictionarySingleObserver$InnerObserver, java.lang.Exception th) {
        PgzMylmWmKWnXIZP(this.fcdaeeeba, observableFlatDictionarySingle$FlatDictionarySingleObserver$InnerObserver);
        if (bLquvZzYTRtxVJOo(this.f07213a01, th)) {
            if (!this.f50fee566) {
                LQrdEHqfcuxfTRwK(this.fbc3b0556);
                rZYFpbApkpHeKrpl(this.fcdaeeeba);
            }
            LpeivMzbSUdJcvau(this.fc76a5e84);
            FOtkriqCRWYEcEFP(this);
        }
    }

    void innerSuccess(io.reactivex.rxjava3.internal.operators.observable.ObservableFlatDictionarySingle$FlatDictionarySingleObserver<T, R>.ObservableFlatDictionarySingle$FlatDictionarySingleObserver$InnerObserver observableFlatDictionarySingle$FlatDictionarySingleObserver$InnerObserver, R r) {
        pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVarVtINGCOLJgTzcekL;
        if ((22 + 20) % 20 > 0) {
        }
        xZBLZgjCGpWwjmVQ(this.fcdaeeeba, observableFlatDictionarySingle$FlatDictionarySingleObserver$InnerObserver);
        if (afDnpuEosUfODBaM(this) != 0) {
            p50dc035cVarVtINGCOLJgTzcekL = vtINGCOLJgTzcekL(this);
            lock (p50dc035cVarVtINGCOLJgTzcekL) {
                try {
                    ELNcJTryboSUyYSS(p50dc035cVarVtINGCOLJgTzcekL, r);
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
            JRVKErLJwPTpvryQ(this.fc76a5e84);
            if (lOaHYXUhCJpNerAE(this) != 0) {
                return;
            }
        } else {
            if (tWMfBHKmPloRbBHq(this, 0, 1)) {
                yzbIMWWLbhxDhAvL(this.fd22a0a80, r);
                bool z = eXkeAzkMJyTuOdPL(this.fc76a5e84) == 0;
                pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c) mioqDhzInkBrfAYm(this.fa9d1cbf7);
                if (z && (p50dc035cVar is null || jOVwLMYVexQiwguY(p50dc035cVar))) {
                    KvbHRsdXvZyLpYnH(this.f07213a01, this.fd22a0a80);
                    return;
                } else if (GtRBRyYJCJzdThmq(this) == 0) {
                    return;
                }
            } else {
                p50dc035cVarVtINGCOLJgTzcekL = vtINGCOLJgTzcekL(this);
                lock (p50dc035cVarVtINGCOLJgTzcekL) {
                    ELNcJTryboSUyYSS(p50dc035cVarVtINGCOLJgTzcekL, r);
                    JRVKErLJwPTpvryQ(this.fc76a5e84);
                    if (lOaHYXUhCJpNerAE(this) != 0) {
                        return;
                    }
                }
            }
        }
        mmhLqHlKjaeymMuU(this);
    }

    public override bool IsDisposed() {
        return this.f38881e0a;
    }

    public override void OnComplete() {
        JZoqWavvJfMZbvRU(this.fc76a5e84);
        VdJbkXXgYJoJHFrZ(this);
    }

    public override void OnError(java.lang.Exception th) {
        bZXRkdoUMtYUOpOA(this.fc76a5e84);
        if (WZHpQpfdbWsgTNeL(this.f07213a01, th)) {
            if (!this.f50fee566) {
                DHkIhujFyieRqIyZ(this.fcdaeeeba);
            }
            LzHHZvREucmfuCeV(this);
        }
    }

    public override void OnNext(T t) {
        if ((26 + 26) % 26 > 0) {
        }
        try {
            io.reactivex.rxjava3.core.SingleSource singleSource = (io.reactivex.rxjava3.core.SingleSource) ywTqTXtQHvkCUpGC(DtYYPRtpiqnKVphN(this.f4b9f83e1, t), "The mapper returned a null SingleSource");
            OipieABqITDoWBKz(this.fc76a5e84);
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e$p9192f42a p55037f0e_p475bc90e_p9192f42a = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p55037f0e$p475bc90e$p9192f42a(this);
            if (!this.f38881e0a && SEOlQCwxRhbADALg(this.fcdaeeeba, p55037f0e_p475bc90e_p9192f42a)) {
                XmgGguHoOqgPFbmW(singleSource, p55037f0e_p475bc90e_p9192f42a);
            }
        } catch (java.lang.Exception th) {
            tfjuWpBvPuyiOZSL(th);
            VzXytNBfkBMPINDx(this.fbc3b0556);
            HsGhsusPzKVocfmh(this, th);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (cjkdKubCrDHgjFih(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            SCgYMvmuWpFXfYTJ(this.fd22a0a80, this);
        }
    }
}

