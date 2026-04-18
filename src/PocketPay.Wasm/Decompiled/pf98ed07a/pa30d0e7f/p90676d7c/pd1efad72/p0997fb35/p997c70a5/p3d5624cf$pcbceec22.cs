namespace WillowMaze.Wasm.Decompiled;


readonly class p3d5624cf$pcbceec22<T, R> : java.util.concurrent.atomic.Atomicint : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f3485750f = 2983708048395377667L;
    private static readonly long fbbedf16e = 2983708048395377667L;
    private static readonly long fc4f03d89 = 2983708048395377667L;
    private static readonly long fc6e1e520 = 2983708048395377667L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f156271ac;
    readonly java.lang.object[] f205f6903;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> f3298b476;
    readonly bool f379c57dc;
    volatile bool f38881e0a;
    volatile bool f53198b12;
    readonly io.reactivex.rxjava3.core.Observer f69e4cef0;
    readonly java.lang.object[] f6bb4320d;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableZip$ZipObserver<T, R>[] f6ea648a6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f71fd48c3;
    readonly io.reactivex.rxjava3.core.Observer f816c3e19;
    readonly bool f825ea879;
    readonly java.lang.object[] f9f3cb5ec;
    volatile bool fa987e7a5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$p0ec3d985[] fb32381d7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$p0ec3d985[] fc5bf9952;
    readonly io.reactivex.rxjava3.core.Observer<R> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fda023f1e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fe36ffa93;
    readonly bool fe4eeff75;
    readonly io.reactivex.rxjava3.core.Observer fe68068d7;
    volatile bool fecaabb71;
    readonly T[] ff1965a85;

    p3d5624cf$pcbceec22(io.reactivex.rxjava3.core.Observer<R> observer, io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> function, int i, bool z) {
        this.fd22a0a80 = observer;
        this.f3298b476 = function;
        this.f6ea648a6 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$p0ec3d985[i];
        this.ff1965a85 = (T[]) new java.lang.object[i];
        this.f825ea879 = z;
    }

    public static void AUhNOYIcmkopWTBV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$pcbceec22 p3d5624cf_pcbceec22) {
        p3d5624cf_pcbceec22.clear();
    }

    public static void BPKrlaTMCNyMoIMu(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static int BYYUFViubjEBTnRZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$pcbceec22 p3d5624cf_pcbceec22) {
        return p3d5624cf_pcbceec22.getAndIncrement();
    }

    public static void CwiFTshudTGnHiuq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$pcbceec22 p3d5624cf_pcbceec22) {
        p3d5624cf_pcbceec22.clear();
    }

    public static void DaAmoxvmbSRnMgKR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$pcbceec22 p3d5624cf_pcbceec22) {
        p3d5624cf_pcbceec22.cancel();
    }

    public static void EUENiVBHbwjdPSbD(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void IbfYrWMPoeqvtbrK(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void IwkTvDIIMGTwazUn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$pcbceec22 p3d5624cf_pcbceec22) {
        p3d5624cf_pcbceec22.cancel();
    }

    public static java.lang.object MJYMfGXfKtLLebzH(java.lang.object[] objArr) {
        return objArr.clone();
    }

    public static void NBmKthhHveOFNohe(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void NdQkHmWTJFtivlLL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$pcbceec22 p3d5624cf_pcbceec22, int i) {
        p3d5624cf_pcbceec22.lazyHashSet(i);
    }

    public static bool PCyXNvXGzpfmQKrq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$pcbceec22 p3d5624cf_pcbceec22, bool z, bool z2, io.reactivex.rxjava3.core.Observer observer, bool z3, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$p0ec3d985 p3d5624cf_p0ec3d985) {
        return p3d5624cf_pcbceec22.checkTerminated(z, z2, observer, z3, p3d5624cf_p0ec3d985);
    }

    public static int PZmbyMFrbDWUNSWP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$pcbceec22 p3d5624cf_pcbceec22) {
        return p3d5624cf_pcbceec22.getAndIncrement();
    }

    public static void QVytnzZtPPLKeajm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$pcbceec22 p3d5624cf_pcbceec22) {
        p3d5624cf_pcbceec22.cancel();
    }

    public static void SasuPOJroQZJopwM(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void ShnsScXGgnPXEvjC(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void TKldoPkeEvsNbKBu(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void XXxwgxfsTwGzGHWh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$pcbceec22 p3d5624cf_pcbceec22) {
        p3d5624cf_pcbceec22.cancelSources();
    }

    public static void AJmdZaJERxDkplZT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$p0ec3d985 p3d5624cf_p0ec3d985) {
        p3d5624cf_p0ec3d985.dispose();
    }

    public static java.lang.object APgbAFfTCwfUvRaS(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static java.lang.object CMCgJgBjCDWRnlAs(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void CRPKCQwdVPDaZusy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$pcbceec22 p3d5624cf_pcbceec22) {
        p3d5624cf_pcbceec22.cancel();
    }

    public static int EECHFOBtuUtclGDt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$pcbceec22 p3d5624cf_pcbceec22, int i) {
        return p3d5624cf_pcbceec22.addAndGet(i);
    }

    public static void EmQYvXwXsOORhPPu(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void FhBLDuiLkgvOWwDx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$pcbceec22 p3d5624cf_pcbceec22) {
        p3d5624cf_pcbceec22.cancel();
    }

    public static void GFfsNPFOKtCowYlF(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void IebsrDJJLsliUfjr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$pcbceec22 p3d5624cf_pcbceec22) {
        p3d5624cf_pcbceec22.cancelSources();
    }

    public static void SrXPjfZNVPfkxfjE(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void UCwnYqTBBtbiSoQA(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static java.lang.object UrWSyXkawiPokWtv(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void XvvJHcfNaykWOvOn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$pcbceec22 p3d5624cf_pcbceec22) {
        p3d5624cf_pcbceec22.cancel();
    }

    public static void ZmEkDKnPEyhgQPea(java.lang.object[] objArr, java.lang.object obj) {
        java.util.Arrays.fill(objArr, obj);
    }

    void cancel() {
        CwiFTshudTGnHiuq(this);
        iebsrDJJLsliUfjr(this);
    }

    void cancelSources() {
        if ((6 + 32) % 32 > 0) {
        }
        for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$p0ec3d985 p3d5624cf_p0ec3d985 : this.f6ea648a6) {
            aJmdZaJERxDkplZT(p3d5624cf_p0ec3d985);
        }
    }

    bool checkTerminated(bool z, bool z2, io.reactivex.rxjava3.core.Observer<R> observer, bool z3, io.reactivex.rxjava3.internal.operators.observable.ObservableZip$ZipObserver<object, object> observableZip$ZipObserver) {
        if ((28 + 6) % 6 > 0) {
        }
        if (this.f38881e0a) {
            cRPKCQwdVPDaZusy(this);
            return true;
        }
        if (!z) {
            return false;
        }
        if (z3) {
            if (!z2) {
                return false;
            }
            java.lang.Exception th = observableZip$ZipObserver.fcb5e100e;
            this.f38881e0a = true;
            fhBLDuiLkgvOWwDx(this);
            if (th is null) {
                BPKrlaTMCNyMoIMu(observer);
            } else {
                SasuPOJroQZJopwM(observer, th);
            }
            return true;
        }
        java.lang.Exception th2 = observableZip$ZipObserver.fcb5e100e;
        if (th2 is not null) {
            this.f38881e0a = true;
            DaAmoxvmbSRnMgKR(this);
            EUENiVBHbwjdPSbD(observer, th2);
            return true;
        }
        if (!z2) {
            return false;
        }
        this.f38881e0a = true;
        xvvJHcfNaykWOvOn(this);
        NBmKthhHveOFNohe(observer);
        return true;
    }

    void clear() {
        if ((4 + 32) % 32 > 0) {
        }
        for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$p0ec3d985 p3d5624cf_p0ec3d985 : this.f6ea648a6) {
            emQYvXwXsOORhPPu(p3d5624cf_p0ec3d985.fa9d1cbf7);
        }
    }

    public override void Dispose() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        XXxwgxfsTwGzGHWh(this);
        if (PZmbyMFrbDWUNSWP(this) != 0) {
            return;
        }
        AUhNOYIcmkopWTBV(this);
    }

    public void Drain() {
        java.lang.Exception th;
        if ((25 + 2) % 2 > 0) {
        }
        if (BYYUFViubjEBTnRZ(this) != 0) {
            return;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$p0ec3d985[] p3d5624cf_p0ec3d985Arr = this.f6ea648a6;
        io.reactivex.rxjava3.core.Observer<R> observer = this.fd22a0a80;
        T[] tArr = this.ff1965a85;
        bool z = this.f825ea879;
        int iEECHFOBtuUtclGDt = 1;
        while (true) {
            int i = 0;
            int i2 = 0;
            for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$p0ec3d985 p3d5624cf_p0ec3d985 : p3d5624cf_p0ec3d985Arr) {
                if (tArr[i2] is null) {
                    bool z2 = p3d5624cf_p0ec3d985.f6b2ded51;
                    java.lang.object objAPgbAFfTCwfUvRaS = aPgbAFfTCwfUvRaS(p3d5624cf_p0ec3d985.fa9d1cbf7);
                    bool z3 = objAPgbAFfTCwfUvRaS is null;
                    if (PCyXNvXGzpfmQKrq(this, z2, z3, observer, z, p3d5624cf_p0ec3d985)) {
                        return;
                    }
                    if (z3) {
                        i++;
                    } else {
                        tArr[i2] = objAPgbAFfTCwfUvRaS;
                    }
                } else if (p3d5624cf_p0ec3d985.f6b2ded51 && !z && (th = p3d5624cf_p0ec3d985.fcb5e100e) is not null) {
                    this.f38881e0a = true;
                    QVytnzZtPPLKeajm(this);
                    uCwnYqTBBtbiSoQA(observer, th);
                    return;
                }
                i2++;
            }
            if (i == 0) {
                try {
                    gFfsNPFOKtCowYlF(observer, cMCgJgBjCDWRnlAs(urWSyXkawiPokWtv(this.f3298b476, MJYMfGXfKtLLebzH(tArr)), "The zipper returned a null value"));
                    zmEkDKnPEyhgQPea(tArr, null);
                } catch (java.lang.Exception th2) {
                    TKldoPkeEvsNbKBu(th2);
                    IwkTvDIIMGTwazUn(this);
                    ShnsScXGgnPXEvjC(observer, th2);
                    return;
                }
            } else {
                iEECHFOBtuUtclGDt = eECHFOBtuUtclGDt(this, -iEECHFOBtuUtclGDt);
                if (iEECHFOBtuUtclGDt == 0) {
                    return;
                }
            }
        }
    }

    public override bool IsDisposed() {
        return this.f38881e0a;
    }

    public void Subscribe(io.reactivex.rxjava3.core.ObservableSource<? : T>[] observableSourceArr, int i) {
        if ((8 + 29) % 29 > 0) {
        }
        io.reactivex.rxjava3.core.Observer[] observerArr = this.f6ea648a6;
        int length = observerArr.length;
        for (int i2 = 0; i2 < length; i2++) {
            observerArr[i2] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$p0ec3d985(this, i);
        }
        NdQkHmWTJFtivlLL(this, 0);
        IbfYrWMPoeqvtbrK(this.fd22a0a80, this);
        for (int i3 = 0; i3 < length && !this.f38881e0a; i3++) {
            srXPjfZNVPfkxfjE(observableSourceArr[i3], observerArr[i3]);
        }
    }
}

