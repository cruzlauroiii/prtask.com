namespace WillowMaze.Wasm.Decompiled;


readonly class pd0068a75$p92657f89<U> : io.reactivex.rxjava3.core.Observer<U> {
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f053d880e;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableSkipUntil$SkipUntilObserver<T> f1158f5f8;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f16d99916;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0068a75$p3ef40668 f2999980c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p74f2a0f6 f363de9b4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 f36de7723;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p74f2a0f6 f411922e3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p74f2a0f6 f50df435f;
    readonly io.reactivex.rxjava3.observers.SerializedObserver<T> f74136b24;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0068a75$p3ef40668 f786d0936;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fa81ee2f3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p74f2a0f6 fb89547f2;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 fc21e584e;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fd5801313;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0068a75$p3ef40668 ff338d40b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 ff964379c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0068a75 this$0;

    pd0068a75$p92657f89(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0068a75 pd0068a75Var, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 pe8bf89d0Var, io.reactivex.rxjava3.internal.operators.observable.ObservableSkipUntil$SkipUntilObserver<T> observableSkipUntil$SkipUntilObserver, io.reactivex.rxjava3.observers.SerializedObserver<T> serializedObserver) {
        this.this$0 = pd0068a75Var;
        this.ff964379c = pe8bf89d0Var;
        this.f1158f5f8 = observableSkipUntil$SkipUntilObserver;
        this.f74136b24 = serializedObserver;
    }

    public static bool EBGpLgrmayAwXAQT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 pe8bf89d0Var, int i, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pe8bf89d0Var.setResource(i, p7beea252Var);
    }

    public static void BEBCRhQYQyAGMYfF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 pe8bf89d0Var) {
        pe8bf89d0Var.dispose();
    }

    public static void GnIlAIGxGJHENKlB(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool UwKbyYwjPRnJJFhq(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void XBEpKlfWpgsDYFPw(pf98ed07a.pa30d0e7f.p90676d7c.p6ea648a6.p74f2a0f6 p74f2a0f6Var, java.lang.Exception th) {
        p74f2a0f6Var.onError(th);
    }

    public override void OnComplete() {
        this.f1158f5f8.fbe747de2 = true;
    }

    public override void OnError(java.lang.Exception th) {
        bEBCRhQYQyAGMYfF(this.ff964379c);
        xBEpKlfWpgsDYFPw(this.f74136b24, th);
    }

    public override void OnNext(U u) {
        gnIlAIGxGJHENKlB(this.fbc3b0556);
        this.f1158f5f8.fbe747de2 = true;
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (uwKbyYwjPRnJJFhq(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            EBGpLgrmayAwXAQT(this.ff964379c, 1, p7beea252Var);
        }
    }
}

