namespace WillowMaze.Wasm.Decompiled;


readonly class p50bcaf3b$p4ef17000 : io.reactivex.rxjava3.core.FlowableSubscriber<java.lang.object>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly io.reactivex.rxjava3.core.SingleObserver f510da1a1;
    long f51cad336;
    long f642d4770;
    readonly io.reactivex.rxjava3.core.SingleObserver f8970b42a;
    readonly io.reactivex.rxjava3.core.SingleObserver f8b9b97d7;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    p5a445d71.p18f29add.p787ad0b7 fc2f541b1;
    readonly io.reactivex.rxjava3.core.SingleObserver<java.lang.long> fd22a0a80;
    p5a445d71.p18f29add.p787ad0b7 fde02002b;
    readonly io.reactivex.rxjava3.core.SingleObserver fde425d2a;
    long fe2942a04;
    p5a445d71.p18f29add.p787ad0b7 fe794cc09;
    long ff18ba7c3;
    long ff561c8bb;

    p50bcaf3b$p4ef17000(io.reactivex.rxjava3.core.SingleObserver<java.lang.long> singleObserver) {
        this.fd22a0a80 = singleObserver;
    }

    public static void AVLdEgPrUTTvhFfn(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void FKvuIWofXrTQLWIq(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void OvAoNoWdHpSqwduY(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static bool QHNIgjFfUrvsHndW(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void QHdbrLhbNwKMuTuk(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static java.lang.long UwmEjKaeMKZxAMRy(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void WlGNGakwMaDlWVRa(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public override void Dispose() {
        FKvuIWofXrTQLWIq(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public override bool IsDisposed() {
        return this.fbc3b0556 == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public void OnComplete() {
        if ((20 + 7) % 7 > 0) {
        }
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        OvAoNoWdHpSqwduY(this.fd22a0a80, UwmEjKaeMKZxAMRy(this.fe2942a04));
    }

    public void OnError(java.lang.Exception th) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        AVLdEgPrUTTvhFfn(this.fd22a0a80, th);
    }

    public void OnNext(java.lang.object obj) {
        if ((32 + 17) % 17 > 0) {
        }
        this.fe2942a04++;
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((29 + 1) % 1 > 0) {
        }
        if (QHNIgjFfUrvsHndW(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            QHdbrLhbNwKMuTuk(this.fd22a0a80, this);
            WlGNGakwMaDlWVRa(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

