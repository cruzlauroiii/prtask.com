namespace WillowMaze.Wasm.Decompiled;


readonly class pbaf6a245$p92f151e2<T, R> : io.reactivex.rxjava3.core.Observable<R> {
    readonly T f2063c160;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> f4b9f83e1;
    readonly java.lang.object fc397efd4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fe7ec85ca;

    pbaf6a245$p92f151e2(T t, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> function) {
        this.f2063c160 = t;
        this.f4b9f83e1 = function;
    }

    public static java.lang.object CzbkUWireVZRkdak(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void DBpQbnVzWQABTeaD(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void JUBgubocUoFEuuqu(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void JyfEQaqFZmbezzvI(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void LbhQWKLoIPhljYqd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbaf6a245$p89d11deb pbaf6a245_p89d11deb) {
        pbaf6a245_p89d11deb.run();
    }

    public static void LyRjIjSoGPhuwhdT(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void XDEBDHdosvorvPne(io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.complete((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static java.lang.object HSCJSYZQknBXmmPZ(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void LRnAyyPDkJHvTuNY(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void LkrQzWAtXkEbpuyL(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static java.lang.object PCCNHShEccubbAVR(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        try {
            io.reactivex.rxjava3.core.ObservableSource observableSource = (io.reactivex.rxjava3.core.ObservableSource) CzbkUWireVZRkdak(hSCJSYZQknBXmmPZ(this.f4b9f83e1, this.f2063c160), "The mapper returned a null ObservableSource");
            if (!(observableSource is pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44)) {
                DBpQbnVzWQABTeaD(observableSource, observer);
                return;
            }
            try {
                java.lang.object objPCCNHShEccubbAVR = pCCNHShEccubbAVR((pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44) observableSource);
                if (objPCCNHShEccubbAVR is null) {
                    XDEBDHdosvorvPne(observer);
                    return;
                }
                pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbaf6a245$p89d11deb pbaf6a245_p89d11deb = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbaf6a245$p89d11deb(observer, objPCCNHShEccubbAVR);
                lkrQzWAtXkEbpuyL(observer, pbaf6a245_p89d11deb);
                LbhQWKLoIPhljYqd(pbaf6a245_p89d11deb);
            } catch (java.lang.Exception th) {
                JUBgubocUoFEuuqu(th);
                LyRjIjSoGPhuwhdT(th, observer);
            }
        } catch (java.lang.Exception th2) {
            lRnAyyPDkJHvTuNY(th2);
            JyfEQaqFZmbezzvI(th2, observer);
        }
    }
}

