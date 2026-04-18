namespace WillowMaze.Wasm.Decompiled;


readonly class p0ee8a1e1$p8b01a664<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly io.reactivex.rxjava3.core.Observer f29bdda7e;
    readonly io.reactivex.rxjava3.core.Observer f46840515;
    p5a445d71.p18f29add.p787ad0b7 f65e29802;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    p5a445d71.p18f29add.p787ad0b7 fc08eeff5;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;

    p0ee8a1e1$p8b01a664(io.reactivex.rxjava3.core.Observer<T> observer) {
        this.fd22a0a80 = observer;
    }

    public static void DjcnIHkmNpYdDlzJ(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static bool PZCEaiBmfUheaTjl(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void TyFtHnAAjcuHflBo(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void XksZdJmiEVvlhWtt(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void HNpqooDcpKWhcqbv(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void MUrjTFhzEyIuuUHq(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void OXnLFsyKXpBsvSAg(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public override void Dispose() {
        TyFtHnAAjcuHflBo(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public override bool IsDisposed() {
        return this.fbc3b0556 == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public void OnComplete() {
        oXnLFsyKXpBsvSAg(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        mUrjTFhzEyIuuUHq(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        hNpqooDcpKWhcqbv(this.fd22a0a80, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((8 + 5) % 5 > 0) {
        }
        if (PZCEaiBmfUheaTjl(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            DjcnIHkmNpYdDlzJ(this.fd22a0a80, this);
            XksZdJmiEVvlhWtt(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

