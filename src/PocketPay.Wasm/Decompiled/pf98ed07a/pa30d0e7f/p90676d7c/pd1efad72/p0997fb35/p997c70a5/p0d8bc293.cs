namespace WillowMaze.Wasm.Decompiled;


public readonly class p0d8bc293<T, U> : io.reactivex.rxjava3.core.Single<U> : io.reactivex.rxjava3.internal.fuseable.FuseToObservable<U> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 f00623692;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f14d71a5d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 f2904867f;
    readonly io.reactivex.rxjava3.core.ObservableSource<T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f56363fd0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pe2a87954 f7b2eab0d;
    readonly io.reactivex.rxjava3.functions.BiConsumer<U, T> f91e3a7ff;
    readonly io.reactivex.rxjava3.core.ObservableSource f9f06227e;
    readonly io.reactivex.rxjava3.functions.Supplier<? : U> fb205c04e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fbdd7a38d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fdea93c0a;

    public p0d8bc293(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Supplier<? : U> supplier, io.reactivex.rxjava3.functions.BiConsumer<U, T> biConsumer) {
        this.f36cd38f4 = observableSource;
        this.fb205c04e = supplier;
        this.f91e3a7ff = biConsumer;
    }

    public static void BgboifZygomLhnYe(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object COBZYmfhLGSTIyXc(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static io.reactivex.rxjava3.core.Observable IQphsriCNFudVmTN(io.reactivex.rxjava3.core.Observable observable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(observable);
    }

    public static void QBKONVayAVbeGRqd(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void HqpPaFmnPnjyMFAU(java.lang.Exception th, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.SingleObserver<object>) singleObserver);
    }

    public static java.lang.object XwMfauOrdCqgXbub(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public io.reactivex.rxjava3.core.Observable<U> FuseToObservable() {
        if ((30 + 18) % 18 > 0) {
        }
        return IQphsriCNFudVmTN(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfcff9b1d(this.f36cd38f4, this.fb205c04e, this.f91e3a7ff));
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<U> singleObserver) {
        if ((6 + 32) % 32 > 0) {
        }
        try {
            QBKONVayAVbeGRqd(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0d8bc293$p2c0ed584(singleObserver, xwMfauOrdCqgXbub(COBZYmfhLGSTIyXc(this.fb205c04e), "The initialSupplier returned a null value"), this.f91e3a7ff));
        } catch (java.lang.Exception th) {
            BgboifZygomLhnYe(th);
            hqpPaFmnPnjyMFAU(th, singleObserver);
        }
    }
}

