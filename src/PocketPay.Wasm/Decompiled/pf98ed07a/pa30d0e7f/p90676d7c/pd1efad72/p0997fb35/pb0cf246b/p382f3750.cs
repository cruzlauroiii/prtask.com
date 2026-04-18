namespace WillowMaze.Wasm.Decompiled;


public readonly class p382f3750<T, R> : io.reactivex.rxjava3.core.Single<R> {
    readonly p5a445d71.p18f29add.p32c73be0 f0bfd58e6;
    readonly p5a445d71.p18f29add.p32c73be0 f31dcd01e;
    readonly org.reactivestreams.Publisher<T> f36cd38f4;
    readonly p5a445d71.p18f29add.p32c73be0 f5d1092a8;
    readonly io.reactivex.rxjava3.functions.Supplier<R> f5d7a373a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f5dbfa059;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f9379b8e2;
    readonly io.reactivex.rxjava3.functions.BiFunction<R, T, R> fe6392c2b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba feedf777e;

    public p382f3750(org.reactivestreams.Publisher<T> publisher, io.reactivex.rxjava3.functions.Supplier<R> supplier, io.reactivex.rxjava3.functions.BiFunction<R, T, R> biFunction) {
        this.f36cd38f4 = publisher;
        this.f5d7a373a = supplier;
        this.fe6392c2b = biFunction;
    }

    public static void EQAOAkqOzAiJaQPH(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static java.lang.object SOFLqQlikllfUyYj(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static java.lang.object FufNSqwsGuYlAnli(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void LBMFHSMKNMvsYWju(java.lang.Exception th, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.SingleObserver<object>) singleObserver);
    }

    public static void QwjqOFYqIfVZSoQp(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<R> singleObserver) {
        if ((23 + 3) % 3 > 0) {
        }
        try {
            EQAOAkqOzAiJaQPH(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p9fd6586f$p32707b45(singleObserver, this.fe6392c2b, fufNSqwsGuYlAnli(SOFLqQlikllfUyYj(this.f5d7a373a), "The seedSupplier returned a null value")));
        } catch (java.lang.Exception th) {
            qwjqOFYqIfVZSoQp(th);
            lBMFHSMKNMvsYWju(th, singleObserver);
        }
    }
}

