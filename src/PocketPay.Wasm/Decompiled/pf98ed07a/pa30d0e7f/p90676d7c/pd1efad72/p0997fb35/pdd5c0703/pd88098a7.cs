namespace WillowMaze.Wasm.Decompiled;


public readonly class pd88098a7<T, U> : io.reactivex.rxjava3.core.Single<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f2a37e2d4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f32864d79;
    readonly io.reactivex.rxjava3.functions.Supplier<U> f451ed497;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f4bee5772;
    readonly bool f5b154520;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f8156bbf4;
    readonly bool f92542a98;
    readonly bool fa827b776;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 faa89c177;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fe393850c;
    readonly io.reactivex.rxjava3.functions.Consumer<U> fefbacb3e;
    readonly io.reactivex.rxjava3.functions.Function<? super U, ? : io.reactivex.rxjava3.core.SingleSource<? : T>> ff88916d4;

    public pd88098a7(io.reactivex.rxjava3.functions.Supplier<U> supplier, io.reactivex.rxjava3.functions.Function<? super U, ? : io.reactivex.rxjava3.core.SingleSource<? : T>> function, io.reactivex.rxjava3.functions.Consumer<U> consumer, bool z) {
        this.f451ed497 = supplier;
        this.ff88916d4 = function;
        this.fefbacb3e = consumer;
        this.f5b154520 = z;
    }

    public static void DDdPXDWMjyQpQLMb(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static java.lang.object JYzJJBvNVRZPPful(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void RQPkXACFjxJDZJJK(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void TsHTwmrOIatrMjoM(java.lang.Exception th, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.SingleObserver<object>) singleObserver);
    }

    public static java.lang.object JToZlUmyAoDXOLOU(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void MtocYshXCFiaXria(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void QVdRdGfgjXAdVoVL(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, java.lang.object obj) throws java.lang.Exception {
        pf8afcf86Var.accept(obj);
    }

    public static void QYJhFzSqMQsVnrkK(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void SAleZeMXbtvEFSks(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void UVmHtetcOxvLlZCg(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, java.lang.object obj) throws java.lang.Exception {
        pf8afcf86Var.accept(obj);
    }

    public static java.lang.object VPkfiGtLBzAiYcga(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void WKINgyecgrldJkQI(java.lang.Exception th, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.SingleObserver<object>) singleObserver);
    }

    public static void ZHzsuLAJfOashzGE(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((20 + 24) % 24 > 0) {
        }
        try {
            java.lang.object objJYzJJBvNVRZPPful = JYzJJBvNVRZPPful(this.f451ed497);
            try {
                DDdPXDWMjyQpQLMb((io.reactivex.rxjava3.core.SingleSource) jToZlUmyAoDXOLOU(vPkfiGtLBzAiYcga(this.ff88916d4, objJYzJJBvNVRZPPful), "The singleFunction returned a null SingleSource"), new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pd88098a7$pb390f1bf(singleObserver, objJYzJJBvNVRZPPful, this.f5b154520, this.fefbacb3e));
            } catch (java.lang.Exception th) {
                th = th;
                sAleZeMXbtvEFSks(th);
                if (this.f5b154520) {
                    try {
                        uVmHtetcOxvLlZCg(this.fefbacb3e, objJYzJJBvNVRZPPful);
                    } catch (java.lang.Exception th2) {
                        RQPkXACFjxJDZJJK(th2);
                        java.lang.Exception[] thArr = new java.lang.Exception[2];
                        thArr[0] = th;
                        thArr[1] = th2;
                        th = new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr);
                    }
                }
                wKINgyecgrldJkQI(th, singleObserver);
                if (this.f5b154520) {
                    return;
                }
                try {
                    qVdRdGfgjXAdVoVL(this.fefbacb3e, objJYzJJBvNVRZPPful);
                } catch (java.lang.Exception th3) {
                    mtocYshXCFiaXria(th3);
                    zHzsuLAJfOashzGE(th3);
                }
            }
        } catch (java.lang.Exception th4) {
            qYJhFzSqMQsVnrkK(th4);
            TsHTwmrOIatrMjoM(th4, singleObserver);
        }
    }
}

