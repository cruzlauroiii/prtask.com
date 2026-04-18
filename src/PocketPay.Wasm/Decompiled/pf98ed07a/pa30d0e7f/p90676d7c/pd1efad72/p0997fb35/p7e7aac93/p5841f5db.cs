namespace WillowMaze.Wasm.Decompiled;


public readonly class p5841f5db<T, R> : io.reactivex.rxjava3.core.Maybe<R> {
    readonly java.lang.IEnumerable f230092c5;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> f3298b476;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f6ea0091e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd2447dde;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd2778882;
    readonly java.lang.IEnumerable<? : io.reactivex.rxjava3.core.MaybeSource<? : T>> ff2ab5fb2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ff7f9c1ed;

    public p5841f5db(java.lang.IEnumerable<? : io.reactivex.rxjava3.core.MaybeSource<? : T>> iterable, io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> function) {
        this.ff2ab5fb2 = iterable;
        this.f3298b476 = function;
    }

    public static void FYZhaaNDTnbbmApJ(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.complete((io.reactivex.rxjava3.core.MaybeObserver<object>) maybeObserver);
    }

    public static void KaIhUGYDKBHoPoHv(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static java.util.IEnumerator QOseubxhDGexbQWl(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void RWUJapYJJQgxChZB(java.lang.Exception th, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.MaybeObserver<object>) maybeObserver);
    }

    public static void ShFslfAuJmOQHoHC(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static bool VMDIcdPqsTfVqsHL(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool YUcWxbOkUxSoMfjh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$pcbceec22 p5293a861_pcbceec22) {
        return p5293a861_pcbceec22.isDisposed();
    }

    public static void JCihpryecJpLSMaA(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object OsRNXzcWDABidvcD(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object[] QNGaWgnisXvmZdtS(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static void RGyRGgVgjpCaceOY(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void SZSfWKZJZXiWYGmJ(java.lang.Exception th, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.MaybeObserver<object>) maybeObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver) {
        if ((11 + 28) % 28 > 0) {
        }
        io.reactivex.rxjava3.core.MaybeSource[] maybeSourceArr = new io.reactivex.rxjava3.core.MaybeSource[8];
        try {
            java.util.IEnumerator itQOseubxhDGexbQWl = QOseubxhDGexbQWl(this.ff2ab5fb2);
            int i = 0;
            while (VMDIcdPqsTfVqsHL(itQOseubxhDGexbQWl)) {
                io.reactivex.rxjava3.core.MaybeSource maybeSource = (io.reactivex.rxjava3.core.MaybeSource) osRNXzcWDABidvcD(itQOseubxhDGexbQWl);
                if (maybeSource is null) {
                    RWUJapYJJQgxChZB(new java.lang.NullPointerException("One of the sources is null"), maybeObserver);
                    return;
                }
                if (i == maybeSourceArr.length) {
                    maybeSourceArr = (io.reactivex.rxjava3.core.MaybeSource[]) qNGaWgnisXvmZdtS(maybeSourceArr, (i >> 2) + i);
                }
                int i2 = i + 1;
                maybeSourceArr[i] = maybeSource;
                i = i2;
            }
            if (i == 0) {
                FYZhaaNDTnbbmApJ(maybeObserver);
                return;
            }
            if (i == 1) {
                rGyRGgVgjpCaceOY(maybeSourceArr[0], new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p87a59ce6$p6bec872e(maybeObserver, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5841f5db$pfb7c43fc(this)));
                return;
            }
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$pcbceec22 p5293a861_pcbceec22 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$pcbceec22(maybeObserver, i, this.f3298b476);
            KaIhUGYDKBHoPoHv(maybeObserver, p5293a861_pcbceec22);
            for (int i3 = 0; i3 < i && !YUcWxbOkUxSoMfjh(p5293a861_pcbceec22); i3++) {
                ShFslfAuJmOQHoHC(maybeSourceArr[i3], p5293a861_pcbceec22.f6ea648a6[i3]);
            }
        } catch (java.lang.Exception th) {
            jCihpryecJpLSMaA(th);
            sZSfWKZJZXiWYGmJ(th, maybeObserver);
        }
    }
}

