namespace WillowMaze.Wasm.Decompiled;


public readonly class p451cc1e4<T, D> : io.reactivex.rxjava3.core.Observable<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1211474c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f180b5c9b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f232811df;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f260b30a9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f2c556a16;
    readonly io.reactivex.rxjava3.functions.Supplier<? : D> f451ed497;
    readonly bool f5b154520;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f5e899cfd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f5fc49eed;
    readonly bool f6e27745b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f722b7f67;
    readonly bool f82af20f3;
    readonly io.reactivex.rxjava3.functions.Function<? super D, ? : io.reactivex.rxjava3.core.ObservableSource<? : T>> f9053270d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f910b3e67;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fe2019312;
    readonly io.reactivex.rxjava3.functions.Consumer<D> fefbacb3e;

    public p451cc1e4(io.reactivex.rxjava3.functions.Supplier<? : D> supplier, io.reactivex.rxjava3.functions.Function<? super D, ? : io.reactivex.rxjava3.core.ObservableSource<? : T>> function, io.reactivex.rxjava3.functions.Consumer<D> consumer, bool z) {
        this.f451ed497 = supplier;
        this.f9053270d = function;
        this.fefbacb3e = consumer;
        this.f5b154520 = z;
    }

    public static void AviENIIgHQaXKEOc(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void GbspZKKWGDZztoCr(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void KtxKkhDcpMfesKur(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void NMdHBchYpjyxZUPd(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void SNXqEkruZAAFSSNe(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static java.lang.object VfVzDBDNWCcQvtfe(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void NTcmZKJurUcygLSw(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, java.lang.object obj) throws java.lang.Exception {
        pf8afcf86Var.accept(obj);
    }

    public static void PmhLmxTLHNCHrndq(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static java.lang.object QCsLygWjNWBmQEBq(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void QRaRsMIhkJpfYNKI(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object TSQZaRQjVoNzSjvm(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((5 + 5) % 5 > 0) {
        }
        try {
            java.lang.object objQCsLygWjNWBmQEBq = qCsLygWjNWBmQEBq(this.f451ed497);
            try {
                NMdHBchYpjyxZUPd((io.reactivex.rxjava3.core.ObservableSource) VfVzDBDNWCcQvtfe(tSQZaRQjVoNzSjvm(this.f9053270d, objQCsLygWjNWBmQEBq), "The sourceSupplier returned a null ObservableSource"), new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p451cc1e4$p0af79e9c(observer, objQCsLygWjNWBmQEBq, this.fefbacb3e, this.f5b154520));
            } catch (java.lang.Exception th) {
                AviENIIgHQaXKEOc(th);
                try {
                    nTcmZKJurUcygLSw(this.fefbacb3e, objQCsLygWjNWBmQEBq);
                    GbspZKKWGDZztoCr(th, observer);
                } catch (java.lang.Exception th2) {
                    KtxKkhDcpMfesKur(th2);
                    java.lang.Exception[] thArr = new java.lang.Exception[2];
                    thArr[0] = th;
                    thArr[1] = th2;
                    SNXqEkruZAAFSSNe(new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr), observer);
                }
            }
        } catch (java.lang.Exception th3) {
            qRaRsMIhkJpfYNKI(th3);
            pmhLmxTLHNCHrndq(th3, observer);
        }
    }
}

