namespace WillowMaze.Wasm.Decompiled;


readonly class pe10bde77$p373531b7<T, R> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f050051f4;
    readonly p5a445d71.p18f29add.p992c4a5b f115f7488;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f11cb6eaa;
    readonly p5a445d71.p18f29add.p992c4a5b f1dd5b62f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f243320c2;
    bool f46b5fb28;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : R> f4b9f83e1;
    p5a445d71.p18f29add.p787ad0b7 f6722e3ca;
    bool f6b2ded51;
    bool fac2f8d92;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly org.reactivestreams.Subscriber<R> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fe0613a42;

    pe10bde77$p373531b7(org.reactivestreams.Subscriber<R> subscriber, io.reactivex.rxjava3.functions.Function<? super T, ? : R> function) {
        this.fd22a0a80 = subscriber;
        this.f4b9f83e1 = function;
    }

    public static void ClTAFJGYDWrGNMIW(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static java.lang.object DxdrppzNrJYsKsKo(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void JeALxjWzKKRAlpBY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe10bde77$p373531b7 pe10bde77_p373531b7, java.lang.Exception th) {
        pe10bde77_p373531b7.onError(th);
    }

    public static void OLCKREcPuNoZoaxb(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void WoseAxBdbZRDqFDf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe10bde77$p373531b7 pe10bde77_p373531b7) {
        pe10bde77_p373531b7.cancel();
    }

    public static void FsiRbyXJXrvdWgLg(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void IPNrFQbxLyiZYpLL(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void NoYtJfxcjtMGOXgg(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static java.lang.object PCevJEMHwxsVjmMl(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void PlLBFrECoWblXqYd(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void RfQUuGmPaWUbdcSb(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool WYeSRrHPoHqLeCdz(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void XxOUvfQSOhSEuVKu(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public override void Cancel() {
        OLCKREcPuNoZoaxb(this.fbc3b0556);
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        ClTAFJGYDWrGNMIW(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            fsiRbyXJXrvdWgLg(th);
        } else {
            this.f6b2ded51 = true;
            plLBFrECoWblXqYd(this.fd22a0a80, th);
        }
    }

    public void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        try {
            rfQUuGmPaWUbdcSb(this.fd22a0a80, DxdrppzNrJYsKsKo(pCevJEMHwxsVjmMl(this.f4b9f83e1, t), "The mapper returned a null value"));
        } catch (java.lang.Exception th) {
            xxOUvfQSOhSEuVKu(th);
            WoseAxBdbZRDqFDf(this);
            JeALxjWzKKRAlpBY(this, th);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (wYeSRrHPoHqLeCdz(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            iPNrFQbxLyiZYpLL(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        noYtJfxcjtMGOXgg(this.fbc3b0556, j);
    }
}

