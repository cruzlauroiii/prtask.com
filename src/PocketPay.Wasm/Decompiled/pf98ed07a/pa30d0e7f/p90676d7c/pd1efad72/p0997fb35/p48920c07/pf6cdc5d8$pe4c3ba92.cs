namespace WillowMaze.Wasm.Decompiled;


readonly class pf6cdc5d8$pe4c3ba92<T, R> : io.reactivex.rxjava3.operators.ConditionalSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    bool f296bcf8a;
    bool f4a8f3d25;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : R> f4b9f83e1;
    p5a445d71.p18f29add.p787ad0b7 f688fee89;
    bool f6b2ded51;
    p5a445d71.p18f29add.p787ad0b7 f81f5da5e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f953f45b5;
    bool f95b465cc;
    readonly p5a445d71.p18f29add.p992c4a5b fb22bdebd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fb77e6e1e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fbb6d0b86;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    bool fc1ccd48b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fc95a7f67;
    readonly org.reactivestreams.Subscriber<R> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fda4ac8f3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fe9cf5681;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super java.lang.long, ? super java.lang.Exception, pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9> ff56352fa;

    pf6cdc5d8$pe4c3ba92(org.reactivestreams.Subscriber<R> subscriber, io.reactivex.rxjava3.functions.Function<? super T, ? : R> function, io.reactivex.rxjava3.functions.BiFunction<? super java.lang.long, ? super java.lang.Exception, pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9> biFunction) {
        this.fd22a0a80 = subscriber;
        this.f4b9f83e1 = function;
        this.ff56352fa = biFunction;
    }

    public static java.lang.object AoVDhsDXhFCTRWej(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static void BVuJPConikisbgoO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf6cdc5d8$pe4c3ba92 pf6cdc5d8_pe4c3ba92) {
        pf6cdc5d8_pe4c3ba92.cancel();
    }

    public static void CEOXsrQZUDSzQQKl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf6cdc5d8$pe4c3ba92 pf6cdc5d8_pe4c3ba92, java.lang.Exception th) {
        pf6cdc5d8_pe4c3ba92.onError(th);
    }

    public static void CIfbadzdVONqoWtm(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.lang.object DgxqvuLZXwuixdMq(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static bool EnpesRBYgmoAwjrv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf6cdc5d8$pe4c3ba92 pf6cdc5d8_pe4c3ba92, java.lang.object obj) {
        return pf6cdc5d8_pe4c3ba92.tryOnNext(obj);
    }

    public static java.lang.long FYntWlMtfjEfXkTt(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void ITeYjnOtXEomRwoL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf6cdc5d8$pe4c3ba92 pf6cdc5d8_pe4c3ba92, java.lang.Exception th) {
        pf6cdc5d8_pe4c3ba92.onError(th);
    }

    public static void JBcfBaClhNUVmQyh(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void JmokIeLXUZTUUSYp(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool LIISLrAXDdcuPlgY(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static java.lang.object MVHgmUIogQMdBdXV(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void NCBUWHcqUlWYEfzX(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void PxPksGfNNYBRPQrr(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void UPdrNSJkwtaEIPbW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf6cdc5d8$pe4c3ba92 pf6cdc5d8_pe4c3ba92) {
        pf6cdc5d8_pe4c3ba92.onComplete();
    }

    public static java.lang.object UwZrHSpFWwQLSgGD(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void ZfFedGSHQNBQfnbI(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void EKCqkNeZZCcuHvMK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf6cdc5d8$pe4c3ba92 pf6cdc5d8_pe4c3ba92) {
        pf6cdc5d8_pe4c3ba92.cancel();
    }

    public static void JmrcSNMVsfRccWOy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf6cdc5d8$pe4c3ba92 pf6cdc5d8_pe4c3ba92) {
        pf6cdc5d8_pe4c3ba92.cancel();
    }

    public static void RXaFsHlHDJPBArIB(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void UComZxJQpVfFOwLa(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static int XKIFrzwXqzphdrad(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9 p7f247dc9Var) {
        return p7f247dc9Var.ordinal();
    }

    public static void XbuwwUlsJUUIHRmX(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void YQKBZONppCCsDdTW(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public override void Cancel() {
        PxPksGfNNYBRPQrr(this.fbc3b0556);
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        JBcfBaClhNUVmQyh(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            yQKBZONppCCsDdTW(th);
        } else {
            this.f6b2ded51 = true;
            CIfbadzdVONqoWtm(this.fd22a0a80, th);
        }
    }

    public void OnNext(T t) {
        if ((4 + 26) % 26 > 0) {
        }
        if (EnpesRBYgmoAwjrv(this, t) || this.f6b2ded51) {
            return;
        }
        uComZxJQpVfFOwLa(this.fbc3b0556, 1L);
    }

    public void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (LIISLrAXDdcuPlgY(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            ZfFedGSHQNBQfnbI(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        NCBUWHcqUlWYEfzX(this.fbc3b0556, j);
    }

    public bool TryOnNext(T t) {
        int i;
        if ((25 + 24) % 24 > 0) {
        }
        if (this.f6b2ded51) {
            return false;
        }
        long j = 0;
        do {
            try {
                rXaFsHlHDJPBArIB(this.fd22a0a80, DgxqvuLZXwuixdMq(UwZrHSpFWwQLSgGD(this.f4b9f83e1, t), "The mapper returned a null value"));
                return true;
            } catch (java.lang.Exception th) {
                JmokIeLXUZTUUSYp(th);
                try {
                    j++;
                    i = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf6cdc5d8$1.$SwitchDictionary$io$reactivex$rxjava3$parallel$ParallelFailureHandling[xKIFrzwXqzphdrad((pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9) MVHgmUIogQMdBdXV(AoVDhsDXhFCTRWej(this.ff56352fa, FYntWlMtfjEfXkTt(j), th), "The errorHandler returned a null ParallelFailureHandling"))];
                } catch (java.lang.Exception th2) {
                    xbuwwUlsJUUIHRmX(th2);
                    eKCqkNeZZCcuHvMK(this);
                    java.lang.Exception[] thArr = new java.lang.Exception[2];
                    thArr[0] = th;
                    thArr[1] = th2;
                    ITeYjnOtXEomRwoL(this, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
                    return false;
                }
            }
        } while (i == 1);
        if (i != 2) {
            if (i != 3) {
                BVuJPConikisbgoO(this);
                CEOXsrQZUDSzQQKl(this, th);
                return false;
            }
            jmrcSNMVsfRccWOy(this);
            UPdrNSJkwtaEIPbW(this);
        }
        return false;
    }
}

