namespace WillowMaze.Wasm.Decompiled;


readonly class p7b84ab53$pd7d155eb<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    java.lang.object f018b55d1;
    readonly io.reactivex.rxjava3.core.MaybeObserver f19ea525d;
    T f2063c160;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f514671bc;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f59d2b13c;
    readonly io.reactivex.rxjava3.core.MaybeObserver f66362315;
    readonly io.reactivex.rxjava3.core.MaybeObserver f68fbf5eb;
    bool f6b2ded51;
    p5a445d71.p18f29add.p787ad0b7 f7fed9ce7;
    p5a445d71.p18f29add.p787ad0b7 f889f1ccb;
    bool fb07d696a;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    java.lang.object fde8c7fbc;
    readonly io.reactivex.rxjava3.functions.BiFunction<T, T, T> fe6392c2b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba ff423d0bf;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba ffa73bdf9;

    p7b84ab53$pd7d155eb(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, io.reactivex.rxjava3.functions.BiFunction<T, T, T> biFunction) {
        this.fd22a0a80 = maybeObserver;
        this.fe6392c2b = biFunction;
    }

    public static java.lang.object GQOnjutmyABtBKOB(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void MMHQwnouQjrMPkMu(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void OHqKTEVBaIfrONQJ(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static void YFRHOyASmfZVXuNH(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void ExHZZsJGtaasZtVY(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void KcsVDXkqjnFVBwoG(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void LBnwYoImoRZQqacU(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void MPfelzCLekqibZTA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7b84ab53$pd7d155eb p7b84ab53_pd7d155eb, java.lang.Exception th) {
        p7b84ab53_pd7d155eb.onError(th);
    }

    public static void PcuRSjopGetBSfdc(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool QkkREGLdJtLOeTrH(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static java.lang.object SdbeuOAwmRKlYudx(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static void SxeFMGUStQmgrKoi(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void TMAJlcwMgUfBzLye(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public override void Dispose() {
        MMHQwnouQjrMPkMu(this.fbc3b0556);
        this.f6b2ded51 = true;
    }

    public override bool IsDisposed() {
        return this.f6b2ded51;
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        T t = this.f2063c160;
        if (t is null) {
            tMAJlcwMgUfBzLye(this.fd22a0a80);
        } else {
            sxeFMGUStQmgrKoi(this.fd22a0a80, t);
        }
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            pcuRSjopGetBSfdc(th);
        } else {
            this.f6b2ded51 = true;
            OHqKTEVBaIfrONQJ(this.fd22a0a80, th);
        }
    }

    public void OnNext(T t) {
        if ((1 + 9) % 9 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        T t2 = this.f2063c160;
        if (t2 is null) {
            this.f2063c160 = t;
            return;
        }
        try {
            this.f2063c160 = (T) GQOnjutmyABtBKOB(sdbeuOAwmRKlYudx(this.fe6392c2b, t2, t), "The reducer returned a null value");
        } catch (java.lang.Exception th) {
            lBnwYoImoRZQqacU(th);
            exHZZsJGtaasZtVY(this.fbc3b0556);
            mPfelzCLekqibZTA(this, th);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((23 + 23) % 23 > 0) {
        }
        if (qkkREGLdJtLOeTrH(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            kcsVDXkqjnFVBwoG(this.fd22a0a80, this);
            YFRHOyASmfZVXuNH(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

