namespace WillowMaze.Wasm.Decompiled;


readonly class p6f5e6c40$pc67f1241<T, R> : io.reactivex.rxjava3.core.Flowable<R> {
    readonly T f2063c160;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4400b4ee;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : R>> f4b9f83e1;
    readonly java.lang.object f5bcb5e6f;
    readonly java.lang.object f7275e9d9;
    readonly java.lang.object f75f599d7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fb9d4cd1e;
    readonly java.lang.object ff66bb374;

    p6f5e6c40$pc67f1241(T t, io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : R>> function) {
        this.f2063c160 = t;
        this.f4b9f83e1 = function;
    }

    public static java.lang.object CKWxlePhbvlelhGn(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void OpPFODBMSzXzegvl(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void UZpIIleXqmXRmUrY(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void XLRgXGtuwUuKlgdr(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static void CDVwOFHImGGfKkSd(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static java.lang.object FordhiPtsIZAEXJF(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void IVNLcrcBSYWerzZN(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object IxCDXTzJiBNlQZtx(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void LkStXXyCSnchHroB(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static void WFJZZEVXCBELTaow(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.complete(p992c4a5bVar);
    }

    public override void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        try {
            p5a445d71.p18f29add.p32c73be0 p32c73be0Var = (p5a445d71.p18f29add.p32c73be0) CKWxlePhbvlelhGn(fordhiPtsIZAEXJF(this.f4b9f83e1, this.f2063c160), "The mapper returned a null Publisher");
            if (!(p32c73be0Var is pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44)) {
                cDVwOFHImGGfKkSd(p32c73be0Var, subscriber);
                return;
            }
            try {
                java.lang.object objIxCDXTzJiBNlQZtx = ixCDXTzJiBNlQZtx((pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44) p32c73be0Var);
                if (objIxCDXTzJiBNlQZtx is not null) {
                    UZpIIleXqmXRmUrY(subscriber, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p4c3c8cda(subscriber, objIxCDXTzJiBNlQZtx));
                } else {
                    wFJZZEVXCBELTaow(subscriber);
                }
            } catch (java.lang.Exception th) {
                iVNLcrcBSYWerzZN(th);
                lkStXXyCSnchHroB(th, subscriber);
            }
        } catch (java.lang.Exception th2) {
            OpPFODBMSzXzegvl(th2);
            XLRgXGtuwUuKlgdr(th2, subscriber);
        }
    }
}

