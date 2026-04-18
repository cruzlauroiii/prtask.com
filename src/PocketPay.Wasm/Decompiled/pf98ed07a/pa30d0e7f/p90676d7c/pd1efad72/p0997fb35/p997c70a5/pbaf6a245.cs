namespace WillowMaze.Wasm.Decompiled;


public readonly class pbaf6a245 {
    private pbaf6a245() {
        throw new java.lang.IllegalStateException("No instances!");
    }

    public static java.lang.object DKxwGNuqLLifBHSf(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static io.reactivex.rxjava3.core.Observable KRjIeIAYhPxwgYlZ(io.reactivex.rxjava3.core.Observable observable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(observable);
    }

    public static void KSYUefpKboPLKYIo(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void KzuRKFJYCnaJuPFD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbaf6a245$p89d11deb pbaf6a245_p89d11deb) {
        pbaf6a245_p89d11deb.run();
    }

    public static void VeavizxKOwUPdTpT(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void XJukuiFTJPgarNVw(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void YDPNbWoGCiozJVPy(io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.complete((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void YhcKgpxdFoJckVSw(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static java.lang.object CXbqueQFAEFlteuX(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void FXgNFimhSzqXTgoo(io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.complete((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static java.lang.object HrshnyTnYBIdByKF(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void JGaYHDlzsqhkupkT(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void JKEvFVyUYOAVtjFd(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static java.lang.object LwnlNMukerzYDxYu(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static <T, R> bool M0abd2e53(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.core.Observer<R> observer, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> function) {
        if (!(observableSource is pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44)) {
            return false;
        }
        try {
            java.lang.object objHrshnyTnYBIdByKF = hrshnyTnYBIdByKF((pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44) observableSource);
            if (objHrshnyTnYBIdByKF is null) {
                YDPNbWoGCiozJVPy(observer);
                return true;
            }
            try {
                io.reactivex.rxjava3.core.ObservableSource observableSource2 = (io.reactivex.rxjava3.core.ObservableSource) DKxwGNuqLLifBHSf(cXbqueQFAEFlteuX(function, objHrshnyTnYBIdByKF), "The mapper returned a null ObservableSource");
                if (observableSource2 is pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44) {
                    try {
                        java.lang.object objLwnlNMukerzYDxYu = lwnlNMukerzYDxYu((pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44) observableSource2);
                        if (objLwnlNMukerzYDxYu is null) {
                            fXgNFimhSzqXTgoo(observer);
                            return true;
                        }
                        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbaf6a245$p89d11deb pbaf6a245_p89d11deb = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbaf6a245$p89d11deb(observer, objLwnlNMukerzYDxYu);
                        jKEvFVyUYOAVtjFd(observer, pbaf6a245_p89d11deb);
                        KzuRKFJYCnaJuPFD(pbaf6a245_p89d11deb);
                    } catch (java.lang.Exception th) {
                        rrJUjbZULraAnkKc(th);
                        YhcKgpxdFoJckVSw(th, observer);
                        return true;
                    }
                } else {
                    KSYUefpKboPLKYIo(observableSource2, observer);
                }
                return true;
            } catch (java.lang.Exception th2) {
                XJukuiFTJPgarNVw(th2);
                VeavizxKOwUPdTpT(th2, observer);
                return true;
            }
        } catch (java.lang.Exception th3) {
            qyUyWWCyAOsgouNE(th3);
            jGaYHDlzsqhkupkT(th3, observer);
            return true;
        }
    }

    public static <T, U> io.reactivex.rxjava3.core.Observable<U> Mac2035ca(T t, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : U>> function) {
        return KRjIeIAYhPxwgYlZ(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbaf6a245$p92f151e2(t, function));
    }

    public static void QyUyWWCyAOsgouNE(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void RrJUjbZULraAnkKc(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }
}

