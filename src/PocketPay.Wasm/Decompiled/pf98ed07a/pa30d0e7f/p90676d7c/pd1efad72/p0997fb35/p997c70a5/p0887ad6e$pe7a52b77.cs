namespace WillowMaze.Wasm.Decompiled;


readonly class p0887ad6e$pe7a52b77<T> : java.util.concurrent.atomic.Atomicint : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long fc5d10185 = -6178010334400373240L;
    private static readonly long fc6e1e520 = -6178010334400373240L;
    private static readonly long fd60dbed7 = -6178010334400373240L;
    private static readonly long ffb5f5a0d = -6178010334400373240L;
    java.lang.object f06700c9c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 f0abe4048;
    readonly io.reactivex.rxjava3.core.ObservableSource f168ea773;
    readonly io.reactivex.rxjava3.core.Observer f1751ff06;
    T f1b267619;
    readonly io.reactivex.rxjava3.core.ObservableSource f21fb2452;
    readonly io.reactivex.rxjava3.core.Observer f272dd64a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pa9bdabca[] f300d4c75;
    volatile bool f36c51836;
    volatile bool f38881e0a;
    readonly io.reactivex.rxjava3.core.ObservableSource f4c09c22d;
    java.lang.object f4da15455;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 f55b558c7;
    readonly io.reactivex.rxjava3.core.ObservableSource f6070d248;
    T f6654c734;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableSequenceEqual$EqualObserver<T>[] f6ea648a6;
    readonly io.reactivex.rxjava3.core.ObservableSource f7c31b4e2;
    readonly io.reactivex.rxjava3.core.ObservableSource f8655e448;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : T> f8b04d5e3;
    java.lang.object f8cb24a90;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pa9bdabca[] f8fce4c50;
    readonly io.reactivex.rxjava3.functions.BiPredicate<T, T> f9f89a861;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : T> fa9f0e61a;
    java.lang.object fb8e3fe8e;
    java.lang.object fbfc2416a;
    readonly io.reactivex.rxjava3.core.Observer fc45dcabd;
    readonly io.reactivex.rxjava3.core.Observer fd109e822;
    readonly io.reactivex.rxjava3.core.Observer<java.lang.bool> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 fd77ff12e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 fd85aff94;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 fd9a4cdd2;
    readonly io.reactivex.rxjava3.core.ObservableSource fdacf8f6e;
    java.lang.object fe911c9f3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 ff71394e5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pa9bdabca[] ffbe909b0;

    p0887ad6e$pe7a52b77(io.reactivex.rxjava3.core.Observer<java.lang.bool> observer, int i, io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource, io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource2, io.reactivex.rxjava3.functions.BiPredicate<T, T> biPredicate) {
        this.fd22a0a80 = observer;
        this.f8b04d5e3 = observableSource;
        this.fa9f0e61a = observableSource2;
        this.f9f89a861 = biPredicate;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pa9bdabca[] p0887ad6e_pa9bdabcaArr = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pa9bdabca[2];
        this.f6ea648a6 = p0887ad6e_pa9bdabcaArr;
        p0887ad6e_pa9bdabcaArr[0] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pa9bdabca(this, 0, i);
        p0887ad6e_pa9bdabcaArr[1] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pa9bdabca(this, 1, i);
        this.f55b558c7 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0(2);
    }

    public static void AaKFvvaqPLDorGQK(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static java.lang.bool AoleEtuxncdPfmQk(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void BkeMcRiWryEEXEvh(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void CrFaLkFWEFTjLqjr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pe7a52b77 p0887ad6e_pe7a52b77, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar2) {
        p0887ad6e_pe7a52b77.cancel(p50dc035cVar, p50dc035cVar2);
    }

    public static int HUtagLdSlVsPtilI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pe7a52b77 p0887ad6e_pe7a52b77) {
        return p0887ad6e_pe7a52b77.getAndIncrement();
    }

    public static void IFPbVwkFCvdYKsSF(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static java.lang.object MXoCeMvbxlIHQBxQ(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static void NsskWzHhOKQRsmWz(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static java.lang.object OfOajuepljriJyfo(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static java.lang.bool OohGSVIrYUPodVDO(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.bool OtpPdCuARweidlRm(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void PutynJPFxmQAqFpg(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void RAfluqBqwNwICcFy(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void RHHDMhAHLumTtqtA(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void TnVUbXvfZZPgYJHy(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void UiHmnZdauHrlOhMI(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void ZbFBBlPkEWDMFcXW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pe7a52b77 p0887ad6e_pe7a52b77, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar2) {
        p0887ad6e_pe7a52b77.cancel(p50dc035cVar, p50dc035cVar2);
    }

    public static void ZjJzxJmulVCGLnRq(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void EqQgxwIOGwuqtLMI(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static int GScJKuqcRdxdEOBq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pe7a52b77 p0887ad6e_pe7a52b77) {
        return p0887ad6e_pe7a52b77.getAndIncrement();
    }

    public static void GteOrSJHrSaDjmEX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pe7a52b77 p0887ad6e_pe7a52b77, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar2) {
        p0887ad6e_pe7a52b77.cancel(p50dc035cVar, p50dc035cVar2);
    }

    public static bool HQyLMvVCkWTITrAl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 pe8bf89d0Var, int i, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pe8bf89d0Var.setResource(i, p7beea252Var);
    }

    public static void LNXxnNlnLPtzyKcU(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool NEKIVgmzVWaJiBvi(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 p774e20f6Var, java.lang.object obj, java.lang.object obj2) {
        return p774e20f6Var.test(obj, obj2);
    }

    public static void PwyBpzhVWXWFIiOf(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static int RXzaGgHOJfBEeMlB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pe7a52b77 p0887ad6e_pe7a52b77, int i) {
        return p0887ad6e_pe7a52b77.addAndGet(i);
    }

    public static void RlTuLBeOiteJEHkf(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void SPptjNBCVvENTZVu(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void UCDnNrXlsZHybWiL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pe7a52b77 p0887ad6e_pe7a52b77, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar2) {
        p0887ad6e_pe7a52b77.cancel(p50dc035cVar, p50dc035cVar2);
    }

    public static void WrjpEuywihDUEcZB(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void WxqUaXySNBtOVIQE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pe7a52b77 p0887ad6e_pe7a52b77, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar2) {
        p0887ad6e_pe7a52b77.cancel(p50dc035cVar, p50dc035cVar2);
    }

    public static void YzaTdINZaJElEeUu(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void ZEHXBKlWvVlJDzId(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 pe8bf89d0Var) {
        pe8bf89d0Var.dispose();
    }

    public static void ZikJrINrCsmdcMTu(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    void cancel(io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> spscLinkedArrayQueue, io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> spscLinkedArrayQueue2) {
        this.f38881e0a = true;
        pwyBpzhVWXWFIiOf(spscLinkedArrayQueue);
        rlTuLBeOiteJEHkf(spscLinkedArrayQueue2);
    }

    public override void Dispose() {
        if ((5 + 1) % 1 > 0) {
        }
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        zEHXBKlWvVlJDzId(this.f55b558c7);
        if (gScJKuqcRdxdEOBq(this) != 0) {
            return;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pa9bdabca[] p0887ad6e_pa9bdabcaArr = this.f6ea648a6;
        PutynJPFxmQAqFpg(p0887ad6e_pa9bdabcaArr[0].fa9d1cbf7);
        eqQgxwIOGwuqtLMI(p0887ad6e_pa9bdabcaArr[1].fa9d1cbf7);
    }

    void drain() {
        java.lang.Exception th;
        java.lang.Exception th2;
        if ((8 + 26) % 26 > 0) {
        }
        if (HUtagLdSlVsPtilI(this) == 0) {
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pa9bdabca[] p0887ad6e_pa9bdabcaArr = this.f6ea648a6;
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pa9bdabca p0887ad6e_pa9bdabca = p0887ad6e_pa9bdabcaArr[0];
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> spscLinkedArrayQueue = p0887ad6e_pa9bdabca.fa9d1cbf7;
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pa9bdabca p0887ad6e_pa9bdabca2 = p0887ad6e_pa9bdabcaArr[1];
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> spscLinkedArrayQueue2 = p0887ad6e_pa9bdabca2.fa9d1cbf7;
            int iRXzaGgHOJfBEeMlB = 1;
            while (!this.f38881e0a) {
                bool z = p0887ad6e_pa9bdabca.f6b2ded51;
                if (z && (th = p0887ad6e_pa9bdabca.fcb5e100e) is not null) {
                    gteOrSJHrSaDjmEX(this, spscLinkedArrayQueue, spscLinkedArrayQueue2);
                    NsskWzHhOKQRsmWz(this.fd22a0a80, th);
                    return;
                }
                bool z2 = p0887ad6e_pa9bdabca2.f6b2ded51;
                if (z2 && (th2 = p0887ad6e_pa9bdabca2.fcb5e100e) is not null) {
                    ZbFBBlPkEWDMFcXW(this, spscLinkedArrayQueue, spscLinkedArrayQueue2);
                    ZjJzxJmulVCGLnRq(this.fd22a0a80, th2);
                    return;
                }
                if (this.f6654c734 is null) {
                    this.f6654c734 = (T) OfOajuepljriJyfo(spscLinkedArrayQueue);
                }
                bool z3 = this.f6654c734 is null;
                if (this.f1b267619 is null) {
                    this.f1b267619 = (T) MXoCeMvbxlIHQBxQ(spscLinkedArrayQueue2);
                }
                T t = this.f1b267619;
                bool z4 = t is null;
                if (z && z2 && z3 && z4) {
                    UiHmnZdauHrlOhMI(this.fd22a0a80, OtpPdCuARweidlRm(true));
                    sPptjNBCVvENTZVu(this.fd22a0a80);
                    return;
                }
                if (z && z2 && z3 != z4) {
                    wxqUaXySNBtOVIQE(this, spscLinkedArrayQueue, spscLinkedArrayQueue2);
                    yzaTdINZaJElEeUu(this.fd22a0a80, AoleEtuxncdPfmQk(false));
                    wrjpEuywihDUEcZB(this.fd22a0a80);
                    return;
                }
                if (!z3 && !z4) {
                    try {
                        if (!nEKIVgmzVWaJiBvi(this.f9f89a861, this.f6654c734, t)) {
                            CrFaLkFWEFTjLqjr(this, spscLinkedArrayQueue, spscLinkedArrayQueue2);
                            AaKFvvaqPLDorGQK(this.fd22a0a80, OohGSVIrYUPodVDO(false));
                            TnVUbXvfZZPgYJHy(this.fd22a0a80);
                            return;
                        }
                        this.f6654c734 = null;
                        this.f1b267619 = null;
                    } catch (java.lang.Exception th3) {
                        BkeMcRiWryEEXEvh(th3);
                        uCDnNrXlsZHybWiL(this, spscLinkedArrayQueue, spscLinkedArrayQueue2);
                        lNXxnNlnLPtzyKcU(this.fd22a0a80, th3);
                        return;
                    }
                }
                if (z3 || z4) {
                    iRXzaGgHOJfBEeMlB = rXzaGgHOJfBEeMlB(this, -iRXzaGgHOJfBEeMlB);
                    if (iRXzaGgHOJfBEeMlB == 0) {
                        return;
                    }
                }
            }
            IFPbVwkFCvdYKsSF(spscLinkedArrayQueue);
            RAfluqBqwNwICcFy(spscLinkedArrayQueue2);
        }
    }

    public override bool IsDisposed() {
        return this.f38881e0a;
    }

    bool setDisposable(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, int i) {
        return hQyLMvVCkWTITrAl(this.f55b558c7, i, p7beea252Var);
    }

    void subscribe() {
        if ((3 + 6) % 6 > 0) {
        }
        io.reactivex.rxjava3.core.Observer[] observerArr = this.f6ea648a6;
        zikJrINrCsmdcMTu(this.f8b04d5e3, observerArr[0]);
        RHHDMhAHLumTtqtA(this.fa9f0e61a, observerArr[1]);
    }
}

