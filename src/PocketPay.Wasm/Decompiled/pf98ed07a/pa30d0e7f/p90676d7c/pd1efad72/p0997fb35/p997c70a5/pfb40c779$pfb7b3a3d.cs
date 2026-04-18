namespace WillowMaze.Wasm.Decompiled;


readonly class pfb40c779$pfb7b3a3d<T, C : java.util.ICollection<T>, Open, Close> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f1d7b01f5 = -8466418554264089604L;
    private static readonly long fc6e1e520 = -8466418554264089604L;
    private static readonly long fd83a4d0f = -8466418554264089604L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f1540ba7a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f23c6afeb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f269ef2d0;
    long f331bca06;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f37c0a869;
    volatile bool f38881e0a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f38b519bb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f392771f3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f397d67ea;
    readonly io.reactivex.rxjava3.core.ObservableSource f3c69c259;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f3d5d0ea7;
    long f471e0d51;
    readonly io.reactivex.rxjava3.functions.Supplier<C> f4af2b822;
    volatile bool f54cd67c2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f67394023;
    readonly java.util.concurrent.atomic.object f68ec6348;
    long f6a992d55;
    volatile bool f6b2ded51;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f6bd33b88;
    long f6cb429b8;
    volatile bool f6d14a8b8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f6dc52c1f;
    volatile bool f78446919;
    readonly io.reactivex.rxjava3.core.ObservableSource f96862d6f;
    readonly io.reactivex.rxjava3.functions.Function<? super Open, ? : io.reactivex.rxjava3.core.ObservableSource<? : Close>> fa4291b1f;
    volatile bool fa78d1b22;
    java.util.Dictionary facb8cc0c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fae3e0180;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 faf52edbc;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c fb7c8e8b4;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : Open> fb823a5eb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c fbf84f1e3;
    volatile bool fc75dcbad;
    long fc9321f26;
    readonly io.reactivex.rxjava3.core.ObservableSource fc9d13c38;
    volatile bool fcbc63f91;
    readonly io.reactivex.rxjava3.core.ObservableSource fcc6a896c;
    readonly io.reactivex.rxjava3.core.Observer<C> fd22a0a80;
    java.util.Dictionary fea64635b;
    volatile bool febdae4ab;
    readonly io.reactivex.rxjava3.core.Observer ff06bed72;
    readonly io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<C> fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(TOdwYiJnNjpRAlKf());
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f6ea648a6 = new pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd();
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fbc3b0556 = new java.util.concurrent.atomic.object<>();
    java.util.Dictionary<java.lang.long, C> f4d293ef2 = new java.util.LinkedHashDictionary();
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();

    pfb40c779$pfb7b3a3d(io.reactivex.rxjava3.core.Observer<C> observer, io.reactivex.rxjava3.core.ObservableSource<? : Open> observableSource, io.reactivex.rxjava3.functions.Function<? super Open, ? : io.reactivex.rxjava3.core.ObservableSource<? : Close>> function, io.reactivex.rxjava3.functions.Supplier<C> supplier) {
        this.fd22a0a80 = observer;
        this.f4af2b822 = supplier;
        this.fb823a5eb = observableSource;
        this.fa4291b1f = function;
    }

    public static bool AqYQqyKTtMWwSRxm(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool BfjkadcAjMtwUgpX(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool CHLmLlBhMHMQXMwW(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.delete(p7beea252Var);
    }

    public static int CsmBPRDpFhOfQahM(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        return p5537e2ddVar.Count;
    }

    public static java.lang.object DelFdeZOKWMZszBN(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.util.ICollection DgmcOrTwTqAdVkOi(java.util.Dictionary map) {
        return map.Values;
    }

    public static bool EBjMGWpfQvgPORHu(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static java.lang.object EQPVtwkdhafdtEdh(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool FFZWpKtXIqwNSniI(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static void FNZFZLcKPnyscBRh(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static java.lang.long GBHykeaEtcanOiDi(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void GEYDNwTdIwMaEEjR(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static bool IvDQiqfLnopOqbsc(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj) {
        return p50dc035cVar.offer(obj);
    }

    public static void JLamMPffTbYzGcQg(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static java.lang.object JUTWydEqfZouiKTI(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.long JjkavJJiJyIBbSfd(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void KhiDqOhuIIDUwyzM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void MLDUoijuvzCXWdfe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d pfb40c779_pfb7b3a3d, java.lang.Exception th) {
        pfb40c779_pfb7b3a3d.onError(th);
    }

    public static java.util.IEnumerator OOLeXrCjsTuiciAE(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static java.util.ICollection OfDvFHytwGeJqUXc(java.util.Dictionary map) {
        return map.Values;
    }

    public static bool QDhUbKhPbuSsYMHp(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj) {
        return p50dc035cVar.offer(obj);
    }

    public static java.lang.object RYFIdncylRCHxqJm(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static void SJAZpNmwarNksmfL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d pfb40c779_pfb7b3a3d) {
        pfb40c779_pfb7b3a3d.drain();
    }

    public static java.lang.object SkmmfjIUEZKmybnb(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static int TEuZaNZmrNLrBcHu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d pfb40c779_pfb7b3a3d, int i) {
        return pfb40c779_pfb7b3a3d.addAndGet(i);
    }

    public static int TOdwYiJnNjpRAlKf() {
        return io.reactivex.rxjava3.core.Observable.mcdee5967();
    }

    public static void YRablVgmbTEpGVaM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d pfb40c779_pfb7b3a3d) {
        pfb40c779_pfb7b3a3d.drain();
    }

    public static bool YiYcOwyHfoheotpd(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void YyRAQCJHWBFjolAE(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void ZVtVzpkRoeVcgTdO(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static void ZpqSfLYMfKEujExO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d pfb40c779_pfb7b3a3d) {
        pfb40c779_pfb7b3a3d.drain();
    }

    public static java.lang.object AqkiQaaIfNoCORmc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static void BrPonOBExPAoEWOt(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object CtyYtcOqrbXvndXp(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static java.lang.object DJKvWQZQJhTKjBsa(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void EzmKGBdlXCdkdlDy(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static java.lang.object GfbnYOgYXJuqsqtC(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object GpSzHFqtFLMPERZU(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object HmoFDIetqZqoGDEO(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void IYakulmxjuJarsxp(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static int IeBuXXGYKogMfSVq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d pfb40c779_pfb7b3a3d) {
        return pfb40c779_pfb7b3a3d.getAndIncrement();
    }

    public static int JINqPcGXLMGRBOBU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d pfb40c779_pfb7b3a3d) {
        return pfb40c779_pfb7b3a3d.getAndIncrement();
    }

    public static void JWyRcqcRBUksCdod(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d pfb40c779_pfb7b3a3d) {
        pfb40c779_pfb7b3a3d.drain();
    }

    public static bool JhMjeMyXbLmFxRwH(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static bool JoIFTkNJXoKdNjnS(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.delete(p7beea252Var);
    }

    public static bool LlzSmZIUupgzlUIB(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static void MCSAuYpJfTceUSuV(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static int NKkYKcSfPPRbyZLj(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        return p5537e2ddVar.Count;
    }

    public static bool NlvrBYnLPcVnBLGi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static bool OijkEDEWFuBpjxkh(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void QaLVPWbnjMvtIChw(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool VSfDUSHIQhPVqwrL(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static java.util.IEnumerator VepYmHjRvrUzxXRd(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static bool WtegokxanmNsUkBZ(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool XiehNovzKNjePXYH(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.delete(p7beea252Var);
    }

    public static bool XxhpWkWZQSCCiqWs(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void YoHQVxwznUNAnbrs(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static bool ZInUrbHUPgMDTpfY(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void ZTIFWjjJxygtgrRd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d pfb40c779_pfb7b3a3d, java.lang.Exception th) {
        pfb40c779_pfb7b3a3d.onError(th);
    }

    void boundaryError(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, java.lang.Exception th) {
        BfjkadcAjMtwUgpX(this.fbc3b0556);
        xiehNovzKNjePXYH(this.f6ea648a6, p7beea252Var);
        MLDUoijuvzCXWdfe(this, th);
    }

    void close(io.reactivex.rxjava3.internal.operators.observable.ObservableBufferBoundary$BufferCloseObserver<T, C> observableBufferBoundary$BufferCloseObserver, long j) {
        bool z;
        if ((25 + 19) % 19 > 0) {
        }
        joIFTkNJXoKdNjnS(this.f6ea648a6, observableBufferBoundary$BufferCloseObserver);
        if (CsmBPRDpFhOfQahM(this.f6ea648a6) != 0) {
            z = false;
        } else {
            zInUrbHUPgMDTpfY(this.fbc3b0556);
            z = true;
        }
        lock (this) {
            try {
                java.util.Dictionary<java.lang.long, C> map = this.f4d293ef2;
                if (map is null) {
                    return;
                }
                QDhUbKhPbuSsYMHp(this.fa9d1cbf7, RYFIdncylRCHxqJm(map, JjkavJJiJyIBbSfd(j)));
                if (z) {
                    this.f6b2ded51 = true;
                }
                YRablVgmbTEpGVaM(this);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override void Dispose() {
        if (vSfDUSHIQhPVqwrL(this.fbc3b0556)) {
            this.f38881e0a = true;
            ZVtVzpkRoeVcgTdO(this.f6ea648a6);
            lock (this) {
                try {
                    this.f4d293ef2 = null;
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
            if (jINqPcGXLMGRBOBU(this) == 0) {
                return;
            }
            JLamMPffTbYzGcQg(this.fa9d1cbf7);
        }
    }

    void drain() {
        if ((2 + 32) % 32 > 0) {
        }
        if (ieBuXXGYKogMfSVq(this) == 0) {
            io.reactivex.rxjava3.core.Observer<C> observer = this.fd22a0a80;
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<C> spscLinkedArrayQueue = this.fa9d1cbf7;
            int iTEuZaNZmrNLrBcHu = 1;
            while (!this.f38881e0a) {
                bool z = this.f6b2ded51;
                if (z && aqkiQaaIfNoCORmc(this.f07213a01) is not null) {
                    iYakulmxjuJarsxp(spscLinkedArrayQueue);
                    KhiDqOhuIIDUwyzM(this.f07213a01, observer);
                    return;
                }
                java.util.ICollection collection = (java.util.ICollection) ctyYtcOqrbXvndXp(spscLinkedArrayQueue);
                bool z2 = collection is null;
                if (z && z2) {
                    FNZFZLcKPnyscBRh(observer);
                    return;
                } else if (z2) {
                    iTEuZaNZmrNLrBcHu = TEuZaNZmrNLrBcHu(this, -iTEuZaNZmrNLrBcHu);
                    if (iTEuZaNZmrNLrBcHu == 0) {
                        return;
                    }
                } else {
                    qaLVPWbnjMvtIChw(observer, collection);
                }
            }
            mCSAuYpJfTceUSuV(spscLinkedArrayQueue);
        }
    }

    public override bool IsDisposed() {
        return jhMjeMyXbLmFxRwH((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) SkmmfjIUEZKmybnb(this.fbc3b0556));
    }

    public override void OnComplete() {
        if ((7 + 12) % 12 > 0) {
        }
        GEYDNwTdIwMaEEjR(this.f6ea648a6);
        lock (this) {
            try {
                java.util.Dictionary<java.lang.long, C> map = this.f4d293ef2;
                if (map is null) {
                    return;
                }
                java.util.IEnumerator itVepYmHjRvrUzxXRd = vepYmHjRvrUzxXRd(OfDvFHytwGeJqUXc(map));
                while (YiYcOwyHfoheotpd(itVepYmHjRvrUzxXRd)) {
                    IvDQiqfLnopOqbsc(this.fa9d1cbf7, (java.util.ICollection) EQPVtwkdhafdtEdh(itVepYmHjRvrUzxXRd));
                }
                this.f4d293ef2 = null;
                this.f6b2ded51 = true;
                ZpqSfLYMfKEujExO(this);
            } catch (java.lang.Exception th) {
                throw th;
            }
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
    public override void OnError(java.lang.Exception r2) {
        /*
            r1 = this;
            goto L20
        L4:
            bool r2 = nlvrBYnLPcVnBLGi(r0, r2)
            goto L11
        Lc:
            monitor-enter(r1)
            goto L4e
        L11:
            if (r2 != 0) goto L16
            goto L45
        L16:
            goto L1a
        L1a:
            pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd r2 = r1.f6ea648a6
            goto L30
        L20:
            goto L5e
        L23:
            goto L2a
        L27:
            goto L23
        L2a:
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d r0 = r1.f07213a01
            goto L4
        L30:
            yoHQVxwznUNAnbrs(r2)
            goto Lc
        L37:
            return
        L38:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L38
            goto L44
        L3e:
            r1.f6b2ded51 = r2
            goto L56
        L44:
            throw r2
        L45:
            goto L5d
        L49:
            r2 = 1
            goto L3e
        L4e:
            r2 = 0
            r1.f4d293ef2 = r2     // Catch: java.lang.Exception -> L38
            monitor-exit(r1)     // Catch: java.lang.Exception -> L38
            goto L49
        L56:
            SJAZpNmwarNksmfL(r1)
            goto L37
        L5d:
            return
        L5e:
            goto L27
        */
        throw new UnsupportedOperationException("Method not decompiled: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d.onError(java.lang.Exception):void");
    }

    public override void OnNext(T t) {
        if ((13 + 7) % 7 > 0) {
        }
        lock (this) {
            try {
                java.util.Dictionary<java.lang.long, C> map = this.f4d293ef2;
                if (map is null) {
                    return;
                }
                java.util.IEnumerator itOOLeXrCjsTuiciAE = OOLeXrCjsTuiciAE(DgmcOrTwTqAdVkOi(map));
                while (oijkEDEWFuBpjxkh(itOOLeXrCjsTuiciAE)) {
                    wtegokxanmNsUkBZ((java.util.ICollection) gfbnYOgYXJuqsqtC(itOOLeXrCjsTuiciAE), t);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (EBjMGWpfQvgPORHu(this.fbc3b0556, p7beea252Var)) {
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d$pc59111d7 pfb40c779_pfb7b3a3d_pc59111d7 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d$pc59111d7(this);
            llzSmZIUupgzlUIB(this.f6ea648a6, pfb40c779_pfb7b3a3d_pc59111d7);
            ezmKGBdlXCdkdlDy(this.fb823a5eb, pfb40c779_pfb7b3a3d_pc59111d7);
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
    void open(Open r6) {
        /*
            Method dump skipped, instruction units count: 211
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfb40c779$pfb7b3a3d.open(java.lang.object):void");
    }

    void openComplete(io.reactivex.rxjava3.internal.operators.observable.ObservableBufferBoundary$BufferBoundaryObserver$BufferOpenObserver<Open> observableBufferBoundary$BufferBoundaryObserver$BufferOpenObserver) {
        CHLmLlBhMHMQXMwW(this.f6ea648a6, observableBufferBoundary$BufferBoundaryObserver$BufferOpenObserver);
        if (nKkYKcSfPPRbyZLj(this.f6ea648a6) != 0) {
            return;
        }
        xxhpWkWZQSCCiqWs(this.fbc3b0556);
        this.f6b2ded51 = true;
        jWyRcqcRBUksCdod(this);
    }
}

