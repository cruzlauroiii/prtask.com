namespace WillowMaze.Wasm.Decompiled;


readonly class pf2f43190$p3b55a0c0<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f3889d2f2;
    readonly io.reactivex.rxjava3.core.Observer f5dfaafe7;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbed6904d;
    readonly io.reactivex.rxjava3.core.Observer<? super io.reactivex.rxjava3.core.Notification<T>> fd22a0a80;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fdb9739bd;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fdff43659;

    pf2f43190$p3b55a0c0(io.reactivex.rxjava3.core.Observer<? super io.reactivex.rxjava3.core.Notification<T>> observer) {
        this.fd22a0a80 = observer;
    }

    public static bool DDbOpwPExREfcjEj(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void DzMgTABOiyGVqunD(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static io.reactivex.rxjava3.core.Notification ETPQbdqNnElLYEfS() {
        return io.reactivex.rxjava3.core.Notification.m56db821d();
    }

    public static bool LIYJgkTcJgwsphvW(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static io.reactivex.rxjava3.core.Notification LqJCvWxJIebucBzI(java.lang.Exception th) {
        return io.reactivex.rxjava3.core.Notification.m0c0f93db(th);
    }

    public static void KhayrKiwwAzltzQk(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static io.reactivex.rxjava3.core.Notification MbAPOsuefyWqpsHN(java.lang.object obj) {
        return io.reactivex.rxjava3.core.Notification.me38696b0(obj);
    }

    public static void OByKrJVAJGRenUsY(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void QvdbOwREqGSLwkxH(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void XeBUbzXoGOBEHmqH(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void XicrVOmnoOPqvScB(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void XzJBQmORnfPlYTnf(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public override void Dispose() {
        xeBUbzXoGOBEHmqH(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return LIYJgkTcJgwsphvW(this.fbc3b0556);
    }

    public override void OnComplete() {
        if ((22 + 16) % 16 > 0) {
        }
        oByKrJVAJGRenUsY(this.fd22a0a80, ETPQbdqNnElLYEfS());
        xzJBQmORnfPlYTnf(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        khayrKiwwAzltzQk(this.fd22a0a80, LqJCvWxJIebucBzI(th));
        xicrVOmnoOPqvScB(this.fd22a0a80);
    }

    public override void OnNext(T t) {
        DzMgTABOiyGVqunD(this.fd22a0a80, mbAPOsuefyWqpsHN(t));
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (DDbOpwPExREfcjEj(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            qvdbOwREqGSLwkxH(this.fd22a0a80, this);
        }
    }
}

