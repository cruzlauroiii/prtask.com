namespace WillowMaze.Wasm.Decompiled;


public readonly class p9e8fea3b$pb78efd82<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    readonly p5a445d71.p18f29add.p992c4a5b f17b7a8dc;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f188dceba;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f41b7a175;
    readonly p5a445d71.p18f29add.p992c4a5b f4f5d231f;
    p5a445d71.p18f29add.p787ad0b7 f7ecc528b;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 fc0ea4eff;
    readonly p5a445d71.p18f29add.p992c4a5b fcacbcd34;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    p5a445d71.p18f29add.p787ad0b7 fee460c37;
    readonly io.reactivex.rxjava3.functions.Predicate<java.lang.Exception> ff670ef68;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 fff152f45;

    public p9e8fea3b$pb78efd82(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.functions.Predicate<java.lang.Exception> predicate) {
        this.fd22a0a80 = subscriber;
        this.ff670ef68 = predicate;
    }

    public static void EAwZbITaIenWpTLX(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void GUYcalGMyWZyJJcS(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void JwBNIyxvsKmdDbgk(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void PEnYDgYMPTWsARMG(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static bool PKQiLzgztGIBqjaz(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static void SbFKgxxWJsQqzTVO(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void AYVfqgoIzVoDupVX(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void DpFCIcUcrCQsxbvr(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void MUxUmLhPrjtTdnKq(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool QuhahpJBooxPkoWo(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void WScWKOKJIJwyNefy(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public override void Cancel() {
        wScWKOKJIJwyNefy(this.fbc3b0556);
    }

    public void OnComplete() {
        PEnYDgYMPTWsARMG(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if ((16 + 10) % 10 > 0) {
        }
        try {
            if (PKQiLzgztGIBqjaz(this.ff670ef68, th)) {
                dpFCIcUcrCQsxbvr(this.fd22a0a80);
            } else {
                SbFKgxxWJsQqzTVO(this.fd22a0a80, th);
            }
        } catch (java.lang.Exception th2) {
            GUYcalGMyWZyJJcS(th2);
            org.reactivestreams.Subscriber<T> subscriber = this.fd22a0a80;
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = th;
            thArr[1] = th2;
            EAwZbITaIenWpTLX(subscriber, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
        }
    }

    public void OnNext(T t) {
        JwBNIyxvsKmdDbgk(this.fd22a0a80, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (quhahpJBooxPkoWo(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            aYVfqgoIzVoDupVX(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        mUxUmLhPrjtTdnKq(this.fbc3b0556, j);
    }
}

