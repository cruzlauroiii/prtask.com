namespace WillowMaze.Wasm.Decompiled;


readonly class p3d8908b7$p765294b8<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly io.reactivex.rxjava3.core.CompletableObserver f7a2f86cf;
    p5a445d71.p18f29add.p787ad0b7 f857466a5;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly io.reactivex.rxjava3.core.CompletableObserver fd22a0a80;

    p3d8908b7$p765294b8(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        this.fd22a0a80 = completableObserver;
    }

    public static void JKHtbjQUUNeIDlEn(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void CeaTmAcJridaLPsQ(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void JBjYQqrKKyLWXnBh(io.reactivex.rxjava3.core.CompletableObserver completableObserver, java.lang.Exception th) {
        completableObserver.onError(th);
    }

    public static bool PZBVIlmEEWPcUHZM(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void VmLOpjKqpwskCYkQ(io.reactivex.rxjava3.core.CompletableObserver completableObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        completableObserver.onSubscribe(p7beea252Var);
    }

    public static void WuGTWNIHcheYtIWp(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableObserver.onComplete();
    }

    public override void Dispose() {
        JKHtbjQUUNeIDlEn(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public override bool IsDisposed() {
        return this.fbc3b0556 == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public void OnComplete() {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        wuGTWNIHcheYtIWp(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        jBjYQqrKKyLWXnBh(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((16 + 1) % 1 > 0) {
        }
        if (pZBVIlmEEWPcUHZM(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            vmLOpjKqpwskCYkQ(this.fd22a0a80, this);
            ceaTmAcJridaLPsQ(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

