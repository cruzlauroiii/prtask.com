namespace WillowMaze.Wasm.Decompiled;


readonly class p70631f3c$p46e76e1b<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f5902b1c4;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f69eb1073;
    readonly io.reactivex.rxjava3.core.Observer f886391bb;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fa902dc81;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.Observer fc8902945;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : T> fdb9d6c56;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fdc208f1c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fdd4b122c;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fdd5b2c02;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ffc05e25c;

    p70631f3c$p46e76e1b(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : T> function) {
        this.fd22a0a80 = observer;
        this.fdb9d6c56 = function;
    }

    public static bool ARkDbJjCtugfaBBu(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static bool BMthlucCUflaZxiH(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void QVrjrjroRpXbSYGz(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void YhMBGYFfRmxQfUNS(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static java.lang.object AnJmhLTzvGGWyuLc(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void BIbohdIaOgRrtlTK(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void BOJxOiYqpelSAdWX(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void HGyfXHcrCRIZrwGE(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void LxyeWNfRjiVKCadV(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void MagkfJdSaUsDgYwN(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void PXqBMrJLhwllvYsI(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.Exception TjGoYrkFnCDSWcIS(java.lang.NullPointerException nullPointerException, java.lang.Exception th) {
        return nullPointerException.initCause(th);
    }

    public static void UtwTlcAeuUYAuBCh(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public override void Dispose() {
        bIbohdIaOgRrtlTK(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return ARkDbJjCtugfaBBu(this.fbc3b0556);
    }

    public override void OnComplete() {
        QVrjrjroRpXbSYGz(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if ((26 + 30) % 30 > 0) {
        }
        try {
            java.lang.object objAnJmhLTzvGGWyuLc = anJmhLTzvGGWyuLc(this.fdb9d6c56, th);
            if (objAnJmhLTzvGGWyuLc is not null) {
                hGyfXHcrCRIZrwGE(this.fd22a0a80, objAnJmhLTzvGGWyuLc);
                magkfJdSaUsDgYwN(this.fd22a0a80);
            } else {
                java.lang.NullPointerException nullPointerException = new java.lang.NullPointerException("The supplied value is null");
                tjGoYrkFnCDSWcIS(nullPointerException, th);
                lxyeWNfRjiVKCadV(this.fd22a0a80, nullPointerException);
            }
        } catch (java.lang.Exception th2) {
            pXqBMrJLhwllvYsI(th2);
            io.reactivex.rxjava3.core.Observer<T> observer = this.fd22a0a80;
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = th;
            thArr[1] = th2;
            utwTlcAeuUYAuBCh(observer, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
        }
    }

    public override void OnNext(T t) {
        YhMBGYFfRmxQfUNS(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (BMthlucCUflaZxiH(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            bOJxOiYqpelSAdWX(this.fd22a0a80, this);
        }
    }
}

