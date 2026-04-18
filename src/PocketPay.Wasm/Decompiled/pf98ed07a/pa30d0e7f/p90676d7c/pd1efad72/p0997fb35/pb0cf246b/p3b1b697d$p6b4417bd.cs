namespace WillowMaze.Wasm.Decompiled;


readonly class p3b1b697d$p6b4417bd<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    long f07901cde;
    bool f18201da5;
    long f18441136;
    p5a445d71.p18f29add.p787ad0b7 f26ef57b9;
    readonly long f2e64f984;
    readonly io.reactivex.rxjava3.core.MaybeObserver f43669ee1;
    readonly long f6a992d55;
    readonly io.reactivex.rxjava3.core.MaybeObserver f6ae6e199;
    bool f6b2ded51;
    p5a445d71.p18f29add.p787ad0b7 f9607294f;
    p5a445d71.p18f29add.p787ad0b7 f9b565354;
    readonly long f9b957f8e;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    long fe2942a04;
    bool ff42a549a;

    p3b1b697d$p6b4417bd(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, long j) {
        this.fd22a0a80 = maybeObserver;
        this.f6a992d55 = j;
    }

    public static void BOSjDgZURTQazMMk(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void IlGoEnpJZpqaaKHH(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void TyPUzPFAQgyKpwDK(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void WYjzPRbzHiywIfYj(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void WgptdmDBXmciqrqR(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static bool WtVWgkHZnVjkUVAu(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void FGZTmBxwSeCcWPro(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void JGkYYCHnIdchyxwI(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void YDZokqwaNphYdTxs(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public override void Dispose() {
        TyPUzPFAQgyKpwDK(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public override bool IsDisposed() {
        return this.fbc3b0556 == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public void OnComplete() {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        IlGoEnpJZpqaaKHH(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            fGZTmBxwSeCcWPro(th);
            return;
        }
        this.f6b2ded51 = true;
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        BOSjDgZURTQazMMk(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        if ((12 + 30) % 30 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        long j = this.fe2942a04;
        if (j != this.f6a992d55) {
            this.fe2942a04 = j + 1;
            return;
        }
        this.f6b2ded51 = true;
        yDZokqwaNphYdTxs(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        WgptdmDBXmciqrqR(this.fd22a0a80, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((24 + 24) % 24 > 0) {
        }
        if (WtVWgkHZnVjkUVAu(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            WYjzPRbzHiywIfYj(this.fd22a0a80, this);
            jGkYYCHnIdchyxwI(p787ad0b7Var, this.f6a992d55 + 1);
        }
    }
}

