namespace WillowMaze.Wasm.Decompiled;


public readonly class pe7c376bd$p19001454<T> : io.reactivex.rxjava3.core.MaybeObserver<T>, io.reactivex.rxjava3.core.SingleObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly io.reactivex.rxjava3.core.MaybeObserver f08a49cc5;
    readonly io.reactivex.rxjava3.core.MaybeObserver f0e79ad56;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f3a1c8e93;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f3a79f1f3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f429c5d60;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f6165fc02;
    readonly io.reactivex.rxjava3.core.MaybeObserver f8cbfc662;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 fb57c2d9c;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.MaybeObserver fcc02576a;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.functions.Predicate<java.lang.Exception> ff670ef68;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 ffc70eaa9;

    public pe7c376bd$p19001454(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, io.reactivex.rxjava3.functions.Predicate<java.lang.Exception> predicate) {
        this.fd22a0a80 = maybeObserver;
        this.ff670ef68 = predicate;
    }

    public static void QzTJkZihDEzWnfpl(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void ReXZnyhSvxEPNhMj(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void VBmAIXNaCdoyVKTc(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void YoUqTTDjHZImCBfi(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static bool CWVlFtZzaQlGhixy(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static bool GcFeVxDznNThHDvo(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static bool HMEVoWdPGPokRkFs(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void KzuusKcgspmPZqBZ(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void OMFcnNIlxKakhsdW(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void OMSSXSNDVRNrvsBS(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void RRHSLqpbiupdGfXk(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public override void Dispose() {
        oMFcnNIlxKakhsdW(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return gcFeVxDznNThHDvo(this.fbc3b0556);
    }

    public override void OnComplete() {
        VBmAIXNaCdoyVKTc(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if ((1 + 21) % 21 > 0) {
        }
        try {
            if (cWVlFtZzaQlGhixy(this.ff670ef68, th)) {
                YoUqTTDjHZImCBfi(this.fd22a0a80);
            } else {
                kzuusKcgspmPZqBZ(this.fd22a0a80, th);
            }
        } catch (java.lang.Exception th2) {
            oMSSXSNDVRNrvsBS(th2);
            io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver = this.fd22a0a80;
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = th;
            thArr[1] = th2;
            QzTJkZihDEzWnfpl(maybeObserver, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (hMEVoWdPGPokRkFs(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            rRHSLqpbiupdGfXk(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        ReXZnyhSvxEPNhMj(this.fd22a0a80, t);
    }
}

