namespace WillowMaze.Wasm.Decompiled;


public readonly class peb3b02af<T, D> : io.reactivex.rxjava3.core.Flowable<T> {
    readonly bool f0bd68fde;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f2caff852;
    readonly bool f2ced1c9b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f431af36d;
    readonly io.reactivex.rxjava3.functions.Supplier<? : D> f451ed497;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f56eecb25;
    readonly bool f5b154520;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f6116b531;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f7c5519d2;
    readonly io.reactivex.rxjava3.functions.Function<? super D, ? : org.reactivestreams.Publisher<? : T>> f9053270d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fc2f6b438;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fc4760fb4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc99108c3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fde40a9e7;
    readonly io.reactivex.rxjava3.functions.Consumer<D> fefbacb3e;
    readonly bool ffabba361;

    public peb3b02af(io.reactivex.rxjava3.functions.Supplier<? : D> supplier, io.reactivex.rxjava3.functions.Function<? super D, ? : org.reactivestreams.Publisher<? : T>> function, io.reactivex.rxjava3.functions.Consumer<D> consumer, bool z) {
        this.f451ed497 = supplier;
        this.f9053270d = function;
        this.fefbacb3e = consumer;
        this.f5b154520 = z;
    }

    public static java.lang.object BDTstftQbnEkyURS(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void BFDFmFkcwDgyqIov(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void GZYlDxsmIYgosFHM(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, java.lang.object obj) throws java.lang.Exception {
        pf8afcf86Var.accept(obj);
    }

    public static java.lang.object MDOFAiJYeQDgwdGJ(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void QTjkMGqJrAqxrndI(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static void TeOSKYLGsyLBemXb(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void YfIJbcXPKUJafoNc(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static void AteIijujqZWTYnnd(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static java.lang.object EAixYPVKQtDiTJlI(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void LMZnZtwKnUeHpQEB(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static void XxOQhHFXPzlrtnkn(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((17 + 4) % 4 > 0) {
        }
        try {
            java.lang.object objBDTstftQbnEkyURS = BDTstftQbnEkyURS(this.f451ed497);
            try {
                QTjkMGqJrAqxrndI((p5a445d71.p18f29add.p32c73be0) MDOFAiJYeQDgwdGJ(eAixYPVKQtDiTJlI(this.f9053270d, objBDTstftQbnEkyURS), "The sourceSupplier returned a null Publisher"), new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.peb3b02af$p6f0392ca(subscriber, objBDTstftQbnEkyURS, this.fefbacb3e, this.f5b154520));
            } catch (java.lang.Exception th) {
                xxOQhHFXPzlrtnkn(th);
                try {
                    GZYlDxsmIYgosFHM(this.fefbacb3e, objBDTstftQbnEkyURS);
                    lMZnZtwKnUeHpQEB(th, subscriber);
                } catch (java.lang.Exception th2) {
                    TeOSKYLGsyLBemXb(th2);
                    java.lang.Exception[] thArr = new java.lang.Exception[2];
                    thArr[0] = th;
                    thArr[1] = th2;
                    ateIijujqZWTYnnd(new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr), subscriber);
                }
            }
        } catch (java.lang.Exception th3) {
            BFDFmFkcwDgyqIov(th3);
            YfIJbcXPKUJafoNc(th3, subscriber);
        }
    }
}

