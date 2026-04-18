namespace WillowMaze.Wasm.Decompiled;


readonly class pf8c2030f$pb9cedb4c<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    bool f15e3a2be;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f5a60bd71;
    p5a445d71.p18f29add.p787ad0b7 f5ff5acbc;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f7262899e;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    bool fbe747de2;
    bool fc023b82f;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly p5a445d71.p18f29add.p992c4a5b fe823ca59;
    bool fe8deb452;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;
    bool ff988148a;

    pf8c2030f$pb9cedb4c(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        this.fd22a0a80 = subscriber;
        this.ff670ef68 = predicate;
    }

    public static void ANUGhCGfttUmKjIq(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void BgNMUEhUEIJAhklh(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void BpzWOGenPFgEdSuQ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void OsnqmrnZVWvxcGaQ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static bool PcYJeLbmlzlROEgC(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static void PdyXkuXWVJsaqApS(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void QBaCuDaHnWjpZpFq(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void TSnncNWoiPHSXlfn(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void BXfLdMxUEdOUEmuM(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool MJIdQvVtqEuFITBT(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void NhqNHEoUYlSSKAum(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void YpPcLpdKMtdzvsSs(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void ZMqlGzjaGaOgwsnw(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public override void Cancel() {
        nhqNHEoUYlSSKAum(this.fbc3b0556);
    }

    public void OnComplete() {
        ANUGhCGfttUmKjIq(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        QBaCuDaHnWjpZpFq(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        if ((31 + 11) % 11 > 0) {
        }
        if (this.fbe747de2) {
            bXfLdMxUEdOUEmuM(this.fd22a0a80, t);
            return;
        }
        try {
            if (PcYJeLbmlzlROEgC(this.ff670ef68, t)) {
                zMqlGzjaGaOgwsnw(this.fbc3b0556, 1L);
            } else {
                this.fbe747de2 = true;
                TSnncNWoiPHSXlfn(this.fd22a0a80, t);
            }
        } catch (java.lang.Exception th) {
            ypPcLpdKMtdzvsSs(th);
            BgNMUEhUEIJAhklh(this.fbc3b0556);
            BpzWOGenPFgEdSuQ(this.fd22a0a80, th);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (mJIdQvVtqEuFITBT(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            OsnqmrnZVWvxcGaQ(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        PdyXkuXWVJsaqApS(this.fbc3b0556, j);
    }
}

