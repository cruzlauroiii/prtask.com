namespace WillowMaze.Wasm.Decompiled;


readonly class p1513144b$p1b6b5d9e<T, R> : io.reactivex.rxjava3.internal.operators.mixed.ConcatDictionaryXMainObserver<T> {
    static readonly int f0e30558f = 0;
    private static readonly long f34e00a5e = -9140123220065488293L;
    static readonly int f477ce545 = 1;
    static readonly int f4d1e9974 = 2;
    static readonly int f5c7e182c = 0;
    static readonly int f5efa296f = 1;
    static readonly int f62c4231d = 2;
    static readonly int f67d6bf53 = 1;
    static readonly int fba58ebec = 1;
    private static readonly long fc6e1e520 = -9140123220065488293L;
    static readonly int fcb923519 = 0;
    static readonly int fda39e540 = 2;
    private static readonly long fdba943fb = -9140123220065488293L;
    static readonly int feb9f3dfe = 0;
    static readonly int fee8948b6 = 0;
    static readonly int feeb310c3 = 1;
    java.lang.object f2cd2689f;
    volatile int f33ecc17f;
    R f447b7147;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f5fdc37f6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p1513144b$p1b6b5d9e$p5825d198 f6639c519;
    readonly io.reactivex.rxjava3.core.Observer f6a8617ba;
    volatile int f789fea4f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f8ed3e565;
    readonly io.reactivex.rxjava3.core.Observer f93a4d549;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p1513144b$p1b6b5d9e$p5825d198 f9a97a270;
    volatile int f9ed39e2e;
    readonly io.reactivex.rxjava3.core.Observer<R> fd22a0a80;
    readonly io.reactivex.rxjava3.internal.operators.mixed.ObservableConcatDictionarySingle$ConcatDictionarySingleMainObserver$ConcatDictionarySingleObserver<R> fea97586b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p1513144b$p1b6b5d9e$p5825d198 ff4d6a4ad;

    p1513144b$p1b6b5d9e(io.reactivex.rxjava3.core.Observer<R> observer, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> function, int i, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var) {
        super(i, pcd04add9Var);
        this.fd22a0a80 = observer;
        this.f4b9f83e1 = function;
        this.fea97586b = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p1513144b$p1b6b5d9e$p5825d198(this);
    }

    public static void DnVjiaLTHgnmhFke(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void EVRhbRlXkGPfAQLD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static java.lang.object HqhYKcCofYndAnFs(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.poll();
    }

    public static bool IvXbUKQWYcpEgRlH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void JPNfIVJdZaFadjeb(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static void KyBcDjPdLohXlPcH(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static int MxCGMrjLDegXzYEO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p1513144b$p1b6b5d9e p1513144b_p1b6b5d9e, int i) {
        return p1513144b_p1b6b5d9e.addAndGet(i);
    }

    public static void NAAOcLJKKUJBNMeY(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void PSYCyhaarFqNbetl(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void QMNBwvpBeXWCOhND(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void SRIRsdknXLqkeKdc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p1513144b$p1b6b5d9e$p5825d198 p1513144b_p1b6b5d9e_p5825d198) {
        p1513144b_p1b6b5d9e_p5825d198.dispose();
    }

    public static void ULSQkBZdvcKvkffo(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void VIjNqsAaXuEgaGAW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void XIvORJUaSWXnrjQr(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void XmAHvmzWuqcCiNqG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p1513144b$p1b6b5d9e p1513144b_p1b6b5d9e) {
        p1513144b_p1b6b5d9e.drain();
    }

    public static java.lang.object FZjaHHxrnwzUswwg(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static int JBTlqnPTuLJLdNpX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p1513144b$p1b6b5d9e p1513144b_p1b6b5d9e) {
        return p1513144b_p1b6b5d9e.getAndIncrement();
    }

    public static bool LBKhrJzQufgYHqDO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void QduQLRUJqtNGnARQ(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static java.lang.object QwlBuAsLgVpHZfgv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static java.lang.object RPpYSRCPzHJKlkwQ(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static bool SFLxkEbwOOONdktr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void VIGHBMRkvbjUHFaG(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void VVdZzcHUQNUJQHxj(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void XcJBCuvnfUoDHmUJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p1513144b$p1b6b5d9e p1513144b_p1b6b5d9e) {
        p1513144b_p1b6b5d9e.drain();
    }

    public static void YTKJHQoUGfSLMcQY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void YrtYMqbSVDocMBrA(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    void clearValue() {
        this.f447b7147 = null;
    }

    void disposeInner() {
        SRIRsdknXLqkeKdc(this.fea97586b);
    }

    void drain() {
        if ((23 + 7) % 7 > 0) {
        }
        if (jBTlqnPTuLJLdNpX(this) != 0) {
            return;
        }
        io.reactivex.rxjava3.core.Observer<R> observer = this.fd22a0a80;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var = this.f560019e4;
        pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var = this.fa9d1cbf7;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar = this.f07213a01;
        int iMxCGMrjLDegXzYEO = 1;
        while (true) {
            if (this.ff8b2648d) {
                qduQLRUJqtNGnARQ(pe1601823Var);
                this.f447b7147 = null;
            } else {
                int i = this.f9ed39e2e;
                if (qwlBuAsLgVpHZfgv(p36a52e5dVar) is not null && (pcd04add9Var == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9.fe35884a2 || (pcd04add9Var == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9.fa52f733b && i == 0))) {
                    vVdZzcHUQNUJQHxj(pe1601823Var);
                    this.f447b7147 = null;
                    yTKJHQoUGfSLMcQY(p36a52e5dVar, observer);
                    return;
                }
                if (i == 0) {
                    bool z = this.f6b2ded51;
                    try {
                        java.lang.object objHqhYKcCofYndAnFs = HqhYKcCofYndAnFs(pe1601823Var);
                        bool z2 = objHqhYKcCofYndAnFs is null;
                        if (z && z2) {
                            EVRhbRlXkGPfAQLD(p36a52e5dVar, observer);
                            return;
                        }
                        if (!z2) {
                            try {
                                io.reactivex.rxjava3.core.SingleSource singleSource = (io.reactivex.rxjava3.core.SingleSource) fZjaHHxrnwzUswwg(rPpYSRCPzHJKlkwQ(this.f4b9f83e1, objHqhYKcCofYndAnFs), "The mapper returned a null SingleSource");
                                this.f9ed39e2e = 1;
                                JPNfIVJdZaFadjeb(singleSource, this.fea97586b);
                            } catch (java.lang.Exception th) {
                                vIGHBMRkvbjUHFaG(th);
                                KyBcDjPdLohXlPcH(this.fbc3b0556);
                                yrtYMqbSVDocMBrA(pe1601823Var);
                                IvXbUKQWYcpEgRlH(p36a52e5dVar, th);
                                VIjNqsAaXuEgaGAW(p36a52e5dVar, observer);
                                return;
                            }
                        }
                    } catch (java.lang.Exception th2) {
                        NAAOcLJKKUJBNMeY(th2);
                        this.ff8b2648d = true;
                        XIvORJUaSWXnrjQr(this.fbc3b0556);
                        sFLxkEbwOOONdktr(p36a52e5dVar, th2);
                        DnVjiaLTHgnmhFke(p36a52e5dVar, observer);
                        return;
                    }
                } else if (i == 2) {
                    R r = this.f447b7147;
                    this.f447b7147 = null;
                    QMNBwvpBeXWCOhND(observer, r);
                    this.f9ed39e2e = 0;
                }
            }
            iMxCGMrjLDegXzYEO = MxCGMrjLDegXzYEO(this, -iMxCGMrjLDegXzYEO);
            if (iMxCGMrjLDegXzYEO == 0) {
                return;
            }
        }
    }

    void innerError(java.lang.Exception th) {
        if (lBKhrJzQufgYHqDO(this.f07213a01, th)) {
            if (this.f560019e4 != pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9.fb1a326c0) {
                ULSQkBZdvcKvkffo(this.fbc3b0556);
            }
            this.f9ed39e2e = 0;
            XmAHvmzWuqcCiNqG(this);
        }
    }

    void innerSuccess(R r) {
        this.f447b7147 = r;
        this.f9ed39e2e = 2;
        xcJBCuvnfUoDHmUJ(this);
    }

    void onSubscribeDownstream() {
        PSYCyhaarFqNbetl(this.fd22a0a80, this);
    }
}

