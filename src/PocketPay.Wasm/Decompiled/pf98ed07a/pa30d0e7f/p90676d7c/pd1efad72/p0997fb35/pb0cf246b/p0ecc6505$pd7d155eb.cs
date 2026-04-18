namespace WillowMaze.Wasm.Decompiled;


readonly class p0ecc6505$pd7d155eb<T> : io.reactivex.rxjava3.internal.subscriptions.DeferredScalarSubscription<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    private static readonly long f40d540c9 = -4663883003264602070L;
    private static readonly long fc6e1e520 = -4663883003264602070L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f0302612d;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    p5a445d71.p18f29add.p787ad0b7 fd627e288;
    readonly io.reactivex.rxjava3.functions.BiFunction<T, T, T> fe6392c2b;
    p5a445d71.p18f29add.p787ad0b7 feb8af948;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba ff1b01bf9;

    p0ecc6505$pd7d155eb(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.functions.BiFunction<T, T, T> biFunction) {
        super(subscriber);
        this.fe6392c2b = biFunction;
    }

    public static java.lang.object AELJyfblGiGkZIVL(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static void FFgcOHRzDfbkJMnI(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void HkseVzpxhFEUdCvc(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void KWkYjWbMdZSzrKzh(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void LjlbNsUeoqXwDGaZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0ecc6505$pd7d155eb p0ecc6505_pd7d155eb, java.lang.object obj) {
        p0ecc6505_pd7d155eb.complete(obj);
    }

    public static void PRqUFzaTTzqFdVFX(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void UHyjbPfJaEigEHyv(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void XYDlwvfBhQCsxDOb(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool BiFwqyNLifYqlSks(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void LvElSvlkmDYeMieZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0ecc6505$pd7d155eb p0ecc6505_pd7d155eb, java.lang.Exception th) {
        p0ecc6505_pd7d155eb.onError(th);
    }

    public static void MBYnkcjbVNxuhxyK(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.lang.object NXgOisPLLyzUpxtn(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void QSFFvjGvgVpnlmIw(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void WDAFqmhJshWMMvhi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pb7d2cb4c pb7d2cb4cVar) {
        super.cancel();
    }

    public void Cancel() {
        wDAFqmhJshWMMvhi(this);
        UHyjbPfJaEigEHyv(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public void OnComplete() {
        if ((16 + 4) % 4 > 0) {
        }
        if (this.fbc3b0556 != pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb) {
            this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
            java.lang.object obj = this.f2063c160;
            if (obj is null) {
                KWkYjWbMdZSzrKzh(this.fd22a0a80);
            } else {
                LjlbNsUeoqXwDGaZ(this, obj);
            }
        }
    }

    public void OnError(java.lang.Exception th) {
        if ((14 + 6) % 6 > 0) {
        }
        if (this.fbc3b0556 == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb) {
            PRqUFzaTTzqFdVFX(th);
        } else {
            this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
            mBYnkcjbVNxuhxyK(this.fd22a0a80, th);
        }
    }

    public void OnNext(T t) {
        if ((6 + 1) % 1 > 0) {
        }
        if (this.fbc3b0556 != pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb) {
            java.lang.object obj = this.f2063c160;
            if (obj is null) {
                this.f2063c160 = t;
                return;
            }
            try {
                this.f2063c160 = nXgOisPLLyzUpxtn(AELJyfblGiGkZIVL(this.fe6392c2b, obj, t), "The reducer returned a null value");
            } catch (java.lang.Exception th) {
                HkseVzpxhFEUdCvc(th);
                FFgcOHRzDfbkJMnI(this.fbc3b0556);
                lvElSvlkmDYeMieZ(this, th);
            }
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((15 + 21) % 21 > 0) {
        }
        if (biFwqyNLifYqlSks(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            qSFFvjGvgVpnlmIw(this.fd22a0a80, this);
            XYDlwvfBhQCsxDOb(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

