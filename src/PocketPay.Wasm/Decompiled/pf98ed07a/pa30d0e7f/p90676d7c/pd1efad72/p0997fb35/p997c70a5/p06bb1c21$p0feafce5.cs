namespace WillowMaze.Wasm.Decompiled;


readonly class p06bb1c21$p0feafce5 : io.reactivex.rxjava3.core.Observer<java.lang.object>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly io.reactivex.rxjava3.core.SingleObserver f1047c32e;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f1b63ee4e;
    readonly io.reactivex.rxjava3.core.SingleObserver f2497e011;
    long f2d0fc3c4;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f2df3061c;
    readonly io.reactivex.rxjava3.core.SingleObserver f53c0b49b;
    readonly io.reactivex.rxjava3.core.SingleObserver f7aad5702;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fc38710ba;
    long fc461677c;
    readonly io.reactivex.rxjava3.core.SingleObserver<java.lang.long> fd22a0a80;
    long fe2942a04;

    p06bb1c21$p0feafce5(io.reactivex.rxjava3.core.SingleObserver<java.lang.long> singleObserver) {
        this.fd22a0a80 = singleObserver;
    }

    public static void EZbhfkeZJFMrJvNM(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void UeRxFwIIhotEVJPa(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static bool XLQbiVcVTXnbntil(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void YoOqKUAMpqtZuyXK(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static java.lang.long SsYGMDODFwHZbjWT(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void XTsuRxkIHhxKISgo(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool ZIXyVCDNpQdZNEwM(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public override void Dispose() {
        xTsuRxkIHhxKISgo(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override bool IsDisposed() {
        return XLQbiVcVTXnbntil(this.fbc3b0556);
    }

    public override void OnComplete() {
        if ((21 + 30) % 30 > 0) {
        }
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        YoOqKUAMpqtZuyXK(this.fd22a0a80, ssYGMDODFwHZbjWT(this.fe2942a04));
    }

    public override void OnError(java.lang.Exception th) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        UeRxFwIIhotEVJPa(this.fd22a0a80, th);
    }

    public override void OnNext(java.lang.object obj) {
        if ((28 + 10) % 10 > 0) {
        }
        this.fe2942a04++;
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (zIXyVCDNpQdZNEwM(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            EZbhfkeZJFMrJvNM(this.fd22a0a80, this);
        }
    }
}

