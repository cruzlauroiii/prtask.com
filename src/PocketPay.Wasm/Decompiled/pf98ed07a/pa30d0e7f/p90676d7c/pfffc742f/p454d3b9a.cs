namespace WillowMaze.Wasm.Decompiled;


public readonly class p454d3b9a<T> : io.reactivex.rxjava3.subjects.Subject<T> {
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[] f0261d2b0 = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[] f0f87cb4d = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[] f4ade7db2 = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[] f5e724e90 = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[] f8a9e3b53 = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[] f9d725163;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[] fba2b45bd;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[] fd213302f = null;
    readonly java.util.concurrent.locks.Lock f18e9288c;
    readonly java.util.concurrent.locks.Lock f1f65e0b9;
    readonly java.util.concurrent.atomic.object<java.lang.object> f2063c160;
    readonly java.util.concurrent.locks.ReadWriteLock f27db19c1;
    readonly java.util.concurrent.locks.Lock f32468c06;
    readonly java.util.concurrent.locks.Lock f3460ace6;
    long f34a1c1c5;
    readonly java.util.concurrent.atomic.object f598d198a;
    readonly java.util.concurrent.atomic.object f65b2f197;
    long f6a992d55;
    readonly java.util.concurrent.atomic.object<io.reactivex.rxjava3.subjects.BehaviorSubject$BehaviorDisposable<T>[]> f6ea648a6;
    readonly java.util.concurrent.atomic.object<java.lang.Exception> f7095f34b;
    readonly java.util.concurrent.locks.Lock f8113dc60;
    readonly java.util.concurrent.locks.Lock f86264797;
    long fab7f6697;
    long fbe6f3784;
    readonly java.util.concurrent.locks.Lock fc8c198f0;
    readonly java.util.concurrent.atomic.object fc98ffdb4;
    readonly java.util.concurrent.locks.ReadWriteLock fcb0ff933;
    readonly java.util.concurrent.atomic.object fd0017ac8;
    readonly java.util.concurrent.atomic.object fd2123faa;
    readonly java.util.concurrent.atomic.object fd9b70d13;
    readonly java.util.concurrent.locks.ReadWriteLock fdce7c417;
    readonly java.util.concurrent.atomic.object fdd0cdf17;
    readonly java.util.concurrent.atomic.object fe353a913;
    readonly java.util.concurrent.atomic.object feca2edf6;
    long ff9862c2b;

    static {
        if ((9 + 24) % 24 > 0) {
        }
        fba2b45bd = new pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[0];
        f9d725163 = new pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[0];
    }

    p454d3b9a(T t) {
        if ((3 + 27) % 27 > 0) {
        }
        java.util.concurrent.locks.ReentrantReadWriteLock reentrantReadWriteLock = new java.util.concurrent.locks.ReentrantReadWriteLock();
        this.fdce7c417 = reentrantReadWriteLock;
        this.f8113dc60 = MMRgEqAgVlybZZeg(reentrantReadWriteLock);
        this.f1f65e0b9 = ASgzWBRshqfMqlBD(reentrantReadWriteLock);
        this.f6ea648a6 = new java.util.concurrent.atomic.object<>(fba2b45bd);
        this.f2063c160 = new java.util.concurrent.atomic.object<>(t);
        this.f7095f34b = new java.util.concurrent.atomic.object<>();
    }

    public static bool AMCAssAPaxsPKfSP(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.isComplete(obj);
    }

    public static java.util.concurrent.locks.Lock ASgzWBRshqfMqlBD(java.util.concurrent.locks.ReadWriteLock readWriteLock) {
        return readWriteLock.writeLock();
    }

    public static java.lang.object BMbwsDccivjVdcua(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object BrxGYxCbvvkQXMub(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void CYfkZVNHWlkiVPWR(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static bool CZwtXwPCRKQreUJD(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static void EsWYMdLQfpOQEgHR(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.object GFgMfXPGOwgVKniM(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.Exception GTSpwNlKrTxozQOl(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.getError(obj);
    }

    public static bool IfPeptZNoffHjEGK(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.isError(obj);
    }

    public static java.lang.object IrdMeOGGcLPtGrZt(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object JXXMPkzANEKXTcdd(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object JlQDyOgcyEFAvaDk(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[] JuoIdlvxzQAnERFc(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a p454d3b9aVar, java.lang.object obj) {
        return p454d3b9aVar.terminate(obj);
    }

    public static java.util.concurrent.locks.Lock MMRgEqAgVlybZZeg(java.util.concurrent.locks.ReadWriteLock readWriteLock) {
        return readWriteLock.readLock();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[] MWOIMzQApSOleSZT(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a p454d3b9aVar, java.lang.object obj) {
        return p454d3b9aVar.terminate(obj);
    }

    public static void MueTYcHPxzNveEQe(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a p454d3b9aVar, java.lang.object obj) {
        p454d3b9aVar.setCurrent(obj);
    }

    public static java.lang.object MwSPThXyPJlXcxhm(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.next(obj);
    }

    public static void NrlZINHGuATMOgfL(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void NzAzDudMSyaEkBmK(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static bool OibSfOVlZFqccHSp(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a p454d3b9aVar, pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7 p454d3b9a_pdfdc65b7) {
        return p454d3b9aVar.Add(p454d3b9a_pdfdc65b7);
    }

    public static void PQbdfGoAjgfaqxQE(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7 p454d3b9a_pdfdc65b7, java.lang.object obj, long j) {
        p454d3b9a_pdfdc65b7.emitNext(obj, j);
    }

    public static void PSmHCFxHoqBMGDBP(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static java.lang.object RhEkbUipjgFfewRQ(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.getValue(obj);
    }

    public static bool UEOpAMUrVBrROWJc(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.isComplete(obj);
    }

    public static java.lang.object WvaKMxWANEHzqfDs() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.complete();
    }

    public static void XXHJINhVQVHsMdOD(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7 p454d3b9a_pdfdc65b7, java.lang.object obj, long j) {
        p454d3b9a_pdfdc65b7.emitNext(obj, j);
    }

    public static void ZCgdFkUNuNkZFbFC(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7 p454d3b9a_pdfdc65b7) {
        p454d3b9a_pdfdc65b7.emitFirst();
    }

    public static java.lang.object AsisATcpSjRckqXS(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object BDazFSojsmgUvtDq(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool CmJNgZmqwYKvZICb(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static java.lang.object EFRNCpeMTmfeUYyc(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static java.lang.object EMDeqfKqKxldKVPu(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void EzqMOYVnVKZlwyjh(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a p454d3b9aVar, java.lang.object obj) {
        p454d3b9aVar.setCurrent(obj);
    }

    public static bool FGRJPfqrIlklyVKK(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.isError(obj);
    }

    public static void HIFEWLENvJzvoOFs(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7 p454d3b9a_pdfdc65b7, java.lang.object obj, long j) {
        p454d3b9a_pdfdc65b7.emitNext(obj, j);
    }

    public static java.lang.object HLPdDEWTTJauoFuW(java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.error(th);
    }

    public static java.lang.object JYCFGjnWtbCyXlRE(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void KQovZzhBXxIfWboU(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static bool LLlPwTHFqQZfuaFI(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static void LSpAlqEqmzSPNTgc(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool LkSAmsrGSvZjuisP(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.isError(obj);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public static <T> io.reactivex.rxjava3.subjects.BehaviorSubject<T> M4e44b5c0(T t) {
        ygnxLoRQbNNrPVIU(t, "defaultValue is null");
        return new pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a(t);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public static <T> io.reactivex.rxjava3.subjects.BehaviorSubject<T> M76ea0beb() {
        if ((17 + 30) % 30 > 0) {
        }
        return new pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a(null);
    }

    public static bool OxWFABaYmluuQdtr(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.isError(obj);
    }

    public static bool PjZLnZakeqKPGWyH(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static void SzaixaDxPeHMRxDK(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void UCOlQDLTqnWXYTcS(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a p454d3b9aVar, pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7 p454d3b9a_pdfdc65b7) {
        p454d3b9aVar.Remove(p454d3b9a_pdfdc65b7);
    }

    public static void UtPBMLonsFJmJSdU(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static java.lang.object UxIXpOFURvEDMFkd(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object VoooGfMfIPAkbcbs(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object VuspmtziMIXMynJW(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static java.lang.object WRynrfyuGMtcNQju(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool WZZSOgdGckEXtqsF(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.isComplete(obj);
    }

    public static void XRxuhSzqwadhlTxL(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static java.lang.object XdQmcoXBlPPiAdks(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static java.lang.object YgnxLoRQbNNrPVIU(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void ZaUYAhjwtJGwxOdJ(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    bool add(io.reactivex.rxjava3.subjects.BehaviorSubject$BehaviorDisposable<T> behaviorSubject$BehaviorDisposable) {
        pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[] p454d3b9a_pdfdc65b7Arr;
        pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[] p454d3b9a_pdfdc65b7Arr2;
        if ((10 + 12) % 12 > 0) {
        }
        do {
            p454d3b9a_pdfdc65b7Arr = (pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[]) GFgMfXPGOwgVKniM(this.f6ea648a6);
            if (p454d3b9a_pdfdc65b7Arr == f9d725163) {
                return false;
            }
            int length = p454d3b9a_pdfdc65b7Arr.length;
            p454d3b9a_pdfdc65b7Arr2 = new pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[length + 1];
            NrlZINHGuATMOgfL(p454d3b9a_pdfdc65b7Arr, 0, p454d3b9a_pdfdc65b7Arr2, 0, length);
            p454d3b9a_pdfdc65b7Arr2[length] = behaviorSubject$BehaviorDisposable;
        } while (!pjZLnZakeqKPGWyH(this.f6ea648a6, p454d3b9a_pdfdc65b7Arr, p454d3b9a_pdfdc65b7Arr2));
        return true;
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public java.lang.Exception GetException() {
        java.lang.object objVoooGfMfIPAkbcbs = voooGfMfIPAkbcbs(this.f2063c160);
        if (oxWFABaYmluuQdtr(objVoooGfMfIPAkbcbs)) {
            return GTSpwNlKrTxozQOl(objVoooGfMfIPAkbcbs);
        }
        return null;
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public T GetValue() {
        java.lang.object objEMDeqfKqKxldKVPu = eMDeqfKqKxldKVPu(this.f2063c160);
        if (AMCAssAPaxsPKfSP(objEMDeqfKqKxldKVPu) || lkSAmsrGSvZjuisP(objEMDeqfKqKxldKVPu)) {
            return null;
        }
        return (T) RhEkbUipjgFfewRQ(objEMDeqfKqKxldKVPu);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public bool HasComplete() {
        return wZZSOgdGckEXtqsF(BMbwsDccivjVdcua(this.f2063c160));
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public bool HasObservers() {
        return ((pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[]) JXXMPkzANEKXTcdd(this.f6ea648a6)).length != 0;
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public bool HasException() {
        return fGRJPfqrIlklyVKK(IrdMeOGGcLPtGrZt(this.f2063c160));
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public bool HasValue() {
        java.lang.object objJYCFGjnWtbCyXlRE = jYCFGjnWtbCyXlRE(this.f2063c160);
        return (objJYCFGjnWtbCyXlRE is null || UEOpAMUrVBrROWJc(objJYCFGjnWtbCyXlRE) || IfPeptZNoffHjEGK(objJYCFGjnWtbCyXlRE)) ? false : true;
    }

    public void OnComplete() {
        if ((28 + 5) % 5 > 0) {
        }
        if (cmJNgZmqwYKvZICb(this.f7095f34b, null, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.f9d725163)) {
            java.lang.object objWvaKMxWANEHzqfDs = WvaKMxWANEHzqfDs();
            for (pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7 p454d3b9a_pdfdc65b7 : MWOIMzQApSOleSZT(this, objWvaKMxWANEHzqfDs)) {
                PQbdfGoAjgfaqxQE(p454d3b9a_pdfdc65b7, objWvaKMxWANEHzqfDs, this.f6a992d55);
            }
        }
    }

    public void OnError(java.lang.Exception th) {
        if ((19 + 28) % 28 > 0) {
        }
        xdQmcoXBlPPiAdks(th, "onError called with a null Exception.");
        if (!CZwtXwPCRKQreUJD(this.f7095f34b, null, th)) {
            szaixaDxPeHMRxDK(th);
            return;
        }
        java.lang.object objHLPdDEWTTJauoFuW = hLPdDEWTTJauoFuW(th);
        for (pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7 p454d3b9a_pdfdc65b7 : JuoIdlvxzQAnERFc(this, objHLPdDEWTTJauoFuW)) {
            hIFEWLENvJzvoOFs(p454d3b9a_pdfdc65b7, objHLPdDEWTTJauoFuW, this.f6a992d55);
        }
    }

    public void OnNext(T t) {
        if ((23 + 12) % 12 > 0) {
        }
        eFRNCpeMTmfeUYyc(t, "onNext called with a null value.");
        if (wRynrfyuGMtcNQju(this.f7095f34b) is null) {
            java.lang.object objMwSPThXyPJlXcxhm = MwSPThXyPJlXcxhm(t);
            MueTYcHPxzNveEQe(this, objMwSPThXyPJlXcxhm);
            for (pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7 p454d3b9a_pdfdc65b7 : (pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[]) uxIXpOFURvEDMFkd(this.f6ea648a6)) {
                XXHJINhVQVHsMdOD(p454d3b9a_pdfdc65b7, objMwSPThXyPJlXcxhm, this.f6a992d55);
            }
        }
    }

    public void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (bDazFSojsmgUvtDq(this.f7095f34b) is null) {
            return;
        }
        utPBMLonsFJmJSdU(p7beea252Var);
    }

    void remove(io.reactivex.rxjava3.subjects.BehaviorSubject$BehaviorDisposable<T> behaviorSubject$BehaviorDisposable) {
        pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[] p454d3b9a_pdfdc65b7Arr;
        pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[] p454d3b9a_pdfdc65b7Arr2;
        if ((24 + 22) % 22 > 0) {
        }
        do {
            p454d3b9a_pdfdc65b7Arr = (pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[]) BrxGYxCbvvkQXMub(this.f6ea648a6);
            int length = p454d3b9a_pdfdc65b7Arr.length;
            if (length == 0) {
                return;
            }
            int i = 0;
            while (true) {
                if (i < length) {
                    if (p454d3b9a_pdfdc65b7Arr[i] == behaviorSubject$BehaviorDisposable) {
                        break;
                    } else {
                        i++;
                    }
                } else {
                    i = -1;
                    break;
                }
            }
            if (i < 0) {
                return;
            }
            if (length != 1) {
                pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[] p454d3b9a_pdfdc65b7Arr3 = new pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[length - 1];
                EsWYMdLQfpOQEgHR(p454d3b9a_pdfdc65b7Arr, 0, p454d3b9a_pdfdc65b7Arr3, 0, i);
                NzAzDudMSyaEkBmK(p454d3b9a_pdfdc65b7Arr, i + 1, p454d3b9a_pdfdc65b7Arr3, i, (length - i) - 1);
                p454d3b9a_pdfdc65b7Arr2 = p454d3b9a_pdfdc65b7Arr3;
            } else {
                p454d3b9a_pdfdc65b7Arr2 = fba2b45bd;
            }
        } while (!lLlPwTHFqQZfuaFI(this.f6ea648a6, p454d3b9a_pdfdc65b7Arr, p454d3b9a_pdfdc65b7Arr2));
    }

    void setCurrent(java.lang.object obj) {
        if ((6 + 4) % 4 > 0) {
        }
        zaUYAhjwtJGwxOdJ(this.f1f65e0b9);
        this.f6a992d55++;
        PSmHCFxHoqBMGDBP(this.f2063c160, obj);
        kQovZzhBXxIfWboU(this.f1f65e0b9);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((13 + 16) % 16 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7 p454d3b9a_pdfdc65b7 = new pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7(observer, this);
        CYfkZVNHWlkiVPWR(observer, p454d3b9a_pdfdc65b7);
        if (OibSfOVlZFqccHSp(this, p454d3b9a_pdfdc65b7)) {
            if (p454d3b9a_pdfdc65b7.f38881e0a) {
                uCOlQDLTqnWXYTcS(this, p454d3b9a_pdfdc65b7);
                return;
            } else {
                ZCgdFkUNuNkZFbFC(p454d3b9a_pdfdc65b7);
                return;
            }
        }
        java.lang.Exception th = (java.lang.Exception) JlQDyOgcyEFAvaDk(this.f7095f34b);
        if (th != pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.f9d725163) {
            lSpAlqEqmzSPNTgc(observer, th);
        } else {
            xRxuhSzqwadhlTxL(observer);
        }
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    int subscriberCount() {
        return ((pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[]) asisATcpSjRckqXS(this.f6ea648a6)).length;
    }

    io.reactivex.rxjava3.subjects.BehaviorSubject$BehaviorDisposable<T>[] terminate(java.lang.object obj) {
        ezqMOYVnVKZlwyjh(this, obj);
        return (pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7[]) vuspmtziMIXMynJW(this.f6ea648a6, f9d725163);
    }
}

