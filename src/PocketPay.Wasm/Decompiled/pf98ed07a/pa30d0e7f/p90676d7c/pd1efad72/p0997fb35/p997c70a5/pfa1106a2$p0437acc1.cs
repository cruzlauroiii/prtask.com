namespace WillowMaze.Wasm.Decompiled;


public readonly class pfa1106a2$p0437acc1<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f00351203;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f03aa28ac;
    readonly io.reactivex.rxjava3.core.Observer f061492bc;
    readonly io.reactivex.rxjava3.core.Observer f118ee389;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f3912ae13;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f3b3239f8;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f3f9f4db2;
    readonly io.reactivex.rxjava3.core.Observer f485745bb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f535d9cb4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 facf721dd;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly io.reactivex.rxjava3.functions.Predicate<java.lang.Exception> ff670ef68;

    public pfa1106a2$p0437acc1(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.functions.Predicate<java.lang.Exception> predicate) {
        this.fd22a0a80 = observer;
        this.ff670ef68 = predicate;
    }

    public static bool NISMLBkuoxbBqHHE(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void QZcddgTqPFpaNwCs(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static bool QioowHhHsiebTabD(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static void TGUGKQTahesbYTKF(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void TZfpewyAHWwsKEFS(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void TzCVlkQQHzUWbstc(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool CMEXPcWAasXxDFxa(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void CYhNHAhfHlnWgYuc(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void ITlwfwSvGKOLRSsm(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void JnknWsSOEBhNIJRr(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void NZeUxidNaNuCVcKH(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public override void Dispose() {
        jnknWsSOEBhNIJRr(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return cMEXPcWAasXxDFxa(this.fbc3b0556);
    }

    public override void OnComplete() {
        TzCVlkQQHzUWbstc(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if ((1 + 19) % 19 > 0) {
        }
        try {
            if (QioowHhHsiebTabD(this.ff670ef68, th)) {
                cYhNHAhfHlnWgYuc(this.fd22a0a80);
            } else {
                TZfpewyAHWwsKEFS(this.fd22a0a80, th);
            }
        } catch (java.lang.Exception th2) {
            TGUGKQTahesbYTKF(th2);
            io.reactivex.rxjava3.core.Observer<T> observer = this.fd22a0a80;
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = th;
            thArr[1] = th2;
            nZeUxidNaNuCVcKH(observer, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
        }
    }

    public override void OnNext(T t) {
        iTlwfwSvGKOLRSsm(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (NISMLBkuoxbBqHHE(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            QZcddgTqPFpaNwCs(this.fd22a0a80, this);
        }
    }
}

