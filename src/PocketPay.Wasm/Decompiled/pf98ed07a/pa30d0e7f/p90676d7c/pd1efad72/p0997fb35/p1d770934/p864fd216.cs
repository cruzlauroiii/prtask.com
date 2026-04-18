namespace WillowMaze.Wasm.Decompiled;


readonly class p864fd216 {
    private p864fd216() {
        throw new java.lang.IllegalStateException("No instances!");
    }

    public static void AvBRtqcrFwsLokTN(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object BdNjffxhqTkUOfNS(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void DhPqSgJGPnHQEDhq(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void PsJzKpirhJrlXITD(io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.complete((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void TOZoYrKsUqXkmdfU(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static java.lang.object UQwCVboNiRXtFxRd(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object VCVrqXKxAeIgNcdl(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object XXcfUpmkkjrAzMgG(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void AjUTRSIBkMFgKuDI(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object BLwybKMOKSheNkbU(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void BaNvBNjGBxtJsLmh(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    public static io.reactivex.rxjava3.core.MaybeObserver FWOkloRhGzGbObzu(io.reactivex.rxjava3.core.Observer observer) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p4e2f9198.m76ea0beb(observer);
    }

    public static void HKRqdjHHUEbWArUM(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static io.reactivex.rxjava3.core.SingleObserver KwJfIAkMLEUVDkPq(io.reactivex.rxjava3.core.Observer observer) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pdc419046.m76ea0beb(observer);
    }

    static <T, R> bool M0695b60d(java.lang.object obj, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> function, io.reactivex.rxjava3.core.Observer<R> observer) {
        if (!(obj is pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44)) {
            return false;
        }
        try {
            java.lang.object objXXcfUpmkkjrAzMgG = XXcfUpmkkjrAzMgG((pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44) obj);
            io.reactivex.rxjava3.core.MaybeSource maybeSource = objXXcfUpmkkjrAzMgG is not null ? (io.reactivex.rxjava3.core.MaybeSource) mpthFmdmCBUwBthi(BdNjffxhqTkUOfNS(function, objXXcfUpmkkjrAzMgG), "The mapper returned a null MaybeSource") : null;
            if (maybeSource is not null) {
                DhPqSgJGPnHQEDhq(maybeSource, fWOkloRhGzGbObzu(observer));
            } else {
                PsJzKpirhJrlXITD(observer);
            }
            return true;
        } catch (java.lang.Exception th) {
            AvBRtqcrFwsLokTN(th);
            TOZoYrKsUqXkmdfU(th, observer);
            return true;
        }
    }

    static <T> bool M53eb0443(java.lang.object obj, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.CompletableSource> function, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        if (!(obj is pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44)) {
            return false;
        }
        try {
            java.lang.object objSprEKQCAgEVVbdrS = sprEKQCAgEVVbdrS((pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44) obj);
            io.reactivex.rxjava3.core.CompletableSource completableSource = objSprEKQCAgEVVbdrS is not null ? (io.reactivex.rxjava3.core.CompletableSource) VCVrqXKxAeIgNcdl(UQwCVboNiRXtFxRd(function, objSprEKQCAgEVVbdrS), "The mapper returned a null CompletableSource") : null;
            if (completableSource is not null) {
                baNvBNjGBxtJsLmh(completableSource, completableObserver);
            } else {
                wjrnLqTJHMjZYSWN(completableObserver);
            }
            return true;
        } catch (java.lang.Exception th) {
            vEcxyecBGdirMMAu(th);
            usZuSsnjsATTXZkU(th, completableObserver);
            return true;
        }
    }

    static <T, R> bool M97c40b97(java.lang.object obj, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> function, io.reactivex.rxjava3.core.Observer<R> observer) {
        if (!(obj is pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44)) {
            return false;
        }
        try {
            java.lang.object objQpdXausExGkzVtfr = qpdXausExGkzVtfr((pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44) obj);
            io.reactivex.rxjava3.core.SingleSource singleSource = objQpdXausExGkzVtfr is not null ? (io.reactivex.rxjava3.core.SingleSource) bLwybKMOKSheNkbU(xCtajnGgHNgUfSmu(function, objQpdXausExGkzVtfr), "The mapper returned a null SingleSource") : null;
            if (singleSource is not null) {
                tGXYZJcmoaWsfiXp(singleSource, kwJfIAkMLEUVDkPq(observer));
            } else {
                qyRvNCBNikrzADrk(observer);
            }
            return true;
        } catch (java.lang.Exception th) {
            ajUTRSIBkMFgKuDI(th);
            hKRqdjHHUEbWArUM(th, observer);
            return true;
        }
    }

    public static java.lang.object MpthFmdmCBUwBthi(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object QpdXausExGkzVtfr(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void QyRvNCBNikrzADrk(io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.complete((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static java.lang.object SprEKQCAgEVVbdrS(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void TGXYZJcmoaWsfiXp(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static void UsZuSsnjsATTXZkU(java.lang.Exception th, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, completableObserver);
    }

    public static void VEcxyecBGdirMMAu(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void WjrnLqTJHMjZYSWN(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.complete(completableObserver);
    }

    public static java.lang.object XCtajnGgHNgUfSmu(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }
}

