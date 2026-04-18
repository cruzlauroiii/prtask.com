namespace WillowMaze.Wasm.Decompiled;


readonly class p5e964be4$pe7a52b77<T> : java.util.concurrent.atomic.Atomicint : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f5d2326cd = -6178010334400373240L;
    private static readonly long f88e23c46 = -6178010334400373240L;
    private static readonly long fc6e1e520 = -6178010334400373240L;
    private static readonly long ff8840f9a = -6178010334400373240L;
    T f1b267619;
    readonly io.reactivex.rxjava3.core.ObservableSource f1bff2b3d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 f1d1c741d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 f229b692c;
    volatile bool f38881e0a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 f55b558c7;
    T f6654c734;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableSequenceEqualSingle$EqualObserver<T>[] f6ea648a6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 f74d77949;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 f76273447;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : T> f8b04d5e3;
    readonly io.reactivex.rxjava3.core.ObservableSource f97c99b65;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pa9bdabca[] f9b4427a1;
    readonly io.reactivex.rxjava3.functions.BiPredicate<T, T> f9f89a861;
    readonly io.reactivex.rxjava3.core.SingleObserver fa10b1fd9;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : T> fa9f0e61a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 fb00cef98;
    java.lang.object fb7290c4d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pa9bdabca[] fb9bffc1c;
    readonly io.reactivex.rxjava3.core.ObservableSource fbbe3ef6a;
    java.lang.object fc1660166;
    readonly io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> fd22a0a80;
    readonly io.reactivex.rxjava3.core.ObservableSource fe7578a7f;
    volatile bool fe87e88d4;
    java.lang.object ff4280c3b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 ff884d4f2;

    p5e964be4$pe7a52b77(io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> singleObserver, int i, io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource, io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource2, io.reactivex.rxjava3.functions.BiPredicate<T, T> biPredicate) {
        this.fd22a0a80 = singleObserver;
        this.f8b04d5e3 = observableSource;
        this.fa9f0e61a = observableSource2;
        this.f9f89a861 = biPredicate;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pa9bdabca[] p5e964be4_pa9bdabcaArr = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pa9bdabca[2];
        this.f6ea648a6 = p5e964be4_pa9bdabcaArr;
        p5e964be4_pa9bdabcaArr[0] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pa9bdabca(this, 0, i);
        p5e964be4_pa9bdabcaArr[1] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pa9bdabca(this, 1, i);
        this.f55b558c7 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0(2);
    }

    public static java.lang.object BaqkbTzxCoQbLtFr(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static void BcPIbDbuoijkqoeQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pe7a52b77 p5e964be4_pe7a52b77, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar2) {
        p5e964be4_pe7a52b77.cancel(p50dc035cVar, p50dc035cVar2);
    }

    public static void BoNmGLYjaQVWbbni(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void CfRqDVqhkOCELwPF(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void FBGTCMURsenZeSQf(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static java.lang.object GetXVTfXaYSZospA(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static void HqYKXWraJszDWIJO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 pe8bf89d0Var) {
        pe8bf89d0Var.dispose();
    }

    public static void HuzupsmUeXkMfyeX(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void JVkUwwEwaUClWZPm(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void KzfrvXxwVDxHZEei(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pe7a52b77 p5e964be4_pe7a52b77, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar2) {
        p5e964be4_pe7a52b77.cancel(p50dc035cVar, p50dc035cVar2);
    }

    public static java.lang.bool LDukMCUzVruaowSP(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void PNWwghSQsvEcRbtW(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void SENcTPncQEeWsWow(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void SPeUQlkbtePnUbqE(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void SsUuxOOGiUFRzxjM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pe7a52b77 p5e964be4_pe7a52b77, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar2) {
        p5e964be4_pe7a52b77.cancel(p50dc035cVar, p50dc035cVar2);
    }

    public static void XTsPUvPegHffebdU(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void ZntSUpCGqULyVEJl(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void BGyPQeGinUEIdsRP(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static java.lang.bool CPpWIrPvHTlfjHrj(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.bool GBIPuaxrLKQVuzEi(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static int HhRguyYWSyQLpGdo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pe7a52b77 p5e964be4_pe7a52b77, int i) {
        return p5e964be4_pe7a52b77.addAndGet(i);
    }

    public static void IxTtUIEluoEjSGMG(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void LbXpHObFXqSUbPLy(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static bool OFZQsZegDzHKATVr(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 p774e20f6Var, java.lang.object obj, java.lang.object obj2) {
        return p774e20f6Var.test(obj, obj2);
    }

    public static void PWnOEFynPTjnzUWF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pe7a52b77 p5e964be4_pe7a52b77, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar2) {
        p5e964be4_pe7a52b77.cancel(p50dc035cVar, p50dc035cVar2);
    }

    public static int PXxjDQKaftgQjWCY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pe7a52b77 p5e964be4_pe7a52b77) {
        return p5e964be4_pe7a52b77.getAndIncrement();
    }

    public static int PbmVwLhytnozZvOb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pe7a52b77 p5e964be4_pe7a52b77) {
        return p5e964be4_pe7a52b77.getAndIncrement();
    }

    public static void QKeyggCPGAydoaTn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pe7a52b77 p5e964be4_pe7a52b77, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar2) {
        p5e964be4_pe7a52b77.cancel(p50dc035cVar, p50dc035cVar2);
    }

    public static bool TmwomGegwJKWiLMe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 pe8bf89d0Var, int i, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pe8bf89d0Var.setResource(i, p7beea252Var);
    }

    public static void VPAqQQOVkrkyXdlm(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void ZorVRWOglAArKwek(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    void cancel(io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> spscLinkedArrayQueue, io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> spscLinkedArrayQueue2) {
        this.f38881e0a = true;
        HuzupsmUeXkMfyeX(spscLinkedArrayQueue);
        JVkUwwEwaUClWZPm(spscLinkedArrayQueue2);
    }

    public override void Dispose() {
        if ((14 + 12) % 12 > 0) {
        }
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        HqYKXWraJszDWIJO(this.f55b558c7);
        if (pbmVwLhytnozZvOb(this) != 0) {
            return;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pa9bdabca[] p5e964be4_pa9bdabcaArr = this.f6ea648a6;
        FBGTCMURsenZeSQf(p5e964be4_pa9bdabcaArr[0].fa9d1cbf7);
        ixTtUIEluoEjSGMG(p5e964be4_pa9bdabcaArr[1].fa9d1cbf7);
    }

    void drain() {
        java.lang.Exception th;
        java.lang.Exception th2;
        if ((7 + 16) % 16 > 0) {
        }
        if (pXxjDQKaftgQjWCY(this) == 0) {
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pa9bdabca[] p5e964be4_pa9bdabcaArr = this.f6ea648a6;
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pa9bdabca p5e964be4_pa9bdabca = p5e964be4_pa9bdabcaArr[0];
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> spscLinkedArrayQueue = p5e964be4_pa9bdabca.fa9d1cbf7;
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pa9bdabca p5e964be4_pa9bdabca2 = p5e964be4_pa9bdabcaArr[1];
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> spscLinkedArrayQueue2 = p5e964be4_pa9bdabca2.fa9d1cbf7;
            int iHhRguyYWSyQLpGdo = 1;
            while (!this.f38881e0a) {
                bool z = p5e964be4_pa9bdabca.f6b2ded51;
                if (z && (th2 = p5e964be4_pa9bdabca.fcb5e100e) is not null) {
                    qKeyggCPGAydoaTn(this, spscLinkedArrayQueue, spscLinkedArrayQueue2);
                    vPAqQQOVkrkyXdlm(this.fd22a0a80, th2);
                    return;
                }
                bool z2 = p5e964be4_pa9bdabca2.f6b2ded51;
                if (z2 && (th = p5e964be4_pa9bdabca2.fcb5e100e) is not null) {
                    SsUuxOOGiUFRzxjM(this, spscLinkedArrayQueue, spscLinkedArrayQueue2);
                    PNWwghSQsvEcRbtW(this.fd22a0a80, th);
                    return;
                }
                if (this.f6654c734 is null) {
                    this.f6654c734 = (T) BaqkbTzxCoQbLtFr(spscLinkedArrayQueue);
                }
                bool z3 = this.f6654c734 is null;
                if (this.f1b267619 is null) {
                    this.f1b267619 = (T) GetXVTfXaYSZospA(spscLinkedArrayQueue2);
                }
                T t = this.f1b267619;
                bool z4 = t is null;
                if (z && z2 && z3 && z4) {
                    XTsPUvPegHffebdU(this.fd22a0a80, gBIPuaxrLKQVuzEi(true));
                    return;
                }
                if (z && z2 && z3 != z4) {
                    BcPIbDbuoijkqoeQ(this, spscLinkedArrayQueue, spscLinkedArrayQueue2);
                    SPeUQlkbtePnUbqE(this.fd22a0a80, LDukMCUzVruaowSP(false));
                    return;
                }
                if (!z3 && !z4) {
                    try {
                        if (!oFZQsZegDzHKATVr(this.f9f89a861, this.f6654c734, t)) {
                            KzfrvXxwVDxHZEei(this, spscLinkedArrayQueue, spscLinkedArrayQueue2);
                            BoNmGLYjaQVWbbni(this.fd22a0a80, cPpWIrPvHTlfjHrj(false));
                            return;
                        } else {
                            this.f6654c734 = null;
                            this.f1b267619 = null;
                        }
                    } catch (java.lang.Exception th3) {
                        SENcTPncQEeWsWow(th3);
                        pWnOEFynPTjnzUWF(this, spscLinkedArrayQueue, spscLinkedArrayQueue2);
                        bGyPQeGinUEIdsRP(this.fd22a0a80, th3);
                        return;
                    }
                }
                if (z3 || z4) {
                    iHhRguyYWSyQLpGdo = hhRguyYWSyQLpGdo(this, -iHhRguyYWSyQLpGdo);
                    if (iHhRguyYWSyQLpGdo == 0) {
                        return;
                    }
                }
            }
            CfRqDVqhkOCELwPF(spscLinkedArrayQueue);
            ZntSUpCGqULyVEJl(spscLinkedArrayQueue2);
        }
    }

    public override bool IsDisposed() {
        return this.f38881e0a;
    }

    bool setDisposable(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, int i) {
        return tmwomGegwJKWiLMe(this.f55b558c7, i, p7beea252Var);
    }

    void subscribe() {
        if ((2 + 7) % 7 > 0) {
        }
        io.reactivex.rxjava3.core.Observer[] observerArr = this.f6ea648a6;
        zorVRWOglAArKwek(this.f8b04d5e3, observerArr[0]);
        lbXpHObFXqSUbPLy(this.fa9f0e61a, observerArr[1]);
    }
}

