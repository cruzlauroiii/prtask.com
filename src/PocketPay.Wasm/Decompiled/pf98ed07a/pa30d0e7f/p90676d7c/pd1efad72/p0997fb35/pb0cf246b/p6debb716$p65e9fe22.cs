namespace WillowMaze.Wasm.Decompiled;


readonly class p6debb716$p65e9fe22<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f17a997e2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f2fa906fd;
    readonly p5a445d71.p18f29add.p992c4a5b f33e72d39;
    p5a445d71.p18f29add.p787ad0b7 f4e4a39e1;
    bool f560e6792;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f68f7fc11;
    bool f6b2ded51;
    bool f94397fdb;
    readonly p5a445d71.p18f29add.p992c4a5b fa42f840b;
    readonly p5a445d71.p18f29add.p992c4a5b fb5fd02de;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    bool fe2e761f1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 ff3928bb9;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;

    p6debb716$p65e9fe22(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        this.fd22a0a80 = subscriber;
        this.ff670ef68 = predicate;
    }

    public static void BlQeaNXycpfpEIkN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p6debb716$p65e9fe22 p6debb716_p65e9fe22, java.lang.Exception th) {
        p6debb716_p65e9fe22.onError(th);
    }

    public static void HVitOEgyZJdjaRkG(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void LAFJIOlkHnDvUsqs(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void NNaEWSKuYTeBUpsd(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void PtBbiZIsXDAuwAHv(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void UIUVjosTvNkiPgvT(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void XUlZLcjWkdflsIMl(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void JKpAuMFTrSjpLavV(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void JqzXbbsnNtXPxXMw(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void NMfUBiaCsrjPctWv(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool TgHPFWdOgOkywXri(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static bool VHWSSsGqnLcIrLkN(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static void VpPTUMKUhbkErrda(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void WDaUrGqDkpJlPQtp(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public override void Cancel() {
        UIUVjosTvNkiPgvT(this.fbc3b0556);
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        PtBbiZIsXDAuwAHv(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            jKpAuMFTrSjpLavV(th);
        } else {
            this.f6b2ded51 = true;
            wDaUrGqDkpJlPQtp(this.fd22a0a80, th);
        }
    }

    public void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        XUlZLcjWkdflsIMl(this.fd22a0a80, t);
        try {
            if (vHWSSsGqnLcIrLkN(this.ff670ef68, t)) {
                this.f6b2ded51 = true;
                HVitOEgyZJdjaRkG(this.fbc3b0556);
                jqzXbbsnNtXPxXMw(this.fd22a0a80);
            }
        } catch (java.lang.Exception th) {
            vpPTUMKUhbkErrda(th);
            NNaEWSKuYTeBUpsd(this.fbc3b0556);
            BlQeaNXycpfpEIkN(this, th);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (tgHPFWdOgOkywXri(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            LAFJIOlkHnDvUsqs(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        nMfUBiaCsrjPctWv(this.fbc3b0556, j);
    }
}

