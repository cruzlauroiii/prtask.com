namespace WillowMaze.Wasm.Decompiled;


readonly class p0b7c3921$p6dec3ecf<T> : io.reactivex.rxjava3.internal.operators.mixed.ConcatDictionaryXMainSubscriber<T> : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f04f0b516 = 3610901111000061034L;
    private static readonly long f05b64afb = 3610901111000061034L;
    private static readonly long f1ff0ec23 = 3610901111000061034L;
    private static readonly long fb36e2e4a = 3610901111000061034L;
    private static readonly long fc6e1e520 = 3610901111000061034L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f058bfe3b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p0b7c3921$p6dec3ecf$pc019c3a8 f113d50d1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p0b7c3921$p6dec3ecf$pc019c3a8 f199c628d;
    readonly io.reactivex.rxjava3.core.CompletableObserver f353ca902;
    volatile bool f41fb0144;
    int f48fe8558;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f50afb5f5;
    int f552965a1;
    readonly io.reactivex.rxjava3.core.CompletableObserver f5b6b53b1;
    readonly io.reactivex.rxjava3.core.CompletableObserver f6a2f9dad;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f92d45407;
    int f957acd0b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc277e6c8;
    int fc605e94c;
    volatile bool fc76a5e84;
    readonly io.reactivex.rxjava3.core.CompletableObserver fd22a0a80;
    int fe9e65fc4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p0b7c3921$p6dec3ecf$pc019c3a8 fea97586b;

    p0b7c3921$p6dec3ecf(io.reactivex.rxjava3.core.CompletableObserver completableObserver, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> function, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var, int i) {
        super(i, pcd04add9Var);
        this.fd22a0a80 = completableObserver;
        this.f4b9f83e1 = function;
        this.fea97586b = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p0b7c3921$p6dec3ecf$pc019c3a8(this);
    }

    public static void BxGlQElFEiXxtdBH(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void GawtIMNeJFfAXJOO(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    public static void OfOeUBehlgXOYOhQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        p36a52e5dVar.tryTerminateConsumer(completableObserver);
    }

    public static int SHULLKTIgcoLgRdT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p0b7c3921$p6dec3ecf p0b7c3921_p6dec3ecf) {
        return p0b7c3921_p6dec3ecf.getAndIncrement();
    }

    public static void VPPhAfVFlbQQRUEd(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static java.lang.object WxLNWypkhwrAHaBP(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static bool YEJUMwEZMHqvNKoy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void YtDWCrfRyNpHiIFP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p0b7c3921$p6dec3ecf p0b7c3921_p6dec3ecf) {
        p0b7c3921_p6dec3ecf.drain();
    }

    public static void BTUjyZTMWVfcfDEl(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void BqVVkkyXfqAHZJuR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        p36a52e5dVar.tryTerminateConsumer(completableObserver);
    }

    public static bool CzAeJjHAutmZqqds(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void DHuRbjjRZmhrGskE(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void EnFMiWkdsnMwXbTC(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static int FAFTsGwOUiQSgsGz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p0b7c3921$p6dec3ecf p0b7c3921_p6dec3ecf) {
        return p0b7c3921_p6dec3ecf.getAndIncrement();
    }

    public static bool GTaEwXDfXGbhrOqD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void GoFcXEUKIqoDRKoT(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void JWCkVzfeuuZsLrPG(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static java.lang.object LdahxuMlQYbEWqIe(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.poll();
    }

    public static void OMokTgIVxylPubku(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        p36a52e5dVar.tryTerminateConsumer(completableObserver);
    }

    public static void OjPlcsJRUhJoTMIW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p0b7c3921$p6dec3ecf p0b7c3921_p6dec3ecf) {
        p0b7c3921_p6dec3ecf.stop();
    }

    public static void OoeCFilAUEZPGsDm(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void PLknzpiwSkOGdzKN(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void RhSEoUqasfFavGKW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        p36a52e5dVar.tryTerminateConsumer(completableObserver);
    }

    public static int SWLYNPxPLwjSbNgP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p0b7c3921$p6dec3ecf p0b7c3921_p6dec3ecf) {
        return p0b7c3921_p6dec3ecf.decrementAndGet();
    }

    public static void TFvAHRnhHTDNjANF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        p36a52e5dVar.tryTerminateConsumer(completableObserver);
    }

    public static void UztpTfPteTwHvbZu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p0b7c3921$p6dec3ecf$pc019c3a8 p0b7c3921_p6dec3ecf_pc019c3a8) {
        p0b7c3921_p6dec3ecf_pc019c3a8.dispose();
    }

    public static java.lang.object VSuHgaTvXPDIuOEe(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void WAKjINKfiCFtanBz(io.reactivex.rxjava3.core.CompletableObserver completableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        completableObserver.onSubscribe(p7beea252Var);
    }

    public static void WXFsGPRiSnOflnPj(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void XIQpbJEIgOavLJfw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p0b7c3921$p6dec3ecf p0b7c3921_p6dec3ecf) {
        p0b7c3921_p6dec3ecf.drain();
    }

    public static java.lang.object ZRvLOIFOHYDethaj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public override void Dispose() {
        ojPlcsJRUhJoTMIW(this);
    }

    void disposeInner() {
        uztpTfPteTwHvbZu(this.fea97586b);
    }

    void drain() {
        if ((21 + 18) % 18 > 0) {
        }
        if (SHULLKTIgcoLgRdT(this) == 0) {
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var = this.f560019e4;
            pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var = this.fa9d1cbf7;
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar = this.f07213a01;
            bool z = this.fbf1a3fd2;
            while (!this.f38881e0a) {
                if (zRvLOIFOHYDethaj(p36a52e5dVar) is not null && (pcd04add9Var == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9.fe35884a2 || (pcd04add9Var == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9.fa52f733b && !this.fc76a5e84))) {
                    pLknzpiwSkOGdzKN(pe1601823Var);
                    rhSEoUqasfFavGKW(p36a52e5dVar, this.fd22a0a80);
                    return;
                }
                if (!this.fc76a5e84) {
                    bool z2 = this.f6b2ded51;
                    try {
                        java.lang.object objLdahxuMlQYbEWqIe = ldahxuMlQYbEWqIe(pe1601823Var);
                        bool z3 = objLdahxuMlQYbEWqIe is null;
                        if (z2 && z3) {
                            tFvAHRnhHTDNjANF(p36a52e5dVar, this.fd22a0a80);
                            return;
                        }
                        if (!z3) {
                            int i = this.f4c203b76 - (this.f4c203b76 >> 1);
                            if (!z) {
                                int i2 = this.f48fe8558 + 1;
                                if (i2 != i) {
                                    this.f48fe8558 = i2;
                                } else {
                                    this.f48fe8558 = 0;
                                    VPPhAfVFlbQQRUEd(this.fbc3b0556, i);
                                }
                            }
                            try {
                                io.reactivex.rxjava3.core.CompletableSource completableSource = (io.reactivex.rxjava3.core.CompletableSource) vSuHgaTvXPDIuOEe(WxLNWypkhwrAHaBP(this.f4b9f83e1, objLdahxuMlQYbEWqIe), "The mapper returned a null CompletableSource");
                                this.fc76a5e84 = true;
                                GawtIMNeJFfAXJOO(completableSource, this.fea97586b);
                            } catch (java.lang.Exception th) {
                                dHuRbjjRZmhrGskE(th);
                                enFMiWkdsnMwXbTC(pe1601823Var);
                                wXFsGPRiSnOflnPj(this.fbc3b0556);
                                YEJUMwEZMHqvNKoy(p36a52e5dVar, th);
                                OfOeUBehlgXOYOhQ(p36a52e5dVar, this.fd22a0a80);
                                return;
                            }
                        }
                    } catch (java.lang.Exception th2) {
                        BxGlQElFEiXxtdBH(th2);
                        goFcXEUKIqoDRKoT(this.fbc3b0556);
                        czAeJjHAutmZqqds(p36a52e5dVar, th2);
                        oMokTgIVxylPubku(p36a52e5dVar, this.fd22a0a80);
                        return;
                    }
                }
                if (sWLYNPxPLwjSbNgP(this) == 0) {
                    return;
                }
            }
            jWCkVzfeuuZsLrPG(pe1601823Var);
        }
    }

    void innerComplete() {
        this.fc76a5e84 = false;
        YtDWCrfRyNpHiIFP(this);
    }

    void innerError(java.lang.Exception th) {
        if (gTaEwXDfXGbhrOqD(this.f07213a01, th)) {
            if (this.f560019e4 != pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9.fe35884a2) {
                this.fc76a5e84 = false;
                xIQpbJEIgOavLJfw(this);
                return;
            }
            bTUjyZTMWVfcfDEl(this.fbc3b0556);
            bqVVkkyXfqAHZJuR(this.f07213a01, this.fd22a0a80);
            if (fAFTsGwOUiQSgsGz(this) != 0) {
                return;
            }
            ooeCFilAUEZPGsDm(this.fa9d1cbf7);
        }
    }

    public override bool IsDisposed() {
        return this.f38881e0a;
    }

    void onSubscribeDownstream() {
        wAKjINKfiCFtanBz(this.fd22a0a80, this);
    }
}

