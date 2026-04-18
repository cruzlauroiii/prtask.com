namespace WillowMaze.Wasm.Decompiled;


readonly class pb8f919dc$pf047b211<T, U : java.util.ICollection<T>> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    p5a445d71.p18f29add.p787ad0b7 f0ce95e18;
    U f2063c160;
    java.util.ICollection f5da30b1d;
    readonly io.reactivex.rxjava3.core.SingleObserver f772cc46b;
    java.util.ICollection f866743b9;
    p5a445d71.p18f29add.p787ad0b7 faddb6472;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly io.reactivex.rxjava3.core.SingleObserver<U> fd22a0a80;
    java.util.ICollection fd8170f48;
    p5a445d71.p18f29add.p787ad0b7 fef07c8b2;

    pb8f919dc$pf047b211(io.reactivex.rxjava3.core.SingleObserver<U> singleObserver, U u) {
        this.fd22a0a80 = singleObserver;
        this.f2063c160 = u;
    }

    public static bool IgNiSehuAujhJpYg(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void PCcxzHeEwnNdqxpg(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void HQjSMcFgoPjOMobT(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void JuaoFcvdpYPDyUAc(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool QCfARcKgjSASZfpy(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static void SmIEFakuagItgTGs(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void XreNseIVwoaOSuFt(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public override void Dispose() {
        hQjSMcFgoPjOMobT(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public override bool IsDisposed() {
        return this.fbc3b0556 == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public void OnComplete() {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        xreNseIVwoaOSuFt(this.fd22a0a80, this.f2063c160);
    }

    public void OnError(java.lang.Exception th) {
        this.f2063c160 = null;
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        smIEFakuagItgTGs(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        qCfARcKgjSASZfpy(this.f2063c160, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((17 + 8) % 8 > 0) {
        }
        if (IgNiSehuAujhJpYg(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            PCcxzHeEwnNdqxpg(this.fd22a0a80, this);
            juaoFcvdpYPDyUAc(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

