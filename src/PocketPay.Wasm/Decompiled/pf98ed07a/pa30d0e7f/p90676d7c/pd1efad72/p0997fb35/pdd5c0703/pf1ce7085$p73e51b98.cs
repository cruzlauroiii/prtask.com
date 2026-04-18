namespace WillowMaze.Wasm.Decompiled;


readonly class pf1ce7085$p73e51b98<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    bool f1bd8afb8;
    T f2063c160;
    java.lang.object f21d793d6;
    readonly io.reactivex.rxjava3.core.SingleObserver f22011d67;
    readonly io.reactivex.rxjava3.core.SingleObserver f3f8937f2;
    readonly io.reactivex.rxjava3.core.SingleObserver f43296838;
    bool f5eb6d31e;
    p5a445d71.p18f29add.p787ad0b7 f64f0f519;
    volatile bool f65c65a79;
    bool f6b2ded51;
    p5a445d71.p18f29add.p787ad0b7 f8f176bfd;
    bool f91186d73;
    volatile bool faaa3735a;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    p5a445d71.p18f29add.p787ad0b7 fc3b57d41;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    volatile bool fd6604df3;
    p5a445d71.p18f29add.p787ad0b7 fe024a9e4;
    bool fe11a260a;
    volatile bool ff8b2648d;

    pf1ce7085$p73e51b98(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        this.fd22a0a80 = singleObserver;
    }

    public static void AAWfHByhEJkyGnHu(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void CdkCziZjpTpMPDPG(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static bool OaoRygRwIEqAgxFl(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void RyHVxtGQNKLBtirN(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void ZXCrUVdIxkpGuXlD(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void ATsVOkyyHpkGgffo(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void EkRVItKplwHfLsLU(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void IobXJXrLaQYrEgXy(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void MryEPqnTtOiNodzD(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void MzgJzNmehZkNwNzd(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public override void Dispose() {
        this.ff8b2648d = true;
        mryEPqnTtOiNodzD(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return this.ff8b2648d;
    }

    public void OnComplete() {
        if ((13 + 19) % 19 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        T t = this.f2063c160;
        this.f2063c160 = null;
        if (t is not null) {
            RyHVxtGQNKLBtirN(this.fd22a0a80, t);
        } else {
            CdkCziZjpTpMPDPG(this.fd22a0a80, new java.util.NoSuchElementException("The source Publisher is empty"));
        }
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            aTsVOkyyHpkGgffo(th);
            return;
        }
        this.f6b2ded51 = true;
        this.f2063c160 = null;
        mzgJzNmehZkNwNzd(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        if (this.f2063c160 is null) {
            this.f2063c160 = t;
            return;
        }
        ekRVItKplwHfLsLU(this.fbc3b0556);
        this.f6b2ded51 = true;
        this.f2063c160 = null;
        iobXJXrLaQYrEgXy(this.fd22a0a80, new java.lang.IndexOutOfBoundsException("Too many elements in the Publisher"));
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((9 + 30) % 30 > 0) {
        }
        if (OaoRygRwIEqAgxFl(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            ZXCrUVdIxkpGuXlD(this.fd22a0a80, this);
            AAWfHByhEJkyGnHu(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

