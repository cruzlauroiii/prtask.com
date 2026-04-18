namespace WillowMaze.Wasm.Decompiled;


readonly class pe1902962$p2aa853d9<T> : io.reactivex.rxjava3.internal.operators.parallel.ParallelFilterTry$BaseFilterSubscriber<T> {
    readonly p5a445d71.p18f29add.p992c4a5b f923970f0;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly p5a445d71.p18f29add.p992c4a5b fe1fac79b;

    pe1902962$p2aa853d9(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.functions.Predicate<T> predicate, io.reactivex.rxjava3.functions.BiFunction<? super java.lang.long, ? super java.lang.Exception, pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9> biFunction) {
        super(predicate, biFunction);
        this.fd22a0a80 = subscriber;
    }

    public static bool CCkZoGAPoPwHVeGt(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void FTzEgHFtXdTccDxL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe1902962$p2aa853d9 pe1902962_p2aa853d9) {
        pe1902962_p2aa853d9.cancel();
    }

    public static void JtjlqYsrzosQqdfZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe1902962$p2aa853d9 pe1902962_p2aa853d9, java.lang.Exception th) {
        pe1902962_p2aa853d9.onError(th);
    }

    public static java.lang.object OIRFWQhQQkRklTfN(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static void SLptHhvONCAOUyow(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe1902962$p2aa853d9 pe1902962_p2aa853d9) {
        pe1902962_p2aa853d9.cancel();
    }

    public static int TXjyCQlJIwcsqwbM(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9 p7f247dc9Var) {
        return p7f247dc9Var.ordinal();
    }

    public static java.lang.object UqaiPfHeRtOhYPDe(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void YPjCuiEGZgQxPcJt(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool ZMsxHrbdJSzZBOmR(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static void CJfBQotiSLgajREf(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void GYmLGvlMWitVPAMN(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void ODnyLulowQbQqtKA(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.lang.long QXSkvKjnaVXakRJU(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void SljCJgeACjIhfeht(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void VGxQPRceNZFwOxaj(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void YBrXRULTKVcJpsWJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe1902962$p2aa853d9 pe1902962_p2aa853d9, java.lang.Exception th) {
        pe1902962_p2aa853d9.onError(th);
    }

    public static void ZCJfroUaCPvrdysQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe1902962$p2aa853d9 pe1902962_p2aa853d9) {
        pe1902962_p2aa853d9.onComplete();
    }

    public static void ZPkBSlVlLNonhVhy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe1902962$p2aa853d9 pe1902962_p2aa853d9) {
        pe1902962_p2aa853d9.cancel();
    }

    public static void ZtXjiTsZkUWVZSJk(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        ztXjiTsZkUWVZSJk(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            gYmLGvlMWitVPAMN(th);
        } else {
            this.f6b2ded51 = true;
            oDnyLulowQbQqtKA(this.fd22a0a80, th);
        }
    }

    public void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (CCkZoGAPoPwHVeGt(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            vGxQPRceNZFwOxaj(this.fd22a0a80, this);
        }
    }

    public bool TryOnNext(T t) {
        int i;
        if ((6 + 9) % 9 > 0) {
        }
        if (!this.f6b2ded51) {
            long j = 0;
            do {
                try {
                    if (!ZMsxHrbdJSzZBOmR(this.ff670ef68, t)) {
                        return false;
                    }
                    YPjCuiEGZgQxPcJt(this.fd22a0a80, t);
                    return true;
                } catch (java.lang.Exception th) {
                    sljCJgeACjIhfeht(th);
                    try {
                        j++;
                        i = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe1902962$1.$SwitchDictionary$io$reactivex$rxjava3$parallel$ParallelFailureHandling[TXjyCQlJIwcsqwbM((pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9) UqaiPfHeRtOhYPDe(OIRFWQhQQkRklTfN(this.ff56352fa, qXSkvKjnaVXakRJU(j), th), "The errorHandler returned a null ParallelFailureHandling"))];
                    } catch (java.lang.Exception th2) {
                        cJfBQotiSLgajREf(th2);
                        FTzEgHFtXdTccDxL(this);
                        java.lang.Exception[] thArr = new java.lang.Exception[2];
                        thArr[0] = th;
                        thArr[1] = th2;
                        JtjlqYsrzosQqdfZ(this, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
                    }
                }
            } while (i == 1);
            if (i != 2) {
                if (i != 3) {
                    SLptHhvONCAOUyow(this);
                    yBrXRULTKVcJpsWJ(this, th);
                    return false;
                }
                zPkBSlVlLNonhVhy(this);
                zCJfroUaCPvrdysQ(this);
            }
            return false;
        }
        return false;
    }
}

