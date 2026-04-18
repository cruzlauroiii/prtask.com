namespace WillowMaze.Wasm.Decompiled;


readonly class p2d22cca3$p541fb820<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    T f2063c160;
    java.lang.object f218ce703;
    bool f22a67d78;
    readonly io.reactivex.rxjava3.core.MaybeObserver f3f54f282;
    bool f6b2ded51;
    readonly io.reactivex.rxjava3.core.MaybeObserver f72646ede;
    java.lang.object f83815156;
    p5a445d71.p18f29add.p787ad0b7 f8f5d0e2c;
    bool fa8ef80f9;
    java.lang.object fbb7bfb74;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly io.reactivex.rxjava3.core.MaybeObserver fc6defb3a;
    bool fcc9c4daf;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    p5a445d71.p18f29add.p787ad0b7 ff8f5cf01;
    bool ffadbf937;

    p2d22cca3$p541fb820(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        this.fd22a0a80 = maybeObserver;
    }

    public static void BJWOxryEbNcXlARq(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void TbSxKSSqAyjEdbuA(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static bool WHfplyJKTRMZWoAN(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void ARJPmtnFnCitOLpO(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void HNMmBiXOMYIhHAZE(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void JNnLCRHHiwOgidEY(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void LjIrVCyDJLDRcpCf(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void LvrXfuLemRGqPmdH(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void QgMuZKQIKvdfLRiR(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void YdFNtCjCJDXPpytR(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public override void Dispose() {
        hNMmBiXOMYIhHAZE(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public override bool IsDisposed() {
        return this.fbc3b0556 == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public void OnComplete() {
        if ((25 + 8) % 8 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        T t = this.f2063c160;
        this.f2063c160 = null;
        if (t is not null) {
            aRJPmtnFnCitOLpO(this.fd22a0a80, t);
        } else {
            ydFNtCjCJDXPpytR(this.fd22a0a80);
        }
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            BJWOxryEbNcXlARq(th);
            return;
        }
        this.f6b2ded51 = true;
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        qgMuZKQIKvdfLRiR(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        if (this.f2063c160 is null) {
            this.f2063c160 = t;
            return;
        }
        this.f6b2ded51 = true;
        lvrXfuLemRGqPmdH(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        ljIrVCyDJLDRcpCf(this.fd22a0a80, new java.lang.IllegalArgumentException("Sequence contains more than one element!"));
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((8 + 8) % 8 > 0) {
        }
        if (WHfplyJKTRMZWoAN(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            TbSxKSSqAyjEdbuA(this.fd22a0a80, this);
            jNnLCRHHiwOgidEY(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

