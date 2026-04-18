namespace WillowMaze.Wasm.Decompiled;


readonly class pb4a6cdfe$p6b4417bd<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly long f0dee82ee;
    readonly T f16830a58;
    p5a445d71.p18f29add.p787ad0b7 f1b67f7b4;
    readonly java.lang.object f1cf5dff3;
    p5a445d71.p18f29add.p787ad0b7 f2bad0ac2;
    readonly java.lang.object f3b941033;
    bool f42f41f10;
    readonly long f6a992d55;
    bool f6b2ded51;
    readonly long f918cb4f4;
    long f92ae84c5;
    long f9593908a;
    p5a445d71.p18f29add.p787ad0b7 f99699fec;
    long faa2675d4;
    bool fb36da187;
    readonly io.reactivex.rxjava3.core.SingleObserver fb8e519ac;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    bool fc6a02e97;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    long fd8cc87f0;
    long fe2942a04;
    bool ff5436dbf;

    pb4a6cdfe$p6b4417bd(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, long j, T t) {
        this.fd22a0a80 = singleObserver;
        this.f6a992d55 = j;
        this.f16830a58 = t;
    }

    public static void IxDAPxMwDpRxBXps(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void JvVzvAvdIJBJWmQb(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void YgOEvyWLZXTwgdtX(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void BiLarEaUTapdmGME(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void FOtKckKAXCAhKWcP(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void GiBvWxRbHQcLwhWJ(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void MRRiybWVYNtWwTuF(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void PYLDddGJrxNCcmBA(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool TlScNLWlwFmuRRHE(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void URGlRKVNbikVAWIA(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public override void Dispose() {
        mRRiybWVYNtWwTuF(this.fbc3b0556);
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
        T t = this.f16830a58;
        if (t is null) {
            biLarEaUTapdmGME(this.fd22a0a80, new java.util.NoSuchElementException());
        } else {
            uRGlRKVNbikVAWIA(this.fd22a0a80, t);
        }
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            JvVzvAvdIJBJWmQb(th);
            return;
        }
        this.f6b2ded51 = true;
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        fOtKckKAXCAhKWcP(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        if ((26 + 6) % 6 > 0) {
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
        giBvWxRbHQcLwhWJ(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        IxDAPxMwDpRxBXps(this.fd22a0a80, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((22 + 13) % 13 > 0) {
        }
        if (tlScNLWlwFmuRRHE(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            YgOEvyWLZXTwgdtX(this.fd22a0a80, this);
            pYLDddGJrxNCcmBA(p787ad0b7Var, this.f6a992d55 + 1);
        }
    }
}

