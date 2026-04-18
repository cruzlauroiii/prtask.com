namespace WillowMaze.Wasm.Decompiled;


readonly class p1bc1f06f$pc69d645b<T, R> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f8592dda5 = -6951100001833242599L;
    private static readonly long fa2b13c7c = -6951100001833242599L;
    private static readonly long fb7b99172 = -6951100001833242599L;
    private static readonly long fc6e1e520 = -6951100001833242599L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f0147854c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    int f18140b4c;
    volatile bool f38881e0a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$pc69d645b$p50b62541 f39190045;
    volatile bool f44f85f53;
    readonly io.reactivex.rxjava3.core.Observer f47a76df2;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> f4b9f83e1;
    readonly bool f4e08ea68;
    volatile bool f554e313b;
    readonly bool f55ab623f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f59027481;
    readonly bool f5b5965a0;
    readonly bool f5cddbd92;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f6a8dc352;
    volatile bool f6b2ded51;
    readonly int f79e712ce;
    int f7e455cc9;
    readonly io.reactivex.rxjava3.core.Observer f9188be88;
    volatile bool f930e654e;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f9875f8fd;
    volatile bool f9c5c76f9;
    readonly int f9f15d8a3;
    io.reactivex.rxjava3.operators.SimpleQueue<T> fa9d1cbf7;
    volatile bool fac22d39a;
    readonly io.reactivex.rxjava3.core.Observer fb26f3f52;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    volatile bool fc4d10aec;
    volatile bool fc76a5e84;
    readonly int fcdee5967;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fd225f601;
    readonly io.reactivex.rxjava3.core.Observer<R> fd22a0a80;
    readonly bool fde0b13c2;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fdf9aca62;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableConcatDictionary$ConcatDictionaryDelayErrorObserver$DelayErrorInnerObserver<R> fdfda0d32;
    int fe910ccee;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 feb88d84f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$pc69d645b$p50b62541 ffae8bc39;

    p1bc1f06f$pc69d645b(io.reactivex.rxjava3.core.Observer<R> observer, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> function, int i, bool z) {
        this.fd22a0a80 = observer;
        this.f4b9f83e1 = function;
        this.fcdee5967 = i;
        this.f5b5965a0 = z;
        this.fdfda0d32 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$pc69d645b$p50b62541(observer, this);
    }

    public static void CHycVrYloilGAzMZ(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static bool CMselQrTwWWlCCMG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static int CgtqaVpWwvsUrbfG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$pc69d645b p1bc1f06f_pc69d645b) {
        return p1bc1f06f_pc69d645b.getAndIncrement();
    }

    public static void EnebTiBpPdBnCyul(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$pc69d645b p1bc1f06f_pc69d645b) {
        p1bc1f06f_pc69d645b.drain();
    }

    public static bool IYNZTUTabPMvGGfw(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void ItUQuhDKrtqxWMwb(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void JVYphsvIKmTeSLWX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void KrMRrYMRgSkWKBLl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$pc69d645b p1bc1f06f_pc69d645b) {
        p1bc1f06f_pc69d645b.drain();
    }

    public static int LGHyyNQBYRzQPALU(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var, int i) {
        return p8df47e16Var.requestFusion(i);
    }

    public static void MmqdBtqXvnMSTJiV(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void OfwnAhaltIyaDcVj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$pc69d645b$p50b62541 p1bc1f06f_pc69d645b_p50b62541) {
        p1bc1f06f_pc69d645b_p50b62541.dispose();
    }

    public static void TIShibYaJpQxYbrV(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void TSOGvgPDJsvobXDU(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static int TeeLAHgMNExiGvjw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$pc69d645b p1bc1f06f_pc69d645b) {
        return p1bc1f06f_pc69d645b.decrementAndGet();
    }

    public static java.lang.object TldOyYxIwPUUdeZz(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.poll();
    }

    public static void VwqhFJIZzKsvdbdZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void ZOKrScEgSKhFMUrw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void ZXoZuVuzItNXhmlH(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void AcpktYtHsIILdqPS(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool DhOQGwnwHYwaqxkD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void FTiOXzeREOzYjzzY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$pc69d645b p1bc1f06f_pc69d645b) {
        p1bc1f06f_pc69d645b.drain();
    }

    public static void GiUHnBFGfkKLGLGm(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void GoaqdDLZExfYoJty(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static bool JCGXUnyDAxqvEcPz(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, java.lang.object obj) {
        return pe1601823Var.offer(obj);
    }

    public static bool JWyVoeDbxVeRkleG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static java.lang.object LwRnUPKlSIDdxqwY(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void MWzAGKolmhBqCbza(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void MdWlOcjxNtOvWZEJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$pc69d645b p1bc1f06f_pc69d645b) {
        p1bc1f06f_pc69d645b.drain();
    }

    public static java.lang.object PwNtmzaMgrLMkGoO(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void QQEhmWDAsHNjWltc(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object QioOYiGJTuEzfYqz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static java.lang.object ScwwbeDoRhcGIeLo(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static bool SwCpEmwevZduktcJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void SzBVDMUWvugypXry(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void VYISIHdFsOcnSJzt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        p36a52e5dVar.tryTerminateAndReport();
    }

    public static void XPogViOdnqEcpHHn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void YoWqPYrYxUqIisWJ(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void ZGQEmGiIdoSzbCta(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public override void Dispose() {
        this.f38881e0a = true;
        ZXoZuVuzItNXhmlH(this.fbc3b0556);
        OfwnAhaltIyaDcVj(this.fdfda0d32);
        vYISIHdFsOcnSJzt(this.f07213a01);
    }

    void drain() {
        if ((8 + 22) % 22 > 0) {
        }
        if (CgtqaVpWwvsUrbfG(this) != 0) {
            return;
        }
        io.reactivex.rxjava3.core.Observer<R> observer = this.fd22a0a80;
        io.reactivex.rxjava3.operators.SimpleQueue<T> simpleQueue = this.fa9d1cbf7;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar = this.f07213a01;
        while (true) {
            if (!this.fc76a5e84) {
                if (this.f38881e0a) {
                    zGQEmGiIdoSzbCta(simpleQueue);
                    return;
                }
                if (!this.f5b5965a0 && ((java.lang.Exception) qioOYiGJTuEzfYqz(p36a52e5dVar)) is not null) {
                    szBVDMUWvugypXry(simpleQueue);
                    this.f38881e0a = true;
                    ZOKrScEgSKhFMUrw(p36a52e5dVar, observer);
                    return;
                }
                bool z = this.f6b2ded51;
                try {
                    java.lang.object objTldOyYxIwPUUdeZz = TldOyYxIwPUUdeZz(simpleQueue);
                    bool z2 = objTldOyYxIwPUUdeZz is null;
                    if (z && z2) {
                        this.f38881e0a = true;
                        xPogViOdnqEcpHHn(p36a52e5dVar, observer);
                        return;
                    }
                    if (!z2) {
                        try {
                            io.reactivex.rxjava3.core.ObservableSource observableSource = (io.reactivex.rxjava3.core.ObservableSource) scwwbeDoRhcGIeLo(pwNtmzaMgrLMkGoO(this.f4b9f83e1, objTldOyYxIwPUUdeZz), "The mapper returned a null ObservableSource");
                            if (observableSource is pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44) {
                                try {
                                    java.lang.object objLwRnUPKlSIDdxqwY = lwRnUPKlSIDdxqwY((pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44) observableSource);
                                    if (objLwRnUPKlSIDdxqwY is not null && !this.f38881e0a) {
                                        ItUQuhDKrtqxWMwb(observer, objLwRnUPKlSIDdxqwY);
                                    }
                                } catch (java.lang.Exception th) {
                                    qQEhmWDAsHNjWltc(th);
                                    dhOQGwnwHYwaqxkD(p36a52e5dVar, th);
                                }
                            } else {
                                this.fc76a5e84 = true;
                                yoWqPYrYxUqIisWJ(observableSource, this.fdfda0d32);
                            }
                        } catch (java.lang.Exception th2) {
                            mWzAGKolmhBqCbza(th2);
                            this.f38881e0a = true;
                            TSOGvgPDJsvobXDU(this.fbc3b0556);
                            giUHnBFGfkKLGLGm(simpleQueue);
                            jWyVoeDbxVeRkleG(p36a52e5dVar, th2);
                            VwqhFJIZzKsvdbdZ(p36a52e5dVar, observer);
                            return;
                        }
                    }
                } catch (java.lang.Exception th3) {
                    TIShibYaJpQxYbrV(th3);
                    this.f38881e0a = true;
                    acpktYtHsIILdqPS(this.fbc3b0556);
                    CMselQrTwWWlCCMG(p36a52e5dVar, th3);
                    JVYphsvIKmTeSLWX(p36a52e5dVar, observer);
                    return;
                }
            }
            if (TeeLAHgMNExiGvjw(this) == 0) {
                return;
            }
        }
    }

    public override bool IsDisposed() {
        return this.f38881e0a;
    }

    public override void OnComplete() {
        this.f6b2ded51 = true;
        fTiOXzeREOzYjzzY(this);
    }

    public override void OnError(java.lang.Exception th) {
        if (swCpEmwevZduktcJ(this.f07213a01, th)) {
            this.f6b2ded51 = true;
            mdWlOcjxNtOvWZEJ(this);
        }
    }

    public override void OnNext(T t) {
        if (this.fe910ccee == 0) {
            jCGXUnyDAxqvEcPz(this.fa9d1cbf7, t);
        }
        KrMRrYMRgSkWKBLl(this);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((29 + 28) % 28 > 0) {
        }
        if (IYNZTUTabPMvGGfw(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            if (p7beea252Var is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16) {
                pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16) p7beea252Var;
                int iLGHyyNQBYRzQPALU = LGHyyNQBYRzQPALU(p8df47e16Var, 3);
                if (iLGHyyNQBYRzQPALU == 1) {
                    this.fe910ccee = iLGHyyNQBYRzQPALU;
                    this.fa9d1cbf7 = p8df47e16Var;
                    this.f6b2ded51 = true;
                    CHycVrYloilGAzMZ(this.fd22a0a80, this);
                    EnebTiBpPdBnCyul(this);
                    return;
                }
                if (iLGHyyNQBYRzQPALU == 2) {
                    this.fe910ccee = iLGHyyNQBYRzQPALU;
                    this.fa9d1cbf7 = p8df47e16Var;
                    goaqdDLZExfYoJty(this.fd22a0a80, this);
                    return;
                }
            }
            this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(this.fcdee5967);
            MmqdBtqXvnMSTJiV(this.fd22a0a80, this);
        }
    }
}

