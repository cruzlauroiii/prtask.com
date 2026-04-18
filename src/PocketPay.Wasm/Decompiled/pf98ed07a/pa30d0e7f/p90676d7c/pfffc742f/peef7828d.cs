namespace WillowMaze.Wasm.Decompiled;


public readonly class peef7828d<T> : io.reactivex.rxjava3.subjects.Subject<T> {
    bool f129b1cea;
    readonly java.util.concurrent.atomic.Atomicbool f151856c0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f16ec788f;
    bool f17edcca5;
    readonly java.util.concurrent.atomic.object f2ddbfd20;
    readonly java.util.concurrent.atomic.object f37ae7f4a;
    volatile bool f3841ed21;
    readonly java.util.concurrent.atomic.object<java.lang.Action> f3c3c9527;
    volatile bool f409afe32;
    readonly java.util.concurrent.atomic.object f44f4aed3;
    readonly bool f45ce9223;
    bool f4d424dc1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f4e18c030;
    volatile bool f50e6d4d3;
    volatile bool f5bd23e63;
    java.lang.Exception f5f2cd0aa;
    volatile bool f6b2ded51;
    readonly java.util.concurrent.atomic.object f72f6009e;
    volatile bool f7e03a21a;
    readonly bool f825ea879;
    java.lang.Exception f8c0eaccf;
    java.lang.Exception f937a22da;
    readonly io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> fa9d1cbf7;
    bool fb4425d57;
    java.lang.Exception fbb23b6c5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pd0401512 fc8baf21e;
    java.lang.Exception fcb5e100e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c fd41418ca;
    readonly bool fdeb2bb5a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pd0401512 feabac900;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c feeb4379e;
    readonly java.util.concurrent.atomic.Atomicbool fefd30ae9;
    readonly bool ff23868da;
    volatile bool ff8b2648d;
    readonly java.util.concurrent.atomic.object<io.reactivex.rxjava3.core.Observer<T>> fd22a0a80 = new java.util.concurrent.atomic.object<>();
    readonly java.util.concurrent.atomic.Atomicbool fe2eff6c2 = new java.util.concurrent.atomic.Atomicbool();
    readonly io.reactivex.rxjava3.internal.observers.BasicIntQueueDisposable<T> ffa687cdf = new pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d$p809289b9(this);

    peef7828d(int i, java.lang.Action runnable, bool z) {
        this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(i);
        this.f3c3c9527 = new java.util.concurrent.atomic.object<>(runnable);
        this.f825ea879 = z;
    }

    public static void AGJzRUfUAtERkxAz(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar, io.reactivex.rxjava3.core.Observer observer) {
        peef7828dVar.errorOrComplete(observer);
    }

    public static void AsDSEkJvnAUZGNru(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        peef7828dVar.drain();
    }

    public static void EanNIdenDrccVSKH(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar, io.reactivex.rxjava3.core.Observer observer) {
        peef7828dVar.drainNormal(observer);
    }

    public static void HNWoxXjjjbolwOKJ(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static void ICQVWyodWVpPYXlX(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static bool KdrAMmylvVnvkZkQ(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static void KeIlajSqtVHQmUJd(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void MrgkBxkKynLptfzZ(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        peef7828dVar.drain();
    }

    public static java.lang.object NCVgbhwOXfcXuuZh(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static java.lang.object OCiTOjcxjJhMeekT(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void OtlmzxysBaNmTHbp(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        peef7828dVar.doTerminate();
    }

    public static int PCikLIdDWyouBpVT() {
        return bufferSize();
    }

    public static void QlIfOzVeZHFoCgHA(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void SaXcONmDjSONvjYo(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        peef7828dVar.drain();
    }

    public static void UDHJesgIPwBjqYuO(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static bool UhKxSYpBJoabpKHq(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, io.reactivex.rxjava3.core.Observer observer) {
        return peef7828dVar.failedFast(pe1601823Var, observer);
    }

    public static bool VPojCCBUIbFyuuvO(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj) {
        return p50dc035cVar.offer(obj);
    }

    public static void VQBavCoBaBTtQsHd(java.lang.Action runnable) {
        runnable.run();
    }

    public static void VXmvqHWlQKijGIxR(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static bool WPtjrcWSUXrlxerg(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, io.reactivex.rxjava3.core.Observer observer) {
        return peef7828dVar.failedFast(pe1601823Var, observer);
    }

    public static java.lang.object WnpravYdEhKiLaBk(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static void XKLPoTmmLclPPXVG(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar, io.reactivex.rxjava3.core.Observer observer) {
        peef7828dVar.errorOrComplete(observer);
    }

    public static void XZsHQDjZlUOFGPsZ(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        peef7828dVar.drain();
    }

    public static java.lang.object YlNhOKRKfiWXQJrx(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static void ZQUCBdCwvLlOMkrf(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void ACevArNdhTuqonVs(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static java.lang.object BLxybrnyxrAvQtyU(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static int BXeBQnSdWfREwzbt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pd0401512 pd0401512Var, int i) {
        return pd0401512Var.addAndGet(i);
    }

    public static java.lang.object CtcWqPCGwnzYqQmu(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static int CuwpNrpAvfBZnFmh() {
        return bufferSize();
    }

    public static int DTbTbtBlcMitTjUZ(int i, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0eaa46c1.pc7a9e54c.m2fe9780d(i, str);
    }

    public static void DeTvGLkTZCmZNioL(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void DvKFsYCUUwsUUdxX(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        peef7828dVar.doTerminate();
    }

    public static void FVGWuTzXvLyUzjev(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static java.lang.object FrRnUJHuXuByhNwx(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void HcJngFfYPVAGEjvF(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static int HuFYrbZQdjQwdNpY(int i, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0eaa46c1.pc7a9e54c.m2fe9780d(i, str);
    }

    public static java.lang.object IDFdxRzazmwVelPE(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static int JfpwjtUoyVCSKeAg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pd0401512 pd0401512Var) {
        return pd0401512Var.getAndIncrement();
    }

    public static java.lang.object KKljjMpXbKWrviLC(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static int KlGgZqAqqajTLeLL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pd0401512 pd0401512Var, int i) {
        return pd0401512Var.addAndGet(i);
    }

    public static void LAGDJRGOsWPrXdAZ(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public static <T> io.reactivex.rxjava3.subjects.UnicastSubject<T> M76ea0beb() {
        if ((22 + 23) % 23 > 0) {
        }
        return new pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d(cuwpNrpAvfBZnFmh(), null, true);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public static <T> io.reactivex.rxjava3.subjects.UnicastSubject<T> M76ea0beb(int i) {
        if ((8 + 30) % 30 > 0) {
        }
        dTbTbtBlcMitTjUZ(i, "capacityHint");
        return new pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d(i, null, true);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public static <T> io.reactivex.rxjava3.subjects.UnicastSubject<T> M76ea0beb(int i, java.lang.Action runnable) {
        if ((17 + 30) % 30 > 0) {
        }
        huFYrbZQdjQwdNpY(i, "capacityHint");
        bLxybrnyxrAvQtyU(runnable, "onTerminate");
        return new pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d(i, runnable, true);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public static <T> io.reactivex.rxjava3.subjects.UnicastSubject<T> M76ea0beb(int i, java.lang.Action runnable, bool z) {
        mMniVQVqXlvCorhe(i, "capacityHint");
        kKljjMpXbKWrviLC(runnable, "onTerminate");
        return new pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d(i, runnable, z);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public static <T> io.reactivex.rxjava3.subjects.UnicastSubject<T> M76ea0beb(bool z) {
        if ((24 + 30) % 30 > 0) {
        }
        return new pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d(PCikLIdDWyouBpVT(), null, z);
    }

    public static int MMniVQVqXlvCorhe(int i, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0eaa46c1.pc7a9e54c.m2fe9780d(i, str);
    }

    public static void NwLhBEdHlXELCcJH(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static void OGzfRUvpbSdsUsep(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar, io.reactivex.rxjava3.core.Observer observer) {
        peef7828dVar.drainFused(observer);
    }

    public static bool TVCttWzQLqDNMchx(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static bool TqimKdZfsUPKfPOz(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static int VWLBtFMPIbAIDPog(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.pd0401512 pd0401512Var, int i) {
        return pd0401512Var.addAndGet(i);
    }

    public static void WLjNoVBohLolgANQ(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void XwCVxrQBsHTqJEhE(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static void YaQqaPTINqMMwCXq(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static void ZqSUcavtUeSvcLLc(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    void doTerminate() {
        if ((22 + 27) % 27 > 0) {
        }
        java.lang.Action runnable = (java.lang.Action) iDFdxRzazmwVelPE(this.f3c3c9527);
        if (runnable is not null && KdrAMmylvVnvkZkQ(this.f3c3c9527, runnable, null)) {
            VQBavCoBaBTtQsHd(runnable);
        }
    }

    void drain() {
        if ((25 + 13) % 13 > 0) {
        }
        if (jfpwjtUoyVCSKeAg(this.ffa687cdf) == 0) {
            io.reactivex.rxjava3.core.Observer observer = (io.reactivex.rxjava3.core.Observer) ctcWqPCGwnzYqQmu(this.fd22a0a80);
            int iVWLBtFMPIbAIDPog = 1;
            while (observer is null) {
                iVWLBtFMPIbAIDPog = vWLBtFMPIbAIDPog(this.ffa687cdf, -iVWLBtFMPIbAIDPog);
                if (iVWLBtFMPIbAIDPog == 0) {
                    return;
                } else {
                    observer = (io.reactivex.rxjava3.core.Observer) OCiTOjcxjJhMeekT(this.fd22a0a80);
                }
            }
            if (this.f4d424dc1) {
                oGzfRUvpbSdsUsep(this, observer);
            } else {
                EanNIdenDrccVSKH(this, observer);
            }
        }
    }

    void drainFused(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((28 + 23) % 23 > 0) {
        }
        io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> spscLinkedArrayQueue = this.fa9d1cbf7;
        bool z = this.f825ea879;
        int iKlGgZqAqqajTLeLL = 1;
        do {
            if (this.ff8b2648d) {
                yaQqaPTINqMMwCXq(this.fd22a0a80, null);
                return;
            }
            bool z2 = this.f6b2ded51;
            if (!z && z2 && WPtjrcWSUXrlxerg(this, spscLinkedArrayQueue, observer)) {
                return;
            }
            deTvGLkTZCmZNioL(observer, null);
            if (z2) {
                XKLPoTmmLclPPXVG(this, observer);
                return;
            }
            iKlGgZqAqqajTLeLL = klGgZqAqqajTLeLL(this.ffa687cdf, -iKlGgZqAqqajTLeLL);
        } while (iKlGgZqAqqajTLeLL != 0);
    }

    void drainNormal(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((19 + 15) % 15 > 0) {
        }
        io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> spscLinkedArrayQueue = this.fa9d1cbf7;
        bool z = this.f825ea879;
        bool z2 = true;
        int iBXeBQnSdWfREwzbt = 1;
        while (!this.ff8b2648d) {
            bool z3 = this.f6b2ded51;
            java.lang.object objNCVgbhwOXfcXuuZh = NCVgbhwOXfcXuuZh(this.fa9d1cbf7);
            bool z4 = objNCVgbhwOXfcXuuZh is null;
            if (z3) {
                if (!z && z2) {
                    if (UhKxSYpBJoabpKHq(this, spscLinkedArrayQueue, observer)) {
                        return;
                    } else {
                        z2 = false;
                    }
                }
                if (z4) {
                    AGJzRUfUAtERkxAz(this, observer);
                    return;
                }
            }
            if (z4) {
                iBXeBQnSdWfREwzbt = bXeBQnSdWfREwzbt(this.ffa687cdf, -iBXeBQnSdWfREwzbt);
                if (iBXeBQnSdWfREwzbt == 0) {
                    return;
                }
            } else {
                QlIfOzVeZHFoCgHA(observer, objNCVgbhwOXfcXuuZh);
            }
        }
        nwLhBEdHlXELCcJH(this.fd22a0a80, null);
        aCevArNdhTuqonVs(spscLinkedArrayQueue);
    }

    void errorOrComplete(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((21 + 27) % 27 > 0) {
        }
        HNWoxXjjjbolwOKJ(this.fd22a0a80, null);
        java.lang.Exception th = this.fcb5e100e;
        if (th is null) {
            ZQUCBdCwvLlOMkrf(observer);
        } else {
            hcJngFfYPVAGEjvF(observer, th);
        }
    }

    bool failedFast(io.reactivex.rxjava3.operators.SimpleQueue<T> simpleQueue, io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((24 + 12) % 12 > 0) {
        }
        java.lang.Exception th = this.fcb5e100e;
        if (th is null) {
            return false;
        }
        VXmvqHWlQKijGIxR(this.fd22a0a80, null);
        fVGWuTzXvLyUzjev(simpleQueue);
        wLjNoVBohLolgANQ(observer, th);
        return true;
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public java.lang.Exception GetException() {
        if (this.f6b2ded51) {
            return this.fcb5e100e;
        }
        return null;
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public bool HasComplete() {
        return this.f6b2ded51 && this.fcb5e100e is null;
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public bool HasObservers() {
        return frRnUJHuXuByhNwx(this.fd22a0a80) is not null;
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public bool HasException() {
        return this.f6b2ded51 && this.fcb5e100e is not null;
    }

    public void OnComplete() {
        if (this.f6b2ded51 || this.ff8b2648d) {
            return;
        }
        this.f6b2ded51 = true;
        dvKFsYCUUwsUUdxX(this);
        SaXcONmDjSONvjYo(this);
    }

    public void OnError(java.lang.Exception th) {
        YlNhOKRKfiWXQJrx(th, "onError called with a null Exception.");
        if (this.f6b2ded51 || this.ff8b2648d) {
            KeIlajSqtVHQmUJd(th);
            return;
        }
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        OtlmzxysBaNmTHbp(this);
        XZsHQDjZlUOFGPsZ(this);
    }

    public void OnNext(T t) {
        WnpravYdEhKiLaBk(t, "onNext called with a null value.");
        if (this.f6b2ded51 || this.ff8b2648d) {
            return;
        }
        VPojCCBUIbFyuuvO(this.fa9d1cbf7, t);
        MrgkBxkKynLptfzZ(this);
    }

    public void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (this.f6b2ded51 || this.ff8b2648d) {
            zqSUcavtUeSvcLLc(p7beea252Var);
        }
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((7 + 6) % 6 > 0) {
        }
        if (tVCttWzQLqDNMchx(this.fe2eff6c2) || !tqimKdZfsUPKfPOz(this.fe2eff6c2, false, true)) {
            ICQVWyodWVpPYXlX(new java.lang.IllegalStateException("Only a single observer allowed."), observer);
            return;
        }
        lAGDJRGOsWPrXdAZ(observer, this.ffa687cdf);
        UDHJesgIPwBjqYuO(this.fd22a0a80, observer);
        if (this.ff8b2648d) {
            xwCVxrQBsHTqJEhE(this.fd22a0a80, null);
        } else {
            AsDSEkJvnAUZGNru(this);
        }
    }
}

