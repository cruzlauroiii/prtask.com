namespace WillowMaze.Wasm.Decompiled;


public readonly class pbb5a4423<T> : io.reactivex.rxjava3.core.Observable<T> {
    readonly io.reactivex.rxjava3.core.ObservableSource[] f0fe905dd;
    readonly java.lang.IEnumerable<? : io.reactivex.rxjava3.core.ObservableSource<? : T>> f21ee63f9;
    readonly java.lang.IEnumerable f79bb9fd5;
    readonly java.lang.IEnumerable f92d7c57a;
    readonly io.reactivex.rxjava3.core.ObservableSource[] fc5a1d3a1;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : T>[] ff2ab5fb2;

    public pbb5a4423(io.reactivex.rxjava3.core.ObservableSource<? : T>[] observableSourceArr, java.lang.IEnumerable<? : io.reactivex.rxjava3.core.ObservableSource<? : T>> iterable) {
        this.ff2ab5fb2 = observableSourceArr;
        this.f21ee63f9 = iterable;
    }

    public static void CNAAMkXFNVyOFvAC(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void FzaCAuQoZoytCmGr(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void KQaYLkedWfzISRpi(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.object OEzCruBQoewakCmE(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void RqNBYeRIAWsOLXJS(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void UtDWeYZTbeRTtIop(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbb5a4423$p7bd44374 pbb5a4423_p7bd44374, io.reactivex.rxjava3.core.ObservableSource[] observableSourceArr) {
        pbb5a4423_p7bd44374.subscribe(observableSourceArr);
    }

    public static java.util.IEnumerator DlQlAqUStWhkEucQ(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void KwqLtgYSHPlipstN(io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.complete((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static bool LPReWtzIdVZIHbBN(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void XRVCFnsPLBdMludb(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        int length;
        if ((11 + 9) % 9 > 0) {
        }
        io.reactivex.rxjava3.core.ObservableSource<? : T>[] observableSourceArr = this.ff2ab5fb2;
        if (observableSourceArr is not null) {
            length = observableSourceArr.length;
        } else {
            observableSourceArr = new io.reactivex.rxjava3.core.ObservableSource[8];
            try {
                java.util.IEnumerator itDlQlAqUStWhkEucQ = dlQlAqUStWhkEucQ(this.f21ee63f9);
                length = 0;
                while (lPReWtzIdVZIHbBN(itDlQlAqUStWhkEucQ)) {
                    io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource = (io.reactivex.rxjava3.core.ObservableSource) OEzCruBQoewakCmE(itDlQlAqUStWhkEucQ);
                    if (observableSource is null) {
                        CNAAMkXFNVyOFvAC(new java.lang.NullPointerException("One of the sources is null"), observer);
                        return;
                    }
                    if (length == observableSourceArr.length) {
                        io.reactivex.rxjava3.core.ObservableSource<? : T>[] observableSourceArr2 = new io.reactivex.rxjava3.core.ObservableSource[(length >> 2) + length];
                        KQaYLkedWfzISRpi(observableSourceArr, 0, observableSourceArr2, 0, length);
                        observableSourceArr = observableSourceArr2;
                    }
                    int i = length + 1;
                    observableSourceArr[length] = observableSource;
                    length = i;
                }
            } catch (java.lang.Exception th) {
                FzaCAuQoZoytCmGr(th);
                RqNBYeRIAWsOLXJS(th, observer);
                return;
            }
        }
        if (length == 0) {
            kwqLtgYSHPlipstN(observer);
        } else if (length != 1) {
            UtDWeYZTbeRTtIop(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbb5a4423$p7bd44374(observer, length), observableSourceArr);
        } else {
            xRVCFnsPLBdMludb(observableSourceArr[0], observer);
        }
    }
}

