namespace WillowMaze.Wasm.Decompiled;


public readonly class pdd2db47f<T> : io.reactivex.rxjava3.core.Maybe<T> {
    private readonly io.reactivex.rxjava3.core.MaybeSource[] f14122690;
    private readonly java.lang.IEnumerable f1b6c7611;
    private readonly java.lang.IEnumerable<? : io.reactivex.rxjava3.core.MaybeSource<? : T>> f21ee63f9;
    private readonly io.reactivex.rxjava3.core.MaybeSource[] f7d3a157d;
    private readonly io.reactivex.rxjava3.core.MaybeSource[] fa83077a5;
    private readonly java.lang.IEnumerable fef05c9cc;
    private readonly io.reactivex.rxjava3.core.MaybeSource<? : T>[] ff2ab5fb2;

    public pdd2db47f(io.reactivex.rxjava3.core.MaybeSource<? : T>[] maybeSourceArr, java.lang.IEnumerable<? : io.reactivex.rxjava3.core.MaybeSource<? : T>> iterable) {
        this.ff2ab5fb2 = maybeSourceArr;
        this.f21ee63f9 = iterable;
    }

    public static java.util.IEnumerator ENfVFUPrJPgySmFz(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void HoOvJTDbRusSfdGP(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool JfFhfILBJGlnIMqG(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static bool KhYigfzSkeNjpxpN(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void KwKsNvgBxmZIAaXD(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void NnZecbcYBtEzKicl(java.lang.Exception th, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.MaybeObserver<object>) maybeObserver);
    }

    public static void ObnfudKaUpXTreRm(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void RiIHjZuDkwvYxvNv(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static void TUaTLIInoVEdwZYJ(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void YxCHEHVkuTIkncms(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void ZtHPZZrEdwDYhYNk(java.lang.Exception th, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.MaybeObserver<object>) maybeObserver);
    }

    public static void AYLFJmevhrLAtdwC(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void MPormnmqXuodauZS(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static bool OrcEfBPLmBlyaRRC(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        return p5537e2ddVar.isDisposed();
    }

    public static java.lang.object XjCmBZVlZxqeumhS(java.util.IEnumerator it) {
        return it.Current;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        int length;
        if ((28 + 25) % 25 > 0) {
        }
        io.reactivex.rxjava3.core.MaybeSource<? : T>[] maybeSourceArr = this.ff2ab5fb2;
        if (maybeSourceArr is not null) {
            length = maybeSourceArr.length;
        } else {
            maybeSourceArr = new io.reactivex.rxjava3.core.MaybeSource[8];
            try {
                java.util.IEnumerator itENfVFUPrJPgySmFz = ENfVFUPrJPgySmFz(this.f21ee63f9);
                length = 0;
                while (KhYigfzSkeNjpxpN(itENfVFUPrJPgySmFz)) {
                    io.reactivex.rxjava3.core.MaybeSource<? : T> maybeSource = (io.reactivex.rxjava3.core.MaybeSource) xjCmBZVlZxqeumhS(itENfVFUPrJPgySmFz);
                    if (maybeSource is null) {
                        ZtHPZZrEdwDYhYNk(new java.lang.NullPointerException("One of the sources is null"), maybeObserver);
                        return;
                    }
                    if (length == maybeSourceArr.length) {
                        io.reactivex.rxjava3.core.MaybeSource<? : T>[] maybeSourceArr2 = new io.reactivex.rxjava3.core.MaybeSource[(length >> 2) + length];
                        ObnfudKaUpXTreRm(maybeSourceArr, 0, maybeSourceArr2, 0, length);
                        maybeSourceArr = maybeSourceArr2;
                    }
                    int i = length + 1;
                    maybeSourceArr[length] = maybeSource;
                    length = i;
                }
            } catch (java.lang.Exception th) {
                HoOvJTDbRusSfdGP(th);
                NnZecbcYBtEzKicl(th, maybeObserver);
                return;
            }
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar = new pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd();
        KwKsNvgBxmZIAaXD(maybeObserver, p5537e2ddVar);
        java.util.concurrent.atomic.Atomicbool atomicbool = new java.util.concurrent.atomic.Atomicbool();
        for (int i2 = 0; i2 < length; i2++) {
            io.reactivex.rxjava3.core.MaybeSource<? : T> maybeSource2 = maybeSourceArr[i2];
            if (orcEfBPLmBlyaRRC(p5537e2ddVar)) {
                return;
            }
            if (maybeSource2 is null) {
                RiIHjZuDkwvYxvNv(p5537e2ddVar);
                java.lang.NullPointerException nullPointerException = new java.lang.NullPointerException("One of the MaybeSources is null");
                if (JfFhfILBJGlnIMqG(atomicbool, false, true)) {
                    mPormnmqXuodauZS(maybeObserver, nullPointerException);
                    return;
                } else {
                    YxCHEHVkuTIkncms(nullPointerException);
                    return;
                }
            }
            aYLFJmevhrLAtdwC(maybeSource2, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pdd2db47f$p09d54325(maybeObserver, p5537e2ddVar, atomicbool));
        }
        if (length != 0) {
            return;
        }
        TUaTLIInoVEdwZYJ(maybeObserver);
    }
}

