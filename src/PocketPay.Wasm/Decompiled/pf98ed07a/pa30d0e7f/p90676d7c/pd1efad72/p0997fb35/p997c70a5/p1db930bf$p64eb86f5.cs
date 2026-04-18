namespace WillowMaze.Wasm.Decompiled;


readonly class p1db930bf$p64eb86f5<T, B> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, java.lang.Action {
    static readonly java.lang.object f016333bd = null;
    static readonly java.lang.object f5a0418ba = null;
    static readonly java.lang.object fbc6d68ea = null;
    private static readonly long fc6e1e520 = 2233020065421370272L;
    private static readonly long fd675f75e = 2233020065421370272L;
    static readonly java.lang.object fed5c9d0d = new java.lang.object();
    io.reactivex.rxjava3.subjects.UnicastSubject<T> f05b8c74c;
    readonly java.util.concurrent.atomic.object f07d68cac;
    readonly int f0b1310ff;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f0b222216;
    volatile bool f1a8959bf;
    readonly java.util.concurrent.atomic.object f2e6c8113;
    volatile bool f31ef59a9;
    pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d f46d640fe;
    readonly java.util.concurrent.atomic.Atomicbool f4a02d3f3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d f5069ef74;
    readonly java.util.concurrent.atomic.Atomicbool f50d9cc82;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f63ffd50e;
    readonly java.util.concurrent.atomic.Atomicbool f6aa1ba4f;
    volatile bool f6b2ded51;
    pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d f7482cb8c;
    readonly io.reactivex.rxjava3.core.Observer f8392878b;
    readonly int f8be22347;
    pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d fa26c5d1b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1db930bf$pc6b84b0a faa01b264;
    readonly int fae42a9e8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1db930bf$pc6b84b0a faf01b31b;
    readonly java.util.concurrent.atomic.Atomicbool fc5484539;
    readonly java.util.concurrent.atomic.object fcc4549c5;
    readonly io.reactivex.rxjava3.core.Observer<? super io.reactivex.rxjava3.core.Observable<T>> fd22a0a80;
    readonly java.util.concurrent.atomic.object fd29e7d6f;
    readonly int fd2dcf371;
    volatile bool fdd87e9d0;
    readonly io.reactivex.rxjava3.core.Observer ffa1b3049;
    pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d ffba0e4ff;
    readonly java.util.concurrent.atomic.Atomicint ffe90d194;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableWindowBoundary$WindowBoundaryInnerObserver<T, B> f5bb26334 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1db930bf$pc6b84b0a(this);
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fbc3b0556 = new java.util.concurrent.atomic.object<>();
    readonly java.util.concurrent.atomic.Atomicint f0f4137ed = new java.util.concurrent.atomic.Atomicint(1);
    readonly io.reactivex.rxjava3.internal.queue.MpscLinkedQueue<java.lang.object> fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d();
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    readonly java.util.concurrent.atomic.Atomicbool ff4d0fc5c = new java.util.concurrent.atomic.Atomicbool();

    p1db930bf$p64eb86f5(io.reactivex.rxjava3.core.Observer<? super io.reactivex.rxjava3.core.Observable<T>> observer, int i) {
        this.fd22a0a80 = observer;
        this.f0b1310ff = i;
    }

    public static int AbKLtzJsnvmpbpWd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1db930bf$p64eb86f5 p1db930bf_p64eb86f5, int i) {
        return p1db930bf_p64eb86f5.addAndGet(i);
    }

    public static void DgBZQxaCPyIBOYdk(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool HHxTEXvkckaQkRIk(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static bool HiIixqclhTGsDOiS(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static java.lang.Exception HpgPSpJpCqmIapco(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar.terminate();
    }

    public static void IDTqShtkMLqadfoG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1db930bf$p64eb86f5 p1db930bf_p64eb86f5) {
        p1db930bf_p64eb86f5.innerNext();
    }

    public static void IsQexbhbqwVZPXjr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1db930bf$p64eb86f5 p1db930bf_p64eb86f5) {
        p1db930bf_p64eb86f5.drain();
    }

    public static bool LHMcNRzHqFRZoqZw(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void LLPHzfFtlHIinARV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1db930bf$p64eb86f5 p1db930bf_p64eb86f5) {
        p1db930bf_p64eb86f5.drain();
    }

    public static void MCkOzvCpSaXlwbxH(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar, java.lang.Exception th) {
        peef7828dVar.onError(th);
    }

    public static void MhHnjDZVAPWHuujZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1db930bf$pc6b84b0a p1db930bf_pc6b84b0a) {
        p1db930bf_pc6b84b0a.dispose();
    }

    public static void MjVolbmnadwnxwHa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1db930bf$p64eb86f5 p1db930bf_p64eb86f5) {
        p1db930bf_p64eb86f5.drain();
    }

    public static int NIFglbbDkwCJgsIw(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static bool OXqzDlwlHzpxYscu(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool POEzwCyHUIHeiCGh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void RnwdwnyKLIIwFnYl(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool RrTbAQWsmxgFELFR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void SuUEdWfmDsqbrLnu(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool UtQJzloxfrIAkyny(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static void VRMvypUHbSZLOByp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1db930bf$pc6b84b0a p1db930bf_pc6b84b0a) {
        p1db930bf_pc6b84b0a.dispose();
    }

    public static void ZnbbbMlcOkZtfJwh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1db930bf$p64eb86f5 p1db930bf_p64eb86f5) {
        p1db930bf_p64eb86f5.drain();
    }

    public static void AfmtMmalSNwwEjdO(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar, java.lang.object obj) {
        peef7828dVar.onNext(obj);
    }

    public static java.lang.Exception BGYNCorkrcgkNxBR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar.terminate();
    }

    public static void BghbaFfujxLJwaxC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1db930bf$p64eb86f5 p1db930bf_p64eb86f5) {
        p1db930bf_p64eb86f5.drain();
    }

    public static void CCpnbsfooRZtaldP(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void CUEModkyHgvSEjYe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d p4d2eef2dVar) {
        p4d2eef2dVar.clear();
    }

    public static void DLXPrLfeRtOmBaGJ(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar, java.lang.Exception th) {
        peef7828dVar.onError(th);
    }

    public static int DbRnysGBYuWKKJOg(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static void DhicaTriMMkZLOUt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d p4d2eef2dVar) {
        p4d2eef2dVar.clear();
    }

    public static bool DwAdEQYmyrxeUblV(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void FLABGTQotGYBscrN(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        peef7828dVar.onComplete();
    }

    public static int GIuTRIFcjHZRaufN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1db930bf$p64eb86f5 p1db930bf_p64eb86f5) {
        return p1db930bf_p64eb86f5.getAndIncrement();
    }

    public static void JSbnlcmyAWjKJVWW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1db930bf$p64eb86f5 p1db930bf_p64eb86f5) {
        p1db930bf_p64eb86f5.drain();
    }

    public static void MfSRnEmQnOFSuQRj(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        peef7828dVar.onComplete();
    }

    public static void OCchGoBuphdpnLAB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1db930bf$pc6b84b0a p1db930bf_pc6b84b0a) {
        p1db930bf_pc6b84b0a.dispose();
    }

    public static void OFleWcXdiLCZaCYG(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVar) {
        peef7828dVar.onComplete();
    }

    public static int OYIDeiuWFSdKgvEN(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static bool QXhJvUXxCqaNmjmG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p62d68523 p62d68523Var) {
        return p62d68523Var.tryAbandon();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d QfKHCoMIPYvWTYqh(int i, java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d.m76ea0beb(i, runnable);
    }

    public static bool RCUOWeALLGOuRWnB(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static java.lang.object SnlTsIZazKZsNGcl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static java.lang.object UZMDMgATACxIjVSz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d p4d2eef2dVar) {
        return p4d2eef2dVar.poll();
    }

    public static bool VPHJJwbzhistXkXT(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static int WJrjAqqzCCgaugnq(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static bool WZVbqhNbrGdAwlpy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d p4d2eef2dVar, java.lang.object obj) {
        return p4d2eef2dVar.offer(obj);
    }

    public static bool ZhhtNBBsrsZXryRa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.pa9d1cbf7.p4d2eef2d p4d2eef2dVar, java.lang.object obj) {
        return p4d2eef2dVar.offer(obj);
    }

    public override void Dispose() {
        if ((22 + 25) % 25 > 0) {
        }
        if (HHxTEXvkckaQkRIk(this.ff4d0fc5c, false, true)) {
            oCchGoBuphdpnLAB(this.f5bb26334);
            if (NIFglbbDkwCJgsIw(this.f0f4137ed) != 0) {
                return;
            }
            vPHJJwbzhistXkXT(this.fbc3b0556);
        }
    }

    void drain() {
        if ((27 + 13) % 13 > 0) {
        }
        if (gIuTRIFcjHZRaufN(this) == 0) {
            io.reactivex.rxjava3.core.Observer<? super io.reactivex.rxjava3.core.Observable<T>> observer = this.fd22a0a80;
            io.reactivex.rxjava3.internal.queue.MpscLinkedQueue<java.lang.object> mpscLinkedQueue = this.fa9d1cbf7;
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar = this.f07213a01;
            int iAbKLtzJsnvmpbpWd = 1;
            while (oYIDeiuWFSdKgvEN(this.f0f4137ed) != 0) {
                io.reactivex.rxjava3.subjects.UnicastSubject<T> unicastSubject = this.f05b8c74c;
                bool z = this.f6b2ded51;
                if (z && snlTsIZazKZsNGcl(p36a52e5dVar) is not null) {
                    cUEModkyHgvSEjYe(mpscLinkedQueue);
                    java.lang.Exception thHpgPSpJpCqmIapco = HpgPSpJpCqmIapco(p36a52e5dVar);
                    if (unicastSubject is not null) {
                        this.f05b8c74c = null;
                        MCkOzvCpSaXlwbxH(unicastSubject, thHpgPSpJpCqmIapco);
                    }
                    DgBZQxaCPyIBOYdk(observer, thHpgPSpJpCqmIapco);
                    return;
                }
                java.lang.object objUZMDMgATACxIjVSz = uZMDMgATACxIjVSz(mpscLinkedQueue);
                bool z2 = objUZMDMgATACxIjVSz is null;
                if (z && z2) {
                    java.lang.Exception thBGYNCorkrcgkNxBR = bGYNCorkrcgkNxBR(p36a52e5dVar);
                    if (thBGYNCorkrcgkNxBR is not null) {
                        if (unicastSubject is not null) {
                            this.f05b8c74c = null;
                            dLXPrLfeRtOmBaGJ(unicastSubject, thBGYNCorkrcgkNxBR);
                        }
                        RnwdwnyKLIIwFnYl(observer, thBGYNCorkrcgkNxBR);
                        return;
                    }
                    if (unicastSubject is not null) {
                        this.f05b8c74c = null;
                        mfSRnEmQnOFSuQRj(unicastSubject);
                    }
                    SuUEdWfmDsqbrLnu(observer);
                    return;
                }
                if (z2) {
                    iAbKLtzJsnvmpbpWd = AbKLtzJsnvmpbpWd(this, -iAbKLtzJsnvmpbpWd);
                    if (iAbKLtzJsnvmpbpWd == 0) {
                        return;
                    }
                } else if (objUZMDMgATACxIjVSz == fed5c9d0d) {
                    if (unicastSubject is not null) {
                        this.f05b8c74c = null;
                        oFleWcXdiLCZaCYG(unicastSubject);
                    }
                    if (!rCUOWeALLGOuRWnB(this.ff4d0fc5c)) {
                        pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.peef7828d peef7828dVarQfKHCoMIPYvWTYqh = qfKHCoMIPYvWTYqh(this.f0b1310ff, this);
                        this.f05b8c74c = peef7828dVarQfKHCoMIPYvWTYqh;
                        dbRnysGBYuWKKJOg(this.f0f4137ed);
                        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p62d68523 p62d68523Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p62d68523(peef7828dVarQfKHCoMIPYvWTYqh);
                        cCpnbsfooRZtaldP(observer, p62d68523Var);
                        if (qXhJvUXxCqaNmjmG(p62d68523Var)) {
                            fLABGTQotGYBscrN(peef7828dVarQfKHCoMIPYvWTYqh);
                        }
                    }
                } else {
                    afmtMmalSNwwEjdO(unicastSubject, objUZMDMgATACxIjVSz);
                }
            }
            dhicaTriMMkZLOUt(mpscLinkedQueue);
            this.f05b8c74c = null;
        }
    }

    void innerComplete() {
        HiIixqclhTGsDOiS(this.fbc3b0556);
        this.f6b2ded51 = true;
        IsQexbhbqwVZPXjr(this);
    }

    void innerError(java.lang.Exception th) {
        OXqzDlwlHzpxYscu(this.fbc3b0556);
        if (POEzwCyHUIHeiCGh(this.f07213a01, th)) {
            this.f6b2ded51 = true;
            ZnbbbMlcOkZtfJwh(this);
        }
    }

    void innerNext() {
        if ((3 + 5) % 5 > 0) {
        }
        wZVbqhNbrGdAwlpy(this.fa9d1cbf7, fed5c9d0d);
        LLPHzfFtlHIinARV(this);
    }

    public override bool IsDisposed() {
        return UtQJzloxfrIAkyny(this.ff4d0fc5c);
    }

    public override void OnComplete() {
        MhHnjDZVAPWHuujZ(this.f5bb26334);
        this.f6b2ded51 = true;
        MjVolbmnadwnxwHa(this);
    }

    public override void OnError(java.lang.Exception th) {
        VRMvypUHbSZLOByp(this.f5bb26334);
        if (RrTbAQWsmxgFELFR(this.f07213a01, th)) {
            this.f6b2ded51 = true;
            jSbnlcmyAWjKJVWW(this);
        }
    }

    public override void OnNext(T t) {
        zhhtNBBsrsZXryRa(this.fa9d1cbf7, t);
        bghbaFfujxLJwaxC(this);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (LHMcNRzHqFRZoqZw(this.fbc3b0556, p7beea252Var)) {
            IDTqShtkMLqadfoG(this);
        }
    }

    public override void Run() {
        if (wJrjAqqzCCgaugnq(this.f0f4137ed) != 0) {
            return;
        }
        dwAdEQYmyrxeUblV(this.fbc3b0556);
    }
}

