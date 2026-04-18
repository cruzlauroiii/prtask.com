namespace WillowMaze.Wasm.Decompiled;


readonly class p9fd6586f$p32707b45<T, R> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    java.lang.object f0f8a28bf;
    java.lang.object f1a3529c4;
    R f2063c160;
    readonly io.reactivex.rxjava3.core.SingleObserver f317aa8dd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f4be82cb0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f5099d71e;
    readonly io.reactivex.rxjava3.core.SingleObserver f51a2a6c5;
    java.lang.object f7aa276b2;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly io.reactivex.rxjava3.core.SingleObserver<R> fd22a0a80;
    readonly io.reactivex.rxjava3.core.SingleObserver fddd2145e;
    readonly io.reactivex.rxjava3.functions.BiFunction<R, T, R> fe6392c2b;
    p5a445d71.p18f29add.p787ad0b7 ffcc13d5e;

    p9fd6586f$p32707b45(io.reactivex.rxjava3.core.SingleObserver<R> singleObserver, io.reactivex.rxjava3.functions.BiFunction<R, T, R> biFunction, R r) {
        this.fd22a0a80 = singleObserver;
        this.f2063c160 = r;
        this.fe6392c2b = biFunction;
    }

    public static void ABsvjXpWIZqYrBdD(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static java.lang.object KAQenEDdQoAGvbNo(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static bool KGSFkzoaQrBclTZJ(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void PnOohrLekunuscjN(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void QwKVkxTBgLinhkLG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9fd6586f$p32707b45 p9fd6586f_p32707b45, java.lang.Exception th) {
        p9fd6586f_p32707b45.onError(th);
    }

    public static void TjGrggfoJfrivxlm(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void OYXlmhiwMBpwLOku(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static java.lang.object SfMwuaRghlhSvttn(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static void SomEJeksNnyvzmqF(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void WEFfVGzraRAXOSsk(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void XMasZWyoWHrviwpk(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void ZxQjVzyWYHYKFEnm(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public override void Dispose() {
        PnOohrLekunuscjN(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public override bool IsDisposed() {
        return this.fbc3b0556 == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public void OnComplete() {
        if ((9 + 10) % 10 > 0) {
        }
        R r = this.f2063c160;
        if (r is null) {
            return;
        }
        this.f2063c160 = null;
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        wEFfVGzraRAXOSsk(this.fd22a0a80, r);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f2063c160 is null) {
            ABsvjXpWIZqYrBdD(th);
            return;
        }
        this.f2063c160 = null;
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        TjGrggfoJfrivxlm(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        if ((16 + 8) % 8 > 0) {
        }
        R r = this.f2063c160;
        if (r is null) {
            return;
        }
        try {
            this.f2063c160 = (R) KAQenEDdQoAGvbNo(sfMwuaRghlhSvttn(this.fe6392c2b, r, t), "The reducer returned a null value");
        } catch (java.lang.Exception th) {
            somEJeksNnyvzmqF(th);
            xMasZWyoWHrviwpk(this.fbc3b0556);
            QwKVkxTBgLinhkLG(this, th);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((8 + 21) % 21 > 0) {
        }
        if (KGSFkzoaQrBclTZJ(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            zxQjVzyWYHYKFEnm(this.fd22a0a80, this);
            oYXlmhiwMBpwLOku(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

