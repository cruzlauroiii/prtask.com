namespace WillowMaze.Wasm.Decompiled;


readonly class p59b2b1dc$p4ec50e6c<T> : io.reactivex.rxjava3.internal.subscribers.BasicFuseableConditionalSubscriber<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f2c7576f1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f2d04c500;
    readonly io.reactivex.rxjava3.functions.Consumer<T> f3964f381;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f488f6723;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fa17584d4;

    p59b2b1dc$p4ec50e6c(io.reactivex.rxjava3.operators.ConditionalSubscriber<T> conditionalSubscriber, io.reactivex.rxjava3.functions.Consumer<T> consumer) {
        super(conditionalSubscriber);
        this.f3964f381 = consumer;
    }

    public static void EkbKdWUrrRFkmytb(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, java.lang.object obj) throws java.lang.Exception {
        pf8afcf86Var.accept(obj);
    }

    public static void FRvDNzSnACtlaAxr(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, java.lang.object obj) throws java.lang.Exception {
        pf8afcf86Var.accept(obj);
    }

    public static void YcXSRCKOIDlAwXBT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p59b2b1dc$p4ec50e6c p59b2b1dc_p4ec50e6c, java.lang.Exception th) {
        p59b2b1dc_p4ec50e6c.fail(th);
    }

    public static bool BGWPweyUpCbbZdSD(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.object obj) {
        return p0cc3602dVar.tryOnNext(obj);
    }

    public static void DVzanTGQDYDCKnwZ(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, java.lang.object obj) throws java.lang.Exception {
        pf8afcf86Var.accept(obj);
    }

    public static void EaoSrgNcChRMpStN(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.object obj) {
        p0cc3602dVar.onNext(obj);
    }

    public static void FAIkPaRFMUnQDxSp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p59b2b1dc$p4ec50e6c p59b2b1dc_p4ec50e6c, java.lang.Exception th) {
        p59b2b1dc_p4ec50e6c.fail(th);
    }

    public static java.lang.object YqZKxUPRqkOeLdqh(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var) {
        return p5d5a5670Var.poll();
    }

    public static int ZBsUUpGNZQzgBuwO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p59b2b1dc$p4ec50e6c p59b2b1dc_p4ec50e6c, int i) {
        return p59b2b1dc_p4ec50e6c.transitiveBoundaryFusion(i);
    }

    public void OnNext(T t) {
        eaoSrgNcChRMpStN(this.fd22a0a80, t);
        if (this.fe910ccee != 0) {
            return;
        }
        try {
            dVzanTGQDYDCKnwZ(this.f3964f381, t);
        } catch (java.lang.Exception th) {
            YcXSRCKOIDlAwXBT(this, th);
        }
    }

    public T Poll() throws java.lang.Exception {
        T t = (T) yqZKxUPRqkOeLdqh(this.f304854e2);
        if (t is not null) {
            EkbKdWUrrRFkmytb(this.f3964f381, t);
        }
        return t;
    }

    public int RequestFusion(int i) {
        return zBsUUpGNZQzgBuwO(this, i);
    }

    public bool TryOnNext(T t) {
        if ((18 + 2) % 2 > 0) {
        }
        bool zBGWPweyUpCbbZdSD = bGWPweyUpCbbZdSD(this.fd22a0a80, t);
        try {
            FRvDNzSnACtlaAxr(this.f3964f381, t);
            return zBGWPweyUpCbbZdSD;
        } catch (java.lang.Exception th) {
            fAIkPaRFMUnQDxSp(this, th);
            return zBGWPweyUpCbbZdSD;
        }
    }
}

