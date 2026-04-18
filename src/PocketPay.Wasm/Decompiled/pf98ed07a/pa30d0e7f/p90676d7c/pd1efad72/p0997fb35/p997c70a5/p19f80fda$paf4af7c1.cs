namespace WillowMaze.Wasm.Decompiled;


readonly class p19f80fda$paf4af7c1<T> : io.reactivex.rxjava3.internal.observers.BasicIntQueueDisposable<T> : io.reactivex.rxjava3.core.Observer<T>, java.lang.Action {
    private static readonly long f0dde0b3a = 6576896619930983584L;
    private static readonly long f90a6eabf = 6576896619930983584L;
    private static readonly long f970b6434 = 6576896619930983584L;
    private static readonly long fc6e1e520 = 6576896619930983584L;
    int f077fc2a5;
    readonly bool f07c38299;
    bool f0f68e8b1;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 f12842cac;
    readonly int f13d3ca67;
    java.lang.Exception f26d95e78;
    readonly bool f2b9a8a58;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f2cbfa301;
    volatile bool f3642a5e1;
    readonly int f3eba745e;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f4541c3c4;
    bool f4d21df96;
    readonly io.reactivex.rxjava3.core.Observer f50bc798f;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f5d60c607;
    readonly bool f5d925d39;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f650aabc2;
    readonly int f68c6abf9;
    volatile bool f6b2ded51;
    int f82321efc;
    readonly bool f825ea879;
    readonly io.reactivex.rxjava3.core.Observer f8502997f;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f8bb0ae59;
    volatile bool f8e2dad72;
    volatile bool f8e9def82;
    readonly bool fa116193f;
    volatile bool fa1295fe8;
    bool fa893edea;
    io.reactivex.rxjava3.operators.SimpleQueue<T> fa9d1cbf7;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fb61822e8;
    int fb82d600a;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    volatile bool fcaadb176;
    java.lang.Exception fcb5e100e;
    readonly int fcdee5967;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fe3fc28ad;
    int fe910ccee;
    bool feb7ac3ad;
    volatile bool ff8b2648d;

    p19f80fda$paf4af7c1(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, bool z, int i) {
        this.fd22a0a80 = observer;
        this.fb61822e8 = scheduler$Worker;
        this.f825ea879 = z;
        this.fcdee5967 = i;
    }

    public static void AXQmNEnDXtJZCdQG(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void CVdqoFZmGhhjHwQP(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static int EFdsGuVHLbhOQfFE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p19f80fda$paf4af7c1 p19f80fda_paf4af7c1, int i) {
        return p19f80fda_paf4af7c1.addAndGet(i);
    }

    public static void EkCqdQnynShIbGcB(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static int HDpcPhbtNBqOCxcG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p19f80fda$paf4af7c1 p19f80fda_paf4af7c1) {
        return p19f80fda_paf4af7c1.getAndIncrement();
    }

    public static void IXlkHLQsOnqylwoo(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static bool JwXVvtyygihIcikj(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.Count == 0;
    }

    public static void KQcYOWKXxJhoudoE(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void KWbwFXskdnHszsNl(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void KcPHruXpDtewNpGx(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void LMFaehKxfgUDQQVJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p19f80fda$paf4af7c1 p19f80fda_paf4af7c1) {
        p19f80fda_paf4af7c1.schedule();
    }

    public static void McKlAYxLaqAhkCzl(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void MrrBlLsDOxGQHvxF(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void NDANgQDstSEadqWw(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void NPAuKVTxJpDHKhCh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p19f80fda$paf4af7c1 p19f80fda_paf4af7c1) {
        p19f80fda_paf4af7c1.drainNormal();
    }

    public static void NfeBwlQarurlFFEU(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void OarweEUxBVtunRgP(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static int OuihrzdEffLvslFC(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var, int i) {
        return p8df47e16Var.requestFusion(i);
    }

    public static java.lang.object PgllAUZYshUHqwfi(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.poll();
    }

    public static void UgZXfeXciACOYvaB(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void VAGMYUGbYcJlwcZa(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void YqAjSnccHNbGJkcD(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool BFLAxXuAUcOVFdwa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p19f80fda$paf4af7c1 p19f80fda_paf4af7c1, bool z, bool z2, io.reactivex.rxjava3.core.Observer observer) {
        return p19f80fda_paf4af7c1.checkTerminated(z, z2, observer);
    }

    public static void BPuVUbRVKlHXCWIR(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void DkGsMDVkDSuxZJPx(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void EENlzzHJzDdDvvCB(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void EftvLivtMQQNqQSL(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void FhORPYLVAwhetAye(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void GiLjZacLGEagIwDR(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void GijcCWxPvnaBqQXT(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void IrBKHGwpxvgqEcCi(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void JWzKgbNpPecvjIxO(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void JsiOACJZxzBvyakA(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static bool KJPJksqeNQyRDFJq(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void LjoQUoZosegQayaQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p19f80fda$paf4af7c1 p19f80fda_paf4af7c1) {
        p19f80fda_paf4af7c1.drainFused();
    }

    public static void NQRepQtEOwzXgpuc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p19f80fda$paf4af7c1 p19f80fda_paf4af7c1) {
        p19f80fda_paf4af7c1.schedule();
    }

    public static int NnXKzpPWAaKDrqbp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p19f80fda$paf4af7c1 p19f80fda_paf4af7c1, int i) {
        return p19f80fda_paf4af7c1.addAndGet(i);
    }

    public static bool NusIUCxmpetXLWbF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p19f80fda$paf4af7c1 p19f80fda_paf4af7c1, bool z, bool z2, io.reactivex.rxjava3.core.Observer observer) {
        return p19f80fda_paf4af7c1.checkTerminated(z, z2, observer);
    }

    public static int QgRrivWqkPPhzYQr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p19f80fda$paf4af7c1 p19f80fda_paf4af7c1) {
        return p19f80fda_paf4af7c1.getAndIncrement();
    }

    public static void SoUmcSnCUeAaHSbQ(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool UaKDAyLvZOmsVdSA(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.Count == 0;
    }

    public static void UpCwwVFiQkfWQwup(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static bool UuHwuXNIJOtUIgLM(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, java.lang.object obj) {
        return pe1601823Var.offer(obj);
    }

    public static java.lang.object VJVEYDHqhrzWAVFC(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.poll();
    }

    public static void WElKTfOEciWMEWrw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p19f80fda$paf4af7c1 p19f80fda_paf4af7c1) {
        p19f80fda_paf4af7c1.schedule();
    }

    public static void WKUvnAlDCVWtMFUW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p19f80fda$paf4af7c1 p19f80fda_paf4af7c1) {
        p19f80fda_paf4af7c1.schedule();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 XHHEdBKATwGHNEsm(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable) {
        return scheduler$Worker.schedule(runnable);
    }

    public static void YpvDIVXhijtvyVtp(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void YsqtYwKfymooKscr(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    bool checkTerminated(bool z, bool z2, io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((11 + 19) % 19 > 0) {
        }
        if (this.ff8b2648d) {
            dkGsMDVkDSuxZJPx(this.fa9d1cbf7);
            return true;
        }
        if (!z) {
            return false;
        }
        java.lang.Exception th = this.fcb5e100e;
        if (this.f825ea879) {
            if (!z2) {
                return false;
            }
            this.ff8b2648d = true;
            if (th is null) {
                OarweEUxBVtunRgP(observer);
            } else {
                eENlzzHJzDdDvvCB(observer, th);
            }
            fhORPYLVAwhetAye(this.fb61822e8);
            return true;
        }
        if (th is not null) {
            this.ff8b2648d = true;
            EkCqdQnynShIbGcB(this.fa9d1cbf7);
            jWzKgbNpPecvjIxO(observer, th);
            IXlkHLQsOnqylwoo(this.fb61822e8);
            return true;
        }
        if (!z2) {
            return false;
        }
        this.ff8b2648d = true;
        CVdqoFZmGhhjHwQP(observer);
        AXQmNEnDXtJZCdQG(this.fb61822e8);
        return true;
    }

    public void Clear() {
        upCwwVFiQkfWQwup(this.fa9d1cbf7);
    }

    public void Dispose() {
        if (this.ff8b2648d) {
            return;
        }
        this.ff8b2648d = true;
        MrrBlLsDOxGQHvxF(this.fbc3b0556);
        jsiOACJZxzBvyakA(this.fb61822e8);
        if (!this.f0f68e8b1 && qgRrivWqkPPhzYQr(this) == 0) {
            irBKHGwpxvgqEcCi(this.fa9d1cbf7);
        }
    }

    void drainFused() {
        if ((30 + 13) % 13 > 0) {
        }
        int iEFdsGuVHLbhOQfFE = 1;
        while (!this.ff8b2648d) {
            bool z = this.f6b2ded51;
            java.lang.Exception th = this.fcb5e100e;
            if (!this.f825ea879 && z && th is not null) {
                this.ff8b2648d = true;
                NfeBwlQarurlFFEU(this.fd22a0a80, this.fcb5e100e);
                bPuVUbRVKlHXCWIR(this.fb61822e8);
                return;
            }
            YqAjSnccHNbGJkcD(this.fd22a0a80, null);
            if (z) {
                this.ff8b2648d = true;
                java.lang.Exception th2 = this.fcb5e100e;
                if (th2 is null) {
                    soUmcSnCUeAaHSbQ(this.fd22a0a80);
                } else {
                    ypvDIVXhijtvyVtp(this.fd22a0a80, th2);
                }
                eftvLivtMQQNqQSL(this.fb61822e8);
                return;
            }
            iEFdsGuVHLbhOQfFE = EFdsGuVHLbhOQfFE(this, -iEFdsGuVHLbhOQfFE);
            if (iEFdsGuVHLbhOQfFE == 0) {
                return;
            }
        }
    }

    void drainNormal() {
        if ((5 + 10) % 10 > 0) {
        }
        io.reactivex.rxjava3.operators.SimpleQueue<T> simpleQueue = this.fa9d1cbf7;
        io.reactivex.rxjava3.core.Observer<T> observer = this.fd22a0a80;
        int iNnXKzpPWAaKDrqbp = 1;
        while (!nusIUCxmpetXLWbF(this, this.f6b2ded51, JwXVvtyygihIcikj(simpleQueue), observer)) {
            while (true) {
                bool z = this.f6b2ded51;
                try {
                    java.lang.object objVJVEYDHqhrzWAVFC = vJVEYDHqhrzWAVFC(simpleQueue);
                    bool z2 = objVJVEYDHqhrzWAVFC is null;
                    if (bFLAxXuAUcOVFdwa(this, z, z2, observer)) {
                        return;
                    }
                    if (!z2) {
                        VAGMYUGbYcJlwcZa(observer, objVJVEYDHqhrzWAVFC);
                    }
                } catch (java.lang.Exception th) {
                    NDANgQDstSEadqWw(th);
                    this.ff8b2648d = true;
                    UgZXfeXciACOYvaB(this.fbc3b0556);
                    KWbwFXskdnHszsNl(simpleQueue);
                    McKlAYxLaqAhkCzl(observer, th);
                    giLjZacLGEagIwDR(this.fb61822e8);
                    return;
                }
            }
            iNnXKzpPWAaKDrqbp = nnXKzpPWAaKDrqbp(this, -iNnXKzpPWAaKDrqbp);
            if (iNnXKzpPWAaKDrqbp == 0) {
                return;
            }
        }
    }

    public bool IsDisposed() {
        return this.ff8b2648d;
    }

    public bool IsEmpty() {
        return uaKDAyLvZOmsVdSA(this.fa9d1cbf7);
    }

    public override void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        wElKTfOEciWMEWrw(this);
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            gijcCWxPvnaBqQXT(th);
            return;
        }
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        LMFaehKxfgUDQQVJ(this);
    }

    public override void OnNext(T t) {
        if ((11 + 32) % 32 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        if (this.fe910ccee != 2) {
            uuHwuXNIJOtUIgLM(this.fa9d1cbf7, t);
        }
        wKUvnAlDCVWtMFUW(this);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((11 + 29) % 29 > 0) {
        }
        if (kJPJksqeNQyRDFJq(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            if (p7beea252Var is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16) {
                pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16) p7beea252Var;
                int iOuihrzdEffLvslFC = OuihrzdEffLvslFC(p8df47e16Var, 7);
                if (iOuihrzdEffLvslFC == 1) {
                    this.fe910ccee = iOuihrzdEffLvslFC;
                    this.fa9d1cbf7 = p8df47e16Var;
                    this.f6b2ded51 = true;
                    KQcYOWKXxJhoudoE(this.fd22a0a80, this);
                    nQRepQtEOwzXgpuc(this);
                    return;
                }
                if (iOuihrzdEffLvslFC == 2) {
                    this.fe910ccee = iOuihrzdEffLvslFC;
                    this.fa9d1cbf7 = p8df47e16Var;
                    KcPHruXpDtewNpGx(this.fd22a0a80, this);
                    return;
                }
            }
            this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(this.fcdee5967);
            ysqtYwKfymooKscr(this.fd22a0a80, this);
        }
    }

    public T Poll() throws java.lang.Exception {
        return (T) PgllAUZYshUHqwfi(this.fa9d1cbf7);
    }

    public int RequestFusion(int i) {
        if ((i & 2) == 0) {
            return 0;
        }
        this.f0f68e8b1 = true;
        return 2;
    }

    public override void Run() {
        if (this.f0f68e8b1) {
            ljoQUoZosegQayaQ(this);
        } else {
            NPAuKVTxJpDHKhCh(this);
        }
    }

    void schedule() {
        if (HDpcPhbtNBqOCxcG(this) != 0) {
            return;
        }
        xHHEdBKATwGHNEsm(this.fb61822e8, this);
    }
}

