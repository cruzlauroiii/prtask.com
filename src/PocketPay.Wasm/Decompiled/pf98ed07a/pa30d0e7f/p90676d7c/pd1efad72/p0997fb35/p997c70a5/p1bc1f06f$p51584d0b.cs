namespace WillowMaze.Wasm.Decompiled;


readonly class p1bc1f06f$p51584d0b<T, U> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f562366a3 = 8828587559905699186L;
    private static readonly long fc6e1e520 = 8828587559905699186L;
    int f06b7c4ff;
    volatile bool f108cf0cc;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f2309d423;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 f2a268b8c;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 f2ddfdd63;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$p51584d0b$p9192f42a f300f0f6a;
    readonly io.reactivex.rxjava3.core.Observer f3f2298d1;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : U>> f4b9f83e1;
    readonly io.reactivex.rxjava3.core.Observer f4e281bd2;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 f534eb23b;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 f5a8d9587;
    volatile bool f6b2ded51;
    volatile bool f828eaf54;
    volatile bool f985479b6;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f9d804b9f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$p51584d0b$p9192f42a fa949bba0;
    io.reactivex.rxjava3.operators.SimpleQueue<T> fa9d1cbf7;
    volatile bool fbb139ea3;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    volatile bool fbc7641df;
    readonly int fc0d50686;
    volatile bool fc69091a3;
    volatile bool fc76a5e84;
    volatile bool fc83bfd30;
    readonly int fcdee5967;
    int fce492fa8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fcfc8573d;
    readonly io.reactivex.rxjava3.core.Observer<U> fd22a0a80;
    volatile bool fd4edc376;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$p51584d0b$p9192f42a fdc3e265f;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fea5492eb;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableConcatDictionary$SourceObserver$InnerObserver<U> fea97586b;
    volatile bool ff8b2648d;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ff8dd075f;
    readonly io.reactivex.rxjava3.core.Observer fff3bce81;

    p1bc1f06f$p51584d0b(io.reactivex.rxjava3.core.Observer<U> observer, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : U>> function, int i) {
        this.fd22a0a80 = observer;
        this.f4b9f83e1 = function;
        this.fcdee5967 = i;
        this.fea97586b = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$p51584d0b$p9192f42a(observer, this);
    }

    public static bool AaWvphhbkOIgaTUc(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, java.lang.object obj) {
        return pe1601823Var.offer(obj);
    }

    public static int CEmpgnLKxtEVFQIL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$p51584d0b p1bc1f06f_p51584d0b) {
        return p1bc1f06f_p51584d0b.getAndIncrement();
    }

    public static void DRrIRwKoZJJrUVQE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$p51584d0b p1bc1f06f_p51584d0b) {
        p1bc1f06f_p51584d0b.dispose();
    }

    public static void GzGUSUExTUgoVLLr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$p51584d0b p1bc1f06f_p51584d0b) {
        p1bc1f06f_p51584d0b.drain();
    }

    public static void HgoDVzcNVDLCVaLj(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static bool IvMXEzvesAKkZfLB(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void KyOqPLxePFCGuUAN(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void LgJHbLsYBKmDasZV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$p51584d0b p1bc1f06f_p51584d0b) {
        p1bc1f06f_p51584d0b.dispose();
    }

    public static void LzUzvTEJuXoHjjwu(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void PsKhlOvecDElOrTZ(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void RMqcFGRBDcwRXhXu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$p51584d0b p1bc1f06f_p51584d0b) {
        p1bc1f06f_p51584d0b.drain();
    }

    public static java.lang.object SpnyYadKbpjAYElY(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.poll();
    }

    public static java.lang.object AbxkYyMzCmDqddcD(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static int BqZRoEeoqQYXWMWM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$p51584d0b p1bc1f06f_p51584d0b) {
        return p1bc1f06f_p51584d0b.getAndIncrement();
    }

    public static int GCXdSkElplkuctPA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$p51584d0b p1bc1f06f_p51584d0b) {
        return p1bc1f06f_p51584d0b.decrementAndGet();
    }

    public static int HKJRJEvFbnLPbbSi(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var, int i) {
        return p8df47e16Var.requestFusion(i);
    }

    public static void IQIRNdWJBxPYgRkg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$p51584d0b p1bc1f06f_p51584d0b) {
        p1bc1f06f_p51584d0b.drain();
    }

    public static void JcCmZfZDqhMdXGqJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$p51584d0b p1bc1f06f_p51584d0b) {
        p1bc1f06f_p51584d0b.dispose();
    }

    public static void KsqItKYRvgEVgxBe(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void MJNImWUlPjvLHBFd(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void NVFctmgnBSYKmNwT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$p51584d0b$p9192f42a p1bc1f06f_p51584d0b_p9192f42a) {
        p1bc1f06f_p51584d0b_p9192f42a.dispose();
    }

    public static void NsOUhpjTttUKClDj(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void NsZDBdKIFAodolCD(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void NuIVZznAgTECBTHE(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void QiFyhzZWXJYspFDS(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void RyRkMUMSLJYhZnBy(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void SaoTZHnfnadwfybj(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void TRtrYFFknUUnBUQi(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void TmPhAGVecmhwrmYI(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void TvDXQSwHEtvkQTOz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$p51584d0b p1bc1f06f_p51584d0b) {
        p1bc1f06f_p51584d0b.drain();
    }

    public static void VLhjZhOwqHPVpSKx(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void WgrdKGmnlkClrIEw(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static java.lang.object ZZgZTKhhCnnMbIlF(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public override void Dispose() {
        this.ff8b2648d = true;
        nVFctmgnBSYKmNwT(this.fea97586b);
        LzUzvTEJuXoHjjwu(this.fbc3b0556);
        if (CEmpgnLKxtEVFQIL(this) != 0) {
            return;
        }
        tRtrYFFknUUnBUQi(this.fa9d1cbf7);
    }

    void drain() {
        if ((1 + 15) % 15 > 0) {
        }
        if (bqZRoEeoqQYXWMWM(this) == 0) {
            while (!this.ff8b2648d) {
                if (!this.fc76a5e84) {
                    bool z = this.f6b2ded51;
                    try {
                        java.lang.object objSpnyYadKbpjAYElY = SpnyYadKbpjAYElY(this.fa9d1cbf7);
                        bool z2 = objSpnyYadKbpjAYElY is null;
                        if (z && z2) {
                            this.ff8b2648d = true;
                            vLhjZhOwqHPVpSKx(this.fd22a0a80);
                            return;
                        } else if (!z2) {
                            try {
                                io.reactivex.rxjava3.core.ObservableSource observableSource = (io.reactivex.rxjava3.core.ObservableSource) abxkYyMzCmDqddcD(zZgZTKhhCnnMbIlF(this.f4b9f83e1, objSpnyYadKbpjAYElY), "The mapper returned a null ObservableSource");
                                this.fc76a5e84 = true;
                                nuIVZznAgTECBTHE(observableSource, this.fea97586b);
                            } catch (java.lang.Exception th) {
                                KyOqPLxePFCGuUAN(th);
                                jcCmZfZDqhMdXGqJ(this);
                                ryRkMUMSLJYhZnBy(this.fa9d1cbf7);
                                ksqItKYRvgEVgxBe(this.fd22a0a80, th);
                                return;
                            }
                        }
                    } catch (java.lang.Exception th2) {
                        mJNImWUlPjvLHBFd(th2);
                        DRrIRwKoZJJrUVQE(this);
                        wgrdKGmnlkClrIEw(this.fa9d1cbf7);
                        nsOUhpjTttUKClDj(this.fd22a0a80, th2);
                        return;
                    }
                }
                if (gCXdSkElplkuctPA(this) == 0) {
                    return;
                }
            }
            tmPhAGVecmhwrmYI(this.fa9d1cbf7);
        }
    }

    void innerComplete() {
        this.fc76a5e84 = false;
        iQIRNdWJBxPYgRkg(this);
    }

    public override bool IsDisposed() {
        return this.ff8b2648d;
    }

    public override void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        tvDXQSwHEtvkQTOz(this);
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            qiFyhzZWXJYspFDS(th);
            return;
        }
        this.f6b2ded51 = true;
        LgJHbLsYBKmDasZV(this);
        saoTZHnfnadwfybj(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        if (this.f06b7c4ff == 0) {
            AaWvphhbkOIgaTUc(this.fa9d1cbf7, t);
        }
        RMqcFGRBDcwRXhXu(this);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((13 + 19) % 19 > 0) {
        }
        if (IvMXEzvesAKkZfLB(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            if (p7beea252Var is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16) {
                pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16) p7beea252Var;
                int iHKJRJEvFbnLPbbSi = hKJRJEvFbnLPbbSi(p8df47e16Var, 3);
                if (iHKJRJEvFbnLPbbSi == 1) {
                    this.f06b7c4ff = iHKJRJEvFbnLPbbSi;
                    this.fa9d1cbf7 = p8df47e16Var;
                    this.f6b2ded51 = true;
                    HgoDVzcNVDLCVaLj(this.fd22a0a80, this);
                    GzGUSUExTUgoVLLr(this);
                    return;
                }
                if (iHKJRJEvFbnLPbbSi == 2) {
                    this.f06b7c4ff = iHKJRJEvFbnLPbbSi;
                    this.fa9d1cbf7 = p8df47e16Var;
                    PsKhlOvecDElOrTZ(this.fd22a0a80, this);
                    return;
                }
            }
            this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(this.fcdee5967);
            nsZDBdKIFAodolCD(this.fd22a0a80, this);
        }
    }
}

