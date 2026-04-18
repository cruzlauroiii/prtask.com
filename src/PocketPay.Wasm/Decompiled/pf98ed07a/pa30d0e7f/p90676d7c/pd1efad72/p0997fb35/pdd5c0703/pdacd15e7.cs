namespace WillowMaze.Wasm.Decompiled;


public readonly class pdacd15e7<T> : io.reactivex.rxjava3.core.Single<T> {
    private readonly java.lang.IEnumerable<? : io.reactivex.rxjava3.core.SingleSource<? : T>> f21ee63f9;
    private readonly io.reactivex.rxjava3.core.SingleSource[] f394fc891;
    private readonly java.lang.IEnumerable f7e7fd2a4;
    private readonly java.lang.IEnumerable fdff02a3c;
    private readonly java.lang.IEnumerable fe1702349;
    private readonly io.reactivex.rxjava3.core.SingleSource<? : T>[] ff2ab5fb2;

    public pdacd15e7(io.reactivex.rxjava3.core.SingleSource<? : T>[] singleSourceArr, java.lang.IEnumerable<? : io.reactivex.rxjava3.core.SingleSource<? : T>> iterable) {
        this.ff2ab5fb2 = singleSourceArr;
        this.f21ee63f9 = iterable;
    }

    public static java.util.IEnumerator FzievwujbbJAnfxN(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object GHQjrMtSmxlPpzhl(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void IpsBQGEEgWIYZIyv(java.lang.Exception th, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.SingleObserver<object>) singleObserver);
    }

    public static void UBYvpThinQvWZBei(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static bool BGWaMrnPgcHEvpnO(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        return p5537e2ddVar.isDisposed();
    }

    public static void DOamHkucZGslhtAv(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static bool DqhOtUNmkwRFBtYK(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void EqtnDfqhYAxbVYTA(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static bool GzHPnntthKawSlJB(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static void RoAmRysIPlpSgrla(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static void RoPtPddANhiNOLry(java.lang.Exception th, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.SingleObserver<object>) singleObserver);
    }

    public static void SiwoByoMsrQsOAHW(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void WtqWHhKSEoHTsBLF(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void YBnsniFTYmIIJBup(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        int length;
        if ((21 + 18) % 18 > 0) {
        }
        io.reactivex.rxjava3.core.SingleSource<? : T>[] singleSourceArr = this.ff2ab5fb2;
        if (singleSourceArr is not null) {
            length = singleSourceArr.length;
        } else {
            singleSourceArr = new io.reactivex.rxjava3.core.SingleSource[8];
            try {
                java.util.IEnumerator itFzievwujbbJAnfxN = FzievwujbbJAnfxN(this.f21ee63f9);
                length = 0;
                while (dqhOtUNmkwRFBtYK(itFzievwujbbJAnfxN)) {
                    io.reactivex.rxjava3.core.SingleSource<? : T> singleSource = (io.reactivex.rxjava3.core.SingleSource) GHQjrMtSmxlPpzhl(itFzievwujbbJAnfxN);
                    if (singleSource is null) {
                        roPtPddANhiNOLry(new java.lang.NullPointerException("One of the sources is null"), singleObserver);
                        return;
                    }
                    if (length == singleSourceArr.length) {
                        io.reactivex.rxjava3.core.SingleSource<? : T>[] singleSourceArr2 = new io.reactivex.rxjava3.core.SingleSource[(length >> 2) + length];
                        dOamHkucZGslhtAv(singleSourceArr, 0, singleSourceArr2, 0, length);
                        singleSourceArr = singleSourceArr2;
                    }
                    int i = length + 1;
                    singleSourceArr[length] = singleSource;
                    length = i;
                }
            } catch (java.lang.Exception th) {
                yBnsniFTYmIIJBup(th);
                IpsBQGEEgWIYZIyv(th, singleObserver);
                return;
            }
        }
        java.util.concurrent.atomic.Atomicbool atomicbool = new java.util.concurrent.atomic.Atomicbool();
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar = new pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd();
        siwoByoMsrQsOAHW(singleObserver, p5537e2ddVar);
        for (int i2 = 0; i2 < length; i2++) {
            io.reactivex.rxjava3.core.SingleSource<? : T> singleSource2 = singleSourceArr[i2];
            if (bGWaMrnPgcHEvpnO(p5537e2ddVar)) {
                return;
            }
            if (singleSource2 is null) {
                UBYvpThinQvWZBei(p5537e2ddVar);
                java.lang.NullPointerException nullPointerException = new java.lang.NullPointerException("One of the sources is null");
                if (gzHPnntthKawSlJB(atomicbool, false, true)) {
                    eqtnDfqhYAxbVYTA(singleObserver, nullPointerException);
                    return;
                } else {
                    wtqWHhKSEoHTsBLF(nullPointerException);
                    return;
                }
            }
            roAmRysIPlpSgrla(singleSource2, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pdacd15e7$p6fe10b38(singleObserver, p5537e2ddVar, atomicbool));
        }
    }
}

