namespace WillowMaze.Wasm.Decompiled;


readonly class pc7931aa6$p6b4417bd<T> : io.reactivex.rxjava3.internal.subscriptions.DeferredScalarSubscription<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    private static readonly long f677bc706 = 4066607327284737757L;
    private static readonly long fc6e1e520 = 4066607327284737757L;
    private static readonly long fd7082d21 = 4066607327284737757L;
    readonly java.lang.object f0d43c33e;
    long f1254d68a;
    readonly bool f151b5375;
    readonly T f16830a58;
    p5a445d71.p18f29add.p787ad0b7 f1bf2a0b1;
    readonly bool f1d2566b1;
    bool f259b8e74;
    readonly bool f4fe1e667;
    bool f50136bf0;
    readonly long f50a7dbdf;
    readonly long f644f11e7;
    readonly long f6a992d55;
    bool f6b2ded51;
    readonly bool fa826c37b;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly java.lang.object fcee62afb;
    bool fcff48cd9;
    long fe2942a04;
    readonly long fe5c7b51f;
    bool ffac1e446;

    pc7931aa6$p6b4417bd(org.reactivestreams.Subscriber<T> subscriber, long j, T t, bool z) {
        super(subscriber);
        this.f6a992d55 = j;
        this.f16830a58 = t;
        this.f1d2566b1 = z;
    }

    public static void APipWkRJHeJzBATE(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void AyCpYmLYwcDPnFqp(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void FwJQXaaipcocbqJd(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void OHVzOCCuDNwYMpVi(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void TjOExJTbgtHtmplz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pb7d2cb4c pb7d2cb4cVar) {
        super.cancel();
    }

    public static bool UdxivRIdGQNGyljS(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void WtgVIHdQpKyVSyts(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void FPelYBXGdUssYikX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc7931aa6$p6b4417bd pc7931aa6_p6b4417bd, java.lang.object obj) {
        pc7931aa6_p6b4417bd.complete(obj);
    }

    public static void IIuoanZYckxISLgI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc7931aa6$p6b4417bd pc7931aa6_p6b4417bd, java.lang.object obj) {
        pc7931aa6_p6b4417bd.complete(obj);
    }

    public static void JQduEpAsnuwFHPNw(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void VwJMrkGYyjISoLYh(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void ZSOzhWoWisHucokD(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public void Cancel() {
        TjOExJTbgtHtmplz(this);
        OHVzOCCuDNwYMpVi(this.fbc3b0556);
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        T t = this.f16830a58;
        if (t is not null) {
            iIuoanZYckxISLgI(this, t);
        } else if (this.f1d2566b1) {
            WtgVIHdQpKyVSyts(this.fd22a0a80, new java.util.NoSuchElementException());
        } else {
            APipWkRJHeJzBATE(this.fd22a0a80);
        }
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            vwJMrkGYyjISoLYh(th);
        } else {
            this.f6b2ded51 = true;
            zSOzhWoWisHucokD(this.fd22a0a80, th);
        }
    }

    public void OnNext(T t) {
        if ((30 + 5) % 5 > 0) {
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
        jQduEpAsnuwFHPNw(this.fbc3b0556);
        fPelYBXGdUssYikX(this, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((17 + 16) % 16 > 0) {
        }
        if (UdxivRIdGQNGyljS(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            AyCpYmLYwcDPnFqp(this.fd22a0a80, this);
            FwJQXaaipcocbqJd(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

