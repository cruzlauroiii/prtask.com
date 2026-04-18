namespace WillowMaze.Wasm.Decompiled;


public readonly class p2067e67d<T, R> : io.reactivex.rxjava3.core.Single<R> {
    readonly java.lang.IEnumerable f1bdede84;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f2ce05636;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> f3298b476;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f8d5af015;
    readonly java.lang.IEnumerable fa50ba2dd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 faddb6faa;
    readonly java.lang.IEnumerable fdf47f012;
    readonly java.lang.IEnumerable<? : io.reactivex.rxjava3.core.SingleSource<? : T>> ff2ab5fb2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ff5a36fa8;

    public p2067e67d(java.lang.IEnumerable<? : io.reactivex.rxjava3.core.SingleSource<? : T>> iterable, io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> function) {
        this.ff2ab5fb2 = iterable;
        this.f3298b476 = function;
    }

    public static void BIWEsVSfAgiadoEP(java.lang.Exception th, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.SingleObserver<object>) singleObserver);
    }

    public static java.lang.object[] BIvlvDIfDHxhfhUS(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static void CQFGqEokNrVaCBqi(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static java.util.IEnumerator FCimpfJVqmguhcfR(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void YBsQlvFcGGgtLIVI(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static java.lang.object DEMrldjqSvZfNruM(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void JWWNCpbNxTkEzAdD(java.lang.Exception th, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.SingleObserver<object>) singleObserver);
    }

    public static bool KNrwMkHzkLbuYtEY(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void PrZoZjMXTMYxXqMD(java.lang.Exception th, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.SingleObserver<object>) singleObserver);
    }

    public static bool VydqermAvYgssGcM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$pcbceec22 pb37214dd_pcbceec22) {
        return pb37214dd_pcbceec22.isDisposed();
    }

    public static void WEBdVqmOIBLjQZac(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void WZHlHYCjqxWpHccc(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<R> singleObserver) {
        if ((1 + 17) % 17 > 0) {
        }
        io.reactivex.rxjava3.core.SingleSource[] singleSourceArr = new io.reactivex.rxjava3.core.SingleSource[8];
        try {
            java.util.IEnumerator itFCimpfJVqmguhcfR = FCimpfJVqmguhcfR(this.ff2ab5fb2);
            int i = 0;
            while (kNrwMkHzkLbuYtEY(itFCimpfJVqmguhcfR)) {
                io.reactivex.rxjava3.core.SingleSource singleSource = (io.reactivex.rxjava3.core.SingleSource) dEMrldjqSvZfNruM(itFCimpfJVqmguhcfR);
                if (singleSource is null) {
                    prZoZjMXTMYxXqMD(new java.lang.NullPointerException("One of the sources is null"), singleObserver);
                    return;
                }
                if (i == singleSourceArr.length) {
                    singleSourceArr = (io.reactivex.rxjava3.core.SingleSource[]) BIvlvDIfDHxhfhUS(singleSourceArr, (i >> 2) + i);
                }
                int i2 = i + 1;
                singleSourceArr[i] = singleSource;
                i = i2;
            }
            if (i == 0) {
                jWWNCpbNxTkEzAdD(new java.util.NoSuchElementException(), singleObserver);
                return;
            }
            if (i == 1) {
                CQFGqEokNrVaCBqi(singleSourceArr[0], new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p29550156$p52cf00b3(singleObserver, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p2067e67d$pfb7c43fc(this)));
                return;
            }
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$pcbceec22 pb37214dd_pcbceec22 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pb37214dd$pcbceec22(singleObserver, i, this.f3298b476);
            wEBdVqmOIBLjQZac(singleObserver, pb37214dd_pcbceec22);
            for (int i3 = 0; i3 < i && !vydqermAvYgssGcM(pb37214dd_pcbceec22); i3++) {
                YBsQlvFcGGgtLIVI(singleSourceArr[i3], pb37214dd_pcbceec22.f6ea648a6[i3]);
            }
        } catch (java.lang.Exception th) {
            wZHlHYCjqxWpHccc(th);
            BIWEsVSfAgiadoEP(th, singleObserver);
        }
    }
}

